using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Form1 : Form
    {
        /// Домашняя работа Безукладникова Даниила
        /// а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
        /// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
        /// Игрок должен постараться получить это число за минимальное количество ходов.
        /// в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
        /// 

        NumWork num = new NumWork();
        public Form1()
        {
            InitializeComponent();
            numberLablel.Text = "1";
            number2Label.Text = "0";
        }

        private void Add1Button_Click(object sender, EventArgs e)
        {            
            numberLablel.Text = num.Add1(numberLablel.Text);
        }

        private void DoublerButton_Click(object sender, EventArgs e)
        {            
            numberLablel.Text = num.Mult2(numberLablel.Text);
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            numberLablel.Text = num.Undo();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            numberLablel.Text = "1";
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {                        
            number2Label.Text = num.Next();
        }
    }
}
