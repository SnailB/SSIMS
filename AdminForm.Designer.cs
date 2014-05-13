namespace 学籍管理系统
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label 学号Label;
            System.Windows.Forms.Label 姓名Label;
            System.Windows.Forms.Label 性别Label;
            System.Windows.Forms.Label 出生日期Label;
            System.Windows.Forms.Label 政治面貌Label;
            System.Windows.Forms.Label 入学日期Label;
            System.Windows.Forms.Label 院系名Label;
            System.Windows.Forms.Label 专业名Label;
            System.Windows.Forms.Label 班级号Label;
            System.Windows.Forms.Label 电话号码Label;
            System.Windows.Forms.Label 身份证号码Label;
            System.Windows.Forms.Label 详细家庭住址Label;
            System.Windows.Forms.Label 备注Label;
            System.Windows.Forms.Label 账户名Label;
            System.Windows.Forms.Label 账户密码Label;
            System.Windows.Forms.Label 账户类别Label;
            System.Windows.Forms.Label 账户权限Label;
            this.schoolTabControl = new System.Windows.Forms.TabControl();
            this.schoolTabPage = new System.Windows.Forms.TabPage();
            this.refresh = new System.Windows.Forms.Button();
            this.collegeCodeQueryButton = new System.Windows.Forms.Button();
            this.collegeInfoAddButton = new System.Windows.Forms.Button();
            this.collegeInfoDeleteButton = new System.Windows.Forms.Button();
            this.professionInfoAddButton = new System.Windows.Forms.Button();
            this.professionInfoDeleteButton = new System.Windows.Forms.Button();
            this.professionCodeQueryButton = new System.Windows.Forms.Button();
            this.classInfoDeleteButton = new System.Windows.Forms.Button();
            this.classCodeQueryButton = new System.Windows.Forms.Button();
            this.classInfoAddButton = new System.Windows.Forms.Button();
            this.classCodeLabel = new System.Windows.Forms.Label();
            this.classCodeComboBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.professionCodeLabel = new System.Windows.Forms.Label();
            this.professionCodeComboBox = new System.Windows.Forms.ComboBox();
            this.collegeCodeLabel = new System.Windows.Forms.Label();
            this.collegeCodeComboBox = new System.Windows.Forms.ComboBox();
            this.学校信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentinfomanagedatabaseDataSet = new 学籍管理系统.studentinfomanagedatabaseDataSet();
            this.professionLabel = new System.Windows.Forms.Label();
            this.professionComboBox = new System.Windows.Forms.ComboBox();
            this.collegeLabel = new System.Windows.Forms.Label();
            this.collegeComboBox = new System.Windows.Forms.ComboBox();
            this.collegeTableDataGridView = new System.Windows.Forms.DataGridView();
            this.studentTabPage = new System.Windows.Forms.TabPage();
            this.choosePictureButton = new System.Windows.Forms.Button();
            this.cleanQueryButton = new System.Windows.Forms.Button();
            this.入学时间DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.学生信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteStudentInfoButton = new System.Windows.Forms.Button();
            this.addStudentInfoButton = new System.Windows.Forms.Button();
            this.updateStudentInfoButton = new System.Windows.Forms.Button();
            this.queryByClassCodeButton = new System.Windows.Forms.Button();
            this.queryByProfessionNameButton = new System.Windows.Forms.Button();
            this.queryByCollegeNameButton = new System.Windows.Forms.Button();
            this.queryByPoliticalStatusButton = new System.Windows.Forms.Button();
            this.queryByNameButton = new System.Windows.Forms.Button();
            this.学号TextBox = new System.Windows.Forms.TextBox();
            this.姓名TextBox = new System.Windows.Forms.TextBox();
            this.性别TextBox = new System.Windows.Forms.TextBox();
            this.出生日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.政治面貌TextBox = new System.Windows.Forms.TextBox();
            this.院系名TextBox = new System.Windows.Forms.TextBox();
            this.专业名TextBox = new System.Windows.Forms.TextBox();
            this.班级号TextBox = new System.Windows.Forms.TextBox();
            this.电话号码TextBox = new System.Windows.Forms.TextBox();
            this.身份证号码TextBox = new System.Windows.Forms.TextBox();
            this.详细家庭住址TextBox = new System.Windows.Forms.TextBox();
            this.照片PictureBox = new System.Windows.Forms.PictureBox();
            this.备注TextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出生日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.政治面貌DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入学日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.院系名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话号码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTabPage = new System.Windows.Forms.TabPage();
            this.cleanAccountQueryButton = new System.Windows.Forms.Button();
            this.accountCategoryButton = new System.Windows.Forms.Button();
            this.accountAuthorityButton = new System.Windows.Forms.Button();
            this.账户权限TextBox = new System.Windows.Forms.TextBox();
            this.账户信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.账户类别TextBox = new System.Windows.Forms.TextBox();
            this.deleteAccountRecordButton = new System.Windows.Forms.Button();
            this.addAccountRecordbutton = new System.Windows.Forms.Button();
            this.accountInfoUpdateButton = new System.Windows.Forms.Button();
            this.accountNameQueryButton = new System.Windows.Forms.Button();
            this.账户名TextBox = new System.Windows.Forms.TextBox();
            this.账户密码TextBox = new System.Windows.Forms.TextBox();
            this.账户信息表DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitSystemLable = new System.Windows.Forms.Label();
            this.学校信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.学校信息表TableAdapter();
            this.学生信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.学生信息表TableAdapter();
            this.tableAdapterManager = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager();
            this.账户信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.账户信息表TableAdapter();
            this.专业信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.专业信息表TableAdapter();
            this.专业信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.班级信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.班级信息表TableAdapter();
            this.班级信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            学号Label = new System.Windows.Forms.Label();
            姓名Label = new System.Windows.Forms.Label();
            性别Label = new System.Windows.Forms.Label();
            出生日期Label = new System.Windows.Forms.Label();
            政治面貌Label = new System.Windows.Forms.Label();
            入学日期Label = new System.Windows.Forms.Label();
            院系名Label = new System.Windows.Forms.Label();
            专业名Label = new System.Windows.Forms.Label();
            班级号Label = new System.Windows.Forms.Label();
            电话号码Label = new System.Windows.Forms.Label();
            身份证号码Label = new System.Windows.Forms.Label();
            详细家庭住址Label = new System.Windows.Forms.Label();
            备注Label = new System.Windows.Forms.Label();
            账户名Label = new System.Windows.Forms.Label();
            账户密码Label = new System.Windows.Forms.Label();
            账户类别Label = new System.Windows.Forms.Label();
            账户权限Label = new System.Windows.Forms.Label();
            this.schoolTabControl.SuspendLayout();
            this.schoolTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.学校信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeTableDataGridView)).BeginInit();
            this.studentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.学生信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.照片PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.accountTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.账户信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.账户信息表DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.班级信息表BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 学号Label
            // 
            学号Label.AutoSize = true;
            学号Label.Location = new System.Drawing.Point(273, 24);
            学号Label.Name = "学号Label";
            学号Label.Size = new System.Drawing.Size(35, 12);
            学号Label.TabIndex = 1;
            学号Label.Text = "学号:";
            // 
            // 姓名Label
            // 
            姓名Label.AutoSize = true;
            姓名Label.Location = new System.Drawing.Point(19, 24);
            姓名Label.Name = "姓名Label";
            姓名Label.Size = new System.Drawing.Size(35, 12);
            姓名Label.TabIndex = 3;
            姓名Label.Text = "姓名:";
            // 
            // 性别Label
            // 
            性别Label.AutoSize = true;
            性别Label.Location = new System.Drawing.Point(189, 24);
            性别Label.Name = "性别Label";
            性别Label.Size = new System.Drawing.Size(35, 12);
            性别Label.TabIndex = 5;
            性别Label.Text = "性别:";
            // 
            // 出生日期Label
            // 
            出生日期Label.AutoSize = true;
            出生日期Label.Location = new System.Drawing.Point(19, 57);
            出生日期Label.Name = "出生日期Label";
            出生日期Label.Size = new System.Drawing.Size(59, 12);
            出生日期Label.TabIndex = 7;
            出生日期Label.Text = "出生日期:";
            // 
            // 政治面貌Label
            // 
            政治面貌Label.AutoSize = true;
            政治面貌Label.Location = new System.Drawing.Point(19, 93);
            政治面貌Label.Name = "政治面貌Label";
            政治面貌Label.Size = new System.Drawing.Size(59, 12);
            政治面貌Label.TabIndex = 9;
            政治面貌Label.Text = "政治面貌:";
            // 
            // 入学日期Label
            // 
            入学日期Label.AutoSize = true;
            入学日期Label.Location = new System.Drawing.Point(19, 125);
            入学日期Label.Name = "入学日期Label";
            入学日期Label.Size = new System.Drawing.Size(59, 12);
            入学日期Label.TabIndex = 11;
            入学日期Label.Text = "入学日期:";
            // 
            // 院系名Label
            // 
            院系名Label.AutoSize = true;
            院系名Label.Location = new System.Drawing.Point(273, 54);
            院系名Label.Name = "院系名Label";
            院系名Label.Size = new System.Drawing.Size(47, 12);
            院系名Label.TabIndex = 13;
            院系名Label.Text = "院系名:";
            // 
            // 专业名Label
            // 
            专业名Label.AutoSize = true;
            专业名Label.Location = new System.Drawing.Point(273, 81);
            专业名Label.Name = "专业名Label";
            专业名Label.Size = new System.Drawing.Size(47, 12);
            专业名Label.TabIndex = 15;
            专业名Label.Text = "专业名:";
            // 
            // 班级号Label
            // 
            班级号Label.AutoSize = true;
            班级号Label.Location = new System.Drawing.Point(273, 108);
            班级号Label.Name = "班级号Label";
            班级号Label.Size = new System.Drawing.Size(47, 12);
            班级号Label.TabIndex = 17;
            班级号Label.Text = "班级号:";
            // 
            // 电话号码Label
            // 
            电话号码Label.AutoSize = true;
            电话号码Label.Location = new System.Drawing.Point(19, 156);
            电话号码Label.Name = "电话号码Label";
            电话号码Label.Size = new System.Drawing.Size(59, 12);
            电话号码Label.TabIndex = 19;
            电话号码Label.Text = "电话号码:";
            // 
            // 身份证号码Label
            // 
            身份证号码Label.AutoSize = true;
            身份证号码Label.Location = new System.Drawing.Point(19, 187);
            身份证号码Label.Name = "身份证号码Label";
            身份证号码Label.Size = new System.Drawing.Size(71, 12);
            身份证号码Label.TabIndex = 21;
            身份证号码Label.Text = "身份证号码:";
            // 
            // 详细家庭住址Label
            // 
            详细家庭住址Label.AutoSize = true;
            详细家庭住址Label.Location = new System.Drawing.Point(273, 132);
            详细家庭住址Label.Name = "详细家庭住址Label";
            详细家庭住址Label.Size = new System.Drawing.Size(35, 36);
            详细家庭住址Label.TabIndex = 23;
            详细家庭住址Label.Text = "详细\r\n家庭\r\n住址:";
            // 
            // 备注Label
            // 
            备注Label.AutoSize = true;
            备注Label.Location = new System.Drawing.Point(273, 180);
            备注Label.Name = "备注Label";
            备注Label.Size = new System.Drawing.Size(35, 12);
            备注Label.TabIndex = 27;
            备注Label.Text = "备注:";
            // 
            // 账户名Label
            // 
            账户名Label.AutoSize = true;
            账户名Label.Location = new System.Drawing.Point(18, 25);
            账户名Label.Name = "账户名Label";
            账户名Label.Size = new System.Drawing.Size(47, 12);
            账户名Label.TabIndex = 1;
            账户名Label.Text = "账户名:";
            // 
            // 账户密码Label
            // 
            账户密码Label.AutoSize = true;
            账户密码Label.Location = new System.Drawing.Point(18, 52);
            账户密码Label.Name = "账户密码Label";
            账户密码Label.Size = new System.Drawing.Size(59, 12);
            账户密码Label.TabIndex = 3;
            账户密码Label.Text = "账户密码:";
            // 
            // 账户类别Label
            // 
            账户类别Label.AutoSize = true;
            账户类别Label.Location = new System.Drawing.Point(18, 79);
            账户类别Label.Name = "账户类别Label";
            账户类别Label.Size = new System.Drawing.Size(59, 12);
            账户类别Label.TabIndex = 38;
            账户类别Label.Text = "账户类别:";
            // 
            // 账户权限Label
            // 
            账户权限Label.AutoSize = true;
            账户权限Label.Location = new System.Drawing.Point(18, 106);
            账户权限Label.Name = "账户权限Label";
            账户权限Label.Size = new System.Drawing.Size(59, 12);
            账户权限Label.TabIndex = 39;
            账户权限Label.Text = "账户权限:";
            // 
            // schoolTabControl
            // 
            this.schoolTabControl.Controls.Add(this.schoolTabPage);
            this.schoolTabControl.Controls.Add(this.studentTabPage);
            this.schoolTabControl.Controls.Add(this.accountTabPage);
            this.schoolTabControl.Location = new System.Drawing.Point(0, 45);
            this.schoolTabControl.Name = "schoolTabControl";
            this.schoolTabControl.SelectedIndex = 0;
            this.schoolTabControl.Size = new System.Drawing.Size(683, 572);
            this.schoolTabControl.TabIndex = 0;
            this.schoolTabControl.Tag = "";
            // 
            // schoolTabPage
            // 
            this.schoolTabPage.Controls.Add(this.refresh);
            this.schoolTabPage.Controls.Add(this.collegeCodeQueryButton);
            this.schoolTabPage.Controls.Add(this.collegeInfoAddButton);
            this.schoolTabPage.Controls.Add(this.collegeInfoDeleteButton);
            this.schoolTabPage.Controls.Add(this.professionInfoAddButton);
            this.schoolTabPage.Controls.Add(this.professionInfoDeleteButton);
            this.schoolTabPage.Controls.Add(this.professionCodeQueryButton);
            this.schoolTabPage.Controls.Add(this.classInfoDeleteButton);
            this.schoolTabPage.Controls.Add(this.classCodeQueryButton);
            this.schoolTabPage.Controls.Add(this.classInfoAddButton);
            this.schoolTabPage.Controls.Add(this.classCodeLabel);
            this.schoolTabPage.Controls.Add(this.classCodeComboBox);
            this.schoolTabPage.Controls.Add(this.classLabel);
            this.schoolTabPage.Controls.Add(this.classComboBox);
            this.schoolTabPage.Controls.Add(this.professionCodeLabel);
            this.schoolTabPage.Controls.Add(this.professionCodeComboBox);
            this.schoolTabPage.Controls.Add(this.collegeCodeLabel);
            this.schoolTabPage.Controls.Add(this.collegeCodeComboBox);
            this.schoolTabPage.Controls.Add(this.professionLabel);
            this.schoolTabPage.Controls.Add(this.professionComboBox);
            this.schoolTabPage.Controls.Add(this.collegeLabel);
            this.schoolTabPage.Controls.Add(this.collegeComboBox);
            this.schoolTabPage.Controls.Add(this.collegeTableDataGridView);
            this.schoolTabPage.Location = new System.Drawing.Point(4, 22);
            this.schoolTabPage.Name = "schoolTabPage";
            this.schoolTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.schoolTabPage.Size = new System.Drawing.Size(675, 546);
            this.schoolTabPage.TabIndex = 0;
            this.schoolTabPage.Text = "学校信息管理";
            this.schoolTabPage.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(565, 28);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 25;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // collegeCodeQueryButton
            // 
            this.collegeCodeQueryButton.Location = new System.Drawing.Point(341, 28);
            this.collegeCodeQueryButton.Name = "collegeCodeQueryButton";
            this.collegeCodeQueryButton.Size = new System.Drawing.Size(75, 23);
            this.collegeCodeQueryButton.TabIndex = 24;
            this.collegeCodeQueryButton.Text = "查询";
            this.collegeCodeQueryButton.UseVisualStyleBackColor = true;
            this.collegeCodeQueryButton.Click += new System.EventHandler(this.collegeCodeQueryButton_Click);
            // 
            // collegeInfoAddButton
            // 
            this.collegeInfoAddButton.Location = new System.Drawing.Point(438, 29);
            this.collegeInfoAddButton.Name = "collegeInfoAddButton";
            this.collegeInfoAddButton.Size = new System.Drawing.Size(75, 23);
            this.collegeInfoAddButton.TabIndex = 23;
            this.collegeInfoAddButton.Text = "添加";
            this.collegeInfoAddButton.UseVisualStyleBackColor = true;
            this.collegeInfoAddButton.Click += new System.EventHandler(this.collegeInfoAddButton_Click);
            // 
            // collegeInfoDeleteButton
            // 
            this.collegeInfoDeleteButton.Location = new System.Drawing.Point(438, 6);
            this.collegeInfoDeleteButton.Name = "collegeInfoDeleteButton";
            this.collegeInfoDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.collegeInfoDeleteButton.TabIndex = 22;
            this.collegeInfoDeleteButton.Text = "删除";
            this.collegeInfoDeleteButton.UseVisualStyleBackColor = true;
            this.collegeInfoDeleteButton.Click += new System.EventHandler(this.collegeInfoDeleteButton_Click);
            // 
            // professionInfoAddButton
            // 
            this.professionInfoAddButton.Location = new System.Drawing.Point(438, 81);
            this.professionInfoAddButton.Name = "professionInfoAddButton";
            this.professionInfoAddButton.Size = new System.Drawing.Size(75, 23);
            this.professionInfoAddButton.TabIndex = 21;
            this.professionInfoAddButton.Text = "添加";
            this.professionInfoAddButton.UseVisualStyleBackColor = true;
            this.professionInfoAddButton.Click += new System.EventHandler(this.professionInfoAddButton_Click);
            // 
            // professionInfoDeleteButton
            // 
            this.professionInfoDeleteButton.Location = new System.Drawing.Point(438, 58);
            this.professionInfoDeleteButton.Name = "professionInfoDeleteButton";
            this.professionInfoDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.professionInfoDeleteButton.TabIndex = 20;
            this.professionInfoDeleteButton.Text = "删除";
            this.professionInfoDeleteButton.UseVisualStyleBackColor = true;
            this.professionInfoDeleteButton.Click += new System.EventHandler(this.professionInfoDeleteButton_Click);
            // 
            // professionCodeQueryButton
            // 
            this.professionCodeQueryButton.Location = new System.Drawing.Point(341, 79);
            this.professionCodeQueryButton.Name = "professionCodeQueryButton";
            this.professionCodeQueryButton.Size = new System.Drawing.Size(75, 23);
            this.professionCodeQueryButton.TabIndex = 19;
            this.professionCodeQueryButton.Text = "查询";
            this.professionCodeQueryButton.UseVisualStyleBackColor = true;
            this.professionCodeQueryButton.Click += new System.EventHandler(this.professionCodeQueryButton_Click);
            // 
            // classInfoDeleteButton
            // 
            this.classInfoDeleteButton.Location = new System.Drawing.Point(438, 110);
            this.classInfoDeleteButton.Name = "classInfoDeleteButton";
            this.classInfoDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.classInfoDeleteButton.TabIndex = 18;
            this.classInfoDeleteButton.Text = "删除";
            this.classInfoDeleteButton.UseVisualStyleBackColor = true;
            this.classInfoDeleteButton.Click += new System.EventHandler(this.classInfoDeleteButton_Click);
            // 
            // classCodeQueryButton
            // 
            this.classCodeQueryButton.Location = new System.Drawing.Point(339, 131);
            this.classCodeQueryButton.Name = "classCodeQueryButton";
            this.classCodeQueryButton.Size = new System.Drawing.Size(75, 23);
            this.classCodeQueryButton.TabIndex = 17;
            this.classCodeQueryButton.Text = "查询";
            this.classCodeQueryButton.UseVisualStyleBackColor = true;
            this.classCodeQueryButton.Click += new System.EventHandler(this.classCodeQueryButton_Click);
            // 
            // classInfoAddButton
            // 
            this.classInfoAddButton.Location = new System.Drawing.Point(438, 133);
            this.classInfoAddButton.Name = "classInfoAddButton";
            this.classInfoAddButton.Size = new System.Drawing.Size(75, 23);
            this.classInfoAddButton.TabIndex = 15;
            this.classInfoAddButton.Text = "添加";
            this.classInfoAddButton.UseVisualStyleBackColor = true;
            this.classInfoAddButton.Click += new System.EventHandler(this.classInfoAddButton_Click);
            // 
            // classCodeLabel
            // 
            this.classCodeLabel.AutoSize = true;
            this.classCodeLabel.Location = new System.Drawing.Point(246, 115);
            this.classCodeLabel.Name = "classCodeLabel";
            this.classCodeLabel.Size = new System.Drawing.Size(41, 12);
            this.classCodeLabel.TabIndex = 14;
            this.classCodeLabel.Text = "班级号";
            // 
            // classCodeComboBox
            // 
            this.classCodeComboBox.FormattingEnabled = true;
            this.classCodeComboBox.Location = new System.Drawing.Point(248, 133);
            this.classCodeComboBox.Name = "classCodeComboBox";
            this.classCodeComboBox.Size = new System.Drawing.Size(87, 20);
            this.classCodeComboBox.TabIndex = 13;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(28, 115);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(41, 12);
            this.classLabel.TabIndex = 12;
            this.classLabel.Text = "班级名";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(28, 133);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(192, 20);
            this.classComboBox.TabIndex = 11;
            // 
            // professionCodeLabel
            // 
            this.professionCodeLabel.AutoSize = true;
            this.professionCodeLabel.Location = new System.Drawing.Point(246, 64);
            this.professionCodeLabel.Name = "professionCodeLabel";
            this.professionCodeLabel.Size = new System.Drawing.Size(53, 12);
            this.professionCodeLabel.TabIndex = 10;
            this.professionCodeLabel.Text = "专业代码";
            // 
            // professionCodeComboBox
            // 
            this.professionCodeComboBox.FormattingEnabled = true;
            this.professionCodeComboBox.Location = new System.Drawing.Point(248, 82);
            this.professionCodeComboBox.Name = "professionCodeComboBox";
            this.professionCodeComboBox.Size = new System.Drawing.Size(87, 20);
            this.professionCodeComboBox.TabIndex = 9;
            // 
            // collegeCodeLabel
            // 
            this.collegeCodeLabel.AutoSize = true;
            this.collegeCodeLabel.Location = new System.Drawing.Point(246, 12);
            this.collegeCodeLabel.Name = "collegeCodeLabel";
            this.collegeCodeLabel.Size = new System.Drawing.Size(53, 12);
            this.collegeCodeLabel.TabIndex = 7;
            this.collegeCodeLabel.Text = "学院代码";
            // 
            // collegeCodeComboBox
            // 
            this.collegeCodeComboBox.DataSource = this.学校信息表BindingSource;
            this.collegeCodeComboBox.DisplayMember = "院系编号";
            this.collegeCodeComboBox.FormattingEnabled = true;
            this.collegeCodeComboBox.Location = new System.Drawing.Point(248, 30);
            this.collegeCodeComboBox.Name = "collegeCodeComboBox";
            this.collegeCodeComboBox.Size = new System.Drawing.Size(87, 20);
            this.collegeCodeComboBox.TabIndex = 6;
            // 
            // 学校信息表BindingSource
            // 
            this.学校信息表BindingSource.DataMember = "学校信息表";
            this.学校信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // studentinfomanagedatabaseDataSet
            // 
            this.studentinfomanagedatabaseDataSet.DataSetName = "studentinfomanagedatabaseDataSet";
            this.studentinfomanagedatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professionLabel
            // 
            this.professionLabel.AutoSize = true;
            this.professionLabel.Location = new System.Drawing.Point(28, 64);
            this.professionLabel.Name = "professionLabel";
            this.professionLabel.Size = new System.Drawing.Size(41, 12);
            this.professionLabel.TabIndex = 4;
            this.professionLabel.Text = "专业名";
            // 
            // professionComboBox
            // 
            this.professionComboBox.FormattingEnabled = true;
            this.professionComboBox.Location = new System.Drawing.Point(28, 82);
            this.professionComboBox.Name = "professionComboBox";
            this.professionComboBox.Size = new System.Drawing.Size(192, 20);
            this.professionComboBox.TabIndex = 3;
            // 
            // collegeLabel
            // 
            this.collegeLabel.AutoSize = true;
            this.collegeLabel.Location = new System.Drawing.Point(28, 12);
            this.collegeLabel.Name = "collegeLabel";
            this.collegeLabel.Size = new System.Drawing.Size(29, 12);
            this.collegeLabel.TabIndex = 1;
            this.collegeLabel.Text = "学院";
            // 
            // collegeComboBox
            // 
            this.collegeComboBox.DataSource = this.学校信息表BindingSource;
            this.collegeComboBox.DisplayMember = "学院名";
            this.collegeComboBox.FormattingEnabled = true;
            this.collegeComboBox.Location = new System.Drawing.Point(28, 30);
            this.collegeComboBox.Name = "collegeComboBox";
            this.collegeComboBox.Size = new System.Drawing.Size(192, 20);
            this.collegeComboBox.TabIndex = 0;
            // 
            // collegeTableDataGridView
            // 
            this.collegeTableDataGridView.AllowUserToAddRows = false;
            this.collegeTableDataGridView.AllowUserToDeleteRows = false;
            this.collegeTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collegeTableDataGridView.Location = new System.Drawing.Point(0, 173);
            this.collegeTableDataGridView.Name = "collegeTableDataGridView";
            this.collegeTableDataGridView.RowTemplate.Height = 23;
            this.collegeTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.collegeTableDataGridView.Size = new System.Drawing.Size(675, 377);
            this.collegeTableDataGridView.TabIndex = 16;
            // 
            // studentTabPage
            // 
            this.studentTabPage.AutoScroll = true;
            this.studentTabPage.Controls.Add(this.choosePictureButton);
            this.studentTabPage.Controls.Add(this.cleanQueryButton);
            this.studentTabPage.Controls.Add(this.入学时间DateTimePicker);
            this.studentTabPage.Controls.Add(this.deleteStudentInfoButton);
            this.studentTabPage.Controls.Add(this.addStudentInfoButton);
            this.studentTabPage.Controls.Add(this.updateStudentInfoButton);
            this.studentTabPage.Controls.Add(this.queryByClassCodeButton);
            this.studentTabPage.Controls.Add(this.queryByProfessionNameButton);
            this.studentTabPage.Controls.Add(this.queryByCollegeNameButton);
            this.studentTabPage.Controls.Add(this.queryByPoliticalStatusButton);
            this.studentTabPage.Controls.Add(this.queryByNameButton);
            this.studentTabPage.Controls.Add(学号Label);
            this.studentTabPage.Controls.Add(this.学号TextBox);
            this.studentTabPage.Controls.Add(姓名Label);
            this.studentTabPage.Controls.Add(this.姓名TextBox);
            this.studentTabPage.Controls.Add(性别Label);
            this.studentTabPage.Controls.Add(this.性别TextBox);
            this.studentTabPage.Controls.Add(出生日期Label);
            this.studentTabPage.Controls.Add(this.出生日期DateTimePicker);
            this.studentTabPage.Controls.Add(政治面貌Label);
            this.studentTabPage.Controls.Add(this.政治面貌TextBox);
            this.studentTabPage.Controls.Add(入学日期Label);
            this.studentTabPage.Controls.Add(院系名Label);
            this.studentTabPage.Controls.Add(this.院系名TextBox);
            this.studentTabPage.Controls.Add(专业名Label);
            this.studentTabPage.Controls.Add(this.专业名TextBox);
            this.studentTabPage.Controls.Add(班级号Label);
            this.studentTabPage.Controls.Add(this.班级号TextBox);
            this.studentTabPage.Controls.Add(电话号码Label);
            this.studentTabPage.Controls.Add(this.电话号码TextBox);
            this.studentTabPage.Controls.Add(身份证号码Label);
            this.studentTabPage.Controls.Add(this.身份证号码TextBox);
            this.studentTabPage.Controls.Add(详细家庭住址Label);
            this.studentTabPage.Controls.Add(this.详细家庭住址TextBox);
            this.studentTabPage.Controls.Add(this.照片PictureBox);
            this.studentTabPage.Controls.Add(备注Label);
            this.studentTabPage.Controls.Add(this.备注TextBox);
            this.studentTabPage.Controls.Add(this.dataGridView1);
            this.studentTabPage.Location = new System.Drawing.Point(4, 22);
            this.studentTabPage.Name = "studentTabPage";
            this.studentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentTabPage.Size = new System.Drawing.Size(675, 546);
            this.studentTabPage.TabIndex = 1;
            this.studentTabPage.Text = "学生信息管理";
            this.studentTabPage.UseVisualStyleBackColor = true;
            // 
            // choosePictureButton
            // 
            this.choosePictureButton.Location = new System.Drawing.Point(492, 169);
            this.choosePictureButton.Name = "choosePictureButton";
            this.choosePictureButton.Size = new System.Drawing.Size(46, 23);
            this.choosePictureButton.TabIndex = 38;
            this.choosePictureButton.Text = "选择";
            this.choosePictureButton.UseVisualStyleBackColor = true;
            this.choosePictureButton.Click += new System.EventHandler(this.choosePictureButton_Click);
            // 
            // cleanQueryButton
            // 
            this.cleanQueryButton.Location = new System.Drawing.Point(366, 204);
            this.cleanQueryButton.Name = "cleanQueryButton";
            this.cleanQueryButton.Size = new System.Drawing.Size(75, 23);
            this.cleanQueryButton.TabIndex = 37;
            this.cleanQueryButton.Text = "清除查询";
            this.cleanQueryButton.UseVisualStyleBackColor = true;
            this.cleanQueryButton.Click += new System.EventHandler(this.cleanQueryButton_Click);
            // 
            // 入学时间DateTimePicker
            // 
            this.入学时间DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.学生信息表BindingSource, "入学日期", true));
            this.入学时间DateTimePicker.Location = new System.Drawing.Point(92, 119);
            this.入学时间DateTimePicker.Name = "入学时间DateTimePicker";
            this.入学时间DateTimePicker.Size = new System.Drawing.Size(105, 21);
            this.入学时间DateTimePicker.TabIndex = 36;
            // 
            // 学生信息表BindingSource
            // 
            this.学生信息表BindingSource.DataMember = "学生信息表";
            this.学生信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // deleteStudentInfoButton
            // 
            this.deleteStudentInfoButton.Location = new System.Drawing.Point(590, 204);
            this.deleteStudentInfoButton.Name = "deleteStudentInfoButton";
            this.deleteStudentInfoButton.Size = new System.Drawing.Size(43, 23);
            this.deleteStudentInfoButton.TabIndex = 35;
            this.deleteStudentInfoButton.Text = "删除";
            this.deleteStudentInfoButton.UseVisualStyleBackColor = true;
            this.deleteStudentInfoButton.Click += new System.EventHandler(this.deleteStudentInfoButton_Click);
            // 
            // addStudentInfoButton
            // 
            this.addStudentInfoButton.Location = new System.Drawing.Point(541, 204);
            this.addStudentInfoButton.Name = "addStudentInfoButton";
            this.addStudentInfoButton.Size = new System.Drawing.Size(43, 23);
            this.addStudentInfoButton.TabIndex = 35;
            this.addStudentInfoButton.Text = "增加";
            this.addStudentInfoButton.UseVisualStyleBackColor = true;
            this.addStudentInfoButton.Click += new System.EventHandler(this.addStudentInfoButton_Click);
            // 
            // updateStudentInfoButton
            // 
            this.updateStudentInfoButton.Location = new System.Drawing.Point(492, 204);
            this.updateStudentInfoButton.Name = "updateStudentInfoButton";
            this.updateStudentInfoButton.Size = new System.Drawing.Size(43, 23);
            this.updateStudentInfoButton.TabIndex = 34;
            this.updateStudentInfoButton.Text = "更新";
            this.updateStudentInfoButton.UseVisualStyleBackColor = true;
            this.updateStudentInfoButton.Click += new System.EventHandler(this.updateStudentInfoButton_Click);
            // 
            // queryByClassCodeButton
            // 
            this.queryByClassCodeButton.Location = new System.Drawing.Point(437, 103);
            this.queryByClassCodeButton.Name = "queryByClassCodeButton";
            this.queryByClassCodeButton.Size = new System.Drawing.Size(43, 23);
            this.queryByClassCodeButton.TabIndex = 33;
            this.queryByClassCodeButton.Text = "查询";
            this.queryByClassCodeButton.UseVisualStyleBackColor = true;
            this.queryByClassCodeButton.Click += new System.EventHandler(this.queryByClassCodeButton_Click);
            // 
            // queryByProfessionNameButton
            // 
            this.queryByProfessionNameButton.Location = new System.Drawing.Point(437, 76);
            this.queryByProfessionNameButton.Name = "queryByProfessionNameButton";
            this.queryByProfessionNameButton.Size = new System.Drawing.Size(43, 23);
            this.queryByProfessionNameButton.TabIndex = 32;
            this.queryByProfessionNameButton.Text = "查询";
            this.queryByProfessionNameButton.UseVisualStyleBackColor = true;
            this.queryByProfessionNameButton.Click += new System.EventHandler(this.queryByProfessionNameButton_Click);
            // 
            // queryByCollegeNameButton
            // 
            this.queryByCollegeNameButton.Location = new System.Drawing.Point(437, 49);
            this.queryByCollegeNameButton.Name = "queryByCollegeNameButton";
            this.queryByCollegeNameButton.Size = new System.Drawing.Size(43, 23);
            this.queryByCollegeNameButton.TabIndex = 31;
            this.queryByCollegeNameButton.Text = "查询";
            this.queryByCollegeNameButton.UseVisualStyleBackColor = true;
            this.queryByCollegeNameButton.Click += new System.EventHandler(this.queryByCollegeNameButton_Click);
            // 
            // queryByPoliticalStatusButton
            // 
            this.queryByPoliticalStatusButton.Location = new System.Drawing.Point(211, 85);
            this.queryByPoliticalStatusButton.Name = "queryByPoliticalStatusButton";
            this.queryByPoliticalStatusButton.Size = new System.Drawing.Size(43, 23);
            this.queryByPoliticalStatusButton.TabIndex = 30;
            this.queryByPoliticalStatusButton.Text = "查询";
            this.queryByPoliticalStatusButton.UseVisualStyleBackColor = true;
            this.queryByPoliticalStatusButton.Click += new System.EventHandler(this.queryByPoliticalStatusButton_Click);
            // 
            // queryByNameButton
            // 
            this.queryByNameButton.Location = new System.Drawing.Point(139, 19);
            this.queryByNameButton.Name = "queryByNameButton";
            this.queryByNameButton.Size = new System.Drawing.Size(43, 23);
            this.queryByNameButton.TabIndex = 29;
            this.queryByNameButton.Text = "查询";
            this.queryByNameButton.UseVisualStyleBackColor = true;
            this.queryByNameButton.Click += new System.EventHandler(this.queryByNameButton_Click);
            // 
            // 学号TextBox
            // 
            this.学号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "学号", true));
            this.学号TextBox.Location = new System.Drawing.Point(326, 21);
            this.学号TextBox.Name = "学号TextBox";
            this.学号TextBox.Size = new System.Drawing.Size(77, 21);
            this.学号TextBox.TabIndex = 2;
            // 
            // 姓名TextBox
            // 
            this.姓名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "姓名", true));
            this.姓名TextBox.Location = new System.Drawing.Point(68, 21);
            this.姓名TextBox.Name = "姓名TextBox";
            this.姓名TextBox.Size = new System.Drawing.Size(65, 21);
            this.姓名TextBox.TabIndex = 4;
            // 
            // 性别TextBox
            // 
            this.性别TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "性别", true));
            this.性别TextBox.Location = new System.Drawing.Point(224, 21);
            this.性别TextBox.Name = "性别TextBox";
            this.性别TextBox.Size = new System.Drawing.Size(30, 21);
            this.性别TextBox.TabIndex = 6;
            // 
            // 出生日期DateTimePicker
            // 
            this.出生日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.学生信息表BindingSource, "出生日期", true));
            this.出生日期DateTimePicker.Location = new System.Drawing.Point(92, 51);
            this.出生日期DateTimePicker.Name = "出生日期DateTimePicker";
            this.出生日期DateTimePicker.Size = new System.Drawing.Size(105, 21);
            this.出生日期DateTimePicker.TabIndex = 8;
            // 
            // 政治面貌TextBox
            // 
            this.政治面貌TextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "党员",
            "预备党员",
            "共青团员",
            "民盟党员",
            "少先队员"});
            this.政治面貌TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.政治面貌TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.政治面貌TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "政治面貌", true));
            this.政治面貌TextBox.Location = new System.Drawing.Point(92, 87);
            this.政治面貌TextBox.Name = "政治面貌TextBox";
            this.政治面貌TextBox.Size = new System.Drawing.Size(105, 21);
            this.政治面貌TextBox.TabIndex = 10;
            // 
            // 院系名TextBox
            // 
            this.院系名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "院系名", true));
            this.院系名TextBox.Location = new System.Drawing.Point(326, 51);
            this.院系名TextBox.Name = "院系名TextBox";
            this.院系名TextBox.Size = new System.Drawing.Size(105, 21);
            this.院系名TextBox.TabIndex = 14;
            // 
            // 专业名TextBox
            // 
            this.专业名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "专业名", true));
            this.专业名TextBox.Location = new System.Drawing.Point(326, 78);
            this.专业名TextBox.Name = "专业名TextBox";
            this.专业名TextBox.Size = new System.Drawing.Size(105, 21);
            this.专业名TextBox.TabIndex = 16;
            // 
            // 班级号TextBox
            // 
            this.班级号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "班级号", true));
            this.班级号TextBox.Location = new System.Drawing.Point(326, 105);
            this.班级号TextBox.Name = "班级号TextBox";
            this.班级号TextBox.Size = new System.Drawing.Size(105, 21);
            this.班级号TextBox.TabIndex = 18;
            // 
            // 电话号码TextBox
            // 
            this.电话号码TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "电话号码", true));
            this.电话号码TextBox.Location = new System.Drawing.Point(92, 153);
            this.电话号码TextBox.Name = "电话号码TextBox";
            this.电话号码TextBox.Size = new System.Drawing.Size(105, 21);
            this.电话号码TextBox.TabIndex = 20;
            // 
            // 身份证号码TextBox
            // 
            this.身份证号码TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "身份证号码", true));
            this.身份证号码TextBox.Location = new System.Drawing.Point(94, 184);
            this.身份证号码TextBox.Name = "身份证号码TextBox";
            this.身份证号码TextBox.Size = new System.Drawing.Size(162, 21);
            this.身份证号码TextBox.TabIndex = 22;
            // 
            // 详细家庭住址TextBox
            // 
            this.详细家庭住址TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "详细家庭住址", true));
            this.详细家庭住址TextBox.Location = new System.Drawing.Point(326, 132);
            this.详细家庭住址TextBox.Multiline = true;
            this.详细家庭住址TextBox.Name = "详细家庭住址TextBox";
            this.详细家庭住址TextBox.Size = new System.Drawing.Size(154, 42);
            this.详细家庭住址TextBox.TabIndex = 24;
            // 
            // 照片PictureBox
            // 
            this.照片PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.照片PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.照片PictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.学生信息表BindingSource, "照片", true));
            this.照片PictureBox.Location = new System.Drawing.Point(492, 6);
            this.照片PictureBox.Name = "照片PictureBox";
            this.照片PictureBox.Size = new System.Drawing.Size(130, 157);
            this.照片PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.照片PictureBox.TabIndex = 26;
            this.照片PictureBox.TabStop = false;
            // 
            // 备注TextBox
            // 
            this.备注TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "备注", true));
            this.备注TextBox.Location = new System.Drawing.Point(326, 180);
            this.备注TextBox.Multiline = true;
            this.备注TextBox.Name = "备注TextBox";
            this.备注TextBox.Size = new System.Drawing.Size(154, 21);
            this.备注TextBox.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.出生日期DataGridViewTextBoxColumn,
            this.政治面貌DataGridViewTextBoxColumn,
            this.入学日期DataGridViewTextBoxColumn,
            this.院系名DataGridViewTextBoxColumn,
            this.专业名DataGridViewTextBoxColumn,
            this.班级号DataGridViewTextBoxColumn,
            this.电话号码DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.学生信息表BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
            this.学号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            this.姓名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            this.性别DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 出生日期DataGridViewTextBoxColumn
            // 
            this.出生日期DataGridViewTextBoxColumn.DataPropertyName = "出生日期";
            this.出生日期DataGridViewTextBoxColumn.HeaderText = "出生日期";
            this.出生日期DataGridViewTextBoxColumn.Name = "出生日期DataGridViewTextBoxColumn";
            this.出生日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 政治面貌DataGridViewTextBoxColumn
            // 
            this.政治面貌DataGridViewTextBoxColumn.DataPropertyName = "政治面貌";
            this.政治面貌DataGridViewTextBoxColumn.HeaderText = "政治面貌";
            this.政治面貌DataGridViewTextBoxColumn.Name = "政治面貌DataGridViewTextBoxColumn";
            this.政治面貌DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 入学日期DataGridViewTextBoxColumn
            // 
            this.入学日期DataGridViewTextBoxColumn.DataPropertyName = "入学日期";
            this.入学日期DataGridViewTextBoxColumn.HeaderText = "入学日期";
            this.入学日期DataGridViewTextBoxColumn.Name = "入学日期DataGridViewTextBoxColumn";
            this.入学日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 院系名DataGridViewTextBoxColumn
            // 
            this.院系名DataGridViewTextBoxColumn.DataPropertyName = "院系名";
            this.院系名DataGridViewTextBoxColumn.HeaderText = "院系名";
            this.院系名DataGridViewTextBoxColumn.Name = "院系名DataGridViewTextBoxColumn";
            this.院系名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 专业名DataGridViewTextBoxColumn
            // 
            this.专业名DataGridViewTextBoxColumn.DataPropertyName = "专业名";
            this.专业名DataGridViewTextBoxColumn.HeaderText = "专业名";
            this.专业名DataGridViewTextBoxColumn.Name = "专业名DataGridViewTextBoxColumn";
            this.专业名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 班级号DataGridViewTextBoxColumn
            // 
            this.班级号DataGridViewTextBoxColumn.DataPropertyName = "班级号";
            this.班级号DataGridViewTextBoxColumn.HeaderText = "班级号";
            this.班级号DataGridViewTextBoxColumn.Name = "班级号DataGridViewTextBoxColumn";
            this.班级号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 电话号码DataGridViewTextBoxColumn
            // 
            this.电话号码DataGridViewTextBoxColumn.DataPropertyName = "电话号码";
            this.电话号码DataGridViewTextBoxColumn.HeaderText = "电话号码";
            this.电话号码DataGridViewTextBoxColumn.Name = "电话号码DataGridViewTextBoxColumn";
            this.电话号码DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountTabPage
            // 
            this.accountTabPage.AutoScroll = true;
            this.accountTabPage.Controls.Add(this.cleanAccountQueryButton);
            this.accountTabPage.Controls.Add(this.accountCategoryButton);
            this.accountTabPage.Controls.Add(this.accountAuthorityButton);
            this.accountTabPage.Controls.Add(账户权限Label);
            this.accountTabPage.Controls.Add(this.账户权限TextBox);
            this.accountTabPage.Controls.Add(账户类别Label);
            this.accountTabPage.Controls.Add(this.账户类别TextBox);
            this.accountTabPage.Controls.Add(this.deleteAccountRecordButton);
            this.accountTabPage.Controls.Add(this.addAccountRecordbutton);
            this.accountTabPage.Controls.Add(this.accountInfoUpdateButton);
            this.accountTabPage.Controls.Add(this.accountNameQueryButton);
            this.accountTabPage.Controls.Add(账户名Label);
            this.accountTabPage.Controls.Add(this.账户名TextBox);
            this.accountTabPage.Controls.Add(账户密码Label);
            this.accountTabPage.Controls.Add(this.账户密码TextBox);
            this.accountTabPage.Controls.Add(this.账户信息表DataGridView);
            this.accountTabPage.Location = new System.Drawing.Point(4, 22);
            this.accountTabPage.Name = "accountTabPage";
            this.accountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountTabPage.Size = new System.Drawing.Size(675, 546);
            this.accountTabPage.TabIndex = 2;
            this.accountTabPage.Text = "账户信息管理";
            this.accountTabPage.UseVisualStyleBackColor = true;
            // 
            // cleanAccountQueryButton
            // 
            this.cleanAccountQueryButton.Location = new System.Drawing.Point(260, 20);
            this.cleanAccountQueryButton.Name = "cleanAccountQueryButton";
            this.cleanAccountQueryButton.Size = new System.Drawing.Size(75, 23);
            this.cleanAccountQueryButton.TabIndex = 43;
            this.cleanAccountQueryButton.Text = "清除查询";
            this.cleanAccountQueryButton.UseVisualStyleBackColor = true;
            this.cleanAccountQueryButton.Click += new System.EventHandler(this.cleanAccountQueryButton_Click);
            // 
            // accountCategoryButton
            // 
            this.accountCategoryButton.Location = new System.Drawing.Point(189, 74);
            this.accountCategoryButton.Name = "accountCategoryButton";
            this.accountCategoryButton.Size = new System.Drawing.Size(43, 23);
            this.accountCategoryButton.TabIndex = 42;
            this.accountCategoryButton.Text = "查询";
            this.accountCategoryButton.UseVisualStyleBackColor = true;
            this.accountCategoryButton.Click += new System.EventHandler(this.accountCategoryButton_Click);
            // 
            // accountAuthorityButton
            // 
            this.accountAuthorityButton.Location = new System.Drawing.Point(189, 101);
            this.accountAuthorityButton.Name = "accountAuthorityButton";
            this.accountAuthorityButton.Size = new System.Drawing.Size(43, 23);
            this.accountAuthorityButton.TabIndex = 41;
            this.accountAuthorityButton.Text = "查询";
            this.accountAuthorityButton.UseVisualStyleBackColor = true;
            this.accountAuthorityButton.Click += new System.EventHandler(this.accountAuthorityButton_Click);
            // 
            // 账户权限TextBox
            // 
            this.账户权限TextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3"});
            this.账户权限TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.账户权限TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.账户权限TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.账户信息表BindingSource, "账户权限", true));
            this.账户权限TextBox.Location = new System.Drawing.Point(83, 103);
            this.账户权限TextBox.Name = "账户权限TextBox";
            this.账户权限TextBox.Size = new System.Drawing.Size(100, 21);
            this.账户权限TextBox.TabIndex = 40;
            // 
            // 账户信息表BindingSource
            // 
            this.账户信息表BindingSource.DataMember = "账户信息表";
            this.账户信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // 账户类别TextBox
            // 
            this.账户类别TextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "管理员",
            "教师",
            "学生"});
            this.账户类别TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.账户类别TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.账户类别TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.账户信息表BindingSource, "账户类别", true));
            this.账户类别TextBox.Location = new System.Drawing.Point(83, 76);
            this.账户类别TextBox.Name = "账户类别TextBox";
            this.账户类别TextBox.Size = new System.Drawing.Size(100, 21);
            this.账户类别TextBox.TabIndex = 39;
            // 
            // deleteAccountRecordButton
            // 
            this.deleteAccountRecordButton.Location = new System.Drawing.Point(358, 101);
            this.deleteAccountRecordButton.Name = "deleteAccountRecordButton";
            this.deleteAccountRecordButton.Size = new System.Drawing.Size(43, 23);
            this.deleteAccountRecordButton.TabIndex = 38;
            this.deleteAccountRecordButton.Text = "删除";
            this.deleteAccountRecordButton.UseVisualStyleBackColor = true;
            this.deleteAccountRecordButton.Click += new System.EventHandler(this.deleteAccountRecordButton_Click);
            // 
            // addAccountRecordbutton
            // 
            this.addAccountRecordbutton.Location = new System.Drawing.Point(309, 101);
            this.addAccountRecordbutton.Name = "addAccountRecordbutton";
            this.addAccountRecordbutton.Size = new System.Drawing.Size(43, 23);
            this.addAccountRecordbutton.TabIndex = 37;
            this.addAccountRecordbutton.Text = "增加";
            this.addAccountRecordbutton.UseVisualStyleBackColor = true;
            this.addAccountRecordbutton.Click += new System.EventHandler(this.addAccountRecordbutton_Click);
            // 
            // accountInfoUpdateButton
            // 
            this.accountInfoUpdateButton.Location = new System.Drawing.Point(260, 101);
            this.accountInfoUpdateButton.Name = "accountInfoUpdateButton";
            this.accountInfoUpdateButton.Size = new System.Drawing.Size(43, 23);
            this.accountInfoUpdateButton.TabIndex = 36;
            this.accountInfoUpdateButton.Text = "更新";
            this.accountInfoUpdateButton.UseVisualStyleBackColor = true;
            this.accountInfoUpdateButton.Click += new System.EventHandler(this.accountInfoUpdateButton_Click);
            // 
            // accountNameQueryButton
            // 
            this.accountNameQueryButton.Location = new System.Drawing.Point(189, 20);
            this.accountNameQueryButton.Name = "accountNameQueryButton";
            this.accountNameQueryButton.Size = new System.Drawing.Size(43, 23);
            this.accountNameQueryButton.TabIndex = 9;
            this.accountNameQueryButton.Text = "查询";
            this.accountNameQueryButton.UseVisualStyleBackColor = true;
            this.accountNameQueryButton.Click += new System.EventHandler(this.accountNameQueryButton_Click);
            // 
            // 账户名TextBox
            // 
            this.账户名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.账户信息表BindingSource, "账户名", true));
            this.账户名TextBox.Location = new System.Drawing.Point(83, 22);
            this.账户名TextBox.Name = "账户名TextBox";
            this.账户名TextBox.Size = new System.Drawing.Size(100, 21);
            this.账户名TextBox.TabIndex = 2;
            // 
            // 账户密码TextBox
            // 
            this.账户密码TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.账户信息表BindingSource, "账户密码", true));
            this.账户密码TextBox.Location = new System.Drawing.Point(83, 49);
            this.账户密码TextBox.Name = "账户密码TextBox";
            this.账户密码TextBox.PasswordChar = '*';
            this.账户密码TextBox.Size = new System.Drawing.Size(100, 21);
            this.账户密码TextBox.TabIndex = 4;
            // 
            // 账户信息表DataGridView
            // 
            this.账户信息表DataGridView.AllowUserToAddRows = false;
            this.账户信息表DataGridView.AllowUserToDeleteRows = false;
            this.账户信息表DataGridView.AllowUserToOrderColumns = true;
            this.账户信息表DataGridView.AutoGenerateColumns = false;
            this.账户信息表DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.账户信息表DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.账户信息表DataGridView.DataSource = this.账户信息表BindingSource;
            this.账户信息表DataGridView.Location = new System.Drawing.Point(3, 140);
            this.账户信息表DataGridView.Name = "账户信息表DataGridView";
            this.账户信息表DataGridView.ReadOnly = true;
            this.账户信息表DataGridView.RowTemplate.Height = 23;
            this.账户信息表DataGridView.Size = new System.Drawing.Size(669, 406);
            this.账户信息表DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "账户名";
            this.dataGridViewTextBoxColumn1.HeaderText = "账户名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 230;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "账户类别";
            this.dataGridViewTextBoxColumn3.HeaderText = "账户类别";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "账户权限";
            this.dataGridViewTextBoxColumn4.HeaderText = "账户权限";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // exitSystemLable
            // 
            this.exitSystemLable.AutoSize = true;
            this.exitSystemLable.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitSystemLable.Location = new System.Drawing.Point(594, 43);
            this.exitSystemLable.Name = "exitSystemLable";
            this.exitSystemLable.Size = new System.Drawing.Size(85, 19);
            this.exitSystemLable.TabIndex = 1;
            this.exitSystemLable.Text = "退出系统";
            this.exitSystemLable.Click += new System.EventHandler(this.exitSystemLable_Click);
            // 
            // 学校信息表TableAdapter
            // 
            this.学校信息表TableAdapter.ClearBeforeFill = true;
            // 
            // 学生信息表TableAdapter
            // 
            this.学生信息表TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.专业信息表TableAdapter = null;
            this.tableAdapterManager.学校信息表TableAdapter = this.学校信息表TableAdapter;
            this.tableAdapterManager.学生信息表TableAdapter = this.学生信息表TableAdapter;
            this.tableAdapterManager.班级信息表TableAdapter = null;
            this.tableAdapterManager.账户信息表TableAdapter = null;
            // 
            // 账户信息表TableAdapter
            // 
            this.账户信息表TableAdapter.ClearBeforeFill = true;
            // 
            // 专业信息表TableAdapter
            // 
            this.专业信息表TableAdapter.ClearBeforeFill = true;
            // 
            // 专业信息表BindingSource
            // 
            this.专业信息表BindingSource.DataMember = "专业信息表";
            this.专业信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // 班级信息表TableAdapter
            // 
            this.班级信息表TableAdapter.ClearBeforeFill = true;
            // 
            // 班级信息表BindingSource
            // 
            this.班级信息表BindingSource.DataMember = "班级信息表";
            this.班级信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 617);
            this.Controls.Add(this.exitSystemLable);
            this.Controls.Add(this.schoolTabControl);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "AdminForm";
            this.Text = "学籍管理系统管理后台";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.schoolTabControl.ResumeLayout(false);
            this.schoolTabPage.ResumeLayout(false);
            this.schoolTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.学校信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeTableDataGridView)).EndInit();
            this.studentTabPage.ResumeLayout(false);
            this.studentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.学生信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.照片PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.accountTabPage.ResumeLayout(false);
            this.accountTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.账户信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.账户信息表DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.班级信息表BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl schoolTabControl;
        private System.Windows.Forms.TabPage schoolTabPage;
        private System.Windows.Forms.TabPage studentTabPage;
        private System.Windows.Forms.TabPage accountTabPage;
        private System.Windows.Forms.Label exitSystemLable;
        private System.Windows.Forms.Label collegeLabel;
        private System.Windows.Forms.ComboBox collegeComboBox;
        private studentinfomanagedatabaseDataSet studentinfomanagedatabaseDataSet;
        private System.Windows.Forms.BindingSource 学校信息表BindingSource;
        private studentinfomanagedatabaseDataSetTableAdapters.学校信息表TableAdapter 学校信息表TableAdapter;
        private System.Windows.Forms.ComboBox collegeCodeComboBox;
        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.ComboBox professionComboBox;
        private System.Windows.Forms.Label collegeCodeLabel;
        private System.Windows.Forms.Label professionCodeLabel;
        private System.Windows.Forms.ComboBox professionCodeComboBox;
        private System.Windows.Forms.Button classInfoAddButton;
        private System.Windows.Forms.Label classCodeLabel;
        private System.Windows.Forms.ComboBox classCodeComboBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.DataGridView collegeTableDataGridView;
        private System.Windows.Forms.Button classCodeQueryButton;
        private System.Windows.Forms.Button classInfoDeleteButton;
        private System.Windows.Forms.Button professionCodeQueryButton;
        private System.Windows.Forms.Button professionInfoDeleteButton;
        private System.Windows.Forms.Button professionInfoAddButton;
        private System.Windows.Forms.Button collegeInfoAddButton;
        private System.Windows.Forms.Button collegeInfoDeleteButton;
        private System.Windows.Forms.Button collegeCodeQueryButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 学生信息表BindingSource;
        private studentinfomanagedatabaseDataSetTableAdapters.学生信息表TableAdapter 学生信息表TableAdapter;
        private studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox 学号TextBox;
        private System.Windows.Forms.TextBox 姓名TextBox;
        private System.Windows.Forms.TextBox 性别TextBox;
        private System.Windows.Forms.DateTimePicker 出生日期DateTimePicker;
        private System.Windows.Forms.TextBox 政治面貌TextBox;
        private System.Windows.Forms.TextBox 院系名TextBox;
        private System.Windows.Forms.TextBox 专业名TextBox;
        private System.Windows.Forms.TextBox 班级号TextBox;
        private System.Windows.Forms.TextBox 电话号码TextBox;
        private System.Windows.Forms.TextBox 身份证号码TextBox;
        private System.Windows.Forms.TextBox 详细家庭住址TextBox;
        private System.Windows.Forms.PictureBox 照片PictureBox;
        private System.Windows.Forms.TextBox 备注TextBox;
        private System.Windows.Forms.Button queryByNameButton;
        private System.Windows.Forms.Button queryByClassCodeButton;
        private System.Windows.Forms.Button queryByProfessionNameButton;
        private System.Windows.Forms.Button queryByCollegeNameButton;
        private System.Windows.Forms.Button queryByPoliticalStatusButton;
        private System.Windows.Forms.Button deleteStudentInfoButton;
        private System.Windows.Forms.Button addStudentInfoButton;
        private System.Windows.Forms.Button updateStudentInfoButton;
        private System.Windows.Forms.DateTimePicker 入学时间DateTimePicker;
        private System.Windows.Forms.Button cleanQueryButton;
        private System.Windows.Forms.Button choosePictureButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 政治面貌DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入学日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 院系名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话号码DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 账户信息表BindingSource;
        private studentinfomanagedatabaseDataSetTableAdapters.账户信息表TableAdapter 账户信息表TableAdapter;
        private System.Windows.Forms.Button accountNameQueryButton;
        private System.Windows.Forms.TextBox 账户名TextBox;
        private System.Windows.Forms.TextBox 账户密码TextBox;
        private System.Windows.Forms.DataGridView 账户信息表DataGridView;
        private System.Windows.Forms.Button deleteAccountRecordButton;
        private System.Windows.Forms.Button addAccountRecordbutton;
        private System.Windows.Forms.Button accountInfoUpdateButton;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox 账户权限TextBox;
        private System.Windows.Forms.TextBox 账户类别TextBox;
        private System.Windows.Forms.Button accountCategoryButton;
        private System.Windows.Forms.Button accountAuthorityButton;
        private System.Windows.Forms.Button cleanAccountQueryButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private studentinfomanagedatabaseDataSetTableAdapters.专业信息表TableAdapter 专业信息表TableAdapter;
        private System.Windows.Forms.BindingSource 专业信息表BindingSource;
        private studentinfomanagedatabaseDataSetTableAdapters.班级信息表TableAdapter 班级信息表TableAdapter;
        private System.Windows.Forms.BindingSource 班级信息表BindingSource;
    }
}