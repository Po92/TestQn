using System;

    namespace ToDoList;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /*//Test task constructor
        Task task = new Task(1,"Task1", DateTime.Now);
        //Test displaytask
        task.DisplayTask();
        //Test Task List
        task.MarkComplete();
        task.DisplayTask();*/

        TaskList tasks = new TaskList();
        tasks.AddTask("task2", DateTime.Now);
        tasks.DisplayTaskList();
        tasks.AddTask("task3", DateTime.Now);
        tasks.DisplayTaskList();
        tasks.MarkTaskCompleted(2);
        tasks.DisplayTaskList();
        tasks.MarkTaskCompleted(3);
        tasks.AddTask("task4", DateTime.Now);
        tasks.AddTask("task5", DateTime.Now);
        tasks.DisplayTaskList();



    }
}