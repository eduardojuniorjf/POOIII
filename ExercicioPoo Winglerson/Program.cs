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
            String nome, religiao, cpf, cargo;
            int matricula;

            nome = "Winglerson";
            cpf = "100.200.300-45";
            religiao = "Umbanda";
            cargo = "Marceneiro Pleno";
            matricula = 10030;

            Funcionario  func = new Funcionario(nome , cpf, cargo, religiao, 10030);
            Usuario user = new Usuario(nome, religiao);


            Console.Write(func);

            Console.Write(user.ToString0());

            Console.ReadKey();
         
        }
    }
}
