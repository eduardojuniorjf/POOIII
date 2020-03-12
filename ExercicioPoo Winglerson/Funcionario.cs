using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_oo_1
{
    class Funcionario{
         String nome, cpf, cargo;
         int matricula;

     
        public Funcionario(String nome, String cpf, String cargo, String religiao, int matricula)//Construtor do objeto funcionário, só funciona se o CPF for válido
        {
            if(this.ValidaCpf(cpf))
            this.RegFunc(nome, cpf, cargo, religiao, matricula);
        }

        public void RegFunc(String nome, String cpf, String cargo, String religiao,  int matricula) //Registro de funcionarios
        {
            this.nome = nome;
            this.cpf = cpf;
            this.cargo = cargo;
            this.matricula = matricula;
        }


        public Boolean ValidaCpf(String cpf) {
            return true;

        }

        public override string ToString()
        {
            return "Dados do Funfionário" + " \nNome: " + nome + " \nCPF: " + cpf + " \nCargo: " + cargo +  " \nMatricula: " + matricula;

        }


    }





}

