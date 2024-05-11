namespace CompTemp
{
    partial class CompTemp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompTemp));
            lblInfo = new Label();
            lblModel = new Label();
            lblCore = new Label();
            lblThread = new Label();
            txtModel = new TextBox();
            txtCore = new TextBox();
            txtThread = new TextBox();
            txtMotherboard = new TextBox();
            txtGpu = new TextBox();
            txtRam1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRam2 = new TextBox();
            txtRam3 = new TextBox();
            label6 = new Label();
            txtMakeMB = new TextBox();
            lblMake = new Label();
            label7 = new Label();
            label8 = new Label();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            fileReload = new ToolStripMenuItem();
            grpCpu = new GroupBox();
            txtCpuTemp = new TextBox();
            label10 = new Label();
            grpMotherboard = new GroupBox();
            grpGpu = new GroupBox();
            txtGpuTemp = new TextBox();
            label11 = new Label();
            grpRam = new GroupBox();
            label9 = new Label();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            grpCpu.SuspendLayout();
            grpMotherboard.SuspendLayout();
            grpGpu.SuspendLayout();
            grpRam.SuspendLayout();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(50, 11);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(30, 15);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "CPU";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(3, 31);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(44, 15);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model:";
            // 
            // lblCore
            // 
            lblCore.AutoSize = true;
            lblCore.Location = new Point(-1, 57);
            lblCore.Name = "lblCore";
            lblCore.Size = new Size(48, 15);
            lblCore.TabIndex = 4;
            lblCore.Text = "Core(s):";
            // 
            // lblThread
            // 
            lblThread.AutoSize = true;
            lblThread.Location = new Point(90, 57);
            lblThread.Name = "lblThread";
            lblThread.Size = new Size(59, 15);
            lblThread.TabIndex = 5;
            lblThread.Text = "Thread(s):";
            // 
            // txtModel
            // 
            txtModel.BackColor = SystemColors.MenuBar;
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtModel.ForeColor = SystemColors.InfoText;
            txtModel.Location = new Point(53, 29);
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = true;
            txtModel.Size = new Size(263, 21);
            txtModel.TabIndex = 1;
            // 
            // txtCore
            // 
            txtCore.BackColor = SystemColors.MenuBar;
            txtCore.BorderStyle = BorderStyle.FixedSingle;
            txtCore.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCore.ForeColor = SystemColors.InfoText;
            txtCore.Location = new Point(53, 54);
            txtCore.Name = "txtCore";
            txtCore.ReadOnly = true;
            txtCore.Size = new Size(31, 21);
            txtCore.TabIndex = 2;
            // 
            // txtThread
            // 
            txtThread.BackColor = SystemColors.MenuBar;
            txtThread.BorderStyle = BorderStyle.FixedSingle;
            txtThread.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtThread.ForeColor = SystemColors.InfoText;
            txtThread.Location = new Point(155, 54);
            txtThread.Name = "txtThread";
            txtThread.ReadOnly = true;
            txtThread.Size = new Size(31, 21);
            txtThread.TabIndex = 3;
            // 
            // txtMotherboard
            // 
            txtMotherboard.BackColor = SystemColors.MenuBar;
            txtMotherboard.BorderStyle = BorderStyle.FixedSingle;
            txtMotherboard.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMotherboard.ForeColor = SystemColors.InfoText;
            txtMotherboard.Location = new Point(51, 53);
            txtMotherboard.Name = "txtMotherboard";
            txtMotherboard.ReadOnly = true;
            txtMotherboard.Size = new Size(263, 21);
            txtMotherboard.TabIndex = 6;
            // 
            // txtGpu
            // 
            txtGpu.BackColor = SystemColors.MenuBar;
            txtGpu.BorderStyle = BorderStyle.FixedSingle;
            txtGpu.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGpu.ForeColor = SystemColors.InfoText;
            txtGpu.Location = new Point(54, 29);
            txtGpu.Name = "txtGpu";
            txtGpu.ReadOnly = true;
            txtGpu.Size = new Size(263, 21);
            txtGpu.TabIndex = 7;
            // 
            // txtRam1
            // 
            txtRam1.BackColor = SystemColors.MenuBar;
            txtRam1.BorderStyle = BorderStyle.FixedSingle;
            txtRam1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRam1.ForeColor = SystemColors.InfoText;
            txtRam1.Location = new Point(54, 30);
            txtRam1.Name = "txtRam1";
            txtRam1.ReadOnly = true;
            txtRam1.Size = new Size(263, 21);
            txtRam1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 16;
            label1.Text = "Motherboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 55);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 17;
            label2.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 11);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 18;
            label3.Text = "Gpu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 31);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 19;
            label4.Text = "Model:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 372);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 20;
            label5.Text = "Ram";
            // 
            // txtRam2
            // 
            txtRam2.BackColor = SystemColors.MenuBar;
            txtRam2.BorderStyle = BorderStyle.FixedSingle;
            txtRam2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRam2.ForeColor = SystemColors.InfoText;
            txtRam2.Location = new Point(54, 53);
            txtRam2.Name = "txtRam2";
            txtRam2.ReadOnly = true;
            txtRam2.Size = new Size(263, 21);
            txtRam2.TabIndex = 10;
            // 
            // txtRam3
            // 
            txtRam3.BackColor = SystemColors.MenuBar;
            txtRam3.BorderStyle = BorderStyle.FixedSingle;
            txtRam3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRam3.ForeColor = SystemColors.InfoText;
            txtRam3.Location = new Point(54, 76);
            txtRam3.Name = "txtRam3";
            txtRam3.ReadOnly = true;
            txtRam3.Size = new Size(263, 21);
            txtRam3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 32);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 23;
            label6.Text = "Make:";
            // 
            // txtMakeMB
            // 
            txtMakeMB.BackColor = SystemColors.MenuBar;
            txtMakeMB.BorderStyle = BorderStyle.FixedSingle;
            txtMakeMB.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMakeMB.ForeColor = SystemColors.InfoText;
            txtMakeMB.Location = new Point(51, 27);
            txtMakeMB.Name = "txtMakeMB";
            txtMakeMB.ReadOnly = true;
            txtMakeMB.Size = new Size(263, 21);
            txtMakeMB.TabIndex = 5;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(6, 29);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(39, 15);
            lblMake.TabIndex = 25;
            lblMake.Text = "Make:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 55);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 26;
            label7.Text = "Size:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 78);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 27;
            label8.Text = "Speed:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(367, 25);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuExit, fileReload });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(39, 21);
            menuFile.Text = "File";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(180, 22);
            menuExit.Text = "Exit";
            menuExit.Click += menuExit_Click;
            // 
            // fileReload
            // 
            fileReload.Name = "fileReload";
            fileReload.Size = new Size(180, 22);
            fileReload.Text = "Reload";
            fileReload.Click += fileReload_Click;
            // 
            // grpCpu
            // 
            grpCpu.BackColor = Color.Transparent;
            grpCpu.Controls.Add(txtCpuTemp);
            grpCpu.Controls.Add(label10);
            grpCpu.Controls.Add(txtModel);
            grpCpu.Controls.Add(lblInfo);
            grpCpu.Controls.Add(lblCore);
            grpCpu.Controls.Add(lblThread);
            grpCpu.Controls.Add(txtThread);
            grpCpu.Controls.Add(lblModel);
            grpCpu.Controls.Add(txtCore);
            grpCpu.Location = new Point(13, 28);
            grpCpu.Name = "grpCpu";
            grpCpu.Size = new Size(339, 86);
            grpCpu.TabIndex = 29;
            grpCpu.TabStop = false;
            // 
            // txtCpuTemp
            // 
            txtCpuTemp.BackColor = SystemColors.MenuBar;
            txtCpuTemp.BorderStyle = BorderStyle.FixedSingle;
            txtCpuTemp.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpuTemp.ForeColor = SystemColors.InfoText;
            txtCpuTemp.Location = new Point(237, 54);
            txtCpuTemp.Name = "txtCpuTemp";
            txtCpuTemp.Size = new Size(31, 21);
            txtCpuTemp.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(192, 57);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 34;
            label10.Text = "Temp:";
            // 
            // grpMotherboard
            // 
            grpMotherboard.Controls.Add(txtMakeMB);
            grpMotherboard.Controls.Add(txtMotherboard);
            grpMotherboard.Controls.Add(label1);
            grpMotherboard.Controls.Add(label2);
            grpMotherboard.Controls.Add(lblMake);
            grpMotherboard.Location = new Point(12, 120);
            grpMotherboard.Name = "grpMotherboard";
            grpMotherboard.Size = new Size(340, 84);
            grpMotherboard.TabIndex = 30;
            grpMotherboard.TabStop = false;
            // 
            // grpGpu
            // 
            grpGpu.Controls.Add(txtGpuTemp);
            grpGpu.Controls.Add(txtGpu);
            grpGpu.Controls.Add(label11);
            grpGpu.Controls.Add(label3);
            grpGpu.Controls.Add(label4);
            grpGpu.Location = new Point(12, 212);
            grpGpu.Name = "grpGpu";
            grpGpu.Size = new Size(340, 83);
            grpGpu.TabIndex = 31;
            grpGpu.TabStop = false;
            // 
            // txtGpuTemp
            // 
            txtGpuTemp.BackColor = SystemColors.MenuBar;
            txtGpuTemp.BorderStyle = BorderStyle.FixedSingle;
            txtGpuTemp.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGpuTemp.ForeColor = SystemColors.InfoText;
            txtGpuTemp.Location = new Point(54, 53);
            txtGpuTemp.Name = "txtGpuTemp";
            txtGpuTemp.ReadOnly = true;
            txtGpuTemp.Size = new Size(31, 21);
            txtGpuTemp.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 55);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 36;
            label11.Text = "Temp:";
            // 
            // grpRam
            // 
            grpRam.Controls.Add(label9);
            grpRam.Controls.Add(txtRam1);
            grpRam.Controls.Add(txtRam2);
            grpRam.Controls.Add(txtRam3);
            grpRam.Controls.Add(label6);
            grpRam.Controls.Add(label8);
            grpRam.Controls.Add(label7);
            grpRam.Location = new Point(13, 312);
            grpRam.Name = "grpRam";
            grpRam.Size = new Size(339, 111);
            grpRam.TabIndex = 32;
            grpRam.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 12);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 20;
            label9.Text = "Ram";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(55, 21);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // CompTemp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 447);
            Controls.Add(grpRam);
            Controls.Add(grpGpu);
            Controls.Add(grpMotherboard);
            Controls.Add(grpCpu);
            Controls.Add(label5);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "CompTemp";
            Text = "Hardware Information";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpCpu.ResumeLayout(false);
            grpCpu.PerformLayout();
            grpMotherboard.ResumeLayout(false);
            grpMotherboard.PerformLayout();
            grpGpu.ResumeLayout(false);
            grpGpu.PerformLayout();
            grpRam.ResumeLayout(false);
            grpRam.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Label lblModel;
        private Label lblCore;
        private Label lblThread;
        private TextBox txtModel;
        private TextBox txtCore;
        private TextBox txtThread;
        private TextBox txtMotherboard;
        private TextBox txtGpu;
        private TextBox txtRam1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRam2;
        private TextBox txtRam3;
        private Label label6;
        private TextBox txtMakeMB;
        private Label lblMake;
        private Label label7;
        private Label label8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem fileReload;
        private GroupBox grpCpu;
        private GroupBox grpMotherboard;
        private GroupBox grpGpu;
        private GroupBox grpRam;
        private Label label9;
        private TextBox txtCpuTemp;
        private Label label10;
        private TextBox txtGpuTemp;
        private Label label11;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
