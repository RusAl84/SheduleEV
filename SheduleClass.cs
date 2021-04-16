using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheduleEV
{
  [Serializable]
  public class SheduleClass
  {
    public SheduleClass(string name, int priority)
    {
      this.name = name;
      this.priority = priority;
    }

    public SheduleClass()
    {
      this.name = "name";
      this.priority = 0;
    }

    public string name { set; get; }
    public int priority { set; get; }

    public override string ToString()
    {
      string str1 = String.Format("name: {0} - priority: {1}", name, priority);
      return str1;
    }
  }

  public class SheduleMasClass
  {
    public List<SheduleClass> shed_mas = new List<SheduleClass>();

    public void Add(SheduleClass _shed)
    {
      SheduleClass sh = new SheduleClass();
      sh.name = _shed.name;
      sh.priority = _shed.priority;
      shed_mas.Add(sh);
    }

    public SheduleClass Get(int pos)
    {
      return shed_mas[pos];
    }

    public int Size()
    {
      return shed_mas.Count;
    }

    public void SaveToFile(string FileName)
    {
      string json = JsonConvert.SerializeObject(shed_mas);
      //Console.WriteLine(json);
      using (StreamWriter sw = new StreamWriter(FileName, false, System.Text.Encoding.Default))
      {
        sw.WriteLine(json);
      }
    }

    public void LoadFromFile(string FileName)
    {
      string json = "";
      using (StreamReader sr = new StreamReader(FileName))
      {
        json = sr.ReadToEnd();
      }

      SheduleMasClass dshed_mas = new SheduleMasClass();
      //Console.WriteLine(json);
      List<SheduleClass> ldshed_mas = new List<SheduleClass>();
      ldshed_mas = JsonConvert.DeserializeObject<List<SheduleClass>>(json);
      //Console.WriteLine(ldshed_mas[1]);
      shed_mas.Clear();
      for (int i = 0; i < ldshed_mas.Count; i++)
      {
        SheduleClass shed = new SheduleClass();
        shed = ldshed_mas[i];
        shed_mas.Add(shed);
      }
    }

    public override string ToString()
    {
      string str1 = "";
      foreach(SheduleClass item in shed_mas)
      {
        str1 = str1 + "\n" + item;
      }
      return str1;
    }

  }

}
