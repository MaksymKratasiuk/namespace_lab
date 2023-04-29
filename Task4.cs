using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_lab
{
    namespace PseudoTextGenerator
    {
        namespace TextGenerator
        {
            public class PseudoTextGenerator
            {
                private Random random;

                private string vowels = "aeiouy";
                private string consonants = "bcdfghjklmnpqrstvwxz";

                public PseudoTextGenerator()
                {
                    random = new Random();
                }

                public string Generate(int vowelCount, int consonantCount, int maxLength)
                {
                    string text = "";
                    int length = random.Next(1, maxLength + 1);
                    int vowelsLeft = vowelCount;
                    int consonantsLeft = consonantCount;

                    while (text.Length < length)
                    {
                        if (vowelsLeft > 0 && (consonantsLeft == 0 || random.Next(2) == 0))
                        {
                            text += GetRandomVowel();
                            vowelsLeft--;
                        }
                        else if (consonantsLeft > 0)
                        {
                            text += GetRandomConsonant();
                            consonantsLeft--;
                        }
                    }

                    return text;
                }

                private char GetRandomVowel()
                {
                    return vowels[random.Next(vowels.Length)];
                }

                private char GetRandomConsonant()
                {
                    return consonants[random.Next(consonants.Length)];
                }
            }
        }

        public class Task4
        {
            public static void num4()
            {
                int vowelCount, consonantCount, maxLength;

                Console.Write(" vowels: ");
                vowelCount = int.Parse(Console.ReadLine());

                Console.Write(" consonants: ");
                consonantCount = int.Parse(Console.ReadLine());

                Console.Write(" maximum length of the word: ");
                maxLength = int.Parse(Console.ReadLine());

                TextGenerator.PseudoTextGenerator generator = new TextGenerator.PseudoTextGenerator();

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(generator.Generate(vowelCount, consonantCount, maxLength));
                }


            }
        }
    }
}
