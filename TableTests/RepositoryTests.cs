using ServiceStack.OrmLite;
using System.Collections.Generic;
using System.Linq;
using TableBoi.Models;
using TableBoi.Repositories;
using TableTests.Utils;
using Xunit;

namespace TableTests
{
    public class RepositoryTests
    {
        [Fact]
        public void Validate_OnTaskAdd_ShouldBeOneTaskInDB()
        {
            var expectTask = new TaskModel()
            {
                Id = 1,
                UserId = 1,
                TaskName = "Имя",
                TaskDescription = "Описание"
            };

            var user = new UserModel() { Id = 1, Login = "Логин", Password = "Пароль"  };


            VirtualDatabaseProvider inMemoryDatabaseProvider = new VirtualDatabaseProvider();
            TasksRepository taskRepository = new TasksRepository(inMemoryDatabaseProvider);
            UserRepository userRepository = new UserRepository(inMemoryDatabaseProvider);

            // Act
            using (var db = inMemoryDatabaseProvider.Open())
            {
                db.CreateTableIfNotExists<TaskModel>();
                db.CreateTableIfNotExists<UserModel>();
            }

            userRepository.AddUser(user);
            taskRepository.AddTask(expectTask);

            List<TaskModel> tasks;
            using (var db = inMemoryDatabaseProvider.Open())
                tasks = db.Select<TaskModel>();

            // Assert
            Assert.Single(tasks);
            Assert.Equal(expectTask.Id, tasks[0].Id);
            Assert.Equal(expectTask.UserId, tasks[0].UserId);
            Assert.Equal(expectTask.TaskDescription, tasks[0].TaskDescription);
            Assert.Equal(expectTask.TaskName, tasks[0].TaskName);
        }

        [Fact]
        public void Validate_OnUpdate_ShouldBeUpdated()
        {
            var taskToEdit = new TaskModel()
            {
                Id = 1,
                UserId = 1,
                TaskName = "Имя",
                TaskDescription = "Описание"
            };

            var editedTask = new TaskModel()
            {
                Id = 1,
                UserId = 1,
                TaskName = "Новое имя",
                TaskDescription = "Новое описание"
            };

            var user = new UserModel() { Id = 1, Login = "Логин", Password = "Пароль" };

            VirtualDatabaseProvider inMemoryDatabaseProvider = new VirtualDatabaseProvider();
            TasksRepository taskRepository = new TasksRepository(inMemoryDatabaseProvider);

            // Act
            using (var db = inMemoryDatabaseProvider.Open())
            {
                db.CreateTableIfNotExists<TaskModel>();
                db.CreateTableIfNotExists<UserModel>();
                db.Insert<UserModel>(user);
                db.Insert<TaskModel>(taskToEdit);
            }

            taskRepository.EditTask(editedTask);
            List<TaskModel> tasks;
            using (var db = inMemoryDatabaseProvider.Open())
                tasks = db.Select<TaskModel>();

            // Assert
            Assert.Single(tasks);
            Assert.Equal(editedTask.Id, tasks[0].Id);
            Assert.Equal(editedTask.UserId, tasks[0].UserId);
            Assert.Equal(editedTask.TaskName, tasks[0].TaskName);
            Assert.Equal(editedTask.TaskDescription, tasks[0].TaskDescription);
        }

