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
            this.schoolTabControl = new System.Windows.Forms.TabControl();
            this.schoolTabPage = new System.Windows.Forms.TabPage();
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
            this.accountTabPage = new System.Windows.Forms.TabPage();
            this.exitSystemLable = new System.Windows.Forms.Label();
            this.学校信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.学校信息表TableAdapter();
            this.schoolTabControl.SuspendLayout();
            this.schoolTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.学校信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeTableDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // collegeCodeQueryButton
            // 
            this.collegeCodeQueryButton.Location = new System.Drawing.Point(321, 28);
            this.collegeCodeQueryButton.Name = "collegeCodeQueryButton";
            this.collegeCodeQueryButton.Size = new System.Drawing.Size(75, 23);
            this.collegeCodeQueryButton.TabIndex = 24;
            this.collegeCodeQueryButton.Text = "查询";
            this.collegeCodeQueryButton.UseVisualStyleBackColor = true;
            this.collegeCodeQueryButton.Click += new System.EventHandler(this.collegeCodeQueryButton_Click);
            // 
            // collegeInfoAddButton
            // 
            this.collegeInfoAddButton.Location = new System.Drawing.Point(402, 29);
            this.collegeInfoAddButton.Name = "collegeInfoAddButton";
            this.collegeInfoAddButton.Size = new System.Drawing.Size(75, 23);
            this.collegeInfoAddButton.TabIndex = 23;
            this.collegeInfoAddButton.Text = "添加";
            this.collegeInfoAddButton.UseVisualStyleBackColor = true;
            this.collegeInfoAddButton.Click += new System.EventHandler(this.collegeInfoAddButton_Click);
            // 
            // collegeInfoDeleteButton
            // 
            this.collegeInfoDeleteButton.Location = new System.Drawing.Point(402, 6);
            this.collegeInfoDeleteButton.Name = "collegeInfoDeleteButton";
            this.collegeInfoDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.collegeInfoDeleteButton.TabIndex = 22;
            this.collegeInfoDeleteButton.Text = "删除";
            this.collegeInfoDeleteButton.UseVisualStyleBackColor = true;
            this.collegeInfoDeleteButton.Click += new System.EventHandler(this.collegeInfoDeleteButton_Click);
            // 
            // professionInfoAddButton
            // 
            this.professionInfoAddButton.Location = new System.Drawing.Point(402, 79);
            this.professionInfoAddButton.Name = "professionInfoAddButton";
            this.professionInfoAddButton.Size = new System.Drawing.Size(75, 23);
            this.professionInfoAddButton.TabIndex = 21;
            this.professionInfoAddButton.Text = "添加";
            this.professionInfoAddButton.UseVisualStyleBackColor = true;
            this.professionInfoAddButton.Click += new System.EventHandler(this.professionInfoAddButton_Click);
            // 
            // professionInfoDeleteButton
            // 
            this.professionInfoDeleteButton.Location = new System.Drawing.Point(402, 56);
            this.professionInfoDeleteButton.Name = "professionInfoDeleteButton";
            this.professionInfoDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.professionInfoDeleteButton.TabIndex = 20;
            this.professionInfoDeleteButton.Text = "删除";
            this.professionInfoDeleteButton.UseVisualStyleBackColor = true;
            this.professionInfoDeleteButton.Click += new System.EventHandler(this.professionInfoDeleteButton_Click);
            // 
            // professionCodeQueryButton
            // 
            this.professionCodeQueryButton.Location = new System.Drawing.Point(321, 79);
            this.professionCodeQueryButton.Name = "professionCodeQueryButton";
            this.professionCodeQueryButton.Size = new System.Drawing.Size(75, 23);
            this.professionCodeQueryButton.TabIndex = 19;
            this.professionCodeQueryButton.Text = "查询";
            this.professionCodeQueryButton.UseVisualStyleBackColor = true;
            this.professionCodeQueryButton.Click += new System.EventHandler(this.professionCodeQueryButton_Click);
            // 
            // classInfoDeleteButton
            // 
            this.classInfoDeleteButton.Location = new System.Drawing.Point(402, 108);
            this.classInfoDeleteButton.Name = "classInfoDeleteButton";
            this.classInfoDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.classInfoDeleteButton.TabIndex = 18;
            this.classInfoDeleteButton.Text = "删除";
            this.classInfoDeleteButton.UseVisualStyleBackColor = true;
            this.classInfoDeleteButton.Click += new System.EventHandler(this.classInfoDeleteButton_Click);
            // 
            // classCodeQueryButton
            // 
            this.classCodeQueryButton.Location = new System.Drawing.Point(321, 131);
            this.classCodeQueryButton.Name = "classCodeQueryButton";
            this.classCodeQueryButton.Size = new System.Drawing.Size(75, 23);
            this.classCodeQueryButton.TabIndex = 17;
            this.classCodeQueryButton.Text = "查询";
            this.classCodeQueryButton.UseVisualStyleBackColor = true;
            this.classCodeQueryButton.Click += new System.EventHandler(this.classCodeQueryButton_Click);
            // 
            // classInfoAddButton
            // 
            this.classInfoAddButton.Location = new System.Drawing.Point(402, 131);
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
            this.classCodeLabel.Location = new System.Drawing.Point(226, 115);
            this.classCodeLabel.Name = "classCodeLabel";
            this.classCodeLabel.Size = new System.Drawing.Size(41, 12);
            this.classCodeLabel.TabIndex = 14;
            this.classCodeLabel.Text = "班级号";
            // 
            // classCodeComboBox
            // 
            this.classCodeComboBox.FormattingEnabled = true;
            this.classCodeComboBox.Location = new System.Drawing.Point(228, 133);
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
            this.professionCodeLabel.Location = new System.Drawing.Point(224, 64);
            this.professionCodeLabel.Name = "professionCodeLabel";
            this.professionCodeLabel.Size = new System.Drawing.Size(53, 12);
            this.professionCodeLabel.TabIndex = 10;
            this.professionCodeLabel.Text = "专业代码";
            // 
            // professionCodeComboBox
            // 
            this.professionCodeComboBox.FormattingEnabled = true;
            this.professionCodeComboBox.Location = new System.Drawing.Point(226, 82);
            this.professionCodeComboBox.Name = "professionCodeComboBox";
            this.professionCodeComboBox.Size = new System.Drawing.Size(87, 20);
            this.professionCodeComboBox.TabIndex = 9;
            // 
            // collegeCodeLabel
            // 
            this.collegeCodeLabel.AutoSize = true;
            this.collegeCodeLabel.Location = new System.Drawing.Point(226, 12);
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
            this.collegeCodeComboBox.Location = new System.Drawing.Point(228, 30);
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
            this.collegeTableDataGridView.AllowUserToOrderColumns = true;
            this.collegeTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collegeTableDataGridView.Location = new System.Drawing.Point(0, 173);
            this.collegeTableDataGridView.Name = "collegeTableDataGridView";
            this.collegeTableDataGridView.RowTemplate.Height = 23;
            this.collegeTableDataGridView.Size = new System.Drawing.Size(675, 377);
            this.collegeTableDataGridView.TabIndex = 16;
            // 
            // studentTabPage
            // 
            this.studentTabPage.Location = new System.Drawing.Point(4, 22);
            this.studentTabPage.Name = "studentTabPage";
            this.studentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentTabPage.Size = new System.Drawing.Size(675, 546);
            this.studentTabPage.TabIndex = 1;
            this.studentTabPage.Text = "学生信息管理";
            this.studentTabPage.UseVisualStyleBackColor = true;
            // 
            // accountTabPage
            // 
            this.accountTabPage.Location = new System.Drawing.Point(4, 22);
            this.accountTabPage.Name = "accountTabPage";
            this.accountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountTabPage.Size = new System.Drawing.Size(675, 546);
            this.accountTabPage.TabIndex = 2;
            this.accountTabPage.Text = "账户信息管理";
            this.accountTabPage.UseVisualStyleBackColor = true;
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
            // 
            // 学校信息表TableAdapter
            // 
            this.学校信息表TableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 617);
            this.Controls.Add(this.exitSystemLable);
            this.Controls.Add(this.schoolTabControl);
            this.Name = "AdminForm";
            this.Text = "学籍管理系统管理后台";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.schoolTabControl.ResumeLayout(false);
            this.schoolTabPage.ResumeLayout(false);
            this.schoolTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.学校信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeTableDataGridView)).EndInit();
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
    }
}