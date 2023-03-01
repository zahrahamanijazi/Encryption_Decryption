using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Security_P1
{
    public partial class Form1 : Form
    {
        private bool Pause = false;
        List<string> KeyList = new List<string>();

        //=======================================================================================================
        //=======================================================================================================
        //=======================================================================================================
        public Form1()
        {
            InitializeComponent();
        }

        //=======================================================================================================
        //=============== Generating all posible keys for Brute Force attack ====================================
        //=======================================================================================================
        private IEnumerable<string> GenerateKey(int KeyLen) 
        {
            if (KeyLen <= 0)
                yield return "";

            for (char c = 'A'; c <= 'Z'; c++) 
            {
                if (KeyLen == 1)           // base condition of recursion
                {
                    yield return "" + c.ToString(); 
                }
                else
                {
                    foreach (string item in GenerateKey(KeyLen - 1)) //recursive loop for generating all possible keys
                      {
                        yield return c + item;
                    }
                }
            }
        }

        //=======================================================================================================
        //Generating all possible keys when we have candidate keys for each character of key and the length of key
        //=======================================================================================================
        private IEnumerable<string> GenerateKey(string[] keyLst, int Index) 
        {
            if (keyLst.Length == 0 || Index < 0)
                yield return "";

            if (Index == 0)   //base condition of recursion
            {
                for (int i = 0; i < keyLst[Index].Length; i++)  
                {
                    yield return keyLst[Index][i].ToString();
                }
            }
            else
            {
                foreach (string item in GenerateKey(keyLst, Index - 1)) //generating possible keys by recursive loop
                {
                    for (int i = 0; i < keyLst[Index].Length; i++)
                    {
                        yield return item + keyLst[Index][i].ToString();
                    }
                }
            }
        }

        //=======================================================================================================
        //==========================Calculating Index of Coincidence(IC)=========================================
        //=======================================================================================================
        private double CalculateIndexCoincidence(string text)
        {
            double index_of_coincidence = 0;
            double total = 0;
            double[] CarFreq = new double[26]; // an array to keep frequency of each letter

            for (int j = 0; j < text.Length; j++)
            {
                char MyLetter = text[j];
                int indx = Convert.ToInt32(MyLetter) - 65;
                CarFreq[indx] = CarFreq[indx] + 1; // calculate the frequency of each letter in the given text
            }

            total = CarFreq.Sum(k => k); // calculate the total number of characters
            for (int i = 0; i < 26; i++)
            {
                index_of_coincidence += (CarFreq[i] * (CarFreq[i] - 1)) / (total * (total - 1)); // the formula for calculating index of coincidence
            }

            return index_of_coincidence;
        }

        //=======================================================================================================
        //===================== Finding possible keys for Auto-key cipher =======================================
        //=======================================================================================================
        private string[] FindKey(string CipherText, int StartKeyLen, int MaxKeyLen, double ICLevel, ref int FinalKeyLen)
        {
            string[] FinalKey = new string[MaxKeyLen];

            for (int i = StartKeyLen; i <= MaxKeyLen; i++)
            {
                string[] Key = new string[i];

                int ArrayLen = Convert.ToInt32(CipherText.Length / i) + 1;

                double[,] CipherFreq = new double[i, 26];
                double[] ICValue = new double[i];
                string[] SplitText = new string[i];

                LogTextBox.AppendText("********************************************************************************************" + Environment.NewLine);
                LogTextBox.AppendText("====== Key Len = " + i.ToString() + " ======" + Environment.NewLine);
                LogTextBox.AppendText("********************************************************************************************" + Environment.NewLine);

                for (int R = 0; R < i; R++)
                {
                    SplitText[R] = "";

                    for (int j = R; j < CipherText.Length; j += i) //the loop for dividing text to R group of characters
                    {
                        if (j < CipherText.Length)
                        {
                            char MyLetter = CipherText[j];
                            SplitText[R] = SplitText[R] + MyLetter;
                        }
                    }

                    double[] KeyICValue = new double[26];

                    for (char c = 'A'; c <= 'Z'; c++)
                    {
                        var PlainText = crypto.DecryptAutoKey(SplitText[R], c.ToString());//apply auto-key decryption on each group with the special character 
                        var IC = CalculateIndexCoincidence(PlainText); // calculate IC for the plaintext produced in the previous step
                        LogTextBox.AppendText("      " + (Convert.ToInt32(c) - 65).ToString() + " - [" + c + "]     IC = " + IC.ToString() + Environment.NewLine);
                        KeyICValue[Convert.ToInt32(c) - 65] = IC;
                    }

                    for (int ic = 0; ic < 26; ic++)// the loop to check which characters can produced a plaintext with IC>0.053
                    {
                        if (KeyICValue[ic] > ICLevel)
                        {
                            Key[R] += Convert.ToChar(ic + 65);

                            if (FinalKeyLen == 0)
                            {
                                FinalKeyLen = i;
                                LogTextBox.AppendText(">>>>>>>>>>>>>>>>>>>   Key Len = " + i.ToString() + Environment.NewLine);
                            }
                        }
                    }

                    if (R == 0 && FinalKeyLen == 0)
                        break;

                    if (FinalKeyLen > 0 && string.IsNullOrEmpty(Key[R]))
                    {
                        FinalKeyLen = 0;   // no key was found
                        break;
                    }
                } // For R

                if (FinalKeyLen > 0) 
                {
                    FinalKey = new string[FinalKeyLen]; // keep candidate keys for each key's letters in FinalKey
                                                        // because Key was a local arrays of strings 
                    for (int kk = 0; kk < Key.Length; kk++)  
                    {
                        FinalKey[kk] = Key[kk]; 
                    }
                }

                if (FinalKeyLen > 0)
                    break;
            } // For i

            return FinalKey;
        }
        //=======================================================================================================
        //=======================================================================================================
        //=======================Finding possible keys for Vigenere cipher=======================================
        private string[] FindKey_for_vigenere(string CipherText, int StartKeyLen, int MaxKeyLen, double ICLevel, ref int FinalKeyLen)
        {
            string[] FinalKey = new string[MaxKeyLen];

            for (int i = StartKeyLen; i <= MaxKeyLen; i++)
            {
                string[] Key = new string[i];

                int ArrayLen = Convert.ToInt32(CipherText.Length / i) + 1;

                double[,] CipherFreq = new double[i, 26];
                double[] ICValue = new double[i];
                string[] SplitText = new string[i];

                LogTextBox.AppendText("********************************************************************************************" + Environment.NewLine);
                LogTextBox.AppendText("====== Key Len = " + i.ToString() + " ======" + Environment.NewLine);
                LogTextBox.AppendText("********************************************************************************************" + Environment.NewLine);

                for (int R = 0; R < i; R++)
                {
                    SplitText[R] = "";

                    for (int j = R; j < CipherText.Length; j += i) //the loop for dividing text to R group of characters
                    {
                        if (j < CipherText.Length)
                        {
                            char MyLetter = CipherText[j];
                            SplitText[R] = SplitText[R] + MyLetter;
                        }
                    }

                    double[] KeyICValue = new double[26];

                    for (char c = 'A'; c <= 'Z'; c++)
                    {
                        var PlainText = crypto.DecryptVigenere(SplitText[R], c.ToString());//apply vigenere decryption on each group with the special character 
                        var IC = CalculateIndexCoincidence(PlainText); // calculate IC for the plaintext produced in the previous step
                        LogTextBox.AppendText("      " + (Convert.ToInt32(c) - 65).ToString() + " - [" + c + "]     IC = " + IC.ToString() + Environment.NewLine);
                        KeyICValue[Convert.ToInt32(c) - 65] = IC;
                    }

                    for (int ic = 0; ic < 26; ic++)// the loop to check which characters can produced a plaintext with IC>0.053
                    {
                        if (KeyICValue[ic] > ICLevel)
                        {
                            Key[R] += Convert.ToChar(ic + 65);

                            if (FinalKeyLen == 0)
                            {
                                FinalKeyLen = i;
                                LogTextBox.AppendText(">>>>>>>>>>>>>>>>>>>   Key Len = " + i.ToString() + Environment.NewLine);
                            }
                        }
                    }

                    if (R == 0 && FinalKeyLen == 0)
                        break;

                    if (FinalKeyLen > 0 && string.IsNullOrEmpty(Key[R]))
                    {
                        FinalKeyLen = 0;   // no key was found
                        break;
                    }
                } // For R

                if (FinalKeyLen > 0)
                {
                    FinalKey = new string[FinalKeyLen]; // keep candidate keys for each key's letters in FinalKey
                                                        // because Key was a local arrays of strings 
                    for (int kk = 0; kk < Key.Length; kk++)
                    {
                        FinalKey[kk] = Key[kk];
                    }
                }

                if (FinalKeyLen > 0)
                    break;
            } // For i

            return FinalKey;
        }

        //=======================================================================================================
        //=======================================================================================================
        //=======================================================================================================
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Tag.ToString() == "0")
            {
                Pause = true;
                btnPause.Tag = "1";
                btnPause.Text = "Continue";
            }
            else
            {
                Pause = false;
                btnPause.Tag = "0";
                btnPause.Text = "Pause";
            }
        }

        //=======================================================================================================
        //=======================================================================================================
        //=======================================================================================================
        class clsDecryptResult
        {
            public string Key { get; set; }
            public string PlainText { get; set; }
            public double Score { get; set; }
            public double NormalScore { get; set; }

            public double DictionaryScore { get; set; }
            public double DictionaryNormalScore { get; set; }


            public clsDecryptResult(string key, string plaintext, double score, double normalscore, double dicscore, double dicnormalscore)
            {
                this.Key = key;
                this.PlainText = plaintext;
                this.Score = score;
                this.NormalScore = normalscore;
                this.DictionaryScore = dicscore;
                this.DictionaryNormalScore = dicnormalscore;
            }
        }

        //=======================================================================================================
        //=======================================================================================================
        //======================== Decrypt button in  the output Form=============================================
        private void btnICDecrypt_Click(object sender, EventArgs e) 
        {
            string InputKey = KeyTextBox.Text;
            string CipherText = CipherTextBox.Text;

            if (string.IsNullOrEmpty(CipherText) || string.IsNullOrWhiteSpace(CipherText))// check if ciphertext is entered
            {
                MessageBox.Show("Please Entere The Cipher Text", "Empty Cipher Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CipherTextBox.Focus();
                btnICDecrypt.Enabled = true;
                return;
            }

            Stopwatch SW1 = new Stopwatch();

            if (rbWithKey.Checked)  // With User Input Key
            {
                if (string.IsNullOrEmpty(InputKey))
                {
                    MessageBox.Show("Please Entere The Key", "Empty Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    KeyTextBox.Focus();
                    btnICDecrypt.Enabled = true;
                    return;
                }

                PercentLabel.Visible = false;

                KeyList.Clear();
                KeyListBox.Items.Clear();

                KeyList.Add(InputKey);
                KeyListBox.Items.Add(InputKey);

                LogTextBox.Text = "";
                FinalResultTextBox.Text = "";
            }
            else // Deciphering when we don't have neither key nor the length of key
            {
                int FromKeyLen = Convert.ToInt32(FromKeyLenUpDown.Value);
                int ToKeyLen = Convert.ToInt32(ToKeyLenUpDown.Value);

                if (FromKeyLen > ToKeyLen)// monitor user for entering right min key's length and max key'length
                {
                    MessageBox.Show("From Key Length Must Be Smaller Than To Key Len", "Key Length Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FromKeyLenUpDown.Focus();
                    btnICDecrypt.Enabled = true;
                    return;
                }

                if (cmbMode.SelectedIndex == 0) // Applying Autokey decipher with frequency analysis 
                {
                    btnICDecrypt.Enabled = false;
                    FinalResultTextBox.Text = "";

                    btnPause.Enabled = true;
                    btnPause.Text = "Pause";
                    btnPause.Tag = "0";
                    PercentLabel.Visible = true;
                    // generating keys and calculating time of generation
                    SW1.Start();
                    KeyListBox.Items.Clear();

                    double ICLevel = Convert.ToDouble(ICMaskEdit.Text);
                    int startKey = FromKeyLen;

                    int FinalKeyLen = 0;
                    var Keys = FindKey(CipherText, startKey, ToKeyLen, ICLevel, ref FinalKeyLen);

                    if (FinalKeyLen > 0)
                    {
                        KeyList = GenerateKey(Keys, FinalKeyLen - 1).ToList();// generating all possible keys
                        foreach (var item in KeyList)
                        {
                            KeyListBox.Items.Add(item);
                        }
                    }
                    else
                    {
                        FinalResultTextBox.Text = "No Result Found";
                        btnICDecrypt.Enabled = true;
                        return;
                    }
                    SW1.Stop();

                    KeyTimelabel.Text = SW1.ElapsedMilliseconds.ToString() + " Mili Seconds";  // the time of generating key
                    SW1.Reset();
                }
                else if(cmbMode.SelectedIndex == 1) // Applying Vigenere algorithm with frequency analysis
                    {
                    btnICDecrypt.Enabled = false;
                    FinalResultTextBox.Text = "";

                    btnPause.Enabled = true;
                    btnPause.Text = "Pause";
                    btnPause.Tag = "0";
                    PercentLabel.Visible = true;
                    // generating keys and calculating time of generation
                    SW1.Start();
                    KeyListBox.Items.Clear();

                    double ICLevel = Convert.ToDouble(ICMaskEdit.Text);
                    int startKey = FromKeyLen;

                    int FinalKeyLen = 0;
                    var Keys = FindKey_for_vigenere(CipherText, startKey, ToKeyLen, ICLevel, ref FinalKeyLen);

                    if (FinalKeyLen > 0)
                    {
                        KeyList = GenerateKey(Keys, FinalKeyLen - 1).ToList();// generating all possible keys
                        foreach (var item in KeyList)
                        {
                            KeyListBox.Items.Add(item);
                        }
                    }
                    else
                    {
                        FinalResultTextBox.Text = "No Result Found";
                        btnICDecrypt.Enabled = true;
                        return;
                    }
                    SW1.Stop();

                    KeyTimelabel.Text = SW1.ElapsedMilliseconds.ToString() + " Mili Seconds";  // the time of generating keys
                    SW1.Reset();


                }
                else if (cmbMode.SelectedIndex == 2) // Applying Vigener Algorithm with brute force attack
                {
                    //if (ToKeyLen > 4)
                    //{
                    //    MessageBox.Show("Brute Force Algorithm Is Not Practical When The Key's Length Is More Than 4", "Key Length Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    ToKeyLenUpDown.Focus();
                    //    btnICDecrypt.Enabled = true;
                    //    return;
                    //}

                    if (FromKeyLen > ToKeyLen)
                    {
                        MessageBox.Show("From Key Length Must Be Smaller Than To Key Len", "Key Length Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FromKeyLenUpDown.Focus();
                        btnICDecrypt.Enabled = true;
                        return;
                    }

                    btnICDecrypt.Enabled = false;

                    LogTextBox.Text = "";
                    FinalResultTextBox.Text = "";

                    btnPause.Enabled = true;
                    btnPause.Text = "Pause";
                    btnPause.Tag = "0";
                    PercentLabel.Visible = true;

                    SW1.Start();
                    KeyListBox.Items.Clear();
                    int keynum = 0;

                    int startKey = FromKeyLen;

                    double MaxKeyCount = 0;
                    for (int i = startKey; i <= ToKeyLen; i++) 
                    {
                        MaxKeyCount += Math.Pow(26, i);
                    }

                    for (int i = startKey; i <= ToKeyLen; i++)
                    {
                        foreach (var k in GenerateKey(i))
                        {
                            while (Pause)
                            {
                                Application.DoEvents();
                            }

                            keynum++;
                            KeyListBox.Items.Add(keynum.ToString() + "- " + k);
                            KeyList.Add(k);
                            KeyListBox.SelectedIndex = keynum - 1;

                            PercentLabel.Text = ((Convert.ToDouble(keynum) * 100) / MaxKeyCount).ToString("N1") + " %";
                            Countlabel.Text = keynum.ToString() + "  Of  " + MaxKeyCount.ToString();
                            Application.DoEvents();
                        }
                    }
                    SW1.Stop();

                    KeyTimelabel.Text = SW1.ElapsedMilliseconds.ToString() + " Mili Seconds";
                    SW1.Reset();
                }
            }

            //------------------------------------------------------------------------------------------
            List<clsDecryptResult> ResultList = new List<clsDecryptResult>();// this is for keeping a list of objects
                                                                             // including keys, their IC and Dictionary scores 

            int row = 0;
            double SumTime = 0;
            int wordLen = Convert.ToInt32(WordLenLenUpDown.Value);

            foreach (string Key in KeyList)
            {
                while (Pause)
                {
                    Application.DoEvents();
                }

                SW1.Start();   // start to calculate the time of Auto key Decrypting time
                row++;

                KeyListBox.SelectedIndex = row - 1;

                var Res = crypto.DecryptAutoKey(CipherText, Key);  

                double Score = CalculateIndexCoincidence(Res);  
                double NormalScore = Convert.ToDouble(FinalTextICMaskEdit.Text);

                if (Score >= NormalScore)
                {
                    ResultList.Add(new clsDecryptResult(Key, Res, Score, NormalScore, 0, 0));
                }

                LogTextBox.AppendText("Key=" + Key + Environment.NewLine + "Score=" + Score + " of " + NormalScore.ToString() + Environment.NewLine + "Text=" + Res + Environment.NewLine + Environment.NewLine);

                PercentLabel.Text = ((row * 100) / KeyList.Count).ToString() + "%";
                Countlabel.Text = row.ToString() + "  Of  " + KeyList.Count.ToString();

                Application.DoEvents();
                SW1.Stop();
                SumTime += SW1.ElapsedMilliseconds;
                LastTimelabel.Text = SW1.ElapsedMilliseconds.ToString() + " Mili Seconds";// the time of last decrypting time
                AverageTimelabel.Text = (SumTime / row).ToString() + " Mili Seconds"; //Average time of Auto key decrypting
                TotalTimelabel.Text = (SumTime / 1000).ToString() + " Seconds";    // the total time of Auto key decrypting
                SW1.Reset();
            }

            if (ResultList.Count == 0)
                FinalResultTextBox.Text = "No Result Found";
            else
            { // checking dictionary score for the generated plaintext
                if (chkDictionary.Checked)
                {
                    foreach (var item in ResultList)
                    {
                        item.DictionaryScore = crypto.CheckEnglishSentence(item.PlainText, true);
                        item.DictionaryNormalScore= item.PlainText.Length / wordLen;
                    }
                }

                foreach (var item in ResultList.OrderByDescending(i => i.DictionaryScore).ThenByDescending(i => i.Score).ToList())
                {
                    FinalResultTextBox.AppendText("Key=" + item.Key + Environment.NewLine + "Score=" + item.Score.ToString() + " of " + item.NormalScore.ToString() +"------Dictionary Score=" + item.DictionaryScore.ToString() + " (!!!!!!!!SUCCESS!!!!!!!!)" + Environment.NewLine + "Text=" + item.PlainText + Environment.NewLine + Environment.NewLine);
                }
            }
            btnICDecrypt.Enabled = true;
        }

        //=======================================================================================================
        //=======================================================================================================
        //=======================================================================================================
        private void rbWithKey_CheckedChanged(object sender, EventArgs e)
        {
            WithKeyPanel.Enabled = rbWithKey.Checked;
        }

        //=======================================================================================================
        //=======================================================================================================
        //=======================================================================================================
        private void rbNoKey_CheckedChanged(object sender, EventArgs e)
        {
            NoKeyPanel.Enabled = rbNoKey.Checked;
        }

        //=======================================================================================================
        //=======================================================================================================
        //=======================================================================================================
        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ICMaskEdit.Enabled = (cmbMode.SelectedIndex == 0);
            ICLevellabel.Enabled = (cmbMode.SelectedIndex == 0);
        }

        //=======================================================================================================
        //=======================================================================================================
        //=======================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMode.SelectedIndex = 0;
        }

        //=======================================================================================================
        //=======================================================================================================
        //=======================================================================================================
    }
}
