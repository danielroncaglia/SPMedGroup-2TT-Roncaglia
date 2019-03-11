using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.MedicalGroup.WebAPI.Roncaglia.Domains;
using Senai.MedicalGroup.WebAPI.Roncaglia.Interfaces;
using Senai.MedicalGroup.WebAPI.Roncaglia.Repositories;

namespace Senai.MedicalGroup.WebAPI.Roncaglia.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        
        private IConsultaRepository ConsultaRepository { get; set; }

        public ConsultasController()
        {
            ConsultaRepository = new ConsultaRepository();
        }

        //Cadastrar nova consulta
        [HttpPost]
        public IActionResult cadastrarConsultas(Consultas consulta)
        {
            try
            {
                ConsultaRepository.cadastrarConsulta(consulta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }

        //Apagar consulta
        public IActionResult Apagar(int id)
        {
            try
            {
                        ConsultaRepository.apagarConsulta(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }

        //Listar todas as consultas
        [HttpGet]
        public IActionResult todasConsultas()
        {
                try
                {
                   
                        return Ok(ConsultaRepository.todasConsultas());
                    
                }
                catch (Exception ex)
                {
                       return BadRequest(new { mensagem = ex.Message });
                }
        }

        //Listar as consultas por paciente
        [HttpGet("paciente/{id}")]
        public IActionResult consultasporPaciente(int Id)
        {
            try
            {

                return Ok(ConsultaRepository.consultaporPaciente(Id));

            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }

        //Listar as consultas por medicos
        [HttpGet("medico/{Id}")]
        public IActionResult consultaporMedico(int Id)
        {
            try
            {

                return Ok(ConsultaRepository.consultaporMedico(Id));

            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }

        //Atualizar consulta
        [HttpPut]
        public IActionResult atualizarConsulta(Consultas consulta)
        {
            try
            {
               ConsultaRepository.atualizarConsulta(consulta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }
        

    }
}