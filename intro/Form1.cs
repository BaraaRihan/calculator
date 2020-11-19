using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intro
{
    public partial class Form1 : Form
    {


        string first = ""; //store
        string second = "";
        char function;   //function we are using 
        double result = 0.0; //hold the result
        string USERINPUT = ""; //HOLD THE FIRST VALUE AND PASS IT TO THE SECOND STRING
        //keep traking..
        public Form1()
        {
            InitializeComponent();
        }


        private void Buttonzero_Click(object sender, EventArgs e)
        {


            CalDisplay.Text = ""; //To remove the the previous numbers come before
            USERINPUT += "0"; //to add and keep traking the prosses.
            CalDisplay.Text = CalDisplay.Text + USERINPUT;  //add to the display text the user input
        }
            private void Buttonone_Click(object sender, EventArgs e)
        {
            CalDisplay.Text = ""; //To remove the the previous numbers come before
            USERINPUT += "1";
            CalDisplay.Text += USERINPUT;
        }

        private void Buttontwo_Click(object sender, EventArgs e)
        {
            CalDisplay.Text = ""; //To remove the the previous numbers come before
            USERINPUT += "2";
            CalDisplay.Text = CalDisplay.Text + USERINPUT;
        }

        private void Buttonthree_Click(object sender, EventArgs e)
        {
            CalDisplay.Text = ""; //To remove the the previous numbers come before
            USERINPUT += "3";
            CalDisplay.Text = CalDisplay.Text + USERINPUT;
        }

        private void Buttonfour_Click(object sender, EventArgs e)
        {
            CalDisplay.Text = ""; //To remove the the previous numbers come before
            USERINPUT += "4";
            CalDisplay.Text = CalDisplay.Text + USERINPUT;
        }

        private void Buttonfive_Click(object sender, EventArgs e)
        {
            CalDisplay.Text = ""; //To remove the the previous numbers come before
            USERINPUT += "5";
            CalDisplay.Text = CalDisplay.Text + USERINPUT;
        }

        private void Buttonsix_Click(object sender, EventArgs e)
        {
            CalDisplay.Text = ""; //TTo remove the the previous numbers come before
            USERINPUT += "6";
            CalDisplay.Text = CalDisplay.Text + USERINPUT;
        }

        private void Buttonseven_Click(object sender, EventArgs e)
        {
            CalDisplay.Text = ""; //To remove the the previous numbers come before
            USERINPUT += "7";
            CalDisplay.Text = CalDisplay.Text + USERINPUT;
        }

        private void Buttoneight_Click(object sender, EventArgs e)
        {
            CalDisplay.Text = ""; //To remove the zero from continuting with numbers
            USERINPUT += "8";
            CalDisplay.Text = CalDisplay.Text + USERINPUT;
        }

        private void Buttonnine_Click(object sender, EventArgs e)
        {
            CalDisplay.Text = ""; //To remove the zero from continuting with numbers
            USERINPUT += "9";
            CalDisplay.Text = CalDisplay.Text + USERINPUT;
        }
        private void Buttundot_Click(object sender, EventArgs e)
        {
            CalDisplay.Text = CalDisplay.Text + USERINPUT;
            USERINPUT += ".";
        }

        private void Buttonequle_Click(object sender, EventArgs e)
        {
            second = USERINPUT;  // when the user is finsh to add on..
            Double firstnum, secondnum; //now those var are to convert it from string to integer..
            firstnum = Convert.ToDouble(first);  //converting from string to double ..
            secondnum = Convert.ToDouble(second);


            //sum
            if (function == '+')
            {
                result = firstnum + secondnum;
                CalDisplay.Text = result.ToString(); // showw on text and change it to string 
            }
            //sub
            else if (function == '-')
            {
                result = firstnum - secondnum;
                CalDisplay.Text = result.ToString(); // showw on text and change it to string
            }
            //mul
            else if (function == '*') 
            {
                result = firstnum * secondnum;
                CalDisplay.Text = result.ToString(); // showw on text and change it to string
            }
            //div
            else if (function=='/')
            {
                if (secondnum == '0')
                {
                    CalDisplay.Text = "lol try again habebe";
                }
                else
                {
                    result = firstnum / secondnum;
                    CalDisplay.Text = result.ToString(); // showw on text and change it to string
                }
            }

            
        }

        private void Buttonplus_Click(object sender, EventArgs e)
        {
            function = '+';
            first = USERINPUT;
            USERINPUT = "";
        }

        private void Buttonminse_Click(object sender, EventArgs e)
        {
            function = '-';
            first = USERINPUT;
            USERINPUT = "";
        }

        private void Button3la_Click(object sender, EventArgs e)
        {
            function = '/';
            first = USERINPUT;
            USERINPUT = "";
        }
        private void Buttonmul_Click(object sender, EventArgs e)
        {
            function = '*';
            first = USERINPUT;
            USERINPUT = "";
        }

        private void Buttonclear_Click(object sender, EventArgs e)
        {
            //clear every single shit
             
            first = "";
            second = "";
            USERINPUT = "";
            result = 0.0;
            CalDisplay.Text = "0"; //goes bk to zeroo
        }

        
    }
}
