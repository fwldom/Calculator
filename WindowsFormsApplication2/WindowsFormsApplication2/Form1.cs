using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public static int NumberOrg;
        public static string PDS;


        public Form1()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var i in NumberOS.Text)
            {
                if (Convert.ToString(i) == "=")
                {
                    button11_Click(sender, e);
                }
                if (Convert.ToString(i) == "-")
                {
                    Reduce_Click(sender, e);
                }
                if (Convert.ToString(i) == "*")
                {
                    multiplication_Click(sender, e);

                }
                if (Convert.ToString(i) == "=")
                {
                    Equal_Click(sender, e);

                }
                if (Convert.ToString(i) == "/")
                {
                    Division_Click(sender, e);
                }
            }


        }
        

        private void button11_Click(object sender, EventArgs e)
        {
            NumberOrg += Convert.ToInt32(NumberOS.Text);
            NumberOS.ResetText();
            PDS = "+";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (PDS == "+")
            {
                try
                {
                    NumberOrg += Convert.ToInt32(NumberOS.Text);
                }
                catch (Exception)
                {

                }
            }
            if (PDS == "*")
            {
                try
                {
                    NumberOrg *= Convert.ToInt32(NumberOS.Text);
                }
                catch (Exception)
                {
                }
            }
            if (PDS == "-")
            {
                try
                {
                    NumberOrg -= Convert.ToInt32(NumberOS.Text);

                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (PDS == "/")
            {
                try
                {
                    NumberOrg /= Convert.ToInt32(NumberOS.Text);

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {

            }
            NumberOS.Text = Convert.ToString(NumberOrg);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            NumberOrg *= Convert.ToInt32(NumberOS.Text);
            NumberOS.ResetText();
            PDS = "*";
        }

        private void Reduce_Click(object sender, EventArgs e)
        {
            NumberOrg -= Convert.ToInt32(NumberOS.Text);
            NumberOS.ResetText();
            PDS = "*";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            NumberOrg = NumberOrg / Convert.ToInt32(NumberOS.Text);
            NumberOS.ResetText();
            PDS = "*";
        }

        private void C_Clear_Click(object sender, EventArgs e)
        {
            NumberOrg = 0;
            NumberOS.Text = "";
            PDS = "";
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            NumberOS.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            NumberOS.Text += "2";

        }

        private void Num3_Click(object sender, EventArgs e)
        {
            NumberOS.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            NumberOS.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            NumberOS.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            NumberOS.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            NumberOS.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            NumberOS.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            NumberOS.Text += "9";
        }
    }
}
