using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder
{
    class Extra
    {
        static internal string GetExeDirectory()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            path = System.IO.Path.GetDirectoryName(path);
            return path;
        }
        public static byte[] HexStringToByte(string hexString)
        {
            try
            {
                int bytesCount = (hexString.Length) / 2;
                byte[] bytes = new byte[bytesCount];
                for (int x = 0; x < bytesCount; ++x)
                {
                    bytes[x] = Convert.ToByte(hexString.Substring(x * 2, 2), 16);
                }
                return bytes;
            }
            catch
            {
                MessageBox.Show("Неверный формат данных!");
                return null;
            }
        }
        public static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        //public static string ToHexString(string str)
        //{
        //    var sb = new StringBuilder();

        //    var bytes = Encoding.Unicode.GetBytes(str);
        //    foreach (var t in bytes)
        //    {
        //        sb.Append(t.ToString("X2"));
        //    }

        //    return sb.ToString(); // returns: "48656C6C6F20776F726C64" for "Hello world"
        //}

        //public static string FromHexString(string hexString)
        //{
        //    var bytes = new byte[hexString.Length / 2];
        //    for (var i = 0; i < bytes.Length; i++)
        //    {
        //        bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
        //    }

        //    return Encoding.Unicode.GetString(bytes); // returns: "Hello world" for "48656C6C6F20776F726C64"
        //}
    }   
}
