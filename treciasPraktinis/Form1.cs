using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treciasPraktinis
{
    public partial class Form1 : Form
    {
        private char[] encryptedText;
        private int[] encryptedNumbers;
        private BigInteger[] keyPri = new BigInteger[2];
        private BigInteger[] keyPub = new BigInteger[2];

        public Form1()
        {
            InitializeComponent();
            var primaryNumbers = new string[] { "2", "3", "5", "7", "11", "13", "17", "19", "23", "29", "31", "37", "41", "43", "47", "53", "59", "61", "67", "71", "73", "79", "83", "89", "97", "101" };
            comboBoxP.Items.AddRange(primaryNumbers);
            comboBoxQ.Items.AddRange(primaryNumbers);

        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            int p, q;
            if (int.TryParse(comboBoxP.Text, out p) && int.TryParse(comboBoxQ.Text, out q))
            {
                string plainNumbers = "";
                string cipherNumbers = "";
                string text = richTextBox1.Text;
                var encrypted = RSACipher.Encrypt(text, p, q);
                var plainBytes = Encoding.ASCII.GetBytes(text);
                char[] cipherText = new char[encrypted.Length];
                encryptedNumbers = new int[encrypted.Length];
                for (int i = 0; i < encrypted.Length; i++)
                {
                    plainNumbers += int.Parse(plainBytes[i].ToString()) + " ";
                    cipherNumbers += encrypted[i] + " ";
                    cipherText[i] = (char)encrypted[i];
                    encryptedNumbers[i] = encrypted[i];
                }
                richTextBox2.Text = "Plain text numerical value:\n" + plainNumbers + "\n";
                richTextBox2.AppendText("Encrypted text numerical value:\n" + cipherNumbers + "\n");
                richTextBox2.AppendText("Encrypted text:\n");
                foreach (char ch in cipherText)
                {
                    richTextBox2.AppendText(ch.ToString());
                }
                encryptedText = cipherText;
                keyPri = RSACipher.GetPrivateKey();
                keyPub = RSACipher.GetPublicKey();
                labelKeyPrivate.Text = "( " + keyPri[0] + "; " + keyPri[1] + " )";
                labelKeyPublic.Text = "( " + keyPub[0] + "; " + keyPub[1] + " )";
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string cipherNumbers = "";
            string plainNumbers = "";
            
            string text = richTextBox1.Text;
            string[] numberArray = text.Split(' ');
            var intArray = new int[numberArray.Length - 1];
            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                intArray[i] = int.Parse(numberArray[i]);
            }
            var decrypted = RSACipher.Decrypt(intArray, keyPub);
            var cipherBytes = Encoding.ASCII.GetBytes(text);
            char[] plainText = new char[decrypted.Length];
            for (int i = 0; i < decrypted.Length; i++)
            {
                cipherNumbers += int.Parse(cipherBytes[i].ToString()) + " ";
                plainNumbers += decrypted[i] + " ";
                plainText[i] = (char)decrypted[i];
            }
            richTextBox2.Text = "Cipher text numerical value:\n" + cipherNumbers + "\n";
            richTextBox2.AppendText("Decrypted text numerical value:\n" + plainNumbers + "\n");
            richTextBox2.AppendText("Decrypted text:\n");
            foreach (char ch in plainText)
            {
                richTextBox2.AppendText(ch.ToString());
            }
            keyPri = RSACipher.GetPrivateKey();
            labelKeyPrivate.Text = "( " + keyPri[0] + "; " + keyPri[1] + " )";
        }

        private void buttonFileRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Choose text file";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(var stream = new StreamReader(openFileDialog1.FileName))
                {
                    keyPub[0] = BigInteger.Parse(stream.ReadLine().ToString());
                    keyPub[1] = BigInteger.Parse(stream.ReadLine().ToString());

                    string text = stream.ReadToEnd();
                    string[] numberArray = text.Split(' ');
                    var intArray = new int[numberArray.Length];
                    encryptedNumbers = new int[numberArray.Length - 1];
                    for (int i = 0; i < numberArray.Length - 1; i++)
                    {
                        encryptedNumbers[i] = int.Parse(numberArray[i]);
                    }
                }
                richTextBox1.Text = "";
                foreach(var ch in encryptedNumbers)
                {
                    richTextBox1.AppendText(ch + " ");
                }
                labelKeyPublic.Text = "( " + keyPub[0] + "; " + keyPub[1] + " )";
                richTextBox2.Clear();
                labelKeyPrivate.Text = "";
            }
        }

        private void buttonFileSave_Click(object sender, EventArgs e)
        {
            var keyPub = RSACipher.GetPublicKey();
            string toSave = keyPub[0] + "\n" + keyPub[1] + "\n";
            foreach (var ch in encryptedNumbers)
            {
                toSave += ch + " ";
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save text to file";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, toSave);
            }
        }
    }
}
