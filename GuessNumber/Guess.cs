using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    class Guess
    {
        public int number;
        public Random rnd = new Random();

        public Guess()
        {
            this.number = rnd.Next(0,100);
        }
        public void Next()
        {
            this.number = rnd.Next(0, 100);
        }
        public string Try(string text)
        {
            int guessNum = 0;
            int.TryParse(text, out guessNum);
            if (guessNum != 0)
            {
                if (guessNum == number) 
                {
                    var res = MessageBox.Show(@"Вы угадали!
Хотите начать заново?", "Поздравляем", MessageBoxButtons.YesNo);
                    if (res == DialogResult.OK)
                    {
                        return "Введите своё предположение";
                    }
                    else Form1.ActiveForm.Close();
                    return "";
                }
                else if (guessNum > number) return "Ваше число больше";
                else return "Ваше число меньше";
            }
            else return "Вы ввели не подходящее значение";
        }
    }
}
