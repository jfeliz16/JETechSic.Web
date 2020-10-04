using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JETech.SIC.Web.Models;
using System.Security.Cryptography;
using DevExtreme.AspNet.Mvc;
using JETech.SIC.Core.Data.Entities;
using JETech.SIC.Core.User.Helper;
using JETech.SIC.Core.Exceptions;
using JETech.SIC.Web.Helper.User;
using JETech.SIC.Core.User.Services;
using JETech.SIC.Core.User.Interfaces;
using JETech.SIC.Core.Global;
using JETech.SIC.Web.Helper;

namespace JETech.SIC.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _context;
        private readonly IUserService _userManager;
        private readonly IUserConverterHelper _userConverterHelper;

        public AccountController(
            DataContext context,
            IUserService userManager,
            IUserConverterHelper userConverterHelper)
        {
            _context = context;
            _userManager = userManager;
            _userConverterHelper = userConverterHelper;
        }

        public IActionResult Login() 
        {
            return View();
        }

        [HttpPost]        
        public async Task<IActionResult> Login(LoginViewModel model) {
            if (ModelState.IsValid)
            {
                try
                {
                    var loginModel = _userConverterHelper.ToLoginModel(model);

                    var result = await _userManager.LoginAsync(loginModel);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError("", Messages.InvalidUser);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", JETechException.Parse(ex).AppMessage);
                }               
            }
            return View();
        }        
             
        public IActionResult Create()
        {
            return View();
        }
            
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = _userConverterHelper.ToUserModel(model);

                    var result = await _userManager.CreateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(Login));
                    }
                    ModelState.AddModelError("", "Ha ocurrido un error inesperado.");
                }
                catch (Exception ex)
                {                    
                    ModelState.AddModelError("", JETechException.Parse(ex).AppMessage);
                }
            }
            return View(model);
        }
              
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addUserViewModel = await _context.Users.FindAsync(id);
            if (addUserViewModel == null)
            {
                return NotFound();
            }
            return View(addUserViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName")] AddUserViewModel addUserViewModel)
        {
            if (id != addUserViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addUserViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!AddUserViewModelExists(addUserViewModel.Id.ToString()))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction(nameof(Index));
            }
            return View(addUserViewModel);
        }
                
        public async Task<IActionResult> Logout()
        {
            try
            {
                await _userManager.LogoutAsync();

                return RedirectToAction("Login", "Account");
            }
            catch (Exception)
            {
                return View(CommonWebHelper.PageError);
            }
        }

        public IActionResult ForgotPassword() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RecoverPassword(AddUserViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    return RedirectToAction("Login");
                }

                return View();
            }
            catch (Exception)
            {
                return View(CommonWebHelper.PageError);
            }
        }

    }
}
