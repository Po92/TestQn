using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Task
    {
        private int Id;
        private string taskName;
        private DateTime dueDate;
        private bool isCompleted;

        internal Task(int Id, string taskName, DateTime dueDate)
        {
            this.Id = Id;
            this.taskName = taskName;
            this.dueDate = dueDate;
            this.isCompleted = false;

        }
        
        internal void DisplayTask()
        {
            Console.Write("ID: " + Id + "\t");
            Console.Write("Task: " + taskName + "\t");
            Console.Write("Due Date: "+dueDate.ToShortDateString()+"\t");
            Console.WriteLine("Status: "+ (isCompleted ? "Completed":"Pending")+"\t");
        }
        internal void MarkComplete()
        {
            this.isCompleted = true;
        }
    }
}
