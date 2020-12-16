using System;
public class prime
{
    public static void Main(string[] args)
    {
        int isPrime=0,N; //5
        Console.WriteLine("Enter a number ");
        N=Convert.ToInt32(Console.ReadLine());
        for(int i=2; i<N; i++)
        {
            if(N%i==0)
            {
                System.Console.WriteLine(N+" : is not Prime Number");
                isPrime=1; 
                break;
            }
        }
        if(isPrime==0)  //isPrime=0 0==0 true
        {
            System.Console.WriteLine(N+" : is prime number"); // 5 : is prime number
        }
    }
}