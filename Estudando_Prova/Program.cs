using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando_Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Recebe dois números e fornece quatro opções de operações entre eles 
            (soma, subtração, divisão ou multiplicação). */

            double num1 = 0;
            double num2 = 0;
            //variável zerada para poder entrar no while
            int operacao = 0;
            
            //verifica o valor que a variável operacao contém
            while (operacao < 1 || operacao > 4)
            {
                Console.WriteLine("Digite um número");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite outro número");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha uma operação:\n" +
                                    "1 - Soma\n" +
                                    "2 - Subtração\n" +
                                    "3 - Multiplicação\n" +
                                    "4 - Divisão");
                operacao = Convert.ToInt16(Console.ReadLine());
                /*caso o número digitado para escolher uma operação foi diferente de 1,2,3 ou 4 mostra a
                mensagem de erro e pede para o usuário digitar novamente um número válido*/
                if (operacao < 1 || operacao > 4)
                {
                    Console.WriteLine("[ERRO] Número inválido, tente novamente\n");
                    Console.WriteLine("Escolha uma operação:\n" +
                                        "1 - Soma\n" +
                                        "2 - Subtração\n" +
                                        "3 - Multiplicação\n" +
                                        "4 - Divisão\n");
                }
                /*quando o número é válido passa para a verificação do switch case,
                o número digitado deve corresponder a algum dos cases, então fará sua respectiva operação*/
                else
                {
                    switch (operacao)
                    {
                        case 1:
                            double resultSoma = num1 + num2;
                            Console.WriteLine($"O resultado da Soma é: {resultSoma}");
                            break;
                        case 2:
                            double resultSub = num1 - num2;
                            Console.WriteLine($"O resultado da Subtração é: {resultSub}");
                            break;
                        case 3:
                            double resultMult = num1 * num2;
                            Console.WriteLine($"O resultado da Multiplicação é: {resultMult}");
                            break;
                        default:
                            double resultDiv = num1 / num2;
                            Console.WriteLine($"O resultado da Divisão é: {resultDiv}");
                            break;
                    };
                }
            }
            Console.ReadKey();
        }
    }
}
