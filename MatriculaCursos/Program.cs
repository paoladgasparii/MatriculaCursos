using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vagasd = 5;
            int vagasa = 5;
            int vagasm = 5;
            int vagase = 5;

            int totald = 0;
            int totala = 0;
            int totalm = 0;
            int totale = 0;

            int continuar = 1;

            while (continuar == 1)
            {
                Console.WriteLine("Insira a opção de curso desejada (D)esenvolvimento (A)dministração (M)ecatrônica (E)dificações: ");
                string curso = Console.ReadLine();

                switch (curso)
                {
                    case "D":
                        if (vagasd > 0)
                        {
                            Console.WriteLine("Você foi matriculado para o curso Desenvolvimento de Sistemas");
                            vagasd--;
                            totald++;
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para este curso");
                        }
                        break;

                        case "A":
                        if (vagasa > 0)
                        {
                            Console.WriteLine("Você foi matriculado para o curso Administração");
                            vagasa--;
                            totala++;
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para este curso");
                        }
                        break;

                        case "M":
                        if (vagasm > 0)
                        {
                            Console.WriteLine("Você foi matriculado para o curso Mecatrônica");
                            vagasm--;
                            totalm++;
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para este curso");
                        }
                        break;

                        case "E":
                        if (vagase > 0)
                        {
                            Console.WriteLine("Você foi matriculado para o curso Edificações");
                            vagase--;
                            totale++;
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para este curso");
                        }
                        break;
                        
                        default:
                        Console.WriteLine("Opção inválida! Tente novamente");
                        break;

                        
                }

                Console.WriteLine("Deseja continuar? (1)Sim (2)Não: ");
                continuar = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Total de matrículas por curso:");
            Console.WriteLine("Desenvolvimento de Sistemas: " + totald);
            Console.WriteLine("Administração: " + totala);
            Console.WriteLine("Mecatrônica: " + totalm);
            Console.WriteLine("Edificações: " +  totale);

            Console.ReadKey();

        }
    }
}
