using Microsoft.AspNetCore.Mvc;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModelo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DimensaoController : ControllerBase
    {

        private readonly IApplicationServiceDimensao applicationServiceDimensao;


        public DimensaoController(IApplicationServiceDimensao applicationServiceDimensao)
        {
            this.applicationServiceDimensao = applicationServiceDimensao;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceDimensao.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceDimensao.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] DimensaoDto dimensaoDTO)
        {
            try
            {
                if (dimensaoDTO == null)
                    return NotFound();

                applicationServiceDimensao.Add(dimensaoDTO);
                return Ok("Dimensao Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] DimensaoDto dimensaoDTO)
        {
            try
            {
                if (dimensaoDTO == null)
                    return NotFound();

                applicationServiceDimensao.Update(dimensaoDTO);
                return Ok("Dimensao Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] DimensaoDto dimensaoDTO)
        {
            try
            {
                if (dimensaoDTO == null)
                    return NotFound();

                applicationServiceDimensao.Remove(dimensaoDTO);
                return Ok("Dimensao Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}