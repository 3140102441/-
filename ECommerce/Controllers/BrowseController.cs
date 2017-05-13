using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ECommerce.Models;
using ECommerce.Models.AccountViewModels;
using ECommerce.Services;
using Microsoft.AspNetCore.Http;
using ECommerce.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    public class BrowseController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly ILogger _logger;
        private readonly string _externalCookieScheme;
        private readonly ApplicationDbContext _context;


        public BrowseController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IOptions<IdentityCookieOptions> identityCookieOptions,
            IEmailSender emailSender,
            ISmsSender smsSender,
            ILoggerFactory loggerFactory,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _externalCookieScheme = identityCookieOptions.Value.ExternalCookieAuthenticationScheme;
            _emailSender = emailSender;
            _smsSender = smsSender;
            _logger = loggerFactory.CreateLogger<AccountController>();
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            return View(
                new Models.BrowseViewModels.IndexViewModel { Genres = Commodity.Genres });

        }

        [HttpPost]
        public async Task<IActionResult> Search(Models.BrowseViewModels.IndexViewModel model)
        {

            var searchRes = await _context.Commodity.Where(i => i.Name.Contains(model.SearchString))
                .Select(i => new Models.BrowseViewModels.IndexViewModel.Commodity
                {
                    Genre = i.Genre,
                    ImagePaths = i.Paths.Select(j => j.FullStaticPath()).ToList(),
                    Name = i.Name
                })
                .ToListAsync();

            return View(new Models.BrowseViewModels.IndexViewModel { Commodities = searchRes });
        }

        [HttpPost]
        public async Task<IActionResult> Search(string searchString)
        {

            var searchRes = await _context.Commodity.Where(i => i.Name.Contains(searchString))
                .Select(i => new Models.BrowseViewModels.IndexViewModel.Commodity
                {
                    Genre = i.Genre,
                    ImagePaths = i.Paths.Select(j => j.FullStaticPath()).ToList(),
                    Name = i.Name
                })
                .ToListAsync();

            return View(new Models.BrowseViewModels.IndexViewModel { Commodities = searchRes });
        }

        [HttpPost]
        public async Task<IActionResult> Genre(Models.BrowseViewModels.IndexViewModel model)
        {

            var searchRes = await _context.Commodity.Where(i => i.Genre == model.Genre)
                .Select(i => new Models.BrowseViewModels.IndexViewModel.Commodity
                {
                    Genre = i.Genre,
                    ImagePaths = i.Paths.Select(j => j.FullStaticPath()).ToList(),
                    Name = i.Name
                })
                .ToListAsync();

            return View(new Models.BrowseViewModels.IndexViewModel { Commodities = searchRes });
        }
    }
}