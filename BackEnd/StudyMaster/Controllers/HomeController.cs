using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudyMaster.Models;

namespace StudyMaster.Controllers
{
    public class HomeController : Controller
    {

        private IRepository repository { get; }
        public HomeController(IRepository repo) => repository = repo;

        public IActionResult Index()
        {
            return View(repository.GetAllQuestions);
        }
    }
}