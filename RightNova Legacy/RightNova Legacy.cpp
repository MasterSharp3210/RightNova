#include <windows.h>
#include <iostream>
#include <string>
#include <sstream>
#include <fstream>
#include <wbemidl.h>
#include <comdef.h>
#include <wincrypt.h>

#pragma comment(lib, "wbemuuid.lib")
#pragma comment(lib, "advapi32.lib")

using namespace std;

string WMI(const wstring& query, const wstring& prop)
{
    IWbemLocator* loc = NULL;
    IWbemServices* svc = NULL;
    IEnumWbemClassObject* en = NULL;

    CoInitializeEx(0, COINIT_MULTITHREADED);
    CoInitializeSecurity(NULL, -1, NULL, NULL, RPC_C_AUTHN_LEVEL_DEFAULT,
        RPC_C_IMP_LEVEL_IMPERSONATE, NULL, EOAC_NONE, NULL);

    CoCreateInstance(CLSID_WbemLocator, 0, CLSCTX_INPROC_SERVER,
        IID_IWbemLocator, (LPVOID*)&loc);

    loc->ConnectServer(_bstr_t(L"ROOT\\CIMV2"), NULL, NULL, 0, NULL, 0, 0, &svc);

    svc->ExecQuery(bstr_t("WQL"), bstr_t(query.c_str()),
        WBEM_FLAG_FORWARD_ONLY | WBEM_FLAG_RETURN_IMMEDIATELY,
        NULL, &en);

    IWbemClassObject* obj = NULL;
    ULONG ret = 0;
    string out;

    if (en->Next(WBEM_INFINITE, 1, &obj, &ret) == S_OK)
    {
        VARIANT v;
        obj->Get(prop.c_str(), 0, &v, 0, 0);

        if (v.vt == VT_BSTR && v.bstrVal)
        {
            out = _bstr_t(v.bstrVal);
        }
        else if (v.vt == VT_I4)
        {
            out = to_string(v.intVal);
        }
        else if (v.vt == VT_UI4)
        {
            out = to_string(v.uintVal);
        }
        else
        {
            out = "";
        }

        VariantClear(&v);
    }

    return out;
}

string OSInfo()
{
    return WMI(L"SELECT Caption FROM Win32_OperatingSystem", L"Caption");
}

string GetComputerNameStr()
{
    char buffer[256];
    DWORD size = 256;
    GetComputerNameA(buffer, &size);
    return buffer;
}

string GetDomainName()
{
    char buffer[256];
    DWORD size = 256;
    GetUserNameA(buffer, &size);
    return buffer;
}

string CPUInfo()
{
    return WMI(L"SELECT Name FROM Win32_Processor", L"Name");
}

string CoreThreadsInfo()
{
    return "Cores: " + WMI(L"SELECT NumberOfCores FROM Win32_Processor", L"NumberOfCores") +
        " / Threads: " + WMI(L"SELECT NumberOfLogicalProcessors FROM Win32_Processor", L"NumberOfLogicalProcessors");
}

string RAMInfo()
{
    string kb = WMI(
        L"SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem",
        L"TotalVisibleMemorySize"
    );

    double gb = _strtoui64(kb.c_str(), NULL, 10) / (1024.0 * 1024.0);

    stringstream ss;
    ss.setf(std::ios::fixed);
    ss.precision(1);
    ss << gb << " GB";

    return ss.str();
}

string FormatSize(unsigned long long bytes)
{
    double size = (double)bytes;

    const double KB = 1024.0;
    const double MB = KB * 1024.0;
    const double GB = MB * 1024.0;
    const double TB = GB * 1024.0;

    stringstream ss;
    ss.setf(std::ios::fixed);
    ss.precision(1);

    if (size >= TB)
    {
        ss << (size / TB) << " TB";
    }
    else if (size >= GB)
    {
        ss << (size / GB) << " GB";
    }
    else if (size >= MB)
    {
        ss << (size / MB) << " MB";
    }
    else if (size >= KB)
    {
        ss << (size / KB) << " KB";
    }
    else
    {
        ss << size << " B";
    }

    return ss.str();
}

