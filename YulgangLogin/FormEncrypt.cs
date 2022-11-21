using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YulgangLogin
{
    public partial class FormEncrypt : Form
    {
        private bool _hasPassword = false;

        public FormEncrypt()
        {
            InitializeComponent();
        }

        private void checkPassword()
        {
            if( Database.CheckConnection(textBoxPassword.Text) )
            {
                Database.PasswordDatabase = textBoxPassword.Text;
                _hasPassword = true;
                Close();
            }
            else
            {
                MessageBox.Show("รหัสผ่านไม่ถูกต้อง!", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = null;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Database.PathDatabaseFile());
            checkPassword();
        }

        private void FormEncrypt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_hasPassword == false)
            {
                System.Environment.Exit(0);
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == Convert.ToChar(Keys.Return) )
            {
                checkPassword();
            }
        }

        private void ToolStripMenuItemClean_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("คุณกำลังจะล้างข้อมูลเก่าออกโดยไม่สามารถกู้คืนได้ อาจจะมาจากคุณจำรหัสไม่ได้หรือมีปัญหากับการเข้าถึงข้อมูล คุณแน่ใจว่าต้องการล้างข้อมูลทั้งหมด?","แน่ใจ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if( dialogResult == DialogResult.Yes )
            {
                if (Database.Clean())
                {
                    MessageBox.Show("ทำการล้างข้อมูลเรียบร้อยแล้ว", "แน่ใจ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.GetCurrentProcess().Kill();
                }
                else
                {
                    MessageBox.Show("เกิดข้อผิดพลาดไม่สามารถล้างข้อมูลได้", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormEncrypt_Load(object sender, EventArgs e)
        {
            //Set title
            this.Text = "Yulgang Login " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
