using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         int sayi;
         string sehir;
         string[] sehirler = new string[6];
       char[] alfabe = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ".ToCharArray();
    
        Random rastgele = new Random();
        
        private void btn_basla_Click(object sender, EventArgs e)
        {
            
            sayi = rastgele.Next(0, 6);
           sehir = sehirler[sayi];
            for (int i = 0; i < alfabe.Length; i++)
            {
                
                Button btn = new Button();
                btn.Name = i.ToString();
                btn.Text = alfabe[i].ToString();
                btn.Width = 20;
                btn.Height =20;
                flowLayoutPanel1.Controls.Add(btn);
            }
            for (int i = 0; i < sehir.Length; i++)
            {
                TextBox txt = new TextBox();
                txt.Name = i.ToString();
                txt.Text = "";
                txt.Width = 20;
                txt.Height = 20;
                flowLayoutPanel2.Controls.Add(txt);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            sehirler[0] = "Samsun";
            sehirler[1] = "Sivas";
            sehirler[2] = "Giresun";
            sehirler[3] = "Ağrı";
            sehirler[4] = "Sakarya";
            sehirler[5] = "Yozgat";
        }
    }
}