string DiskInfo()
{
    ULARGE_INTEGER freeBytes, totalBytes, availBytes;

    GetDiskFreeSpaceExA("C:\\", &availBytes, &totalBytes, &freeBytes);

    string free = FormatSize(freeBytes.QuadPart);
    string total = FormatSize(totalBytes.QuadPart);

    return free + " free of " + total;
}

string GPUInfo()
{
    return WMI(L"SELECT Name FROM Win32_VideoController", L"Name");
}

string MotherboardInfo()
{
    return WMI(L"SELECT Product FROM Win32_BaseBoard", L"Product");
}

string BIOSInfo()
{
    return WMI(L"SELECT SMBIOSBIOSVersion FROM Win32_BIOS", L"SMBIOSBIOSVersion");
}

string GetVolume()
{
    return WMI(L"SELECT VolumeSerialNumber FROM Win32_LogicalDisk WHERE DeviceID='C:'", L"VolumeSerialNumber");
}

string ComputeSHA1(string input)
{
    HCRYPTPROV prov;
    HCRYPTHASH hash;
    BYTE data[20];
    DWORD size = 20;
    string out;

    CryptAcquireContext(&prov, NULL, NULL, PROV_RSA_FULL, CRYPT_VERIFYCONTEXT);
    CryptCreateHash(prov, CALG_SHA1, 0, 0, &hash);
    CryptHashData(hash, (BYTE*)input.c_str(), input.size(), 0);
    CryptGetHashParam(hash, HP_HASHVAL, data, &size, 0);

    char buf[3];
    for (DWORD i = 0; i < size; i++)
    {
        sprintf_s(buf, "%02X", data[i]);
        out += buf;
    }

    CryptDestroyHash(hash);
    CryptReleaseContext(prov, 0);

    return out;
}

string HWIDInfo()
{
    return ComputeSHA1(CPUInfo() + BIOSInfo() + MotherboardInfo() + GetVolume());
}

string ExePath()
{
    char buffer[MAX_PATH];
    GetModuleFileNameA(NULL, buffer, MAX_PATH);
    string p(buffer);
    return p.substr(0, p.find_last_of("\\/"));
}

void RightNova_Load()
{
    string os = OSInfo();
    string comp = "Computer Name: " + GetComputerNameStr();
    string dom = "Domain Name: " + GetDomainName();
    string cpu = "CPU: " + CPUInfo();
    string core = "Cores and Threads: " + CoreThreadsInfo();
    string ram = "RAM: " + RAMInfo();
    string disk = DiskInfo();
    string gpu = "GPU: " + GPUInfo();
    string mb = "Motherboard: " + MotherboardInfo();
    string bios = "BIOS: " + BIOSInfo();
    string hwid = "HWID: " + HWIDInfo();

    cout << "---------------------------------------------------------------------------------------------------------------------\r\n"
        << "Operating System: " << os << "\r\n"
        << comp << "\r\n"
        << dom << "\r\n"
        << "---------------------------------------------------------------------------------------------------------------------\r\n"
        << cpu << "\r\n"
        << core << "\r\n"
        << ram << "\r\n"
        << "Disk Space (C:): " << disk << "\r\n"
        << "---------------------------------------------------------------------------------------------------------------------\r\n"
        << gpu << "\r\n"
        << mb << "\r\n"
        << bios << "\r\n"
        << "---------------------------------------------------------------------------------------------------------------------\r\n"
		<< hwid << "\r\n"
		<< "---------------------------------------------------------------------------------------------------------------------\r\n";
        

    ofstream file(ExePath() + "\\sys_info.txt");

    file << "Operating System: " << os << "\r\n"
        << comp << "\r\n"
        << dom << "\r\n"
        << "---------------------------------------------------------------------------------------------------------------------\r\n"
        << cpu << "\r\n"
        << core << "\r\n"
        << ram << "\r\n"
        << "Disk Space (C:): " + disk << "\r\n"
        << "---------------------------------------------------------------------------------------------------------------------\r\n"
        << gpu << "\r\n"
        << mb << "\r\n"
        << bios << "\r\n"
        << "---------------------------------------------------------------------------------------------------------------------\r\n"
        << hwid;

    file.close();
}

int main()
{
    RightNova_Load();
    system("pause");
    return 0;
}