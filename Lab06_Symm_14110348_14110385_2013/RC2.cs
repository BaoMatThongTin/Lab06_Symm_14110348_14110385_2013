using System;
using System.Collections.Generic;
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
        public string decrypt()
        {
            throw new NotImplementedException();
        }

        public string encrypt()
        {
            throw new NotImplementedException();
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
