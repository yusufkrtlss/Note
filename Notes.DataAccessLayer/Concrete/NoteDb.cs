using Microsoft.EntityFrameworkCore;
using Notes.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.DataAccessLayer.Concrete
{
    public class NoteDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-TIRV6AC\\MSSQLSERVER01;database=NotesDb;integrated security=true;");
        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TreeViewNode> TreeViewNodes { get; set; }
    }
}
