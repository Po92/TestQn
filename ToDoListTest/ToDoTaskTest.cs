using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList;

namespace ToDoListTest
{
    public class ToDoTaskTest
    {
        [Fact]
        public void Constructor_TaskCreatedCorrectly()
        {
            // Arrange
            int taskId = 1;
            string taskName = "Test Task";
            DateTime dueDate = new DateTime(2025, 2, 2);

            // Act
            ToDoTask task = new ToDoTask(taskId, taskName, dueDate);

            // Assert Check Task variables are set correctly
            Assert.Equal(taskId, task.GetId());
            Assert.Equal(taskName, task.GetTaskName());
            Assert.Equal(dueDate, task.GetdueDate());
            Assert.False(task.GetisCompleted());
        }

        [Fact]
        public void MarkComplete_ShouldSetIsCompletedToTrue()
        {
            // Arrange
            ToDoTask task = new ToDoTask(1, "Test Task", DateTime.Now);

            // Act
            task.MarkComplete();

            // Assert Check task is completed
            Assert.True(task.GetisCompleted());
        }
        [Fact]
        public void DisplayTask_ShouldDisplayCorrectTaskDetails()
        {
            // Arrange
            DateTime testDate = new DateTime(2025, 2, 2);
            ToDoTask task = new ToDoTask(1, "Test Task", testDate);
            // Act Direct output to a string
            using var sw = new System.IO.StringWriter();
            Console.SetOut(sw);
            task.DisplayTask();
            string output = sw.ToString();

            // Assert: Check if the output contains expected task details
            Assert.Contains("ID: 1", output);
            Assert.Contains("Task: Test Task", output);
            Assert.Contains("Due Date: " + testDate.ToShortDateString(), output);
            Assert.Contains("Status: Pending", output); 
        }
    }
}
