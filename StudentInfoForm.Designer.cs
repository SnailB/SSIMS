namespace 学籍管理系统
{
    partial class StudentInfoForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.学生信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentinfomanagedatabaseDataSet = new 学籍管理系统.studentinfomanagedatabaseDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出生日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.政治面貌DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入学日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.院系名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话号码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentPictureLabel = new System.Windows.Forms.Label();
            this.班级号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.照片PictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学生信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.学生信息表TableAdapter();
            this.label13 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.学生信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.照片PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 学号Label
            // 
            学号Label.AutoSize = true;
            学号Label.Location = new System.Drawing.Point(274, 58);
            学号Label.Name = "学号Label";
            学号Label.Size = new System.Drawing.Size(35, 12);
            学号Label.TabIndex = 79;
            学号Label.Text = "学号:";
            // 
            // 姓名Label
            // 
            姓名Label.AutoSize = true;
            姓名Label.Location = new System.Drawing.Point(39, 30);
            姓名Label.Name = "姓名Label";
            姓名Label.Size = new System.Drawing.Size(35, 12);
            姓名Label.TabIndex = 80;
            姓名Label.Text = "姓名:";
            // 
            // 性别Label
            // 
            性别Label.AutoSize = true;
            性别Label.Location = new System.Drawing.Point(276, 30);
            性别Label.Name = "性别Label";
            性别Label.Size = new System.Drawing.Size(35, 12);
            性别Label.TabIndex = 81;
            性别Label.Text = "性别:";
            // 
            // 出生日期Label
            // 
            出生日期Label.AutoSize = true;
            出生日期Label.Location = new System.Drawing.Point(39, 63);
            出生日期Label.Name = "出生日期Label";
            出生日期Label.Size = new System.Drawing.Size(59, 12);
            出生日期Label.TabIndex = 82;
            出生日期Label.Text = "出生日期:";
            // 
            // 政治面貌Label
            // 
            政治面貌Label.AutoSize = true;
            政治面貌Label.Location = new System.Drawing.Point(39, 95);
            政治面貌Label.Name = "政治面貌Label";
            政治面貌Label.Size = new System.Drawing.Size(59, 12);
            政治面貌Label.TabIndex = 83;
            政治面貌Label.Text = "政治面貌:";
            // 
            // 入学日期Label
            // 
            入学日期Label.AutoSize = true;
            入学日期Label.Location = new System.Drawing.Point(39, 127);
            入学日期Label.Name = "入学日期Label";
            入学日期Label.Size = new System.Drawing.Size(59, 12);
            入学日期Label.TabIndex = 84;
            入学日期Label.Text = "入学日期:";
            // 
            // 院系名Label
            // 
            院系名Label.AutoSize = true;
            院系名Label.Location = new System.Drawing.Point(274, 86);
            院系名Label.Name = "院系名Label";
            院系名Label.Size = new System.Drawing.Size(47, 12);
            院系名Label.TabIndex = 85;
            院系名Label.Text = "院系名:";
            // 
            // 专业名Label
            // 
            专业名Label.AutoSize = true;
            专业名Label.Location = new System.Drawing.Point(274, 114);
            专业名Label.Name = "专业名Label";
            专业名Label.Size = new System.Drawing.Size(47, 12);
            专业名Label.TabIndex = 86;
            专业名Label.Text = "专业名:";
            // 
            // 班级号Label
            // 
            班级号Label.AutoSize = true;
            班级号Label.Location = new System.Drawing.Point(274, 142);
            班级号Label.Name = "班级号Label";
            班级号Label.Size = new System.Drawing.Size(47, 12);
            班级号Label.TabIndex = 87;
            班级号Label.Text = "班级号:";
            // 
            // 电话号码Label
            // 
            电话号码Label.AutoSize = true;
            电话号码Label.Location = new System.Drawing.Point(39, 159);
            电话号码Label.Name = "电话号码Label";
            电话号码Label.Size = new System.Drawing.Size(59, 12);
            电话号码Label.TabIndex = 88;
            电话号码Label.Text = "电话号码:";
            // 
            // 身份证号码Label
            // 
            身份证号码Label.AutoSize = true;
            身份证号码Label.Location = new System.Drawing.Point(39, 191);
            身份证号码Label.Name = "身份证号码Label";
            身份证号码Label.Size = new System.Drawing.Size(71, 12);
            身份证号码Label.TabIndex = 89;
            身份证号码Label.Text = "身份证号码:";
            // 
            // 详细家庭住址Label
            // 
            详细家庭住址Label.AutoSize = true;
            详细家庭住址Label.Location = new System.Drawing.Point(274, 170);
            详细家庭住址Label.Name = "详细家庭住址Label";
            详细家庭住址Label.Size = new System.Drawing.Size(35, 36);
            详细家庭住址Label.TabIndex = 90;
            详细家庭住址Label.Text = "详细\r\n家庭\r\n住址:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "专业名", true));
            this.label11.Location = new System.Drawing.Point(327, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 106;
            this.label11.Text = "label2";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "班级号", true));
            this.label10.Location = new System.Drawing.Point(327, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 105;
            this.label10.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "详细家庭住址", true));
            this.label9.Location = new System.Drawing.Point(327, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 104;
            this.label9.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "身份证号码", true));
            this.label6.Location = new System.Drawing.Point(112, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 103;
            this.label6.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "电话号码", true));
            this.label5.Location = new System.Drawing.Point(112, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 102;
            this.label5.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "政治面貌", true));
            this.label3.Location = new System.Drawing.Point(112, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 101;
            this.label3.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "院系名", true));
            this.label7.Location = new System.Drawing.Point(327, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 100;
            this.label7.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "入学日期", true));
            this.label4.Location = new System.Drawing.Point(112, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 99;
            this.label4.Text = "label2";
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
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
            this.学号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 电话号码DataGridViewTextBoxColumn
            // 
            this.电话号码DataGridViewTextBoxColumn.DataPropertyName = "电话号码";
            this.电话号码DataGridViewTextBoxColumn.HeaderText = "电话号码";
            this.电话号码DataGridViewTextBoxColumn.Name = "电话号码DataGridViewTextBoxColumn";
            this.电话号码DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "出生日期", true));
            this.label2.Location = new System.Drawing.Point(112, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 98;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "性别", true));
            this.label1.Location = new System.Drawing.Point(327, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 97;
            this.label1.Text = "label1";
            // 
            // studentPictureLabel
            // 
            this.studentPictureLabel.AutoSize = true;
            this.studentPictureLabel.Location = new System.Drawing.Point(512, 185);
            this.studentPictureLabel.Name = "studentPictureLabel";
            this.studentPictureLabel.Size = new System.Drawing.Size(29, 12);
            this.studentPictureLabel.TabIndex = 93;
            this.studentPictureLabel.Text = "照片";
            // 
            // 班级号DataGridViewTextBoxColumn
            // 
            this.班级号DataGridViewTextBoxColumn.DataPropertyName = "班级号";
            this.班级号DataGridViewTextBoxColumn.HeaderText = "班级号";
            this.班级号DataGridViewTextBoxColumn.Name = "班级号DataGridViewTextBoxColumn";
            this.班级号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 照片PictureBox
            // 
            this.照片PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.照片PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.照片PictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.学生信息表BindingSource, "照片", true));
            this.照片PictureBox.Location = new System.Drawing.Point(512, 12);
            this.照片PictureBox.Name = "照片PictureBox";
            this.照片PictureBox.Size = new System.Drawing.Size(130, 157);
            this.照片PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.照片PictureBox.TabIndex = 91;
            this.照片PictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "姓名", true));
            this.label8.Location = new System.Drawing.Point(112, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 98;
            this.label8.Text = "label2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生信息表BindingSource, "学号", true));
            this.label12.Location = new System.Drawing.Point(327, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 100;
            this.label12.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(679, 376);
            this.dataGridView1.TabIndex = 107;
            // 
            // 学生信息表TableAdapter
            // 
            this.学生信息表TableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 108;
            this.label13.Text = "成绩信息";
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 617);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentPictureLabel);
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
            this.Name = "StudentInfoForm";
            this.Text = "StudentInfoForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StudentInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.学生信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.照片PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 政治面貌DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入学日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 院系名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话号码DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label studentPictureLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级号DataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox 照片PictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private studentinfomanagedatabaseDataSetTableAdapters.学生信息表TableAdapter 学生信息表TableAdapter;
        private System.Windows.Forms.BindingSource 学生信息表BindingSource;
        private studentinfomanagedatabaseDataSet studentinfomanagedatabaseDataSet;
        private System.Windows.Forms.Label label13;
    }
}