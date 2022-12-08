using System;
using System.IO;
using System.Windows.Forms;

namespace GreetingInABox
{
    public partial class FormGreeting : Form
    {
        public FormGreeting()
        {
            InitializeComponent();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\greeting.txt";
            StreamReader streamReader = new StreamReader(path);

            int leftMargin = Convert.ToInt32(streamReader.ReadLine());
            int blankSpaces = Convert.ToInt32(streamReader.ReadLine());
            string character = streamReader.ReadLine();
            string name = streamReader.ReadLine();

            TxtResult.Text += DisplayGreeting(leftMargin, blankSpaces, character, name);

        }

        private string DisplayGreeting(int leftMargin, int blankSpaces, string character, string name)
        {
            string spaces = "                                        ";
            string result = "";
            string greeting = "Hello there, " + name + "!";
            int boxHeight = 1 + blankSpaces + 1 + blankSpaces + 1;

            result += "123456789012345678901234567890123456789012345678901234567890123456" + Environment.NewLine;

            //We itterate for each roll.
            for (int i = 1; i <= boxHeight; i++)
            {
                //If it's the first or the last row, display row of characters.
                if (i == 1 || i == boxHeight)
                {
                    result += spaces.Substring(0, leftMargin);
                    for (int a = 1; a <= greeting.Length + blankSpaces * 2 + 2; a++)
                    {
                        result += character;
                    }
                    result += Environment.NewLine;
                }
                //If it's between the first row and the row with the greeting,
                //and if it's between the row with the greeting and the last row,
                //we display the below.
                else if (i > 1 && i <= blankSpaces + 1 || i > boxHeight / 2 + 1 && i < boxHeight)
                {
                    result += spaces.Substring(0, leftMargin);
                    result += character;
                    result += spaces.Substring(0, greeting.Length + blankSpaces * 2);
                    result += character;
                    result += Environment.NewLine;
                }
                //Display the row with the greeting.
                else
                {
                    result += spaces.Substring(0, leftMargin);
                    result += character;
                    result += spaces.Substring(0, blankSpaces);
                    result += greeting;
                    result += spaces.Substring(0, blankSpaces);
                    result += character;
                    result += Environment.NewLine;
                }

                result += Environment.NewLine;
            }

            return result;
        }
    }
}
