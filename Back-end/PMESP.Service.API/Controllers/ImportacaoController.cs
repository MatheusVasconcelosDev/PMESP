using Microsoft.AspNetCore.Mvc;
using PMESP.Application.DTO;
using PMESP.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace PMESP.Service.API.Controllers
{
    [Route("api/importacao")]
    [ApiController]
    public class ImportacaoController : ControllerBase
    {
        private readonly IApplicationServiceImportacao applicationServiceImportacao;

        public ImportacaoController(IApplicationServiceImportacao applicationServiceImportacao)
        {
            this.applicationServiceImportacao = applicationServiceImportacao;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetImportacoes()
        {
            return Ok(applicationServiceImportacao.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetImportacao(int id)
        {
            return Ok(applicationServiceImportacao.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PlanilhaDTO planilhaDTO)
        {
            try
            {
                if (planilhaDTO == null)
                    return NotFound();

                applicationServiceImportacao.Add(planilhaDTO);
                return Ok("Planilha Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PlanilhaDTO planilhaDTO)
        {
            try
            {
                if (planilhaDTO == null)
                    return NotFound();

                applicationServiceImportacao.Update(planilhaDTO);
                return Ok("Planilha Atualizada com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PlanilhaDTO planilhaDTO)
        {
            try
            {
                if (planilhaDTO == null)
                    return NotFound();

                applicationServiceImportacao.Remove(planilhaDTO);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
