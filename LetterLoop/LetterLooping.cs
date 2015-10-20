// Andrew MacKinnon
// October 20 2015
// ISC3UR
// It shows all letters of the alphabet, lowwer and upper case.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterLoop
{
    public partial class frmLetterLooping : Form
    {
        public frmLetterLooping()
        {
            InitializeComponent();
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            // variables
            int firstNumber;
            int secondNumber;
            // clear listbox
            this.lstLetterBox.Items.Clear();

            for (firstNumber = 65; firstNumber <= 90; firstNumber++)
            {
               
                for (secondNumber = 97; secondNumber <= 122; secondNumber++)
                {
                    
                   this.lstLetterBox.Items.Add(Char.ConvertFromUtf32(firstNumber) + " -> " + Char.ConvertFromUtf32(secondNumber));
                }
            }
        }
    }
}
