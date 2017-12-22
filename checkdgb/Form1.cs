using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Win32;
using System.IO;


namespace checkdgb
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Activated += Form1_Activated;
        }

        void Form1_Activated(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AyarCek()
        {
            try
            {
                var tmp = File.ReadAllText("Ayar.txt").Trim();
                var aralik = tmp.Split('=')[1].ToString().Trim();
                var aralikInt = Int32.Parse(aralik);
                timer1.Interval = aralikInt;
            }
            catch (Exception ex)
            {
                
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshCoin();
            AyarCek();
            timer1.Start();

         
        }

        private static void SetStartup()
        {
            try
            {
                 RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            //if (chkStartUp.Checked)
            rk.SetValue("checkdgb", Application.ExecutablePath.ToString());
            //else
            //    rk.DeleteValue("checkdgb",false);            
            }
            catch (Exception ex)
            {
                
            }

        }

        private static void DeleteStartup()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                rk.DeleteValue("checkdgb", false);
            }
            catch (Exception ex)
            {

            }

        }

        private void RefreshCoin()
        {
            var tmp = "";
            try
            {
                tmp = CheckCoin();
            }
            catch (Exception)
            {
                tmp = "!";
            }
            try
            {

            }
            catch (Exception ex)
            {
                
                throw;
            }
            try
            {
                tmp = EditNumbers(tmp);
            }
            catch (Exception ex)
            {

                tmp = "!";
            }
            CreateTextIcon(tmp);
        }

        public void CreateTextIcon(string str)
        {
            Font fontToUse = new Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Pixel);
            Brush brushToUse = new SolidBrush(Color.White);
            Bitmap bitmapText = new Bitmap(16, 16);
            Graphics g = System.Drawing.Graphics.FromImage(bitmapText);

            IntPtr hIcon;

            g.Clear(Color.Transparent);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.DrawString(str, fontToUse, brushToUse, -2, -2);
            hIcon = (bitmapText.GetHicon());
            notifyIcon1.Icon = System.Drawing.Icon.FromHandle(hIcon);
            //DestroyIcon(hIcon.ToInt32);
        }

        private static string CheckCoin()
        {
            var url = new Uri("https://api.coinmarketcap.com/v1/ticker/digibyte/?convert=BTC");
            var d1 = DateTime.Now;
            var d2 = DateTime.Now;

            var tmpr = "";
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    var str = webClient.DownloadString(url);
                    var jar = (Newtonsoft.Json.Linq.JArray)JsonConvert.DeserializeObject(str);

                    foreach (var prc in from JObject item in jar select item.GetValue("price_btc"))
                    {
                        tmpr = prc.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                tmpr = "!";
            }
            return tmpr;
        }

        private static string EditNumbers(string nmb)
        {
            nmb = nmb.Split('.')[1];
            var tmp = "";
            var count = 0;
            foreach (var t in nmb)
            {
                if (t.ToString() != "0")
                    count++;
                if (count > 0)
                {
                    tmp += t.ToString();
                }
            }
            return tmp.Where((t, i) => i < 3).Aggregate("", (current, t) => current + t);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                RefreshCoin();
            }
            catch (Exception ex)
            {
                    
               
            }

        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void başlangıcaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStartup();

        }

        private void başlangıçtanÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStartup();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"iletisim@mehmetcanyegen.com.tr", @"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ayarYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyarCek();
        }

    }

}
