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
    public partial class Search : Form
    {
        public int index;
        public Search()
        {
            InitializeComponent();
        }

        private void КонкурсBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.конкурсBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dancecompetitionDataSet);

        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dancecompetitionDataSet.Конкурс". При необходимости она может быть перемещена или удалена.
            this.конкурсTableAdapter.Fill(this.dancecompetitionDataSet.Конкурс);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string NameFileld;
            NameFileld = "Фамилия";
            index = конкурсBindingSource.Find(NameFileld, textBox1.Text);
            if (index > -1)
            {
                конкурсBindingSource.Position = index;
                Close();
            }
            else MessageBox.Show("Поиск завершен. Образец не найден.");
        }
    }
}
