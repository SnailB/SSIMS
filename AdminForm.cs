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
        MySqlConnectionStringBuilder connectStringBuilder;
        MySqlConnection myConnection;
        MySqlCommand myCommand;
        MySqlDataAdapter myAdapter;
        DataTable myDataTable;
        BindingSource professionBindingSource = new BindingSource();
        BindingSource classBindingSource = new BindingSource();
        BindingSource tableBindingSource = new BindingSource();
        public AdminForm()
        {
            InitializeComponent();
            #region 初始化数据库连接
            connectStringBuilder = new MySqlConnectionStringBuilder();
            connectStringBuilder.Database = "studentinfomanagedatabase";
            connectStringBuilder.Server = "localhost";
            connectStringBuilder.UserID = "root";
            connectStringBuilder.Password = "slowly";
            #endregion
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.账户信息表”中。您可以根据需要移动或删除它。
            this.账户信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.账户信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学生信息表”中。您可以根据需要移动或删除它。
            this.学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学生信息表”中。您可以根据需要移动或删除它。
            this.学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学生信息表”中。您可以根据需要移动或删除它。
            this.学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学生信息表”中。您可以根据需要移动或删除它。
            this.学生信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学生信息表);
            InitPanelOne();
        }

        #region 学校管理panel
        /// <summary>
        /// 用于初始化学校管理panel的显示
        /// </summary>
        private void InitPanelOne()
        {
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学校信息表”中。您可以根据需要移动或删除它。
            this.学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学校信息表);

            collegeCodeComboBox.SelectedValueChanged += collegeCodeComboBox_SelectedValueChanged;
            professionCodeComboBox.SelectedValueChanged += professionCodeComboBox_SelectedValueChanged;
            classCodeComboBox.SelectedValueChanged += classCodeComboBox_SelectedValueChanged;

            myConnection = new MySqlConnection(connectStringBuilder.ConnectionString);
            //
            // 初始化专业信息栏
            //
            string professionSelectQuery = "select 专业名, 专业代码 from 专业信息表 where (院系编号 = '$collegeCode')";
            professionSelectQuery = professionSelectQuery.Replace("$collegeCode", collegeCodeComboBox.Text);
            // 更新数据源
            UpdateDataSource(professionBindingSource, professionSelectQuery);
            // 绑定数据源
            //professionComboBox.DisplayMember = "专业名";
            professionComboBox.ValueMember = "专业名";
            professionComboBox.DataSource = professionBindingSource;
            //professionCodeComboBox.DisplayMember = "专业代码";
            professionCodeComboBox.ValueMember = "专业代码";
            professionCodeComboBox.DataSource = professionBindingSource;
            //
            // 初始化班级信息栏
            //
            string classSelectQuery = "select 班级名称, 班级号 from 班级信息表 where (专业代码 = '$professionCode')";
            classSelectQuery = classSelectQuery.Replace("$professionCode", professionCodeComboBox.Text);
            // 更新数据源
            UpdateDataSource(classBindingSource, classSelectQuery);
            // 绑定数据源
            classComboBox.DataSource = classBindingSource;
            classComboBox.ValueMember = "班级名称";
            classCodeComboBox.DataSource = classBindingSource;
            classCodeComboBox.ValueMember = "班级号";
            //
            // 初始化汇总信息表
            //
            SetCollegeTableDataGridView();
        }
        #region 信息更新事件处理
        /// <summary>
        /// 从班级信息栏中的班级号控件框中获取班级号, 更新DataGridView选中状态
        /// </summary>
        void classCodeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow myRow in collegeTableDataGridView.Rows)
            {
                if (myRow.Cells["班级号"].Value.ToString() == classCodeComboBox.Text)
                {
                    collegeTableDataGridView.ClearSelection();
                    myRow.Selected = true;
                    collegeTableDataGridView.CurrentCell = myRow.Cells["班级号"];
                }
            }
        }
        /// <summary>
        /// 从专业信息栏的专业代码控件框中获取专业代码, 更新班级信息栏
        /// </summary>
        void professionCodeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string classSelectQuery = "select 班级名称, 班级号 from 班级信息表 where (专业代码 = '$professionCode')";
            classSelectQuery = classSelectQuery.Replace("$professionCode", professionCodeComboBox.Text);
            UpdateDataSource(classBindingSource, classSelectQuery);
        }
        /// <summary>
        /// 从学校信息栏中的院系编号控件框获取院系编号, 更新专业信息栏
        /// </summary>
        void collegeCodeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string professionSelectQuery = "select 专业名, 专业代码 from 专业信息表 where (院系编号 = '$collegeCode')";
            professionSelectQuery = professionSelectQuery.Replace("$collegeCode", collegeCodeComboBox.Text);
            UpdateDataSource(professionBindingSource, professionSelectQuery);
        }
        #endregion
        #region 用于操作数据库的一些方法
        /// <summary>
        /// 用于更新数据源的方法
        /// </summary>
        /// <param name="myBindingSource"> 需要更新的数据源</param>
        /// <param name="commandString">用于更新数据源的SQL语句</param>
        private void UpdateDataSource(BindingSource myBindingSource, string commandString)//, ComboBox updateComboBox, string DataMember)
        {
            myCommand = myConnection.CreateCommand();
            myConnection.Close();
            myCommand.CommandText = commandString;
            myAdapter = new MySqlDataAdapter(myCommand);
            //
            // 需要创建一个新的引用, 否则无法获取更新后的数据源, 目前不知道为什么
            // 使用ComboBox控件的DataBindings绑定数据源后也无法更新, 且只能获取数据表的一行记录, 目前不知道为什么
            //
            myDataTable = new DataTable();
            myAdapter.Fill(myDataTable);
            myDataTable.TableName = "InfoTable";
            myBindingSource.DataSource = myDataTable;
        }
        /// <summary>
        /// 设置CollegeTableDataGridView控件用于预览汇总后的信息表
        /// </summary>
        private void SetCollegeTableDataGridView()
        {
            // 初始化汇总信息表
            string totalTableSelectQuery = "select 班级信息表.班级号, 班级名称, 专业信息表.专业代码, 专业名,  专业信息表.院系编号, 学院名, tmp.班级人数 " +
                                            "from 班级信息表 join 专业信息表 on 班级信息表.专业代码 = 专业信息表.专业代码 " +
                                            "join 学校信息表 on 专业信息表.院系编号 = 学校信息表.院系编号 " +
                                            "left join (SELECT 学生信息表.班级号, COUNT(学生信息表.班级号) AS '班级人数' " +
                                            "FROM 学生信息表  group by 班级号) as tmp on 班级信息表.班级号 = tmp.班级号";
            myCommand = myConnection.CreateCommand();
            myConnection.Close();
            myCommand.CommandText = totalTableSelectQuery;
            myAdapter = new MySqlDataAdapter(myCommand);
            myDataTable = new DataTable();
            myAdapter.Fill(myDataTable);
            myDataTable.TableName = "Table";
            tableBindingSource.DataSource = myDataTable;

            collegeTableDataGridView.DataSource = tableBindingSource;
            // 初始化选中行
            foreach (DataGridViewRow myRow in collegeTableDataGridView.Rows)
            {
                if (myRow.Cells["班级号"].Value.ToString() == classCodeComboBox.Text)
                {
                    collegeTableDataGridView.ClearSelection();
                    myRow.Selected = true;
                    collegeTableDataGridView.FirstDisplayedScrollingColumnIndex = myRow.Index;
                }
            }
        }
        /// <summary>
        /// 用于将查询到的信息在DataGridView控件中,将其设为选中状态
        /// </summary>
        /// <param name="queryFieldComboBox">用于获取查询条件内容的ComboBox控件</param>
        private void QueryAndSelect(ComboBox queryFieldComboBox)
        {
            bool firstTimeGetIn = true;
            collegeTableDataGridView.ClearSelection();
            //
            // 遍历collegeTableDataGridView的Row集合, 将符合查询条件的Row设置为选中状态并将选中行的第一行设置为当前活动行
            //
            foreach (DataGridViewRow myRow in collegeTableDataGridView.Rows)
            {
                if (myRow.Cells[queryFieldComboBox.DisplayMember].Value.ToString() == queryFieldComboBox.Text)
                {
                    // 将符合查询条件的所有行设置为选中状态
                    myRow.Selected = true;
                    // 设置选中行的第一行设置为当前活动行
                    if (firstTimeGetIn)
                    {
                        collegeTableDataGridView.CurrentCell = myRow.Cells[queryFieldComboBox.DisplayMember];
                        firstTimeGetIn = false;
                    }
                }
            }
        }
        /// <summary>
        /// 用于删除数据库中某一个表中的某一条记录
        /// </summary>
        /// <param name="deletedTableName">需要删除数据的表名</param>
        /// <param name="primaryField">需要删除数据的字段</param>
        /// <param name="value">需要删除的数据项</param>
        private void DeleteOneRecord(BindingSource myBindingSource, string deletedTableName, string primaryField, string value)
        {
            string deleteCommand = "delete from $deletedTableName where ( $primaryField = @value )";
            // 使用字符串对象的Replace方法替换用于删除数据的SQL语句里的自定义变量,$deletedTableName和$primaryField
            deleteCommand = deleteCommand.Replace("$deletedTableName", deletedTableName);
            deleteCommand = deleteCommand.Replace("$primaryField", primaryField);

            myCommand = myConnection.CreateCommand();
            myCommand.CommandText = deleteCommand;
            // 使用设置MySql提供的标准变量, @value
            myCommand.Parameters.AddWithValue("@value", value);
            myAdapter = new MySqlDataAdapter(myCommand);
            // 更新数据库
            DataTable myDataTable = new DataTable();
            myAdapter.Fill(myDataTable);
            myDataTable.TableName = "InfoTable";
            myBindingSource.DataSource = myDataTable;
        }
        /// <summary>
        /// 用于向数据库添加一条记录
        /// </summary>
        /// <param name="addCommand">添加数据的SQL语句</param>
        private void AddOneRecord(MySqlCommand addCommand)
        {
            myAdapter = new MySqlDataAdapter(addCommand);
            myAdapter.Fill(new DataTable());
        }
        /// <summary>
        /// 用于更新一条数据库记录
        /// </summary>
        private void UpdateOneRecord(BindingSource myBindingSource, string updateTable, ComboBox comboBox, ComboBox codeComboBox)
        {
            try
            {
                string field_1 = codeComboBox.DisplayMember;
                string field_2 = comboBox.DisplayMember;
                string updateCommandString = "update $updateTable set $field_2 = '$value2' where $field_1 = '$value1'";
                updateCommandString = updateCommandString.Replace("$updateTable", updateTable);
                updateCommandString = updateCommandString.Replace("$field_2", field_2);
                updateCommandString = updateCommandString.Replace("$field_1", field_1);
                updateCommandString = updateCommandString.Replace("$value1", codeComboBox.Text);
                updateCommandString = updateCommandString.Replace("$value2", comboBox.Text);
                myCommand = myConnection.CreateCommand();
                myCommand.CommandText = updateCommandString;
                myAdapter = new MySqlDataAdapter(myCommand);

                DataTable myDataTable = new DataTable();
                myAdapter.Fill(myDataTable);
                myBindingSource.DataSource = myDataTable;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            QueryAndSelect(professionCodeComboBox);
        }
        /// <summary>
        /// 班级号查询按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classCodeQueryButton_Click(object sender, EventArgs e)
        {
            QueryAndSelect(classCodeComboBox);
        }
        /// <summary>
        /// 院系编号查询按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collegeCodeQueryButton_Click(object sender, EventArgs e)
        {
            QueryAndSelect(collegeCodeComboBox);
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
            //    
            // 应该先进行检查外键约束, 当前删除项对应的学生信息表中相应项是否为空, 并给出提示
            //
            if (true)
            {

            }
            if (classCodeComboBox.Text != string.Empty)
            {
                DeleteOneRecord(classBindingSource, "班级信息表", "班级号", classCodeComboBox.Text);
                SetCollegeTableDataGridView();
            }

        }
        /// <summary>
        /// 专业信息删除按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void professionInfoDeleteButton_Click(object sender, EventArgs e)
        {
            //    
            // 应该先进行检查外键约束, 当前删除项对应的班级信息表中相应项是否为空, 并给出提示
            //
            if (true)
            {

            }
            if (professionCodeComboBox.Text != string.Empty)
            {
                DeleteOneRecord(professionBindingSource, "专业信息表", "专业代码", professionCodeComboBox.Text);
                
            }
        }
        /// <summary>
        /// 院系信息删除按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collegeInfoDeleteButton_Click(object sender, EventArgs e)
        {
            //    
            // 应该先进行检查外键约束, 当前删除项对应的专业信息表中相应项是否为空, 并给出提示
            //
            if (true)
            {

            }
            if (collegeCodeComboBox.Text != string.Empty)
            {
                DeleteOneRecord(学校信息表BindingSource, "学校信息表", "院系编号", collegeCodeComboBox.Text);
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
            MySqlCommand addCommand = myConnection.CreateCommand();
            string addCommandString = "insert into 班级信息表 values(@classCode, @className, @professionCode, @studentCountOfClass)";
            addCommand.CommandText = addCommandString;
            addCommand.Parameters.AddWithValue("@classCode", classCodeComboBox.Text);
            addCommand.Parameters.AddWithValue("@className", classComboBox.Text);
            addCommand.Parameters.AddWithValue("@professionCode", professionCodeComboBox.Text);
            addCommand.Parameters.AddWithValue("@studentCountOfClass", 0);
            AddOneRecord(addCommand);
            SetCollegeTableDataGridView();

            string classSelectQuery = "select 班级名称, 班级号 from 班级信息表 where (专业代码 = '$professionCode')";
            classSelectQuery = classSelectQuery.Replace("$professionCode", professionCodeComboBox.Text);
            UpdateDataSource(classBindingSource, classSelectQuery);
        }
        /// <summary>
        /// 专业信息增加按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void professionInfoAddButton_Click(object sender, EventArgs e)
        {
            MySqlCommand addCommand = myConnection.CreateCommand();
            string addCommandString = "insert into 专业信息表 values(@professionCode, @professionName, @collegeCode, @classCountOfProfession)";
            addCommand.CommandText = addCommandString;
            addCommand.Parameters.AddWithValue("@professionCode", professionCodeComboBox.Text);
            addCommand.Parameters.AddWithValue("@professionName", professionComboBox.Text);
            addCommand.Parameters.AddWithValue("@collegeCode", collegeCodeComboBox.Text);
            addCommand.Parameters.AddWithValue("@classCountOfProfession", 0);
            AddOneRecord(addCommand);
            string professionSelectQuery = "select 专业名, 专业代码 from 专业信息表 where (院系编号 = '$collegeCode')";
            professionSelectQuery = professionSelectQuery.Replace("$collegeCode", collegeCodeComboBox.Text);
            
            UpdateDataSource(professionBindingSource, professionSelectQuery);
        }
        /// <summary>
        /// 院系信息增加按钮点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collegeInfoAddButton_Click(object sender, EventArgs e)
        {
            MySqlCommand addCommand = myConnection.CreateCommand();
            string addCommandString = "insert into 学校信息表 values(@collegeCode, @collegeName, @professionCountOfCollege)";
            addCommand.CommandText = addCommandString;
            addCommand.Parameters.AddWithValue("@collegeCode", collegeCodeComboBox.Text);
            addCommand.Parameters.AddWithValue("@collegeName", collegeComboBox.Text);
            addCommand.Parameters.AddWithValue("@professionCountOfCollege", 0);
            MessageBox.Show(addCommand.CommandText);
            AddOneRecord(addCommand);

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
            UpdateOneRecord(学校信息表BindingSource, "学校信息表", collegeComboBox, collegeCodeComboBox);
            InitPanelOne();
        }

        private void updateProfessionInfoButton_Click(object sender, EventArgs e)
        {
            UpdateOneRecord(professionBindingSource, "专业信息表", professionComboBox, professionCodeComboBox);
            InitPanelOne();
        }

        private void updateClassInfoButton_Click(object sender, EventArgs e)
        {
            UpdateOneRecord(classBindingSource, "班级信息表", classComboBox, classCodeComboBox);
            InitPanelOne();
        }
        #endregion
        #region 刷新按钮点击事件处理
        /// <summary>
        /// 刷新按钮点击事件处理
        /// </summary>
        private void refresh_Click(object sender, EventArgs e)
        {
            InitPanelOne();
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
                    电话号码TextBox.Text, 身份证号码TextBox.Text, 详细家庭住址TextBox.Text, null, 备注TextBox.Text);
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
            //this.Close();
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