using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace semester2_Final_Project
{
    public partial class IP_Validator : Form
    {
        public IP_Validator()
        {
            InitializeComponent();
        }


        private void IP_Validator_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void Btn_validate_Click(object sender, EventArgs e)
        {

            try
            {
                Regex isValid = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");
                if (isValid.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("test");
                }
                else
                {
                    MessageBox.Show("wrong");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid input");
            }
            
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
