using ApiPredutos.Data.Entities;
using ApiPredutos.Data.Repositories;
using ApiPredutos.Services.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPredutos.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
                        //Produtos//
    public class AgendaController : ControllerBase
    {
        //atributo
        private readonly IMapper _mapper;

        //construtor para inicialização dos atributos
        public AgendaController(IMapper mapper)
        {
            _mapper = mapper;
        }



        [HttpPost]
        public IActionResult Post(AgendaPostModel model)
        {
            try
            {
                var agenda = _mapper.Map<Agenda>(model);

                var agendaRepository = new AgendaRepository();
                agendaRepository.Add(agenda);

                return StatusCode(201, new
                {
                    mensagem = "Agenda feita  com sucesso.",
                    produto = _mapper.Map<AgendaGetModel>(agendaRepository.GetById(agenda.IdAgenda))
                });
            }
            catch (Exception e)
            {
                return StatusCode(500,new{  mensagem = "Falha ao confirmar o agendamento: "+ e.Message});
            }

        }

        [HttpPut]
        public IActionResult Put(AgendaPutModel model)
        {
            try
            {
                var agendaRepository = new AgendaRepository();
                if (agendaRepository.GetById(model.IdAgenda) == null)
                    return StatusCode(404,
                        new { mensagem = "Agendamento não encontrado." });

                var agenda = _mapper.Map<Agenda>(model);
                agendaRepository.Update(agenda);

                return StatusCode(200,
                    new
                    {
                        mensagem = "Agenda Atualizada com sucesso.",
                        agenda = _mapper.Map<AgendaGetModel>(agenda)
                    });

            }
            catch (Exception e)
            {
                return StatusCode(500,
                    new { mensagem = "Falha ao atualizar a agenda :(" });

            }
        }

        [HttpDelete ("{id}")]
        public IActionResult Delete(Guid? id) {

            try
            {
                var agendaRepository = new AgendaRepository();
                var agenda = agendaRepository.GetById(id);

                if (agenda == null)
                    return StatusCode(404, new { mensagem = "Agendamento não encontrado" });

                agendaRepository.Delete(agenda);

                return StatusCode(200,
                   new
                   {
                       mensagem = "Agendamento excluído com sucesso.",
                       agenda = _mapper.Map<AgendaGetModel>(agenda)
                   });
            }
            catch (Exception e)
            {
                return StatusCode(500,
                    new { mensagem = "Falha ao excluír agenda :(" });
            }
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<AgendaGetModel>),200)]
        public IActionResult GetAll() {
            try
            {
                var agendaRepository = new AgendaRepository();
                var agenda = agendaRepository.GetAll();

                return StatusCode(200, _mapper.Map<List<AgendaGetModel>>(agenda));
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensagem = "Erro ao consultar os agendamnetos:( " + e.Message });

            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(List<AgendaGetModel>), 200)]
        public IActionResult GetById(Guid? id) {
            try
            {
                var agendaRepository = new AgendaRepository();
                var agenda = agendaRepository.GetById(id);
                if (agenda == null)
                    return StatusCode(404,
                        new { mensagem = "Agendamento não encontrado." });
                else
                    return StatusCode(200, _mapper.Map<AgendaGetModel>(agenda));
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mennsagem = "Erro ao oobter Agendamentos:(" + e.Message });
            }
        }
    }
}
