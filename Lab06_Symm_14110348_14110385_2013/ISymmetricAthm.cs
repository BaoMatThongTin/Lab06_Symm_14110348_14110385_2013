using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Symm_14110348_14110385_2013
{
    interface ISymmetricAthm
    {
        string encrypt();
        string decrypt();
        byte[] getKey();
        byte[] getIV();
        void setKey(byte[] key);
        void setIV(byte[] iv);
    }
}
