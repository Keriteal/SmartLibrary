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
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnPreorder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnToEdit = new System.Windows.Forms.Button();
            this.btnLend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBorrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrow.BackgroundImage")));
            this.btnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrow.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnBorrow.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBorrow.Location = new System.Drawing.Point(463, 120);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(86, 48);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.TabStop = false;
            this.btnBorrow.Text = "借书";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnPreorder
            // 
            this.btnPreorder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPreorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPreorder.BackgroundImage")));
            this.btnPreorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreorder.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnPreorder.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPreorder.Location = new System.Drawing.Point(413, 206);
            this.btnPreorder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreorder.Name = "btnPreorder";
            this.btnPreorder.Size = new System.Drawing.Size(108, 58);
            this.btnPreorder.TabIndex = 2;
            this.btnPreorder.Text = "预约座位";
            this.btnPreorder.UseVisualStyleBackColor = false;
            this.btnPreorder.Click += new System.EventHandler(this.btnPreorder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("华文楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 341);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "公告";
            // 
            // btnToEdit
            // 
            this.btnToEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnToEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToEdit.BackgroundImage")));
            this.btnToEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToEdit.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnToEdit.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnToEdit.Location = new System.Drawing.Point(311, 293);
            this.btnToEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnToEdit.Name = "btnToEdit";
            this.btnToEdit.Size = new System.Drawing.Size(108, 58);
            this.btnToEdit.TabIndex = 5;
            this.btnToEdit.Text = "修改信息";
            this.btnToEdit.UseVisualStyleBackColor = false;
            this.btnToEdit.Click += new System.EventHandler(this.btnToEdit_Click);
            // 
            // btnLend
            // 
            this.btnLend.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLend.BackgroundImage")));
            this.btnLend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLend.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnLend.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLend.Location = new System.Drawing.Point(424, 30);
            this.btnLend.Margin = new System.Windows.Forms.Padding(2);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(86, 48);
            this.btnLend.TabIndex = 6;
            this.btnLend.TabStop = false;
            this.btnLend.Text = "还书";
            this.btnLend.UseVisualStyleBackColor = false;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.btnToEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPreorder);
            this.Controls.Add(this.btnBorrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = " 主菜單";
            this.Load += new System.EventHandler(this.Login_interface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnPreorder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnToEdit;
        private System.Windows.Forms.Button btnLend;
    }
}