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
    public partial class Money_Exchange : Form
    {
        DateTime aDate = DateTime.Now;

        public Money_Exchange()
        {
            InitializeComponent();
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"..\..\Folder\") == false)
            {
                Directory.CreateDirectory(@"..\..\Folder\");
            }
            FileStream fs = new FileStream(@"..\..\Folder\MoneyExchange.txt", FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);

            double convertFrom, convertTo;
            bool flag = false;

            if (radioFrom_CAD.Checked)
            {
                try
                {
                    flag = true;

                    if (radioTo_USD.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 0.76);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_CAD.Text + "=" + txtBox_To.Text + " " + radioTo_USD.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_EUR.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 0.68);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_CAD.Text + "=" + txtBox_To.Text + " " + radioTo_EUR.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_GBP.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 0.63);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_CAD.Text + "=" + txtBox_To.Text + " " + radioTo_GBP.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_INR.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 52.37);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_CAD.Text + "=" + txtBox_To.Text + " " + radioTo_INR.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid input");
                    flag = false;
                    textOut.Close();
                }

                
            }

            if (radioFrom_USD.Checked)
            {
                try
                {
                    flag = true;

                    if (radioTo_CAD.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 1.31);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_USD.Text + "=" + txtBox_To.Text + " " + radioTo_CAD.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_EUR.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 0.90);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_USD.Text + "=" + txtBox_To.Text + " " + radioTo_EUR.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_GBP.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 0.82);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_USD.Text + "=" + txtBox_To.Text + " " + radioTo_GBP.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_INR.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 68.87);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_USD.Text + "=" + txtBox_To.Text + " " + radioTo_INR.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid input");
                    flag = false;
                    textOut.Close();
                }

                
            }
            if (radioFrom_EUR.Checked)
            {
                try
                {
                    flag = true;

                    if (radioTo_CAD.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 1.47);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_EUR.Text + "=" + txtBox_To.Text + " " + radioTo_CAD.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_USD.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 1.12);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_EUR.Text + "=" + txtBox_To.Text + " " + radioTo_USD.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_GBP.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 0.92);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_EUR.Text + "=" + txtBox_To.Text + " " + radioTo_GBP.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_INR.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 76.85);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_EUR.Text + "=" + txtBox_To.Text + " " + radioTo_INR.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid input");
                    flag = false;
                    textOut.Close();
                }

                
            }
            if (radioFrom_GBP.Checked)
            {
                try
                {
                    flag = true;

                    if (radioTo_CAD.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 1.60);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_GBP.Text + "=" + txtBox_To.Text + " " + radioTo_CAD.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_USD.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 1.22);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_GBP.Text + "=" + txtBox_To.Text + " " + radioTo_USD.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_EUR.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 1.09);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_GBP.Text + "=" + txtBox_To.Text + " " + radioTo_EUR.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_INR.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 83.80);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_GBP.Text + "=" + txtBox_To.Text + " " + radioTo_INR.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid input");
                    flag = false;
                    textOut.Close();
                }
                
            }
            if (radioFrom_INR.Checked)
            {
                try
                {
                    flag = true;

                    if (radioTo_CAD.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 0.019);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_INR.Text + "=" + txtBox_To.Text + " " + radioTo_CAD.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_USD.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 0.015);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_INR.Text + "=" + txtBox_To.Text + " " + radioTo_USD.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_EUR.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 0.013);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_INR.Text + "=" + txtBox_To.Text + " " + radioTo_EUR.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                    if (radioTo_GBP.Checked)
                    {
                        convertFrom = Convert.ToDouble(txtBox_From.Text);
                        convertTo = Convert.ToDouble(convertFrom * 0.012);
                        txtBox_To.Text = Convert.ToString(convertTo);
                        textOut.WriteLine(txtBox_From.Text + " " + radioFrom_INR.Text + "=" + txtBox_To.Text + " " + radioTo_GBP.Text + "," + " " + aDate.ToString("MM/dd/yyyy hh:mm tt"));
                        textOut.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid input");
                    flag = false;
                    textOut.Close();
                }

                
            }
        }

        private void RadioFrom_CAD_CheckedChanged(object sender, EventArgs e)
        {
            radioTo_CAD.Enabled = false;
            radioTo_USD.Enabled = true;
            radioTo_EUR.Enabled = true;
            radioTo_GBP.Enabled = true;
            radioTo_INR.Enabled = true;
        }

        private void RadioFrom_USD_CheckedChanged(object sender, EventArgs e)
        {
            radioTo_CAD.Enabled = true;
            radioTo_USD.Enabled = false;
            radioTo_EUR.Enabled = true;
            radioTo_GBP.Enabled = true;
            radioTo_INR.Enabled = true;
        }

        private void RadioFrom_EUR_CheckedChanged(object sender, EventArgs e)
        {
            radioTo_CAD.Enabled = true;
            radioTo_USD.Enabled = true;
            radioTo_EUR.Enabled = false;
            radioTo_GBP.Enabled = true;
            radioTo_INR.Enabled = true;
        }

        private void RadioFrom_GBP_CheckedChanged(object sender, EventArgs e)
        {
            radioTo_CAD.Enabled = true;
            radioTo_USD.Enabled = true;
            radioTo_EUR.Enabled = true;
            radioTo_GBP.Enabled = false;
            radioTo_INR.Enabled = true;
        }

        private void RadioFrom_INR_CheckedChanged(object sender, EventArgs e)
        {
            radioTo_CAD.Enabled = true;
            radioTo_USD.Enabled = true;
            radioTo_EUR.Enabled = true;
            radioTo_GBP.Enabled = true;
            radioTo_INR.Enabled = false;
        }

        private void Btn_Read_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"..\..\Folder\") == false)
            {
                Directory.CreateDirectory(@"..\..\Folder\");
            }
            FileStream fs = new FileStream(@"..\..\Folder\MoneyExchange.txt", FileMode.OpenOrCreate, FileAccess.Read);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Money_Exchange_Load(object sender, EventArgs e)
        {

        }
    }
}
