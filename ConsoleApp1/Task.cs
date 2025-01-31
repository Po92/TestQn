using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Task
    {
        private int Id;
        private string taskName;
        private DateTime dueDate;
        private bool isCompleted;

       

        public Task(int Id, string taskName, DateTime dueDate)
        {
            this.Id = Id;
            this.taskName = taskName;
            this.dueDate = dueDate;
            this.isCompleted = false;

        }
        public bool getisCompleted()
        {
            return isCompleted;
        }


        public void DisplayTask()
        {
            Console.Write("ID: " + Id + "\t");
            Console.Write("Task: " + taskName + "\t");
            Console.Write("Due Date: "+dueDate.ToShortDateString()+"\t");
            Console.WriteLine("Status: "+ (isCompleted ? "Completed":"Pending")+"\t");
        }
        public void MarkComplete()
        {
            this.isCompleted = true;
        }
    }
}
