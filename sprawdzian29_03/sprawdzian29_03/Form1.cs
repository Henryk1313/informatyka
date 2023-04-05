using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprawdzian29_03
{
    
    public partial class aplikacjaOkienkowa : Form
    {
        
        public aplikacjaOkienkowa()
        {
            InitializeComponent();
            string slowo;
            
        }
        private char szyfrDuze (char c, int k)
        {
            int i = 0;
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            while (s[i] != c)
            {
                i++;
            }
            return s[(i + k) % 26];
        }
        private char szyfrMale(char c, int k)
        {
            int i = 0;
            string s = "abcdefghijklmnopqrstvwxyz";
            while (s[i] != c)
            {
                i++;
            }
            return s[(i + k) % 26];
        }
        private char szyfrCyfry(char c, int k)
        {
            int i = 0;
            string s = "0123456789";
            while (s[i] != c)
            {
                i++;
            }
            return s[(i + k) % 10];
        }

        private char odszyfrowanieDuze(char c, int k)
        {
            int k1 = k % 26;
            int i = 0;
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            while (s[i] != c)
            {
                i++;
            }
            if (i - k1 < 0) { return s[(i - k1 + 26) % 26]; }
            else
                return s[(i - k1) % 26];
        }
        char odszyfrowanieMale(char c, int k)
        {
            int k1 = k % 26;
            int i = 0;
            string s = "abcdefghijklmnopqrstuvwxyz";
            while (s[i] != c)
            {
                i++;
            }
            if (i - k1 < 0) { return s[(i - k1 + 26) % 26]; }
            else
                return s[(i - k1) % 26];
        }
        char odszyfrowanieCyfry(char c, int k)
        {
            int k1 = k % 10;
            int i = 0;
            string s = "0123456789";
            while (s[i] != c)
            {
                i++;
            }
            if (i - k1 < 0) { return s[(i - k1 + 10) % 10]; }
            else
                return s[(i - k1) % 10];
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_szyfr.Text = "";
        }

        private void txt_szyfr_TextChanged(object sender, EventArgs e)
        {

        }

        private void numud1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkWielkie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkCyfry_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string slowo = txt_szyfr.Text;
            string zaszyfrowane="";
            char c, g;
            int liczba = Convert.ToInt32(numud1.Value);
            for (int i = 0; i < slowo.Length; i++)
            {
                if (radioszyfr.Checked)
                {
                    if ('A' <= slowo[i] && slowo[i] <= 'Z')
                    {
                        if (checkWielkie.Checked)
                        {
                            zaszyfrowane = zaszyfrowane + szyfrDuze(slowo[i], liczba);
                        }
                        else { zaszyfrowane = zaszyfrowane + '*'; }
                    }
                    if ('a' <= slowo[i] && slowo[i] <= 'z')
                    {
                        if (checkMale.Checked)
                        {
                            zaszyfrowane = zaszyfrowane + szyfrMale(slowo[i], liczba);
                        }
                        else { zaszyfrowane = zaszyfrowane + '*'; }
                    }
                    if ('0' <= slowo[i] && slowo[i] <= '9')
                    {
                        if (checkCyfry.Checked)
                        {
                            zaszyfrowane = zaszyfrowane + szyfrCyfry(slowo[i], liczba);
                        }
                        else { zaszyfrowane = zaszyfrowane + '*'; }
                    }
                }
                if (radiodeszyfr.Checked)
                {
                    if ('A' <= slowo[i] && slowo[i] <= 'Z')
                    {
                        if (checkWielkie.Checked)
                        {
                            zaszyfrowane = zaszyfrowane + odszyfrowanieDuze(slowo[i], liczba);
                        }
                        else { zaszyfrowane = zaszyfrowane + '*'; }
                    }
                    if ('a' <= slowo[i] && slowo[i] <= 'z')
                    {
                        if (checkMale.Checked)
                        {
                            zaszyfrowane = zaszyfrowane + odszyfrowanieMale(slowo[i], liczba);
                        }
                        else { zaszyfrowane = zaszyfrowane + '*'; }
                    }
                    if ('0' <= slowo[i] && slowo[i] <= '9')
                    {
                        if (checkCyfry.Checked)
                        {
                            zaszyfrowane = zaszyfrowane + odszyfrowanieCyfry(slowo[i], liczba);
                        }
                        else { zaszyfrowane = zaszyfrowane + '*'; }
                    }
                }
            }
            MessageBox.Show(zaszyfrowane, "szyfr");
        }
    }
}
