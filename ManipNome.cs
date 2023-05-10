using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipNome01
{
    class ManipNome
    {
        private static String nome;

        public static void setNome(String _nome) { nome = _nome; }
        public static String getNome() { return nome; }
        public static int getUltimoEspaco()
        {
            int i;

            for (i = nome.Length - 1; nome[i] != ' '; --i) ;
            return i;
        }
        public static String getSobrenome()
        {
            //return nome.Substring(getUltimoEspaco() + 1, nome.Length - getUltimoEspaco() - 1);
            string[] dadosSobrenome = nome.Split(' ');
            return (dadosSobrenome[dadosSobrenome.Length - 1]);
        }
        public static String getNomeF1()
        {
            //return nome.Substring(getUltimoEspaco() + 1, nome.Length - getUltimoEspaco() - 1) + ", " + nome.Substring(0, getUltimoEspaco());
            String[] dadosSobrenome = nome.Split(' ');
            String aux = dadosSobrenome[dadosSobrenome.Length - 1] + "," + dadosSobrenome[0] + " ";
            
            
            for(int i = 1;i < dadosSobrenome.Length - 1;++i)
            {
                //aux += dadosSobrenome[dadosSobrenome.Length - i] + " ";
                 aux += dadosSobrenome[i] + " ";
                //Maricota Gouveia Henrique Marques Silva
            }
            return aux;
        }


        public static String getNomeF2()
        {
            String[] dadosSobrenome = nome.Split(' ');
            String aux = dadosSobrenome[dadosSobrenome.Length - 1] + "," + dadosSobrenome[0] + ".";
            //String aux = getSobrenome() + ", " + nome[0] + ". ";
            for (int i = 1; i < dadosSobrenome.Length - 1; ++i)
            {
               // for (int i = 1; i < getUltimoEspaco(); ++i)
           // {
                //if (nome[i] == ' ')
                {
                    aux += dadosSobrenome[i][0] + ". ";
                }
            }
            return aux;
        }
          
        public static String getNomeF3()
        {
            String aux = "";
            for (int i = nome.Length-1; i >= 0; --i)
            {
                aux += nome[i];
            }
            return aux;
        }

    }
}
