﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Pet.Domains;
using API_Pet.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Pet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPetController : ControllerBase
    {
        //Aqui chamamos o a classe responsavel pela ligacao
        TipoPetRepository rep = new TipoPetRepository();

        // GET: api/<TipoPetController>
        [HttpGet]
        public List<TipoPet> Get()
        {
            return rep.LerTodos();
        }

        // GET api/<TipoPetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoPetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TipoPetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoPetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
