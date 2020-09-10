using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder
{
    public partial class Form1 : Form
    {
        byte[] closeText = null;
        byte[] key = null;
        byte[] vector = null;
        private RegistryKey _regKey { set; get; }
        Crypt text;
        public Form1()
        {
            InitializeComponent();
        }
        private void saveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filePath = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllBytes(filePath, closeText);
            // File.WriteAllBytes(, Encoding.Default.GetBytes(outputText.Text)); // save in current directory Extra.GetExeDirectory()
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filePath = openFileDialog1.FileName;
            // читаем файл в строку
            closeText = System.IO.File.ReadAllBytes(filePath);
            inputText.Text = Encoding.ASCII.GetString(closeText);
        }

        private void setKey_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filePath = openFileDialog2.FileName;
            if (File.Exists(filePath) && _regKey != null)
            {
                _regKey.SetValue("key", filePath, RegistryValueKind.String);
            }
            // читаем файл в строку
            key = System.IO.File.ReadAllBytes(filePath);
            keyPath.Text = filePath;
            keyString.Text = Encoding.ASCII.GetString(key);
            keyHex.Text = Extra.ByteArrayToHexString(key);
        }

        private void setVector_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filePath = openFileDialog3.FileName;
            if (File.Exists(filePath) && _regKey != null)
            {
                _regKey.SetValue("vector", filePath, RegistryValueKind.String);
            }
            // читаем файл в строку
            vector = File.ReadAllBytes(filePath);
            vectorPath.Text = filePath;
            vectorString.Text = Encoding.ASCII.GetString(vector);
            vectorHex.Text = Extra.ByteArrayToHexString(vector);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _regKey = Registry.LocalMachine.CreateSubKey(@"Software\DefaultPath");
                if ((_regKey.GetValueNames()).Length >= 1)
                {
                    string pathToKey = (string)_regKey.GetValue("key");
                    if (File.Exists(pathToKey))
                    {
                        keyPath.Text = pathToKey;
                        keyString.Text = File.ReadAllText(pathToKey);
                    }
                    string pathToVector = (string)_regKey.GetValue("vector");
                    if (File.Exists(pathToVector))
                    {
                        vectorPath.Text = pathToVector;
                        vectorString.Text = File.ReadAllText(pathToVector);
                    }
                }
            }
            catch
            { }
        }

        private void encrypting_Click(object sender, EventArgs e)
        {

            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void decrypting_Click(object sender, EventArgs e)
        {
            if (backgroundWorker2.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            hexText.Text = Extra.ByteArrayToHexString(Encoding.UTF8.GetBytes(inputText.Text));
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (string.IsNullOrEmpty(keyPath.Text))
            {
                MessageBox.Show("Не выбран ключ!");
            }
            try
            {
                if (!string.IsNullOrEmpty(keyPath.Text) && string.IsNullOrEmpty(vectorPath.Text))
                    text = new AESCrypt(File.ReadAllBytes(keyPath.Text));
                else if (!string.IsNullOrEmpty(keyPath.Text) && !string.IsNullOrEmpty(vectorPath.Text))
                    text = new AESCrypt(File.ReadAllBytes(keyPath.Text), File.ReadAllBytes(vectorPath.Text));
                else text = null;
            }
            catch
            {
                MessageBox.Show("Ошибка инициализации ключа/вектора!");
                text = null;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (text != null)
                {
                    if (Hex.Checked && !Base64_box.Checked)
                    {
                        closeText = text.Encrypt(Encoding.ASCII.GetString(Extra.HexStringToByte(inputText.Text)));
                        outputText.Text = Encoding.ASCII.GetString(closeText);
                    }
                    if (Hex.Checked && Base64_box.Checked)
                    {
                        closeText = text.Encrypt(Encoding.ASCII.GetString((Extra.HexStringToByte(inputText.Text))));
                        outputText.Text = Convert.ToBase64String(closeText);
                    }
                    if (Base64_box.Checked && !Hex.Checked)
                    {
                        closeText = text.Encrypt(inputText.Text);
                        outputText.Text = Convert.ToBase64String(closeText);
                    }
                    else if (!Base64_box.Checked && !Hex.Checked)
                    {
                        closeText = text.Encrypt(inputText.Text);
                        outputText.Text = Encoding.ASCII.GetString(closeText);
                    }
                }
            }
            catch { }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (string.IsNullOrEmpty(keyPath.Text))
            {
                MessageBox.Show("Не выбран ключ!");
            }
            try
            {
                if (!string.IsNullOrEmpty(keyPath.Text) && string.IsNullOrEmpty(vectorPath.Text))
                    text = new AESCrypt(File.ReadAllBytes(keyPath.Text));
                else if (!string.IsNullOrEmpty(keyPath.Text) && !string.IsNullOrEmpty(vectorPath.Text))
                    text = new AESCrypt(File.ReadAllBytes(keyPath.Text), File.ReadAllBytes(vectorPath.Text));
                else text = null;
            }
            catch
            {
                MessageBox.Show("Ошибка инициализации ключа/вектора!");
                text = null;
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (text != null)
                {
                    if (Hex.Checked && !Base64_box.Checked)
                    {
                        outputText.Text = Extra.ByteArrayToHexString(Encoding.UTF8.GetBytes((text.Decrypt(closeText))));
                    }
                    if (Hex.Checked && Base64_box.Checked)
                    {
                        outputText.Text = Extra.ByteArrayToHexString(Encoding.UTF8.GetBytes((text.Decrypt(Convert.FromBase64String(inputText.Text)))));
                    }
                    if (Base64_box.Checked && !Hex.Checked)
                    {
                        outputText.Text = text.Decrypt(Convert.FromBase64String(inputText.Text));
                    }
                    else if (!Base64_box.Checked && !Hex.Checked)
                    {
                        outputText.Text = text.Decrypt(closeText);
                    }
                }
            }
            catch { }
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {
            hexCloseText.Text = Extra.ByteArrayToHexString(Encoding.UTF8.GetBytes(outputText.Text));
        }
    }
}
