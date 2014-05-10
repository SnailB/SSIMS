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
    public partial class loadForm : Form
    {
        MySqlConnectionStringBuilder connectStringBuilder;
        MySqlConnection myConnection;
        MySqlCommand myCommand;
        MySqlDataAdapter myAdapter;
        DataSet myDataSet;
        bool errorAccountName = false;
        bool errorPasswd = false;
        bool firstTimeClick = true;
        public loadForm()
        {
            InitializeComponent();
            connectStringBuilder = new MySqlConnectionStringBuilder();
            connectStringBuilder.Database = "studentinfomanagedatabase";
            connectStringBuilder.Server = "localhost";
            connectStringBuilder.UserID = "root";
            connectStringBuilder.Password = "slowly";
        }
        #region 账户验证
        private void loadButton_Click(object sender, EventArgs e)
        {
            myConnection = new MySqlConnection(connectStringBuilder.ConnectionString);
            myConnection.Open();
            /*
             * 先验证账户是否存在
             */
            myCommand = myConnection.CreateCommand();
            //查询用户输入账号是否存在
            string mySelectQuery = "select 账户名, 账户密码, 账户权限 from 账户信息表 where (账户名 = @accountName)";
            myCommand.CommandText = mySelectQuery;
            myCommand.Parameters.AddWithValue("@accountName", accountName.Text);
            myAdapter = new MySqlDataAdapter(myCommand);
            myDataSet = new DataSet("StudentInfoDatabase");
            myAdapter.Fill(myDataSet);
            DataTable dataTable = myDataSet.Tables[0];
            //dataGridView1.DataSource = dataTable.DefaultView;
            //查询结果为空, 账户不存在
            if (dataTable.Rows.Count == 0)
            {
                errorInfo.SetError(accountName, "账号不存在请重新输入");
                errorInfoLabel.Text = "账号不存在请重新输入";
                errorAccountName = true;
            }
            //账户存在, 密码正确
            else if ((string)dataTable.Rows[0]["账户密码"] == passwd.Text)
            {
                switch ((int)dataTable.Rows[0]["账户权限"])
                {
                    case 1: 
                        AdminForm adminFrom = new AdminForm();
                        adminFrom.Show();
                        break;
                    case 2:

                    default:
                        break;
                }

            }
            //密码不正确
            else
            {
                errorInfo.SetError(passwd, "密码错误请重新输入");
                errorInfoLabel.Text = "密码错误请重新输入";
                errorPasswd = true;
            }
            myConnection.Close();
        }
        #endregion
        private void loadForm_Load(object sender, EventArgs e)
        {
            accountName.MouseClick += accountName_MouseClick;
            passwd.MouseClick += passwd_MouseClick;
            passwd.TextChanged += passwd_TextChanged;
        }

        void passwd_TextChanged(object sender, EventArgs e)
        {
            passwd.PasswordChar = '*';
        }
        #region 清除提示信息
        private void ClearPromptInfo()
        {
            if (firstTimeClick)
            {
                passwd.Clear();
                accountName.Clear();
                firstTimeClick = false;
            }
            else if (errorPasswd)
            {
                passwd.Clear();
                errorPasswd = false;
            }
            else if (errorAccountName)
            {
                accountName.Clear();
                passwd.Clear();
                errorAccountName = false;
                errorPasswd = false;
            }
            errorInfo.SetError(accountName, string.Empty);
            errorInfo.SetError(passwd, string.Empty);
            errorInfoLabel.Text = string.Empty;
        }
        #endregion
        void passwd_MouseClick(object sender, EventArgs e)
        {
            ClearPromptInfo();
        }

        void accountName_MouseClick(object sender, EventArgs e)
        {
            ClearPromptInfo();
        }

        private void regesitButton_Click(object sender, EventArgs e)
        {
            StudentRegisterForm studentRegisterForm = new StudentRegisterForm();
            studentRegisterForm.Show();
        }
    }
}
