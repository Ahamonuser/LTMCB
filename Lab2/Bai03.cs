using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TestLab2
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input3.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            txtFileContent.Text = reader.ReadToEnd();
            reader.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output3.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            string FileContent = txtFileContent.Text;
            string command = "";
            string Postfix;
            double result;
            for (int index = 0;index < FileContent.Length;index++)
            {
                if (FileContent[index] == '\n' || index == FileContent.Length - 1)
                {
                    Postfix = InfixToPostfix(command);
                    writer.Write(command);
                    writer.Write(" = ");
                    command = "";
                    result = evaluatePostfix(Postfix);
                    result = Math.Round(result, 2);
                    writer.WriteLine(result);
                }
                else
                {
                    command += FileContent[index];
                }
            }
            writer.Close();
        }

        internal static int Prec(char ch)
        {
            switch (ch)
            {
                case '(':
                    {
                        return 0;
                    }
                case '+':
                case '-':
                    {
                        return 1;
                    }
                case '*':
                case '/':
                    {
                        return 2;
                    }
            }
            return 3;
        }

        public static string InfixToPostfix(string Infix)
        {
            string result = "";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < Infix.Length; ++i)
            {
                char c = Infix[i];
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }

                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        return "Invalid Expression"; // invalid expression 
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    while (stack.Count > 0 && Prec(c) <= Prec(stack.Peek()))
                    {
                        result += stack.Pop();
                    }
                    stack.Push(c);
                }
            }
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }
            return result;
        }

        public static double evaluatePostfix(string Postfix)
        {
            Stack<double> stack = new Stack<double>();
            for (int index = 0; index < Postfix.Length; index++)
            {
                char c = Postfix[index];
                if (c == ' ')
                {
                    continue;
                }
                // If the scanned character is an operand (number here),extract the number.
                // Push it to the stack.  
                else if (char.IsDigit(c))
                {
                    double number = 0;
                    // extract the characters and store it in num  
                    while (char.IsDigit(c))
                    {
                        number = number * 10 + (double)(c - '0');
                        index++;
                        c = Postfix[index];
                    }
                    index--;
                    // push the number in stack  
                    stack.Push(number);
                }
                // If the scanned character is an operator,
                // pop two elements from stack apply the operator  
                else
                {
                    double val1 = stack.Pop();
                    double val2 = stack.Pop();
                    switch (c)
                    {
                        case '+':
                            stack.Push(val2 + val1);
                            break;

                        case '-':
                            stack.Push(val2 - val1);
                            break;

                        case '/':
                            stack.Push(val2 / val1);
                            break;

                        case '*':
                            stack.Push(val2 * val1);
                            break;
                    }
                }
            }
            return stack.Pop();
        }
    }
}
