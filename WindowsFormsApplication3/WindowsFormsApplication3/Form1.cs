using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int number1 = 0;
        int number2 = 0;
        string PDS = "";
        bool ISFN = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickNumber(object sender, EventArgs e)
        {
            Button Number = (Button)sender;
            Display.Text += Number.Text;
            if (ISFN)
            {
                number1 = Convert.ToInt32(Display.Text);

            }
            else
            {
                number2 = Convert.ToInt32(Display.Text);

            }
            if (Display.Text.Length > 10)
            {
                Display.Text.Replace(Number.Text, "");
                MessageBox.Show("Very Number");
            }
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            try
            {
                ISFN = true;
                string coutext = Display.Text;
                coutext = coutext.Remove(coutext.Length - 1);
                Display.Text = coutext;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            ISFN = true;
        }

        private void HPDS(object sender, EventArgs e)
        {
            Button Sopt = (Button)sender;
            PDS = Sopt.Text;
            Display.Text = "";
        }

        private void Mosavi_Click(object sender, EventArgs e)
        {
            int result = 0 ;
            switch (PDS)
            {
                case "+":
                    result = number1 + number1;
                    break;           
                case "-":
                    result = number1 - number1;
                    break;
                case "×":
                    result = number1 * number1;
                    break;
                case "÷":
                    result = number1 / number2;
                    break;

            }
            Display.Text = Convert.ToString(result);
        }
    }
}
