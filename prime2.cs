//find a prime number between 1 to 15 
using System;
public class prime2
{
    public static void Main(string[] args)
    {
        for(int i=2; i<=15; i++) //i=2,3,4,5
        {
            int isPrime=0;   // isprime=0
                for(int j=2 ; j<i; j++)  // j=2 2<4
                {
                    if(i%j==0) // 4%2 true 
                    {
                        isPrime=1; // isprime= 1
                        break; 
                    }
                }
                if(isPrime==0) // 1=0 false
                {
                    System.Console.WriteLine(i);// 2, 3
                }
        }
    }
}