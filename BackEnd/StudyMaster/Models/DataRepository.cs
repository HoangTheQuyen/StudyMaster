using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMaster.Models
{
    public class DataRepository : IRepository
    {
        private EFDatabaseContext context { get; set; }

        public DataRepository(EFDatabaseContext ctx) => context = ctx;

        public IEnumerable<Question> GetAllQuestions => context.Questions.Include(s => s.Selections);

    }
}
