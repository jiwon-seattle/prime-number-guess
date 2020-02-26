using System;
using System.Collections.Generic;

public class Program
{

  public static void Main()
  {
    Console.WriteLine("Please, provide number");
    int number = int.Parse(Console.ReadLine());

    int[] array = new int[number-1];
    List <int> primeNumbers = new List <int> {};

    for (int i=2; i<=number; i++)
    {
      array[i-2] = i;
    }


    for (int j=0; j<array.Length; j++)
    {
      int index = 0;
      for (int k=0; k<array.Length; k++)
      {
        if (array[j] % array[k] == 0)
        {
          index ++;
        }
      }
      if (index == 1)
      {
        primeNumbers.Add(array[j]);
      }
    }

    Console.WriteLine("Prime numbers are:");
    foreach (int element in primeNumbers)
    {
      Console.WriteLine(element);
    }

  }
}