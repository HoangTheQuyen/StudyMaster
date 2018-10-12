using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMaster.Models
{
    public interface IRepository
    {
        IEnumerable<Question> GetAllQuestions { get;}
    }
}
