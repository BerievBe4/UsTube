using Microsoft.AspNetCore.Mvc;
using Moq;
using ServiceStack.OrmLite;
using System;
using TableBoi.Controllers;
using TableBoi.Controllers.Helpers;
using TableBoi.Models;
using TableBoi.Repositories;
using TableTests.Utils;
using Xunit;

namespace TableTests
{
    public class ControllerTests
    {
        [Fact]
        public void Validate_AddOrEditTaskWithNullModel_BadRequest()
        {
            // Arange
            var controller = new HomeController(null);

            // Act
            var result = (StatusCodeResult)controller.AddOrEdit(null);

            // Assert
            Assert.Equal(400, result?.StatusCode);
        }

        [Fact]
        public void Validate_AddOrEditTaskWithNullModelFields_BadRequest()
        {
            // Arange
            var controller = new HomeController(null);
            var task = new TaskModel();
            // Act
            var result = (StatusCodeResult)controller.AddOrEdit(task);

            // Assert
            Assert.Equal(400, result?.StatusCode);
        }

        [Fact]
        public void Validate_AddOrEditTaskWithNullName_BadRequest()
        {
            // Arange
            var controller = new HomeController(null);
            var task = new TaskModel() {Id = 0, TaskName = null, TaskDescription = "Описание", UserId = 1 };
            // Act
            var result = (StatusCodeResult)controller.AddOrEdit(task);

            // Assert
            Assert.Equal(400, result?.StatusCode);
        }

         [Fact]
        public void Validate_AddOrEditTaskWithEmptyName_BadRequest()
        {
            // Arange
            var controller = new HomeController(null);
            var task = new TaskModel() { Id = 0, TaskName = "", TaskDescription = "Описание", UserId = 1 };
            // Act
            var result = (StatusCodeResult)controller.AddOrEdit(task);

            // Assert
            Assert.Equal(400, result?.StatusCode);
        }

        [Fact]
        public void Validate_AddOrEditTaskWithNullDescription_BadRequest()
        {
            // Arange
            var controller = new HomeController(null);
            var task = new TaskModel() { Id = 0, TaskName = "Имя", TaskDescription = null, UserId = 1 };
            // Act
            var result = (StatusCodeResult)controller.AddOrEdit(task);

            // Assert
            Assert.Equal(400, result?.StatusCode);
        }

        [Fact]
        public void Validate_AddOrEditTaskWithEmptyDescription_BadRequest()
        {
            // Arange
            var controller = new HomeController(null);
            var task = new TaskModel() { Id = 0, TaskName = "Имя", TaskDescription = "", UserId = 1 };
            // Act
            var result = (StatusCodeResult)controller.AddOrEdit(task);

            // Assert
            Assert.Equal(400, result?.StatusCode);
        }

        [Fact]
        public void Validate_AddOrEditTaskWithInvalidId_BadRequest()
        {
            // Arange
            var controller = new HomeController(null);
            var task = new TaskModel() { Id = -1, TaskName = "Имя", TaskDescription = "", UserId = 1 };
            // Act
            var result = (StatusCodeResult)controller.AddOrEdit(task);

            // Assert
            Assert.Equal(400, result?.StatusCode);
        }

        [Fact]
        public void Validate_AddOrEditTaskWithoutDb_ServerError()
        {
            // Arange
            var controller = new HomeController(null);
            var task = new TaskModel() { Id = 0, TaskName = "Имя", TaskDescription = "Описание", UserId = 1 };
            // Act
            var result = (StatusCodeResult)controller.AddOrEdit(task);

            // Assert
            Assert.Equal(500, result?.StatusCode);
        }

        [Fact]
        public void Validate_AddOrEditTaskWithoutTable_ServerError()
        {
            // Arange
            VirtualDatabaseProvider inMemoryDatabaseProvider = new VirtualDatabaseProvider();
            TasksRepository taskRepository = new TasksRepository(inMemoryDatabaseProvider);
            var controller = new HomeController(taskRepository);
            var task = new TaskModel() { Id = 0, TaskName = "Имя", TaskDescription = "Описание", UserId = 1 };
            // Act
            var result = (StatusCodeResult)controller.AddOrEdit(task);

            // Assert
            Assert.Equal(500, result?.StatusCode);
        }

        [Fact]
        public void Validate_GetTaskWithInvalidId_BadRequest()
        {
            // Arange
            var controller = new HomeController(null);
            var task = new TaskModel() { Id = -1, TaskName = "Имя", TaskDescription = "", UserId = 1 };
            // Act
            var result = (StatusCodeResult)controller.AddOrEdit(task.Id);

            // Assert
            Assert.Equal(400, result?.StatusCode);
        }

        [Fact]
        public void Validate_DeleteTaskWithInvalidId_BadRequest()
        {
            // Arange
            var controller = new HomeController(null);
            var task = new TaskModel() { Id = -1, TaskName = "Имя", TaskDescription = "", UserId = 1 };
            // Act
            var result = (StatusCodeResult)controller.DeleteTask(task.Id);

            // Assert
            Assert.Equal(400, result?.StatusCode);
        }
    }
}
