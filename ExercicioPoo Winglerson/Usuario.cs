using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_oo_1
{
    class Usuario{
        String nome, religiao, musica, hobbie ;

        public Usuario(String nome, String religiao, String musica, String hobbie ) { //Construtor du usuario 
            this.RegUser(nome, religiao, musica, hobbie);

        }

        public void RegUser(String nome, String religiao, String musica, String hobbie) //Registro de funcionarios
        {
            this.nome = nome;
            this.religiao = religiao;
            this.musica = musica;
            this.hobbie = hobbie;
        }

        public string ToString0()
        {
            return "\n\nDados do Usuário" + " \nNome: " + nome + " \nReligião: " + religiao + "\nTipo de música favorita: " + musica + "\nHobbie: " + hobbie;

        }


    }
}
