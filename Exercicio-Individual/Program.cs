using System;

namespace Exercicio3{
    public class Exercicio3{
        public static void Main(string[] args){
            Console.WriteLine("Digite o preço do primeiro produto!");
            double produto1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o preço do segundo produto!");
            double produto2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o preço do terceiro produto!");
            double produto3 = Convert.ToDouble(Console.ReadLine());


            if(produto1 < produto2 && produto1 < produto3){
                Console.WriteLine("Compre o produto 1, ele é o mais barato");
            }
            
            else if(produto2 < produto1 && produto2 < produto3)
            {
                Console.WriteLine("Compre o produto 2, ele é o mais barato");
            }else{
                Console.WriteLine("Compre o produto 3, ele é o mais barato");
            }
            
            

        }
    }
}