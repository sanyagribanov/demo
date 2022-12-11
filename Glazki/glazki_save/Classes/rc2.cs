using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace glazki_save.Classes
{
    internal class rc2
    {
        public static string CryptoPass(string password)
        {
            RC2CryptoServiceProvider rC2 = new RC2CryptoServiceProvider();

            byte[] key = rC2.Key;
            byte[] IV = rC2.IV;

            ICryptoTransform encryptor = rC2.CreateEncryptor(key, IV);

            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

            string original = "Here is some data to encrypt.";
            byte[] toEncrypt = Encoding.ASCII.GetBytes(original);

            csEncrypt.Write(toEncrypt, 0, toEncrypt.Length);
            csEncrypt.FlushFinalBlock();

            byte[] encrypted = msEncrypt.ToArray();


            ICryptoTransform decryptor = rC2.CreateDecryptor(key, IV);

            MemoryStream msDecrypt = new MemoryStream(encrypted);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);

            StringBuilder roundtrip = new StringBuilder();

            do
            {
                roundtrip.Append(original);

                if (msDecrypt.Length > 0)
                {
                    roundtrip.Append(msDecrypt.ToString());
                }
            } while (msDecrypt.Length > 0);
            return csDecrypt.ToString();

        }
    }
}
