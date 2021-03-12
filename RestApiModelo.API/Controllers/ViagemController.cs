using Microsoft.AspNetCore.Mvc;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModelo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ViagemController : ControllerBase
    {
        private readonly IApplicationServiceViagem applicationServiceViagem;

        public ViagemController(IApplicationServiceViagem applicationServiceViagem)
        {
            this.applicationServiceViagem = applicationServiceViagem;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceViagem.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceViagem.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ViagemDto viagemDTO)
        {
            try
            {
                if (viagemDTO == null)
                    return NotFound();


                applicationServiceViagem.Add(viagemDTO);
                return Ok("O viagem foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ViagemDto viagemDTO)
        {

            try
            {
                if (viagemDTO == null)
                    return NotFound();

                applicationServiceViagem.Update(viagemDTO);
                return Ok("O viagem foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ViagemDto viagemDTO)
        {
            try
            {
                if (viagemDTO == null)
                    return NotFound();

                applicationServiceViagem.Remove(viagemDTO);
                return Ok("O viagem foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}