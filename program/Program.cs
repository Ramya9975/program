using System;

public class Program
{
    public static void Main()
    {
       
        int num1, num2, temp;
        //ask for numbers
        Console.WriteLine("\nEnter the First Number : ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter the Second Number : ");
        num2 = int.Parse(Console.ReadLine());
      
        temp = num1;
        num1 = num2;
        num2 = temp;
      
        Console.WriteLine("After Swapping : ");
        Console.WriteLine("First Number : " + num1);
        Console.WriteLine("Second Number : " + num2);

    }
}
