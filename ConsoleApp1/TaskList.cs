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
        //Initializes a new instance of the TaskList class
        public TaskList()
        {
            taskList = [];
            taskIdCounter = 1;
        }

        public ToDoTask GetTask(int taskId)
        {
            _ = taskList.TryGetValue(taskId, out ToDoTask task);
            return task;
        }

        //Add task to list
        public void AddTask(string name, DateTime dueDate)
        {
            ToDoTask task = new(taskIdCounter, name, dueDate);
            taskList[taskIdCounter] = task;
            taskIdCounter++;
            Console.WriteLine("Task added successfully.");
        }
        //Display Tasks
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
        //Mark task as completed
        public void MarkTaskCompleted(int taskId)
        {
            if (taskList.ContainsKey(taskId))
            {
                taskList[taskId].MarkComplete();
                Console.WriteLine("Task Completed");
            }
            else
            {
                Console.WriteLine("Task ID does not Exist.");
            }
        }
        //Delete Task
        public void DeleteTask(int taskId)
        {
            if (taskList.ContainsKey(taskId))
            {
                taskList.Remove(taskId);
                Console.WriteLine("Task Deleted");
            }
            else
            {
                Console.WriteLine("Task ID does not Exist.");
            }

        }

        //Display filtered task list
        public void DisplayFilteredTaskList(bool status)
        {
            foreach (ToDoTask task in taskList.Values)
            {
                if (task.GetisCompleted().Equals(status))
                {
                    task.DisplayTask();
                }
                else { continue; }
            }
        }
        //Check if due date is earlier than current date and display
        public void DisplayOverdueTasks()
        {
            foreach (ToDoTask task in taskList.Values)
            {
                if (task.GetdueDate().CompareTo(DateTime.Now) < 0)
                { task.DisplayTask(); }
                else { continue; }

            }
        }
        //Sort dictionary based on due date, and store into new dictionary for display
        public void DisplayTaskDateSorted()
        {
            var sortedTaskList = taskList.OrderBy(kvp => kvp.Value.GetdueDate());
            foreach (var kvp in sortedTaskList)
            {
                kvp.Value.DisplayTask();
            }
        }

        //Sort dictionary based on status, and store into new dictionary for display
        public void DisplayTaskStatusSorted()
        {
            var sortedTaskList = taskList.OrderBy(kvp => kvp.Value.GetisCompleted());
            foreach (var kvp in sortedTaskList)
            {
                kvp.Value.DisplayTask();
            }
        }
    }
}


 