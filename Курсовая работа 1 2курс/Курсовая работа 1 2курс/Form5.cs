using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовая_работа_1_2курс
{
    public partial class Form5 : System.Windows.Forms.Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f1 = new Form1(); //создаём объект формыЗ
            f1.Show(); //показываем форму3
            this.Hide(); //скрываем текущую форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double velocity))
            {
                const double MASS_ELECTRON = 9.1e-31; // масса электрона, кг
                double wavelength = 6.626e-34 / (MASS_ELECTRON * velocity);

                textBox3.Text = $"6,626 × 10⁻³⁴";
                textBox4.Text = $"9,1 × {Math.Pow(10, -31)} × {velocity}";
                textBox2.Text = $"{wavelength * 1e9:F3}";
                textBox5.Text = $"{wavelength * 1e9:F3}";
            }
            else
            {
                MessageBox.Show("Введите корректную скорость!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
