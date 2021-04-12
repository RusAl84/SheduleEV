using System;
using System.Collections.Generic;
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
