using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Pass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] rakam = { 1, 9, 0, 7, 6, 8 };
            String[] kücük = { "d", "a", "m", "l", "n", "u", "r", };
            string uretk = "";
            string uretb = "";
            string rakam1 = "";
            String[] büyük = { "D", "A", "M", "L", "N", "U", "R", };
            int a, b, c;
            a = Convert.ToInt32(txtbüyük.Text);
            b = Convert.ToInt32(txtkücük.Text);
            c = Convert.ToInt32(txtrakam.Text);
            Random rnd = new Random();
            for (int i = 0; i < b; i++)
            {
                int rastgele = rnd.Next(0, kücük.Length);
                uretk += kücük[rastgele];

            }
            for (int i = 0; i < a; i++)
            {
                int rastgele = rnd.Next(0, büyük.Length);
                uretb += büyük[rastgele];

            }
            for (int i = 0; i < c; i++)
            {
                int rastgele = rnd.Next(0, rakam.Length);
                rakam1 += rakam[rastgele];

            }
            label4.Text = uretk + uretb + rakam1.ToString();
        }
    }
}
