
namespace Zadatak1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izgledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veličinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.većeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izgledToolStripMenuItem,
            this.veličinaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izgledToolStripMenuItem
            // 
            this.izgledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.regularToolStripMenuItem});
            this.izgledToolStripMenuItem.Name = "izgledToolStripMenuItem";
            this.izgledToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.izgledToolStripMenuItem.Text = "Izgled";
            // 
            // veličinaToolStripMenuItem
            // 
            this.veličinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manjeToolStripMenuItem,
            this.većeToolStripMenuItem});
            this.veličinaToolStripMenuItem.Name = "veličinaToolStripMenuItem";
            this.veličinaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.veličinaToolStripMenuItem.Text = "Veličina";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.underlineToolStripMenuItem.Text = "Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // regularToolStripMenuItem
            // 
            this.regularToolStripMenuItem.Name = "regularToolStripMenuItem";
            this.regularToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regularToolStripMenuItem.Text = "Regular";
            this.regularToolStripMenuItem.Click += new System.EventHandler(this.regularToolStripMenuItem_Click);
            // 
            // manjeToolStripMenuItem
            // 
            this.manjeToolStripMenuItem.Name = "manjeToolStripMenuItem";
            this.manjeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manjeToolStripMenuItem.Text = "Manje";
            this.manjeToolStripMenuItem.Click += new System.EventHandler(this.manjeToolStripMenuItem_Click);
            // 
            // većeToolStripMenuItem
            // 
            this.većeToolStripMenuItem.Name = "većeToolStripMenuItem";
            this.većeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.većeToolStripMenuItem.Text = "Veće";
            this.većeToolStripMenuItem.Click += new System.EventHandler(this.većeToolStripMenuItem_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(148, 201);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(193, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Ovo je tekst koji ću mijenjati iz izbornika";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izgledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veličinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem većeToolStripMenuItem;
        private System.Windows.Forms.Label lblText;
    }
}

