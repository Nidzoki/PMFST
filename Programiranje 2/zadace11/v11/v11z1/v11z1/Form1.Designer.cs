﻿
namespace v11z1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovaDostava = new System.Windows.Forms.Button();
            this.btnKraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(410, 297);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sve dostave:";
            // 
            // btnNovaDostava
            // 
            this.btnNovaDostava.Location = new System.Drawing.Point(40, 375);
            this.btnNovaDostava.Name = "btnNovaDostava";
            this.btnNovaDostava.Size = new System.Drawing.Size(116, 45);
            this.btnNovaDostava.TabIndex = 2;
            this.btnNovaDostava.Text = "Nova dostava";
            this.btnNovaDostava.UseVisualStyleBackColor = true;
            this.btnNovaDostava.Click += new System.EventHandler(this.btnNovaDostava_Click);
            // 
            // btnKraj
            // 
            this.btnKraj.Location = new System.Drawing.Point(162, 375);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(116, 45);
            this.btnKraj.TabIndex = 3;
            this.btnKraj.Text = "Kraj";
            this.btnKraj.UseVisualStyleBackColor = true;
            this.btnKraj.Click += new System.EventHandler(this.btnKraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.btnKraj);
            this.Controls.Add(this.btnNovaDostava);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Dostava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaDostava;
        private System.Windows.Forms.Button btnKraj;
    }
}

