using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace TestLab2
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        string zippath = "input5";
        string filezippath = "output5.zip";
        string unzippath = "output5";

        private void btnZip_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filezippath)) //not exists
            {
                ZipFile.CreateFromDirectory(zippath, filezippath);
                using (ZipArchive archive = new ZipArchive(File.Open(filezippath, FileMode.Open, FileAccess.ReadWrite), ZipArchiveMode.Update))
                {
                    ZipArchiveEntry[] entries = archive.Entries.ToArray();
                    foreach (ZipArchiveEntry entry in entries)
                    {
                        if (entry.Name == "input5.txt")
                        {
                            ZipArchiveEntry newEntry = archive.CreateEntry("output5.txt");
                            using (Stream stream = entry.Open())
                            {
                                using (Stream newstream = newEntry.Open())
                                {
                                    stream.CopyTo(newstream);
                                }
                            }
                            entry.Delete();
                        }
                    }
                }
                MessageBox.Show("Compression completed.");
            }
            else
            {
                MessageBox.Show("Zip file already exists.");
            }
        }

        private void btnUnzip_Click(object sender, EventArgs e)
        {
            ZipFile.ExtractToDirectory(filezippath, unzippath);
            MessageBox.Show("Decompression completed.");
        }
    }
}
