﻿namespace PCDMapper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnTextBox = new System.Windows.Forms.TextBox();
            this.pnLabel = new System.Windows.Forms.Label();
            this.snLabel = new System.Windows.Forms.Label();
            this.snTextBox = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testerName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matchStatusLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCDoctorToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runADHOCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTextBox
            // 
            this.pnTextBox.Location = new System.Drawing.Point(11, 156);
            this.pnTextBox.Name = "pnTextBox";
            this.pnTextBox.Size = new System.Drawing.Size(177, 20);
            this.pnTextBox.TabIndex = 1;
            this.mainFormToolTips.SetToolTip(this.pnTextBox, "Part Number of the unit you are testing, used to find the necessary test script b" +
        "inding.");
            this.pnTextBox.TextChanged += new System.EventHandler(this.pnTextBox_TextChanged);
            // 
            // pnLabel
            // 
            this.pnLabel.AutoSize = true;
            this.pnLabel.Location = new System.Drawing.Point(11, 139);
            this.pnLabel.Name = "pnLabel";
            this.pnLabel.Size = new System.Drawing.Size(70, 13);
            this.pnLabel.TabIndex = 1;
            this.pnLabel.Text = "Part Number*";
            // 
            // snLabel
            // 
            this.snLabel.AutoSize = true;
            this.snLabel.Location = new System.Drawing.Point(191, 139);
            this.snLabel.Name = "snLabel";
            this.snLabel.Size = new System.Drawing.Size(77, 13);
            this.snLabel.TabIndex = 3;
            this.snLabel.Text = "Serial Number*";
            // 
            // snTextBox
            // 
            this.snTextBox.Location = new System.Drawing.Point(194, 155);
            this.snTextBox.Name = "snTextBox";
            this.snTextBox.Size = new System.Drawing.Size(146, 20);
            this.snTextBox.TabIndex = 2;
            this.mainFormToolTips.SetToolTip(this.snTextBox, "Serial Number of the unit being tested as it will appear on the test report.");
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(355, 153);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 27);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start PCD";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            this.startBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startBtn_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Part Number and Serial Number of the machine you are about to run PCDoctor " +
    "on.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tester";
            // 
            // testerName
            // 
            this.testerName.Location = new System.Drawing.Point(11, 104);
            this.testerName.Name = "testerName";
            this.testerName.Size = new System.Drawing.Size(177, 20);
            this.testerName.TabIndex = 0;
            this.mainFormToolTips.SetToolTip(this.testerName, "Tester Name as It will appear on the test report.");
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.matchStatusLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.snLabel);
            this.panel1.Controls.Add(this.pnLabel);
            this.panel1.Controls.Add(this.snTextBox);
            this.panel1.Controls.Add(this.pnTextBox);
            this.panel1.Controls.Add(this.testerName);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 210);
            this.panel1.TabIndex = 8;
            // 
            // matchStatusLabel
            // 
            this.matchStatusLabel.AutoSize = true;
            this.matchStatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.matchStatusLabel.Location = new System.Drawing.Point(12, 186);
            this.matchStatusLabel.Name = "matchStatusLabel";
            this.matchStatusLabel.Size = new System.Drawing.Size(49, 13);
            this.matchStatusLabel.TabIndex = 8;
            this.matchStatusLabel.Text = "Matched";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCDoctorToolsToolStripMenuItem,
            this.runADHOCToolStripMenuItem,
            this.newMappingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newMappingToolStripMenuItem
            // 
            this.newMappingToolStripMenuItem.Name = "newMappingToolStripMenuItem";
            this.newMappingToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.newMappingToolStripMenuItem.Text = "New Mapping";
            this.newMappingToolStripMenuItem.Click += new System.EventHandler(this.newMappingToolStripMenuItem_Click);
            // 
            // pCDoctorToolsToolStripMenuItem
            // 
            this.pCDoctorToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptGenerationToolStripMenuItem});
            this.pCDoctorToolsToolStripMenuItem.Name = "pCDoctorToolsToolStripMenuItem";
            this.pCDoctorToolsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.pCDoctorToolsToolStripMenuItem.Text = "PCDoctor Tools";
            // 
            // scriptGenerationToolStripMenuItem
            // 
            this.scriptGenerationToolStripMenuItem.Name = "scriptGenerationToolStripMenuItem";
            this.scriptGenerationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scriptGenerationToolStripMenuItem.Text = "Generate Script Log";
            this.scriptGenerationToolStripMenuItem.Click += new System.EventHandler(this.scriptGenerationToolStripMenuItem_Click);
            // 
            // runADHOCToolStripMenuItem
            // 
            this.runADHOCToolStripMenuItem.Name = "runADHOCToolStripMenuItem";
            this.runADHOCToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.runADHOCToolStripMenuItem.Text = "Run Unmapped";
            this.runADHOCToolStripMenuItem.Click += new System.EventHandler(this.runADHOCToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 210);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PCD Mapper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pnTextBox;
        private System.Windows.Forms.Label pnLabel;
        private System.Windows.Forms.Label snLabel;
        private System.Windows.Forms.TextBox snTextBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox testerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label matchStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCDoctorToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runADHOCToolStripMenuItem;
        private System.Windows.Forms.ToolTip mainFormToolTips;
    }
}

