// See https://aka.ms/new-console-template for more information
using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Limpa a tela

            Console.WriteLine("Primeiro valor: "); // Escrevendo diretriz para usuario
            float v1 = float.Parse(Console.ReadLine()); // Armazena valor

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(""); // Pular uma linha

            float resultado = v1 + v2; // Resultado (V1/V2)
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


