using System;

namespace ExercicioDeFunções
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string [10]; 
            float[] nota1 = new float [10]; 
            float[] nota2 = new float [10]; 
            float[] nota3 = new float [10]; 
            float[] nota4 = new float [10];
            float[] media = new float[10];

            for(var i = 0; i < 10; i++) {
                Console.Write("Digite o nome do aluno: ");
                nome[i] = Console.ReadLine();
                Console.Write("Digite a nota: ");
                nota1[i] = float.Parse(Console.ReadLine());
                Console.Write("Digite a nota: ");
                nota2[i] = float.Parse(Console.ReadLine());
                Console.Write("Digite a nota: ");
                nota3[i] = float.Parse(Console.ReadLine());
                Console.Write("Digite a nota: ");
                nota4[i] = float.Parse(Console.ReadLine());

                media[i] = ((nota1[i] + nota2[i] + nota3[i] + nota4[i])/4 );
                Console.WriteLine(media[i]);
            }
        }
    }
}
