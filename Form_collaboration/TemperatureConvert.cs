using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace semester2_Final_Project
{
    public partial class TemperatureConvert : Form
    {


        public TemperatureConvert()
        {
            InitializeComponent();
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"..\..\Folder\") == false)
            {
                Directory.CreateDirectory(@"..\..\Folder\");
            }
            FileStream fs = new FileStream(@"..\..\Folder\TemperatureConvert.txt", FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);


            double from = 0;
            double to = 0;
            bool flag = false;

            if (radio_CtoF.Checked)
            {
                try
                {
                    from = Convert.ToDouble(txt_From.Text);
                    flag = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid input");
                    flag = false;
                    textOut.Close();
                }

                if (flag == true)
                {
                    to = ((from * 9 / 5) + 32);
                    to = Math.Round(to, 1);
                    txt_To.Text = Convert.ToString(to);

                    if (from >= 100)
                    {
                        txtbox_Message.Text = "Water boils";
                    }
                    else if (from >= 40 && from <= 99)
                    {
                        txtbox_Message.Text = "Hot Bath";
                    }
                    else if (from >= 37 && from <= 39)
                    {
                        txtbox_Message.Text = "Body temperature";
                    }
                    else if (from >= 30 && from <= 38)
                    {
                        txtbox_Message.Text = "Beach weather";
                    }
                    else if (from >= 21 && from <= 29)
                    {
                        txtbox_Message.Text = "Room temperature";
                    }
                    else if (from >= 10 && from <= 20)
                    {
                        txtbox_Message.Text = "Cool Day";
                    }
                    else if (from == 0)
                    {
                        txtbox_Message.Text = "Freezing point of water";
                    }
                    else if (from <= -1 && from >= -18)
                    {
                        txtbox_Message.Text = "Very Cold Day";
                    }
                    else if (from <= -19 && from >= -39)
                    {
                        txtbox_Message.Text = "Extreme cold";
                    }
                    else if (from <= -40)
                    {
                        txtbox_Message.Text = "Extremely Cold Day (and the same number!)";
                    }

                    textOut.WriteLine(txt_From.Text + lbl_From.Text + " " + "=" + " " + txt_To.Text + lbl_To.Text + " " + txtbox_Message.Text);
                    textOut.Close();
                }


            }
            if (radio_FtoC.Checked)
            {

                try
                {
                    from = Convert.ToDouble(txt_From.Text);
                    flag = true;
                }
                catch(Exception)
                {
                    MessageBox.Show("Please enter a valid input");
                    flag = false;
                    textOut.Close();
                }

                if(flag == true)
                {
                    to = Convert.ToDouble((from - 32) * 5 / 9);
                    to = Math.Round(to, 1);
                    txt_To.Text = Convert.ToString(to);

                    if (from >= 212)
                    {
                        txtbox_Message.Text = "Water boils";
                    }
                    else if (from >= 104 && from <= 211)
                    {
                        txtbox_Message.Text = "Hot Bath";
                    }
                    else if (from >= 98.6 && from <= 103)
                    {
                        txtbox_Message.Text = "Body temperature";
                    }
                    else if (from >= 86 && from <= 98.5)
                    {
                        txtbox_Message.Text = "Beach weather";
                    }
                    else if (from >= 70 && from <= 85)
                    {
                        txtbox_Message.Text = "Room temperature";
                    }
                    else if (from >= 50 && from <= 69)
                    {
                        txtbox_Message.Text = "Cool Day";
                    }
                    else if (from == 32)
                    {
                        txtbox_Message.Text = "Freezing point of water";
                    }
                    else if (from >= 0 && from <= 31)
                    {
                        txtbox_Message.Text = "Very Cold Day";
                    }
                    else if (from <= -1 && from >= -39)
                    {
                        txtbox_Message.Text = "Extreme cold";
                    }
                    else if (from <= -40)
                    {
                        txtbox_Message.Text = "Extremely Cold Day (and the same number!)";
                    }

                    textOut.WriteLine(txt_From.Text + lbl_From.Text + " " + "=" + " " + txt_To.Text + lbl_To.Text + " " + txtbox_Message.Text);
                    textOut.Close();
                }
             
            }
        }

        private void Radio_FtoC_CheckedChanged(object sender, EventArgs e)
        {
            lbl_From.Text = "F";
            lbl_To.Text = "C";
        }

        private void Radio_CtoF_CheckedChanged(object sender, EventArgs e)
        {
            lbl_From.Text = "C";
            lbl_To.Text = "F";
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Read_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"..\..\Folder\") == false)
            {
                Directory.CreateDirectory(@"..\..\Folder\");
            }
            FileStream fs = new FileStream(@"..\..\Folder\TemperatureConvert.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(fs);
            string textToPrint = "";

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                textToPrint += row + "\n";
            }
            MessageBox.Show(textToPrint, "Result History");
            textIn.Close();
        }

        private void TemperatureConvert_Load(object sender, EventArgs e)
        {

        }
    }
}
