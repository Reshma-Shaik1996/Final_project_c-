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

    public partial class Calculator : Form
    {
        Operator obj1 = new Operator();

        string operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        #region ALL NUMERIC VALUE

        private void Btn_7_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, "7");
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, "8");
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, "9");
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, "4");
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, "5");
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, "6");
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, "1");
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, "2");
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, "3");
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, "0");
        }

        private void Btn_Dot_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = lbl_Display.Text.Insert(lbl_Display.Text.Length, ".");
        }

        #endregion
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (lbl_Display.Text.Length > 0)
            {
                lbl_Display.Text = lbl_Display.Text.Remove(lbl_Display.Text.Length - 1);
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            operation = "+";
            obj1.Val1 = Convert.ToDouble(lbl_Display.Text);
            lbl_Display.Text = string.Empty;
        }
        private void Btn_Subs_Click(object sender, EventArgs e)
        {
            operation = "-";
            obj1.Val1 = Convert.ToDouble(lbl_Display.Text);
            lbl_Display.Text = string.Empty;
        }
        private void Btn_Times_Click(object sender, EventArgs e)
        {
            operation = "*";
            obj1.Val1 = Convert.ToDouble(lbl_Display.Text);
            lbl_Display.Text = string.Empty;
        }
        private void Btn_Divide_Click(object sender, EventArgs e)
        {
            operation = "/";
            obj1.Val1 = Convert.ToDouble(lbl_Display.Text);
            lbl_Display.Text = string.Empty;
        }

        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"..\..\Folder\") == false)
            {
                Directory.CreateDirectory(@"..\..\Folder\");
            }
            FileStream fs = new FileStream(@"..\..\Folder\Calculator.txt", FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);




            switch (operation)
            {
                case "+":
                    obj1.Val2 = Convert.ToDouble(lbl_Display.Text);
                    lbl_Display.Text = Convert.ToString(obj1.Additon());
                    textOut.WriteLine(obj1.Val1 + "+" + obj1.Val2 + "=" + lbl_Display.Text);
                    textOut.Close();
                    break;
                case "-":
                    obj1.Val2 = Convert.ToDouble(lbl_Display.Text);
                    lbl_Display.Text = Convert.ToString(obj1.Substraction());
                    textOut.WriteLine(obj1.Val1 + "-" + obj1.Val2 + "=" + lbl_Display.Text);
                    textOut.Close();
                    break;
                case "*":
                    obj1.Val2 = Convert.ToDouble(lbl_Display.Text);
                    lbl_Display.Text = Convert.ToString(obj1.Multiplication());
                    textOut.WriteLine(obj1.Val1 + "*" + obj1.Val2 + "=" + lbl_Display.Text);
                    textOut.Close();
                    break;
                case "/":
                    obj1.Val2 = Convert.ToDouble(lbl_Display.Text);
                    lbl_Display.Text = Convert.ToString(obj1.Division());
                    textOut.WriteLine(obj1.Val1 + "/" + obj1.Val2 + "=" + lbl_Display.Text);
                    textOut.Close();
                    break;
            }

        }

        private void Btn_Plus_Minus_Click(object sender, EventArgs e)
        {
            if (lbl_Display.Text.Contains("-"))
            {
                lbl_Display.Text = lbl_Display.Text.Remove(0, 1);
            }
            else
            {
                lbl_Display.Text = lbl_Display.Text.Insert(0, "-");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = string.Empty;
        }



        class Operator
        {
            double val1, val2;

            public double Val1
            {
                get { return val1; }
                set { val1 = value; }
            }

            public double Val2
            {
                get { return val2; }
                set { val2 = value; }
            }


            public Operator()
            {

            }

            public double Additon()
            {
                double result;
                result = Val1 + Val2;
                return result;
            }

            public double Substraction()
            {
                double result;
                result = Val1 - Val2;
                return result;
            }

            public double Multiplication()
            {
                double result;
                result = Val1 * Val2;
                return result;
            }

            public double Division()
            {
                double result;
                result = Val1 / Val2;
                return result;
            }
        }

    }
}
