﻿
int sum = 0;

for(int i = 1; i <= 10; i++) //i-- = i - 1

{
    Console.WriteLine($"i = {i}"); 
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum += 1;
}

//Console.WriteLine($"Final total{sum}");