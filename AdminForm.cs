using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 学籍管理系统
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.汇总学校信息表”中。您可以根据需要移动或删除它。
            this.汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学校信息表”中。您可以根据需要移动或删除它。
            this.学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学校信息表);
            this.专业信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.专业信息表, collegeCodeComboBox.Text);
            this.班级信息表TableAdapter.FillByProfessionCode(this.studentinfomanagedatabaseDataSet.班级信息表, professionCodeComboBox.Text);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学生信息表”中。您可以根据需要移动或删除它。
            this.学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
            this.账户信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.账户信息表);
            collegeCodeComboBox.SelectedValueChanged += collegeCodeComboBox_SelectedValueChanged;
            professionCodeComboBox.SelectedValueChanged += professionCodeComboBox_SelectedValueChanged;
            classCodeComboBox.TextChanged += classCodeComboBox_TextChanged;
            //collegeTableDataGridView.CurrentCellChanged += collegeTableDataGridView_CurrentCellChanged;
        }

        void collegeTableDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
        }

        #region 学校管理panel

        #region 信息更新事件处理
        /// <summary>
        /// 从班级信息栏中的班级号控件框中获取班级号, 更新DataGridView选中状态
        /// </summary>
        void classCodeComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow myRow in collegeTableDataGridView.Rows)
                {
                    if (myRow.Cells[0].Value.ToString() == classCodeComboBox.Text)
                    {
                        collegeTableDataGridView.ClearSelection();
                        myRow.Selected = true;
                        collegeTableDataGridView.CurrentCell = myRow.Cells[0];
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// 从专业信息栏的专业代码控件框中获取专业代码, 更新班级信息栏
        /// </summary>
        void professionCodeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            班级信息表TableAdapter.FillByProfessionCode(this.studentinfomanagedatabaseDataSet.班级信息表, professionCodeComboBox.Text);
        }
        /// <summary>
        /// 从学校信息栏中的院系编号控件框获取院系编号, 更新专业信息栏
        /// </summary>
        void collegeCodeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            专业信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.专业信息表, collegeCodeComboBox.Text);
        }
        #endregion
        #region 查询按钮点击事件处理
        /// <summary>
        /// 专业代码查询按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void professionCodeQueryButton_Click(object sender, EventArgs e)
        {
            汇总学校信息表TableAdapter.FillByProfessionCode(this.studentinfomanagedatabaseDataSet.汇总学校信息表, professionCodeComboBox.Text);
            collegeTableDataGridView.ClearSelection();
        }
        /// <summary>
        /// 班级号查询按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classCodeQueryButton_Click(object sender, EventArgs e)
        {
            汇总学校信息表TableAdapter.FillByClassCode(this.studentinfomanagedatabaseDataSet.汇总学校信息表, classCodeComboBox.Text);
            collegeTableDataGridView.ClearSelection();
        }
        /// <summary>
        /// 院系编号查询按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collegeCodeQueryButton_Click(object sender, EventArgs e)
        {
            汇总学校信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.汇总学校信息表, collegeCodeComboBox.Text);
            collegeTableDataGridView.ClearSelection();
        }
        #endregion
        #region 删除按钮点击事件处理
        /// <summary>
        /// 班级信息删除按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classInfoDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var reasult = MessageBox.Show("是否删除该项数据", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reasult == DialogResult.Yes)
                {
                    班级信息表BindingSource.RemoveCurrent();
                    班级信息表TableAdapter.Update(this.studentinfomanagedatabaseDataSet.班级信息表);
                    班级信息表TableAdapter.FillByProfessionCode(this.studentinfomanagedatabaseDataSet.班级信息表, professionCodeComboBox.Text);
                    汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Delete failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// 专业信息删除按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void professionInfoDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var reasult = MessageBox.Show("是否删除该项数据", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reasult == DialogResult.Yes)
                {
                    专业信息表BindingSource.RemoveCurrent();
                    专业信息表TableAdapter.Update(this.studentinfomanagedatabaseDataSet.专业信息表);
                    专业信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.专业信息表, collegeCodeComboBox.Text);
                    汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Delete failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 院系信息删除按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collegeInfoDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var reasult = MessageBox.Show("是否删除该项数据", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reasult == DialogResult.Yes)
                {
                    学校信息表BindingSource.RemoveCurrent();
                    学校信息表TableAdapter.Update(this.studentinfomanagedatabaseDataSet.学校信息表);
                    学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学校信息表);
                    汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Delete failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion 
        #region 增加按钮点击事件处理
        /// <summary>
        /// 班级信息增加按钮点击事件处理 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classInfoAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                班级信息表TableAdapter.Insert(classCodeComboBox.Text, classComboBox.Text, professionCodeComboBox.Text, 0);
                班级信息表TableAdapter.FillByProfessionCode(this.studentinfomanagedatabaseDataSet.班级信息表, professionCodeComboBox.Text);
                汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
                MessageBox.Show("Add succeed");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Add failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 专业信息增加按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void professionInfoAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                专业信息表TableAdapter.Insert(professionCodeComboBox.Text, professionComboBox.Text, collegeCodeComboBox.Text, 0);
                专业信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.专业信息表, collegeCodeComboBox.Text);
                汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
                MessageBox.Show("Add succeed");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Add failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 院系信息增加按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collegeInfoAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                学校信息表TableAdapter.Insert(collegeCodeComboBox.Text, collegeComboBox.Text, 0);
                学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学校信息表);
                汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
                MessageBox.Show("Add succeed");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Add failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 用于学校信息管理panel的刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #endregion
        #region 更新按钮点击事件处理

        private void updateCollegeInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                DataRowView myDataRowView = (DataRowView)学校信息表BindingSource.Current;
                学校信息表TableAdapter.Update(collegeCodeComboBox.Text, collegeComboBox.Text, int.Parse(myDataRowView["专业数目"].ToString()), 
                    myDataRowView["院系编号"].ToString(), myDataRowView["学院名"].ToString(), int.Parse(myDataRowView["专业数目"].ToString()));
                学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学校信息表);
                汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
                MessageBox.Show("Update succeed");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateProfessionInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                DataRowView myDataRowView = (DataRowView)专业信息表BindingSource.Current;
                专业信息表TableAdapter.Update(professionCodeComboBox.Text, professionComboBox.Text, collegeCodeComboBox.Text, int.Parse(myDataRowView["班级数目"].ToString()), 
                    myDataRowView["专业代码"].ToString(), myDataRowView["专业名"].ToString(), myDataRowView["院系编号"].ToString(), int.Parse(myDataRowView["班级数目"].ToString()));
                专业信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.专业信息表, collegeCodeComboBox.Text);
                汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
                MessageBox.Show("Update succeed");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateClassInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                DataRowView myDataRowView = (DataRowView)班级信息表BindingSource.Current;
                班级信息表TableAdapter.Update(classCodeComboBox.Text, classComboBox.Text, professionCodeComboBox.Text, int.Parse(myDataRowView["班级人数"].ToString()),
                    myDataRowView["班级号"].ToString(), myDataRowView["班级名称"].ToString(), myDataRowView["专业代码"].ToString(), int.Parse(myDataRowView["班级人数"].ToString()));
                班级信息表TableAdapter.FillByProfessionCode(this.studentinfomanagedatabaseDataSet.班级信息表, professionCodeComboBox.Text);
                汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
                MessageBox.Show("Update succeed");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region 刷新按钮点击事件处理
        /// <summary>
        /// 刷新按钮点击事件处理
        /// </summary>
        private void refresh_Click(object sender, EventArgs e)
        {
            this.汇总学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.汇总学校信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学校信息表”中。您可以根据需要移动或删除它。
            this.学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学校信息表);
            专业信息表TableAdapter.FillByCollegeCode(this.studentinfomanagedatabaseDataSet.专业信息表, collegeCodeComboBox.Text);
            班级信息表TableAdapter.FillByProfessionCode(this.studentinfomanagedatabaseDataSet.班级信息表, professionCodeComboBox.Text);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学生信息表”中。您可以根据需要移动或删除它。
            this.学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
        }
        #endregion
        #endregion

        #region 学生信息管理panel
        private void queryByNameButton_Click(object sender, EventArgs e)
        {
            学生信息表TableAdapter.FillByStudentName(this.studentinfomanagedatabaseDataSet.学生信息表, 姓名TextBox.Text);
        }

        private void queryByPoliticalStatusButton_Click(object sender, EventArgs e)
        {
            学生信息表TableAdapter.FillByPoliticalStatus(this.studentinfomanagedatabaseDataSet.学生信息表, 政治面貌TextBox.Text);
        }

        private void queryByCollegeNameButton_Click(object sender, EventArgs e)
        {
            学生信息表TableAdapter.FillByCollegeName(this.studentinfomanagedatabaseDataSet.学生信息表, 院系名TextBox.Text);
        }

        private void queryByProfessionNameButton_Click(object sender, EventArgs e)
        {
            学生信息表TableAdapter.FillByProfessionName(this.studentinfomanagedatabaseDataSet.学生信息表, 专业名TextBox.Text);
        }

        private void queryByClassCodeButton_Click(object sender, EventArgs e)
        {
            学生信息表TableAdapter.FillByClassCode(this.studentinfomanagedatabaseDataSet.学生信息表, 班级号TextBox.Text);
        }

        private void addStudentInfoButton_Click(object sender, EventArgs e)
        {
            MyException myError;
            try
            {
                this.Validate();
                this.学生信息表BindingSource.EndEdit();


                #region 定义一些约束检查
                //
                // 找到当前输入专业名的专业代码
                // 
                DataRowCollection professionTableRows = 专业信息表TableAdapter.GetDataByProfessionName(专业名TextBox.Text).Rows;
                if (professionTableRows.Count != 0)
                {
                    // 获取代码字符串
                    string professionCode;
                    professionCode = professionTableRows[0]["专业代码"].ToString();
                    // 找到当前专业代码的班级号集合
                    DataRowCollection classTableRows = 班级信息表TableAdapter.GetDataByProfessionCode(professionCode).Rows;
                    if (!classTableRows.Contains(班级号TextBox.Text))
                    {
                        myError = new MyException(班级号TextBox.Text + "在该专业不存在, 请重新输入");
                        throw myError;
                    }
                }
                else
                {
                    myError = new MyException(专业名TextBox.Text + "不存在, 请重新输入");
                    throw myError;
                }

                if (!(性别TextBox.Text.Equals("男") || 性别TextBox.Text.Equals("女")))
                {
                    myError = new MyException("性别: " + 性别TextBox.Text + "不存在, 请重新输入");
                    throw myError;
                }
                #endregion

                学生信息表TableAdapter.Insert(学号TextBox.Text, 姓名TextBox.Text, 性别TextBox.Text, 出生日期DateTimePicker.Value,
                    政治面貌TextBox.Text, 入学时间DateTimePicker.Value, 院系名TextBox.Text, 专业名TextBox.Text, 班级号TextBox.Text,
                    电话号码TextBox.Text, 身份证号码TextBox.Text, 详细家庭住址TextBox.Text, null, 备注TextBox.Text, int.Parse(creditTextBox.Text));
                //
                // 直接向数据库中插入新数据后, dategridView不会更新, 需要fill一次更新bindSource
                //
                学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
                MessageBox.Show("Add Successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Add failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateStudentInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.学生信息表BindingSource.EndEdit();
                this.学生信息表TableAdapter.Update(this.studentinfomanagedatabaseDataSet.学生信息表);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteStudentInfoButton_Click(object sender, EventArgs e)
        {

            try
            {
                var reasult = MessageBox.Show("是否删除选中行数据", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reasult == DialogResult.Yes)
                {
                    int selectRowsCount;
                    selectRowsCount = dataGridView1.SelectedRows.Count;
                    DataGridViewRow[] myRows = new DataGridViewRow[selectRowsCount];
                    dataGridView1.SelectedRows.CopyTo(myRows, 0);
                    for (int i = 0; i < selectRowsCount; i++)
                    {
                        dataGridView1.Rows.Remove(myRows[i]);
                    }
                    学生信息表TableAdapter.Update(this.studentinfomanagedatabaseDataSet.学生信息表);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Delete failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cleanQueryButton_Click(object sender, EventArgs e)
        {
            学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
        }

        private void choosePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDiaolg = new OpenFileDialog();
            string imageFilePath;
            fileDiaolg.Filter = "图片文件|*.jpg; *.jpeg; *.png; *.bmp|JPEG|*.jpg; *.jpeg|PNG|*.png|位图文件|*.bmp";
            if (fileDiaolg.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = fileDiaolg.FileName;
                照片PictureBox.Image = Image.FromFile(imageFilePath);
            }
        }
        #endregion

        #region 账户信息管理panel
        private void accountNameQueryButton_Click(object sender, EventArgs e)
        {
            账户信息表TableAdapter.FillByAccountName(this.studentinfomanagedatabaseDataSet.账户信息表, 账户名TextBox.Text);
        }

        private void accountCategoryButton_Click(object sender, EventArgs e)
        {
            账户信息表TableAdapter.FillByAccountCategory(this.studentinfomanagedatabaseDataSet.账户信息表, 账户类别TextBox.Text);
        }

        private void accountAuthorityButton_Click(object sender, EventArgs e)
        {
            账户信息表TableAdapter.FillByAccountAuthority(this.studentinfomanagedatabaseDataSet.账户信息表, int.Parse(账户权限TextBox.Text));
        }

        private void cleanAccountQueryButton_Click(object sender, EventArgs e)
        {
            账户信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.账户信息表);
        }

        private void accountInfoUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.账户信息表BindingSource.EndEdit();
                this.账户信息表TableAdapter.Update(this.studentinfomanagedatabaseDataSet.账户信息表);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addAccountRecordbutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.账户信息表BindingSource.EndEdit();

                账户信息表TableAdapter.Insert(账户名TextBox.Text, 账户密码TextBox.Text, 账户类别TextBox.Text, int.Parse(账户权限TextBox.Text));
                //
                // 直接向数据库中插入新数据后, dategridView不会更新, 需要fill一次更新bindSource
                //
                账户信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.账户信息表);
                MessageBox.Show("Add Successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Add failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteAccountRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                var reasult = MessageBox.Show("是否删除选中行数据", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reasult == DialogResult.Yes)
                {
                    int selectRowsCount;
                    selectRowsCount = 账户信息表DataGridView.SelectedRows.Count;
                    DataGridViewRow[] myRows = new DataGridViewRow[selectRowsCount];
                    账户信息表DataGridView.SelectedRows.CopyTo(myRows, 0);
                    for (int i = 0; i < selectRowsCount; i++)
                    {
                        账户信息表DataGridView.Rows.Remove(myRows[i]);
                    }
                    账户信息表TableAdapter.Update(this.studentinfomanagedatabaseDataSet.账户信息表);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Delete failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void exitSystemLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
    /// <summary>
    /// 自定义异常类
    /// </summary>
    public class MyException : ApplicationException
    {
        public MyException(string message) : base(message) { }
    }
}