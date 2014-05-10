namespace 学籍管理系统
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.studentinfomanagedatabaseDataSet = new 学籍管理系统.studentinfomanagedatabaseDataSet();
            this.专业信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.专业信息表TableAdapter = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.专业信息表TableAdapter();
            this.tableAdapterManager = new 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager();
            this.专业信息表BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.专业信息表BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.专业信息表DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表BindingNavigator)).BeginInit();
            this.专业信息表BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentinfomanagedatabaseDataSet
            // 
            this.studentinfomanagedatabaseDataSet.DataSetName = "studentinfomanagedatabaseDataSet";
            this.studentinfomanagedatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 专业信息表BindingSource
            // 
            this.专业信息表BindingSource.DataMember = "专业信息表";
            this.专业信息表BindingSource.DataSource = this.studentinfomanagedatabaseDataSet;
            // 
            // 专业信息表TableAdapter
            // 
            this.专业信息表TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = 学籍管理系统.studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.专业信息表TableAdapter = this.专业信息表TableAdapter;
            this.tableAdapterManager.学校信息表TableAdapter = null;
            this.tableAdapterManager.学生信息表TableAdapter = null;
            this.tableAdapterManager.班级信息表TableAdapter = null;
            this.tableAdapterManager.账户信息表TableAdapter = null;
            // 
            // 专业信息表BindingNavigator
            // 
            this.专业信息表BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.专业信息表BindingNavigator.BindingSource = this.专业信息表BindingSource;
            this.专业信息表BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.专业信息表BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.专业信息表BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.专业信息表BindingNavigatorSaveItem});
            this.专业信息表BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.专业信息表BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.专业信息表BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.专业信息表BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.专业信息表BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.专业信息表BindingNavigator.Name = "专业信息表BindingNavigator";
            this.专业信息表BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.专业信息表BindingNavigator.Size = new System.Drawing.Size(646, 25);
            this.专业信息表BindingNavigator.TabIndex = 0;
            this.专业信息表BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 17);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // 专业信息表BindingNavigatorSaveItem
            // 
            this.专业信息表BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.专业信息表BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("专业信息表BindingNavigatorSaveItem.Image")));
            this.专业信息表BindingNavigatorSaveItem.Name = "专业信息表BindingNavigatorSaveItem";
            this.专业信息表BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.专业信息表BindingNavigatorSaveItem.Text = "保存数据";
            this.专业信息表BindingNavigatorSaveItem.Click += new System.EventHandler(this.专业信息表BindingNavigatorSaveItem_Click);
            // 
            // 专业信息表DataGridView
            // 
            this.专业信息表DataGridView.AutoGenerateColumns = false;
            this.专业信息表DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.专业信息表DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.专业信息表DataGridView.DataSource = this.专业信息表BindingSource;
            this.专业信息表DataGridView.Location = new System.Drawing.Point(0, 28);
            this.专业信息表DataGridView.Name = "专业信息表DataGridView";
            this.专业信息表DataGridView.RowTemplate.Height = 23;
            this.专业信息表DataGridView.Size = new System.Drawing.Size(646, 482);
            this.专业信息表DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "专业代码";
            this.dataGridViewTextBoxColumn1.HeaderText = "专业代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "专业名";
            this.dataGridViewTextBoxColumn2.HeaderText = "专业名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "院系编号";
            this.dataGridViewTextBoxColumn3.HeaderText = "院系编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "班级数目";
            this.dataGridViewTextBoxColumn4.HeaderText = "班级数目";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 509);
            this.Controls.Add(this.专业信息表DataGridView);
            this.Controls.Add(this.专业信息表BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentinfomanagedatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表BindingNavigator)).EndInit();
            this.专业信息表BindingNavigator.ResumeLayout(false);
            this.专业信息表BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private studentinfomanagedatabaseDataSet studentinfomanagedatabaseDataSet;
        private System.Windows.Forms.BindingSource 专业信息表BindingSource;
        private studentinfomanagedatabaseDataSetTableAdapters.专业信息表TableAdapter 专业信息表TableAdapter;
        private studentinfomanagedatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 专业信息表BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 专业信息表BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView 专业信息表DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}