namespace Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number:");
            int first_number = int.Parse(Console.ReadLine());
            Console.WriteLine("enter secend number:");
            int secend_number = int.Parse(Console.ReadLine());
           
            for (int i = first_number; i <= secend_number; i++)
            {
                int counter = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    { counter++; }
                }   
                    if (counter == 2)
                    {
                    Console.WriteLine(i);
                    }
            }    
                    
                
            } 

            
        }
    }
