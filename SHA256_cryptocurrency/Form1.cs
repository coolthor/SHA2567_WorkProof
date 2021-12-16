using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace SHA256_cryptocurrency
{
    public partial class Form1 : Form
    {
        string header = "0";
        BackgroundWorker backgroundworker;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            backgroundworker = new BackgroundWorker();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
            
            backgroundworker.DoWork += (sender, e) => {
                btnGetSHA256.Enabled = false;
                SHA256 mySHA256 = SHA256.Create();
                sw.Reset();//碼表歸零
                sw.Start();//碼表開始計時
                for (ulong ul = 0; ul < Math.Pow(2, 256); ul++)
                {
                    txtInput.Text = ul.ToString();

                    byte[] byteArray = BitConverter.GetBytes(ul);
                    string strbinhash = "";
                    byte[] hashArray = mySHA256.ComputeHash(byteArray);
                    for (int i = 0; i < hashArray.Length; i++)
                        strbinhash += Convert.ToString(hashArray[i], 2);

                    textBox1.Text = strbinhash;

                    if (strbinhash.Substring(0, header.Length) == header)
                    {
                        sw.Stop();
                        return;
                    }
                }
            };

            backgroundworker.RunWorkerCompleted += (sender, e) => {
                btnGetSHA256.Enabled = true;
                lblUsedtime.Text = sw.Elapsed.TotalMilliseconds.ToString() + "ms";
            };

            for (int i = 1; i < 256; i++)
                cboZeroHeader.Items.Add(i);
        }

        private void btnGetSHA256_Click(object sender, EventArgs e)
        {

            backgroundworker.RunWorkerAsync();
        }

        private void cboZeroHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            header = "";
            for (int i = 0; i < ((ComboBox)sender).SelectedIndex + 1; i++)
                header += "0";
        }
    }
}
