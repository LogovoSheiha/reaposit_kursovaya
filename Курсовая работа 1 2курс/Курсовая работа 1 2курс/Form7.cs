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
    public partial class Form7 : System.Windows.Forms.Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f1 = new Form1(); //создаём объект формыЗ
            f1.Show(); //показываем форму3
            this.Hide(); //скрываем текущую форму
        }
    }
}
