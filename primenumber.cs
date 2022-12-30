

namespace Logicalprograms
{
    public class PrimeNumber
    {
        public static void PrimeN()
        {

            Console.WriteLine("Enter the number to check Prime Number");

            int a = Convert.ToInt32(Console.ReadLine());


            if (a == 1)
            {
                Console.WriteLine(a + " is not a prime number");

            }

            else
            {
                int i, b, c = 0;

                {
                    b = a / 2;
                    for (i = 2; i <= b; i++)
                    {
                        if (a % i == 0)
                        {
                            Console.WriteLine(a + " is not a prime number");
                            c = 1;
                            break;
                        }
                    }
                }
                if (c == 0)
                {
                    Console.WriteLine(a + " is a prime number");
                }

            }

        }
    }
}