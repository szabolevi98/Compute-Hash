using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashApp
{
    public partial class HashForm : Form
    {
        private bool Fajl { get; set; }
        public HashForm()
        {
            InitializeComponent();
        }

        private void HashForm_Load(object sender, EventArgs e)
        {
            Text += " v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            labelCopyright.Text = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).LegalCopyright;
            Fajl = false;
        }

        private void textBoxSzoveg_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSzoveg.ForeColor == Color.Blue)
            {
                textBoxSzoveg.ForeColor = SystemColors.WindowText;
            }
            if (Fajl)
            {
                Fajl = false;
                label1.Text = "Szöveg";
                label1.ForeColor = SystemColors.ControlText;
            }
            szamol();
        }

        private void szamol()
        {
            if (string.IsNullOrEmpty(textBoxSzoveg.Text))
            {
                textBoxMD5.Text = string.Empty;
                textBoxSHA1.Text = string.Empty;
            }
            else
            {
                textBoxMD5.Text = GetStringMD5(textBoxSzoveg.Text.ToString());
                textBoxSHA1.Text = GetStringSHA1(textBoxSzoveg.Text.ToString());
            }
        }

        private void checkBoxKisbetu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKisbetu.Checked)
            {
                textBoxMD5.CharacterCasing = CharacterCasing.Lower;
                textBoxSHA1.CharacterCasing = CharacterCasing.Lower;
            }
            else
            {
                textBoxMD5.CharacterCasing = CharacterCasing.Upper;
                textBoxSHA1.CharacterCasing = CharacterCasing.Upper;
            }
        }

        private void md5Masol_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMD5.Text))
            {
                Clipboard.SetText(textBoxMD5.Text);
            }
        }

        private void sha1Masol_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSHA1.Text))
            {
                Clipboard.SetText(textBoxSHA1.Text);
            }
        }

        private void buttonMegnyit_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            Fajl = true;
        }

        private void buttonMent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSzoveg.Text))
            {
                if (Fajl)
                {
                    saveFileDialog.FileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".txt";
                }
                else
                {
                    if (!textBoxSzoveg.Text.Contains(@":\"))
                    {
                        saveFileDialog.FileName = textBoxSzoveg.Text;
                    }
                    else
                    {
                        saveFileDialog.FileName = "hash.txt";
                    }
                }
                saveFileDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs mit menteni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile()))
            {
                if (Fajl)
                {
                    writer.WriteLine($"Fájl: {textBoxSzoveg.Text}");
                }
                else
                {
                    writer.WriteLine($"Szöveg: {textBoxSzoveg.Text}");
                }
                writer.WriteLine($"MD5: {textBoxMD5.Text}");
                writer.WriteLine($"SHA-1: {textBoxSHA1.Text}");
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            label1.Text = "Fájl";
            label1.ForeColor = Color.Blue;
            textBoxSzoveg.Text = openFileDialog.FileName;
            textBoxSzoveg.ForeColor = Color.Blue;
            textBoxMD5.Text = GetFileMD5(openFileDialog.FileName);
            textBoxSHA1.Text = GetFileSHA1(openFileDialog.FileName);
        }

        private static string GetFileMD5(string path)
        {
            using (MD5 md5 = MD5.Create())
            {
                using (Stream stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        private static string GetFileSHA1(string path)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                using (Stream stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        private static string GetStringMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                return BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(input))).Replace("-", string.Empty);
            }
        }

        private static string GetStringSHA1(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                return BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(input))).Replace("-", string.Empty);
            }
        }
    }
}
