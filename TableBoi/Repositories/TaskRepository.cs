using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableBoi.Models;
using TableBoi.Providers;

namespace TableBoi.Repositories
{
    public class TasksRepository : Repository
    {
        public TasksRepository(IDbConnectionProvider connectionProvider) :
            base(connectionProvider)
        { }

        private string SqlInsertTaskQuery(string name, string description, int userId, DateTime creationDate)
        {
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append("INSERT INTO TaskModel(UserId, TaskName, TaskDescription, CreationDate) VALUES('");
            sqlQuery.Append(userId);
            sqlQuery.Append("', '");
            sqlQuery.Append(name);
            sqlQuery.Append("', '");
            sqlQuery.Append(description);
            sqlQuery.Append("', '");
            var formatForMySql = creationDate.ToString("yyyy-MM-dd HH:mm:ss");
            sqlQuery.Append(formatForMySql);
            sqlQuery.Append("')");

            return sqlQuery.ToString();
        }

        private string SqlUpdateTaskQuery(string name, string description, int userId, int taskId)
        {
            StringBuilder sqlQuery = new StringBuilder();
            //sqlQuery.Append("Update Task(UserId, TaskName, TaskDescription, CreationDate) set Task.UserId = ");
            sqlQuery.Append("Update TaskModel set UserId = ");
            sqlQuery.Append(userId);
            sqlQuery.Append(", TaskName = '");
            sqlQuery.Append(name);
            sqlQuery.Append("', TaskDescription = '");
            sqlQuery.Append(description);
            sqlQuery.Append("' WHERE Id = ");
            sqlQuery.Append(taskId);

            return sqlQuery.ToString();
        }

        private string SqlDeleteTaskQuery(int taskId)
        {
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append("delete from TaskModel where TaskModel.Id = ");
            sqlQuery.Append(taskId);

            return sqlQuery.ToString();
        }
        private string SqlTasksByUserIdQuery(int id)
        {
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append("SELECT * FROM TaskModel WHERE UserId = ");
            sqlQuery.Append(id);

            return sqlQuery.ToString();
        }

        private string SqlTaskByIdQuery(int id)
        {
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append("SELECT * FROM TaskModel WHERE Id = ");
            sqlQuery.Append(id);

            return sqlQuery.ToString();
        }

        public void AddTask(TaskModel task)
        {
            string sql = SqlInsertTaskQuery(task.TaskName, task.TaskDescription, task.UserId, task.CreationDate);
            ExecuteSqlWithoutReturn(sql);
        }

        public void EditTask(TaskModel task)
        {
            string sql = SqlUpdateTaskQuery(task.TaskName, task.TaskDescription, task.UserId, task.Id);
            ExecuteSqlWithoutReturn(sql);
        }

        public void DeleteTask(int id)
        {
            string sql = SqlDeleteTaskQuery(id);
            ExecuteSqlWithoutReturn(sql);
        }

        public IEnumerable<TaskModel> GetAllTasks(int id)
        {
            string sql = SqlTasksByUserIdQuery(id);
            return ExecuteSqlReturnList<TaskModel>(sql);
        }

        public TaskModel GetTaskById(int id)
        {
            string sql = SqlTaskByIdQuery(id);
            return ExecuteSqlReturnList<TaskModel>(sql).FirstOrDefault();
        }
    }
}
