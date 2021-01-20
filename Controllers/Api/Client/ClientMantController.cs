﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JETech.NetCoreWeb.Types;
using JETech.SIC.Core.Clients.Interfaces;
using JETech.SIC.Core.Clients.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JETech.NetCoreWeb.Exceptions;

namespace JETech.SIC.Web.Controllers.Api.Client
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientMantController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientMantController(IClientService clientService) 
        {
            _clientService = clientService;
        }

        [HttpPost]        
        public async Task<IActionResult> Get(ActionQueryArgs<ClientModel> args)
        {
            try
            {
                if (!string.IsNullOrEmpty(args.CondictionString))
                {                    
                        args.Condiction = JETech.DevExtremeCore.Converter.FilterToExpresion<ClientModel>(args.CondictionString);
                }
                var resultCli =  _clientService.GetClients(args);
                
                var result = new ActionPaginationResult<List<ClientModel>>
                {
                    Data = await resultCli.Data.AsNoTracking().ToListAsync(),
                    GroupCount = resultCli.GroupCount,
                    TotalCount = resultCli.TotalCount
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty,JETechException.Parse(ex).AppMessage);
                throw;
            } 
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    ActionQueryArgs<ClientModel> args = new ActionQueryArgs<ClientModel>();

        //    return Ok(await _clientService.GetClients(args));
        //}

        [HttpGet("GetName")]
        public IActionResult GetName() {
            return Ok("My name");
        }
    }
}
