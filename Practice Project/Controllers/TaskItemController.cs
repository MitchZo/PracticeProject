using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer;
using Practice_Project.Models;

namespace Practice_Project.Controllers
{
    public class TaskItemController : Controller
    {
        private readonly IDAL dAL;
        public TaskItemController(IDAL DAL)
        {
            this.dAL = DAL;
        }
        public IActionResult ViewTasks()
        {
            List<TaskItem> task = this.dAL.GetAllItems();
            return View(task);
        }
        [HttpGet]
        public IActionResult EditTask(int taskId)
        {
            TaskItem foundTask = new TaskItem()
            {
                Name = "Trash",
                Description = "Take out the trash",
                DueDate = DateTime.Today,
                User = new User()
                {
                    Name = "Ted"
                }
            };

            return View(foundTask);
        }
        [HttpPost]
        public IActionResult EditTask(TaskItem task)
        {
            return RedirectToAction("ViewTasks");
        }
    }
}