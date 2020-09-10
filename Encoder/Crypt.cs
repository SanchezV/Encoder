using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    internal abstract class Crypt
    {
        internal abstract byte[] Encrypt(string cipherText);
        internal abstract string Decrypt(byte[] cipherText);
    }
}
