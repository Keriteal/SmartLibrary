namespace SmartLibrary
{
    partial class LectureInfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lectureName = new System.Windows.Forms.Label();
            this.lectureDescription = new System.Windows.Forms.Label();
            this.TimeStart = new System.Windows.Forms.Label();
            this.TimeEnd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lectureName
            // 
            this.lectureName.AutoSize = true;
            this.lectureName.Location = new System.Drawing.Point(6, 6);
            this.lectureName.Margin = new System.Windows.Forms.Padding(6);
            this.lectureName.Name = "lectureName";
            this.lectureName.Size = new System.Drawing.Size(29, 12);
            this.lectureName.TabIndex = 0;
            this.lectureName.Text = "name";
            // 
            // lectureDescription
            // 
            this.lectureDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lectureDescription.Location = new System.Drawing.Point(10, 27);
            this.lectureDescription.Margin = new System.Windows.Forms.Padding(10, 3, 10, 0);
            this.lectureDescription.Name = "lectureDescription";
            this.lectureDescription.Size = new System.Drawing.Size(121, 39);
            this.lectureDescription.TabIndex = 1;
            this.lectureDescription.Text = "description";
            // 
            // TimeStart
            // 
            this.TimeStart.AutoSize = true;
            this.TimeStart.Location = new System.Drawing.Point(6, 78);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(101, 12);
            this.TimeStart.TabIndex = 2;
            this.TimeStart.Text = "2020-06-14 19:42";
            // 
            // TimeEnd
            // 
            this.TimeEnd.AutoSize = true;
            this.TimeEnd.Location = new System.Drawing.Point(6, 106);
            this.TimeEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(101, 12);
            this.TimeEnd.TabIndex = 3;
            this.TimeEnd.Text = "2020-06-14 19:42";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "到";
            // 
            // LectureInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeEnd);
            this.Controls.Add(this.TimeStart);
            this.Controls.Add(this.lectureDescription);
            this.Controls.Add(this.lectureName);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "LectureInfo";
            this.Size = new System.Drawing.Size(141, 121);
            this.Load += new System.EventHandler(this.LectureInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lectureName;
        private System.Windows.Forms.Label lectureDescription;
        private System.Windows.Forms.Label TimeStart;
        private System.Windows.Forms.Label TimeEnd;
        private System.Windows.Forms.Label label3;
    }
}
