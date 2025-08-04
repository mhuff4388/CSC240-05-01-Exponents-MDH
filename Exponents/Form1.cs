using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:Matthew D. Huff
 * Date: 8/3/2025
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int input;
            int squared;
            int cubed;

            // INPUT
            input = int.Parse(txtInput.Text);

            // PROCESS
            squared = Square(input);
            cubed = Cube(input);    

            // OUTPUT
            lblOutput.Text = $"Squared: {squared}\nCubed: {cubed}"; 
            lblOutput.Visible = true ;
        }

        public int Square(int num)
        {
            return num * num;
        }

        public int Cube(int num)
        {
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            // turn the output to invisible
            // turn the Go button back on
        }

    }
}
