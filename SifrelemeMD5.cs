using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Sifreleme
    {
        public static string byteuzunlugu;
        public static string SifreleAES(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) plainText = "";
            string sharedSecret = "1234567890123456789012345678";
            string genelsifre = "1123454845121584854";

            byte[] _salt = Encoding.ASCII.GetBytes(genelsifre);
            string outStr = null;
            RijndaelManaged aesAlg = null;
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    byteuzunlugu = msEncrypt.ToArray().Length.ToString();
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                if (aesAlg != null)
                    aesAlg.Clear();
            }
            return outStr;
        }


        public static string SifreyiCozAES(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText)) cipherText = "cipherTextaa";
            string sharedSecret = "1234567890123456789012345678";
            string genelsifre = "1123454845121584854";

            byte[] _salt = Encoding.ASCII.GetBytes(genelsifre);
            RijndaelManaged aesAlg = null;


            string plaintext = null;

            try
            {

                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);


                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    try
                    {
                        aesAlg = new RijndaelManaged();
                        aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                        aesAlg.IV = ReadByteArray(msDecrypt);
                        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                                plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                    catch (Exception)
                    { plaintext = ""; }

                }
            }
            finally
            {

                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            try
            {
                byte[] rawLength = new byte[sizeof(int)];
                if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
                {
                    throw new SystemException("Stream did not contain properly formatted byte array");
                }

                byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
                if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
                {
                    throw new SystemException("Did not read byte array properly");
                }

                return buffer;

            }
            catch (Exception)
            { return null; }
        }


        public static bool IIsNumeric(string deger)
        {
            bool isNumberResult = true;
            if (deger.Length > 0)
            {
                for (int i = 0; i < deger.Length; i++)
                {
                    if (!Char.IsNumber(deger, i))
                    {
                        isNumberResult = false;
                        break;
                    }
                }
            }
            else
            { isNumberResult = false; }
            return isNumberResult;
        }


        public static string SifreleMD5(string Metin)
        {
            string yenimetin = "";
            for (int i = 0; i < Metin.Length; i++)
            {
                yenimetin += Metin.Substring(i, 1);
                yenimetin += (i % 6).ToString();
            }

            MD5CryptoServiceProvider MD5Code = new MD5CryptoServiceProvider();
            yenimetin = "366996" + yenimetin + "123456";
            byte[] byteDizisi = Encoding.UTF8.GetBytes(yenimetin);

            byteDizisi = MD5Code.ComputeHash(byteDizisi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in byteDizisi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }


        public static string SifreleMD5yeni(string Metin)
        {
            MD5CryptoServiceProvider MD5Code = new MD5CryptoServiceProvider();
            byte[] byteDizisi = Encoding.UTF8.GetBytes(Metin);
            byteDizisi = MD5Code.ComputeHash(byteDizisi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in byteDizisi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }


        public static string TurkceyeCevir(string gelentext)
        {
            if (gelentext == null)
            { return ""; }


            string yenikelime = "";

            for (int i = 0; i < gelentext.Length; i++)
            {
                char deger1 = Convert.ToChar(gelentext.Substring(i, 1));
                int aa = Convert.ToInt32(deger1);
                switch (aa)
                {
                    case 208: yenikelime += "Ğ"; break;
                    case 220: yenikelime += "Ü"; break;
                    case 222: yenikelime += "Ş"; break;
                    case 221: yenikelime += "İ"; break;
                    case 214: yenikelime += "Ö"; break;
                    case 199: yenikelime += "Ç"; break;
                    case 73: yenikelime += "I"; break;
                    case 240: yenikelime += "ğ"; break;
                    case 252: yenikelime += "ü"; break;
                    case 254: yenikelime += "ş"; break;
                    case 105: yenikelime += "i"; break;
                    case 246: yenikelime += "ö"; break;
                    case 231: yenikelime += "ç"; break;
                    case 253: yenikelime += "ı"; break;
                    default: yenikelime += deger1; break;
                }
            }
            return yenikelime;
        }
    }
}