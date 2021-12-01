using System;

namespace ProgramacaoOrientadaObjetos{
 public class Program
    {
        public static void Main(string[] args){

            Pessoa objetoPessoa = new Pessoa();

            objetoPessoa.Nome = "Marcos";
            objetoPessoa.Sobrenome = "Fernandes";
            objetoPessoa.DataNascimento = DateTime.Now;

            Console.WriteLine($"O nome da pessoa é: {objetoPessoa.Nome} {objetoPessoa.Sobrenome}");

            Pessoa novoObjetoPessoa = new Pessoa("Marcos", "Vinício", new DateTime(1986, 04, 04));
            Console.WriteLine($"O nome da pessoa: {novoObjetoPessoa.Nome} {novoObjetoPessoa.Sobrenome}. {novoObjetoPessoa.CalculaIdade()}");
            
        }
    } 

}