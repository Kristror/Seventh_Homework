using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        /// Домашняя работа Безукладникова Даниила
        /// Используя Windows Forms, разработать игру «Угадай число». 
        /// Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
        /// Для ввода данных от человека используется элемент TextBox.
        ///
        Guess gg = new Guess();
        public Form1()
        {
            InitializeComponent();           
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            label.Text = gg.Try(textBox.Text);
        }
    }
}
