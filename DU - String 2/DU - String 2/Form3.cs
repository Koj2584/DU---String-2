using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DU___String_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posun = (int)numericUpDown1.Value;
            string vstup = textBox1.Text;
            char[] vystup = new char[vstup.Length];
            int i = 0;
            foreach(char c in vstup)
            {
                if((c>='a'&&c<='z')||(c>='A'&&c<='Z'))
                {
                    if ((c + posun <= 'z' && c + posun >= 'a'&& c >= 'a' && c <= 'z') || (c + posun <= 'Z' && c + posun >= 'A'&& c >= 'A' && c <= 'Z'))
                    {
                        vystup[i] = (char)(c + posun);
                    }
                    else
                        vystup[i] = (char)(c + (posun-26));
                }
                else
                    vystup[i] = c;
                i++;
            }

            textBox2.Text = new string(vystup);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int posun = (int)numericUpDown1.Value;
            string vstup = textBox1.Text;
            char[] vystup = new char[vstup.Length];
            int i = 0;
            foreach (char c in vstup)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if ((c - posun <= 'z' && c - posun >= 'a' && c >= 'a' && c <= 'z') || (c - posun <= 'Z' && c - posun >= 'A' && c >= 'A' && c <= 'Z'))
                    {
                        vystup[i] = (char)(c - posun);
                    }
                    else
                        vystup[i] = (char)(c - (posun - 26));
                }
                else
                    vystup[i] = c;
                i++;
            }

            textBox2.Text = new string(vystup);
        }
    }
}
