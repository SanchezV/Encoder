using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    internal class AESCrypt : Crypt
    {
        protected RijndaelManaged myRijndael;
        private readonly byte[] key;
        private readonly byte[] vector;
        public AESCrypt(byte[] key, byte[] vector)
        {
            this.key = key;
            this.vector = vector;
        }
        public AESCrypt(byte[] key)
        {
            this.key = key;
            vector = new byte[] { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63 };
        }
        //public AESCrypt()
        //{
        //    key = "m5%8n%$i2a#)xer3";
        //    vector = "0123456789101112";
        //}

       
        internal override byte[] Encrypt(string plainText)
        {
            try
            {
                myRijndael = new RijndaelManaged
                {
                    Key = key,
                    IV = vector,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7
                };
                byte[] encrypted = null;
                //   string encString = Convert.ToBase64String(encrypted);
                ICryptoTransform encryptor = myRijndael.CreateEncryptor(myRijndael.Key, myRijndael.IV);
                // Create the streams used for encryption. 
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
                return encrypted;
            }
            catch { return null; }
        }
        internal override string Decrypt(byte[] encryptedString)
        {
            try
            {
                myRijndael = new RijndaelManaged
                {
                    Key = key,
                    IV = vector,
                    Mode = CipherMode.CBC,      //CBC
                    Padding = PaddingMode.PKCS7 //PKCS7
                };
                string plaintext = null;
                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = myRijndael.CreateDecryptor(myRijndael.Key, myRijndael.IV);
                // Create the streams used for decryption. 
                using (MemoryStream msDecrypt = new MemoryStream(encryptedString))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream 
                            // and place them in a string.
                            //Array.Copy(Encoding.Unicode.GetBytes(srDecrypt.ReadToEnd()), plaintext, srDecrypt.ReadToEnd().Length);
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
                return plaintext;
            }
            catch { return null; }
        }
    }
}

