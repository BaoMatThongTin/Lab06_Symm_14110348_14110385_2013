﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Symm_14110348_14110385_2013
{
    interface ISymmetricAthm
    {
        byte[] encrypt(string plaintext, byte[] key, byte[] iv);
        string decrypt(byte[] encrypted, byte[] key, byte[] iv);
        byte[] getKey();
        byte[] getIV();
        void setKey(byte[] key);
        void setIV(byte[] iv);
    }
}
