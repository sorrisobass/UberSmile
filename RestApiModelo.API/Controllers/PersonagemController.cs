using Microsoft.AspNetCore.Mvc;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModelo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonagemController : ControllerBase
    {
        private readonly IApplicationServicePersonagem applicationServicePersonagem;

        public PersonagemController(IApplicationServicePersonagem applicationServicePersonagem)
        {
            this.applicationServicePersonagem = applicationServicePersonagem;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServicePersonagem.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServicePersonagem.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PersonagemDto personagemDTO)
        {
            try
            {
                if (personagemDTO == null)
                    return NotFound();


                applicationServicePersonagem.Add(personagemDTO);
                return Ok("O personagem foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PersonagemDto personagemDTO)
        {

            try
            {
                if (personagemDTO == null)
                    return NotFound();

                applicationServicePersonagem.Update(personagemDTO);
                return Ok("O personagem foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PersonagemDto personagemDTO)
        {
            try
            {
                if (personagemDTO == null)
                    return NotFound();

                applicationServicePersonagem.Remove(personagemDTO);
                return Ok("O personagem foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}