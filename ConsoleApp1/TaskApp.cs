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
            Console.Write("Please key in TaskId: ")
            String taskIdInput = Console.ReadLine();
            try
            {
                int taskId = int.Parse(taskIdInput);
                taskList.MarkTaskCompleted(taskId);
            }
            catch {
                Console.WriteLine("Invalid Input, Please Key in valid TaskID");
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
                Console.WriteLine("4. Exit");
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


