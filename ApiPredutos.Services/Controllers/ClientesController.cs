using ApiPredutos.Data.Entities;
using ApiPredutos.Data.Repositories;
using ApiPredutos.Services.Models;
using AutoMapper;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPredutos.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
                    //Categoria//
    public class ClientesController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ClientesController(IMapper mapper) 
        { 
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(ClientesPostModel model){
            try
            {
                var clientes = _mapper.Map<Clientes>(model);

                var clientesRepository = new ClientesRepository();
                clientesRepository.Add(clientes);

                //HTTP 201 (CREATED)
                return StatusCode(201,new 
                {
                    mensagem = "Cliente cadastrado com sucesso.",
                    clientes = _mapper.Map<ClientesGetModel>(clientes)
                });
            }
            catch (Exception e)
            {
                //HTTP 500 (INTERNAL SERVER ERROR)
                return StatusCode(500,
                    new{ mensagem = "Falha ao cadastrar cliente: " + e.Message});
            }
        }


        [HttpPut]
        public IActionResult Put(ClientesPutModel model){

            try
            {
                var clientesRepository = new ClientesRepository();
                if (clientesRepository.GetById(model.IdCliente) == null)
                    return StatusCode(404,
                        new { mensagem = "Cliente não encontrado." });

                var clientes = _mapper.Map<Clientes>(model);
                clientesRepository .Update(clientes);

                return StatusCode(200, 
                    new { mensagem = "Cliente Atualizado com sucesso.",
                       clientes=_mapper.Map<ClientesGetModel>(clientes)
                    });

            }
            catch (Exception e)
            {
                return StatusCode(500,
                    new { mensagem = "Falha ao atualizar cliente :(" });

            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid? id) {
            try
            {
                var clientesRepository = new ClientesRepository();
                var clientes = clientesRepository.GetById(id);

                if (clientes == null)
                    return StatusCode(404, new { mensagem = "Cliente não encontrado" });

                clientesRepository.Delete(clientes);

                return StatusCode(200,
                   new
                   {
                       mensagem = "Cliente excluído com sucesso.",
                       clientes = _mapper.Map<ClientesGetModel>(clientes)
                   });
            }
            catch (Exception e)
            {
                return StatusCode(500,
                    new { mensagem = "Falha ao atualizar cliente :(" });
            }
            

        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ClientesGetModel>), 200)]
        public IActionResult GetAll(){
            try
            {
                var clientesRepository = new ClientesRepository();
                var clientes = clientesRepository.GetAll();

                return StatusCode(200, _mapper.Map<List<ClientesGetModel>>(clientes));
            }
            catch (Exception e) 
            {
                return StatusCode(500,new { mensagem = "Erro ao consultar Clientes:( " + e.Message});

            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(List<ClientesGetModel>), 200)]
        public IActionResult GetById(Guid? id) {
            try
            {
                var clientesRepository = new ClientesRepository();
                var clientes = clientesRepository.GetById(id);
                if (clientes == null)
                    return StatusCode(404,
                        new {mensagem = "Cliente não encontrado." });
                else 
                    return StatusCode(200,_mapper.Map<ClientesGetModel>(clientes));
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mennsagem = "Erro ao oobter cliente:("+e.Message });
            }
        }
    }
}
