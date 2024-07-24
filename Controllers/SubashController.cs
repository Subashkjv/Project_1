using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApplication4.Models;
using WebApplication4.Repository;
namespace WebApplication4.Controllers
{
    public class SubashController : Controller
    {
       
        public IActionResult Index()
        {
            StudentRespository sub = new StudentRespository();
               //List<SUB> studentslist=new List<SUB>();
               //studentslist.Add(new SUB{ id=1, Name="raj",Depatartment="CSE",Year=2021 });
               //studentslist.Add(new SUB { id = 2, Name = "siva", Depatartment = "CSE", Year = 2021 });
               //studentslist.Add(new SUB { id = 3, Name = "mohan", Depatartment = "CSE", Year = 2021 });
               ViewData["Mylist"] = sub.GetAllStudent();
            //ViewBag.MyData = studentslist;
           
            //TempData["Mlist"] = studentslist;
            return View();
        }

        //public IActionResult Index()
        //{

        //    List<SUB> studentslist = new List<SUB>();
        //    studentslist.Add(new SUB { id = 1, Name = "raj", Depatartment = "CSE", Year = 2021 });
        //    studentslist.Add(new SUB { id = 2, Name = "siva", Depatartment = "CSE", Year = 2021 });
        //    studentslist.Add(new SUB { id = 3, Name = "mohan", Depatartment = "CSE", Year = 2021 });
        //    ViewData["Mylist"] = studentslist;
        //    ViewBag.MyData = studentslist;
        //    TempData["Mlist"] = studentslist;
        //    return RedirectToAction("Anoth");
        //}
        public IActionResult Another()
        {       
            ViewBag.Name = "MVC";
            return View();
        }

        public IActionResult AnotherEXP()
        {           
            ViewBag.Name = "MVC- Model Controller View";
      
            return View("Another");
        }

        public IActionResult Anoth()
        {
            ViewBag.Myslist = TempData["Mlist"];
            TempData.Keep(); //  use to to another action 

            return View();
        }

        public IActionResult Anoth1()
        {
            ViewBag.Myslist = TempData["Mlist"];
   
            return View();
        }

        //public IActionResult RenderMethod()
        //{
        //    List<SUB> studentslist = new List<SUB>();
        //    studentslist.Add(new SUB { id = 1, Name = "raj", Depatartment = "CSE", Year = 2021 });
        //    studentslist.Add(new SUB { id = 2, Name = "siva", Depatartment = "CSE", Year = 2021 });
        //    studentslist.Add(new SUB { id = 3, Name = "mohan", Depatartment = "CSE", Year = 2021 });
        //    ViewBag.rm=studentslist;
        //    return PartialView("_PartialList");
        //}
    }
}




//ViewBag is a dynamic property that allows you to pass data from controllers to view. in which we have used different data type and variable name like ViewBag.ANY_NAME
//ViewBag.Name = "SUBASH"; 
//ViewData["subash"] = "View_DATA";


//ViewData.Add(new KeyValuePair<string, object>("Name", "Anto"));
//ViewData.Add(new KeyValuePair<string, object>("Dept", "EEE"));