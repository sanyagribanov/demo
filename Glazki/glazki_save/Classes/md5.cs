using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace glazki_save.Classes
{
    internal class md5
    {
        public static string HashPassword(string password)
        {
            MD5 md5 = MD5.Create();

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);

            StringBuilder sb = new StringBuilder();
            foreach (var a in hash) 
                sb.Append(a.ToString("X2"));

            return Convert.ToString(sb);
        } 

        public static string RC2_password(string password)
        {
            RC2CryptoServiceProvider rc2CSP = new RC2CryptoServiceProvider();

            Console.WriteLine("Effective key size is {0} bits.", rc2CSP.EffectiveKeySize);

            // получение ключа 
            byte[] key = rc2CSP.Key;
            byte[] IV = rc2CSP.IV;

            // шифрование введеного пароля.
            ICryptoTransform encryptor = rc2CSP.CreateEncryptor(key, IV);

            // Encrypt the data as an array of encrypted bytes in memory.
            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

            // конвертация данных в байтовое значение
            string original = "Hello world! ";
            byte[] toEncrypt = Encoding.ASCII.GetBytes(original);

            // Запись данных в криптопоток и его очистка 
            csEncrypt.Write(toEncrypt, 0, toEncrypt.Length);
            csEncrypt.FlushFinalBlock();

            // Получение зашифрованого массива байтов.
            byte[] encryptedx = msEncrypt.ToArray();

            ///////////////////////////////////////////////////////
            // Именно здесь данные могут быть переданы или сохранены.
            ///////////////////////////////////////////////////////

            //Получение дешифратора, который использует тот же ключ и IV, что и шифратор.
            ICryptoTransform decryptor = rc2CSP.CreateDecryptor(key, IV);

            // Теперь расшифруйте ранее зашифрованное сообщение с помощью дешифратора
            // получено на вышеуказанном этапе.
            MemoryStream msDecrypt = new MemoryStream(encryptedx);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);

            // Считайте расшифрованные байты из потока дешифрования
            // и поместите их в класс StringBuilder.

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

            // Отобразите исходные данные и расшифрованные данные.
            Console.WriteLine("Original:   {0}", original);
            Console.WriteLine("Round Trip: {0}", roundtrip);

            return Convert.ToString(roundtrip);
        }
    }
}
