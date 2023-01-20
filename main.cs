using System;

class Program {
  public static void Main (string[] args) {
   Console.Write("Введите число: ");
    string value = Console.ReadLine();
    int sum = 0;
    for (int i = 0; i < value.Length; i++)
    {
      int number = int.Parse(Convert.ToString(value[i]));
      sum += number;
    }
    Console.Write(sum);
  }
}