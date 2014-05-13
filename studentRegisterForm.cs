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
    public partial class StudentRegisterForm : Form
    {
        public StudentRegisterForm()
        {
            InitializeComponent();
        }

        private void commitbutton_Click(object sender, EventArgs e)
        {
            MyException myError;
            try
            {
                //
                // 找到当前输入学号,是否存在数据库
                // 
                DataRowCollection studentTableRows = 学生信息表TableAdapter.GetDataByStudentID(userNameTextBox.Text).Rows;
                if (studentTableRows.Count == 0)
                {

                    myError = new MyException("学号" + userNameTextBox.Text + "不存在, 请重新输入");
                    throw myError;
                }
                else if(passwordTextBox.Text.CompareTo(passwordConfirmTextBox.Text) == 0)
                {
                    studentAccountRegisterTableAdapter1.Insert(userNameTextBox.Text, passwordTextBox.Text, "学生", 3);
                    MessageBox.Show("注册成功");
                }
                else
                {
                    MessageBox.Show("确认密码必须一致", "提示");
                    passwordTextBox.Clear();
                    passwordConfirmTextBox.Clear();
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("注册失败:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitStudentRegisterFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
