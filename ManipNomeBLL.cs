using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaLib;

namespace ManipNome01
{
    class ManipNomeBLL
    {
        public static void validaDados()
        {
            Erro.setErro(false);
            if (ManipNome.getNome().Length == 0)
            {
                Erro.setErro("O campo NOME é de preenchimento obrigatório!");
                return;
            }
        }
    }
}
