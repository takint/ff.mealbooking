using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ff.mealbooking.app.Models;
using ff.mealbooking.app.ViewModels;
using AutoMapper;
using ff.mealbooking.app.Data;
using Microsoft.EntityFrameworkCore;
using ff.mealbooking.app.Data.DataModels;

namespace ff.mealbooking.app.Controllers
{
    public class HomeController : Controller
    {
        private readonly MealBookingDbContext _dbContext = new MealBookingDbContext();

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            DemandOrderViewModel vm = new DemandOrderViewModel();
            return View(vm);
        }

        public IActionResult MealVoting()
        {
            MealVoteViewModel vm = new MealVoteViewModel();
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> MealVoting(MealVoteViewModel viewModel)
        {
            MealVoteViewModel vm = new MealVoteViewModel();

            if (ModelState.IsValid)
            {
                MealVote model = Mapper.Map<MealVote>(viewModel);

                await _dbContext.AddAsync(model);
                await _dbContext.SaveChangesAsync();

                return RedirectToActionPermanent("VoteResults");
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> BookMeal(DemandOrderViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.CreateDate = DateTime.Now;
                viewModel.UpdateDate = DateTime.Now;
                viewModel.Cost = viewModel.Price * viewModel.Quantity;

                DemandOrder model = Mapper.Map<DemandOrder>(viewModel);

                await _dbContext.AddAsync(model);
                await _dbContext.SaveChangesAsync();

                return RedirectToActionPermanent("BookingList");
            }

            return View("Index", viewModel);
        }

        public async Task<IActionResult> VoteResults()
        {
            List<IGrouping<string, MealVote>> model = await _dbContext.MealVotes.GroupBy(m => m.VendorName).ToListAsync();
            return View(model);
        }


        public async Task<IActionResult> BookingList()
        {
            var model = await _dbContext.DemandOrders.Where(m => m.CreateDate.Day.Equals(DateTime.Now.Day)).ToListAsync();
            return View(Mapper.Map<List<DemandOrderViewModel>>(model));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
