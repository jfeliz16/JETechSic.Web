using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JETech.SIC.Web.Models.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JETech.SIC.Web.Controllers.Api.Client
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientMantController : ControllerBase
    {        

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<ClientViewModel> listClient = new List<ClientViewModel>
            {
                new ClientViewModel
                {
                    FullName = "Jose Feliz",
                    FirstName = "Jose",
                    LastName = "Feliz",
                    CellPhome = "809-999-9999",
                    StatusName = "ACTIVO"
                },
                new ClientViewModel
                {
                    FullName = "Manuel Almonte",
                    FirstName = "Manuel",
                    LastName = "Almonte",
                    CellPhome = "809-999-9999",
                    StatusName = "ACTIVO"
                },
                new ClientViewModel
                {
                    FullName = "Miladys Santana",
                    FirstName = "Miladys",
                    LastName = "Santana",
                    CellPhome = "809-999-9999",
                    StatusName = "ACTIVO"
                },
                new ClientViewModel
                {
                    FullName = "Andrick Lora",
                    FirstName = "Andrick",
                    LastName = "Lora",
                    StatusName = "ACTIVO"
                }
            };

            for (int i = 0; i < 50; i++)
            {
                listClient.Add(new ClientViewModel
                {
                    FullName = "Andrick Lora",
                    FirstName = "Andrick",
                    LastName = "Lora",
                    StatusName = "ACTIVO"
                });
            }

            return Ok(listClient);
        }

        [HttpGet("GetName")]
        public IActionResult GetName() {
            return Ok("My name");
        }
    }
}
