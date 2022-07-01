using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace picture_Show
{
    public partial class Form1 : Form
    {
        
        List<String> listOfImage = new List<String>();
        List<String> image = new List<String>();
        List<String> name = new List<String>();
        List<String> path = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gef|PNG|*.png";

            if (open.ShowDialog() == DialogResult.Cancel)
                return;

            //listBox1.Items.Clear();
            listOfImage.Clear();
            name.Clear();
            image.Clear();
            foreach (string s in open.FileNames)
            {
                listBox1.Items.Add(Path.GetFileName(s));
                name.Add(Path.GetFileName(s));
                path.Add(s);

            }

            listOfImage.AddRange(open.FileNames);
        }

        private void singleModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
           
            panel1.Visible = false;
            listBox1.SelectionMode = SelectionMode.One;
            if (listBox1.SelectedIndex < path.Count)
            {
                
                pictureBox1.Image = Image.FromFile(path[listBox1.SelectedIndex]);
                this.Text = name[listBox1.SelectedIndex];

            }
            
        }

        private void multiModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            panel1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            foreach (int idx in listBox1.SelectedIndices)
            {
                image.Add(listOfImage[idx]);
            }
            int x = 250, y = 20, h = -1, c = 0;
            foreach (string s in listOfImage)
            {
                if (c < image.Count)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(image[c]);
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;

                    x += pic.Width + 10;
                    h = Math.Max(pic.Height, h);
                    if (x > panel1.ClientSize.Width -30)
                    {
                        x = 250;
                        y += h + 10;
                    }
                    this.panel1.Controls.Add(pic);
                    c++;
                }

            }

        }

        private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox2.Visible = true;
           
            pictureBox1.Visible = false;
            panel1.Visible = false;
            listBox1.SelectionMode = SelectionMode.MultiExtended;

        }

        private void eixtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int currentImage = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (currentImage < listOfImage.Count)
            {
                pictureBox2.Image = Image.FromFile(listOfImage[currentImage]);

                this.Text = name[currentImage];
                currentImage++;
            }
            else
            {
                currentImage = 0;
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

       
    }
}
