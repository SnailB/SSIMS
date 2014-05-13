namespace 学籍管理系统
{
    partial class StudentRegisterForm
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
            this.studentAccountRegisterTableAdapter1 = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.账户信息表TableAdapter();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordConfirmTextBox = new System.Windows.Forms.TextBox();
            this.passwordConfirmLabel = new System.Windows.Forms.Label();
            this.commitbutton = new System.Windows.Forms.Button();
            this.exitStudentRegisterFormButton = new System.Windows.Forms.Button();
            this.studentinfomanagedatabaseDataSet = new 学籍管理系统.studentinfomanagedatabaseDataSet();
            this.tableAdapterManager = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager();
            this.学生信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.学生信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.学生信息表TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生信息表BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentAccountRegisterTableAdapter1
            // 
            this.studentAccountRegisterTableAdapter1.ClearBeforeFill = true;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(283, 155);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(168, 21);
            this.userNameTextBox.TabIndex = 0;
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(221, 158);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(29, 12);
            this.studentIDLabel.TabIndex = 1;
            this.studentIDLabel.Text = "学号";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(283, 194);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(168, 21);
            this.passwordTextBox.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(221, 197);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(29, 12);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "密码";
            // 
            // passwordConfirmTextBox
            // 
            this.passwordConfirmTextBox.Location = new System.Drawing.Point(283, 231);
            this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            this.passwordConfirmTextBox.PasswordChar = '*';
            this.passwordConfirmTextBox.Size = new System.Drawing.Size(168, 21);
            this.passwordConfirmTextBox.TabIndex = 0;
            // 
            // passwordConfirmLabel
            // 
            this.passwordConfirmLabel.AutoSize = true;
            this.passwordConfirmLabel.Location = new System.Drawing.Point(221, 234);
            this.passwordConfirmLabel.Name = "passwordConfirmLabel";
            this.passwordConfirmLabel.Size = new System.Drawing.Size(53, 12);
            this.passwordConfirmLabel.TabIndex = 1;
            this.passwordConfirmLabel.Text = "确认密码";
            // 
            // commitbutton
            // 
            this.commitbutton.Location = new System.Drawing.Point(283, 267);
            this.commitbutton.Name = "commitbutton";
            this.commitbutton.Size = new System.Drawing.Size(75, 23);
            this.commitbutton.TabIndex = 2;
            this.commitbutton.Text = "提交";
            this.commitbutton.UseVisualStyleBackColor = true;
            this.commitbutton.Click += new System.EventHandler(this.commitbutton_Click);
            // 
            // exitStudentRegisterFormButton
            // 
            this.exitStudentRegisterFormButton.Location = new System.Drawing.Point(376, 267);
            this.exitStudentRegisterFormButton.Name = "exitStudentRegisterFormButton";
            this.exitStudentRegisterFormButton.Size = new System.Drawing.Size(75, 23);
            this.exitStudentRegisterFormButton.TabIndex = 2;
            this.exitStudentRegisterFormButton.Text = "退出";
            this.exitStudentRegisterFormButton.UseVisualStyleBackColor = true;
            this.exitStudentRegisterFormButton.Click += new System.EventHandler(this.exitStudentRegisterFormButton_Click);
            // 
            // studentinfomanagedatabaseDataSet
            // 
            this.studentinfomanagedatabaseDataSet.DataSetName = "studentinfomanagedatabaseDataSet";
            this.studentinfomanagedatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.专业信息表TableAdapter = null;
            this.tableAdapterManager.学校信息表TableAdapter = null;
            this.tableAdapterManager.学生信息表TableAdapter = null;
            this.tableAdapterManager.班级信息表TableAdapter = null;
            this.tableAdapterManager.账户信息表TableAdapter = this.studentAccountRegisterTableAdapter1;
            // 
            // 学生信息表BindingSource
            // 
            this.学生信息表BindingSource.DataMember = "学生信息表";
            this.学生信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // 学生信息表TableAdapter
            // 
            this.学生信息表TableAdapter.ClearBeforeFill = true;
            // 
            // StudentRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(724, 497);
            this.Controls.Add(this.exitStudentRegisterFormButton);
            this.Controls.Add(this.commitbutton);
            this.Controls.Add(this.passwordConfirmLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Controls.Add(this.passwordConfirmTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "StudentRegisterForm";
            this.Text = "学生账号注册";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生信息表BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private studentinfomanagedatabaseDataSetTableAdapters.账户信息表TableAdapter studentAccountRegisterTableAdapter1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordConfirmTextBox;
        private System.Windows.Forms.Label passwordConfirmLabel;
        private System.Windows.Forms.Button commitbutton;
        private System.Windows.Forms.Button exitStudentRegisterFormButton;
        private studentinfomanagedatabaseDataSet studentinfomanagedatabaseDataSet;
        private studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource 学生信息表BindingSource;
        private studentinfomanagedatabaseDataSetTableAdapters.学生信息表TableAdapter 学生信息表TableAdapter;
    }
}