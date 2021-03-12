using Microsoft.AspNetCore.Mvc;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModelo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonagemParceiroParceiroController : ControllerBase
    {
        private readonly IApplicationServicePersonagemParceiro applicationServicePersonagemParceiro;

        public PersonagemParceiroParceiroController(IApplicationServicePersonagemParceiro applicationServicePersonagemParceiro)
        {
            this.applicationServicePersonagemParceiro = applicationServicePersonagemParceiro;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServicePersonagemParceiro.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServicePersonagemParceiro.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PersonagemParceiroDto personagemParceiroDTO)
        {
            try
            {
                if (personagemParceiroDTO == null)
                    return NotFound();


                applicationServicePersonagemParceiro.Add(personagemParceiroDTO);
                return Ok("O personagemParceiro foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PersonagemParceiroDto personagemParceiroDTO)
        {

            try
            {
                if (personagemParceiroDTO == null)
                    return NotFound();

                applicationServicePersonagemParceiro.Update(personagemParceiroDTO);
                return Ok("O personagemParceiro foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PersonagemParceiroDto personagemParceiroDTO)
        {
            try
            {
                if (personagemParceiroDTO == null)
                    return NotFound();

                applicationServicePersonagemParceiro.Remove(personagemParceiroDTO);
                return Ok("O personagemParceiro foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}