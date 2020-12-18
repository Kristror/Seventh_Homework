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
