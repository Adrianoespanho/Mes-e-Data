using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mes_e_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void AdicionarData_Click(object sender, EventArgs e)
        {
            textBoxDataInicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBoxDataFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBoxDataAtual.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDataInicial.Clear();
            textBoxDataFinal.Clear();   
            textBoxDataAtual.Clear();
        }
    }
}
