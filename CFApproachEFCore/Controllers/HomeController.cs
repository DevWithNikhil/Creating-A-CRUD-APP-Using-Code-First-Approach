using CFApproachEFCore.Data;
using CFApproachEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CFApproachEFCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext studentDb;

        public HomeController(StudentDbContext studentDb)
        {
            this.studentDb = studentDb;
        }
        public async Task<IActionResult> Index()
        {
            var stdData = await studentDb.Students.ToListAsync();
            return View(stdData);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
                await studentDb.Students.AddAsync(std);
                await studentDb.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(std);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || studentDb.Students == null)
            {
                return NotFound();
            }
            var stdData = await studentDb.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || studentDb.Students == null)
            {
                return NotFound();
            }
            var stdData = await studentDb.Students.FindAsync(id);
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Student std)
        {
            if (id != std.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                studentDb.Students.Update(std);
                await studentDb.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(std);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || studentDb.Students == null)
            {
                return NotFound();
            }
            var stdData = await studentDb.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var stdData = await studentDb.Students.FindAsync(id);
            if(stdData != null)
            {
                studentDb.Students.Remove(stdData);
            }
            await studentDb.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
