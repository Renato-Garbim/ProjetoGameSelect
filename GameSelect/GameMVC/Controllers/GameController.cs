using Game.Application.Interface;
using GameMVC.Models.JogoModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMVC.Controllers
{
    public class GameController : Controller
    {
        private readonly IJogoAppService _appService;

        public GameController(IJogoAppService appService)
        {
            _appService = appService;
        }       

        public JogoViewModel CarregarIndex()
        {
            var model = new JogoViewModel();
            model.Lista = _appService.ObterTodos();

            return model;
        }


        public IActionResult Index()
        {
            var model = CarregarIndex();

            return View(model);
        }

        public IActionResult Editar(int id)
        {
            var model = new JogoEditModel();

            model.Registro = _appService.ObterPorId(id);

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Salvar(JogoEditModel model)
        {
            var result = _appService.AdicionarOuAtualizar(model.Registro);

            if (!result) return RedirectToAction("Editar", new { id = model.Registro.EntidadeGameId });

            return RedirectToAction("Index");
        }
    }
}
