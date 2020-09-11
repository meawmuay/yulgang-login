using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace YulgangLogin
{
    public partial class FormMain : Form
    {
        private bool _startLogin = false;
        private bool _loginEnter = true;
        private bool _changeTitle = true;
        private int _loginSelected;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Check database file
            Database.Create();

            //Master Password
            if( Database.CheckConnectionDefault() )
            {
                FormEncryptChangePassword formEncryptFirst = new FormEncryptChangePassword();
                formEncryptFirst.ShowDialog();
            }
            else
            {
                FormEncrypt formEncrypt = new FormEncrypt();
                formEncrypt.ShowDialog();
            }

            //Set title
            this.Text = "Yulgang Login " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //List view login
            listViewLogin.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewLogin.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewLogin.Columns.Add("ID", 0);
            listViewLogin.Columns.Add("Title", 160);
            listViewLogin.Columns.Add("Username", 150);

            //Load Users
            ReloadLists();

            //Send button to front
            buttonCancel.BringToFront();

            //Warning
            if( !File.Exists(FormWarning.PathWarning()))
            {
                FormWarning formWarning = new FormWarning();
                formWarning.ShowDialog();
            }
        }

        public void ReloadLists()
        {
            //Clear
            listViewLogin.Items.Clear();

            //Add items in the list view login form users
            string[] arr = new string[3];
            ListViewItem listViewItem ;

            if( User.Lists() != null )
            {
                foreach( var user in User.Lists() )
                {
                    //Add first item
                    arr[0] = user.Id.ToString();
                    arr[1] = user.Title;
                    arr[2] = user.Username;
                    listViewItem = new ListViewItem(arr);
                    listViewLogin.Items.Add(listViewItem);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this, null);
            formAdd.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            for( int i = 0; i < listViewLogin.SelectedItems.Count; i++ )
            {
                int id =  Convert.ToInt32(listViewLogin.SelectedItems[i].SubItems[0].Text);
                User.DeleteUser(new User { Id = id });
            }
            ReloadLists();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if( listViewLogin.SelectedItems.Count == 1 )
            {
                int id =  Convert.ToInt32(listViewLogin.SelectedItems[0].SubItems[0].Text);
                User user = User.GetUserById(id);

                if( user != null )
                {
                    FormAdd formAdd = new FormAdd(this, user);
                    formAdd.Show();
                }

                ReloadLists();
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            StartLogin();
        }
        private void StartLogin()
        {
            if( listViewLogin.SelectedItems.Count != 1 )
            {
                MessageBox.Show(@"กรุณาเลือกรายการจากด้านซ้ายมือก่อน!", @"Alert", MessageBoxButtons.OK);
                return;
            }

            _loginSelected = Convert.ToInt32(listViewLogin.SelectedItems[0].SubItems[0].Text);
            _startLogin = true;
            buttonLogin.Text = @"Wait focus game window...";
            buttonLogin.Enabled = false;
            buttonCancel.Visible = true;
            buttonCancel.Enabled = true;
            checkBoxChangeTitle.Enabled = false;
            timerLogin.Enabled = true;
        }

        private void StopLogin()
        {
            _startLogin = false;
            buttonLogin.Text = @"LOGIN";
            buttonLogin.Enabled = true;
            buttonCancel.Enabled = false;
            checkBoxChangeTitle.Enabled = true;
            buttonCancel.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            StopLogin();
        }


        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern IntPtr GetForegroundWindow();
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int GetWindowText(System.IntPtr hWnd, System.Text.StringBuilder lpString, int cch);
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int SetWindowText(System.IntPtr hWnd, string text);
        private void timerLogin_Tick(object sender, EventArgs e)
        {
            if( _startLogin )
            {
                System.Text.StringBuilder title = new System.Text.StringBuilder(256);
                IntPtr hWnd = GetForegroundWindow();
                GetWindowText(hWnd, title, title.Capacity);
                if( title.ToString().StartsWith("YGOnline") )
                {
                    StopLogin();

                    //Load user
                    User user = User.GetUserById(_loginSelected);
                    if( user != null )
                    {
                        //Change title
                        if( _changeTitle )
                        {
                            SetWindowText(hWnd, "YGOnline - " + user.Title);
                        }

                        //Send key
                        InputSimulator input = new InputSimulator();
                        input.Keyboard.TextEntry(user.Username);
                        //Send tab
                        input.Keyboard.Sleep(200);
                        input.Keyboard.KeyDown(VirtualKeyCode.TAB);
                        input.Keyboard.Sleep(150);
                        input.Keyboard.KeyUp(VirtualKeyCode.TAB);

                        input.Keyboard.Sleep(200);
                        input.Keyboard.TextEntry(user.Password);

                        //Send enter login
                        Console.WriteLine(_loginEnter);
                        if( _loginEnter )
                        {
                            Console.WriteLine(@"Enter");
                            input.Keyboard.Sleep(300);
                            input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                        }
                    }
                }
            }
            else
            {
                timerLogin.Enabled = false;
            }

            Console.WriteLine(@"TimerLogin Tick!" + DateTime.Now);
        }

        private void checkBoxLoginEnter_CheckedChanged(object sender, EventArgs e)
        {
            _loginEnter = checkBoxLoginEnter.Checked;
            Console.WriteLine(_loginEnter);
        }

        private void checkBoxChangeTitle_CheckedChanged(object sender, EventArgs e)
        {
            _changeTitle = checkBoxChangeTitle.Checked;
            Console.WriteLine(_changeTitle);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listViewLogin_DoubleClick(object sender, EventArgs e)
        {
            StartLogin();
        }

        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("โปรแกรมนี้สร้างโดย แมวหมวย\nหากคุณพบปัญหา กรุณาติดต่อเราเพื่อแก้ไข", "เกี่ยวกับ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MasterToolStripMenuItemChangePassword_Click(object sender, EventArgs e)
        {
            FormEncryptChangePassword formEncryptFirst = new FormEncryptChangePassword();
            formEncryptFirst.Text = "ตั้งรหัสผ่านใหม่";
            formEncryptFirst.ChangePassword = true;
            formEncryptFirst.ShowDialog();
        }

        private void ToolStripMenuItemClean_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("คุณกำลังจะล้างข้อมูลเก่าออกโดยไม่สามารถกู้คืนได้ อาจจะมาจากคุณจำรหัสไม่ได้หรือมีปัญหากับการเข้าถึงข้อมูล คุณแน่ใจว่าต้องการล้างข้อมูลทั้งหมด?","แน่ใจ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if( dialogResult == DialogResult.Yes )
            {
                if( Database.Clean() )
                {
                    MessageBox.Show("ทำการล้างข้อมูลเรียบร้อยแล้ว กรุณาเข้าโปรแกรมอีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.GetCurrentProcess().Kill();
                }
                else
                {
                    MessageBox.Show("เกิดข้อผิดพลาดไม่สามารถล้างข้อมูลได้", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ToolStripMenuItemExportDatabase_Click(object sender, EventArgs e)
        {
            if( saveFileDialogExportDatabase.ShowDialog() == DialogResult.OK )
            {
                string path = saveFileDialogExportDatabase.FileName;
                Database.Export(path);
            }
        }

        private void ToolStripMenuItemImportDatabase_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ข้อมูลเก่าจะถูกลบและกู้คืนไม่ได้หากคุณนำเข้าข้อมูลใหม่?","แจ้งเตือน",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if( dialogResult == DialogResult.Yes )
            {
                if( openFileDialogImportDatabase.ShowDialog() == DialogResult.OK )
                {
                    string path = openFileDialogImportDatabase.FileName;
                    Database.Import(path);
                    MessageBox.Show("นำเข้าข้อมูลเรียบร้อยแล้ว กรุณาเปิดโปรแกรมใหม่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.GetCurrentProcess().Kill();
                }
            }
        }
    }
}
