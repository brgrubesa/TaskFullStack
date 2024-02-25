using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskFullStack.Models;

namespace TaskFullStack.Data
{
    public class TaskFullStackContext : DbContext
    {
        public TaskFullStackContext (DbContextOptions<TaskFullStackContext> options)
            : base(options)
        {
        }

        public DbSet<TaskFullStack.Models.Article> Article { get; set; }
    }
}
