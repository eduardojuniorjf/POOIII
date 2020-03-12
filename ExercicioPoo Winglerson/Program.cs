using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_oo_1
{
    class Program
    {
        static void Main(string[] args){
            String nome, religiao, cpf, cargo, musica, hobbie;
            int matricula, opcao;


            Console.WriteLine("Qual o formulário será preenchido? ");
            Console.WriteLine("1 - Cadastro de funcionário  | 2 - Rede Social " );
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) {

                Console.Write("Informe o seu nome: ");
                nome = Console.ReadLine();
                Console.Write("Informe o seu CPF: ");
                cpf = Console.ReadLine();
                Console.Write("Informe o seu cargo na empresa: ");
                cargo = Console.ReadLine();
                matricula = 10030;

                Funcionario func = new Funcionario(nome, cpf, cargo, 10030);

                Console.Write(func);
            }

            if (opcao == 2)
            {

                Console.Write("Informe o seu nome: ");
                nome = Console.ReadLine();
                Console.Write("informe a sua Religião: ");
                religiao = Console.ReadLine();
                Console.Write("Informe o seu tipo de música favorita: ");
                musica = Console.ReadLine();
                Console.Write("Informe o seu Hobbie: ");
                hobbie = Console.ReadLine();

                Usuario user = new Usuario (nome, religiao, musica, hobbie);

                Console.Write(user.ToString0());
            }

            Console.ReadKey();
         
        }
    }
}
