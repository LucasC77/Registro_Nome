using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipNome01
{
    public partial class SaidaIHM : Form
    {
        public SaidaIHM()
        {
            InitializeComponent();
        }

        private void SaidaIHM_Load(object sender, EventArgs e)
        {
            textBox1.Text = ManipNome.getUltimoEspaco().ToString();
            textBox2.Text = ManipNome.getSobrenome();
            textBox3.Text = ManipNome.getNomeF1();
            textBox4.Text = ManipNome.getNomeF2();
            textBox5.Text = ManipNome.getNomeF3();
        }
    }
}
