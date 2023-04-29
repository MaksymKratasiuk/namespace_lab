namespace namespace_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch = -1;
            while (ch != 0)
            {
                Console.WriteLine("enter task number (0-exit)->");
                ch = int.Parse(Console.ReadLine());

                switch (ch) {
                    case 1:
                        Task1.num1();
                        break;
                    case 2:
                        Task2.num2();
                        break;
                    case 3:
                        GuessNumberGame.Task3.num3();
                        break;
                    case 4:
                        PseudoTextGenerator.Task4.num4();
                        break;

                } 
        }
        }
    }
}