using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Genrate_Keys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random rnd = new Random();
        int NumbersOfDigits = 0;
        int NumberOfKeys = 1;

        enum enCharType
        {
            SmallLetter = 1,
            CapitalLetter = 2,
            NumberChar = 3,
            SymbolsChar = 4,
            MixChar = 5,
        }
       
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        int RandomNumber(int From, int To)
        {
            // Generate a random number between 0 and (To - From), then add From to shift the range.
            int randNum = rnd.Next() % (To - From + 1) + From;
            return randNum;
        }

        void GetRadiobtnChecked()
        {
            if (rbLetters1.Checked)
            {
                if (rbLetters1.Text == "Letters" || rbLetters1.Text == "Small Letter")
                    GenerateAllKeys(enCharType.SmallLetter);
                else
                    GenerateAllKeys(enCharType.CapitalLetter);
            }
            else if (rbNumbers.Checked)
            {
                GenerateAllKeys(enCharType.NumberChar);
            }
            else if (rbSymbols.Checked)
            {
                GenerateAllKeys(enCharType.SymbolsChar);
            }
            else
            {
                GenerateAllKeys(enCharType.MixChar);
            }
        }
        string[] GenerateWord(enCharType CharType)
        {
            string[] TabWord = new string[NumberOfKeys];
            string Word = "";  // Initialize an empty string to build the word.

            // Loop for the number of characters specified by Length
            for (int i = 1; i <= NumberOfKeys; i++)
            {
                for (int j = 1; j <= NumbersOfDigits; j++)
                {
                    // Append a random character of the specified type to the word.
                    Word += GetRandomCharacter(CharType);
                    
                }
                TabWord[i - 1] = Word;
                Word = "";

            }

            return TabWord;
        }
        void GenerateAllKeys(enCharType CharType)
        {
            string[] GetAllWord = new string[NumberOfKeys];
            GetAllWord = GenerateWord(CharType);
            // string OneKey = "";
          
            for (int i = 1; i <= NumberOfKeys; i++)
            {
                tbResult.Text += "Key[" + i + "] : " + GetAllWord[i - 1] + "\n";
                
                
                
            }
                   
        }

        char GetRandomCharacter(enCharType CharType)
        {
            switch (CharType)
            {
                case enCharType.SmallLetter:
                    {
                        // Generate a random lowercase letter (ASCII: 97 'a' to 122 'z').
                        return (char)RandomNumber(97, 122);
                        // break is not necessary after return.
                    }
                case enCharType.CapitalLetter:
                    {
                        // Generate a random uppercase letter (ASCII: 65 'A' to 90 'Z').
                        return (char)RandomNumber(65, 90);

                    }
                case enCharType.NumberChar:
                    {
                        // Generate a random special character (ASCII: 33 '!' to 47 '/').
                        return (char)RandomNumber(48, 57);

                    }
                case enCharType.SymbolsChar:
                    {
                        // Generate a random special character (ASCII: 33 '!' to 47 '/').
                        return (char)RandomNumber(33, 47);

                    }
                case enCharType.MixChar:
                    {
                        // Generate a random digit (ASCII: 48 '0' to 57 '9').
                        // pas fair encore
                        return (char)RandomNumber(33, 122);
                        // char(RandomNumber(48, 57));
                        // break;
                    }
            }
            // If no valid type is provided, return a null character.
            return '\0';
        }
      

        private void majsculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbLetters1.Text = "Small Letter";


        }

        private void minusculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbLetters1.Text = "Capital Letter";
        }

      

      
        private void tbNumberOfDigits_TextChanged(object sender, EventArgs e)
        {

        }
        void RadioChecked(RadioButton rbBtn)
        {
            if (rbBtn.Checked)
                rbBtn.Checked = false;
        }
       

       
        private void tbResult_Validating(object sender, CancelEventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbResult.Text);

            MessageBox.Show("That text has been Copid", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rbLetters_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmResult_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            GetRadiobtnChecked();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            tbResult.Text = string.Empty;
            tbNumberOfDigits.Text = string.Empty;
            tbNumberOfKeys.Text = string.Empty;


            RadioChecked(rbLetters1);
            RadioChecked(rbNumbers);
            RadioChecked(rbSymbols);
            RadioChecked(rbMix);
        }

        private void btnOption_Click_1(object sender, EventArgs e)
        {
            tbResult.Visible = true;
            groupBox1.Visible = true;
            btnGenerate.Visible = true;
            btnReset.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbNumberOfDigits_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbNumberOfDigits.Text, out NumbersOfDigits) || NumbersOfDigits <= 0)
            {
                e.Cancel = true;
                tbNumberOfDigits.Focus();
                errorProvider1.SetError(tbNumberOfDigits, "Please Enter Number a Positive");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNumberOfDigits, "");


            }
        }

        private void tbNumberOfKeys_Validating(object sender, CancelEventArgs e)
        {

            if (!int.TryParse(tbNumberOfKeys.Text, out NumberOfKeys) || NumberOfKeys <= 0)
            {
                e.Cancel = true;
                tbNumberOfKeys.Focus();
                errorProvider2.SetError(tbNumberOfKeys, "Please Enter Number a Positive");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(tbNumberOfKeys, "");


            }
        }

    }
}
