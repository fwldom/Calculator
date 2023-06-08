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
            BANumber.Text = "0";

        }

        private void HPDS(object sender, EventArgs e)
        {
            Button Sopt = (Button)sender;
            PDS = Sopt.Tag + "";
            try
            {
                switch (PDS)
                {

                    case "plus":
                        
                            BANumber.Text = Convert.ToString(Convert.ToInt32(BANumber.Text) + Convert.ToInt32(Display.Text));
                        break;
                    case "manfi":
                            BANumber.Text = Convert.ToString(Convert.ToInt32(BANumber.Text) - Convert.ToInt32(Display.Text));
                        break;
                    case "zarb":
                        BANumber.Text = Convert.ToString(Convert.ToInt32(BANumber.Text) * Convert.ToInt32(Display.Text));
                        break;
                    case "tagh":
                        BANumber.Text = Convert.ToString(Convert.ToInt32(BANumber.Text) / Convert.ToInt32(Display.Text));
                        break;

                }
            }
            catch (Exception)
            {
                BANumber.Text = Display.Text;
            //   MessageBox.Show("Null");

            }
            Display.Text = "";
            ISFN = false;
        }

        private void Mosavi_Click(object sender, EventArgs e)
        {
            int result = 0 ;
            switch (PDS)
            {
                case "plus":
                    try
                    {
                        result = Convert.ToInt32(BANumber.Text) + Convert.ToInt32(Display.Text + "");
                    }
                    catch (Exception)
                    {
                        result = Convert.ToInt32(BANumber.Text);
                    }
                    break;           
                case "manfi":
                    try
                    {
                        result = Convert.ToInt32(BANumber.Text) - Convert.ToInt32(Display.Text);
                    }
                    catch (Exception)
                    {
                        result = Convert.ToInt32(BANumber.Text);
                    }
                    break;
                case "zarb":
                    try
                    {
                        result = Convert.ToInt32(BANumber.Text) * Convert.ToInt32(Display.Text);

                    }
                    catch (Exception)
                    {
                        result = Convert.ToInt32(BANumber.Text);
                    }
                    break;
                case "tagh":
                    try
                    {
                        result = Convert.ToInt32(BANumber.Text) / Convert.ToInt32(Display.Text);
                    }
                    catch (Exception)
                    {
                        result = Convert.ToInt32(BANumber.Text);
                    }
                    break;

            }
      //      MessageBox.Show("===N1 : "+number1 + " ===N2: " + number2 +"==== :R: "+result + "=== P: "+PDS);
            Display.Text = Convert.ToString(result);
        }

        private void from_key(object sender, KeyEventArgs e)
        {
            //     MessageBox.Show(e.KeyCode + "");
            if (e.KeyCode == Keys.NumPad1)
            {
                Number1.PerformClick();
            
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                Number0.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                Number2.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                Number3.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                Number4.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                Number5.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                Number6.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                Number7.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                Number8.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                Number9_1.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Mosavi.PerformClick();
            }
            else if (e.KeyCode == Keys.Return)
            {
                Mosavi.PerformClick();
            }
            else if (e.KeyCode == Keys.End)
            {
                Mosavi.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                Plus.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                Down.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                Zarb.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                button16.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                Clear.PerformClick();

            }
            else if (e.KeyCode == Keys.C)
            {
                Clear.PerformClick();
            }
            else if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("\n\n"+
                                "Calculator By Fwldom \n"+
                                "Programing Language C# .Net \n"+
                                "For Woman Life Freedom \n"+
                                "Iran Free \n "+
                                "!!!!!!!!!","HELP");

            }
            else if (e.KeyCode == Keys.F)
            {
//                MessageBox.Show.WindowState = 
            }




        }

        private void Display_Click(object sender, EventArgs e)
        {

        }

        private void BANumber_Click(object sender, EventArgs e)
        {

        }
    }
}
