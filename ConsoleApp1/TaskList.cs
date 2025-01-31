using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class TaskList
    {
        private Dictionary<int, Task> taskList;
        private int taskIdCounter;
        
        internal TaskList()
        {
            taskList = new Dictionary<int, Task>();
            taskIdCounter = 1;
        }

        internal void AddTask(string name, DateTime dueDate)
        {
            Task task = new Task(taskIdCounter, name, dueDate);
            taskList[taskIdCounter] = task;
            taskIdCounter++;
            Console.WriteLine("Task added successfully.");
        }

        internal void DisplayTaskList()
        {
            foreach (Task task in taskList.Values)
            {
                task.DisplayTask();
                
            }
        }

        internal void MarkTaskCompleted(int taskId)
        {
            if (taskList.ContainsKey(taskId))
            {
                taskList[taskId].MarkComplete();
                Console.WriteLine("Task Completed");
            }
            else
            {
                Console.WriteLine("Invalid TaskID.");
            }
        }
       


    }
}
