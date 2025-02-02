using System;
using Xunit;
using ToDoList;

namespace ToDoListTest
{
    public class TaskListTest
    {
        [Fact]
        public void AddTask_TaskIsAddedToList()
        {
            // Arrange
            TaskList taskList = new TaskList();
            string task1 = "Task1";
            DateTime dueDate1 = new DateTime(2022, 12, 31);
            string task2 = "Task2";
            DateTime dueDate2 = new DateTime(2022, 12, 31);
            // Act
            taskList.AddTask(task1, dueDate1);
            taskList.AddTask(task2, dueDate2);
            // Assert ensure task is added correctly to list
            Assert.Equal(task1, taskList.GetTask(1).GetTaskName());
            Assert.Equal(dueDate1, taskList.GetTask(1).GetdueDate());
            Assert.Equal(task2, taskList.GetTask(2).GetTaskName());
            Assert.Equal(dueDate2, taskList.GetTask(2).GetdueDate());

        }
        [Fact]
        public void MarkTaskCompleted_TaskIsMarkedAsCompleted()
        {
            // Arrange
            TaskList taskList = new TaskList();
            string task1 = "Task1";
            DateTime dueDate1 = new DateTime(2022, 12, 31);
            string task2 = "Task2";
            DateTime dueDate2 = new DateTime(2022, 12, 31);
            taskList.AddTask(task1, dueDate1);
            taskList.AddTask(task2, dueDate2);

            // Act
            taskList.MarkTaskCompleted(1);

            // Assert ensure task is marked as completed
            Assert.True(taskList.GetTask(1).GetisCompleted());
            Assert.False(taskList.GetTask(2).GetisCompleted());

        }
        [Fact]
        public void DeleteTask_TaskIsDeleted()
        {
            // Arrange
            TaskList taskList = new TaskList();
            string task1 = "Task1";
            DateTime dueDate1 = new DateTime(2022, 12, 31);
            string task2 = "Task2";
            DateTime dueDate2 = new DateTime(2022, 12, 31);
            taskList.AddTask(task1, dueDate1);
            taskList.AddTask(task2, dueDate2);

            // Act
            taskList.DeleteTask(1);
            // Assert ensure task is deleted

            Assert.Null(taskList.GetTask(1));
            Assert.NotNull(taskList.GetTask(2));
        }
    }
}
