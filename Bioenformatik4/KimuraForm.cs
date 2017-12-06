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
    public partial class KimuraForm : Form
    {
        public KimuraForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float q = Convert.ToSingle(textBox1.Text);
                float p = Convert.ToSingle(textBox2.Text);
                float K;
                K =(float) ((float)(0.5) * (Math.Log((1 / (1 - (2 * p) - q)), Math.E)) + (float)(0.25*Math.Log((1/(1-2*q)),Math.E)));
                listBox1.Items.Add("Transversiyon(Q):"+q);
                listBox1.Items.Add("Transisyon(P):" + p);
                listBox1.Items.Add("Uzaklık" + Math.Round(K,4));
                listBox1.Items.Add("-----------");
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
