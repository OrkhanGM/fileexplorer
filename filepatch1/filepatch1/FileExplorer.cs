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
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files =  Directory.GetFiles(textBox1.Text,"*.jpg");

            foreach (string file in files)
            {
                treeView1.Nodes.Add(file);
            }
        }
    }
}
