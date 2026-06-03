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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void Перейти_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)   {
                System.Windows.Forms.Form f2 = new Form(); //создание нового объекта
                                                    f2.Show(); //показываем форму2
                                                    this.Hide(); //скрываем текущую форму
                                                }
            else if (radioButton2.Checked == true)  {
                System.Windows.Forms.Form f3 = new Form3(); //создание нового объекта
                                                        f3.Show(); //показываем форму3
                                                        this.Hide(); //скрываем текущую форму
                                                    }
            else if (radioButton3.Checked == true)  {
                System.Windows.Forms.Form f4 = new Form4(); //создание нового объекта
                                                        f4.Show(); //показываем форму4
                                                        this.Hide(); //скрываем текущую форму
                                                    }
            else if (radioButton4.Checked == true)  {
                System.Windows.Forms.Form f5 = new Form5(); //создание нового объекта
                                                        f5.Show(); //показываем форму5
                                                        this.Hide(); //скрываем текущую форму
                                                    }
            else if (radioButton5.Checked == true)
                                                    {
                System.Windows.Forms.Form f6 = new Form6(); //создание нового объекта
                                                        f6.Show(); //показываем форму6
                                                        this.Hide(); //скрываем текущую форму
                                                    }
            else if (radioButton6.Checked == true)
                                                    {
                System.Windows.Forms.Form f7 = new Form7(); //создание нового объекта
                                                        f7.Show(); //показываем форму7
                                                        this.Hide(); //скрываем текущую форму
                                                    }
        }
    }
}
