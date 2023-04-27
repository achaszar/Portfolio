using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class TicTacToeController : Controller
    {
        private TicTacToeViewModel _tttViewModel = new TicTacToeViewModel();
        public IActionResult Index()
        {
            return View(_tttViewModel);
        }

        public IActionResult TicTacToeBoard(int wins, int loss, int tie)
        {
            return View("Index");
        }
    }
}
