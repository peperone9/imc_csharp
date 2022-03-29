using System;

namespace Programa_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;

            //Pegando peso e altura
            Console.Write("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());
            //Calculando IMC
            imc = peso / (altura * altura);
         
            Console.WriteLine($"seu IMC: {imc.ToString("F")}");

            //vERIFICANDO A SITUAÇÃO DO CIDADÃO
            if (imc < 18.5)
                Console.WriteLine("\nVOCÊ ESTÁ  ABAIXO DO PESO, MAGRELO ESQUELÉTICO !!");
            if (imc >= 18.5 && imc <= 24.9)
                Console.WriteLine("\nVOCÊ ESTÁ  NO PESO NORMAL");
            if (imc >= 25 && imc <= 29.9)
                Console.WriteLine("\nVOCÊ ESTÁ  NO SOBREPESO");
            if (imc >= 30 && imc <= 40)
                Console.WriteLine("\nVOCÊ ESTÁ  OBESO, GORDÃO !!");
            if (imc >= 40)
                Console.WriteLine("\nOBESIDADE MORBIDA !! SEU GLUTÃO !!");



        }
    }
}
