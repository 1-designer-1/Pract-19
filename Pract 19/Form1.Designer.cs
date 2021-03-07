namespace Pract_19
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dancecompetitionDataSet = new Pract_19.DancecompetitionDataSet();
            this.конкурсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.конкурсTableAdapter = new Pract_19.DancecompetitionDataSetTableAdapters.КонкурсTableAdapter();
            this.tableAdapterManager = new Pract_19.DancecompetitionDataSetTableAdapters.TableAdapterManager();
            this.конкурсBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.конкурсBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.конкурсDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗаросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dancecompetitionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсBindingNavigator)).BeginInit();
            this.конкурсBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dancecompetitionDataSet
            // 
            this.dancecompetitionDataSet.DataSetName = "DancecompetitionDataSet";
            this.dancecompetitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // конкурсBindingSource
            // 
            this.конкурсBindingSource.DataMember = "Конкурс";
            this.конкурсBindingSource.DataSource = this.dancecompetitionDataSet;
            // 
            // конкурсTableAdapter
            // 
            this.конкурсTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Pract_19.DancecompetitionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КонкурсTableAdapter = this.конкурсTableAdapter;
            // 
            // конкурсBindingNavigator
            // 
            this.конкурсBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.конкурсBindingNavigator.BindingSource = this.конкурсBindingSource;
            this.конкурсBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.конкурсBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.конкурсBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.конкурсBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.конкурсBindingNavigatorSaveItem});
            this.конкурсBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.конкурсBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.конкурсBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.конкурсBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.конкурсBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.конкурсBindingNavigator.Name = "конкурсBindingNavigator";
            this.конкурсBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.конкурсBindingNavigator.Size = new System.Drawing.Size(928, 27);
            this.конкурсBindingNavigator.TabIndex = 0;
            this.конкурсBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // конкурсBindingNavigatorSaveItem
            // 
            this.конкурсBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.конкурсBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("конкурсBindingNavigatorSaveItem.Image")));
            this.конкурсBindingNavigatorSaveItem.Name = "конкурсBindingNavigatorSaveItem";
            this.конкурсBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.конкурсBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.конкурсBindingNavigatorSaveItem.Click += new System.EventHandler(this.конкурсBindingNavigatorSaveItem_Click);
            // 
            // конкурсDataGridView
            // 
            this.конкурсDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.конкурсDataGridView.AutoGenerateColumns = false;
            this.конкурсDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.конкурсDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.конкурсDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.конкурсDataGridView.DataSource = this.конкурсBindingSource;
            this.конкурсDataGridView.Location = new System.Drawing.Point(16, 64);
            this.конкурсDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.конкурсDataGridView.Name = "конкурсDataGridView";
            this.конкурсDataGridView.ReadOnly = true;
            this.конкурсDataGridView.RowHeadersWidth = 51;
            this.конкурсDataGridView.Size = new System.Drawing.Size(896, 206);
            this.конкурсDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Город";
            this.dataGridViewTextBoxColumn5.HeaderText = "Город";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Фамилия тренера";
            this.dataGridViewTextBoxColumn6.HeaderText = "Фамилия тренера";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Оценка за квикстеп";
            this.dataGridViewTextBoxColumn7.HeaderText = "Оценка за квикстеп";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Оценка за медленный вальс";
            this.dataGridViewTextBoxColumn8.HeaderText = "Оценка за медленный вальс";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Оценка за танго";
            this.dataGridViewTextBoxColumn9.HeaderText = "Оценка за танго";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Оценка за  медленный фокстрот";
            this.dataGridViewTextBoxColumn10.HeaderText = "Оценка за  медленный фокстрот";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Оценка за  венский вальс";
            this.dataGridViewTextBoxColumn11.HeaderText = "Оценка за  венский вальс";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗапросToolStripMenuItem,
            this.поискЗапросToolStripMenuItem,
            this.изменитьЗаросToolStripMenuItem,
            this.удалитьЗапросToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // добавитьЗапросToolStripMenuItem
            // 
            this.добавитьЗапросToolStripMenuItem.Name = "добавитьЗапросToolStripMenuItem";
            this.добавитьЗапросToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.добавитьЗапросToolStripMenuItem.Text = "Добавить запрос";
            this.добавитьЗапросToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьЗапросToolStripMenuItem_Click);
            // 
            // поискЗапросToolStripMenuItem
            // 
            this.поискЗапросToolStripMenuItem.Name = "поискЗапросToolStripMenuItem";
            this.поискЗапросToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.поискЗапросToolStripMenuItem.Text = "Поиск запроса";
            this.поискЗапросToolStripMenuItem.Click += new System.EventHandler(this.ПоискЗапросToolStripMenuItem_Click);
            // 
            // изменитьЗаросToolStripMenuItem
            // 
            this.изменитьЗаросToolStripMenuItem.Name = "изменитьЗаросToolStripMenuItem";
            this.изменитьЗаросToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.изменитьЗаросToolStripMenuItem.Text = "Изменить запрос";
            this.изменитьЗаросToolStripMenuItem.Click += new System.EventHandler(this.изменитьЗаросToolStripMenuItem_Click);
            // 
            // удалитьЗапросToolStripMenuItem
            // 
            this.удалитьЗапросToolStripMenuItem.Name = "удалитьЗапросToolStripMenuItem";
            this.удалитьЗапросToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.удалитьЗапросToolStripMenuItem.Text = "Удалить запрос";
            this.удалитьЗапросToolStripMenuItem.Click += new System.EventHandler(this.УдалитьЗапросToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ДобавитьЗапросToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Поиск запроса";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ПоискЗапросToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "Изменить запрос";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.изменитьЗаросToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(721, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить запрос";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.УдалитьЗапросToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(16, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 106);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.конкурсDataGridView);
            this.Controls.Add(this.конкурсBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Конкурс танцев";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dancecompetitionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсBindingNavigator)).EndInit();
            this.конкурсBindingNavigator.ResumeLayout(false);
            this.конкурсBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DancecompetitionDataSet dancecompetitionDataSet;
        private System.Windows.Forms.BindingSource конкурсBindingSource;
        private DancecompetitionDataSetTableAdapters.КонкурсTableAdapter конкурсTableAdapter;
        private DancecompetitionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator конкурсBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton конкурсBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView конкурсDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗаросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
    }
}