        [Fact]
        public void Validate_OnGetExistingTask_ShouldBeRightTask()
        {
            var expectedTask = new TaskModel()
            {
                Id = 1,
                UserId = 1,
                TaskName = "Имя",
                TaskDescription = "Описание"
            };

            var wrongTask = new TaskModel()
            {
                Id = 2,
                UserId = 2,
                TaskName = "Имя",
                TaskDescription = "Описание"
            };

            var user = new UserModel() { Id = 1, Login = "Логин", Password = "Пароль" };


            VirtualDatabaseProvider inMemoryDatabaseProvider = new VirtualDatabaseProvider();
            TasksRepository taskRepository = new TasksRepository(inMemoryDatabaseProvider);
            UserRepository userRepository = new UserRepository(inMemoryDatabaseProvider);

            // Act
            using (var db = inMemoryDatabaseProvider.Open())
            {
                db.CreateTableIfNotExists<TaskModel>();
                db.CreateTableIfNotExists<UserModel>();
                db.Insert<UserModel>(user);
                db.Insert<TaskModel>(expectedTask);
                db.Insert<TaskModel>(wrongTask);
            }

            var realTask = taskRepository.GetTaskById(expectedTask.Id);

            List<TaskModel> tasks;
            using (var db = inMemoryDatabaseProvider.Open())
                tasks = db.Select<TaskModel>();

            // Assert
            Assert.Equal(expectedTask.Id, realTask.Id);
            Assert.Equal(expectedTask.UserId, realTask.UserId);
            Assert.Equal(expectedTask.TaskName, realTask.TaskName);
            Assert.Equal(expectedTask.TaskDescription, realTask.TaskDescription);
        }

        [Fact]
        public void Validate_OnGetExistingTaskByUserId_ShouldBeTask()
        {
            var expectedTask = new TaskModel()
            {
                Id = 1,
                UserId = 1,
                TaskName = "Имя",
                TaskDescription = "Описание"
            };

            var wrongTask = new TaskModel()
            {
                Id = 2,
                UserId = 2,
                TaskName = "Имя",
                TaskDescription = "Описание"
            };

            var user = new UserModel() { Id = 1, Login = "Логин", Password = "Пароль" };
            var secondUser = new UserModel() { Id = 2, Login = "Логин", Password = "Пароль" };

            VirtualDatabaseProvider inMemoryDatabaseProvider = new VirtualDatabaseProvider();
            TasksRepository taskRepository = new TasksRepository(inMemoryDatabaseProvider);

            // Act
            using (var db = inMemoryDatabaseProvider.Open())
            {
                db.CreateTableIfNotExists<TaskModel>();
                db.CreateTableIfNotExists<UserModel>();
                db.Insert<UserModel>(user);
                db.Insert<UserModel>(secondUser);
                db.Insert<TaskModel>(expectedTask);
                db.Insert<TaskModel>(wrongTask);
            }

            var realTask = taskRepository.GetAllTasks(expectedTask.UserId).ToArray();

            // Assert
            Assert.Single(realTask);
            Assert.Equal(expectedTask.Id, realTask[0].Id);
            Assert.Equal(expectedTask.UserId, realTask[0].UserId);
            Assert.Equal(expectedTask.TaskName, realTask[0].TaskName);
            Assert.Equal(expectedTask.TaskDescription, realTask[0].TaskDescription);
        }

        [Fact]
        public void Validate_OnDeleteTaskById_ShouldBeEmptyDB()
        {
            var task = new TaskModel()
            {
                Id = 1,
                UserId = 1,
                TaskName = "Имя",
                TaskDescription = "Описание"
            };

            var user = new UserModel() { Id = 1, Login = "Логин", Password = "Пароль" };

            VirtualDatabaseProvider inMemoryDatabaseProvider = new VirtualDatabaseProvider();
            TasksRepository taskRepository = new TasksRepository(inMemoryDatabaseProvider);
            UserRepository userRepository = new UserRepository(inMemoryDatabaseProvider);

            // Act
            using (var db = inMemoryDatabaseProvider.Open())
            {
                db.CreateTableIfNotExists<TaskModel>();
                db.CreateTableIfNotExists<UserModel>();
                db.Insert<UserModel>(user);
                db.Insert<TaskModel>(task);
            }

            taskRepository.DeleteTask(task.Id);

            List<TaskModel> tasks;
            using (var db = inMemoryDatabaseProvider.Open())
                tasks = db.Select<TaskModel>();

            // Assert
            Assert.Empty(tasks);
        }
    }
}
