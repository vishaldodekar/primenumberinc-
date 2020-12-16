// sum of prime between 1 to 15

using System;
public class prime2
{
    public static void Main(string[] args)
    {   
        int sum=0;
        for(int i=2; i<=15; i++) 
        {
            int isPrime=0;
                for(int j=2 ; j<i; j++)  
                {
                    if(i%j==0) 
                    {
                        isPrime=1; 
                        break; 
                    }
                }
                if(isPrime==0)
                {
                    System.Console.WriteLine(i);
                    sum=sum+ i;
                }
        }
        System.Console.WriteLine(" sum of prime number between 1 to 15");
        System.Console.WriteLine(sum);
    }
}

//2+3=5 5+5=10  10+7= 17 17+11= 28 28+13= 41