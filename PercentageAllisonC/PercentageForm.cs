/*
 * Created by: Allison Cook
 * Created on: 25 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Percentage Program
 * This program shows the user what percent their level mark is
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercentageAllisonC
{
    public partial class frmPercentage : Form
    {
        public frmPercentage()
        {
            InitializeComponent();
        }

        private int ConvertToPercent(string level)
        {
            //decalring variable 
            int percent;

            //checking which level the user input
            switch (level)
            {
                case "4++":
                    percent = 98;
                    break;
                case "4+":
                    percent = 95;
                    break;
                case "4":
                    percent = 87;
                    break;
                case "4-":
                    percent = 83;
                    break;
                case "3+":
                    percent = 78;
                    break;
                case "3":
                    percent = 75;
                    break;
                case "3-":
                    percent = 72;
                    break;
                case "2+":
                    percent = 68;
                    break;
                case "2":
                    percent = 65;
                    break;
                case "2-":
                    percent = 62;
                    break;
                case "1+":
                    percent = 58;
                    break;
                case "1":
                    percent = 55;
                    break;
                case "1-":
                    percent = 52;
                    break;
                case "0+":
                    percent = 45;
                    break;
                case "0":
                    percent = 40;
                    break;
                case "0-":
                    percent = 35;
                    break;
                case "0--":
                    percent = 30;
                    break;
                case "0---":
                    percent = 20;
                    break;
                case "0----":
                    percent = 10;
                    break;
                default:
                    percent = -1;
                        break;
            }

            //retruning percent to the function
            return percent; 
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //decalre variables 
            string level;
            int percent;

            //thaking user input
            level = txtLevel.Text;

            //calling the function to convert the level to percent
            percent = ConvertToPercent(level);

            //checking if they inputed the right level
            if (percent == -1)
            {
                //display error message
                MessageBox.Show("Please enter a level", "Percentage program");
            }
            else
            {
                //display a message showing the percentage the level is worth
                MessageBox.Show("Level " + level + " is equivalent to " + percent + " %", "Percentage Program");
            }

        }
    }
}
