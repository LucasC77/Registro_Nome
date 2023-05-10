using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaLib;

namespace ManipNome01
{
    public partial class EntradaIHM : Form
    {
        public EntradaIHM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManipNome.setNome(textBox1.Text);
            ManipNomeBLL.validaDados();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                SaidaIHM saida = new SaidaIHM();
                saida.Show();
            }
        }
    }
}
