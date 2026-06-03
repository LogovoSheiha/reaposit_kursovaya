using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа_1_2курс
{
    public partial class Form4 : System.Windows.Forms.Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f1 = new Form1(); //создаём объект формы1
            f1.Show(); //показываем форму1
            this.Hide(); //скрываем текущую форму
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double photonEnergye);
            double.TryParse(textBox2.Text, out double workFunctione);
            textBox3.Text = $"{photonEnergye}";
            textBox4.Text = $"{workFunctione}";
            double maxKineticEnergy = photonEnergye - workFunctione;
            textBox5.Text = $"{maxKineticEnergy}";
            textBox6.Text = $"{maxKineticEnergy}";
        }
    }
}
