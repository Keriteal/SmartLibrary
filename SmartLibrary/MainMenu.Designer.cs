namespace SmartLibrary
{
    partial class MainMenu
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageReader = new System.Windows.Forms.TabPage();
            this.btnPreorder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnToEdit = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BookManage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageReader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(543, 401);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "注销会话";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 381);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPageReader);
            this.tabControl1.Controls.Add(this.tabPageAdmin);
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 20);
            this.tabControl1.Location = new System.Drawing.Point(-4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 384);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageReader
            // 
            this.tabPageReader.Controls.Add(this.btnPreorder);
            this.tabPageReader.Controls.Add(this.groupBox1);
            this.tabPageReader.Controls.Add(this.btnLend);
            this.tabPageReader.Controls.Add(this.btnToEdit);
            this.tabPageReader.Controls.Add(this.btnBorrow);
            this.tabPageReader.Location = new System.Drawing.Point(4, 24);
            this.tabPageReader.Name = "tabPageReader";
            this.tabPageReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReader.Size = new System.Drawing.Size(604, 356);
            this.tabPageReader.TabIndex = 0;
            this.tabPageReader.UseVisualStyleBackColor = true;
            // 
            // btnPreorder
            // 
            this.btnPreorder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPreorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPreorder.BackgroundImage")));
            this.btnPreorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreorder.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnPreorder.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPreorder.Location = new System.Drawing.Point(435, 202);
            this.btnPreorder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreorder.Name = "btnPreorder";
            this.btnPreorder.Size = new System.Drawing.Size(108, 58);
            this.btnPreorder.TabIndex = 0;
            this.btnPreorder.TabStop = false;
            this.btnPreorder.Text = "预约座位";
            this.btnPreorder.UseVisualStyleBackColor = false;
            this.btnPreorder.Click += new System.EventHandler(this.btnPreorder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("华文楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "公告";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(199, 280);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnLend
            // 
            this.btnLend.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLend.BackgroundImage")));
            this.btnLend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLend.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnLend.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLend.Location = new System.Drawing.Point(321, 28);
            this.btnLend.Margin = new System.Windows.Forms.Padding(2);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(86, 48);
            this.btnLend.TabIndex = 0;
            this.btnLend.Text = "还书";
            this.btnLend.UseVisualStyleBackColor = false;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnToEdit
            // 
            this.btnToEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnToEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToEdit.BackgroundImage")));
            this.btnToEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToEdit.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnToEdit.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnToEdit.Location = new System.Drawing.Point(279, 279);
            this.btnToEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnToEdit.Name = "btnToEdit";
            this.btnToEdit.Size = new System.Drawing.Size(108, 58);
            this.btnToEdit.TabIndex = 0;
            this.btnToEdit.TabStop = false;
            this.btnToEdit.Text = "修改信息";
            this.btnToEdit.UseVisualStyleBackColor = false;
            this.btnToEdit.Click += new System.EventHandler(this.btnToEdit_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBorrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrow.BackgroundImage")));
            this.btnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrow.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnBorrow.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBorrow.Location = new System.Drawing.Point(477, 61);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(86, 48);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Text = "借书";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.button2);
            this.tabPageAdmin.Controls.Add(this.button1);
            this.tabPageAdmin.Controls.Add(this.BookManage);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 24);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(604, 356);
            this.tabPageAdmin.TabIndex = 1;
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "数据库连接设置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "公告管理";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BookManage
            // 
            this.BookManage.Location = new System.Drawing.Point(6, 56);
            this.BookManage.Name = "BookManage";
            this.BookManage.Size = new System.Drawing.Size(89, 45);
            this.BookManage.TabIndex = 0;
            this.BookManage.Text = "书本管理";
            this.BookManage.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "主菜单";
            this.Load += new System.EventHandler(this.Login_interface_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageReader.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageReader;
        private System.Windows.Forms.Button btnPreorder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Button btnToEdit;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BookManage;
    }
}