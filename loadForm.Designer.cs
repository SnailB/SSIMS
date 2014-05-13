namespace 学籍管理系统
{
    partial class loadForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadForm));
            this.label1 = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.regesitButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.errorInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.账户信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentinfomanagedatabaseDataSet = new 学籍管理系统.studentinfomanagedatabaseDataSet();
            this.errorInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.账户信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(175, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎登陆学籍管理系统";
            // 
            // accountName
            // 
            this.errorInfo.SetIconPadding(this.accountName, 10);
            this.accountName.Location = new System.Drawing.Point(290, 176);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(170, 21);
            this.accountName.TabIndex = 1;
            this.accountName.Text = "请输入您的账号";
            // 
            // passwd
            // 
            this.errorInfo.SetIconPadding(this.passwd, 10);
            this.passwd.Location = new System.Drawing.Point(290, 218);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(170, 21);
            this.passwd.TabIndex = 2;
            this.passwd.Text = "请输入密码";
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loadButton.Location = new System.Drawing.Point(290, 252);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "登陆";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // regesitButton
            // 
            this.regesitButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.regesitButton.Location = new System.Drawing.Point(385, 252);
            this.regesitButton.Name = "regesitButton";
            this.regesitButton.Size = new System.Drawing.Size(75, 23);
            this.regesitButton.TabIndex = 4;
            this.regesitButton.Text = "注册";
            this.regesitButton.UseVisualStyleBackColor = true;
            this.regesitButton.Click += new System.EventHandler(this.regesitButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userLabel.Location = new System.Drawing.Point(214, 173);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(70, 24);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "账号:";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.BackColor = System.Drawing.Color.Transparent;
            this.pwdLabel.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdLabel.Location = new System.Drawing.Point(214, 215);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(70, 24);
            this.pwdLabel.TabIndex = 6;
            this.pwdLabel.Text = "密码:";
            // 
            // errorInfo
            // 
            this.errorInfo.ContainerControl = this;
            // 
            // 账户信息表BindingSource
            // 
            this.账户信息表BindingSource.DataMember = "账户信息表";
            this.账户信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // studentinfomanagedatabaseDataSet
            // 
            this.studentinfomanagedatabaseDataSet.DataSetName = "studentinfomanagedatabaseDataSet";
            this.studentinfomanagedatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorInfoLabel
            // 
            this.errorInfoLabel.AutoSize = true;
            this.errorInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.errorInfoLabel.Location = new System.Drawing.Point(290, 252);
            this.errorInfoLabel.Name = "errorInfoLabel";
            this.errorInfoLabel.Size = new System.Drawing.Size(0, 12);
            this.errorInfoLabel.TabIndex = 7;
            // 
            // loadForm
            // 
            this.AcceptButton = this.loadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 454);
            this.Controls.Add(this.errorInfoLabel);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.regesitButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.label1);
            this.Name = "loadForm";
            this.Text = "学籍管理系统";
            this.Load += new System.EventHandler(this.loadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.账户信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button regesitButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.ErrorProvider errorInfo;
        private studentinfomanagedatabaseDataSet studentinfomanagedatabaseDataSet;
        private System.Windows.Forms.BindingSource 账户信息表BindingSource;
        private System.Windows.Forms.Label errorInfoLabel;
        private System.Windows.Forms.TextBox accountName;
        private System.Windows.Forms.TextBox passwd;



    }
}

