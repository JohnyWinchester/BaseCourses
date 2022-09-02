using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ0801MatveewAndrey
{
    public partial class DoublerForm : Form
    {
        private int AmountCommands = 1;
        private Stack<int> cancel = new Stack<int>();
        public DoublerForm()
        {
            InitializeComponent();
            Random rnd = new Random();
            HiddenNumber.Text = rnd.Next(1, 100).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            AmountCommandsOutput.Text = AmountCommands++.ToString();
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            cancel.Push(int.Parse(lblNumber.Text));
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            AmountCommandsOutput.Text = AmountCommands++.ToString();
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            cancel.Push(int.Parse(lblNumber.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            AmountCommandsOutput.Text = AmountCommands++.ToString();
            lblNumber.Text = "1";
            cancel.Push(int.Parse(lblNumber.Text));
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void AmountCommandsOutput_Click(object sender, EventArgs e)
        {

        }

        private void HiddenNumber_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (cancel.Count != 0) 
            {
                cancel.Pop();
                lblNumber.Text = cancel.First().ToString();
            }
            else MessageBox.Show("Количество ходов равно 0.Сделайте хотя бы один ход !!!!");
        }
    }
}
