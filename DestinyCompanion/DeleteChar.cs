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
    public partial class DeleteChar : Form
    {

        #region Global Vars

        public string DCChar1Path = "";
        public string DCChar2Path = "";
        public string DCChar3Path = "";
        public string CharName1 = "";
        public string CharName2 = "";
        public string CharName3 = "";
        public bool DCChar1Found = false;
        public bool DCChar2Found = false;
        public bool DCChar3Found = false;
        #endregion


        public DeleteChar()
        {
            InitializeComponent();
            var mf = new MainForm();
            var sc = new SelectClass();

            DCChar1Path = sc.Char1Path;
            DCChar2Path = sc.Char2Path;
            DCChar3Path = sc.Char3Path;




            #region Find which slots are empty/full
            try
            {

                using (StreamReader sr = new StreamReader(DCChar1Path))
                {

                    string LineFound = sr.ReadLine();
                    if (LineFound != "")
                    {
                        DCChar1Found = true;
                    }


                }
            }
            catch (FileNotFoundException)
            {
                DCChar1Found = false;
            }
            try
            {

                using (StreamReader sr = new StreamReader(DCChar2Path))
                {
                    string LineFound = sr.ReadLine();
                    if (LineFound != "")
                    {
                        DCChar2Found = true;
                    }
                }
            }
            catch (FileNotFoundException)
            {

                DCChar2Found = false;
            }
            try
            {
                using (StreamReader sr = new StreamReader(DCChar3Path))
                {
                    string LineFound = sr.ReadLine();
                    if (LineFound != "")
                    {

                        DCChar3Found = true;
                    }

                }
            }
            catch (FileNotFoundException)
            {
                DCChar3Found = false;
            }
            #endregion
            #region Read Char Names
            try
            {
                using (StreamReader sr = new StreamReader(DCChar1Path))
                {
                    CharName1 = sr.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                DCChar1Found = false;
            }
            try
            {
                using (StreamReader sr = new StreamReader(DCChar2Path))
                {
                    CharName2 = sr.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                DCChar2Found = false;
            }
            try
            {
                using (StreamReader sr = new StreamReader(DCChar3Path))
                {
                    CharName3 = sr.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                DCChar3Found = false;
            }

            #endregion
            #region Logic for the label text
            if (DCChar1Found == true)
            {
                CharLabel1.Text = CharName1;
            }
            if (DCChar2Found == true)
            {
                CharLabel2.Text = CharName2;
            }
            if (DCChar3Found == true)
            {
                CharLabel3.Text = CharName3;
            }
            #endregion

        }
        #region Delete Character 1
        private void DeleteSlot1_Click(object sender, EventArgs e)
        {

            DialogResult DelChar1;
            DelChar1 = MessageBox.Show("Are you sure?", "Delete Character Slot 1?", MessageBoxButtons.YesNo);
            if (DelChar1 == DialogResult.Yes)
            {
                CharLabel1.Text = "Empty";
                File.Delete(DCChar1Path);
            }
            else
            {

            }
        }
        #endregion
        #region Delete Character 2
        private void DeleteSlot2_Click(object sender, EventArgs e)
        {
            DialogResult DelChar2;
            DelChar2 = MessageBox.Show("Are you sure?", "Delete Character Slot 2?", MessageBoxButtons.YesNo);
            if (DelChar2 == DialogResult.Yes)
            {
                CharLabel2.Text = "Empty";
                File.Delete(DCChar2Path);
            }
            else
            {

            }
        }
        #endregion
        #region Delete Character 3
        private void DeleteSlot3_Click(object sender, EventArgs e)
        {
            DialogResult DelChar3;
            DelChar3 = MessageBox.Show("Are you sure?", "Delete Character Slot 3?", MessageBoxButtons.YesNo);
            if (DelChar3 == DialogResult.Yes)
            {
                CharLabel3.Text = "Empty";
                File.Delete(DCChar3Path);
            }
            else
            {

            }
        }
        #endregion
    }
}
