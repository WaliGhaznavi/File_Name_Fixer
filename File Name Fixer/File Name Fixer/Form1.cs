using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Name_Fixer
{
    public partial class Form1 : Form
    {
        private string inputDirectory;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_selectFiles_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    inputDirectory = fbd.SelectedPath;
                    lbl_Directory.Text = inputDirectory;
                }
            }
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            string[] SourceFiles = Directory.GetFiles(inputDirectory);
            foreach (string file in SourceFiles)
            {
                string[] spl = file.Split('\\');
                string xspl = spl[spl.Length - 1];
                string _xspl =  xspl.Trim(' ');
                _xspl = _xspl.Replace(' ', '_');

                if (!_xspl.Equals(xspl))
                {
                    string newName = spl[0];
                    for (int s = 1; s < spl.Length - 1; s++)
                    {
                        newName = newName + "\\" + spl[s];
                    }
                    newName = newName + "\\" + _xspl;
                    File.Move(file, newName);
                    txt_Files.AppendText(newName + Environment.NewLine);
                }
            }
        }
    }
}
