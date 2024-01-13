using Microsoft.AspNetCore.Mvc;
using MyMVCDemo1.Data;
using MyMVCDemo1.Models;

namespace MyMVCDemo1.Controllers
{
    public class PersonsController : Controller
    {
        private MyWebAppDb _context;

        public PersonsController(MyWebAppDb context)
        {
            _context = context;
        }

        [HttpGet]    //to view the all persons list from where we can manage all CRUD operation
        public IActionResult Index()
        {
            var persons = _context.Persons.ToList();
            return View(persons);
        }

        //creating request method for create view right click on create and add new view for create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //creating post method for submitting data to database.
        [HttpPost]
        public IActionResult Create(Person person)
        {
            //  person.Name = "CDAC";   
            _context.Persons.Add(person);  //Database
            _context.SaveChanges();//  Commit
            return Redirect("Index");
        }

        //ceate view and post method for Edit operation 
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Person person = _context.Persons.Find(id);
            return View(person);

        }

        [HttpPost]
        public IActionResult Edit( Person person) 
        {
            _context.Persons.Update(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        //creating view for Details person 
        [HttpGet]
        public IActionResult Details(int id) 
        {
            Person person = _context.Persons.Find(id);
            return View(person);
        }

        //creating view and post for delete method
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Person person = _context.Persons.Find(id);
            //  _context.Persons.Remove(_context.Persons.Find(id));
            //  _context.SaveChanges();
            //  return RedirectToAction("Index");

            return View(person);
        }

        //create post method for delete confirmation
        [HttpPost]
        public IActionResult Delete(Person person)
        {
            _context.Remove(person);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }

}