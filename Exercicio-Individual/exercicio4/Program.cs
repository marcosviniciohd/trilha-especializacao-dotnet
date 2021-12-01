using System;

namespace exercicio4{
    public class Program{
        public static void Main(string[] args){
            Console.WriteLine("Informe seu salário");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Salário antes do ajuste " + salario);

            if(salario <= 2800){
                salario += (salario * 20)/100;
                Console.WriteLine("Seu salário após ajuste é " + salario);
                Console.WriteLine("Percentual de aumento aplicado é de 20%");

            }else if(salario > 2800 && salario < 7000){
                salario += (salario * 15)/100;
                Console.WriteLine("Seu salário após ajuste é " + salario);
                Console.WriteLine("Percentual de aumento aplicado é de 15%");

            }else if(salario > 7000 && salario < 15000){
                salario += (salario * 10)/100;
                Console.WriteLine("Seu salário após ajuste é " + salario);
                Console.WriteLine("Percentual de aumento aplicado é de 10%");
            }else{
                salario += (salario * 5)/100;
                Console.WriteLine("Seu salário após ajuste é " + salario);
                Console.WriteLine("Percentual de aumento aplicado é de 5%");
            }
        }
    }
}