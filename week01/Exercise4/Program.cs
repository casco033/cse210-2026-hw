using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();

            if (int.TryParse(userNumber, out int num))
            {
                if (num == 0)
                {
                    
                    break; 
                }
                    
                numbers.Add(num); 
            }
            else
            {
                
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        if (numbers.Count > 0)
        {
        
            int sum = numbers.Sum();
            Console.WriteLine($"The sum of the numbers is: {sum}");

            
            double average = numbers.Average();
            Console.WriteLine($"The average of the numbers is: {average}");

            
            int max = numbers.Max();
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            
            Console.WriteLine("No numbers were entered.");
        }
       
    }
}