using Microsoft.AspNetCore.Mvc;
using PersonApi.Net.Services;

namespace UdemyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private ILogger<PersonController> _logger;
        private IPersonService _personService;
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var person = _personService.FindByID(id);
            if (person == null) return NotFound();  
            return Ok();
        }
    }
}