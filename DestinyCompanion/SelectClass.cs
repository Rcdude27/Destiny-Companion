using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace DestinyCompanion
{



    public partial class SelectClass : Form
    {

        #region GlobalVars
        public string Class = "";
        public string charPathIn = Path.Combine(Path.GetTempPath(), "");
        public string pubCharName = "";
        public int pubCharLevel;
        public double pubCharLightLevel;
        public string pubChar1Name = "";
        public string pubChar2Name = "";
        public string pubChar3Name = "";
        public int Char1Level;
        public int Char2Level;
        public int Char3Level;
        public double Char1LightLevel;
        public double Char2LightLevel;
        public double Char3LightLevel;
        public string Char1Path = Path.Combine(Path.GetTempPath() + "\\DCData", "Char1.txt");
        public string Char2Path = Path.Combine(Path.GetTempPath() + "\\DCData", "Char2.txt");
        public string Char3Path = Path.Combine(Path.GetTempPath() + "\\DCData", "Char3.txt");
        public bool Char1Found = false;
        public bool Char2Found = false;
        public bool Char3Found = false;
        public string Subclass1 = "";
        public string Subclass2 = "";
        public string Subclass3 = "";
        public int counter = 0;
        #endregion
        public SelectClass()
        {
            InitializeComponent();
        }
        private void SelectClass_Load(object sender, EventArgs e)
        {

            Class = "";

            if (File.Exists(Char1Path) && File.Exists(Char2Path) && File.Exists(Char3Path))
            {
                MessageBox.Show("All slots are filled! You can only have a max of 3 characters.");
                Close();
                Close();
            }
        }

        #region Check which radiobutton is selected
        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (TitanRadio.Checked == true)
            {
                Class = "Titan";
                Subclass1 = "Striker";
                Subclass2 = "Sunbreaker";
                Subclass3 = "Defender";
                writeChar();
            }
            if (WarlockRadio.Checked == true)
            {
                Class = "Warlock";
                Subclass1 = "VoidWalker";
                Subclass2 = "Sunsinger";
                Subclass3 = "Stormcaller";
                writeChar();
            }
            if (HunterRadio.Checked == true)
            {
                Class = "Hunter";
                Subclass1 = "Gunslinger";
                Subclass2 = "Bladedancer";
                Subclass3 = "Nightstalker";
                writeChar();
            }
        }
        #endregion

        public void writeChar()
        {
            AskCharName();
            AskCharLevel();
            AskCharLightLevel();
            FindFiles();
            WriteToFile();
        }
        public void FindFiles()
        {
            try
            {

                using (StreamReader sr = new StreamReader(Char1Path))
                {

                    string LineFound = sr.ReadLine();
                    if (LineFound != "")
                    {
                        Char1Found = true;
                    }


                }
            }
            catch (FileNotFoundException)
            {
                Char1Found = false;
            }
            try
            {

                using (StreamReader sr = new StreamReader(Char2Path))
                {
                    string LineFound = sr.ReadLine();
                    if (LineFound != "")
                    {
                        Char2Found = true;
                    }
                }
            }
            catch (FileNotFoundException)
            {

                Char2Found = false;
            }
            try
            {
                using (StreamReader sr = new StreamReader(Char3Path))
                {
                    string LineFound = sr.ReadLine();
                    if (LineFound != "")
                    {

                        Char3Found = true;
                    }

                }
            }
            catch (FileNotFoundException)
            {
                Char3Found = false;
            }
        }
        public void WriteToFile()
        {
            #region Writing to File based off of FindFiles()
            if (Char1Found == false && Char2Found == false && Char3Found == false)
            {

                using (StreamWriter sw = File.CreateText(Char1Path))
                {
                    pubChar1Name = pubCharName;
                    sw.WriteLine("Name: " + pubChar1Name);
                    sw.WriteLine("Class: " + Class);
                    sw.WriteLine("Level: " + pubCharLevel);
                    sw.WriteLine("Light Level: " + pubCharLightLevel);
                    sw.WriteLine("1." + Subclass1);
                    sw.WriteLine("2." + Subclass2);
                    sw.WriteLine("3." + Subclass3);

                    Close();
                }
            }
            if (Char1Found == true && Char2Found == false && Char3Found == false)
            {

                using (StreamWriter sw = File.CreateText(Char2Path))
                {
                    pubChar2Name = pubCharName;
                    sw.WriteLine("Name: " + pubChar2Name);
                    sw.WriteLine("Class: " + Class);
                    sw.WriteLine("Level: " + pubCharLevel);
                    sw.WriteLine("Light Level: " + pubCharLightLevel);
                    sw.WriteLine("1." + Subclass1);
                    sw.WriteLine("2." + Subclass2);
                    sw.WriteLine("3." + Subclass3);

                    Close();
                }
            }
            if (Char1Found == true && Char2Found == true && Char3Found == false)
            {

                using (StreamWriter sw = File.CreateText(Char3Path))
                {
                    pubChar3Name = pubCharName;
                    sw.WriteLine("Name: " + pubChar3Name);
                    sw.WriteLine("Class: " + Class);
                    sw.WriteLine("Level: " + pubCharLevel);
                    sw.WriteLine("Light Level: " + pubCharLightLevel);
                    sw.WriteLine("1." + Subclass1);
                    sw.WriteLine("2." + Subclass2);
                    sw.WriteLine("3." + Subclass3);

                    Close();
                }
            }
            #endregion
        }
        public void AskCharName()
        {
            #region Asking for Character Name
            string emptystring = "";
            bool keepgoing = true;
            while (keepgoing == true)
            {
                string charName = Interaction.InputBox("What do you want to name your character?");
                emptystring = charName;

                if (emptystring == "")
                {
                    MessageBox.Show("Input Field cannot be empty.");
                    keepgoing = true;
                }
                else
                {
                    keepgoing = false;
                    pubCharName = charName;
                }
            }
            #endregion
        }
        public void AskCharLevel()
        {
            #region Level MAXIMUM: 40
            string emptystring = "";
            bool keepgoing = true;
            while (keepgoing == true)
            {
                string charLevel = Interaction.InputBox("What Level is this Character?");
                emptystring = charLevel;

                if (emptystring == "")
                {
                    MessageBox.Show("You either didn't enter anything or you entered a letter.");
                    keepgoing = true;
                }
                else
                {

                    pubCharLevel = int.Parse(charLevel);

                    if (pubCharLevel > 40)
                    {
                        MessageBox.Show("Maximum Level is 40!");
                        keepgoing = true;
                    }
                    if (pubCharLevel < 1)
                    {
                        MessageBox.Show("Minimum Level is 1!");
                        keepgoing = true;
                    }
                    if(pubCharLevel >= 1 && pubCharLevel <= 40)
                    {
                        keepgoing = false;
                    }
                }
            }

            #endregion
        }
        public void AskCharLightLevel()
        {
            #region Light Level MAXIMUM: 400
            string emptystring = "";
            bool keepgoing = true;
            while (keepgoing == true)
            {
                string charLightLevel = Interaction.InputBox("What Light Level is this Character?");
                emptystring = charLightLevel;

                if (emptystring == "")
                {
                    MessageBox.Show("You either didn't enter anything or you entered a letter.");
                    keepgoing = true;
                }
                else
                {
                    pubCharLightLevel = double.Parse(charLightLevel);

                    if (pubCharLightLevel > 400)
                    {
                        MessageBox.Show("Maximum Light Level is 400!");
                        keepgoing = true;
                    }
                    if (pubCharLightLevel < 1)
                    {
                        MessageBox.Show("Minimum Light Level is 1!");
                        keepgoing = true;
                    }
                    if (pubCharLightLevel >= 1 && pubCharLightLevel <= 400)
                    {
                        keepgoing = false;
                    }
                }


            }
            #endregion
        }
        #region RadioButton Click Events
        private void TitanRadio_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                counter++;
            }
            else
            {
                HunterRadio.Checked = false;
                WarlockRadio.Checked = false;
                TitanRadio.Checked = true;
            }
        }

        private void WarlockRadio_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                counter++;
            }
            else
            {
                TitanRadio.Checked = false;
                HunterRadio.Checked = false;
                WarlockRadio.Checked = true;
            }
        }

        private void HunterRadio_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                counter++;
            }
            else
            {
                TitanRadio.Checked = false;
                WarlockRadio.Checked = false;
                HunterRadio.Checked = true;
            }
        }
        #endregion
    }


}


