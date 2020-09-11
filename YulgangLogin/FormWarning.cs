using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YulgangLogin
{
    public partial class FormWarning : Form
    {
        public static string PathWarning()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\YulgangLogin";
            if( !Directory.Exists(path) )
            {
                Directory.CreateDirectory(path);
            }
            return path + @"\" + "warning_" + Assembly.GetExecutingAssembly().GetName().Version.ToString().Replace(".", "_");
        }
        public FormWarning()
        {
            InitializeComponent();
        }

        private void FormWarning_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\" + @"warning.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxWarning_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWarning.Checked)
            {
                File.AppendAllLines(PathWarning(), new[] { "Meawmuay!" });
            }
            else
            {
                if( File.Exists(PathWarning()) )
                {
                    File.Delete(PathWarning());
                }
            }
           
        }
    }
}
