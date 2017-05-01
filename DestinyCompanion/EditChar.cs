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
    public partial class EditChar : Form
    {
        #region Global Vars
        public string Char1Path = Path.Combine(Path.GetTempPath() + "\\DCData", "Char1.txt");
        public string Char2Path = Path.Combine(Path.GetTempPath() + "\\DCData", "Char2.txt");
        public string Char3Path = Path.Combine(Path.GetTempPath() + "\\DCData", "Char3.txt");
        public string publinetoedit = "";
        public bool ECChar1Found = false;
        public bool ECChar2Found = false;
        public bool ECChar3Found = false;
        public string CharName1 = "";
        public string CharName2 = "";
        public string CharName3 = "";
        public List<string> Char1Content = new List<string>();
        public List<string> Char2Content = new List<string>();
        public List<string> Char3Content = new List<string>();
        #endregion

        public EditChar()
        {
            InitializeComponent();
        }

        private void EditChar_Load(object sender, EventArgs e)
        {
            var mf = new MainForm();
            var dc = new DeleteChar();
            var sc = new SelectClass();

            #region Read Char Names
            try
            {
                using (StreamReader sr = new StreamReader(Char1Path))
                {
                    CharName1 = sr.ReadLine();
                    if (CharName1 != "")
                    {
                        ECChar1Found = true;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                ECChar1Found = false;
            }
            try
            {
                using (StreamReader sr = new StreamReader(Char2Path))
                {
                    CharName2 = sr.ReadLine();
                    if (CharName2 != "")
                    {
                        ECChar2Found = true;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                ECChar2Found = false;
            }
            try
            {
                using (StreamReader sr = new StreamReader(Char3Path))
                {
                    CharName3 = sr.ReadLine();
                    if (CharName3 != "")
                    {
                        ECChar3Found = true;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                ECChar3Found = false;
            }

            #endregion
            #region Logic for the label text
            if (sc.Char1Found == true)
            {
                CN1.Text = dc.CharName1;
            }
            if (sc.Char2Found == true)
            {
                CN2.Text = dc.CharName2;
            }
            if (sc.Char3Found == true)
            {
                CN3.Text = dc.CharName3;
            }
            #endregion
            #region Read Char Info
            if (ECChar1Found == true)
            {
                List<string> Content = new List<string>();
                using (StreamReader sr = new StreamReader(Char1Path))
                {
                    while (!sr.EndOfStream)
                    {
                        Content.Add(sr.ReadLine());
                    }
                }
                Char1Content = Content;

            }
            if (ECChar2Found == true)
            {
                List<string> Content = new List<string>();
                using (StreamReader sr = new StreamReader(Char2Path))
                {
                    while (!sr.EndOfStream)
                    {
                        Content.Add(sr.ReadLine());
                    }
                }
                Char2Content = Content;
            }
            if (ECChar3Found == true)
            {
                List<string> Content = new List<string>();
                using (StreamReader sr = new StreamReader(Char3Path))
                {
                    while (!sr.EndOfStream)
                    {
                        Content.Add(sr.ReadLine());
                    }
                }
                Char3Content = Content;
            }
            #endregion
            #region TextBox Stuff
            if (ECChar1Found == true)
            {
                CN1.Text = CharName1;
                int counter = 0;
                foreach (string item in Char1Content)
                {
                    counter++;
                    richTextBox1.Text += counter + ". " + item + Environment.NewLine;
                }
            }
            if (ECChar2Found == true)
            {
                CN2.Text = CharName2;
                int counter = 0;
                foreach (string item in Char2Content)
                {
                    richTextBox2.Text += counter + ". " + item + Environment.NewLine;
                }
            }
            if (ECChar3Found == true)
            {
                CN3.Text = CharName3;
                int counter = 0;
                foreach (string item in Char3Content)
                {
                    richTextBox3.Text += counter + ". " + item + Environment.NewLine;
                }
            }
            #endregion
        }

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        #region Update TextBox
        public void UpdateRTB1()
        {
                List<string> Content = new List<string>();
                using (StreamReader sr = new StreamReader(Char1Path))
                {
                    while (!sr.EndOfStream)
                    {
                        Content.Add(sr.ReadLine());
                    }
                }
                Char1Content = Content;

            int counter = 0;
            richTextBox1.Clear();
            foreach (string item in Char1Content)
            {
                counter++;
                richTextBox1.Text += counter + ". " + item + Environment.NewLine;
            }
        }
        public void UpdateRTB2()
        {
            List<string> Content = new List<string>();
            using (StreamReader sr = new StreamReader(Char2Path))
            {
                while (!sr.EndOfStream)
                {
                    Content.Add(sr.ReadLine());
                }
            }
            Char2Content = Content;

            int counter = 0;
            richTextBox2.Clear();
            foreach (string item in Char1Content)
            {
                counter++;
                richTextBox2.Text += counter + ". " + item + Environment.NewLine;
            }
        }
        public void UpdateRTB3()
        {
            List<string> Content = new List<string>();
            using (StreamReader sr = new StreamReader(Char3Path))
            {
                while (!sr.EndOfStream)
                {
                    Content.Add(sr.ReadLine());
                }
            }
            Char3Content = Content;

            int counter = 0;
            richTextBox3.Clear();
            foreach (string item in Char1Content)
            {
                counter++;
                richTextBox3.Text += counter + ". " + item + Environment.NewLine;
            }
        }
        #endregion
        #region Edit Button Click Event
        private void ECB1_Click(object sender, EventArgs e)
        {
            DialogResult EditChar1;
            EditChar1 = MessageBox.Show("Are you sure?", "Edit Character Slot 1?", MessageBoxButtons.YesNo);
            if (EditChar1 == DialogResult.Yes)
            {
                bool keepgoing = true;
                while (keepgoing == true)
                {
                    string emptyString = "";
                    string lineToEdit = Interaction.InputBox("What Line do you want to edit?", "Edit Line", emptyString);
                    emptyString = lineToEdit;
                    publinetoedit = lineToEdit;
                    if (emptyString == "")
                    {
                        MessageBox.Show("Input Field cannot be empty. Try again.", "Error", MessageBoxButtons.OK);
                        keepgoing = true;
                    }


                    else
                    {
       
                        double linedub = double.Parse(publinetoedit);
                        if (linedub == 1)
                        {

                            string emptystring = "";
                            string input = Interaction.InputBox("What is the name of your character?", "Character Name", emptystring);
                            lineChanger("Name: " + input, Char1Path, 1);
                            keepgoing = false;
                        }
                        if (linedub == 2)
                        {
                            MessageBox.Show("You cannot change what class you are.");
                            keepgoing = true;
                        }
                        if (linedub == 3)
                        {
                            string emptystring = "";
                            string input = Interaction.InputBox("What is the level of your character?", "Character Level", emptystring);
                            lineChanger("Level: " + input, Char1Path, 3);
                            keepgoing = false;
                        }
                        if (linedub == 4)
                        {
                            string emptystring = "";
                            string input = Interaction.InputBox("What is the light level of your character?", "Character Light Level", emptystring);
                            lineChanger("Light Level: " + input, Char1Path, 4);
                            keepgoing = false;
                        }
                        if (linedub >= 5 && linedub <= 7)
                        {
                            MessageBox.Show("You cannot change what subclasses you have.");
                            keepgoing = true;
                        }
                        if (linedub >= 8)
                        {
                            MessageBox.Show("Those lines do not exist!");
                            keepgoing = true;
                        }
                        UpdateRTB1();
                    }
                }
            }
        }
        private void ECB2_Click(object sender, EventArgs e)
        {
            DialogResult EditChar2;
            EditChar2 = MessageBox.Show("Are you sure?", "Edit Character Slot 2?", MessageBoxButtons.YesNo);
            if (EditChar2 == DialogResult.Yes)
            {
                bool keepgoing = true;
                while (keepgoing == true)
                {
                    string emptyString = "";
                    string lineToEdit = Interaction.InputBox("What Line do you want to edit?", "Edit Line", emptyString);
                    emptyString = lineToEdit;
                    publinetoedit = lineToEdit;
                    if (emptyString == "")
                    {
                        MessageBox.Show("Input Field cannot be empty. Try again.", "Error", MessageBoxButtons.OK);
                        keepgoing = true;
                    }


                    else
                    {

                        double linedub = double.Parse(publinetoedit);
                        if (linedub == 1)
                        {

                            string emptystring = "";
                            string input = Interaction.InputBox("What is the name of your character?", "Character Name", emptystring);
                            lineChanger("Name: " + input, Char2Path, 1);
                            keepgoing = false;
                        }
                        if (linedub == 2)
                        {
                            MessageBox.Show("You cannot change what class you are.");
                            keepgoing = true;
                        }
                        if (linedub == 3)
                        {
                            string emptystring = "";
                            string input = Interaction.InputBox("What is the level of your character?", "Character Level", emptystring);
                            lineChanger("Level: " + input, Char2Path, 3);
                            keepgoing = false;
                        }
                        if (linedub == 4)
                        {
                            string emptystring = "";
                            string input = Interaction.InputBox("What is the light level of your character?", "Character Light Level", emptystring);
                            lineChanger("Light Level: " + input, Char2Path, 4);
                            keepgoing = false;
                        }
                        if (linedub >= 5 && linedub <= 7)
                        {
                            MessageBox.Show("You cannot change what subclasses you have.");
                            keepgoing = true;
                        }
                        if (linedub >= 8)
                        {
                            MessageBox.Show("Those lines do not exist!");
                            keepgoing = true;
                        }
                        UpdateRTB2();
                    }
                }
            }
        }
        private void ECB3_Click(object sender, EventArgs e)
        {
            DialogResult EditChar3;
            EditChar3 = MessageBox.Show("Are you sure?", "Edit Character Slot 3?", MessageBoxButtons.YesNo);
            if (EditChar3 == DialogResult.Yes)
            {
                bool keepgoing = true;
                while (keepgoing == true)
                {
                    string emptyString = "";
                    string lineToEdit = Interaction.InputBox("What Line do you want to edit?", "Edit Line", emptyString);
                    emptyString = lineToEdit;
                    publinetoedit = lineToEdit;
                    if (emptyString == "")
                    {
                        MessageBox.Show("Input Field cannot be empty. Try again.", "Error", MessageBoxButtons.OK);
                        keepgoing = true;
                    }


                    else
                    {

                        double linedub = double.Parse(publinetoedit);
                        if (linedub == 1)
                        {

                            string emptystring = "";
                            string input = Interaction.InputBox("What is the name of your character?", "Character Name", emptystring);
                            lineChanger("Name: " + input, Char3Path, 1);
                            keepgoing = false;
                        }
                        if (linedub == 2)
                        {
                            MessageBox.Show("You cannot change what class you are.");
                            keepgoing = true;
                        }
                        if (linedub == 3)
                        {
                            string emptystring = "";
                            string input = Interaction.InputBox("What is the level of your character?", "Character Level", emptystring);
                            lineChanger("Level: " + input, Char3Path, 3);
                            keepgoing = false;
                        }
                        if (linedub == 4)
                        {
                            string emptystring = "";
                            string input = Interaction.InputBox("What is the light level of your character?", "Character Light Level", emptystring);
                            lineChanger("Light Level: " + input, Char3Path, 4);
                            keepgoing = false;
                        }
                        if (linedub >= 5 && linedub <= 7)
                        {
                            MessageBox.Show("You cannot change what subclasses you have.");
                            keepgoing = true;
                        }
                        if (linedub >= 8)
                        {
                            MessageBox.Show("Those lines do not exist!");
                            keepgoing = true;
                        }
                        UpdateRTB3();
                    }
                }
            }
        }
        #endregion

    }
}
