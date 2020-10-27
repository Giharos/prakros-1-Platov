using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_1;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // расчет
        private void work_Click(object sender, EventArgs e)
        {
            sum.Clear();
            numbers.Clear();
          
            int k,
                Sum;
            
            if (Int32.TryParse(kolvo.Text, out k)==true)
            {
                // вызов функции
                Sum = Lib_1.RandomAmount.Go(k, numbers);
                sum.Text = Sum.ToString();
            }
           
            else
            {
                kolvo.Clear();
                MessageBox.Show("Введите правильное значение");
            }
        }
        //Сброс
        private void reset_Click(object sender, EventArgs e)
        {
            sum.Clear();
            numbers.Clear();
            kolvo.Clear();
        }
        //Изменение входного текстбокса
        private void sourceK_TextChanged(object sender, EventArgs e)
        {
            sum.Clear();
            numbers.Clear();
            kolvo.Clear();
        }
        //О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 1, 12 вариант\n" +
                "Найти сумму n целых случайных чисел, распределенных в диапазоне от 0 до n. Вывести на экран на одной строке сгенерированные числа, на другой строке результат. \n" +
                "Платов Андрей ИСП-31");
        }
        // выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
