using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDoTask
    {
        private int Id;
        private string taskName;
        private DateTime dueDate;
        private bool isCompleted;

       

        public ToDoTask(int Id, string taskName, DateTime dueDate)
        {
            this.Id = Id;
            this.taskName = taskName;
            this.dueDate = dueDate;
            this.isCompleted = false;

        }
        public bool GetisCompleted()
        {
            return isCompleted;
        }

        public DateTime GetdueDate()
        {
            return dueDate;
        }

        public void DisplayTask()
        {
            if (isCompleted)
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (!isCompleted && dueDate.CompareTo(DateTime.Now) < 0)
            { Console.ForegroundColor = ConsoleColor.Red; }

            Console.Write("ID: " + Id + "\t");
            Console.Write("Task: " + taskName + "\t");
            Console.Write("Due Date: "+dueDate.ToShortDateString()+"\t");
            Console.WriteLine("Status: "+ (isCompleted ? "Completed":"Pending")+"\t");
            Console.ResetColor();
        }
        public void MarkComplete()
        {
            this.isCompleted = true;
        }
    }
}
