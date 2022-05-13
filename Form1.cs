using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private float ans;
        private float sum;
        private string num = "";
        private int flag = 0;
        private int length;
        private float last_num;

        private List<List<float>> calculationList = new List<List<float>>();
        private List<int> flagList = new List<int>();

        public Form1()
        {
            InitializeComponent();
            calculationList.Add(new List<float>());
            flagList.Add(0);
        }

        private void flag_operation(float new_num)
        {
            if (flag != 0)
            {
                length = calculationList[calculationList.Count - 1].Count;
                last_num = calculationList[calculationList.Count - 1][length - 1];
            }

            switch (flag)
            {
                case 0:
                    calculationList[calculationList.Count - 1].Add(new_num);
                    break;
                case 1:
                    calculationList[calculationList.Count - 1][length - 1] = last_num * new_num;
                    break;
                case 2:
                    calculationList[calculationList.Count - 1][length - 1] = last_num / new_num;
                    break;
                    
            }
            flag = 0;
        }

        #region Implementation of number button
        
        private void button10_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 3; 
            num = num + 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 6;
            num = num + 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 9;
            num = num + 9;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 0 + 0;
            num = num + 0 + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 7;
            num = num + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 8;
            num = num + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 5;
            num = num + 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 4;
            num = num + 4;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 0;
            num = num + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 2;
            num = num + 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            textBox1.Text = textBox1.Text + 1;
            num = num + 1;
        }
        
        
        private void button14_Click(object sender, EventArgs e)
        {
            if (!num.Contains("."))  
            {  
                textBox1.Text = textBox1.Text + ".";  
                num = num + ".";
            }
        }
        
        #endregion
        
        private void button17_Click(object sender, EventArgs e) //-
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0)
            {
                calculationList[0].Add(ans);
                textBox1.Text = ans.ToString();
            }
            if (num.Length>0) flag_operation(float.Parse(num));
            textBox1.Text = textBox1.Text + "-";
            num = "-";
        }

        private void button13_Click(object sender, EventArgs e) //+
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0)
            {
                calculationList[0].Add(ans);
                textBox1.Text = ans.ToString();
            }
            if (num.Length>0) flag_operation(float.Parse(num));
            textBox1.Text = textBox1.Text + "+";
            num = "";
        }

        private void button9_Click(object sender, EventArgs e) //*
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0)
            {
                calculationList[0].Add(ans);
                textBox1.Text = ans.ToString();
            }
            if (num.Length>0) flag_operation(float.Parse(num));
            textBox1.Text = textBox1.Text + "*";
            num = "";
            flag = 1;
        }
        
        private void button5_Click(object sender, EventArgs e) // /
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0)
            {
                calculationList[0].Add(ans);
                textBox1.Text = ans.ToString();
            }
            if (num.Length>0) flag_operation(float.Parse(num));
            textBox1.Text = textBox1.Text + "/";
            num = "";
            flag = 2;
        }

        private void button19_Click(object sender, EventArgs e) //(
        {
            if (num.Length == 0 && calculationList.Count == 1 && calculationList[0].Count == 0) textBox1.Clear();
            calculationList.Add(new List<float>());
            textBox1.Text = textBox1.Text + "(";
            flagList.Add(flag);
            flag = 0;
        }
        
        private void button18_Click(object sender, EventArgs e) //)
        {
            if (calculationList.Count > 0)
            {
                if (num.Length > 0) flag_operation(float.Parse(num));

                sum = calculationList[calculationList.Count - 1].Sum();
                calculationList.RemoveAt(calculationList.Count - 1);

                flag = flagList[flagList.Count - 1];
                flagList.RemoveAt(flagList.Count - 1);

                flag_operation(sum);
                textBox1.Text = textBox1.Text + ")";
                num = "";
            }
        }
        
        private void button20_Click(object sender, EventArgs e)
        {
            if (calculationList.Count == 1)
            {
                if (num.Length>0) flag_operation(float.Parse(num));

                ans = calculationList[0].Sum();
                textBox1.Text = "=" + ans;
                num = "";
                calculationList.Clear();
                calculationList.Add(new List<float>());
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();  
            calculationList.Clear();
            calculationList.Add(new List<float>());
            flagList.Clear();
            flagList.Add(0);
            num = "";
        }
    }
}