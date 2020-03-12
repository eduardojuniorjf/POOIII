using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_oo_1
{
    class Usuario{
        String nome, religiao;

        public Usuario(String nome, String religiao) { //Construtor du usuario 
            this.RegUser(nome, religiao);

        }

        public void RegUser(String nome, String religiao) //Registro de funcionarios
        {
            this.nome = nome;
            this.religiao = religiao;
        }

        public string ToString0()
        {
            return "\n\nDados do Usuário" + " \nNome: " + nome + " \nReligião: " + religiao;

        }


    }
}
