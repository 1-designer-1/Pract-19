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
    public partial class Change : Form
    {
        public Change()
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

           this.конкурсTableAdapter.FillBy(this.dancecompetitionDataSet.Конкурс, data.kod);
            кодTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][0].ToString();
            фамилияTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][1].ToString();
            имяTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][2].ToString();
            отчествоTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][3].ToString();
            фамилия_тренераTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][4].ToString();
            городTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][5].ToString();
            оценка_за_квикстепTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][6].ToString();
            оценка_за_медленный_вальсTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][7].ToString();
            оценка_за_тангоTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][8].ToString();
            оценка_за__медленный_фокстротTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][9].ToString();
            оценка_за__венский_вальсTextBox.Text = dancecompetitionDataSet.Конкурс.Rows[0][10].ToString();



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (фамилияTextBox.Text == "")
            {
                MessageBox.Show("Введите фамилию", "Ошибка");
                return;
            }
            if (имяTextBox.Text == "")
            {
                MessageBox.Show("Введите имя", "Ошибка");
                return;
            }
            if (отчествоTextBox.Text == "")
            {
                MessageBox.Show("Введите отчество", "Ошибка");
                return;
            }
            if (фамилия_тренераTextBox.Text == "")
            {
                MessageBox.Show("Введите фаимилию тренера", "Ошибка");
                return;
            }
            if (городTextBox.Text == "")
            {
                MessageBox.Show("Введите город", "Ошибка");
                return;
            }
            if (оценка_за_квикстепTextBox.Text == "")
            {
                MessageBox.Show("Введите значение", "Ошибка");
                return;
            }
            if (оценка_за_медленный_вальсTextBox.Text == "")
            {
                MessageBox.Show("Введите значение", "Ошибка");
                return;
            }
            if (оценка_за_тангоTextBox.Text == "")
            {
                MessageBox.Show("Введите значение", "Ошибка");
                return;
            }
            if (оценка_за__медленный_фокстротTextBox.Text == "")
            {
                MessageBox.Show("Введите значение", "Ошибка");
                return;
            }
            if (оценка_за__венский_вальсTextBox.Text == "")
            {
                MessageBox.Show("Введите значение", "Ошибка");
                return;
            }

            try
            {
                decimal? denc1 = Convert.ToDecimal(оценка_за_квикстепTextBox.Text);
                decimal? denc2 = Convert.ToDecimal(оценка_за_медленный_вальсTextBox.Text);
                decimal? denc3 = Convert.ToDecimal(оценка_за_тангоTextBox.Text);
                decimal? denc4 = Convert.ToDecimal(оценка_за__медленный_фокстротTextBox.Text);
                decimal? denc5 = Convert.ToDecimal(оценка_за__венский_вальсTextBox.Text);
                //конкурсTableAdapter.UpdateRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            this.Validate();
            this.конкурсBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dancecompetitionDataSet);
            Close();
        }
    }
}