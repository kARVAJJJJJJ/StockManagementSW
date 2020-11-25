using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace StockManagementSW
{
    class StockUtility
    {
        public static string SHA256Hash(string mit)
        {
            string addOn = "Ptxc:Ja~6Fj\"f!s)dfC]AmRT"; // a \ utáni " a karaktersor része(24) :)
            SHA256CryptoServiceProvider csp = new SHA256CryptoServiceProvider();
            byte[] titkositott = csp.ComputeHash(Encoding.UTF8.GetBytes(mit + addOn));
            return BitConverter.ToString(titkositott).Replace("-", "");
        }
    }
}
