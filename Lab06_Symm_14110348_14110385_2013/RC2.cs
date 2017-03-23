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
        RC2CryptoServiceProvider rc2CSP = new RC2CryptoServiceProvider();
        byte[] key;
        byte[] iv;
        public string decrypt(byte[] encrypted, byte[] key, byte[] iv)
        {
            //Get a decryptor that uses the same key and IV as the encryptor.
            ICryptoTransform decryptor = rc2CSP.CreateDecryptor(key, iv);

            // Now decrypt the previously encrypted message using the decryptor
            // obtained in the above step.
            MemoryStream msDecrypt = new MemoryStream(encrypted);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);

            // Read the decrypted bytes from the decrypting stream
            // and place them in a StringBuilder class.

            StringBuilder roundtrip = new StringBuilder();

            int b = 0;

            do
            {
                b = csDecrypt.ReadByte();

                if (b != -1)
                {
                    roundtrip.Append((char)b);
                }

            } while (b != -1);
            return roundtrip.ToString();
        }

        public byte[] encrypt(string plaintext, byte[] key, byte[] iv)
        {
            this.key = key;
            this.iv = iv;
            // Get an encryptor.
            ICryptoTransform encryptor = rc2CSP.CreateEncryptor(key, iv);

            // Encrypt the data as an array of encrypted bytes in memory.
            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

            // Convert the data to a byte array.
            string original = plaintext;
            byte[] toEncrypt = Encoding.UTF8.GetBytes(original);
            // Write all data to the crypto stream and flush it.
            csEncrypt.Write(toEncrypt, 0, toEncrypt.Length);
            csEncrypt.FlushFinalBlock();

            // Get the encrypted array of bytes.
            return msEncrypt.ToArray();
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

        public void setKey(byte[] key)
        {
            this.key = key;
        }

        public void setIV(byte[] iv)
        {
            this.iv = iv;
        }
    }
}
