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
        public string pubChar1Name = "";
        public string pubChar2Name = "";
        public string pubChar3Name = "";
        public string Char1Path = Path.Combine(Path.GetTempPath() + "\\DCData", "Char1.txt");
        public string Char2Path = Path.Combine(Path.GetTempPath() + "\\DCData", "Char2.txt");
        public string Char3Path = Path.Combine(Path.GetTempPath() + "\\DCData", "Char3.txt");
        public bool Char1Found = false;
        public bool Char2Found = false;
        public bool Char3Found = false;
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
                writeChar();
            }
            if (WarlockRadio.Checked == true)
            {
                Class = "Warlock";
                writeChar();
            }
            if (HunterRadio.Checked == true)
            {
                Class = "Hunter";
                writeChar();
            }
        }
        #endregion
        #region Write Char File
        public void writeChar()
        {
            bool keepgoing1 = true;
            string emptystring = "";
            while (keepgoing1 == true)
            {
                #region Asking for Character Name
                string charName = Interaction.InputBox("What do you want to name your character?");
                emptystring = charName;
                pubCharName = charName;

                if (emptystring == "")
                {
                    MessageBox.Show("Input Field cannot be empty.");
                    keepgoing1 = true;
                }
                #endregion
                #region Finding which files have text in them.
                else
                {
                    keepgoing1 = false;
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
                #endregion
                #region Writing to File based off of try/catches above
                if (Char1Found == false && Char2Found == false && Char3Found == false)
                {

                    using (StreamWriter sw = File.CreateText(Char1Path))
                    {
                        pubChar1Name = pubCharName;
                        sw.WriteLine(pubChar1Name);
                        Close();
                    }
                }
                if (Char1Found == true && Char2Found == false && Char3Found == false)
                {

                    using (StreamWriter sw = File.CreateText(Char2Path))
                    {
                        pubChar2Name = pubCharName;
                        sw.WriteLine(pubChar2Name);
                        Close();
                    }
                }
                if (Char1Found == true && Char2Found == true && Char3Found == false)
                {

                    using (StreamWriter sw = File.CreateText(Char3Path))
                    {
                        pubChar3Name = pubCharName;
                        sw.WriteLine(pubChar3Name);
                        Close();
                    }
                }
                #endregion
            }
        }
        #endregion
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


