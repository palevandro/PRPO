using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Set original value when click reset button
            enterTextBox.ResetText();
            resetButton.ResetText();
            //reset Radio Button ( Color)
            resetButton.ForeColor = Color.Black;
            radioButtonAuto.Checked = false;
            radioButtonBlue.Checked = false;
            radioButtonGreen.Checked = false;
            radioButtonRed.Checked = false;
            //reset CheckBox Button (Type)
            checkBoxItalic.Checked = false;
            checkBoxBold.Checked = false;
            checkBoxUnderline.Checked = false;
            checkBoxBoldAndItalic.Checked = false;

        }

        private void enterTextBox_TextChanged(object sender, EventArgs e)
        {
            resultTextBox.Text = enterTextBox.Text;
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            resultTextBox.ForeColor = Color.Red;           
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            resultTextBox.ForeColor = Color.Green;
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            resultTextBox.ForeColor = Color.Blue;
        }

        private void radioButtonAuto_CheckedChanged(object sender, EventArgs e)
        {
            Random color = new Random();
            resultTextBox.ForeColor = Color.FromArgb(color.Next(255),  color.Next(255),  color.Next(255) );
        }

        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBold.Checked == true)
                resultTextBox.Font = new Font(resultTextBox.Font, FontStyle.Bold);
            else
                resultTextBox.Font = new Font(resultTextBox.Font, FontStyle.Regular);
        }

        private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxItalic.Checked == true)                
            {
                resultTextBox.Font = new Font(resultTextBox.Font, FontStyle.Italic);
            } 
            else
            {
                resultTextBox.Font = new Font(resultTextBox.Font, FontStyle.Regular);
            }
        }

        private void checkBoxUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnderline.Checked == true)
            {
                resultTextBox.Font = new Font(resultTextBox.Font, FontStyle.Underline);
            } 
            else
            {
                resultTextBox.Font = new Font(resultTextBox.Font, FontStyle.Regular);
            }
        }

        private void checkBoxBoldAndItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBoldAndItalic.Checked == true)
            {
                resultTextBox.Font = new Font(resultTextBox.Font, FontStyle.Bold | FontStyle.Italic);
            } 
            else
            {
                resultTextBox.Font = new Font(resultTextBox.Font, FontStyle.Regular);
            }
        }



    }
}
