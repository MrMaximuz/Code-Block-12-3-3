using System;

class MainClass {
  public static void Main (string[] args) {
    int[,] array = { { 1,2,3 }, { 5,6,7 }};
		Console.WriteLine(array.Length);
    Console.WriteLine(array[0,0]);
    foreach(var item in array) 
{
  Console.Write(item + " ");
}
  }
}
