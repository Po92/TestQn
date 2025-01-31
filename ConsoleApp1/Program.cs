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

        TaskList taskList = new TaskList();
        taskList.DisplayTaskList();
        taskList.AddTask("task2", DateTime.Now);
        taskList.DisplayTaskList();
        taskList.AddTask("task3 ", DateTime.Now);
        taskList.DisplayTaskList();
        taskList.MarkTaskCompleted(2);
        taskList.DisplayTaskList();
        taskList.MarkTaskCompleted(3);
        taskList.AddTask("task4", DateTime.Now);
        taskList.AddTask("task5", DateTime.Now);
        taskList.DisplayTaskList();

        TaskApp app = new TaskApp();
        app.start();


      



    }
}