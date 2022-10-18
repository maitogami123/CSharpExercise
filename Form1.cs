using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorClone
{
    public partial class Form1 : Form
    {
        double A;
        string Operation="";
        bool g=false;
        //lock1 la de khoa lai nut xoa tung so sau khi vua in ra ket qua 
        bool lock1 = false, lock2 = false, lock3=false; //basicmath = false;
        //string origin;
        //string basic_math2_store;
        double MemoryStore;
        public Form1()
        {
            InitializeComponent();
        }
        private void MyButtonClick(object sender, EventArgs e)
        {
            lock2 = false;
            lock1 = false;
            //
            //= "";
            if (Operation=="")
            {
                label2.Text = "0";
            }
            if (g == true)
            {
                label3.Text = "0";
                g= false;
            }

            string buttonText = ((Button)sender).Text;
            switch(buttonText)
            {
                case "C":
                    label2.Text = "0";
                    label3.Text = "0";
                    Operation = "";
                    //lock3 = false;
                    break;
                case "CE":
                    label3.Text="0";
                    break;
                case "+/-":
                    if (label3.Text.Contains('-') == true)
                    {
                        label3.Text = label3.Text.Remove(0,1);
                    }
                    else
                    {
                        label3.Text="-"+label3.Text;
                    }
                    break;
                case ".":
                    if (label3.Text.Contains('.')==false && label3.Text != null)
                    {
                        label3.Text = label3.Text + ".";
                    }
                    formatString();
                    break;
                case "0":
                    if (label3.Text != "0" && label3.Text != null)
                    {
                        label3.Text = label3.Text + "0";
                    }
                    formatString();
                    break;
                case "1":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "1";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "1";
                    }
                    formatString();
                    break;
                case"2":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "2";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "2";
                    }
                    formatString();
                    break ;
                case "3":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "3";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "3";
                    }
                    formatString();
                    break;
                case"4":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "4";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "4";
                    }
                    formatString();
                    break;
                case"5":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "5";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "5";
                    }
                    formatString();
                    break;
                case"6":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "6";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "6";
                    }
                    formatString();
                    break;
                case "7":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "7";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "7";
                    }
                    formatString();
                    break ;
                case"8":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "8";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "8";
                    }
                    formatString();
                    break;
                case"9":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "9";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "9";
                    }
                    formatString();
                    break;
            }
        }

        private void formatString()
        {
            string result = "";
            if (!label3.Text.Contains('.'))
            {
                char[] charArr = string.Join("", label3.Text.Split(',')).ToCharArray();
                Array.Reverse(charArr);
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (i % 3 == 0 && i != 0)
                        result += $",{charArr[i]}";
                    else
                        result += $"{charArr[i]}";
                }
                charArr = result.ToCharArray();
                Array.Reverse(charArr);
                label3.Text = (string.Join("", charArr));
            }
        }

        private void basic_math2(object sender, EventArgs e)
        {
            double Result2;
            bool local_lock = false;
            try
            {
                A = Convert.ToDouble(label3.Text);
            }
            catch
            {
                label3.Text = "0";
                local_lock = true;
            }
            if (lock2 == false && Operation=="")
            {
                label2.Text = Convert.ToString(label3.Text);
                lock2 = true;
            }
            /*else if(Operation != "" && lock3==false)
            {
                origin = label3.Text;
            }*/
            string buttonText = ((Button)sender).Text;
            switch (buttonText)
            {
                case "sqrt":
                    /*A = Convert.ToDouble(label3.Text);
                    Result2 = Math.Sqrt(A);
                    label2.Text = "sqrt(" + label2.Text + ")";
                    label3.Text = Convert.ToString(Result2);
                    A = Result2;
                    break;*/
                    A = Convert.ToDouble(label3.Text);
                    if (A >= 0)
                    {
                        /*if (Operation != "")
                        {
                            if(lock3==false)
                            {
                                basic_math2_store = label2.Text;
                                lock3=true;
                            }
                            Result2 = Math.Sqrt(A);
                            origin = "sqrt("+origin+")2";
                            label2.Text = basic_math2_store +" "+ origin;
                            label3.Text = Convert.ToString(Result2);
                            basicmath = true;
                        }
                        else
                        {
                            Result2 = Math.Sqrt(A);
                            label2.Text = "sqrt(" + label2.Text + ")2";
                            label3.Text = Convert.ToString(Result2);
                            A = Result2;
                        }*/
                        Result2 = Math.Sqrt(A);
                        label2.Text = "sqrt(" + label2.Text + ")";
                        label3.Text = Convert.ToString(Result2);
                        A = Result2;
                        Operation = "";
                    }
                    else
                    {
                        label2.Text = label3.Text;
                        label2.Text = $"sqrt({label2.Text})2";
                        label3.Text = "Invalid Input";
                    }
                    break ;
                case "pow(2)":
                    A = Convert.ToDouble(label3.Text);
                    Result2 = Math.Pow(A,2);
                    label2.Text = "pow(" + label2.Text + ")2";
                    label3.Text = Convert.ToString(Result2);
                    A = Result2;
                    Operation = "";
                    /*A = Convert.ToDouble(label3.Text);
                    if (Operation != "")
                    {
                        if (lock3 == false)
                        {
                            basic_math2_store = label2.Text;
                            lock3 = true;
                        }
                        Result2 = Math.Pow(A, 2);
                        origin = "pow(" + origin + ")2";
                        label2.Text = basic_math2_store + " " + origin;
                        label3.Text = Convert.ToString(Result2);
                        basicmath = true;
                    }
                    else
                    {
                        Result2 = Math.Pow(A, 2);
                        label2.Text = "pow(" + label2.Text + ")2";
                        label3.Text = Convert.ToString(Result2);
                        A = Result2;
                    }*/
                    break;
                case "1/x":
                    A = Convert.ToDouble(label3.Text);
                    Result2 = 1/A;
                    label2.Text = "1/(" + label2.Text + ")";
                    label3.Text = Convert.ToString(Result2);
                    A = Result2;
                    Operation = "";
                    /*A = Convert.ToDouble(label3.Text);
                    if (Operation != "")
                    {
                        if (lock3 == false)
                        {
                            basic_math2_store = label2.Text;
                            lock3 = true;
                        }
                        Result2 = 1/A;
                        origin = "1/(" + origin + ")";
                        label2.Text = basic_math2_store + " " + origin;
                        label3.Text = Convert.ToString(Result2);
                        basicmath = true;
                    }
                    else
                    {
                        Result2 = 1/A;
                        label2.Text = "1/(" + label2.Text + ")";
                        label3.Text = Convert.ToString(Result2);
                        A = Result2;
                    }*/
                    break;
                case "%":
                    /*if (Operation == "")
                    {*/
                        A = Convert.ToDouble(label3.Text);
                        Result2 = A / 100;
                        label2.Text = Convert.ToString(Result2);
                        label3.Text = Convert.ToString(Result2);
                        A = Result2;
                        Operation = "";
                    /*}
                    else
                    {
                        /*double B;
                        double Result;
                        B = Convert.ToDouble(label3.Text)/100;

                        if (Operation == "+")
                        {
                            Result = (A + B);
                            label2.Text = label2.Text + " + " + B + " =";
                            label3.Text = Convert.ToString(Result);
                            A = Result;
                        }
                        if (Operation == "-")
                        {
                            Result = (A - B);
                            label2.Text = label2.Text + " - " + B + " =";
                            label3.Text = Convert.ToString(Result);
                            A = Result;
                        }
                        if (Operation == "*")
                        {
                            Result = (A * B);
                            label2.Text = label2.Text + " * " + B + " =";
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
                                label2.Text = label2.Text + " / " + B + " =";
                                label3.Text = Convert.ToString(Result);
                                A = Result;
                            }
                        }
                        if (Operation == "")
                        {
                            label2.Text = label3.Text + " =";
                        }
                        Operation = "";
                        g = true;
                        lock1 = true;*/
                        /*if (lock3 == false)
                        {
                            basic_math2_store = label2.Text;
                            lock3 = true;
                        }*/
                        /*Result2 = A/100;
                        origin = Convert.ToString(Result2);
                        label2.Text = basic_math2_store + " " + origin;
                        label3.Text = Convert.ToString(Result2);
                        basicmath = true;*/
                    //}
                    break;
            }
            g=true;
            lock1 = true;
            formatString();
            if (local_lock == true)
            {
                label2.Text = "0";
            }
        }

        private void basic_math(object sender, EventArgs e)
        {
            lock2 = false;
            double Result2;
            lock1 = false;
            bool local_lock = false;
            string buttonText = ((Button)sender).Text;
            try
            {
                A = Convert.ToDouble(label3.Text);
            }
            catch
            {
                label3.Text = "0";
                local_lock = true;
            }

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
                    break ;
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
            if (local_lock == true)
            {
                label2.Text = "0";
                Operation="";
            }
        }
        private void Memory(object sender, EventArgs e)
        {
            lock2 = false;
            string buttonText = ((Button)sender).Text;
            switch (buttonText)
            {
                case "MC":
                    MemoryStore = 0;
                    label4.Text = Convert.ToString(MemoryStore);
                    break;
                case "MR":
                    if(Operation=="")
                    {
                        label3.Text = MemoryStore.ToString();
                        label2.Text = "0";
                    }
                    /*else if (basicmath==true)
                    {
                        label2.Text = basic_math2_store + " "+MemoryStore.ToString();
                        label3.Text = MemoryStore.ToString();
                    }*/
                    else
                    {
                        label3.Text = MemoryStore.ToString();
                    }
                    break;
                case "M+":
                    MemoryStore += Convert.ToDouble(label3.Text);
                    label4.Text = Convert.ToString(MemoryStore);
                    break;
                case "M-":
                    MemoryStore -= Convert.ToDouble(label3.Text);
                    label4.Text = Convert.ToString(MemoryStore);
                    break;
                case "MS":
                    MemoryStore = Convert.ToDouble(label3.Text);
                    label4.Text = Convert.ToString(MemoryStore);
                    break;
                case "Mv":
                    label4.Text = Convert.ToString(MemoryStore);
                    if (label4.Visible == false)
                    {
                        label4.Visible = true;
                    }
                    else
                    {
                        label4.Visible = false;
                    }
                    break;
            }
        }

        private void delete_KeyDown(object sender, KeyEventArgs e)
        {
            if (lock1 == false && e.KeyCode == (Keys.Back))
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
                formatString();
            }
        }

        private void buttonPress(object sender, KeyPressEventArgs e)
        {
            lock2 = false;
            lock1 = false;
            //
            //= "";
            if (Operation == "")
            {
                label2.Text = "0";
            }
            if (g == true)
            {
                label3.Text = "0";
                g = false;
            }

            string buttonText = e.KeyChar.ToString();
            switch (buttonText)
            {
                case "C":
                    label2.Text = "0";
                    label3.Text = "0";
                    Operation = "";
                    //lock3 = false;
                    break;
                case "CE":
                    label3.Text = "0";
                    break;
                case "+/-":
                    if (label3.Text.Contains('-') == true)
                    {
                        label3.Text = label3.Text.Remove(0, 1);
                    }
                    else
                    {
                        label3.Text = "-" + label3.Text;
                    }
                    break;
                case ".":
                    if (label3.Text.Contains('.') == false && label3.Text != null)
                    {
                        label3.Text = label3.Text + ".";
                    }
                    formatString();
                    break;
                case "0":
                    if (label3.Text != "0" && label3.Text != null && label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "0";
                    }
                    formatString();
                    break;
                case "1":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "1";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "1";
                    }
                    formatString();
                    break;
                case "2":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "2";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "2";
                    }
                    formatString();
                    break;
                case "3":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "3";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "3";
                    }
                    formatString();
                    break;
                case "4":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "4";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "4";
                    }
                    formatString();
                    break;
                case "5":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "5";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "5";
                    }
                    formatString();
                    break;
                case "6":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "6";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "6";
                    }
                    formatString();
                    break;
                case "7":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "7";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "7";
                    }
                    formatString();
                    break;
                case "8":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "8";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "8";
                    }
                    formatString();
                    break;
                case "9":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "9";
                    }
                    else if (label3.Text.Length < 11)
                    {
                        label3.Text = label3.Text + "9";
                    }
                    formatString();
                    break;
            }
        }

        private void bequ_Click(object sender, EventArgs e)
        {
            double B;
            double Result;
            B = Convert.ToDouble(label3.Text);
            formatString();
            /*if(basicmath==false)
            {*/
                if (Operation == "+")
                {
                    Result = (A + B);
                    label2.Text = label2.Text + " " + label3.Text + " =";
                    label3.Text = Convert.ToString(Result);
                    
                    A = Result;
                }
                if (Operation == "-")
                {
                    Result = (A - B);
                    label2.Text = label2.Text + " " + label3.Text + " =";
                    label3.Text = Convert.ToString(Result);
                    A = Result;
                }
                if (Operation == "*")
                {
                    Result = (A * B);
                    label2.Text = label2.Text + " " + label3.Text + " =";
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
                        label2.Text = label2.Text + " " + label3.Text + " =";
                        label3.Text = Convert.ToString(Result);
                        A = Result;
                    }
                }
            /*}
            else
            {
                if (Operation == "+")
                {
                    Result = (A + B);
                    label2.Text = label2.Text + " =";
                    label3.Text = Convert.ToString(Result);
                    A = Result;
                }
                if (Operation == "-")
                {
                    Result = (A - B);
                    label2.Text = label2.Text + " =";
                    label3.Text = Convert.ToString(Result);
                    A = Result;
                }
                if (Operation == "*")
                {
                    Result = (A * B);
                    label2.Text = label2.Text + " =";
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
                        label2.Text = label2.Text + " =";
                        label3.Text = Convert.ToString(Result);
                        A = Result;
                    }
                }
            }*/
            /*if (Operation == "" && basicmath==false)
            {
                label2.Text = label3.Text + " =";
            }*/
            formatString();
            Operation = "";
            g=true;
            lock1 = true;
            //basicmath = false;
            //lock3=false;
        }
        
        private void delete_Click(object sender, EventArgs e)
        {
            if (lock1 == false)
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
                formatString();
            }
        }
    }
}
