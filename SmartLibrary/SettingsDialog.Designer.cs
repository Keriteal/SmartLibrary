﻿namespace SmartLibrary
{
    partial class SettingsDialog
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
            this.DatabaseUser = new System.Windows.Forms.TextBox();
            this.DatabaseNewPasswd = new System.Windows.Forms.TextBox();
            this.DatabaseHost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DatabasePort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DatabaseUser
            // 
            this.DatabaseUser.Location = new System.Drawing.Point(163, 48);
            this.DatabaseUser.Name = "DatabaseUser";
            this.DatabaseUser.Size = new System.Drawing.Size(100, 21);
            this.DatabaseUser.TabIndex = 1;
            // 
            // DatabaseNewPasswd
            // 
            this.DatabaseNewPasswd.Location = new System.Drawing.Point(163, 75);
            this.DatabaseNewPasswd.Name = "DatabaseNewPasswd";
            this.DatabaseNewPasswd.Size = new System.Drawing.Size(100, 21);
            this.DatabaseNewPasswd.TabIndex = 0;
            // 
            // DatabaseHost
            // 
            this.DatabaseHost.Location = new System.Drawing.Point(163, 21);
            this.DatabaseHost.Name = "DatabaseHost";
            this.DatabaseHost.Size = new System.Drawing.Size(100, 21);
            this.DatabaseHost.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "数据库用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "数据库密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "主机";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "：";
            // 
            // DatabasePort
            // 
            this.DatabasePort.Location = new System.Drawing.Point(292, 21);
            this.DatabasePort.Name = "DatabasePort";
            this.DatabasePort.Size = new System.Drawing.Size(48, 21);
            this.DatabasePort.TabIndex = 3;
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 145);
            this.Controls.Add(this.DatabasePort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DatabaseHost);
            this.Controls.Add(this.DatabaseNewPasswd);
            this.Controls.Add(this.DatabaseUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DatabaseUser;
        private System.Windows.Forms.TextBox DatabaseNewPasswd;
        private System.Windows.Forms.TextBox DatabaseHost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DatabasePort;
    }
}