using System;
using System.IO;
using System.Windows.Forms;

namespace TestLab2
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            FileStream fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            txtFileContent.Text = reader.ReadToEnd();
            ShowFileName(openFile.SafeFileName);
            ShowSize(fs.Length);
            ShowURL(openFile.FileName);
            ShowLineCount(fs);
            ShowWordsCount(fs);
            ShowCharacterCount(fs);
            reader.Close();
        }

        void ShowFileName(string filename)
        {
            txtFileName.Text = filename;
        }

        void ShowSize(long size)
        {
            if (size > 1)
            {
                txtSize.Text = size.ToString() + " bytes";
            } 
            else
            {
                txtSize.Text = size.ToString() + " byte";
            }
        }

        void ShowURL(string url)
        {
            txtURL.Text = url;
        }

        void ShowLineCount(FileStream fs)
        {
            fs.Position = 0;
            StreamReader reader = new StreamReader(fs);
            int linecount = 0;
            while (reader.ReadLine() != null)
            {
                linecount++;
            }
            txtLineCount.Text = linecount.ToString();
        }

        void ShowWordsCount(FileStream fs)
        {
            fs.Position = 0;
            StreamReader reader = new StreamReader(fs);
            int wordscount = 0;
            bool wordcounted = false;
            while (reader.Read() != -1)
            {
                if (reader.Peek() == ' ' || reader.Peek() == '\n' || reader.Peek() == -1 || reader.Peek() == '\t')
                {
                    if (wordcounted == false)
                    {
                        wordscount++;
                        wordcounted = true;
                    }
                    else
                    {
                        reader.Read();
                        wordcounted = true;
                    }
                }
                else
                {
                    wordcounted = false;
                } 
            }
            txtWordsCount.Text = wordscount.ToString();
        }

        void ShowCharacterCount(FileStream fs)
        {
            fs.Position = 0;
            StreamReader reader = new StreamReader(fs);
            int charactercount = 0;
            while (reader.Read() != -1)
            {
                charactercount++;
            }
            txtCharCount.Text = charactercount.ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
