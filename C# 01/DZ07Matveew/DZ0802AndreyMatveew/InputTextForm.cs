using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ0802AndreyMatveew
{
    public partial class InputTextForm : Form
    {
        GuessForm guess = new GuessForm();
        public InputTextForm()
        {
            InitializeComponent();
            guess.Show();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InputTextForm_Load(object sender, EventArgs e)
        {

        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            guess.tryLabel.Text = Guess.TryCount--.ToString();
            Guess.UserNumber = Int32.Parse(inputTextBox.Text);

            if (Guess.TryCount == -1)
            {
                MessageBox.Show("Вы проиграли !!!!");
                this.inputButton.Visible = false;
            }

            if (Int32.Parse(inputTextBox.Text) == Guess.GuessNumber)
            {
                this.inputButton.Visible = false;
                guess.helpLabel.Text = "Вы победили !!!!";
            }

            if (Int32.Parse(inputTextBox.Text) < Guess.GuessNumber)
            {
                guess.helpLabel.Text = "Вы ввели слишком маленькое число !!!!";
            }

            if (Int32.Parse(inputTextBox.Text) > Guess.GuessNumber)
            {
                guess.helpLabel.Text = "Вы ввели слишком большое число !!!!";
            }
        }
    }
}
