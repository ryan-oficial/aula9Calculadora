using System;

namespace Aula9Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica calc = new CalculadoraCientifica();
            System.Console.WriteLine("Faça o seu calculo:\nUse os seguintes operadores:\n+ para soma\n- para subtraçao\n* para multiplicaçao\n/ para divisao");
            string calculo = Console.ReadLine();
            calc.ManipularCalcular(calculo);
            System.Console.WriteLine("resultado: "+calc.resultado);

            calc.resultado = 0;
            

            


        }
    }
}
