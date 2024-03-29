﻿using System;
namespace LogicalPrograms
{
    public class program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("Welcome to Logical Programming Problem");
        bool flag = true;
        while (flag)
        {
            Console.Write("1. Fibonacci\n2. Perfect Number\n3. Prime Number\n4. Reverse a number\n5. Coupon Number\n6. Exit\nEnter your option to execute: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fib = new FibonacciSeries();
                    Console.Write("Enter the number of terms for Fibonacci Series: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    fib.PrintFibonacciSeries(num);
                    break;
                case 2:
                    PerfectNumber perf = new PerfectNumber();
                    Console.Write("Enter a number to check if it's a perfect number: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    bool isPerfect = perf.IsPerfectNumber(input);
                    if (isPerfect)
                    {
                        Console.WriteLine(input + " is a perfect number.");
                    }
                    else
                    {
                        Console.WriteLine(input + " is not a perfect number.");
                    }
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    Console.Write("Enter a number to check if it's a prime number: ");
                    int primeInput = Convert.ToInt32(Console.ReadLine());
                    bool isPrime = prime.IsPrimeNumber(primeInput);
                    if (isPrime)
                    {
                        Console.WriteLine(primeInput + " is a prime number.");
                    }
                    else
                    {
                        Console.WriteLine(primeInput + " is not a prime number.");
                    }
                    break;
                case 4:
                    ReverseANumber rev = new ReverseANumber();
                    Console.Write("Enter a number to reverse: ");
                    int reverseInput = Convert.ToInt32(Console.ReadLine());
                    int reversedNumber = rev.ReverseNumber(reverseInput);
                    Console.WriteLine("Reversed number: " + reversedNumber);
                    break;
                case 5:
                    CouponNumber coupon = new CouponNumber();
                    Console.Write("Enter the value for the coupon number: ");
                    int couponInput = Convert.ToInt32(Console.ReadLine());
                    int couponNumber = coupon.Distinctcoupon(couponInput);
                    Console.WriteLine("Coupon Number: " + couponNumber);
                    break;
                case 6:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            
            }
        }
    }
}
