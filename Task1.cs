using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_lab
{
    namespace NumberGenerator
    {
        namespace EvenNumbers//парні
        {
            class Generator
            {
                private int current = 0;

                public int Next()
                {
                    current += 2;
                    return current;
                }
            }
        }

        namespace OddNumbers//непарні
        {
            class Generator
            {
                private int current = -1;

                public int Next()
                {
                    current += 2;
                    return current;
                }
            }
        }

        namespace PrimeNumbers//прості
        {
            class Generator
            {
                private int current = 1;

                private bool IsPrime(int number)
                {
                    if (number < 2)
                    {
                        return false;
                    }

                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            return false;
                        }
                    }

                    return true;
                }

                public int Next()
                {
                    do
                    {
                        current++;
                    } while (!IsPrime(current));

                    return current;
                }
            }
        }

        namespace FibonacciNumbers//фібоначі
        {
            class Generator
            {
                private int current = 0;
                private int previous = 1;

                public int Next()
                {
                    int result = current + previous;
                    previous = current;
                    current = result;
                    return result;
                }
            }
        }
    }

    public class Task1
    {
        public static void num1()
        {
            NumberGenerator.EvenNumbers.Generator evenGenerator = new NumberGenerator.EvenNumbers.Generator();
            Console.WriteLine("Перші 10 парних чисел:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(evenGenerator.Next() + " ");
            }
            Console.WriteLine();

            NumberGenerator.OddNumbers.Generator oddGenerator = new NumberGenerator.OddNumbers.Generator();
            Console.WriteLine("Перші 10 непарних чисел:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(oddGenerator.Next() + " ");
            }
            Console.WriteLine();

            NumberGenerator.PrimeNumbers.Generator primeGenerator = new NumberGenerator.PrimeNumbers.Generator();
            Console.WriteLine("Перші 10 простих чисел:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(primeGenerator.Next() + " ");
            }
            Console.WriteLine();

            NumberGenerator.FibonacciNumbers.Generator fibonacciGenerator = new NumberGenerator.FibonacciNumbers.Generator();
            Console.WriteLine("Перші 10 чисел Фібоначчі:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(fibonacciGenerator.Next() + " ");
            }
            Console.WriteLine();
        }
    }
}