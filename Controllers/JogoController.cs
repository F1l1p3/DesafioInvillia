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
    public class JogoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JogoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Jogo.ToList());
        }

        [HttpGet]
        public IActionResult Save()
        {
            return View("Create");
        }
        
        [HttpPost]
        public IActionResult Save(Jogo item)
        {
            _context.Jogo.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

         public IActionResult Edit(int id)
        {
            return View("Update",_context.Jogo.First(j => j.Id == id));
        }

        [HttpPost]
        public IActionResult Edit(Jogo item)
        {
            var jogo = _context.Jogo.First(j => j.Id == item.Id);
            jogo.NomeJogo = item.NomeJogo;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var jogo = _context.Jogo.First(j => j.Id == id);
            _context.Jogo.Remove(jogo);
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
