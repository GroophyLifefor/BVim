namespace BVim
{
    partial class MainWindow
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
            this.MenuBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.HelpBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentBar = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BCode = new ScintillaNET.Scintilla();
            this.Code = new ScintillaNET.Scintilla();
            this.MenuBar.SuspendLayout();
            this.HelpBar.SuspendLayout();
            this.DocumentBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.MenuBar.Controls.Add(this.label1);
            this.MenuBar.Controls.Add(this.button3);
            this.MenuBar.Controls.Add(this.button2);
            this.MenuBar.Controls.Add(this.button1);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1291, 36);
            this.MenuBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Batch Editor - [Groophy Lifefor]";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1066, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1141, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1216, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.StatusBar.Location = new System.Drawing.Point(0, 718);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusBar.Size = new System.Drawing.Size(1291, 22);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // HelpBar
            // 
            this.HelpBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.HelpBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.HelpBar.Location = new System.Drawing.Point(0, 36);
            this.HelpBar.Name = "HelpBar";
            this.HelpBar.Size = new System.Drawing.Size(1291, 24);
            this.HelpBar.TabIndex = 2;
            this.HelpBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(108)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // DocumentBar
            // 
            this.DocumentBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.DocumentBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.DocumentBar.Location = new System.Drawing.Point(0, 60);
            this.DocumentBar.Name = "DocumentBar";
            this.DocumentBar.Size = new System.Drawing.Size(1291, 24);
            this.DocumentBar.TabIndex = 3;
            this.DocumentBar.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(108)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.toolStripMenuItem1.Text = "Document.Bat";
            // 
            // BCode
            // 
            this.BCode.AutoCMaxHeight = 9;
            this.BCode.Location = new System.Drawing.Point(0, 87);
            this.BCode.Name = "BCode";
            this.BCode.Size = new System.Drawing.Size(644, 628);
            this.BCode.TabIndents = true;
            this.BCode.TabIndex = 4;
            this.BCode.Text = "scintilla1";
            // 
            // Code
            // 
            this.Code.AutoCMaxHeight = 9;
            this.Code.Location = new System.Drawing.Point(650, 87);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(641, 628);
            this.Code.TabIndents = true;
            this.Code.TabIndex = 5;
            this.Code.Text = "scintilla2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1291, 740);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.BCode);
            this.Controls.Add(this.DocumentBar);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.HelpBar);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.HelpBar;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.HelpBar.ResumeLayout(false);
            this.HelpBar.PerformLayout();
            this.DocumentBar.ResumeLayout(false);
            this.DocumentBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        public Panel MenuBar;
        public MenuStrip HelpBar;
        public MenuStrip DocumentBar;
        public ScintillaNET.Scintilla BCode;
        public ScintillaNET.Scintilla Code;
        public StatusStrip StatusBar;
        private Label label1;
    }
}