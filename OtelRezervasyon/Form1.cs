
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> isim = new List<string>();
        List<int> not1= new List<int>();    
        List<int> not2= new List<int>();
        List<int> not3 = new List<int>();
        List<double> ortalama = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            int nt1 = Convert.ToInt16(textBox2.Text);
            int nt2 = Convert.ToInt16(textBox3.Text);
            int nt3 = Convert.ToInt16(textBox4.Text);
            double ortala=(nt1+nt2+ nt3)/3;
            isim.Add(ad);
            not1.Add(nt1);
            not2.Add(nt2);
            not3.Add(nt3);
            ortalama.Add(ortala);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("Kayıt Eklendi");
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            
            foreach (string s in isim)
            {
                listBox1.Items.Add(s);
            }
            foreach(int i in not1)
            {
                listBox2.Items.Add(i);
            }
            foreach (int t in not2)
            {
                listBox3.Items.Add(t);
            }
            foreach (int y in not3)
            {
                listBox4.Items.Add(y);
            }
            foreach (double z in ortalama)
            {
                listBox5.Items.Add(z);
            }

            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            //alt+shift basılı tut ve mouse sol bas

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bul = Interaction.InputBox("Aranacak Kaydı Girin");
            if (string.IsNullOrEmpty(bul))
            {
                MessageBox.Show("Bir İsim Girmediniz");
            }
            else
            {
              int sayi  =isim.IndexOf(bul);
              //liste içindeki index numarasın gösterir
              if(sayi>-1)
                {

                    MessageBox.Show("Kayıt Bulundu");
                    listBox1.SetSelected(sayi, true);
                    listBox1.BackColor = Color.Brown;
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunmadı");
                }
            }
        }
    }
}
