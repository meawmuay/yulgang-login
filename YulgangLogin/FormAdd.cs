using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YulgangLogin
{
    public partial class FormAdd : Form
    {
        protected FormMain FrmMain;
        protected User UserEdit;
        public FormAdd(FormMain frmMain, User user)
        {
            InitializeComponent();
            FrmMain = frmMain;

            if( user != null )
            {
                this.Text = @"User " + user.Title;
                UserEdit = user;
            }
        }

        public FormAdd(FormMain frmMain,String title,String username,String password)
        {
            InitializeComponent();
            FrmMain = frmMain;
            textBoxTitle.Text = title;
            textBoxUsername.Text = username;
            textBoxPassword.Text = password;
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Title = textBoxTitle.Text;
            user.Username = textBoxUsername.Text;
            user.Password = textBoxPassword.Text;
            if (UserEdit != null)
            {
                user.Id = UserEdit.Id;
                if( user.Update() == 1 )
                {
                    FrmMain.ReloadLists();
                    Close();
                }
                else
                {
                    MessageBox.Show(@"ERROR", @"Can't save to database!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if( user.Save() == 1 )
                {
                    FrmMain.ReloadLists();
                    Close();
                }
                else
                {
                    MessageBox.Show(@"ERROR", @"Can't save to database!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            if (UserEdit != null)
            {
                textBoxTitle.Text = UserEdit.Title;
                textBoxUsername.Text = UserEdit.Username;
                textBoxPassword.Text = UserEdit.Password;
            }
        }
    }
}
