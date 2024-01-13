
namespace Zadatak3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtGod = new System.Windows.Forms.TextBox();
            this.cmbPrebivaliste = new System.Windows.Forms.ComboBox();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioZ = new System.Windows.Forms.RadioButton();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblIspis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prebivalište:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina rođenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Spol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vozačka:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(163, 45);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 5;
            // 
            // txtGod
            // 
            this.txtGod.Location = new System.Drawing.Point(163, 116);
            this.txtGod.Name = "txtGod";
            this.txtGod.Size = new System.Drawing.Size(100, 20);
            this.txtGod.TabIndex = 6;
            // 
            // cmbPrebivaliste
            // 
            this.cmbPrebivaliste.FormattingEnabled = true;
            this.cmbPrebivaliste.Items.AddRange(new object[] {
            "Split",
            "Zadar",
            "Dubrovnik",
            "Zagreb",
            "Osijek",
            "Rijeka"});
            this.cmbPrebivaliste.Location = new System.Drawing.Point(163, 84);
            this.cmbPrebivaliste.Name = "cmbPrebivaliste";
            this.cmbPrebivaliste.Size = new System.Drawing.Size(100, 21);
            this.cmbPrebivaliste.TabIndex = 7;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(163, 147);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(34, 17);
            this.radioM.TabIndex = 8;
            this.radioM.TabStop = true;
            this.radioM.Text = "M";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioZ
            // 
            this.radioZ.AutoSize = true;
            this.radioZ.Location = new System.Drawing.Point(203, 147);
            this.radioZ.Name = "radioZ";
            this.radioZ.Size = new System.Drawing.Size(32, 17);
            this.radioZ.TabIndex = 9;
            this.radioZ.TabStop = true;
            this.radioZ.Text = "Ž";
            this.radioZ.UseVisualStyleBackColor = true;
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Location = new System.Drawing.Point(155, 185);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(33, 17);
            this.chkA.TabIndex = 10;
            this.chkA.Text = "A";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Location = new System.Drawing.Point(194, 185);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(33, 17);
            this.chkB.TabIndex = 11;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(233, 185);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(33, 17);
            this.chkC.TabIndex = 12;
            this.chkC.Text = "C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Location = new System.Drawing.Point(272, 186);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(34, 17);
            this.chkD.TabIndex = 13;
            this.chkD.Text = "D";
            this.chkD.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(156, 243);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(110, 55);
            this.btnSpremi.TabIndex = 14;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Location = new System.Drawing.Point(82, 342);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(0, 13);
            this.lblIspis.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 430);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.chkD);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.chkB);
            this.Controls.Add(this.chkA);
            this.Controls.Add(this.radioZ);
            this.Controls.Add(this.radioM);
            this.Controls.Add(this.cmbPrebivaliste);
            this.Controls.Add(this.txtGod);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtGod;
        private System.Windows.Forms.ComboBox cmbPrebivaliste;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioZ;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblIspis;
    }
}

