namespace Excercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What is the maximum number : ");
            int maxNum = int.Parse(Console.ReadLine());
       

            int evenNums = 2;

            for (int i = 0; i < maxNum; i++)
            { 
            Console.Write("Even Numbers of" + maxNum + "are" + i - evenNums);

        }
            
        }
    }
}