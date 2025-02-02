using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class TaskList
    {
        private Dictionary<int, ToDoTask> taskList;
        private int taskIdCounter;

        public TaskList()
        {
            taskList = new Dictionary<int, ToDoTask>();
            taskIdCounter = 1;
        }

        public void AddTask(string name, DateTime dueDate)
        {
            ToDoTask task = new ToDoTask(taskIdCounter, name, dueDate);
            taskList[taskIdCounter] = task;
            taskIdCounter++;
            Console.WriteLine("Task added successfully.");
        }

        public void DisplayTaskList()
        {
            if (taskList.Count == 0)
            {
                Console.WriteLine("No tasks in List");
            }
            foreach (ToDoTask task in taskList.Values)
            {
                task.DisplayTask();

            }
        }

        public void MarkTaskCompleted(int taskId)
        {
            if (taskList.ContainsKey(taskId))
            {
                taskList[taskId].MarkComplete();
                Console.WriteLine("Task Completed");
            }
            else
            {
                Console.WriteLine("Invalid Task ID.");
            }
        }
        public void DeleteTask(int taskId)
        {
            if (taskList.ContainsKey(taskId))
            {
                taskList.Remove(taskId);
                Console.WriteLine("Task Deleted");
            }
            else
            {
                Console.WriteLine("Invalid Task ID.");
            }

        }
        public void DisplayFilteredTaskList(bool status)
        {
            foreach (ToDoTask task in taskList.Values)
            {
                if (task.getisCompleted().Equals(status))
                {
                    task.DisplayTask();
                }
                else { continue; }
            }
        }

        public void DisplayOverdueTasks()
        {
            foreach (ToDoTask task in taskList.Values)
            {
                if (task.getdueDate().CompareTo(DateTime.Now) < 0)
                { task.DisplayTask(); }
                else { continue; }

            }
        }
        public void DisplayTaskDateSorted()
        {
            var sortedTaskList = taskList.OrderBy(kvp => kvp.Value.getdueDate());
            foreach (var kvp in sortedTaskList)
            {
                kvp.Value.DisplayTask();
            }
        }
        public void DisplayTaskStatusSorted()
        {
            var sortedTaskList = taskList.OrderBy(kvp => kvp.Value.getisCompleted());
            foreach (var kvp in sortedTaskList)
            {
                kvp.Value.DisplayTask();
            }
        }
    }
}


 