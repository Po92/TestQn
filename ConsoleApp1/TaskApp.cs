using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    //Constructor
    public class TaskApp
    {
        private TaskList taskList;
        public TaskApp()
        {
            taskList = new TaskList();
        }
        //Start the application
        public void Start()
        {
            ShowMenu();
        }
        //Validation for add task, and adding task to list
        public void AddTask()
        {
            Console.WriteLine("Enter task name: ");
            string taskName = InputValidator.ReadNonEmptyString();
            Console.WriteLine("Please Enter Due Date (MM/dd/yyyy): ");
            DateTime dueDate = InputValidator.ReadDateTime(); 
            taskList.AddTask(taskName, dueDate);
        }
        //Mark task as completed
        public void MarkTaskCompleted()
        {
            Console.Write("Please key in TaskId: ");

            int taskId = InputValidator.ReadInt();
            taskList.MarkTaskCompleted(taskId);
            Console.WriteLine("Task" + taskId + "Completed");           
        }
        //Delete Task
        public void DeleteTask()
        {
            Console.Write("Please key in TaskId: ");
            int taskId = InputValidator.ReadInt();
            taskList.DeleteTask(taskId);
        }
        //Filter task List
        public void FilteredTaskList()
        {
            Console.Write("Press 1 for Completed Tasks, and 2 for Pending Tasks: ");
            int status = InputValidator.ReadInt();
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
            

        //Show instructions and await for user input
        public void ShowMenu()
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
                Console.WriteLine("6. Overdue Task List");
                Console.WriteLine("7. Sort on date");
                Console.WriteLine("8. Sort on status");
                Console.WriteLine("9. Exit");
                Console.Write("Option: ");

                int option = InputValidator.ReadInt();
                switch (option)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        taskList.DisplayTaskList();
                        break;
                    case 3:
                        MarkTaskCompleted();
                        break;
                    case 4:
                        DeleteTask();
                        break;
                    case 5:
                        FilteredTaskList();
                        break;
                    case 6:
                        taskList.DisplayOverdueTasks();
                        break;
                    case 7:
                        taskList.DisplayTaskDateSorted();
                        break;
                    case 8:
                        taskList.DisplayTaskStatusSorted();
                        break;
                    case 9:
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


