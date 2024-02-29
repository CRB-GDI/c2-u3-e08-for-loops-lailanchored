namespace Excercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What is the maximum number : ");
            int maxNum = int.Parse(Console.ReadLine());
       

            int evenNums = 0;

            for (evenNums = 0; evenNums <= maxNum;evenNums += 2)

            {

                Console.WriteLine(" Even Numbers of " + maxNum + " are " + evenNums);


               

            }
            //end ur loop

            //start prob 2
        {

                Console.Write("What Row Ridth");
                int rowWidth = int.Parse(Console.ReadLine());
                int asteriskCount = 0;

                for (asteriskCount = 0; rowWidth > asteriskCount; asteriskCount++)
                {

                    Console.Write("*");
                    // int.Parse(Console.WriteLine("*" * rowWidth));







                }

            }
            
        }
    }
}