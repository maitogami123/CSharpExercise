using System;
using System.Windows.Forms;

namespace CalculatorClone
{
    public partial class Form1 : Form
    {
        double A;
        string Operation = "";
        bool tiep = false;
        bool g = false;
        bool delete_lock = false;
        public Form1()
        {
            InitializeComponent();
        }

        /*private void n1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "1";
            }
            else
            {
                label3.Text = label3.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "2";
            }
            else
            {
                label3.Text = label3.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "3";
            }
            else
            {
                label3.Text = label3.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "4";
            }
            else
            {
                label3.Text = label3.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "5";
            }
            else
            {
                label3.Text = label3.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "6";
            }
            else
            {
                label3.Text = label3.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "7";
            }
            else
            {
                label3.Text = label3.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "8";
            }
            else
            {
                label3.Text = label3.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "9";
            }
            else
            {
                label3.Text = label3.Text + "9";
            }
        }
        private void n0_Click(object sender, EventArgs e)
        {
            if (label3.Text != "0" && label3.Text != null)
            {
                label3.Text = label3.Text + "0";
            }
        }*/
        private void MyButtonClick(object sender, EventArgs e)
        {
            delete_lock = false;
            if (tiep == false && Operation == "")
            {
                label2.Text = "0";
            }
            if (g == true)
            {
                label3.Text = "0";
                g = false;
            }
            string buttonText = ((Button)sender).Text;
            switch (buttonText)
            {
                case "0":
                    if (label3.Text != "0" && label3.Text != null)
                    {
                        label3.Text = label3.Text + "0";
                    }
                    break;
                case "1":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "1";
                    }
                    else
                    {
                        label3.Text = label3.Text + "1";
                    }
                    break;
                case "2":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "2";
                    }
                    else
                    {
                        label3.Text = label3.Text + "2";
                    }
                    break;
                case "3":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "3";
                    }
                    else
                    {
                        label3.Text = label3.Text + "3";
                    }
                    break;
                case "4":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "4";
                    }
                    else
                    {
                        label3.Text = label3.Text + "4";
                    }
                    break;
                case "5":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "5";
                    }
                    else
                    {
                        label3.Text = label3.Text + "5";
                    }
                    break;
                case "6":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "6";
                    }
                    else
                    {
                        label3.Text = label3.Text + "6";
                    }
                    break;
                case "7":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "7";
                    }
                    else
                    {
                        label3.Text = label3.Text + "7";
                    }
                    break;
                case "8":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "8";
                    }
                    else
                    {
                        label3.Text = label3.Text + "8";
                    }
                    break;
                case "9":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "9";
                    }
                    else
                    {
                        label3.Text = label3.Text + "9";
                    }
                    break;
            }
        }
        /*private void bad_Click(object sender, EventArgs e)
        {

            if (Operation == "")
            {
                A = Convert.ToDouble(label3.Text);
                label2.Text = label3.Text + " +";
                label3.Text = "0";
                Operation = "+";
            }
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            if (Operation == "")
            {
                A = Convert.ToDouble(label3.Text);
                label2.Text = label3.Text + " -";
                label3.Text = "0";
                Operation = "-";
            }
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            if (Operation == "")
            {
                A = Convert.ToDouble(label3.Text);
                label2.Text = label3.Text + " *";
                label3.Text = "0";
                Operation = "*";
            }
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            if (Operation == "")
            {
                A = Convert.ToDouble(label3.Text);
                label2.Text = label3.Text + " /";
                label3.Text = "0";
                Operation = "/";
            }
        }*/
        private void basic_math(object sender, EventArgs e)
        {
            delete_lock = false;
            string buttonText = ((Button)sender).Text;
            switch (buttonText)
            {
                case "+":
                    if (Operation == "")
                    {
                        A = Convert.ToDouble(label3.Text);
                        label2.Text = label3.Text + " +";
                        label3.Text = "0";
                        Operation = "+";
                    }
                    break;
                case "-":
                    if (Operation == "")
                    {
                        A = Convert.ToDouble(label3.Text);
                        label2.Text = label3.Text + " -";
                        label3.Text = "0";
                        Operation = "-";
                    }
                    break;
                case "*":
                    if (Operation == "")
                    {
                        A = Convert.ToDouble(label3.Text);
                        label2.Text = label3.Text + " *";
                        label3.Text = "0";
                        Operation = "*";
                    }
                    break;
                case "/":
                    if (Operation == "")
                    {
                        A = Convert.ToDouble(label3.Text);
                        label2.Text = label3.Text + " /";
                        label3.Text = "0";
                        Operation = "/";
                    }
                    break;
            }
        }

        private void bequ_Click(object sender, EventArgs e)
        {
            double B;
            double Result;
            B = Convert.ToDouble(label3.Text);

            if (Operation == "+")
            {
                Result = (A + B);
                label2.Text = label2.Text + " " + B + " =";
                label3.Text = Convert.ToString(Result);
                A = Result;
            }
            if (Operation == "-")
            {
                Result = (A - B);
                label2.Text = label2.Text + " " + B + " =";
                label3.Text = Convert.ToString(Result);
                A = Result;
            }
            if (Operation == "*")
            {
                Result = (A * B);
                label2.Text = label2.Text + " " + B + " =";
                label3.Text = Convert.ToString(Result);
                A = Result;
            }
            if (Operation == "/")
            {
                if (B == 0)
                {
                    label3.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (A / B);
                    label2.Text = label2.Text + " " + B + " =";
                    label3.Text = Convert.ToString(Result);
                    A = Result;
                }
            }
            if (Operation == "")
            {
                label2.Text = label3.Text + " =";
            }
            Operation = "";
            tiep = false;
            g = true;
            delete_lock = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (delete_lock == false)
            {
                if (label3.Text.Length > 1)
                {
                    string n = label3.Text.Remove(label3.Text.Length - 1);
                    label3.Text = n;
                }
                else
                {
                    label3.Text = "0";
                }
            }
        }

        public int RutGon(int x, int y)
        {
            if (y == 0)
                return x;
            return RutGon(y, x / y);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //double A = 1;
            double B = Convert.ToDouble(label3.Text);
            double Result = 1;
            if (label3.Text != "0" && label3.Text != null)
            {
                Result = 1 / B;
                label3.Text = $"1 / {B} = ";
                label2.Text = Convert.ToString(Result);
                label3.Text = "0";

            }
            else
            {
                label3.Text = "Cannot divide by zero";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double Result = 1;
            A = Convert.ToDouble(label3.Text);
            if (label3.Text != null)
            {
                Result = Math.Sqrt(A);
                label3.Text = $"Sqrt({A} = ";
                label2.Text = Convert.ToString(Result);
                
            }
            label3.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double Result = 1;
            A = Convert.ToDouble(label3.Text);
            if(label3.Text != null)
            {
                Result = Math.Pow(A, 2);
                label3.Text = $"{A} ^ 2 = ";
                label2.Text= Convert.ToString(Result);
                label3.Text = "0";
            }
        }
    }
}
