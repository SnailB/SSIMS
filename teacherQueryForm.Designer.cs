namespace 学籍管理系统
{
    partial class TeacherQueryForm
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
            System.Windows.Forms.Label 学院名Label;
            System.Windows.Forms.Label 专业名Label2;
            System.Windows.Forms.Label 班级号Label2;
            System.Windows.Forms.Label 总学分Label;
            this.cleanQueryButton = new System.Windows.Forms.Button();
            this.queryByNameButton = new System.Windows.Forms.Button();
            this.照片PictureBox = new System.Windows.Forms.PictureBox();
            this.学生信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentinfomanagedatabaseDataSet = new 学籍管理系统.studentinfomanagedatabaseDataSet();
            this.studentPictureLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学生信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.学生信息表TableAdapter();
            this.tableAdapterManager = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager();
            this.专业信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.专业信息表TableAdapter();
            this.学校信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.学校信息表TableAdapter();
            this.班级信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.班级信息表TableAdapter();
            this.专业信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.学校信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.学院名ComboBox = new System.Windows.Forms.ComboBox();
            this.专业名ComboBox = new System.Windows.Forms.ComboBox();
            this.班级信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.班级号ComboBox = new System.Windows.Forms.ComboBox();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总学分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.院系名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出生日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.政治面貌DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入学日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话号码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总学分Label1 = new System.Windows.Forms.Label();
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
            学院名Label = new System.Windows.Forms.Label();
            专业名Label2 = new System.Windows.Forms.Label();
            班级号Label2 = new System.Windows.Forms.Label();
            总学分Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.照片PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学校信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.班级信息表BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 学号Label
            // 
            学号Label.AutoSize = true;
            学号Label.Location = new System.Drawing.Point(281, 29);
            学号Label.Name = "学号Label";
            学号Label.Size = new System.Drawing.Size(35, 12);
            学号Label.TabIndex = 40;
            学号Label.Text = "学号:";
            // 
            // 姓名Label
            // 
            姓名Label.AutoSize = true;
            姓名Label.Location = new System.Drawing.Point(27, 29);
            姓名Label.Name = "姓名Label";
            姓名Label.Size = new System.Drawing.Size(35, 12);
            姓名Label.TabIndex = 42;
            姓名Label.Text = "姓名:";
            // 
            // 性别Label
            // 
            性别Label.AutoSize = true;
            性别Label.Location = new System.Drawing.Point(197, 29);
            性别Label.Name = "性别Label";
            性别Label.Size = new System.Drawing.Size(35, 12);
            性别Label.TabIndex = 44;
            性别Label.Text = "性别:";
            // 
            // 出生日期Label
            // 
            出生日期Label.AutoSize = true;
            出生日期Label.Location = new System.Drawing.Point(27, 62);
            出生日期Label.Name = "出生日期Label";
            出生日期Label.Size = new System.Drawing.Size(59, 12);
            出生日期Label.TabIndex = 46;
            出生日期Label.Text = "出生日期:";
            // 
            // 政治面貌Label
            // 
            政治面貌Label.AutoSize = true;
            政治面貌Label.Location = new System.Drawing.Point(27, 94);
            政治面貌Label.Name = "政治面貌Label";
            政治面貌Label.Size = new System.Drawing.Size(59, 12);
            政治面貌Label.TabIndex = 48;
            政治面貌Label.Text = "政治面貌:";
            // 
            // 入学日期Label
            // 
            入学日期Label.AutoSize = true;
            入学日期Label.Location = new System.Drawing.Point(27, 126);
            入学日期Label.Name = "入学日期Label";
            入学日期Label.Size = new System.Drawing.Size(59, 12);
            入学日期Label.TabIndex = 50;
            入学日期Label.Text = "入学日期:";
            // 
            // 院系名Label
            // 
            院系名Label.AutoSize = true;
            院系名Label.Location = new System.Drawing.Point(281, 62);
            院系名Label.Name = "院系名Label";
            院系名Label.Size = new System.Drawing.Size(47, 12);
            院系名Label.TabIndex = 51;
            院系名Label.Text = "院系名:";
            // 
            // 专业名Label
            // 
            专业名Label.AutoSize = true;
            专业名Label.Location = new System.Drawing.Point(281, 88);
            专业名Label.Name = "专业名Label";
            专业名Label.Size = new System.Drawing.Size(47, 12);
            专业名Label.TabIndex = 53;
            专业名Label.Text = "专业名:";
            // 
            // 班级号Label
            // 
            班级号Label.AutoSize = true;
            班级号Label.Location = new System.Drawing.Point(281, 114);
            班级号Label.Name = "班级号Label";
            班级号Label.Size = new System.Drawing.Size(47, 12);
            班级号Label.TabIndex = 55;
            班级号Label.Text = "班级号:";
            // 
            // 电话号码Label
            // 
            电话号码Label.AutoSize = true;
            电话号码Label.Location = new System.Drawing.Point(27, 158);
            电话号码Label.Name = "电话号码Label";
            电话号码Label.Size = new System.Drawing.Size(59, 12);
            电话号码Label.TabIndex = 57;
            电话号码Label.Text = "电话号码:";
            // 
            // 身份证号码Label
            // 
            身份证号码Label.AutoSize = true;
            身份证号码Label.Location = new System.Drawing.Point(27, 190);
            身份证号码Label.Name = "身份证号码Label";
            身份证号码Label.Size = new System.Drawing.Size(71, 12);
            身份证号码Label.TabIndex = 59;
            身份证号码Label.Text = "身份证号码:";
            // 
            // 详细家庭住址Label
            // 
            详细家庭住址Label.AutoSize = true;
            详细家庭住址Label.Location = new System.Drawing.Point(281, 140);
            详细家庭住址Label.Name = "详细家庭住址Label";
            详细家庭住址Label.Size = new System.Drawing.Size(35, 36);
            详细家庭住址Label.TabIndex = 61;
            详细家庭住址Label.Text = "详细\r\n家庭\r\n住址:";
            // 
            // 学院名Label
            // 
            学院名Label.AutoSize = true;
            学院名Label.Location = new System.Drawing.Point(27, 226);
            学院名Label.Name = "学院名Label";
            学院名Label.Size = new System.Drawing.Size(47, 12);
            学院名Label.TabIndex = 85;
            学院名Label.Text = "学院名:";
            // 
            // 专业名Label2
            // 
            专业名Label2.AutoSize = true;
            专业名Label2.Location = new System.Drawing.Point(172, 226);
            专业名Label2.Name = "专业名Label2";
            专业名Label2.Size = new System.Drawing.Size(47, 12);
            专业名Label2.TabIndex = 86;
            专业名Label2.Text = "专业名:";
            // 
            // 班级号Label2
            // 
            班级号Label2.AutoSize = true;
            班级号Label2.Location = new System.Drawing.Point(320, 226);
            班级号Label2.Name = "班级号Label2";
            班级号Label2.Size = new System.Drawing.Size(47, 12);
            班级号Label2.TabIndex = 87;
            班级号Label2.Text = "班级号:";
            // 
            // cleanQueryButton
            // 
            this.cleanQueryButton.Location = new System.Drawing.Point(518, 246);
            this.cleanQueryButton.Name = "cleanQueryButton";
            this.cleanQueryButton.Size = new System.Drawing.Size(75, 23);
            this.cleanQueryButton.TabIndex = 72;
            this.cleanQueryButton.Text = "清除查询";
            this.cleanQueryButton.UseVisualStyleBackColor = true;
            this.cleanQueryButton.Click += new System.EventHandler(this.cleanQueryButton_Click);
            // 
            // queryByNameButton
            // 
            this.queryByNameButton.Location = new System.Drawing.Point(147, 24);
            this.queryByNameButton.Name = "queryByNameButton";
            this.queryByNameButton.Size = new System.Drawing.Size(43, 23);
            this.queryByNameButton.TabIndex = 66;
            this.queryByNameButton.Text = "查询";
            this.queryByNameButton.UseVisualStyleBackColor = true;
            this.queryByNameButton.Click += new System.EventHandler(this.queryByNameButton_Click);
            // 
            // 照片PictureBox
            // 
            this.照片PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.照片PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.照片PictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.学生信息表BindingSource, "照片", true));
            this.照片PictureBox.Location = new System.Drawing.Point(500, 11);
            this.照片PictureBox.Name = "照片PictureBox";
            this.照片PictureBox.Size = new System.Drawing.Size(130, 157);
            this.照片PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.照片PictureBox.TabIndex = 63;
            this.照片PictureBox.TabStop = false;
            // 
            // 学生信息表BindingSource
            // 
            this.学生信息表BindingSource.DataMember = "学生信息表";
            this.学生信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // studentinfomanagedatabaseDataSet
            // 
            this.studentinfomanagedatabaseDataSet.DataSetName = "studentinfomanagedatabaseDataSet";
            this.studentinfomanagedatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentPictureLabel
            // 
            this.studentPictureLabel.AutoSize = true;
            this.studentPictureLabel.Location = new System.Drawing.Point(500, 184);
            this.studentPictureLabel.Name = "studentPictureLabel";
            this.studentPictureLabel.Size = new System.Drawing.Size(29, 12);
            this.studentPictureLabel.TabIndex = 73;
            this.studentPictureLabel.Text = "照片";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "姓名", true));
            this.studentNameTextBox.Location = new System.Drawing.Point(68, 24);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(73, 21);
            this.studentNameTextBox.TabIndex = 75;
            // 
            // studentCodeTextBox
            // 
            this.studentCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "学号", true));
            this.studentCodeTextBox.Location = new System.Drawing.Point(322, 24);
            this.studentCodeTextBox.Name = "studentCodeTextBox";
            this.studentCodeTextBox.Size = new System.Drawing.Size(89, 21);
            this.studentCodeTextBox.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "性别", true));
            this.label1.Location = new System.Drawing.Point(234, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 77;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "出生日期", true));
            this.label2.Location = new System.Drawing.Point(100, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 78;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "政治面貌", true));
            this.label3.Location = new System.Drawing.Point(100, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 78;
            this.label3.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "入学日期", true));
            this.label4.Location = new System.Drawing.Point(100, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 78;
            this.label4.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "电话号码", true));
            this.label5.Location = new System.Drawing.Point(100, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 78;
            this.label5.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "身份证号码", true));
            this.label6.Location = new System.Drawing.Point(100, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 78;
            this.label6.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "院系名", true));
            this.label7.Location = new System.Drawing.Point(334, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 78;
            this.label7.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "详细家庭住址", true));
            this.label9.Location = new System.Drawing.Point(334, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 78;
            this.label9.Text = "label2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "班级号", true));
            this.label10.Location = new System.Drawing.Point(334, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 78;
            this.label10.Text = "label2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "专业名", true));
            this.label11.Location = new System.Drawing.Point(334, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 78;
            this.label11.Text = "label2";
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
            this.总学分,
            this.班级号DataGridViewTextBoxColumn,
            this.专业名DataGridViewTextBoxColumn,
            this.院系名DataGridViewTextBoxColumn,
            this.出生日期DataGridViewTextBoxColumn,
            this.政治面貌DataGridViewTextBoxColumn,
            this.入学日期DataGridViewTextBoxColumn,
            this.电话号码DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.学生信息表BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 337);
            this.dataGridView1.TabIndex = 39;
            // 
            // 学生信息表TableAdapter
            // 
            this.学生信息表TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.专业信息表TableAdapter = this.专业信息表TableAdapter;
            this.tableAdapterManager.学校信息表TableAdapter = this.学校信息表TableAdapter;
            this.tableAdapterManager.学生信息表TableAdapter = this.学生信息表TableAdapter;
            this.tableAdapterManager.班级信息表TableAdapter = this.班级信息表TableAdapter;
            this.tableAdapterManager.账户信息表TableAdapter = null;
            // 
            // 专业信息表TableAdapter
            // 
            this.专业信息表TableAdapter.ClearBeforeFill = true;
            // 
            // 学校信息表TableAdapter
            // 
            this.学校信息表TableAdapter.ClearBeforeFill = true;
            // 
            // 班级信息表TableAdapter
            // 
            this.班级信息表TableAdapter.ClearBeforeFill = true;
            // 
            // 专业信息表BindingSource
            // 
            this.专业信息表BindingSource.DataMember = "专业信息表";
            this.专业信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // 学校信息表BindingSource
            // 
            this.学校信息表BindingSource.DataMember = "学校信息表";
            this.学校信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // 学院名ComboBox
            // 
            this.学院名ComboBox.DataSource = this.学校信息表BindingSource;
            this.学院名ComboBox.DisplayMember = "学院名";
            this.学院名ComboBox.FormattingEnabled = true;
            this.学院名ComboBox.Location = new System.Drawing.Point(29, 249);
            this.学院名ComboBox.Name = "学院名ComboBox";
            this.学院名ComboBox.Size = new System.Drawing.Size(121, 20);
            this.学院名ComboBox.TabIndex = 86;
            this.学院名ComboBox.ValueMember = "学院名";
            // 
            // 专业名ComboBox
            // 
            this.专业名ComboBox.DataSource = this.专业信息表BindingSource;
            this.专业名ComboBox.DisplayMember = "专业名";
            this.专业名ComboBox.FormattingEnabled = true;
            this.专业名ComboBox.Location = new System.Drawing.Point(174, 249);
            this.专业名ComboBox.Name = "专业名ComboBox";
            this.专业名ComboBox.Size = new System.Drawing.Size(121, 20);
            this.专业名ComboBox.TabIndex = 87;
            this.专业名ComboBox.ValueMember = "专业名";
            // 
            // 班级信息表BindingSource
            // 
            this.班级信息表BindingSource.DataMember = "班级信息表";
            this.班级信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // 班级号ComboBox
            // 
            this.班级号ComboBox.DataSource = this.班级信息表BindingSource;
            this.班级号ComboBox.DisplayMember = "班级号";
            this.班级号ComboBox.FormattingEnabled = true;
            this.班级号ComboBox.Location = new System.Drawing.Point(322, 249);
            this.班级号ComboBox.Name = "班级号ComboBox";
            this.班级号ComboBox.Size = new System.Drawing.Size(121, 20);
            this.班级号ComboBox.TabIndex = 88;
            this.班级号ComboBox.ValueMember = "班级号";
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
            this.性别DataGridViewTextBoxColumn.Width = 80;
            // 
            // 总学分
            // 
            this.总学分.DataPropertyName = "总学分";
            this.总学分.HeaderText = "总学分";
            this.总学分.Name = "总学分";
            this.总学分.ReadOnly = true;
            this.总学分.Width = 80;
            // 
            // 班级号DataGridViewTextBoxColumn
            // 
            this.班级号DataGridViewTextBoxColumn.DataPropertyName = "班级号";
            this.班级号DataGridViewTextBoxColumn.HeaderText = "班级号";
            this.班级号DataGridViewTextBoxColumn.Name = "班级号DataGridViewTextBoxColumn";
            this.班级号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 专业名DataGridViewTextBoxColumn
            // 
            this.专业名DataGridViewTextBoxColumn.DataPropertyName = "专业名";
            this.专业名DataGridViewTextBoxColumn.HeaderText = "专业名";
            this.专业名DataGridViewTextBoxColumn.Name = "专业名DataGridViewTextBoxColumn";
            this.专业名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 院系名DataGridViewTextBoxColumn
            // 
            this.院系名DataGridViewTextBoxColumn.DataPropertyName = "院系名";
            this.院系名DataGridViewTextBoxColumn.HeaderText = "院系名";
            this.院系名DataGridViewTextBoxColumn.Name = "院系名DataGridViewTextBoxColumn";
            this.院系名DataGridViewTextBoxColumn.ReadOnly = true;
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
            // 电话号码DataGridViewTextBoxColumn
            // 
            this.电话号码DataGridViewTextBoxColumn.DataPropertyName = "电话号码";
            this.电话号码DataGridViewTextBoxColumn.HeaderText = "电话号码";
            this.电话号码DataGridViewTextBoxColumn.Name = "电话号码DataGridViewTextBoxColumn";
            this.电话号码DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 总学分Label
            // 
            总学分Label.AutoSize = true;
            总学分Label.Location = new System.Drawing.Point(281, 190);
            总学分Label.Name = "总学分Label";
            总学分Label.Size = new System.Drawing.Size(47, 12);
            总学分Label.TabIndex = 88;
            总学分Label.Text = "总学分:";
            // 
            // 总学分Label1
            // 
            this.总学分Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "总学分", true));
            this.总学分Label1.Location = new System.Drawing.Point(334, 190);
            this.总学分Label1.Name = "总学分Label1";
            this.总学分Label1.Size = new System.Drawing.Size(100, 23);
            this.总学分Label1.TabIndex = 89;
            this.总学分Label1.Text = "label8";
            // 
            // TeacherQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 634);
            this.Controls.Add(总学分Label);
            this.Controls.Add(this.总学分Label1);
            this.Controls.Add(班级号Label2);
            this.Controls.Add(this.班级号ComboBox);
            this.Controls.Add(专业名Label2);
            this.Controls.Add(this.专业名ComboBox);
            this.Controls.Add(学院名Label);
            this.Controls.Add(this.学院名ComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentCodeTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentPictureLabel);
            this.Controls.Add(this.cleanQueryButton);
            this.Controls.Add(this.queryByNameButton);
            this.Controls.Add(学号Label);
            this.Controls.Add(姓名Label);
            this.Controls.Add(性别Label);
            this.Controls.Add(出生日期Label);
            this.Controls.Add(政治面貌Label);
            this.Controls.Add(入学日期Label);
            this.Controls.Add(院系名Label);
            this.Controls.Add(专业名Label);
            this.Controls.Add(班级号Label);
            this.Controls.Add(电话号码Label);
            this.Controls.Add(身份证号码Label);
            this.Controls.Add(详细家庭住址Label);
            this.Controls.Add(this.照片PictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeacherQueryForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.teacherQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.照片PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学校信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.班级信息表BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cleanQueryButton;
        private System.Windows.Forms.Button queryByNameButton;
        private System.Windows.Forms.PictureBox 照片PictureBox;
        private System.Windows.Forms.Label studentPictureLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private studentinfomanagedatabaseDataSet studentinfomanagedatabaseDataSet;
        private System.Windows.Forms.BindingSource 学生信息表BindingSource;
        private studentinfomanagedatabaseDataSetTableAdapters.学生信息表TableAdapter 学生信息表TableAdapter;
        private studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private studentinfomanagedatabaseDataSetTableAdapters.专业信息表TableAdapter 专业信息表TableAdapter;
        private System.Windows.Forms.BindingSource 专业信息表BindingSource;
        private studentinfomanagedatabaseDataSetTableAdapters.学校信息表TableAdapter 学校信息表TableAdapter;
        private System.Windows.Forms.BindingSource 学校信息表BindingSource;
        private System.Windows.Forms.ComboBox 学院名ComboBox;
        private studentinfomanagedatabaseDataSetTableAdapters.班级信息表TableAdapter 班级信息表TableAdapter;
        private System.Windows.Forms.ComboBox 专业名ComboBox;
        private System.Windows.Forms.BindingSource 班级信息表BindingSource;
        private System.Windows.Forms.ComboBox 班级号ComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总学分;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 院系名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 政治面貌DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入学日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话号码DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label 总学分Label1;
    }
}