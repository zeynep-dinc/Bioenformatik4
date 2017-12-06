using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioenformatik4
{
    public partial class JCForm : Form
    {
        public JCForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p,K;
            p= Convert.ToSingle(textBox1.Text);
            if (p < 0)
            {
                MessageBox.Show("0,0.75 aralığı");
                listBox1.Items.Add("Hatalı Değer"+p);
                listBox1.Items.Add("-----------");
            }


            else if (p > 0.75)
            {
                MessageBox.Show("[0;0.75]");
               
                listBox1.Items.Add("Hatalı Değer"+p);
                listBox1.Items.Add("-----------");
            }
            else
            {
                try
                {
                    K = (float)(-0.75) * (float)(Math.Log((1 - (1.33 * p)), Math.E));
                    listBox1.Items.Add("Uzaklık" + Math.Round(K,4));
                    listBox1.Items.Add("Yer değiştirme oranı:" + p);
                    listBox1.Items.Add("************");
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }  }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }
    }
}
