using Microsoft.AspNetCore.Mvc;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModelo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ParceiroController : ControllerBase
    {
        private readonly IApplicationServiceParceiro applicationServiceParceiro;

        public ParceiroController(IApplicationServiceParceiro applicationServiceParceiro)
        {
            this.applicationServiceParceiro = applicationServiceParceiro;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceParceiro.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceParceiro.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ParceiroDto parceiroDTO)
        {
            try
            {
                if (parceiroDTO == null)
                    return NotFound();


                applicationServiceParceiro.Add(parceiroDTO);
                return Ok("O parceiro foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ParceiroDto parceiroDTO)
        {

            try
            {
                if (parceiroDTO == null)
                    return NotFound();

                applicationServiceParceiro.Update(parceiroDTO);
                return Ok("O parceiro foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ParceiroDto parceiroDTO)
        {
            try
            {
                if (parceiroDTO == null)
                    return NotFound();

                applicationServiceParceiro.Remove(parceiroDTO);
                return Ok("O parceiro foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}