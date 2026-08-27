using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_Noskov.Context;
using TaskManager_Noskov.Models;

namespace TaskManager_Noskov.ViewModels
{
    public class VM_Tasks
    {
        public TasksContext tasksContext;
        public List<Tasks> Tasks {  get; set; }
    }
}
