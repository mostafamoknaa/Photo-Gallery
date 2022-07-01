
namespace picture_Show
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.singleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eixtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(935, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select the Picture";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(0, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(935, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Select the Mode";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleModeToolStripMenuItem,
            this.multiModeToolStripMenuItem,
            this.slideShowToolStripMenuItem,
            this.eixtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 92);
            // 
            // singleModeToolStripMenuItem
            // 
            this.singleModeToolStripMenuItem.Name = "singleModeToolStripMenuItem";
            this.singleModeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.singleModeToolStripMenuItem.Text = "Single Mode";
            this.singleModeToolStripMenuItem.Click += new System.EventHandler(this.singleModeToolStripMenuItem_Click);
            // 
            // multiModeToolStripMenuItem
            // 
            this.multiModeToolStripMenuItem.Name = "multiModeToolStripMenuItem";
            this.multiModeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.multiModeToolStripMenuItem.Text = "Multi Mode";
            this.multiModeToolStripMenuItem.Click += new System.EventHandler(this.multiModeToolStripMenuItem_Click);
            // 
            // slideShowToolStripMenuItem
            // 
            this.slideShowToolStripMenuItem.Name = "slideShowToolStripMenuItem";
            this.slideShowToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.slideShowToolStripMenuItem.Text = "Slide Show";
            this.slideShowToolStripMenuItem.Click += new System.EventHandler(this.slideShowToolStripMenuItem_Click);
            // 
            // eixtToolStripMenuItem
            // 
            this.eixtToolStripMenuItem.Name = "eixtToolStripMenuItem";
            this.eixtToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.eixtToolStripMenuItem.Text = "Eixt";
            this.eixtToolStripMenuItem.Click += new System.EventHandler(this.eixtToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.ForeColor = System.Drawing.Color.Green;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 342);
            this.listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(246, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 342);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(246, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(246, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(689, 342);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem singleModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eixtToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

