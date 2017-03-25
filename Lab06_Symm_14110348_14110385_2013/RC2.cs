using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Symm_14110348_14110385_2013
{
    class RC2 : ISymmetricAthm
    {
        RC2CryptoServiceProvider rc2CSP;
        byte[] key;
        byte[] iv;
        public RC2()
        {
            rc2CSP = new RC2CryptoServiceProvider();
            Random r = new Random();
            rc2CSP.KeySize = r.Next(5, 16) * 8;
        }
        public string decrypt(byte[] encrypted, byte[] key, byte[] iv)
        {
            //Get a decryptor that uses the same key and IV as the encryptor.
            ICryptoTransform decryptor = rc2CSP.CreateDecryptor(key, iv);

            Symmetric symm = new Symmetric();

            return symm.decrypt(decryptor, encrypted);
        }

        public byte[] encrypt(string plaintext, byte[] key, byte[] iv)
        {
            this.key = key;
            this.iv = iv;
            // Get an encryptor.
            ICryptoTransform encryptor = rc2CSP.CreateEncryptor(key, iv);

            Symmetric symm = new Symmetric();

            return symm.encrypt(encryptor, plaintext);
        }

        public byte[] getIV()
        {
            iv = rc2CSP.IV;
            return iv;
        }

        public byte[] getKey()
        {
            key = rc2CSP.Key;
            return key;
        }
    }
}
