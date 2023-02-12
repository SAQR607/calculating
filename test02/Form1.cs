using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test02
{
    public partial class Form1 : Form
    {

        double num1,num2,result;
        string pro;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pro_click(object sender, EventArgs e)
        {
            Button btn = (Button) sender ;
            num1 = double.Parse(label5.Text);
            pro = btn.Text;
            if(label4.Text!= "")
            {
                label4.Text = label4.Text + pro;
            }
            else
            {
                label4.Text = label5.Text + pro;


            }
            //label4.Text = label4.Text + pro;
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(label5.Text);
            if (pro == "+")
            {
                result = num1 + num2;
                label5.Text = result.ToString();
            }
          else if (pro == "-")
            {
                result = num1 - num2;
                label5.Text = result.ToString();
            }
            else if (pro == "*")
            {
                result = num1 * num2;
                label5.Text = result.ToString();
            }
            else if (pro == "/")
            {
                result = num1 / num2;
                label5.Text = result.ToString();
            }
            label4.Text = "";
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            label5.Text = "0";
            label4.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttons4_Click(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(label5.Text=="0")
            {
                label5.Text="";
                label5.Text = label5.Text + btn.Text;
                
            }
           else
            {
                label5.Text = label5.Text + btn.Text;
                
            }
            if (label5.Text != "")
            {
                label4.Text = label4.Text + btn.Text;
            }
            else
            {
                label4.Text = label5.Text;
            }
        }
    }
}
