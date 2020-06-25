using Practice_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDAL
    {
        List<TaskItem> GetAllItems();
        TaskItem GetTaskItem(int taskId);
        void SaveTaskItem(TaskItem task);

        /*get all task items - input: nothing output:list of items
        get one task item using ID - input: taskId output: taskItem
        save task item - input: taskItem output: nothing*/
    }
}
