using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager_Noskov.Classes.Database;
using TaskManager_Noskov.Models;

namespace TaskManager_Noskov.Context
{
    public class TasksContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; } 
        public TasksContext()
        {
            Database.EnsureCreated();
            Tasks.Load();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseMySql(Config.connection, Config.version);
    }
}
