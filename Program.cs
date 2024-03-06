// See https://aka.ms/new-console-template for more information
using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}"); //interpolação de string
            Console.WriteLine($"O resultado da soma é {v1+ v2}");// envolvendo variaveis

        }
        
    }
}

/*
 * 
 *  Explicando o codigo;
 *  
 *  Console.Clear = Remove qualquer texto anteriormente exibido.
 *  ReadLine = Lê uma linha de texto da entrada padrao (teclado) l'13
 *  Read = Este metodo lê o proximo caractere da entra padrao.
 *  ReadKey = Lê o proximo caractere ou tecla de função pressionada na console 
 *          nao possui necessidade de pressionar enter.
 *  float.Parse() = Converte uma string em um valor float que foi armazenado
 *          na variavel "v1".
 *  
 *  Explicando alguma sugestões de concatenação e interpolação de string.
 *          
 *      
 * 
 * 
 * **/


