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


    public partial class MainForm : Form
    {
        #region Global Variables 
        public string PubGTPSN = "";
        public string PubUN = "";
        public string PubReEnteredUser = "";
        public string DCDPath = "";
        public string pathIn = Path.Combine(Path.GetTempPath() + "\\DCData", "UserName.txt");
        public string Class = "";
        public string MFChar1Path = "";
        public string MFChar2Path = "";
        public string MFChar3Path = "";
        public bool MFChar1Found = false;
        public bool MFChar2Found = false;
        public bool MFChar3Found = false;

        public List<string> Char1Content = new List<string>();
        public List<string> Char2Content = new List<string>();
        public List<string> Char3Content = new List<string>();

        #endregion


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            var sc = new SelectClass();
            var dc = new DeleteChar();

            MFChar1Path = sc.Char1Path;
            MFChar2Path = sc.Char2Path;
            MFChar3Path = sc.Char3Path;

            //Properties.Settings.Default["FirstRun"] = true;

            #region FirstRun
            if ((bool)Properties.Settings.Default["FirstRun"] == true)
            {
                bool keepgoing = true;
                //First application run
                Properties.Settings.Default["FirstRun"] = false; //Makes setting "FirstRun" false
                while (keepgoing == true)
                {
                    string emptyString = "";
                    string GTPSN = Interaction.InputBox("Welcome New User! Please input your GT or PSN", "New User", emptyString); //Input box displays telling user to input their name
                    emptyString = GTPSN;
                    if (emptyString == "")
                    {
                        MessageBox.Show("Input Field cannot be empty. Try again.", "Error", MessageBoxButtons.OK);
                        keepgoing = true;
                    }
                    else
                    {
                        PubGTPSN = GTPSN; //Makes "GTPSN" a global variable
                        string GTPSNtxt = PubGTPSN; //Sets the variable for the text file to what ever PubGTPSN contains

                        #region Writing to Temp Folder
                        string DataFolderPath = Path.Combine(Path.GetTempPath(), "DCData"); //Gets path to temp folder and tell what name to give the folder
                        Directory.CreateDirectory(DataFolderPath); //Creates the folder using the "DataFolderPath" string
                        string tempFile = Path.Combine(DataFolderPath, "UserName.txt"); //Where the file is going to be located and what the file is going to be called
                        DCDPath = DataFolderPath;
                        using (StreamWriter sw = File.CreateText(tempFile))//Creates the file "UserName.txt" in the "Temp" folder
                        {
                            sw.WriteLine(GTPSNtxt); //Writes to a designated file with whatever GTPSNtxt contains
                        }
                        #endregion

                        MessageBox.Show("Welcome: " + PubGTPSN); //Welcomes the new user
                        keepgoing = false;
                    }
                }

            }
            #endregion //Happens when you start the program for the first time.
            #region Welcome Back
            else
            {
                //Reads the file and then displays name
                try
                {
                    using (StreamReader sr = new StreamReader(pathIn))
                    {
                        string UN = sr.ReadLine();
                        PubUN = UN;
                    }
                    MessageBox.Show("Welcome back: " + PubUN + "!", "Welcome Back!");
                }
               

                #region File/FolderNotFound
                catch (FileNotFoundException)
                {

                    DialogResult resultFileNotFound;
                    resultFileNotFound = MessageBox.Show("The Program is unable to find your Username/file.\n Would you like to re-enter your username?", "UserName/File Not Found!", MessageBoxButtons.YesNo);

                    #region FileNotFound DialogueResult YES/NO
                    if (resultFileNotFound == DialogResult.Yes)
                    {
                        bool keepgoing = true;
                        while (keepgoing == true)
                        {
                            string emptyString = "";
                            string ReEnteredUser = Interaction.InputBox("Re-Enter your name please.", "Re-Enter Username", emptyString); //Input box displays telling user to re-enter their name
                            emptyString = ReEnteredUser;
                            PubReEnteredUser = ReEnteredUser;
                            if (emptyString == "")
                            {
                                MessageBox.Show("Input Field cannot be empty. Try again.", "Error", MessageBoxButtons.OK);
                                keepgoing = true;
                            }
                            else
                            {
                                string DataFolderPath = Path.Combine(Path.GetTempPath(), "DCData");
                                string tempFile = Path.Combine(DataFolderPath, "UserName.txt"); //Where the file is going to be located and what the file is going to be called
                                try
                                {
                                    using (StreamWriter sw = File.CreateText(tempFile))//Creates the file "UserName.txt" in the "Temp" folder
                                    {
                                        sw.WriteLine(PubReEnteredUser); //Writes to a designated file with whatever GTPSNtxt contains
                                    }
                                }
                                catch (DirectoryNotFoundException)
                                {
                                    MessageBox.Show("Your data folder is gone and all of your files are gone. \n Recreating Folder and Files. \n All Characters have been deleted.", "Folder Not Found!");

                                    string DataFolderPath1 = Path.Combine(Path.GetTempPath(), "DCData"); //Gets path to temp folder and tell what name to give the folder
                                    Directory.CreateDirectory(DataFolderPath1); //Creates the folder using the "DataFolderPath" string
                                    #region Write UserName.txt to fix FileNotFoundException

                                    string tempFile1 = Path.Combine(DataFolderPath, "UserName.txt"); //Where the file is going to be located and what the file is going to be called

                                    using (StreamWriter sw = File.CreateText(tempFile1))//Creates the file "UserName.txt" in the "Temp" folder
                                    {
                                        sw.WriteLine(PubReEnteredUser); //Writes to a designated file with whatever GTPSNtxt contains
                                    }
                                    MessageBox.Show("Folder and File made.");
                                }
                            }
                            keepgoing = false;
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }

                    #endregion
                }
                #endregion
                #endregion
                #region Find which slots are empty/full
                try
                {

                    using (StreamReader sr = new StreamReader(MFChar1Path))
                    {

                        string LineFound = sr.ReadLine();
                        if (LineFound != "")
                        {
                            MFChar1Found = true;
                        }


                    }
                }
                catch (FileNotFoundException)
                {
                    MFChar1Found = false;
                }
                try
                {

                    using (StreamReader sr = new StreamReader(MFChar2Path))
                    {
                        string LineFound = sr.ReadLine();
                        if (LineFound != "")
                        {
                            MFChar2Found = true;
                        }
                    }
                }
                catch (FileNotFoundException)
                {

                    MFChar2Found = false;
                }
                try
                {
                    using (StreamReader sr = new StreamReader(MFChar3Path))
                    {
                        string LineFound = sr.ReadLine();
                        if (LineFound != "")
                        {

                            MFChar3Found = true;
                        }

                    }
                }
                catch (FileNotFoundException)
                {
                    MFChar3Found = false;
                }
                #endregion
                #region Read Char Info
                if (MFChar1Found == true)
                {
                    List<string> Content = new List<string>();
                    using (StreamReader sr = new StreamReader(MFChar1Path))
                    {
                        while (!sr.EndOfStream)
                        {
                            Content.Add(sr.ReadLine()); 
                        }
                    }
                    Content = Char1Content;

                }
                if (MFChar2Found == true)
                {
                    List<string> Content = new List<string>();
                    using (StreamReader sr = new StreamReader(MFChar1Path))
                    {
                        while (!sr.EndOfStream)
                        {
                            Content.Add(sr.ReadLine());
                        }
                    }
                    Content = Char2Content;
                }
                if (MFChar3Found == true)
                {
                    List<string> Content = new List<string>();
                    using (StreamReader sr = new StreamReader(MFChar1Path))
                    {
                        while (!sr.EndOfStream)
                        {
                            Content.Add(sr.ReadLine());
                        }
                    }
                    Content = Char3Content;
                }
                #endregion
            }
            #endregion


        }
        #region New Char
        private void newToolStripMenuItem_Click(object sender, EventArgs e) //Character --> New
        {
            var sc = new SelectClass(); //Creats an instance of SelectClass
            sc.ShowDialog(); //Locks up main form until SelectClass is closed
            Class = sc.Class;
            if (Class != "")
            {
                MessageBox.Show(Class, "Class Selected", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        #endregion
        #region Delete Char
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dc = new DeleteChar();
            dc.ShowDialog();

        }
        #endregion
        #region Edit Char
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ec = new EditChar();
            ec.ShowDialog();
        }
        #endregion
    }
}
