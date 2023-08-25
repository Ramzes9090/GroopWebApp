﻿using GroopWebApp.Data;
using GroopWebApp.Interfaces;
using GroopWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GroopWebApp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _dashboardRepository;

        public DashboardController(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }
        public async Task<IActionResult> Index()
        {
            var userRaces = await _dashboardRepository.GetAllUserRaces();
            var userClubs = await _dashboardRepository.GetAllUserClubs();
            var dashboardViewModel = new DashboardViewModel()
            {
                Races = userRaces,
                Clubs = userClubs

            };

            return View(dashboardViewModel);
        }
    }
}