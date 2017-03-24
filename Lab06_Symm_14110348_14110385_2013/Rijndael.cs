using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Symm_14110348_14110385_2013
{
    class Rijndael : ISymmetricAthm
    {
        RijndaelManaged rijndaelCSP;
        byte[] key;
        byte[] iv;
        public Rijndael()
        {
            rijndaelCSP = new RijndaelManaged();
        }
        public string decrypt(byte[] encrypted, byte[] key, byte[] iv)
        {
            //Get a decryptor that uses the same key and IV as the encryptor.
            ICryptoTransform decryptor = rijndaelCSP.CreateDecryptor(key, iv);

            Symmetric symm = new Symmetric();

            return symm.decrypt(decryptor, encrypted);
        }

        public byte[] encrypt(string plaintext, byte[] key, byte[] iv)
        {
            this.key = key;
            this.iv = iv;
            // Get an encryptor.
            ICryptoTransform encryptor = rijndaelCSP.CreateEncryptor(key, iv);

            Symmetric symm = new Symmetric();

            return symm.encrypt(encryptor, plaintext);
        }

        public byte[] getIV()
        {
            iv = rijndaelCSP.IV;
            return iv;
        }

        public byte[] getKey()
        {
            key = rijndaelCSP.Key;
            return key;
        }
    }
}
