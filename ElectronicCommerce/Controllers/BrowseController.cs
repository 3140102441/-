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
using ElectronicCommerce.Models;
using ElectronicCommerce.Models.AccountViewModels;
using ElectronicCommerce.Services;
using Microsoft.AspNetCore.Http;
using ElectronicCommerce.Data;
using Microsoft.EntityFrameworkCore;

namespace ElectronicCommerce.Controllers
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
        public IActionResult Index()
        {
            return View(
                new Models.BrowseViewModels.IndexViewModel
                {
                    Genres = new Commodity.GenreType[]
                    {
                        Models.Commodity.GenreType.Book,
                        Models.Commodity.GenreType.Clothes,
                        Models.Commodity.GenreType.Food
                    }
                });
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchString)
        {

            var searchRes = await _context.Commodity.Where(i => i.Name.Contains(searchString))
                .Select(i => new Models.BrowseViewModels.SearchViewModel.Commodity
                {
                    Genre = i.Genre,
                    ImagePaths = i.ImagePaths.Select(j => j.FullStaticPath()).ToList(),
                    Name = i.Name,
                    ID = i.ID
                })
                .ToListAsync();

            return View(new Models.BrowseViewModels.SearchViewModel { Commodities = searchRes });
        }

        [HttpGet]
        public async Task<IActionResult> Genre(Commodity.GenreType genre)
        {

            var res = await _context.Commodity.Where(i => i.Genre == genre)
                .Select(i => new Models.BrowseViewModels.GenreViewModel.Commodity
                {
                    ImagePaths = i.ImagePaths.Select(j => j.FullStaticPath()).ToList(),
                    Name = i.Name,
                    ID = i.ID
                })
                .ToListAsync();

            return View(new Models.BrowseViewModels.GenreViewModel { Commodities = res, Genre = genre });
        }

        [HttpGet]
        public async Task<IActionResult> Commodity(int commodityID)
        {

            var comm = await _context.Commodity.Where(i => i.ID == commodityID)
                .Select(i => new Models.BrowseViewModels.CommodityViewModel
                {
                    ImagePaths = i.ImagePaths.Select(j => j.FullStaticPath()).ToList(),
                    Name = i.Name,
                    ID = i.ID,
                    Genre = i.Genre,
                    Description = i.Description
                })
                .SingleOrDefaultAsync();

            return View(comm);
        }
    }
}
