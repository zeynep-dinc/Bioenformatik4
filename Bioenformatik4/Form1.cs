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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (jc.Checked)
                {
                    JCForm jC = new JCForm();
                    jC.Show();
                    this.Hide();
}
                else
                {
                    KimuraForm kimuraForm = new KimuraForm();
                    kimuraForm.Show();
                    this.Hide();
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

       
    }
}
