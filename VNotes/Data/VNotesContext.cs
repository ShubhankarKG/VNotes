using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VNotes.Models;

    public class VNotesContext : DbContext
    {
        public VNotesContext (DbContextOptions<VNotesContext> options)
            : base(options)
        {
        }

        public DbSet<VNotes.Models.Note> Note { get; set; } = default!;
    }
