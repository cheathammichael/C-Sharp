namespace Joe_s_Automotive
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lubeJbChkBx = new System.Windows.Forms.CheckBox();
            this.oilChangeChkBx = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransFlshBx = new System.Windows.Forms.CheckBox();
            this.radFlshBx = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rotationBox = new System.Windows.Forms.CheckBox();
            this.mufflerBox = new System.Windows.Forms.CheckBox();
            this.inspecBx = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laborTxtBox = new System.Windows.Forms.TextBox();
            this.partsTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.servLabLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lubeJbChkBx);
            this.groupBox1.Controls.Add(this.oilChangeChkBx);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lubeJbChkBx
            // 
            this.lubeJbChkBx.AutoSize = true;
            this.lubeJbChkBx.Location = new System.Drawing.Point(6, 48);
            this.lubeJbChkBx.Name = "lubeJbChkBx";
            this.lubeJbChkBx.Size = new System.Drawing.Size(147, 21);
            this.lubeJbChkBx.TabIndex = 1;
            this.lubeJbChkBx.Text = "Lube Job ($18.00)";
            this.lubeJbChkBx.UseVisualStyleBackColor = true;
            this.lubeJbChkBx.CheckedChanged += new System.EventHandler(this.lubeJbChkBx_CheckedChanged);
            // 
            // oilChangeChkBx
            // 
            this.oilChangeChkBx.AutoSize = true;
            this.oilChangeChkBx.Location = new System.Drawing.Point(6, 21);
            this.oilChangeChkBx.Name = "oilChangeChkBx";
            this.oilChangeChkBx.Size = new System.Drawing.Size(158, 21);
            this.oilChangeChkBx.TabIndex = 0;
            this.oilChangeChkBx.Text = "Oil Change ($26.00)";
            this.oilChangeChkBx.UseVisualStyleBackColor = true;
            this.oilChangeChkBx.CheckedChanged += new System.EventHandler(this.oilChangeChkBx_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TransFlshBx);
            this.groupBox2.Controls.Add(this.radFlshBx);
            this.groupBox2.Location = new System.Drawing.Point(237, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // TransFlshBx
            // 
            this.TransFlshBx.AutoSize = true;
            this.TransFlshBx.Location = new System.Drawing.Point(6, 48);
            this.TransFlshBx.Name = "TransFlshBx";
            this.TransFlshBx.Size = new System.Drawing.Size(210, 21);
            this.TransFlshBx.TabIndex = 1;
            this.TransFlshBx.Text = "Transmission Flush ($80.00)";
            this.TransFlshBx.UseVisualStyleBackColor = true;
            this.TransFlshBx.CheckedChanged += new System.EventHandler(this.TransFlshBx_CheckedChanged);
            // 
            // radFlshBx
            // 
            this.radFlshBx.AutoSize = true;
            this.radFlshBx.Location = new System.Drawing.Point(6, 21);
            this.radFlshBx.Name = "radFlshBx";
            this.radFlshBx.Size = new System.Drawing.Size(180, 21);
            this.radFlshBx.TabIndex = 0;
            this.radFlshBx.Text = "Radiator Flush ($30.00)";
            this.radFlshBx.UseVisualStyleBackColor = true;
            this.radFlshBx.CheckedChanged += new System.EventHandler(this.radFlshBx_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rotationBox);
            this.groupBox3.Controls.Add(this.mufflerBox);
            this.groupBox3.Controls.Add(this.inspecBx);
            this.groupBox3.Location = new System.Drawing.Point(12, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rotationBox
            // 
            this.rotationBox.AutoSize = true;
            this.rotationBox.Location = new System.Drawing.Point(6, 75);
            this.rotationBox.Name = "rotationBox";
            this.rotationBox.Size = new System.Drawing.Size(170, 21);
            this.rotationBox.TabIndex = 2;
            this.rotationBox.Text = "Tire Rotation ($20.00)";
            this.rotationBox.UseVisualStyleBackColor = true;
            this.rotationBox.CheckedChanged += new System.EventHandler(this.rotationBox_CheckedChanged);
            // 
            // mufflerBox
            // 
            this.mufflerBox.AutoSize = true;
            this.mufflerBox.Location = new System.Drawing.Point(6, 48);
            this.mufflerBox.Name = "mufflerBox";
            this.mufflerBox.Size = new System.Drawing.Size(195, 21);
            this.mufflerBox.TabIndex = 1;
            this.mufflerBox.Text = "Replace Muffler ($100.00)";
            this.mufflerBox.UseVisualStyleBackColor = true;
            this.mufflerBox.CheckedChanged += new System.EventHandler(this.mufflerBox_CheckedChanged);
            // 
            // inspecBx
            // 
            this.inspecBx.AutoSize = true;
            this.inspecBx.Location = new System.Drawing.Point(6, 21);
            this.inspecBx.Name = "inspecBx";
            this.inspecBx.Size = new System.Drawing.Size(152, 21);
            this.inspecBx.TabIndex = 0;
            this.inspecBx.Text = "Inspection ($15.00)";
            this.inspecBx.UseVisualStyleBackColor = true;
            this.inspecBx.CheckedChanged += new System.EventHandler(this.inspecBx_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.laborTxtBox);
            this.groupBox4.Controls.Add(this.partsTxtBox);
            this.groupBox4.Location = new System.Drawing.Point(237, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 115);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Labor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parts";
            // 
            // laborTxtBox
            // 
            this.laborTxtBox.Location = new System.Drawing.Point(97, 73);
            this.laborTxtBox.Name = "laborTxtBox";
            this.laborTxtBox.Size = new System.Drawing.Size(68, 22);
            this.laborTxtBox.TabIndex = 1;
            // 
            // partsTxtBox
            // 
            this.partsTxtBox.Location = new System.Drawing.Point(97, 33);
            this.partsTxtBox.Name = "partsTxtBox";
            this.partsTxtBox.Size = new System.Drawing.Size(68, 22);
            this.partsTxtBox.TabIndex = 0;
            this.partsTxtBox.TextChanged += new System.EventHandler(this.partsTxtBox_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.totalLabel);
            this.groupBox5.Controls.Add(this.taxLabel);
            this.groupBox5.Controls.Add(this.partsLabel);
            this.groupBox5.Controls.Add(this.servLabLabel);
            this.groupBox5.Location = new System.Drawing.Point(12, 248);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(448, 143);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total Fees";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tax (on parts)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Parts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Service and Labor";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(151, 107);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(136, 23);
            this.totalLabel.TabIndex = 3;
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxLabel.Location = new System.Drawing.Point(151, 84);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(136, 23);
            this.taxLabel.TabIndex = 2;
            // 
            // partsLabel
            // 
            this.partsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsLabel.Location = new System.Drawing.Point(151, 61);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(136, 23);
            this.partsLabel.TabIndex = 1;
            // 
            // servLabLabel
            // 
            this.servLabLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servLabLabel.Location = new System.Drawing.Point(151, 38);
            this.servLabLabel.Name = "servLabLabel";
            this.servLabLabel.Size = new System.Drawing.Size(136, 23);
            this.servLabLabel.TabIndex = 0;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(80, 397);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(96, 34);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(182, 397);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 34);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(284, 397);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(472, 459);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox lubeJbChkBx;
        private System.Windows.Forms.CheckBox oilChangeChkBx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox TransFlshBx;
        private System.Windows.Forms.CheckBox radFlshBx;
        private System.Windows.Forms.CheckBox rotationBox;
        private System.Windows.Forms.CheckBox mufflerBox;
        private System.Windows.Forms.CheckBox inspecBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox laborTxtBox;
        private System.Windows.Forms.TextBox partsTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label servLabLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

