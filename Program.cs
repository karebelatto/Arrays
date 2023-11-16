using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //  pode colocar string, bool no lugar do int, não tem problema
            // var meuArray = new int[5] { 23, 42, 54, 67, 99 };
            // meuArray[0] = 12;

            // var meuArray = new Teste[2];
            // meuArray[0] = new Teste();

            // Console.WriteLine(meuArray[0].Id);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);
            // Console.WriteLine(meuArray[4]);
            // Console.WriteLine(meuArray[5]); o 5 não existe logo dará erro

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            // Console.WriteLine(meuArray.Length);
            // Percorrer o array
            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }

            // Foreach
            // foreach (var item in meuArray)
            //     Console.WriteLine(item);

            // var funcionarios = new Funcionario[5];
            // funcionarios[0] = new Funcionario() { Id = 1234, Nome = "karine" };

            // foreach (var funcionario in funcionarios)
            // {
            //     Console.WriteLine(funcionario.Id);
            //     Console.WriteLine(funcionario.Nome);
            // }

            // var primeiro = new int[4];
            // var segundo = new int[4];

            // segundo[0] = primeiro[0];

            // primeiro[0] = 23;
            // Console.WriteLine(segundo[0]);



        }

        public struct Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        //     struct Teste
        //     {
        //         public int Id { get; set; }
        //     }
    }
}