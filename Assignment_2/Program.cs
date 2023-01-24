namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalEven = 0;
            int totalOdd = 0;
            for(int i =0; i<10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"{i} is an even number");

                    totalEven += i;
                }
                else
                {
                    Console.WriteLine($"{i} is an odd number");

                    totalOdd += i;
                }

               
            }

            Console.WriteLine($"Total of even numbers:{totalEven}");
            Console.WriteLine($"Total of odd numbers:{totalOdd}");


        }
    }
}