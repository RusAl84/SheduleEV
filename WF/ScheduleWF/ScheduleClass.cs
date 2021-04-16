using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleWF
{
  [Serializable]
  public class ScheduleClass
  {
    public ScheduleClass(string name, int priority, bool isDone)
    {
      this.name = name;
      this.priority = priority;
      this.isDone = isDone;
    }

    public ScheduleClass()
    {
      this.name = "name";
      this.priority = 0;
      this.isDone = false;
    }

    public string name { set; get; }
    public int priority { set; get; }
    public bool isDone { set; get; }
    public DateTime dt { set; get; }

    public bool getIsDone()
    {
      return isDone;
    }

    public override string ToString()
    {
      string str1 = String.Format("<{0}>: {1} : {2} ", dt.ToString(), name, priority);
      return str1;
    }
  }

  public class ScheduleMasClass
  {
    public List<ScheduleClass> shed_mas = new List<ScheduleClass>();

    public ScheduleMasClass()
    {
      shed_mas.Clear();
    }

    public void Add(ScheduleClass _shed)
    {
      ScheduleClass sh = new ScheduleClass();
      sh.name = _shed.name;
      sh.priority = _shed.priority;
      sh.isDone = false;
      sh.dt = DateTime.Now;
      shed_mas.Add(sh);
    }

    public void Add(string _name, int _priority, bool _isDone, DateTime dt)
    {
      ScheduleClass sh = new ScheduleClass();
      sh.name = _name;
      sh.priority = _priority;
      sh.isDone = _isDone;
      sh.dt = dt;
      shed_mas.Add(sh);
    }


    public void setIsDone(int i, bool _isDone)
    {
      shed_mas[i].isDone = _isDone;
    }

    public bool getIsDone(int i)
    {
      return shed_mas[i].isDone ;
    }

    public ScheduleClass Get(int pos)
    {
      return shed_mas[pos];
    }

    public int Size()
    {
      return shed_mas.Count;
    }

    internal void setIsDone(int indexChecked, CheckState checkState)
    {
      throw new NotImplementedException();
    }

    public int Count()
    {
      return shed_mas.Count;
    }

    public void SaveToFile(string FileName)
    {
      string json = JsonConvert.SerializeObject(shed_mas);
      //Console.WriteLine(json);
      using (StreamWriter sw = new StreamWriter(FileName, false, System.Text.Encoding.UTF8))
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

      ScheduleMasClass dshed_mas = new ScheduleMasClass();
      //Console.WriteLine(json);
      List<ScheduleClass> ldshed_mas = new List<ScheduleClass>();
      ldshed_mas = JsonConvert.DeserializeObject<List<ScheduleClass>>(json);
      //Console.WriteLine(ldshed_mas[1]);
      shed_mas.Clear();
      for (int i = 0; i < ldshed_mas.Count; i++)
      {
        ScheduleClass shed = new ScheduleClass();
        shed = ldshed_mas[i];
        shed_mas.Add(shed);
      }
    }

    public override string ToString()
    {
      string str1 = "";
      foreach(ScheduleClass item in shed_mas)
      {
        str1 = str1 + "\n" + item;
      }
      return str1;
    }

  }

}
