using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_P1
{
    public class crypto
    {
        static List<string> WordList = null; // stores dictionary words
        //=======================================================================================================
        //=======================================================================================================
        //// return all words of a dictionary file in a list of strings
        public static List<string> LoadWordsFile(string FileName)
        {
            string DataText = "";
            clsFiling.Instance.LoadTextFromFile(FileName, ref DataText);
            var wordarray = DataText.Split(Environment.NewLine.ToCharArray()).Where(i => i.Length > 2).Select(i => i.ToUpper()).Distinct().ToList();
            return wordarray;
        }

        //=======================================================================================================
        //=======================================================================================================
        //=======================================================================================================
        public static string LoadWordsFileToString(string FileName)
        {
            string DataText = "";
            clsFiling.Instance.LoadTextFromFile(FileName, ref DataText);
            return DataText.ToUpper();
        }

        //=======================================================================================================
        //=======================================================================================================
        //==========function for Decoding ciphertexts encoded by Vigenere cipher=================================
        public static string DecryptVigenere(string cipherText, string key) // function for Vigenere cipher
        {
            //apply vigener algorithm
            cipherText = cipherText.ToUpper();    
            key = key.ToUpper();                  

            int klength = key.Length;

            string pl = "";
            int a = Convert.ToInt32('A');
            for (int i = 0; i < cipherText.Length; i++) // decode all characters in this loop
            {
                int c = Convert.ToInt32(cipherText[i]) - a;
                if (c < 0) c += 26;
                int k = Convert.ToInt32(key[i % klength]) - a;
                if (k < 0) k += 26;
                int p = (c - k);
                p %= 26;
                if (p < 0) p += 26;
                p += a;

                pl += Convert.ToChar(p);
            }

            return pl;
        }

        //=======================================================================================================
        //=======================================================================================================
        //===============function for Decoding ciphertexts encoded by auto-key cipher============================
        //
        public static string DecryptAutoKey(string cipherText, string key)
        {
            cipherText = cipherText.ToUpper();
            key = key.ToUpper();       

            int klength = key.Length;
            //applying encoding algorithm of au
            string pl = string.Empty;
            char[] newPlaintext = new char[cipherText.Length];
            int a = Convert.ToInt32('A');
            for (int i = 0; i < cipherText.Length; i++) // generating the key stream for ciphertext(the parameter)
            {
                int c = Convert.ToInt32(cipherText[i]) - a; 
                if (c < 0) c += 26;
                int k = Convert.ToInt32(key[i]) - a;  
                if (k < 0) k += 26;
                int p = (c - k);                      
                p %= 26;
                if (p < 0) p += 26;
                p += a;
                char temp = Convert.ToChar(p);
                key += temp;                        
                newPlaintext[i] = temp;
            }

            char[] NewKey = new char[cipherText.Length];
            int count = 0;
            for (int i = 0; i < NewKey.Length; i++)    
            {
                NewKey[i] = key[i];
                count++;
            }
            int j = 0;
            for (int i = count; i < cipherText.Length; i++) 
            {
                NewKey[i] = newPlaintext[j];
                j++;
            }


            for (int i = klength; i < cipherText.Length; i++)
            {
                int c = Convert.ToInt32(cipherText[i]) - a;
                int k = Convert.ToInt32(NewKey[i]) - a;
                int p = (c - k);
                p %= 26;
                if (p < 0) p += 26;
                p += a;

                char temp = Convert.ToChar(p);
                newPlaintext[i] = temp;
            }

            pl = new string(newPlaintext);
            return pl;
        } // function

        //=======================================================================================================
        //=======================================================================================================
        //==========function to check how much a text is similar to a meaningful real english text===================
        public static int CheckEnglishSentence(string inputStr, bool CheckAll) 
        {
            if (WordList == null || WordList.Count == 0)
            {
                WordList = LoadWordsFile("Words.txt");
            }

            int FoundCount = 0;
            foreach (string word in WordList)
            {
                if (inputStr.Contains(word))
                {
                    if (CheckAll)
                    {
                        FoundCount++;
                    }
                    else
                    {
                        FoundCount = 1;
                        return FoundCount;
                    }
                }
            }

            return FoundCount;
        }

        //=======================================================================================================
        //=======================================================================================================
        //=======================================================================================================

    } // class
} // namespace
