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
    public partial class Lotto649 : Form
    {
        public Lotto649()
        {
            InitializeComponent();
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"..\..\Folder\") == false)
            {
                Directory.CreateDirectory(@"..\..\Folder\");
            }
            FileStream fs = new FileStream(@"..\..\Folder\Lotto649.txt", FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);


            Random random = new Random();

            var randomNumbers = Enumerable.Range(1, 49).OrderBy(x => random.Next()).Take(6).ToList();

            txtbox.Text = String.Join(Environment.NewLine, randomNumbers);

            textOut.WriteLine(txtbox.Text + "\n" + "--------------");
            textOut.Close();
        }

        private void Btn_Read_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"..\..\Folder\") == false)
            {
                Directory.CreateDirectory(@"..\..\Folder\");
            }
            FileStream fs = new FileStream(@"..\..\Folder\Lotto649.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(fs);
            string textToPrint = "";

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                textToPrint += row + "\n";
            }
            MessageBox.Show(textToPrint, "Result Hisotry");
            textIn.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
