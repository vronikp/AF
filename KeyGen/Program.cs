using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace KeyGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var cryptoContainer = new RijndaelManaged { KeySize = 256 };//use your own keysize
            cryptoContainer.GenerateKey();
            var key = Convert.ToBase64String(cryptoContainer.Key);

            cryptoContainer.GenerateIV();
            var iv = Convert.ToBase64String(cryptoContainer.IV);

            Console.WriteLine(iv.ToString());
            Console.WriteLine(key.ToString());
            Console.WriteLine("Please press any key to exit.");
            Console.ReadKey();
        }
    }
}
