using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class GlassController : Controller
    {
        private readonly IGlassRepositore _repository;

        public GlassController(IGlassRepositore repository){
            _repository=repository;
        }

        public IActionResult Index(){
            var glasses = _repository.GetAll();
            return View(glasses);
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Glass glass){
            _repository.Create(glass);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(long id){
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id){
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Glass glass){
            _repository.Update(glass);
            return RedirectToAction("Index");
        }
    }
}