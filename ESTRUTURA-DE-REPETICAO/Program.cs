﻿public class Program
{
  public static void Main()
  {
    int numberOfPeople = 0;
    int numberOfChildren = 0;
    int age = 99;
    while (age > 0)
    {
      Console.WriteLine("Informe a idade da pessoa. Informa 0 para sair.");
      age = Convert.ToInt32(Console.ReadLine());
      if (age == 0) break;
      numberOfPeople++;
      if (age < 18) numberOfChildren++;
    }
    double rateOfChildren = 100 * numberOfChildren / numberOfPeople;
    Console.WriteLine("Existe " + rateOfChildren + "% de crianças. ");
  }
}