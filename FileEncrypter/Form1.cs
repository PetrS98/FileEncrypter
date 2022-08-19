using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEncrypter
{
    public partial class Form1 : Form
    {
        string filePath = "";
        private bool pahtSelected;

        public bool PahtSelected
        {
            get { return pahtSelected; }
            set 
            { 
                pahtSelected = value;
                btnDecrypth.Enabled = pahtSelected;
                btnEncrypth.Enabled = pahtSelected;
                tbEncryptionKey.Enabled = pahtSelected;
            }
        }

        public Form1()
        {
            InitializeComponent();

            PahtSelected = false;
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            SaveStatusToBox("Data path selection dialog open.", tbStatus);

            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();

            if (DialogResult.OK == dr)
            {
                filePath = ofd.FileName;
                PahtSelected = true;
                SaveStatusToBox("Data path is selected.", tbStatus);
                SaveStatusToBox("Path: " + filePath, tbStatus);
            }

            SaveStatusToBox("Data path selection dialog closed.", tbStatus);
        }

        private void btnDecrypth_Click(object sender, EventArgs e)
        {
            if (CheckEncriptionInputData() == false) return;

            try
            {
                EncriptionManager.DecryptFile(filePath, tbEncryptionKey.Text);
                SaveStatusToBox("Decryption succesful completed.", tbStatus);
            }
            catch (Exception ex)
            {
                SaveStatusToBox("ERROR: Encryption cancel.", tbStatus);
                SaveStatusToBox("ERROR MESSAGE: " + ex.Message, tbStatus);
            }
        }

        private void btnEncrypth_Click(object sender, EventArgs e)
        {
            if(CheckEncriptionInputData() == false) return;

            try
            {
                EncriptionManager.EncryptFile(filePath, tbEncryptionKey.Text);
                SaveStatusToBox("Encryption succesful completed.", tbStatus);
            }
            catch(Exception ex)
            {
                SaveStatusToBox("ERROR: Encryption cancel.", tbStatus);
                SaveStatusToBox("ERROR MESSAGE: " + ex.Message, tbStatus);
            }
        }

        private void tbEncryptionKey_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbEncryptionKey.Text == "xxxxxxxx") tbEncryptionKey.Text = "";
        }

        private bool CheckEncriptionInputData()
        {
            if(tbEncryptionKey.Text == "xxxxxxxx")
            {
                SaveStatusToBox("ERROR: Encryption key not valid.", tbStatus);
                return false;
            }

            if(pahtSelected == false)
            {
                SaveStatusToBox("ERROR: File path not selected.", tbStatus);
                return false;
            }

            if (tbEncryptionKey.Text.ToArray().Length != 8 )
            {
                SaveStatusToBox("ERROR: Encryption key has bad length.", tbStatus);
                SaveStatusToBox("ERROR: Encryption key must be 8 character length.", tbStatus);
                return false;
            }
            return true;
        }

        private string BuildStatusString(string message)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;

            string tmp_message = "<" + dt.ToString("dd/MM/yyyy HH:mm:ss") + "> ";
            tmp_message = tmp_message + message + Environment.NewLine;

            return tmp_message;
        }

        private void SaveStatusToBox(string message, TextBox tb)
        {
            string BoxStatusData_Momory = tb.Text;
            tb.Clear();
            tb.Text = BuildStatusString(message);
            tb.Text = tb.Text + BoxStatusData_Momory;
        }
    }
}
