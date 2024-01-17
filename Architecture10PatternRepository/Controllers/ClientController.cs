using Architecture10PatternRepository.Models;
using Architecture10PatternRepository.Models.Requests;
using Architecture10PatternRepository.Services;
using Microsoft.AspNetCore.Mvc;

namespace Architecture10PatternRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpPost("create", Name = "ClientCreate")]
        public ActionResult<int> Create([FromBody] CreateClientRequest createRequest)
        {
            Client client = new Client();
            client.Document = createRequest.Document;
            client.SurName = createRequest.SurName;
            client.FirstName = createRequest.FirstName;
            client.Patronymic = createRequest.Patronymic;
            client.Birthday = createRequest.Birthday;
            return Ok(_clientRepository.Create(client));
        }

        [HttpPut("edit", Name = "ClientUpdate")]
        public ActionResult<int> Update([FromBody] UpdateClientRequest updateRequest)
        {
            Client client = new Client();
            client.ClientId = updateRequest.ClientId;
            client.Document = updateRequest.Document;
            client.SurName = updateRequest.SurName;
            client.FirstName = updateRequest.FirstName;
            client.Patronymic = updateRequest.Patronymic;
            client.Birthday = updateRequest.Birthday;
            return Ok(_clientRepository.Update(client));
        }


        [HttpDelete("delete", Name = "ClientDelete")]
        public ActionResult<int> Delete([FromQuery] int clientId)
        {
            int res = _clientRepository.Delete(clientId);
            return Ok(res);
        }

        [HttpDelete("delete-All", Name = "ClientDeleteAll")]
        public ActionResult<int> DeleteAll()
        {
            int res = _clientRepository.DeleteAll();
            return Ok(res);
        }

        [HttpGet("get-all", Name = "ClientGetAll")]
        public ActionResult<List<Client>> GetAll()
        {
            return Ok(_clientRepository.GetAll());
        }

        [HttpGet("get/{clientId}", Name = "ClientGetById")]
        public ActionResult<Client> GetById([FromRoute] int clientId)
        {
            return Ok(_clientRepository.GetById(clientId));
        }

        [HttpGet("get-bySurName/{surName}", Name = "ClientGetSurName")]
        public ActionResult<List<Client>> GetBySurName([FromRoute] string surName)
        {
            return Ok(_clientRepository.GetBySurName(surName));
        }
    }
}
