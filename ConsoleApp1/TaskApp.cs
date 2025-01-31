using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class TaskApp
    {
        private TaskList taskList;
        public TaskApp()
        {
            taskList = new TaskList();
        }
        public void start()
        {
            showMenu();
        }
        public void AddTask()
        {
            Console.Write("Enter task name: ");
            string taskName = Console.ReadLine();

            DateTime dueDate;
            while (true)
            {
                Console.Write("Enter due date (MM/dd/yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out dueDate))
                    break;
                else
                    Console.WriteLine("Invalid date format. Please try again.");
            }

            taskList.AddTask(taskName, dueDate);
            Console.WriteLine("Task added successfully.");
        }

        public void MarkTaskCompleted()
        {
            Console.Write("Please key in TaskId: ");
            String taskIdInput = Console.ReadLine();
            try
            {
                int taskId = int.Parse(taskIdInput);
                taskList.MarkTaskCompleted(taskId);
            }
            catch {
                Console.WriteLine("Invalid Input, Please Key in valid Task ID");
            }

            
        }
        public void DeleteTask()
        {
            Console.Write("Please key in TaskId: ");
            String taskIdInput = Console.ReadLine();
            try
            {
                int taskId = int.Parse(taskIdInput);
                taskList.DeleteTask(taskId);
            }
            catch
            {
                Console.WriteLine("Invalid Input, Please Key in valid Task ID");
            }

        }

        public void FilteredTaskList()
        {
            int status = 0;
            Console.Write("Press 1 for Completed Tasks, and 2 for Pending Tasks");
            try
            {
                string filterinput = Console.ReadLine();
                status = int.Parse(filterinput);
            }
            catch
            {
                Console.WriteLine("Invalid input, please key in either 1 or 2");
            }
            switch (status)
            {
                case 1:
                    taskList.DisplayFilteredTaskList(true);
                    break;
                case 2:
                    taskList.DisplayFilteredTaskList(false);
                    break;
                default:
                    Console.WriteLine("Invalid Input please key in either 1 or 2");
                    break;
            }
        }
            


        public void showMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Filtered Task List");
                Console.WriteLine("6. Exit");
                Console.Write("Option: ");

                string option = Console.ReadLine();
                
                switch (option)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        taskList.DisplayTaskList();
                        break;
                    case "3":
                       MarkTaskCompleted();
                       break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        FilteredTaskList();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}


