using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SheduleEV
{
  class Program
  {
    static SheduleMasClass shed_mas = new SheduleMasClass();

    static void Main(string[] args)
    {
      
      SheduleClass shed = new SheduleClass("Task1", 1);
      shed_mas.Add(shed);
      shed.name = "Task2";
      shed.priority = 3;
      shed_mas.Add(shed);
      shed.name = "Task3";
      shed.priority = 2;
      shed_mas.Add(shed);
      shed.name = "Task4";
      shed.priority = 1;
      shed_mas.Add(shed);
      shed.name = "Task9";
      shed.priority = 3;
      shed_mas.Add(shed);

      string json = JsonConvert.SerializeObject(shed_mas);
      //Console.WriteLine(json);
      shed_mas.SaveToFile(@"d:\fb.txt");

      SheduleMasClass dshed_mas = new SheduleMasClass();
      dshed_mas.LoadFromFile(@"d:\fb.txt");
      Console.WriteLine(dshed_mas);


      Console.ReadKey();
    }
  }
}
