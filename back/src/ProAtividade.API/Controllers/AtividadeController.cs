using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAtividade.API.Controllers.Models;

namespace ProAtividade.API.Controllers
{
    [Route("api/[controller]")]
    public class AtividadeController : Controller
    {
        [HttpGet]
        public Atividade Get()
        {
            return new Atividade();
        }

         [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Meu primeiro método get com parâmetro = {id}";
        }

        [HttpPost]
        public string Post()
        {
            return "Meu primeiro método Post";
        }
       
        [HttpPut("id")]
        public string Put(int id)
        {
            return "Meu primeiro método Put";
        }

        [HttpDelete("id")]
        public string Delete(int id)
        {
            return "Meu primeiro método Delete";
        }
    }
}