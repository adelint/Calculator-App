﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        private string number;
        private bool isFloat;
        private bool clicked;
        private List<double> numberList;
        private List<char> operationList;
        private List<char> list;

        public Calculator()
        {
            number = "";
            isFloat = false;
            clicked = false;
            numberList = new List<double>();
            operationList = new List<char>();
            list = new List<char>();
            InitializeComponent();
        }

        /// <summary>
        /// Add operation and numbers to operation history list
        /// </summary>
        /// <param name="c">Char to be added to operation list</param>
        private void addChar(char c)
        {
            list.Add(c);
            string temp = string.Join("", list.ToArray());
            historyBox.Text = temp;
        }

        /// <summary>
        /// Verify if a numpad key or numerical one was pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event generated by pressing a key</param>
        private void Calculator_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    zeroButton_Click(sender, e);
                    break;
                case Keys.D1:
                    oneButton_Click(sender, e);
                    break;
                case Keys.D2:
                    twoButton_Click(sender, e);
                    break;
                case Keys.D3:
                    threeButton_Click(sender, e);
                    break;
                case Keys.D4:
                    fourButton_Click(sender, e);
                    break;
                case Keys.D5:
                    fiveButton_Click(sender, e);
                    break;
                case Keys.D6:
                    sixButton_Click(sender, e);
                    break;
                case Keys.D7:
                    sevenButton_Click(sender, e);
                    break;
                case Keys.D8:
                    eightButton_Click(sender, e);
                    break;
                case Keys.D9:
                    nineButton_Click(sender, e);
                    break;
                case Keys.Decimal:
                    floatButton_Click(sender, e);
                    break;
                case Keys.NumPad0:
                    zeroButton_Click(sender, e);
                    break;
                case Keys.NumPad1:
                    oneButton_Click(sender, e);
                    break;
                case Keys.NumPad2:
                    twoButton_Click(sender, e);
                    break;
                case Keys.NumPad3:
                    threeButton_Click(sender, e);
                    break;
                case Keys.NumPad4:
                    fourButton_Click(sender, e);
                    break;
                case Keys.NumPad5:
                    fiveButton_Click(sender, e);
                    break;
                case Keys.NumPad6:
                    sixButton_Click(sender, e);
                    break;
                case Keys.NumPad7:
                    sevenButton_Click(sender, e);
                    break;
                case Keys.NumPad8:
                    eightButton_Click(sender, e);
                    break;
                case Keys.NumPad9:
                    nineButton_Click(sender, e);
                    break;
                case Keys.Add:
                    addButton_Click(sender, e);
                    break;
                case Keys.Subtract:
                    minusButton_Click(sender, e);
                    break;
                case Keys.Multiply:
                    multiplyButton_Click(sender, e);
                    break;
                case Keys.Divide:
                    divideButton_Click(sender, e);
                    break;
                case Keys.Enter:
                    resultButton_Click(sender, e);
                    e.Handled = true;
                    break;
                case Keys.Back:
                    deleteButton_Click(sender, e);
                    break;
                case Keys.Delete:
                    clearButton_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        //Methods for handling click events
        private void oneButton_Click(object sender, EventArgs e)
        {
            number += "1";
            numberTextBox.Text = number;
            addChar('1');
            this.resultButton.Select();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            number += "2";
            numberTextBox.Text = number;
            addChar('2');
            this.resultButton.Select();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            number += "3";
            numberTextBox.Text = number;
            addChar('3');
            this.resultButton.Select();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            number += "4";
            numberTextBox.Text = number;
            addChar('4');
            this.resultButton.Select();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            number += "5";
            numberTextBox.Text = number;
            addChar('5');
            this.resultButton.Select();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            number += "6";
            numberTextBox.Text = number;
            addChar('6');
            this.resultButton.Select();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            number += "7";
            numberTextBox.Text = number;
            addChar('7');
            this.resultButton.Select();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            number += "8";
            numberTextBox.Text = number;
            addChar('8');
            this.resultButton.Select();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            number += "9";
            numberTextBox.Text = number;
            addChar('9');
            this.resultButton.Select();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            number += "0";
            numberTextBox.Text = number;
            addChar('0');
            this.resultButton.Select();
        }

        private void floatButton_Click(object sender, EventArgs e)
        {
            if (!isFloat)
            {
                isFloat = true;
                number += ".";
                numberTextBox.Text = number;
                addChar('.');
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (number.Length == 0)
            {
                list.Clear();
                historyBox.Text = string.Join("", list.ToArray());
                return;
            }
            number = number.Remove(number.Length - 1);
            numberTextBox.Text = number;
            list.RemoveAt(list.Count - 1);
            historyBox.Text = string.Join("", list.ToArray());
            this.resultButton.Select();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            number = "";
            numberTextBox.Text = number;
            list.Clear();
            historyBox.Text = string.Join("", list.ToArray());
            numberList.Clear();
            operationList.Clear();
            isFloat = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (number == "")
            {
                numberList.Add(0);
                operationList.Add('+');
                numberTextBox.Text = number;
                addChar('0');
                addChar('+');
                isFloat = false;
            }
            else
            {
                try
                {
                    numberList.Add(double.Parse(number));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert a corect value!");
                }
                operationList.Add('+');
                number = "";
                numberTextBox.Text = number;
                addChar('+');
                isFloat = false;
            }
            this.resultButton.Select();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (number == "")
            {
                numberList.Add(0);
                operationList.Add('-');
                numberTextBox.Text = number;
                addChar('0');
                addChar('-');
                isFloat = false;
            }
            else
            {
                try
                {
                    numberList.Add(double.Parse(number));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert a corect value!");
                }
                operationList.Add('-');
                number = "";
                numberTextBox.Text = number;
                addChar('-');
                isFloat = false;
            }
            this.resultButton.Select();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (number == "")
            {
                numberList.Add(1);
                operationList.Add('*');
                numberTextBox.Text = number;
                addChar('1');
                addChar('*');
                isFloat = false;
            }
            else
            {
                try
                {
                    numberList.Add(double.Parse(number));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert a corect value!");
                }
                operationList.Add('*');
                number = "";
                numberTextBox.Text = number;
                addChar('*');
                isFloat = false;
            }
            this.resultButton.Select();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (number == "")
            {
                numberList.Add(0);
                operationList.Add('/');
                numberTextBox.Text = number;
                addChar('0');
                addChar('/');
                isFloat = false;
            }
            else
            {
                try
                {
                    numberList.Add(double.Parse(number));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert a corect value!");
                }
                operationList.Add('/');
                number = "";
                numberTextBox.Text = number;
                addChar('/');
                isFloat = false;
            }
            this.resultButton.Select();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (number != "")
            {
                clicked = true;
                try
                {
                    numberList.Add(double.Parse(number));

                    double result = numberList[0];
                    for (int i = 0; i < operationList.Count; i++)
                    {
                        switch (operationList[i])
                        {
                            case '+':
                                result += numberList[i + 1];
                                break;
                            case '-':
                                result -= numberList[i + 1];
                                break;
                            case '*':
                                result *= numberList[i + 1];
                                break;
                            case '/':
                                result /= numberList[i + 1];
                                break;
                        }
                    }

                    if (result.Equals(Double.NaN))
                    {
                        numberTextBox.Text = "Not defined operation!";
                    }
                    else
                    {

                        numberTextBox.Text = result.ToString();
                        list.Clear();
                        list.AddRange(result.ToString());
                        numberList.Clear();
                        operationList.Clear();
                    }
                    number = "";

                    if (clicked)
                    {
                        number = result.ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert a corect value!");
                    number = "";
                    numberTextBox.Text = number;
                    list.Clear();
                    number = "";
                    numberTextBox.Text = number;
                    list.Clear();
                    historyBox.Text = string.Join("", list.ToArray());
                }
                isFloat = false;
            }
        }

            private void Calculator_Load(object sender, EventArgs e)
            {

            }
        }
    }
