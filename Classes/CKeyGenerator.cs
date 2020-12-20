using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Article75
{
    public class CKeyGenerator
    {
        public CKeyGenerator()
        {
            //
            // TODO: aggiungere qui la logica del costruttore
            //
        }

        public string GetUniqueKey(int maxSize, bool pass)
        {
            char[] chars = new char[62];
            chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            char[] cha = new char[35];
            cha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();

            try
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            finally
            {
                if (crypto != null)
                    crypto = null;

            }

            StringBuilder result = new StringBuilder(maxSize);

            if (!pass)
            {
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
            }
            else
            {
                foreach (byte b in data)
                {
                    result.Append(cha[b % (cha.Length)]);
                }
            }

            return result.ToString();
        }

        public string GeneraPassword(int length)
        {

            string password = string.Empty;


            // Definisce gli speciali caratteri generati da Base64 encoding non validi.
            string[] invalidChars = { "/", "+", "=", "'" };

            // Genera password fino alla lunghezza richiesta.    
            while (password.Length < length)
            {
                // Base64 encode a newly generated GUID. 
                string encodedGuid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());

                // Remove special characters from Base64 encoded GUID.
                foreach (string invalidChar in invalidChars)
                    encodedGuid = encodedGuid.Replace(invalidChar, string.Empty);

                password += encodedGuid;

            }

            // Substring password characters to obtain password of required length.
            password = password.Substring(0, length);

            return password;
        }
    }
}