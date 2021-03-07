using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract_19
{
    public partial class Addlist : Form
    {
        public Addlist()
        {
            InitializeComponent();
        }

        private void конкурсBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.конкурсBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dancecompetitionDataSet);

        }

        private void Addlist_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dancecompetitionDataSet.Конкурс". При необходимости она может быть перемещена или удалена.
            this.конкурсTableAdapter.Fill(this.dancecompetitionDataSet.Конкурс);

            this.конкурсBindingSource.AddNew();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (фамилияTextBox.Text.Length == 0 || имяTextBox.Text.Length == 0 || отчествоTextBox.Text.Length == 0)
            { MessageBox.Show("Заполните все поля"); return; }
            if (городTextBox.Text.Length == 0) { MessageBox.Show("Заполните название города"); return; }
            if (фамилия_тренераTextBox.Text.Length == 0) { MessageBox.Show("Заполните фамилю тренера"); return; }
            this.Validate();
            this.конкурсBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dancecompetitionDataSet);
            Close();
        }
    }
}