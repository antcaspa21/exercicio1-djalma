namespace exercicio1_djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1
            double nota1, nota2, media;
            Console.WriteLine(" digite o nome do aluno:");
            Console.ReadLine();
            Console.WriteLine("digite a nota da primeira prova:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a nota da segunda prova:");
            nota2 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2) / 2;
            Console.WriteLine("media das notas:" + media);
            if (media >= 8.5)
            {
                Console.WriteLine("nota A!");
            }
            else if (media >= 7)
            {
                Console.WriteLine("nota B!");
            }
            else if (media >= 6)
            {
                Console.WriteLine("nota C!");
            }
            else if (media < 6)
            {
                Console.WriteLine("nota D!");
            }
            else if (media <= 0.1)
            {
                Console.WriteLine("nota E!");
            }
            Console.ReadKey();
        }
    }
}