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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void конкурсBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.конкурсBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dancecompetitionDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dancecompetitionDataSet.Конкурс". При необходимости она может быть перемещена или удалена.
            this.конкурсTableAdapter.Fill(this.dancecompetitionDataSet.Конкурс);

        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 19 \n" +
                "Выполнил: Серегин Денис \n" +
                "Задание: \n" +
                "Сведения об участниках конкурса бальных танцев. База данных должна содержать следующую информацию:" +
                "фамилию, имя, отчество участника, город, фамилию тренера, оценки за каждый танец.",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ДобавитьЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addlist addlist = new Addlist();
            addlist.ShowDialog();
            int row, col;
            row = конкурсDataGridView.CurrentCell.RowIndex;
            col = конкурсDataGridView.CurrentCell.ColumnIndex;
            this.конкурсTableAdapter.Fill(this.dancecompetitionDataSet.Конкурс);
            конкурсDataGridView.CurrentCell = конкурсDataGridView[col, row];

        }

        private void УдалитьЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Подтвердите удаление записи", "Удаление записи", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                конкурсBindingSource.RemoveCurrent();
                конкурсTableAdapter.Update(this.dancecompetitionDataSet.Конкурс);
            }
        }

        private void ПоискЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            конкурсDataGridView.Rows[search.index].Selected = true;

        }

        private void изменитьЗаросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.kod = Convert.ToInt32(конкурсDataGridView[0, конкурсDataGridView.CurrentCell.RowIndex].Value);
            Change change = new Change();
            change.ShowDialog();
            int row, col;
            row = конкурсDataGridView.CurrentCell.RowIndex;
            col = конкурсDataGridView.CurrentCell.ColumnIndex;
            this.конкурсTableAdapter.Fill(this.dancecompetitionDataSet.Конкурс);
            конкурсDataGridView.CurrentCell = конкурсDataGridView[col, row];
           

        }
    }
}
