
namespace Zadatak4
{
    partial class Form2
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
            this.btnKraj = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKraj
            // 
            this.btnKraj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKraj.Location = new System.Drawing.Point(95, 233);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(123, 77);
            this.btnKraj.TabIndex = 0;
            this.btnKraj.Text = "Hvala!";
            this.btnKraj.UseVisualStyleBackColor = false;
            this.btnKraj.Click += new System.EventHandler(this.btnKraj_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(51, 78);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnKraj);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKraj;
        private System.Windows.Forms.Label lblText;
    }
}