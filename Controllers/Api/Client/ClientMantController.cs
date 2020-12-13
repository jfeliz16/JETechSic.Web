using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JETech.NetCoreWeb;
using JETech.SIC.Core.Clients.Interfaces;
using JETech.SIC.Core.Clients.Models;
using JETech.SIC.Web.Models.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

                var result = await _clientService.GetClients(args);

                return Ok(result);
            }
            catch (Exception ex)
            {
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
