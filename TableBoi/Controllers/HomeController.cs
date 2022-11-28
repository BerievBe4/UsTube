using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TableBoi.Controllers.Helpers;
using TableBoi.Models;
using TableBoi.Repositories;

namespace TableBoi.Controllers
{
    public class HomeController : Controller
    {
        private readonly TasksRepository _tasksRepository;
        public HomeController(TasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        public IActionResult Index(int userId)
        {
            string contextId = HttpContext.Session.GetString("UserID");
            if (string.IsNullOrEmpty(contextId))
                return RedirectToAction("Auth", "Login");
            var id = userId != 0 ? userId : Int32.Parse(contextId);

            if (id <= 0)
                return BadRequest();
            else
            {
                var tasks = _tasksRepository.GetAllTasks(id);
                ViewBag.Tasks = tasks;
                return View("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrEdit(Models.TaskModel task)
        {
            if (task == null)
                return BadRequest();

            if (!ValidationHelper.ValidateName(task.TaskName, task.TaskDescription))
                return BadRequest();

            if (task.TaskDescription == null || string.IsNullOrEmpty(task.TaskDescription))
                return BadRequest();

            if (task.Id < 0)
                return BadRequest();

            try
            {
                task.UserId = Int32.Parse(HttpContext.Session.GetString("UserID"));
                task.CreationDate = DateTime.UtcNow;

                if (task.Id == 0)
                    _tasksRepository.AddTask(task);
                else
                    _tasksRepository.EditTask(task);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }       

            return Json(data: new { success = true, message = "Данные были успешно добавлены." });
        }

        [HttpGet]
        public IActionResult AddOrEdit(int TaskId = 0)
        {

            if (TaskId < 1)
                return BadRequest();

            var task = _tasksRepository.GetTaskById(TaskId);
            //if (task is null)
            //{
            //    task = new TaskModel();
            //}

            //return Ok(task);

            string jsonString = JsonSerializer.Serialize(task);

            return Json(data: jsonString);
        }

        [HttpDelete]
        public IActionResult DeleteTask(int id)
        {
            if (id <= 0)
                return BadRequest();
            else
            {
                _tasksRepository.DeleteTask(id);
                //return View("Index");
                return Json(data: new { success = true, message = "Данные были успешно удалены." });
            }
          
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
