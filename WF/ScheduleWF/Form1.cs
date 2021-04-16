using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleWF
{
  public partial class Form1 : Form
  {
    public
      ScheduleMasClass sched = new ScheduleMasClass();

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      sched.LoadFromFile(textBoxFileName.Text);

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    public void UpdateLB()
    {
      checkedListBox1.Items.Clear();
      for (int i = 0; i < sched.Size(); i++)
      {
        ScheduleClass sh = new ScheduleClass();
        sh = sched.Get(i);
        checkedListBox1.Items.Add(sh);
        checkedListBox1.SetItemChecked(i, sh.getIsDone());
      }
    }
    private void button1_Click_1(object sender, EventArgs e)
    {
      UpdateLB();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      DateTime dt = dateTimePicker1.Value;
      sched.Add(textBoxTask.Text, comboBox1.SelectedIndex,false, dt);
      UpdateLB();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < checkedListBox1.Items.Count; i++)
      {
        bool isDone = checkedListBox1.GetItemChecked(i);
        sched.setIsDone(i, isDone);
      }
      sched.SaveToFile(textBoxFileName.Text);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      UpdateLB();
    }

    private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      //bool isDone = sched.getIsDone(e.Index);
      //sched.setIsDone(e.Index, !isDone);

      if (e.NewValue.ToString() == "Checked")
      {
        sched.setIsDone(e.Index, true);
      }
      if (e.NewValue.ToString() == "Unchecked")
      {
        sched.setIsDone(e.Index, false);
      }
      //System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
      //messageBoxCS.AppendFormat("{0} = {1}", "Index", e.Index);
      //messageBoxCS.AppendLine();
      //messageBoxCS.AppendFormat("{0} = {1}", "NewValue", e.NewValue);
      //messageBoxCS.AppendLine();
      //messageBoxCS.AppendFormat("{0} = {1}", "CurrentValue", e.CurrentValue);
      //messageBoxCS.AppendLine();
      //MessageBox.Show(messageBoxCS.ToString(), "ItemCheck Event");
    }

    private void checkedListBox1_MouseClick(object sender, MouseEventArgs e)
    {

    }

    private void checkedListBox1_Click(object sender, EventArgs e)
    {

    }
  }
}
