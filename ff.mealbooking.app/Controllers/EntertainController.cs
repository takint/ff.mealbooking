using AutoMapper;
using ff.mealbooking.app.Data;
using ff.mealbooking.app.Data.DataModels;
using ff.mealbooking.app.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ff.mealbooking.app.Controllers
{
    public class EntertainController : Controller
    {
        private readonly MealBookingDbContext _dbContext = new MealBookingDbContext();

        public async Task<IActionResult> Index()
        {
            var model = await _dbContext.Bettings.Where(m => m.CreateDate.Day.Equals(DateTime.Now.Day)).OrderBy(m => m.TeamName).ToListAsync();
            return View(Mapper.Map<List<BettingViewModel>>(model));
        }

        [HttpPost]
        public async Task<IActionResult> BetRegister(BettingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.CreateDate = DateTime.Now;
                viewModel.UpdateDate = DateTime.Now;

                Betting model = Mapper.Map<Betting>(viewModel);

                await _dbContext.Bettings.AddAsync(model);
                await _dbContext.SaveChangesAsync();

                return Json(viewModel);
            }

            return Json(ModelState.ErrorCount);
        }
    }
}
