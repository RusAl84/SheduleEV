
namespace ScheduleWF
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
      this.textBoxFileName = new System.Windows.Forms.TextBox();
      this.buttonLoad = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.textBoxTask = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.SuspendLayout();
      // 
      // checkedListBox1
      // 
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Location = new System.Drawing.Point(12, 23);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new System.Drawing.Size(410, 242);
      this.checkedListBox1.TabIndex = 0;
      this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
      this.checkedListBox1.Click += new System.EventHandler(this.checkedListBox1_Click);
      this.checkedListBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseClick);
      // 
      // textBoxFileName
      // 
      this.textBoxFileName.Location = new System.Drawing.Point(475, 33);
      this.textBoxFileName.Name = "textBoxFileName";
      this.textBoxFileName.Size = new System.Drawing.Size(218, 22);
      this.textBoxFileName.TabIndex = 1;
      this.textBoxFileName.Text = "d:\\fb.txt";
      // 
      // buttonLoad
      // 
      this.buttonLoad.Location = new System.Drawing.Point(516, 114);
      this.buttonLoad.Name = "buttonLoad";
      this.buttonLoad.Size = new System.Drawing.Size(161, 37);
      this.buttonLoad.TabIndex = 2;
      this.buttonLoad.Text = "Load";
      this.buttonLoad.UseVisualStyleBackColor = true;
      this.buttonLoad.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(516, 169);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(161, 34);
      this.button2.TabIndex = 3;
      this.button2.Text = "Save";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(527, 232);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(347, 366);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 6;
      this.buttonAdd.Text = "add";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // textBoxTask
      // 
      this.textBoxTask.Location = new System.Drawing.Point(14, 366);
      this.textBoxTask.Name = "textBoxTask";
      this.textBoxTask.Size = new System.Drawing.Size(164, 22);
      this.textBoxTask.TabIndex = 7;
      this.textBoxTask.Text = "Убить АЛАВРОВА";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
      this.comboBox1.Location = new System.Drawing.Point(194, 365);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 24);
      this.comboBox1.TabIndex = 8;
      this.comboBox1.Text = "8";
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(14, 410);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
      this.dateTimePicker1.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 577);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.textBoxTask);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.buttonLoad);
      this.Controls.Add(this.textBoxFileName);
      this.Controls.Add(this.checkedListBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.TextBox textBoxFileName;
    private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.TextBox textBoxTask;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
  }
}

