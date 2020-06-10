namespace SmartLibrary
{
    partial class ReturnBookDialog
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_BookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_BorrowName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_BorrowTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Borrow_Lend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_BookID,
            this.columnHeader_BookName,
            this.columnHeader_BorrowName,
            this.columnHeader_BorrowTime,
            this.columnHeader_State,
            this.columnHeader_Borrow_Lend});
            this.listView1.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, -2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(807, 456);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_BookID
            // 
            this.columnHeader_BookID.Text = "图书编号";
            this.columnHeader_BookID.Width = 129;
            // 
            // columnHeader_BookName
            // 
            this.columnHeader_BookName.Text = "图书名称";
            this.columnHeader_BookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_BookName.Width = 129;
            // 
            // columnHeader_BorrowName
            // 
            this.columnHeader_BorrowName.Text = "借阅人名字";
            this.columnHeader_BorrowName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_BorrowName.Width = 151;
            // 
            // columnHeader_BorrowTime
            // 
            this.columnHeader_BorrowTime.Text = "借阅时间";
            this.columnHeader_BorrowTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_BorrowTime.Width = 144;
            // 
            // columnHeader_State
            // 
            this.columnHeader_State.Text = "借阅状态";
            this.columnHeader_State.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_State.Width = 128;
            // 
            // columnHeader_Borrow_Lend
            // 
            this.columnHeader_Borrow_Lend.Text = "";
            this.columnHeader_Borrow_Lend.Width = 131;
            // 
            // Back_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Back_Books";
            this.Text = "Back_Books";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_BookID;
        private System.Windows.Forms.ColumnHeader columnHeader_BookName;
        private System.Windows.Forms.ColumnHeader columnHeader_BorrowName;
        private System.Windows.Forms.ColumnHeader columnHeader_BorrowTime;
        private System.Windows.Forms.ColumnHeader columnHeader_State;
        private System.Windows.Forms.ColumnHeader columnHeader_Borrow_Lend;
    }
}