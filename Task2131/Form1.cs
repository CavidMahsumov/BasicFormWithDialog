using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2131
{
   
    public partial class Form1 : Form
    {
        public string FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
               

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                   


                    ovalPictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }

        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StringReader reader = new StringReader(openFileDialog.FileName))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                    FileName = openFileDialog.FileName;
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            
                using (StreamWriter streamWriter = new StreamWriter(FileName))
                {
                    streamWriter.Write(richTextBox1.Text);
                }
            
        }
    }
}
