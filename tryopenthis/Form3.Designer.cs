namespace Test
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.xxxDataSet = new Test.xxxDataSet();
            this.ggBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ggTableAdapter = new Test.xxxDataSetTableAdapters.ggTableAdapter();
            this.tableAdapterManager = new Test.xxxDataSetTableAdapters.TableAdapterManager();
            this.ggBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ggBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ggDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактрлеуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мәліметтердіЕнгізуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мәліметтердіӨзгертуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.xxxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ggBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ggBindingNavigator)).BeginInit();
            this.ggBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ggDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xxxDataSet
            // 
            this.xxxDataSet.DataSetName = "xxxDataSet";
            this.xxxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ggBindingSource
            // 
            this.ggBindingSource.DataMember = "gg";
            this.ggBindingSource.DataSource = this.xxxDataSet;
            // 
            // ggTableAdapter
            // 
            this.ggTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ggTableAdapter = this.ggTableAdapter;
            this.tableAdapterManager.UpdateOrder = Test.xxxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ggBindingNavigator
            // 
            this.ggBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ggBindingNavigator.BackColor = System.Drawing.Color.White;
            this.ggBindingNavigator.BindingSource = this.ggBindingSource;
            this.ggBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ggBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ggBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ggBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ggBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.ggBindingNavigator.Location = new System.Drawing.Point(0, 31);
            this.ggBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ggBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ggBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ggBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ggBindingNavigator.Name = "ggBindingNavigator";
            this.ggBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ggBindingNavigator.Size = new System.Drawing.Size(1426, 31);
            this.ggBindingNavigator.TabIndex = 0;
            this.ggBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // ggBindingNavigatorSaveItem
            // 
            this.ggBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ggBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ggBindingNavigatorSaveItem.Image")));
            this.ggBindingNavigatorSaveItem.Name = "ggBindingNavigatorSaveItem";
            this.ggBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.ggBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ggBindingNavigatorSaveItem.Click += new System.EventHandler(this.ggBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Test.Properties.Resources.png_clipart_scalable_graphics_computer_icons_refresh_icon_cdr_area__1_;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ggDataGridView
            // 
            this.ggDataGridView.AutoGenerateColumns = false;
            this.ggDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ggDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ggDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.ggDataGridView.DataSource = this.ggBindingSource;
            this.ggDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ggDataGridView.Name = "ggDataGridView";
            this.ggDataGridView.RowHeadersWidth = 51;
            this.ggDataGridView.RowTemplate.Height = 24;
            this.ggDataGridView.Size = new System.Drawing.Size(1920, 1080);
            this.ggDataGridView.TabIndex = 1;
            this.ggDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ggDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fio";
            this.dataGridViewTextBoxColumn2.HeaderText = "fio";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn3.HeaderText = "age";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "adress";
            this.dataGridViewTextBoxColumn4.HeaderText = "adress";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tel";
            this.dataGridViewTextBoxColumn5.HeaderText = "tel";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "kafedra";
            this.dataGridViewTextBoxColumn6.HeaderText = "kafedra";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "spec";
            this.dataGridViewTextBoxColumn7.HeaderText = "spec";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ggDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1025);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактрлеуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1426, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // редактрлеуToolStripMenuItem
            // 
            this.редактрлеуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мәліметтердіЕнгізуToolStripMenuItem,
            this.мәліметтердіӨзгертуToolStripMenuItem,
            this.мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem});
            this.редактрлеуToolStripMenuItem.Name = "редактрлеуToolStripMenuItem";
            this.редактрлеуToolStripMenuItem.Size = new System.Drawing.Size(115, 27);
            this.редактрлеуToolStripMenuItem.Text = "Редактрлеу";
            // 
            // мәліметтердіЕнгізуToolStripMenuItem
            // 
            this.мәліметтердіЕнгізуToolStripMenuItem.Name = "мәліметтердіЕнгізуToolStripMenuItem";
            this.мәліметтердіЕнгізуToolStripMenuItem.Size = new System.Drawing.Size(345, 28);
            this.мәліметтердіЕнгізуToolStripMenuItem.Text = "Мәліметтерді енгізу";
            this.мәліметтердіЕнгізуToolStripMenuItem.Click += new System.EventHandler(this.мәліметтердіЕнгізуToolStripMenuItem_Click);
            // 
            // мәліметтердіӨзгертуToolStripMenuItem
            // 
            this.мәліметтердіӨзгертуToolStripMenuItem.Name = "мәліметтердіӨзгертуToolStripMenuItem";
            this.мәліметтердіӨзгертуToolStripMenuItem.Size = new System.Drawing.Size(345, 28);
            this.мәліметтердіӨзгертуToolStripMenuItem.Text = "Мәліметтерді өзгерту";
            this.мәліметтердіӨзгертуToolStripMenuItem.Click += new System.EventHandler(this.мәліметтердіӨзгертуToolStripMenuItem_Click);
            // 
            // мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem
            // 
            this.мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem.Name = "мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem";
            this.мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem.Size = new System.Drawing.Size(345, 28);
            this.мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem.Text = "Мәліметтерді іздеу және өшіру";
            this.мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem.Click += new System.EventHandler(this.мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 693);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ggBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Студенттер МҚ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xxxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ggBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ggBindingNavigator)).EndInit();
            this.ggBindingNavigator.ResumeLayout(false);
            this.ggBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ggDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private xxxDataSet xxxDataSet;
        private System.Windows.Forms.BindingSource ggBindingSource;
        private xxxDataSetTableAdapters.ggTableAdapter ggTableAdapter;
        private xxxDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ggBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ggBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ggDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактрлеуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мәліметтердіЕнгізуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мәліметтердіӨзгертуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}