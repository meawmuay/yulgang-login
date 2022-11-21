namespace YulgangLogin
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listViewLogin = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timerLogin = new System.Windows.Forms.Timer(this.components);
            this.checkBoxLoginEnter = new System.Windows.Forms.CheckBox();
            this.checkBoxChangeTitle = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MasterToolStripMenuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExportDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemImportDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClean = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogExportDatabase = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogImportDatabase = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.buttonCoppy = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonLogin.Location = new System.Drawing.Point(341, 62);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(118, 52);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listViewLogin
            // 
            this.listViewLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listViewLogin.FullRowSelect = true;
            this.listViewLogin.GridLines = true;
            this.listViewLogin.HideSelection = false;
            this.listViewLogin.Location = new System.Drawing.Point(12, 35);
            this.listViewLogin.Name = "listViewLogin";
            this.listViewLogin.Size = new System.Drawing.Size(316, 163);
            this.listViewLogin.TabIndex = 1;
            this.listViewLogin.UseCompatibleStateImageBehavior = false;
            this.listViewLogin.View = System.Windows.Forms.View.Details;
            this.listViewLogin.DoubleClick += new System.EventHandler(this.listViewLogin_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 204);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(74, 24);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "เพิ่ม";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonRemove.Location = new System.Drawing.Point(254, 204);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(74, 24);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "ลบ";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonEdit.Location = new System.Drawing.Point(92, 204);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(74, 24);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "แก้ไข";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(341, 119);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // timerLogin
            // 
            this.timerLogin.Interval = 300;
            this.timerLogin.Tick += new System.EventHandler(this.timerLogin_Tick);
            // 
            // checkBoxLoginEnter
            // 
            this.checkBoxLoginEnter.AutoSize = true;
            this.checkBoxLoginEnter.Checked = true;
            this.checkBoxLoginEnter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoginEnter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxLoginEnter.Location = new System.Drawing.Point(345, 121);
            this.checkBoxLoginEnter.Name = "checkBoxLoginEnter";
            this.checkBoxLoginEnter.Size = new System.Drawing.Size(102, 18);
            this.checkBoxLoginEnter.TabIndex = 6;
            this.checkBoxLoginEnter.Text = "LOGIN ENTER";
            this.checkBoxLoginEnter.UseVisualStyleBackColor = true;
            this.checkBoxLoginEnter.CheckedChanged += new System.EventHandler(this.checkBoxLoginEnter_CheckedChanged);
            // 
            // checkBoxChangeTitle
            // 
            this.checkBoxChangeTitle.AutoSize = true;
            this.checkBoxChangeTitle.Checked = true;
            this.checkBoxChangeTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChangeTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxChangeTitle.Location = new System.Drawing.Point(345, 143);
            this.checkBoxChangeTitle.Name = "checkBoxChangeTitle";
            this.checkBoxChangeTitle.Size = new System.Drawing.Size(109, 18);
            this.checkBoxChangeTitle.TabIndex = 7;
            this.checkBoxChangeTitle.Text = "CHANGE TITLE";
            this.checkBoxChangeTitle.UseVisualStyleBackColor = true;
            this.checkBoxChangeTitle.CheckedChanged += new System.EventHandler(this.checkBoxChangeTitle_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ToolStripMenuItemAbout,
            this.ToolStripMenuItemUpdate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MasterToolStripMenuItemChangePassword,
            this.ToolStripMenuItemExportDatabase,
            this.ToolStripMenuItemImportDatabase,
            this.ToolStripMenuItemClean});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.fileToolStripMenuItem.Text = "ความปลอดภัย";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // MasterToolStripMenuItemChangePassword
            // 
            this.MasterToolStripMenuItemChangePassword.Name = "MasterToolStripMenuItemChangePassword";
            this.MasterToolStripMenuItemChangePassword.Size = new System.Drawing.Size(160, 22);
            this.MasterToolStripMenuItemChangePassword.Text = "เปลี่ยนรหัส Master";
            this.MasterToolStripMenuItemChangePassword.Click += new System.EventHandler(this.MasterToolStripMenuItemChangePassword_Click);
            // 
            // ToolStripMenuItemExportDatabase
            // 
            this.ToolStripMenuItemExportDatabase.Name = "ToolStripMenuItemExportDatabase";
            this.ToolStripMenuItemExportDatabase.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItemExportDatabase.Text = "ส่งออกฐานข้อมูล";
            this.ToolStripMenuItemExportDatabase.Click += new System.EventHandler(this.ToolStripMenuItemExportDatabase_Click);
            // 
            // ToolStripMenuItemImportDatabase
            // 
            this.ToolStripMenuItemImportDatabase.Name = "ToolStripMenuItemImportDatabase";
            this.ToolStripMenuItemImportDatabase.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItemImportDatabase.Text = "นำเข้าฐานข้อมูล";
            this.ToolStripMenuItemImportDatabase.Click += new System.EventHandler(this.ToolStripMenuItemImportDatabase_Click);
            // 
            // ToolStripMenuItemClean
            // 
            this.ToolStripMenuItemClean.Name = "ToolStripMenuItemClean";
            this.ToolStripMenuItemClean.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItemClean.Text = "ล้างข้อมูล";
            this.ToolStripMenuItemClean.Click += new System.EventHandler(this.ToolStripMenuItemClean_Click);
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(54, 20);
            this.ToolStripMenuItemAbout.Text = "เกี่ยวกับ";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // ToolStripMenuItemUpdate
            // 
            this.ToolStripMenuItemUpdate.Name = "ToolStripMenuItemUpdate";
            this.ToolStripMenuItemUpdate.Size = new System.Drawing.Size(49, 20);
            this.ToolStripMenuItemUpdate.Text = "อัปเดต";
            this.ToolStripMenuItemUpdate.Click += new System.EventHandler(this.ToolStripMenuItemUpdate_Click);
            // 
            // saveFileDialogExportDatabase
            // 
            this.saveFileDialogExportDatabase.FileName = "YulgangLoginDB.db";
            this.saveFileDialogExportDatabase.Filter = "DB|*.db";
            // 
            // openFileDialogImportDatabase
            // 
            this.openFileDialogImportDatabase.FileName = "YulgangLoginDB.db";
            this.openFileDialogImportDatabase.Filter = "DB|*.db";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "แบบพิมพ์",
            "แบบคัดลอก"});
            this.comboBoxMode.Location = new System.Drawing.Point(341, 35);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(118, 22);
            this.comboBoxMode.TabIndex = 9;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // buttonCoppy
            // 
            this.buttonCoppy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonCoppy.Location = new System.Drawing.Point(172, 204);
            this.buttonCoppy.Name = "buttonCoppy";
            this.buttonCoppy.Size = new System.Drawing.Size(74, 24);
            this.buttonCoppy.TabIndex = 10;
            this.buttonCoppy.Text = "สำเนา";
            this.buttonCoppy.UseVisualStyleBackColor = true;
            this.buttonCoppy.Click += new System.EventHandler(this.buttonCoppy_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 240);
            this.Controls.Add(this.buttonCoppy);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.checkBoxChangeTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.checkBoxLoginEnter);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewLogin);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yulgang Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListView listViewLogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Timer timerLogin;
        private System.Windows.Forms.CheckBox checkBoxLoginEnter;
        private System.Windows.Forms.CheckBox checkBoxChangeTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MasterToolStripMenuItemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExportDatabase;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemImportDatabase;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClean;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExportDatabase;
        private System.Windows.Forms.OpenFileDialog openFileDialogImportDatabase;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUpdate;
        private System.Windows.Forms.Button buttonCoppy;
    }
}

