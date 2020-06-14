﻿namespace SmartLibrary
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageReader = new System.Windows.Forms.TabPage();
            this.btnPreorder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnToEdit = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BookManage = new System.Windows.Forms.Button();
            this.UserManage = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageReader.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPageReader);
            this.tabControl1.Controls.Add(this.tabPageAdmin);
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 20);
            this.tabControl1.Location = new System.Drawing.Point(35, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 386);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
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
            this.tabPageReader.Size = new System.Drawing.Size(600, 358);
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
            this.btnPreorder.Location = new System.Drawing.Point(409, 172);
            this.btnPreorder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreorder.Name = "btnPreorder";
            this.btnPreorder.Size = new System.Drawing.Size(108, 58);
            this.btnPreorder.TabIndex = 0;
            this.btnPreorder.Text = "预约座位";
            this.btnPreorder.UseVisualStyleBackColor = false;
            this.btnPreorder.Click += new System.EventHandler(this.btnPreorder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
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
            this.btnLend.TabStop = false;
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
            this.btnBorrow.TabStop = false;
            this.btnBorrow.Text = "借书";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.button1);
            this.tabPageAdmin.Controls.Add(this.BookManage);
            this.tabPageAdmin.Controls.Add(this.UserManage);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 24);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(600, 358);
            this.tabPageAdmin.TabIndex = 1;
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "公告管理";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BookManage
            // 
            this.BookManage.Location = new System.Drawing.Point(337, 161);
            this.BookManage.Name = "BookManage";
            this.BookManage.Size = new System.Drawing.Size(97, 54);
            this.BookManage.TabIndex = 0;
            this.BookManage.Text = "书本管理";
            this.BookManage.UseVisualStyleBackColor = true;
            // 
            // UserManage
            // 
            this.UserManage.Location = new System.Drawing.Point(357, 56);
            this.UserManage.Name = "UserManage";
            this.UserManage.Size = new System.Drawing.Size(99, 51);
            this.UserManage.TabIndex = 0;
            this.UserManage.Text = "管理用户";
            this.UserManage.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 459);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = " 主菜單";
            this.Load += new System.EventHandler(this.Login_interface_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageReader.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageReader;
        private System.Windows.Forms.Button btnPreorder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Button btnToEdit;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BookManage;
        private System.Windows.Forms.Button UserManage;
    }
}