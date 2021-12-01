using System;
using System.Collections.Generic;

namespace Exercicio2
{
    public class Program
    {
        public static void Main(string[] args){
            int numeroEntrada = 0;
            bool digitacaoInvalida = true;

            while(digitacaoInvalida){
                try{
                    Console.WriteLine("Digite um número maior que 0 e menor que 10:");
                    numeroEntrada = Convert.ToInt32(Console.ReadLine());

                    if(numeroEntrada > 0 && numeroEntrada < 10){
                        digitacaoInvalida = false;
                        else
                        {
                            Console.WriteLine("Número inválido!!!");
                        }
                    }
                }
                catch{
                    Console.WriteLine("Número inválido");
                }
            }

            int numeroImpar = 0;
            if(numeroEntrada % 2 == 0){
                numeroImpar = numeroEntrada + 1;
            }
            else{
                numeroImpar = numeroEntrada + 2;
            }
            List<int> listaNumerosImpares = new();
            for(int i = 0; i < 20; i++){
                listaNumerosImpares.Add(numeroImpar);
                numeroImpar = numeroImpar + 2;
            }

            int soma = 0;
            foreach(int numero in listaNumerosImpares){
                soma += numero;
            }
        }
    }
}