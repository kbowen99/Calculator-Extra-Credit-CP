using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class frm_Calc : Form
    {
        double Currentnumber = 0.0;
        int operation = 0;
        //1=plus
        //2=minus
        //3=multiply
        //4=divide
        double working = 0.0;
        string sworking = "";
        double multiplier = 0;
        double mult = 1;
        double answer = 0;
        public frm_Calc()
        {
            InitializeComponent();
            txt_Calc.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            working = (working * 10) + 1;
            sworking = sworking + "1";
            txt_Calc.Text = sworking;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation = 1;
            Currentnumber = working;
            working = 0;
            sworking = " ";
            txt_Calc.Text = " ";
            btn_Multiply.Visible = false;
            btn_division.Visible = false;
            btn_Minus.Visible = false;
            btn_plus.Visible = false;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (working == 88224646)
            {
                sworking = "The Konami Code Has Been Released";
                txt_Calc.Text = "The Konami Code Has Been Released";
                Pic_Matrix.Visible = true;
            }
            else
            {
                operation = 0;
                Currentnumber = 0;
                working = 0;
                sworking = " ";
                txt_Calc.Text = " ";
                btn_Multiply.Visible = true;
                btn_division.Visible = true;
                btn_Minus.Visible = true;
                btn_plus.Visible = true;
            }
  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            working = working + 1;
            sworking = working.ToString();
            txt_Calc.Text = working.ToString();
        }

        private void txt_Calc_TextChanged(object sender, EventArgs e)
        {
            txt_Calc.Text = sworking;
            if (answer == 9001){
                sworking = "ANSWER IS OVER 9000";
                txt_Calc.Text = "ANSWER IS OVER 9000";
                answer = 0;
            }
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            working = (working * 10) + 2;
            sworking = sworking + "2";
            txt_Calc.Text = sworking;
 
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            working = (working * 10) + 3;
            sworking = sworking + "3";
            txt_Calc.Text = sworking;
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            working = (working * 10) + 4;
            sworking = sworking + "4";
            txt_Calc.Text = sworking;
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            working = (working * 10) + 5;
            sworking = sworking + "5";
            txt_Calc.Text = sworking;
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            working = (working * 10) + 6;
            sworking = sworking + "6";
            txt_Calc.Text = sworking;
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            working = (working * 10) + 7;
            sworking = sworking + "7";
            txt_Calc.Text = sworking;
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            working = (working * 10) + 8;
            sworking = sworking + "8";
            txt_Calc.Text = sworking;
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            working = (working * 10) + 9;
            sworking = sworking + "9";
            txt_Calc.Text = sworking;
        }

        private void btn_num0_Click(object sender, EventArgs e)
        {
            working = (working * 10);
            sworking = sworking + "0";
            txt_Calc.Text = sworking;
        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
            if (operation == 1)
            {
                //MessageBox.Show(" " + (Currentnumber + working));
                answer = Currentnumber + working;
                sworking = answer.ToString();
                txt_Calc.Text = sworking;
                operation = 0;
                working = answer;
                btn_Multiply.Visible = true;
                btn_division.Visible = true;
                btn_Minus.Visible = true;
                btn_plus.Visible = true;
            }
            else if (operation == 2)
            {
                answer = Currentnumber - working;
                sworking = answer.ToString();
                txt_Calc.Text = sworking;
                operation = 0;
                working = answer;
                btn_Multiply.Visible = true;
                btn_division.Visible = true;
                btn_Minus.Visible = true;
                btn_plus.Visible = true;
            }
            else if (operation == 3)
            {
                answer = Currentnumber * working;
                sworking = answer.ToString();
                txt_Calc.Text = sworking;
                operation = 0;
                working = answer;
                btn_Multiply.Visible = true;
                btn_division.Visible = true;
                btn_Minus.Visible = true;
                btn_plus.Visible = true;
            }
            else if (operation == 4)
            {
                answer = Currentnumber / working;
                sworking = answer.ToString();
                txt_Calc.Text = sworking;
                operation = 0;
                working = answer;
                btn_Multiply.Visible = true;
                btn_division.Visible = true;
                btn_Minus.Visible = true;
                btn_plus.Visible = true;
            }


            
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            operation = 2;
            Currentnumber = working;
            working = 0;
            sworking = " ";
            txt_Calc.Text = " ";
            btn_Multiply.Visible = false;
            btn_division.Visible = false;
            btn_Minus.Visible = false;
            btn_plus.Visible = false;
        }

        private void btn_minus1_Click(object sender, EventArgs e)
        {
            working = working - 1;
            sworking = working.ToString();
            txt_Calc.Text = working.ToString();
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            operation = 3;
            Currentnumber = working;
            working = 0;
            sworking = " ";
            txt_Calc.Text = " ";
            btn_Multiply.Visible = false;
            btn_division.Visible = false;
            btn_Minus.Visible = false;
            btn_plus.Visible = false;
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            operation = 4;
            Currentnumber = working;
            working = 0;
            sworking = " ";
            txt_Calc.Text = " ";
            btn_Multiply.Visible = false;
            btn_division.Visible = false;
            btn_Minus.Visible = false;
            btn_plus.Visible = false;
        }

        private void btn_pwr_Click(object sender, EventArgs e)
        {
            btn_allClear.Visible = true;
            btn_division.Visible = true;
            btn_Equals.Visible = true;
            btn_Minus.Visible = true;
            btn_minus1.Visible = true;
            btn_Multiply.Visible = true;
            btn_num0.Visible = true;
            btn_num1.Visible = true;
            btn_num2.Visible = true;
            btn_num3.Visible = true;
            btn_num4.Visible = true;
            btn_num5.Visible = true;
            btn_num6.Visible = true;
            btn_num7.Visible = true;
            btn_num8.Visible = true;
            btn_num9.Visible = true;
            btn_plus.Visible = true;
            btn_plus1.Visible = true;
            if (btn_allClear.Visible == true)
            {
                //this.exit;
            }
        }
        
    }
}
