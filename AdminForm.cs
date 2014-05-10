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
            #region 学校管理panel
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.学校信息表”中。您可以根据需要移动或删除它。
            this.学校信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.学校信息表);

            collegeCodeComboBox.TextChanged += collegeCodeComboBox_TextChanged;
            professionCodeComboBox.TextChanged += professionCodeComboBox_TextChanged;
            classCodeComboBox.TextChanged += classCodeComboBox_TextChanged;
            //classCodeComboBox.MouseClick += classCodeComboBox_MouseClick;
            //classCodeComboBox.MouseLeave += classCodeComboBox_MouseLeave;
            //professionCodeComboBox.MouseClick += professionCodeComboBox_MouseClick;
            //professionCodeComboBox.MouseLeave += professionCodeComboBox_MouseLeave;

            myConnection = new MySqlConnection(connectStringBuilder.ConnectionString);
            // 初始化专业信息栏
            string professionSelectQuery = "select 专业名, 专业代码 from 专业信息表 where (院系编号 = '$collegeCode')";
            professionSelectQuery = professionSelectQuery.Replace("$collegeCode", collegeCodeComboBox.Text);
            UpdateDataSource(professionBindingSource, professionSelectQuery, professionComboBox, "专业名");
            UpdateDataSource(professionBindingSource, professionSelectQuery, professionCodeComboBox, "专业代码");
            //professionCodeComboBox.DataBindings.Add("Text", professionBindingSource, "专业代码", true, DataSourceUpdateMode.OnPropertyChanged);
            // 初始化班级信息栏
            string classSelectQuery = "select 班级名称, 班级号 from 班级信息表 where (专业代码 = '$professionCode')";
            classSelectQuery = classSelectQuery.Replace("$professionCode", professionCodeComboBox.Text);
            UpdateDataSource(classBindingSource, classSelectQuery, classComboBox, "班级名称");
            UpdateDataSource(classBindingSource, classSelectQuery, classCodeComboBox, "班级号");
            //classCodeComboBox.DataBindings.Add("Text", classBindingSource, "班级号", true, DataSourceUpdateMode.OnPropertyChanged);
            // 初始化汇总信息表
            SetCollegeTableDataGridView();


            #endregion
        }

        //void professionCodeComboBox_MouseLeave(object sender, EventArgs e)
        //{
        //    professionCodeComboBox.TextChanged += professionCodeComboBox_TextChanged;
        //}

        //void professionCodeComboBox_MouseClick(object sender, MouseEventArgs e)
        //{
        //    professionCodeComboBox.TextChanged -= professionCodeComboBox_TextChanged;
        //}

        //void classCodeComboBox_MouseLeave(object sender, EventArgs e)
        //{
        //    classCodeComboBox.TextChanged += classCodeComboBox_TextChanged;
        //}

        //void classCodeComboBox_MouseClick(object sender, MouseEventArgs e)
        //{
        //    classCodeComboBox.TextChanged -= classCodeComboBox_TextChanged;
        //}

        //
        // 更新DataGridView选中状态
        //
        void classCodeComboBox_TextChanged(object sender, EventArgs e)
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
        //
        // 更新班级信息栏
        //
        void professionCodeComboBox_TextChanged(object sender, EventArgs e)
        {
            string classSelectQuery = "select 班级名称, 班级号 from 班级信息表 where (专业代码 = '$professionCode')";
            classSelectQuery = classSelectQuery.Replace("$professionCode", professionCodeComboBox.Text);
            UpdateDataSource(classBindingSource, classSelectQuery, classComboBox, "班级名称");
            UpdateDataSource(classBindingSource, classSelectQuery, classCodeComboBox, "班级号");
            //MessageBox.Show("heh");
        }

        //
        // 更新专业信息栏
        //
        void collegeCodeComboBox_TextChanged(object sender, EventArgs e)
        {
            string professionSelectQuery = "select 专业名, 专业代码 from 专业信息表 where (院系编号 = '$collegeCode')";
            professionSelectQuery = professionSelectQuery.Replace("$collegeCode", collegeCodeComboBox.Text);
            UpdateDataSource(professionBindingSource, professionSelectQuery, professionComboBox, "专业名");
            UpdateDataSource(professionBindingSource, professionSelectQuery, professionCodeComboBox, "专业代码");
        }
        //
        // 用于更新数据源的方法
        //
        private void UpdateDataSource(BindingSource myBindingSource, string commandString, ComboBox updateComboBox, string DataMember)
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
            //
            // 如果使用的是SelectedIndexChanged事件 则给DataSource传递引用需要在DisplayMember和ValueMember之后
            // 如果使用的是SelectedValueChanged事件 则给DataSource传递引用需要在DisplayMember和ValueMember之前
            //
            updateComboBox.DataSource = myBindingSource;
            updateComboBox.DisplayMember = DataMember;
            updateComboBox.FormattingEnabled = true;
        }
        private void SetCollegeTableDataGridView()
        {
            // 初始化汇总信息表
            string totalTableSelectQuery = "select 班级号, 班级名称, 专业信息表.专业代码, 专业名,  专业信息表.院系编号, 学院名, 班级人数 " +
                                            "from 班级信息表 join 专业信息表 on 班级信息表.专业代码 = 专业信息表.专业代码 " +
                                            "join 学校信息表 on 专业信息表.院系编号 = 学校信息表.院系编号";
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
        //
        // 专业代码查询按钮
        //
        private void professionCodeQueryButton_Click(object sender, EventArgs e)
        {
            QueryAndSelect("专业代码", professionCodeComboBox);
        }
        //
        // 班级号查询按钮
        //
        private void classCodeQueryButton_Click(object sender, EventArgs e)
        {
            QueryAndSelect("班级号", classCodeComboBox);
        }
        //
        // 院系编号查询
        //
        private void collegeCodeQueryButton_Click(object sender, EventArgs e)
        {
            QueryAndSelect("院系编号", collegeCodeComboBox);
        }

        private void QueryAndSelect(string queryFieldString, ComboBox queryFieldComboBox)
        {
            bool firstTimeGetIn = true;
            collegeTableDataGridView.ClearSelection();
            foreach (DataGridViewRow myRow in collegeTableDataGridView.Rows)
            {
                if (myRow.Cells[queryFieldString].Value.ToString() == queryFieldComboBox.Text)
                {
                    myRow.Selected = true;
                    // 设置选中行为当前活动行
                    if (firstTimeGetIn)
                    {
                        collegeTableDataGridView.CurrentCell = myRow.Cells[queryFieldString];
                        firstTimeGetIn = false;
                    }
                }
            }
        }

        private void DeleteOneRecord(string deletedTableName, string primaryField, string value)
        {
            string deleteCommand = "delete from $deletedTableName where ( $primaryField = @value )";
            deleteCommand = deleteCommand.Replace("$deletedTableName", deletedTableName);
            deleteCommand = deleteCommand.Replace("$primaryField", primaryField);
            //MessageBox.Show(deleteCommand);
            myCommand = myConnection.CreateCommand();
            myCommand.CommandText = deleteCommand;

            myCommand.Parameters.AddWithValue("@value", value);
            myAdapter = new MySqlDataAdapter(myCommand);
            myAdapter.Fill(new DataTable());
        }

        private void AddOneRecord(MySqlCommand addCommand)
        {
            myAdapter = new MySqlDataAdapter(addCommand);
            myAdapter.Fill(new DataTable());
        }

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
                DeleteOneRecord("班级信息表", "班级号", classCodeComboBox.Text);
                classBindingSource.RemoveCurrent();
                SetCollegeTableDataGridView();
            }

        }

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
                DeleteOneRecord("专业信息表", "专业代码", professionCodeComboBox.Text);
                professionBindingSource.RemoveCurrent();
            }
        }

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
                DeleteOneRecord("学校信息表", "院系编号", collegeCodeComboBox.Text);
                学校信息表BindingSource.RemoveCurrent();
            }
            
        }

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
            UpdateDataSource(classBindingSource, classSelectQuery, classComboBox, "班级名称");
            UpdateDataSource(classBindingSource, classSelectQuery, classCodeComboBox, "班级号");
        }

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
            UpdateDataSource(professionBindingSource, professionSelectQuery, professionComboBox, "专业名");
            UpdateDataSource(professionBindingSource, professionSelectQuery, professionCodeComboBox, "专业代码");
        }

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

    }
}
