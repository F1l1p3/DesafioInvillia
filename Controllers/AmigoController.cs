using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioDotNet.Models;
using Microsoft.AspNetCore.Authorization;
using DesafioDotNet.Data;

namespace DesafioDotNet.Controllers
{
    [Authorize]
    public class AmigoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AmigoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Amigo.ToList());
        }

        public IActionResult Save()
        {
            return View("Create");
        }
        
        [HttpPost]
        public IActionResult Save(Amigo item)
        {
            _context.Amigo.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View("Update",_context.Amigo.First(j => j.Id == id));
        }

        [HttpPost]
        public IActionResult Edit(Amigo item)
        {
            var amigo = _context.Amigo.First(j => j.Id == item.Id);
            amigo.Nome = item.Nome;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Deleta(int id)
        {
            var amigo = _context.Amigo.First(j => j.Id == id);
            _context.Amigo.Remove(amigo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

       [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
