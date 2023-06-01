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
    public partial class Calculator : Form
    {
        int number1 = 0;
        int number2 = 0;
        string PDS = "";
        bool ISFN = true;
        public Calculator()
        {
            InitializeComponent();
            this.KeyPreview = true;
            foreach (Control Cont in this.Controls)
            {
                if (Cont is Button)
                {
                    Button btn = (Button)Cont;
                    btn.TabStop = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }


            }
        }

        private void ClickNumber(object sender, EventArgs e)
        {
            Button Number = (Button)sender;
            Display.Text += Number.Text;
            if (!ISFN)
            {
                number1 = Convert.ToInt32(Display.Text);


            }SS
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
                ISFN = false;
                string coutext = Display.Text;
                coutext = coutext.Remove(coutext.Length - 1);
                Display.Text = coutext;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            ISFN = true;
            number1 = 0;
            number2 = 0;
            PDS = "";
        }

        private void HPDS(object sender, EventArgs e)
        {
            Button Sopt = (Button)sender;
            PDS = Sopt.Tag + "";
            Display.Text = "";
            ISFN = false;
        }

        private void Mosavi_Click(object sender, EventArgs e)
        {
            int result = 0 ;
            switch (PDS)
            {
                case "plus":
                    result = number1 + number2;
                    break;           
                case "manfi":
                    result = number2 - number1;
                    break;
                case "zarb":
                    result = number2 * number1;
                    break;
                case "tagh":
                    result = number2 / number1;
                    break;

            }
            MessageBox.Show("===N1 : "+number1 + " ===N2: " + number2 +"==== :R: "+result + "=== P: "+PDS);
            Display.Text = Convert.ToString(result);
        }

        private void from_key(object sender, KeyEventArgs e)
        {
       //     MessageBox.Show(e.KeyCode + "");
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    Display.Text += "0";
                    ClickNumber(Number0, e);
                    Backspace_Click(sender, e);
                    break;

                case Keys.NumPad1:
                    Display.Text += "1";
                    ClickNumber(Number1, e);
                    Backspace_Click(sender, e);
                    break;
                case Keys.NumPad2:
                    Display.Text += "2";
                    ClickNumber(Number2, e);
                    Backspace_Click(sender, e);
                    break;
                case Keys.NumPad3:
                    Display.Text += "3";
                    ClickNumber(Number3, e);
                    Backspace_Click(sender, e);
                    break;
                case Keys.NumPad4:
                    Display.Text += "4";
                    ClickNumber(Number4, e);
                    Backspace_Click(sender, e);
                    break;
                case Keys.NumPad5:
                    Display.Text += "5";
                    ClickNumber(Number5, e);
                    Backspace_Click(sender, e);
                    break;
                case Keys.NumPad6:
                    Display.Text += "6";
                    ClickNumber(Number6, e);
                    Backspace_Click(sender, e);
                    break;
                case Keys.NumPad7:
                    Display.Text += "7";
                    ClickNumber(Number7, e);
                    Backspace_Click(sender, e);
                    break;
                case Keys.NumPad8:
                    Display.Text += "8";
                    ClickNumber(Number8, e);
                    Backspace_Click(sender, e);
                    break;
                case Keys.NumPad9:
                    Display.Text += "9";
                    ClickNumber(Number9_1, e);
                    Backspace_Click(sender, e);
                    break;
                case Keys.Enter:
                    Mosavi_Click(sender, e);
                    Backspace_Click(sender, e);
                    break;
               case Keys.Add:
                    HPDS(Plus, e);
                    PDS = "plus";
                   break;
            }

        }
    }
}
