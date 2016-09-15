using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace convert
{
    public partial class Form1 : Form
    {
        Image file;
        Boolean opened = false;
        Boolean opened2 = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                opened = true;
                pictureBox1.Image = file;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Image[] files;
            OpenFileDialog dr = new OpenFileDialog
            {
                Multiselect = true,
                Title = "Выберите файлы",
                InitialDirectory = @"E:\"
            };
            opened2 = true;
            dr.ShowDialog();
            string[] fil = dr.FileNames;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (opened)
                {
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "bmp")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                        MessageBox.Show("OK");
                    }
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "jpg")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                        MessageBox.Show("OK");
                    }
                }
                else if (opened2)
                {
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "jpg")
                    {
                        //foreach (string f in file[]) {
                        //    files[].Save(saveFileDialog1.FileNames, ImageFormat.Jpeg);
                        //    MessageBox.Show("OK");
                        //}
                    }

                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
