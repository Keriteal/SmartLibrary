using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLibrary
{
    public partial class LectureInfo : UserControl
    {
        DateTime _dtstart;
        DateTime _dtend;
        [Category("自定义")]
        public string lName
        {
            get
            {
                return lectureName.Text;
            }
            set
            {
                lectureName.Text = value;
            }
        }
        [Category("自定义")]
        public string lDescription
        {
            get
            {
                return lectureDescription.Text;
            }
            set
            {
                lectureDescription.Text = value;
            }
        }
        [Category("自定义")]
        public DateTime lStart
        {
            set
            {
                TimeStart.Text = $"{value.Year}-{value.Month}-{value.Day} {value.Hour}:{value.Minute}";
                _dtstart = value;
            }
            get
            {
                return _dtstart;
            }
        }
        [Category("自定义")]
        public DateTime lEnd
        {
            get
            {
                return _dtend;
            }
            set
            {
                TimeEnd.Text = $"{value.Year}-{value.Month}-{value.Day} {value.Hour}:{value.Minute}";
                _dtend = value;
            }
        }

        public LectureInfo()
        {
            InitializeComponent();
        }

        public LectureInfo(string name, string description, string start, string end) : this()
        {
            this.lName = name;
            lDescription = description;
            lStart = Convert.ToDateTime(start);
            lEnd = Convert.ToDateTime(end);

        }

        private void LectureInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
