using System;
using System.IO;
using System.Text;

namespace Security_P1
{
    public class clsFiling
    {
        private clsFiling()
        {
        }

        private static clsFiling _Instance;
        public static clsFiling Instance
        {
            get
            {
                if (_Instance is null)
                {
                    _Instance = new clsFiling();
                }
                return _Instance;
            }
            set
            {
                _Instance = value;
            }
        }

//=======================================================================================
        public bool LoadTextFromFile(string Address, ref string Text)
        {
            string ReadStr = "";
            try
            {
                if (File.Exists(Address))
                {
                    var objReader = new StreamReader(Address, Encoding.Default);
                    ReadStr = objReader.ReadToEnd();
                    objReader.Close();
                    Text = ReadStr;
                }
                else
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool SaveTextInFile(string Text, string Address)
        {
            try
            {
                var objWriter = new StreamWriter(Address, false, Encoding.Default);
                objWriter.Write(Text);
                objWriter.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SaveTextInFileUnicode(string Text, string Address)
        {
            try
            {
                var objWriter = new StreamWriter(Address, false, Encoding.UTF8);
                objWriter.Write(Text);
                objWriter.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
