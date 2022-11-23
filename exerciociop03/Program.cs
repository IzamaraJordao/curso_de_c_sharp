using exerciociop03;
using System;
using System.Globalization;

namespace Exercicios
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Nome do Aluno: ");
            aluno.Name = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota: ");
            aluno.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a segunda nota: ");
            aluno.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a terceira nota: ");
            aluno.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("NOTA FINAL = "
                + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }
        }
    }
}


