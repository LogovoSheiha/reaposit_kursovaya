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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f1 = new Form1(); //создаём объект формыЗ
            f1.Show(); //показываем форму3
            this.Hide(); //скрываем текущую форму
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double H = 6.626e-34;
            // Считываем ввод пользователя
            if (double.TryParse(textBox1.Text, out double wavelengthNm))
            {
                // Переводим нанометры в метры
                double wavelengthM = wavelengthNm * 1e-9;

                // Рассчитываем импульс фотона
                double momentum = H / wavelengthM;

                textBox7.Text = $"{H}";
                textBox2.Text = $"({wavelengthNm}·10⁻⁹)";
                textBox4.Text = $"{momentum}";

                // Формируем строку результата
                string resultText = $"{momentum * 1e27:F3} * 10⁻²⁷";

                textBox5.Text = resultText;
                textBox3.Text = resultText;
            }
            else
            {
                // Обработка ошибки ввода
                MessageBox.Show("Ошибка! Введите корректное число.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Text = "";
                textBox3.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}