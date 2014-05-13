using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学籍管理系统
{
    public partial class StudentInfoForm : Form
    {
        private string studentID;
        public StudentInfoForm(string studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
        }

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            学生信息表TableAdapter.FillByStudentID(this.studentinfomanagedatabaseDataSet.学生信息表, studentID);
        }
    }
}
