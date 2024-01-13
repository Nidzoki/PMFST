
namespace Zadatak4
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
            this.btnSalji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalji
            // 
            this.btnSalji.Location = new System.Drawing.Point(88, 252);
            this.btnSalji.Name = "btnSalji";
            this.btnSalji.Size = new System.Drawing.Size(130, 73);
            this.btnSalji.TabIndex = 0;
            this.btnSalji.Text = "Šalji dalje";
            this.btnSalji.UseVisualStyleBackColor = true;
            this.btnSalji.Click += new System.EventHandler(this.btnSalji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi neki tekst...";
            // 
            // txtTekst
            // 
            this.txtTekst.Location = new System.Drawing.Point(12, 78);
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.Size = new System.Drawing.Size(288, 20);
            this.txtTekst.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalji);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTekst;
    }
}

