namespace RightNova
{
    partial class ExtendAPI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DecimalTrackbar = new TrackBar();
            HexadecimalValue = new TextBox();
            HexadecimalLabel = new Label();
            DecimalLabel = new Label();
            DecimalValue = new TextBox();
            label1 = new Label();
            HexadecimalTrackbar = new TrackBar();
            ApplyButton = new Button();
            BoxIntPtr = new CheckBox();
            BoxMarshal = new CheckBox();
            Boxuint = new CheckBox();
            BoxSHGFI = new CheckBox();
            BoxDWORD = new CheckBox();
            BoxBool = new CheckBox();
            radioHandles = new RadioButton();
            radioBuffers = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)DecimalTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HexadecimalTrackbar).BeginInit();
            SuspendLayout();
            // 
            // DecimalTrackbar
            // 
            DecimalTrackbar.Location = new Point(12, 33);
            DecimalTrackbar.Maximum = 20;
            DecimalTrackbar.Name = "DecimalTrackbar";
            DecimalTrackbar.Size = new Size(372, 45);
            DecimalTrackbar.TabIndex = 1;
            DecimalTrackbar.Scroll += DecimalTrackbar_Scroll;
            // 
            // HexadecimalValue
            // 
            HexadecimalValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HexadecimalValue.Location = new Point(355, 124);
            HexadecimalValue.Name = "HexadecimalValue";
            HexadecimalValue.ReadOnly = true;
            HexadecimalValue.Size = new Size(29, 29);
            HexadecimalValue.TabIndex = 2;
            // 
            // HexadecimalLabel
            // 
            HexadecimalLabel.AutoSize = true;
            HexadecimalLabel.Location = new Point(243, 132);
            HexadecimalLabel.Name = "HexadecimalLabel";
            HexadecimalLabel.Size = new Size(106, 15);
            HexadecimalLabel.TabIndex = 3;
            HexadecimalLabel.Text = "Hexadecimal Value";
            // 
            // DecimalLabel
            // 
            DecimalLabel.AutoSize = true;
            DecimalLabel.Location = new Point(12, 132);
            DecimalLabel.Name = "DecimalLabel";
            DecimalLabel.Size = new Size(81, 15);
            DecimalLabel.TabIndex = 4;
            DecimalLabel.Text = "Decimal Value";
            // 
            // DecimalValue
            // 
            DecimalValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DecimalValue.Location = new Point(99, 124);
            DecimalValue.Name = "DecimalValue";
            DecimalValue.ReadOnly = true;
            DecimalValue.Size = new Size(29, 29);
            DecimalValue.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 17);
            label1.TabIndex = 13;
            label1.Text = "Windows Marshalling Manager";
            // 
            // HexadecimalTrackbar
            // 
            HexadecimalTrackbar.Location = new Point(12, 84);
            HexadecimalTrackbar.Maximum = 20;
            HexadecimalTrackbar.Name = "HexadecimalTrackbar";
            HexadecimalTrackbar.Size = new Size(372, 45);
            HexadecimalTrackbar.TabIndex = 14;
            HexadecimalTrackbar.Scroll += HexadecimalTrackbar_Scroll;
            // 
            // ApplyButton
            // 
            ApplyButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplyButton.Location = new Point(244, 354);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(140, 30);
            ApplyButton.TabIndex = 16;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // BoxIntPtr
            // 
            BoxIntPtr.AutoSize = true;
            BoxIntPtr.Checked = true;
            BoxIntPtr.CheckState = CheckState.Checked;
            BoxIntPtr.Location = new Point(11, 170);
            BoxIntPtr.Name = "BoxIntPtr";
            BoxIntPtr.Size = new Size(55, 19);
            BoxIntPtr.TabIndex = 17;
            BoxIntPtr.Text = "IntPtr";
            BoxIntPtr.UseVisualStyleBackColor = true;
            // 
            // BoxMarshal
            // 
            BoxMarshal.AutoSize = true;
            BoxMarshal.Checked = true;
            BoxMarshal.CheckState = CheckState.Checked;
            BoxMarshal.Location = new Point(71, 170);
            BoxMarshal.Name = "BoxMarshal";
            BoxMarshal.Size = new Size(68, 19);
            BoxMarshal.TabIndex = 18;
            BoxMarshal.Text = "Marshal";
            BoxMarshal.UseVisualStyleBackColor = true;
            // 
            // Boxuint
            // 
            Boxuint.AutoSize = true;
            Boxuint.Checked = true;
            Boxuint.CheckState = CheckState.Checked;
            Boxuint.Location = new Point(141, 169);
            Boxuint.Name = "Boxuint";
            Boxuint.Size = new Size(47, 19);
            Boxuint.TabIndex = 19;
            Boxuint.Text = "uint";
            Boxuint.UseVisualStyleBackColor = true;
            // 
            // BoxSHGFI
            // 
            BoxSHGFI.AutoSize = true;
            BoxSHGFI.Checked = true;
            BoxSHGFI.CheckState = CheckState.Checked;
            BoxSHGFI.Location = new Point(194, 170);
            BoxSHGFI.Name = "BoxSHGFI";
            BoxSHGFI.Size = new Size(58, 19);
            BoxSHGFI.TabIndex = 20;
            BoxSHGFI.Text = "SHGFI";
            BoxSHGFI.UseVisualStyleBackColor = true;
            // 
            // BoxDWORD
            // 
            BoxDWORD.AutoSize = true;
            BoxDWORD.Location = new Point(258, 170);
            BoxDWORD.Name = "BoxDWORD";
            BoxDWORD.Size = new Size(75, 19);
            BoxDWORD.TabIndex = 21;
            BoxDWORD.Text = "DWORDS";
            BoxDWORD.UseVisualStyleBackColor = true;
            // 
            // BoxBool
            // 
            BoxBool.AutoSize = true;
            BoxBool.Checked = true;
            BoxBool.CheckState = CheckState.Checked;
            BoxBool.Location = new Point(339, 170);
            BoxBool.Name = "BoxBool";
            BoxBool.Size = new Size(57, 19);
            BoxBool.TabIndex = 22;
            BoxBool.Text = "BOOL";
            BoxBool.UseVisualStyleBackColor = true;
            // 
            // radioHandles
            // 
            radioHandles.AutoSize = true;
            radioHandles.Location = new Point(11, 215);
            radioHandles.Name = "radioHandles";
            radioHandles.Size = new Size(143, 19);
            radioHandles.TabIndex = 23;
            radioHandles.TabStop = true;
            radioHandles.Text = "ALLOW ALL HANDLES";
            radioHandles.UseVisualStyleBackColor = true;
            // 
            // radioBuffers
            // 
            radioBuffers.AutoSize = true;
            radioBuffers.Checked = true;
            radioBuffers.Location = new Point(161, 215);
            radioBuffers.Name = "radioBuffers";
            radioBuffers.Size = new Size(137, 19);
            radioBuffers.TabIndex = 24;
            radioBuffers.TabStop = true;
            radioBuffers.Text = "ALLOW ALL BUFFERS";
            radioBuffers.UseVisualStyleBackColor = true;
            // 
            // ExtendAPI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 396);
            Controls.Add(radioBuffers);
            Controls.Add(radioHandles);
            Controls.Add(BoxBool);
            Controls.Add(BoxDWORD);
            Controls.Add(BoxSHGFI);
            Controls.Add(Boxuint);
            Controls.Add(BoxMarshal);
            Controls.Add(BoxIntPtr);
            Controls.Add(ApplyButton);
            Controls.Add(HexadecimalTrackbar);
            Controls.Add(label1);
            Controls.Add(DecimalValue);
            Controls.Add(DecimalLabel);
            Controls.Add(HexadecimalLabel);
            Controls.Add(HexadecimalValue);
            Controls.Add(DecimalTrackbar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExtendAPI";
            Text = "Extend Windows API";
            Load += ExtendAPI_Load;
            ((System.ComponentModel.ISupportInitialize)DecimalTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)HexadecimalTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar DecimalTrackbar;
        private TextBox HexadecimalValue;
        private Label HexadecimalLabel;
        private Label DecimalLabel;
        private TextBox DecimalValue;
        private RadioButton radioButton2;
        private Label label1;
        private TrackBar HexadecimalTrackbar;
        private Button ApplyButton;
        private CheckBox BoxIntPtr;
        private CheckBox BoxMarshal;
        private CheckBox Boxuint;
        private CheckBox BoxSHGFI;
        private CheckBox BoxDWORD;
        private CheckBox BoxBool;
        private RadioButton radioHandles;
        private RadioButton radioBuffers;
    }
}