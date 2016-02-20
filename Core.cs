﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MD5Cracker
{
    class Core
    {
        private Encoding encoding = Encoding.UTF8;
        private List<KeyValuePair<string, string>> data;
        string loginId = "username: ";
        string md5Id = "password: ";
        public string HeslaCesta { get; set; }
        public string SlovnikCesta { get; set; }
        public string VystupniCesta { get; set; }

        public void NacistSoubory(string cesta)
        {
            HeslaCesta = Path.GetFullPath(cesta);
            data = new List<KeyValuePair<string, string>>();
            foreach (string line in File.ReadLines(HeslaCesta, encoding))
            {
                string login = line.Remove(line.IndexOf(',')).Substring(loginId.Length);
                string md5Password = line.Substring(line.IndexOf(md5Id) + md5Id.Length);

                data.Add(new KeyValuePair<string, string>(login, md5Password));
            }
        }

        public void SpustitLamani(bool slovnik)
        {
            Thread vlakno = new Thread(ZjistitHesla);
            vlakno.Name = "Lámání MD5";
            vlakno.Start(slovnik);

        }

        void ZjistitHesla(object slovnik)
        {
            //Nešel by ten using přesunout přímo do té metody GetMd5Hash? (takhle ho musím opisovat i na řádku 106)
            using (MD5 md5Hash = MD5.Create())
            {
                if ((bool)slovnik)
                {
                    int prolomeno = 0;
                    foreach (string slovnikSlovo in File.ReadLines(SlovnikCesta, encoding))
                    {
                        string hashSlovnik = GetMd5Hash(md5Hash, slovnikSlovo);

                        foreach (KeyValuePair<string, string> zaznam in data)
                        {
                            if (VerifyMd5Hash(zaznam.Value, hashSlovnik))
                            {
                                PridatProlomeneHeslo(loginId + zaznam.Key + ", " + md5Id + slovnikSlovo);
                                prolomeno++;
                                if (data.Count == prolomeno)
                                {
                                    PridatProlomeneHeslo(string.Format("Z {0} hesel bylo {1} prolomeno pomoci slovníkového útoku", data.Count, prolomeno));
                                    return;
                                }
                            }
                        }
                    }

                }
            }
        }

        void BruteForce(int min, int max, string type)
        {
            if (max < min)
                return;

            char start = 'a';
            char end = 'z';
            int prolomeno = 0;
            ConvertType(ref start, ref end, type);
            string test = "";

            if (test.Length < min && test.Length < max)
                AddLetter(ref test, min, max, start, end, ref prolomeno);
        }

        void BruteForce(string format)
        {

        }

        void AddLetter(ref string test, int min, int max, char start, char end, ref int prolomeno)
        {
            string startTest = test;

            for (char i = start; i < end; i++)
            {
                test = startTest + i.ToString();

                if (test.Length < min)
                    AddLetter(ref test, min, max, start, end, ref prolomeno);
                else
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        string testHash = GetMd5Hash(md5Hash, test);

                        foreach (KeyValuePair<string, string> zaznam in data)
                        {
                            if (VerifyMd5Hash(zaznam.Value, testHash))
                            {
                                PridatProlomeneHeslo(loginId + zaznam.Key + ", " + md5Id + test);
                                prolomeno++;
                                if (data.Count == prolomeno)
                                {
                                    PridatProlomeneHeslo(string.Format("Z {0} hesel bylo {1} prolomeno pomoci BruteForce útoku", data.Count, prolomeno));
                                    return;
                                }
                            }
                        }
                    }

                    if (test.Length < max)
                        AddLetter(ref test, min, max, start, end, ref prolomeno);
                }
            }
        }

        void ConvertType(ref char start, ref char end, string type)
        {
            switch (type)
            {
                case "c":
                    start = 'a';
                    end = 'z';
                    break;
                case "C":
                    start = 'A';
                    end = 'Z';
                    break;
                case "d":
                    start = '0';
                    end = '9';
                    break;
                case "s":
                    start = '!';
                    end = '/';
                    break;
                case "?":
                    start = '0';
                    end = 'z';
                    break;
                default:
                    start = 'a';
                    end = 'z';
                    break;
            }
        }

        void PridatProlomeneHeslo(string radek)
        {
            using (StreamWriter writer = File.AppendText(VystupniCesta))
            {
                writer.WriteLine(radek);
            }
        }

        string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        bool VerifyMd5Hash(string hash1, string hash2)
        {
            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hash1, hash2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
