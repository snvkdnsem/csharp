﻿using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 10, 20, 30, 40, 50 };
            unsafe
            {
                fixed (int* p = &a[0])
                {
                    Console.WriteLine(&a[0]); // 주소값으로 표현가능(포인트)
                    // p is pinned as well as object, so create another pointer to show incrementing it.
                    int* p2 = p;
                    Console.WriteLine(*p2);
                    // Incrementing p2 bumps the pointer by four bytes due to its type ...
                    p2 += 1;
                    Console.WriteLine(*p2);
                    p2 += 1;
                    Console.WriteLine(*p2);
                    Console.WriteLine("--------");
                    Console.WriteLine(*p);
                    // Dereferencing p and incrementing changes the value of a[0] ...
                    *p += 1;
                    Console.WriteLine(*p);
                    *p += 1;
                    Console.WriteLine(*p);
                }
            }
        }
    }
}