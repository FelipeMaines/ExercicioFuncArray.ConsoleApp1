using System;
using System.Xml;

namespace ExercicioFuncArray.ConsoleApp1
{
    internal class Program
    {
        static int[] ColocarValoresArray()
        {
            for (int i = 0; i < numeros.Length; i++)
            {

                Console.WriteLine($"Qual valor deseja adicionar no index {i}");
                numeros[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            return numeros;
        }
       
        static int[] OrdenarArray()
        {
            Array.Sort(numeros);
            return numeros;
        }

        static int PegarMaiorValor()
        {
            maiorNumero = numeros[numeros.Length - 1];
            return maiorNumero;
        }

        static int PegarMenorValor()

            
        {
            menorNumero = numeros[0];
            return menorNumero;
        }

        static int PegarValorMedio()
        {
          valorMedio = (numeros.Length - 1) / 2;
          valorMedio = numeros[valorMedio];
          return valorMedio;
        }

        static int[] PegarTresMaiores()
        {
            tresMaiores[2] = maiorNumero = PegarMaiorValor();
            tresMaiores[1] = segundoMaior = numeros[numeros.Length - 2];
            tresMaiores[0] = terceiroMaior = numeros[numeros.Length - 3];

            return tresMaiores;
        }

        static int[] PegarValoresNegativos ()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                { valorNegativo[i] = numeros[i]; }
            }
            return valorNegativo;
        }

        static int[] VerValoresFunctions(int[] array)
        {
            if (array == valorNegativo)
            {
                if (valorNegativo[0] == 0)
                {
                    Console.WriteLine("Nenhum valor negativo! ");
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if ((valorNegativo[i] < 0))
                            Console.WriteLine(array[i]);

                        else
                            continue;
                    }
                }
                
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
           
            return array;
        }

        static void MostrarValores ()
        {
            Console.WriteLine($"Maior Valor: {maiorNumero}\n");
            Console.WriteLine($"Menor Valor: {menorNumero}\n");
            Console.WriteLine($"Valor Medio: {valorMedio}\n");
            Console.Write($"Tres Maiores Valores: \n"); 
            VerValoresFunctions(tresMaiores);
            Console.WriteLine($"\nValores Negativos: ");
            VerValoresFunctions(valorNegativo);
            Console.WriteLine($"\nTodos os valores: "); 
            VerValoresFunctions(numeros);
        }

        static void DeletarPosicaoArray()
        {
            Console.Write("Qual posicao deseja deletar: ");
            int valor = int.Parse(Console.ReadLine());
            numeros = numeros.Where((source, index) => index != valor).ToArray();
            VerValoresFunctions(numeros);

        }
        static void Main(string[] args)
        {
            ColocarValoresArray();
            OrdenarArray();
            PegarMaiorValor();
            PegarMenorValor();
            PegarValorMedio();
            PegarTresMaiores();
            PegarValoresNegativos();
            MostrarValores();
            DeletarPosicaoArray();
        }

        static int[] numeros = new int[10];
        static int maiorNumero, menorNumero, segundoMaior, terceiroMaior, valorMedio;
        static int[] tresMaiores = new int[3];
        static int[] valorNegativo = new int[10];
    }

}