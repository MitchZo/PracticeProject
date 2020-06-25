using Practice_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace DataAccessLayer
{
    public class DAL : IDAL
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        public DAL (IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        public List<TaskItem> GetAllItems()
        {
            return new List<TaskItem>();
        }
        public TaskItem GetTaskItem(int taskId)
        {
            return new TaskItem();
        }
        public void SaveTaskItem(TaskItem task)
        {

        }
        //private Dictionary<int,TaskItem> GetDataBase()
        //{
        //    var session = httpContextAccessor.HttpContext.Current.Session.Get("dictionary");
        //    return (Dictionary<int,TaskItem>)session;
        //}
    }
}
