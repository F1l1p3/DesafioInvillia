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
using DesafioDotNet.Models.dto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesafioDotNet.Controllers
{
    [Authorize]
    public class JogoEmprestadoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JogoEmprestadoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<JogoEmprestado> jogoEmp = ListJogoEmprestado();
            return View(jogoEmp);
        }

        private List<JogoEmprestado> ListJogoEmprestado()
        {
            List<JogoEmprestado> jogoEmp = new List<JogoEmprestado>();
            var jogosEmprestados = _context.JogoEmprestado.Where(e => e.Devolvido == false).ToList();
            foreach (var item in jogosEmprestados)
            {
                JogoEmprestado jgEmp = new JogoEmprestado();
                jgEmp.IdJogoEmprestado = item.IdJogoEmprestado;
                jgEmp.IdJogo = _context.Jogo.Single(i => i.Id == item.IdJogoId);
                jgEmp.IdAmigo = _context.Amigo.Single(i => i.Id == item.IdAmigoId);
                jgEmp.DataEmprestimo = item.DataEmprestimo;
                jgEmp.Devolvido = item.Devolvido;

                jogoEmp.Add(jgEmp);
            }

            return jogoEmp;
        }

        public JsonResult IndexJson()
        {
            return Json(_context.JogoEmprestado.ToList());
        }

        [HttpGet]
        public IActionResult Save()
        {
            ViewBagsCreateEdit(0,0);
            return View("Create");
        }

        private void ViewBagsCreateEdit(int jogo, int amigo)
        {
            List<int> jogosEmprestados = _context.JogoEmprestado.Where(i => i.Devolvido.Equals(false)).Select(i => i.IdJogoId).ToList();
            ViewBag.Jogos = new SelectList(_context.Jogo.Where(i => !jogosEmprestados.Contains(i.Id)).ToList(), "Id", "NomeJogo",jogo);
            ViewBag.Amigos = new SelectList(_context.Amigo.ToList(), "Id", "Nome",amigo);
        }

        [HttpPost]
        public IActionResult Save(JogoEmprestadoDto item)
        {

            if (item.IdJogoId == 0)
            {
                ViewBag.Error = "Não foi informado um Jogo";
                ViewBagsCreateEdit(0,0);
                return View("Create");
            }
            else if (item.IdAmigoId == 0)
            {
                ViewBag.Error = "Não foi informado um Amigo";
                ViewBagsCreateEdit(0,0);
                return View("Create");
            }
            else
            {

                item.DataEmprestimo = DateTime.Now;
                item.Devolvido = false;

                _context.JogoEmprestado.Add(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

        }

        public IActionResult Edit(int id)
        {
            var item = _context.JogoEmprestado.First(j => j.IdJogoEmprestado == id);
            ViewBagsCreateEdit(item.IdJogoId,item.IdAmigoId);
            ViewBag.IdJogoEmprestado = item.IdJogoEmprestado;
            return View("Create");
        }

        [HttpPost]
        public IActionResult Edit(JogoEmprestadoDto item)
        {
            var JogoEmprestado = _context.JogoEmprestado.First(j => j.IdJogoEmprestado == item.IdJogoEmprestado);
            JogoEmprestado.IdJogoId = item.IdJogoId;
            JogoEmprestado.IdAmigoId = item.IdAmigoId;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var JogoEmprestado = _context.JogoEmprestado.First(j => j.IdJogoEmprestado == id);
            _context.JogoEmprestado.Remove(JogoEmprestado);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Devolucao(int id)
        {
            var JogoEmprestado = _context.JogoEmprestado.First(j => j.IdJogoEmprestado == id);
            JogoEmprestado.Devolvido = true;
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
