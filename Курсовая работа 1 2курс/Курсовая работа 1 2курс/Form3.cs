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
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f1 = new Form1(); //создаём объект формыЗ
            f1.Show(); //показываем форму3
            this.Hide(); //скрываем текущую форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double n);
            double ratio = -13.6;
            textBox3.Text = $"{ratio / (n * n)}";
            textBox4.Text = $"{ratio / (n * n)}";
            textBox5.Text = $"{ratio / (n * n)}";
            textBox2.Text = $"{n}^2"; 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
