namespace PCDMapper
{
    partial class AddMapping
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.partNumberInput = new System.Windows.Forms.TextBox();
            this.groupInput = new System.Windows.Forms.TextBox();
            this.configInput = new System.Windows.Forms.TextBox();
            this.phaseInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.addmapToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(12, 90);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(336, 20);
            this.titleInput.TabIndex = 1;
            this.addmapToolTip.SetToolTip(this.titleInput, "Reference Name for the mapping.");
            // 
            // partNumberInput
            // 
            this.partNumberInput.Location = new System.Drawing.Point(12, 139);
            this.partNumberInput.Name = "partNumberInput";
            this.partNumberInput.Size = new System.Drawing.Size(336, 20);
            this.partNumberInput.TabIndex = 2;
            this.addmapToolTip.SetToolTip(this.partNumberInput, "Part Number of the unit which will be matched and provided to PCDoctor.");
            // 
            // groupInput
            // 
            this.groupInput.Location = new System.Drawing.Point(12, 100);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(336, 20);
            this.groupInput.TabIndex = 3;
            this.addmapToolTip.SetToolTip(this.groupInput, "Group of the mapped script in the PCDoctor Config. Usually Clients name. Ex. Magn" +
        "etic Must match PCDoctor exactly.");
            // 
            // configInput
            // 
            this.configInput.Location = new System.Drawing.Point(12, 151);
            this.configInput.Name = "configInput";
            this.configInput.Size = new System.Drawing.Size(336, 20);
            this.configInput.TabIndex = 4;
            this.addmapToolTip.SetToolTip(this.configInput, "Configuration of the mapped script in the PCDoctor Config. Usually CEX Partnumber" +
        " name. Ex. 10009455. Must match PCDoctor exactly.");
            // 
            // phaseInput
            // 
            this.phaseInput.Location = new System.Drawing.Point(12, 204);
            this.phaseInput.Name = "phaseInput";
            this.phaseInput.Size = new System.Drawing.Size(336, 20);
            this.phaseInput.TabIndex = 5;
            this.addmapToolTip.SetToolTip(this.phaseInput, "Phase of the mapped script in the PCDoctor Config. Can be used to separate revisi" +
        "ons or special cases. Ex. Rev A or 1U, etc.. Must match PCDoctor exactly.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Part Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Configuration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phase";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(211, 234);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(138, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addmapToolTip.SetToolTip(this.addButton, "Adds the mapping to master Mappings.xml file.");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.partNumberInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.titleInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 169);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.MaximumSize = new System.Drawing.Size(350, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 52);
            this.label7.TabIndex = 13;
            this.label7.Text = "This section collects the information neccessary for matching user provided part " +
    "number to mappings in Mappings.xml file.\r\n\r\nTitle field is only used for identif" +
    "ication.";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.phaseInput);
            this.panel2.Controls.Add(this.groupInput);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.configInput);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 269);
            this.panel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.MaximumSize = new System.Drawing.Size(350, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 52);
            this.label6.TabIndex = 12;
            this.label6.Text = "This section collects the necessary mapping information. \r\n\r\nThese fields must ma" +
    "tch the mappings added in PCDoctor Config section exactly as they appear.";
            // 
            // AddMapping
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddMapping";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Mapping";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox partNumberInput;
        private System.Windows.Forms.TextBox groupInput;
        private System.Windows.Forms.TextBox configInput;
        private System.Windows.Forms.TextBox phaseInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip addmapToolTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}