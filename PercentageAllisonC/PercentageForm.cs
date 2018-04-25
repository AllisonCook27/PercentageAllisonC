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

            //display a message showing the percentage the level is worth
            MessageBox.Show("Level " + level + " is equivalent to " + percent, "Percentage Program");

        }
    }
}
