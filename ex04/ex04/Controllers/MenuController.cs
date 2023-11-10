using System.Text.Json;
using System.Threading.Tasks;
using ex04;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Menu.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly ILogger<MenuController> _logger;

        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            var aluno = new Aluno
            {
                Nome = "Eduardo Domenes",
                RU = "3768302"
            };

            return JsonSerializer.Serialize(aluno);

        }
    }
}
