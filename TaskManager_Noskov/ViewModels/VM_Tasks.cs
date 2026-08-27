using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_Noskov.Classes;
using TaskManager_Noskov.Context;
using TaskManager_Noskov.Models;

namespace TaskManager_Noskov.ViewModels
{
    public class VM_Tasks : Notification
    {
        public ObservableCollection<Tasks> Tasks { get; set; }
        public TasksContext tasksContext;
        public VM_Tasks() =>
            Tasks = new ObservableCollection<Tasks>(tasksContext.Tasks.OrderBy(x=>x.Done));

        public RealyCommand OnAddTask
        {
            get
            {
                return new RealyCommand(obj =>
                {
                    Tasks newTask = new Tasks()
                    {
                        DateExecute = DateTime.Now
                    };
                    Tasks.Add(newTask);
                    tasksContext.Tasks.Add(newTask);
                    tasksContext.SaveChanges();
                });

            }
            
        }
    }
}
