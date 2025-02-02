using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDoTask
    {
        private readonly int Id;
        private string taskName;
        private DateTime dueDate;
        private bool isCompleted;

       
        //Initializes a new instance of the ToDoTask class
        public ToDoTask(int Id, string taskName, DateTime dueDate)
        {
            this.Id = Id;
            this.taskName = taskName;
            this.dueDate = dueDate;
            this.isCompleted = false;

        }
        //Getters and Setters
        public string GetTaskName()
        {
            return taskName;
        }
        public int GetId()
        {
            return Id;
        }
        public bool GetisCompleted()
        {
            return isCompleted;
        }

        public DateTime GetdueDate()
        {
            return dueDate;
        }

        public void SetTaskName(string taskName)
        {
            this.taskName = taskName;
        }

        public void SetDueDate(DateTime dueDate)
        {
            this.dueDate = dueDate;
        }
        public void SetIsCompleted(bool isCompleted)
        {
            this.isCompleted = isCompleted;
        }

        //Display Task
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
        //Change status of task to completed
        public void MarkComplete()
        {
            this.isCompleted = true;
        }
    }
}
