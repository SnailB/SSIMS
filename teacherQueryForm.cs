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
    public partial class TeacherQueryForm : Form
    {
        public TeacherQueryForm()
        {
            InitializeComponent();
        }

        private void 学校信息表BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.学校信息表BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentinfomanagedatabaseDataSet);

        }

        private void teacherQueryForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.班级信息表”中。您可以根据需要移动或删除它。
            this.班级信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.班级信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学校信息表”中。您可以根据需要移动或删除它。
            this.学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学校信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.专业信息表”中。您可以根据需要移动或删除它。
            this.专业信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.专业信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学生信息表”中。您可以根据需要移动或删除它。
            this.学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学生信息表”中。您可以根据需要移动或删除它。
            this.学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.班级信息表”中。您可以根据需要移动或删除它。
            this.班级信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.班级信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学校信息表”中。您可以根据需要移动或删除它。
            this.学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学校信息表);

            学院名ComboBox.TextChanged += 学院名ComboBox_SelectedValueChanged;
            专业名ComboBox.TextChanged += 专业名ComboBox_SelectedValueChanged;
            班级号ComboBox.SelectedValueChanged += 班级号ComboBox_SelectedValueChangedChanged;

            //DataRowCollection schoolTableRows = 学校信息表TableAdapter.GetDataByCollegeName(学院名ComboBox.Text).Rows;
            //if (schoolTableRows.Count != 0)
            //{
            //    string collegeCode;
            //    collegeCode = schoolTableRows[0]["院系编号"].ToString();
            //    专业信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.专业信息表, collegeCode);
            //}
            //else
            //{
            //    //专业信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.专业信息表, "-1");
            //    专业名ComboBox.Text = null;
            //}


            DataRowCollection professionTableRows = 专业信息表TableAdapter.GetDataByProfessionName(专业名ComboBox.Text).Rows;
            if (professionTableRows.Count != 0)
            {
                string professionCode;
                professionCode = professionTableRows[0]["专业代码"].ToString();
                班级信息表TableAdapter.FillByProfessionCode(this.studentinfomanagedatabaseDataSet.班级信息表, professionCode);
            }
            else
            {
                班级号ComboBox.Text = null;
            }
        }
        // there are still some wrong!!!
        void 班级号ComboBox_SelectedValueChangedChanged(object sender, EventArgs e)
        {
            学生信息表TableAdapter.FillByClassCode(this.studentinfomanagedatabaseDataSet.学生信息表, 班级号ComboBox.Text);
        }

        void 专业名ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowCollection professionTableRows = 专业信息表TableAdapter.GetDataByProfessionName(专业名ComboBox.Text).Rows;
            //MessageBox.Show(专业名ComboBox.Text);
            if (professionTableRows.Count != 0)
            {
                string professionCode;
                professionCode = professionTableRows[0]["专业代码"].ToString();
                班级信息表TableAdapter.FillByProfessionCode(this.studentinfomanagedatabaseDataSet.班级信息表, professionCode);
            }
            else
            {
                班级信息表TableAdapter.FillByProfessionCode(this.studentinfomanagedatabaseDataSet.班级信息表, "-1");
                //班级号ComboBox.Text = null;
            }
        }

        void 学院名ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowCollection schoolTableRows = 学校信息表TableAdapter.GetDataByCollegeName(学院名ComboBox.Text).Rows;
            if (schoolTableRows.Count != 0)
            {
                string collegeCode;
                collegeCode = schoolTableRows[0]["院系编号"].ToString();
                专业信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.专业信息表, collegeCode);
            }
            else
            {
                专业信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.专业信息表, "-1");
                //专业名ComboBox.Text = null;
            }
        }

        private void queryByNameButton_Click(object sender, EventArgs e)
        {
            学生信息表TableAdapter.FillByStudentName(this.studentinfomanagedatabaseDataSet.学生信息表, studentNameTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            学生信息表TableAdapter.FillByStudentID(this.studentinfomanagedatabaseDataSet.学生信息表, studentCodeTextBox.Text);
        }

        private void cleanQueryButton_Click(object sender, EventArgs e)
        {
            学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
        }
    }
}
