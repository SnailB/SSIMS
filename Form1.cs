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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 专业信息表BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.专业信息表BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentinfomanagedatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“studentinfomanagedatabaseDataSet.专业信息表”中。您可以根据需要移动或删除它。
            this.专业信息表TableAdapter.Fill(this.studentinfomanagedatabaseDataSet.专业信息表);

        }
    }
}
