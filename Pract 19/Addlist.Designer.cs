namespace Pract_19
{
    partial class Addlist
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
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label городLabel;
            System.Windows.Forms.Label фамилия_тренераLabel;
            System.Windows.Forms.Label оценка_за_квикстепLabel;
            System.Windows.Forms.Label оценка_за_медленный_вальсLabel;
            System.Windows.Forms.Label оценка_за_тангоLabel;
            System.Windows.Forms.Label оценка_за__медленный_фокстротLabel;
            System.Windows.Forms.Label оценка_за__венский_вальсLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addlist));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.фамилия_тренераTextBox = new System.Windows.Forms.TextBox();
            this.конкурсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dancecompetitionDataSet = new Pract_19.DancecompetitionDataSet();
            this.городTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.кодTextBox = new System.Windows.Forms.TextBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.оценка_за__венский_вальсTextBox = new System.Windows.Forms.TextBox();
            this.оценка_за__медленный_фокстротTextBox = new System.Windows.Forms.TextBox();
            this.оценка_за_тангоTextBox = new System.Windows.Forms.TextBox();
            this.оценка_за_медленный_вальсTextBox = new System.Windows.Forms.TextBox();
            this.оценка_за_квикстепTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            кодLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            фамилия_тренераLabel = new System.Windows.Forms.Label();
            оценка_за_квикстепLabel = new System.Windows.Forms.Label();
            оценка_за_медленный_вальсLabel = new System.Windows.Forms.Label();
            оценка_за_тангоLabel = new System.Windows.Forms.Label();
            оценка_за__медленный_фокстротLabel = new System.Windows.Forms.Label();
            оценка_за__венский_вальсLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dancecompetitionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсBindingNavigator)).BeginInit();
            this.конкурсBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Location = new System.Drawing.Point(23, 39);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(29, 13);
            кодLabel.TabIndex = 0;
            кодLabel.Text = "Код:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(19, 76);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 2;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(19, 105);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 4;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(19, 136);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 6;
            отчествоLabel.Text = "Отчество:";
            // 
            // городLabel
            // 
            городLabel.AutoSize = true;
            городLabel.Location = new System.Drawing.Point(19, 168);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(40, 13);
            городLabel.TabIndex = 8;
            городLabel.Text = "Город:";
            // 
            // фамилия_тренераLabel
            // 
            фамилия_тренераLabel.AutoSize = true;
            фамилия_тренераLabel.Location = new System.Drawing.Point(19, 202);
            фамилия_тренераLabel.Name = "фамилия_тренераLabel";
            фамилия_тренераLabel.Size = new System.Drawing.Size(103, 13);
            фамилия_тренераLabel.TabIndex = 10;
            фамилия_тренераLabel.Text = "Фамилия тренера:";
            // 
            // оценка_за_квикстепLabel
            // 
            оценка_за_квикстепLabel.AutoSize = true;
            оценка_за_квикстепLabel.Location = new System.Drawing.Point(17, 35);
            оценка_за_квикстепLabel.Name = "оценка_за_квикстепLabel";
            оценка_за_квикстепLabel.Size = new System.Drawing.Size(113, 13);
            оценка_за_квикстепLabel.TabIndex = 0;
            оценка_за_квикстепLabel.Text = "Оценка за квикстеп:";
            // 
            // оценка_за_медленный_вальсLabel
            // 
            оценка_за_медленный_вальсLabel.AutoSize = true;
            оценка_за_медленный_вальсLabel.Location = new System.Drawing.Point(17, 73);
            оценка_за_медленный_вальсLabel.Name = "оценка_за_медленный_вальсLabel";
            оценка_за_медленный_вальсLabel.Size = new System.Drawing.Size(157, 13);
            оценка_за_медленный_вальсLabel.TabIndex = 2;
            оценка_за_медленный_вальсLabel.Text = "Оценка за медленный вальс:";
            // 
            // оценка_за_тангоLabel
            // 
            оценка_за_тангоLabel.AutoSize = true;
            оценка_за_тангоLabel.Location = new System.Drawing.Point(17, 115);
            оценка_за_тангоLabel.Name = "оценка_за_тангоLabel";
            оценка_за_тангоLabel.Size = new System.Drawing.Size(94, 13);
            оценка_за_тангоLabel.TabIndex = 4;
            оценка_за_тангоLabel.Text = "Оценка за танго:";
            // 
            // оценка_за__медленный_фокстротLabel
            // 
            оценка_за__медленный_фокстротLabel.AutoSize = true;
            оценка_за__медленный_фокстротLabel.Location = new System.Drawing.Point(17, 161);
            оценка_за__медленный_фокстротLabel.Name = "оценка_за__медленный_фокстротLabel";
            оценка_за__медленный_фокстротLabel.Size = new System.Drawing.Size(178, 13);
            оценка_за__медленный_фокстротLabel.TabIndex = 6;
            оценка_за__медленный_фокстротLabel.Text = "Оценка за  медленный фокстрот:";
            // 
            // оценка_за__венский_вальсLabel
            // 
            оценка_за__венский_вальсLabel.AutoSize = true;
            оценка_за__венский_вальсLabel.Location = new System.Drawing.Point(17, 205);
            оценка_за__венский_вальсLabel.Name = "оценка_за__венский_вальсLabel";
            оценка_за__венский_вальсLabel.Size = new System.Drawing.Size(144, 13);
            оценка_за__венский_вальсLabel.TabIndex = 8;
            оценка_за__венский_вальсLabel.Text = "Оценка за  венский вальс:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(фамилия_тренераLabel);
            this.groupBox1.Controls.Add(this.фамилия_тренераTextBox);
            this.groupBox1.Controls.Add(городLabel);
            this.groupBox1.Controls.Add(this.городTextBox);
            this.groupBox1.Controls.Add(отчествоLabel);
            this.groupBox1.Controls.Add(this.отчествоTextBox);
            this.groupBox1.Controls.Add(имяLabel);
            this.groupBox1.Controls.Add(this.имяTextBox);
            this.groupBox1.Controls.Add(фамилияLabel);
            this.groupBox1.Controls.Add(this.фамилияTextBox);
            this.groupBox1.Controls.Add(кодLabel);
            this.groupBox1.Controls.Add(this.кодTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Карточка танцора ";
            // 
            // фамилия_тренераTextBox
            // 
            this.фамилия_тренераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Фамилия тренера", true));
            this.фамилия_тренераTextBox.Location = new System.Drawing.Point(139, 202);
            this.фамилия_тренераTextBox.Name = "фамилия_тренераTextBox";
            this.фамилия_тренераTextBox.Size = new System.Drawing.Size(129, 20);
            this.фамилия_тренераTextBox.TabIndex = 11;
            // 
            // конкурсBindingSource
            // 
            this.конкурсBindingSource.DataMember = "Конкурс";
            this.конкурсBindingSource.DataSource = this.dancecompetitionDataSet;
            // 
            // dancecompetitionDataSet
            // 
            this.dancecompetitionDataSet.DataSetName = "DancecompetitionDataSet";
            this.dancecompetitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // городTextBox
            // 
            this.городTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Город", true));
            this.городTextBox.Location = new System.Drawing.Point(139, 161);
            this.городTextBox.Name = "городTextBox";
            this.городTextBox.Size = new System.Drawing.Size(129, 20);
            this.городTextBox.TabIndex = 9;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(139, 129);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(129, 20);
            this.отчествоTextBox.TabIndex = 7;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(139, 98);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(129, 20);
            this.имяTextBox.TabIndex = 5;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(139, 69);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(129, 20);
            this.фамилияTextBox.TabIndex = 3;
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Код", true));
            this.кодTextBox.Location = new System.Drawing.Point(139, 32);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(129, 20);
            this.кодTextBox.TabIndex = 1;
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
            this.конкурсBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.конкурсBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.конкурсBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.конкурсBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.конкурсBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.конкурсBindingNavigator.Name = "конкурсBindingNavigator";
            this.конкурсBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.конкурсBindingNavigator.Size = new System.Drawing.Size(597, 25);
            this.конкурсBindingNavigator.TabIndex = 1;
            this.конкурсBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // конкурсBindingNavigatorSaveItem
            // 
            this.конкурсBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.конкурсBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("конкурсBindingNavigatorSaveItem.Image")));
            this.конкурсBindingNavigatorSaveItem.Name = "конкурсBindingNavigatorSaveItem";
            this.конкурсBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.конкурсBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.конкурсBindingNavigatorSaveItem.Click += new System.EventHandler(this.конкурсBindingNavigatorSaveItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(оценка_за__венский_вальсLabel);
            this.groupBox2.Controls.Add(this.оценка_за__венский_вальсTextBox);
            this.groupBox2.Controls.Add(оценка_за__медленный_фокстротLabel);
            this.groupBox2.Controls.Add(this.оценка_за__медленный_фокстротTextBox);
            this.groupBox2.Controls.Add(оценка_за_тангоLabel);
            this.groupBox2.Controls.Add(this.оценка_за_тангоTextBox);
            this.groupBox2.Controls.Add(оценка_за_медленный_вальсLabel);
            this.groupBox2.Controls.Add(this.оценка_за_медленный_вальсTextBox);
            this.groupBox2.Controls.Add(оценка_за_квикстепLabel);
            this.groupBox2.Controls.Add(this.оценка_за_квикстепTextBox);
            this.groupBox2.Location = new System.Drawing.Point(280, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оценки за этапы";
            // 
            // оценка_за__венский_вальсTextBox
            // 
            this.оценка_за__венский_вальсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Оценка за  венский вальс", true));
            this.оценка_за__венский_вальсTextBox.Location = new System.Drawing.Point(209, 205);
            this.оценка_за__венский_вальсTextBox.Name = "оценка_за__венский_вальсTextBox";
            this.оценка_за__венский_вальсTextBox.Size = new System.Drawing.Size(100, 20);
            this.оценка_за__венский_вальсTextBox.TabIndex = 9;
            // 
            // оценка_за__медленный_фокстротTextBox
            // 
            this.оценка_за__медленный_фокстротTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Оценка за  медленный фокстрот", true));
            this.оценка_за__медленный_фокстротTextBox.Location = new System.Drawing.Point(209, 161);
            this.оценка_за__медленный_фокстротTextBox.Name = "оценка_за__медленный_фокстротTextBox";
            this.оценка_за__медленный_фокстротTextBox.Size = new System.Drawing.Size(100, 20);
            this.оценка_за__медленный_фокстротTextBox.TabIndex = 7;
            // 
            // оценка_за_тангоTextBox
            // 
            this.оценка_за_тангоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Оценка за танго", true));
            this.оценка_за_тангоTextBox.Location = new System.Drawing.Point(209, 115);
            this.оценка_за_тангоTextBox.Name = "оценка_за_тангоTextBox";
            this.оценка_за_тангоTextBox.Size = new System.Drawing.Size(100, 20);
            this.оценка_за_тангоTextBox.TabIndex = 5;
            // 
            // оценка_за_медленный_вальсTextBox
            // 
            this.оценка_за_медленный_вальсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Оценка за медленный вальс", true));
            this.оценка_за_медленный_вальсTextBox.Location = new System.Drawing.Point(209, 73);
            this.оценка_за_медленный_вальсTextBox.Name = "оценка_за_медленный_вальсTextBox";
            this.оценка_за_медленный_вальсTextBox.Size = new System.Drawing.Size(100, 20);
            this.оценка_за_медленный_вальсTextBox.TabIndex = 3;
            // 
            // оценка_за_квикстепTextBox
            // 
            this.оценка_за_квикстепTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.конкурсBindingSource, "Оценка за квикстеп", true));
            this.оценка_за_квикстепTextBox.Location = new System.Drawing.Point(209, 35);
            this.оценка_за_квикстепTextBox.Name = "оценка_за_квикстепTextBox";
            this.оценка_за_квикстепTextBox.Size = new System.Drawing.Size(100, 20);
            this.оценка_за_квикстепTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(577, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Addlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 310);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.конкурсBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Addlist";
            this.ShowIcon = false;
            this.Text = "Добавить запрос";
            this.Load += new System.EventHandler(this.Addlist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dancecompetitionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсBindingNavigator)).EndInit();
            this.конкурсBindingNavigator.ResumeLayout(false);
            this.конкурсBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TextBox фамилия_тренераTextBox;
        private System.Windows.Forms.TextBox городTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox оценка_за__венский_вальсTextBox;
        private System.Windows.Forms.TextBox оценка_за__медленный_фокстротTextBox;
        private System.Windows.Forms.TextBox оценка_за_тангоTextBox;
        private System.Windows.Forms.TextBox оценка_за_медленный_вальсTextBox;
        private System.Windows.Forms.TextBox оценка_за_квикстепTextBox;
        private System.Windows.Forms.Button button1;
    }
}