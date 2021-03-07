namespace Pract_19
{
    partial class Search
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
            this.dancecompetitionDataSet = new Pract_19.DancecompetitionDataSet();
            this.конкурсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.конкурсTableAdapter = new Pract_19.DancecompetitionDataSetTableAdapters.КонкурсTableAdapter();
            this.tableAdapterManager = new Pract_19.DancecompetitionDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dancecompetitionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсBindingSource)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск по фамилии";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.ShowIcon = false;
            this.Text = "Поиск запроса";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dancecompetitionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.конкурсBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DancecompetitionDataSet dancecompetitionDataSet;
        private System.Windows.Forms.BindingSource конкурсBindingSource;
        private DancecompetitionDataSetTableAdapters.КонкурсTableAdapter конкурсTableAdapter;
        private DancecompetitionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}