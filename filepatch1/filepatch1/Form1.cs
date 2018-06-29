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

namespace filepatch1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;

                FileInfo FileInfo = new FileInfo(textBox1.Text);
            }

          //  using(FileStream fileStream =  FileInfo.OpenRead())
            {
             //   using(StreamReader streamReader = new StreamReader(FileStream))
                {
                  //  string info = streamReader.ReadToEnd();
                 //   richTextBox1.Text = info;
                }
            }
            

            
        }
    }
}
