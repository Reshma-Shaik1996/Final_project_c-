using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semester2_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Money_Exchange object1 = new Money_Exchange();
            object1.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TemperatureConvert object1 = new TemperatureConvert();
            object1.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            Calculator object1 = new Calculator();
            object1.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LottoMax object1 = new LottoMax();
            object1.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            IP_Validator object1 = new IP_Validator();
            object1.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Lotto649 object1 = new Lotto649();
            object1.ShowDialog();
        }
    }
}
