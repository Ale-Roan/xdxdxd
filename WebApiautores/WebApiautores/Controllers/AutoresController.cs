using Microsoft.AspNetCore.Mvc;
using WebApiautores.Entities;

namespace WebApiautores.Controllers
{
    [ApiController]
    [Route("api/v1/autores")]
    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>()
            {
                new Autor(){ Id = 1, Name ="Juan Perez"},
                 new Autor(){ Id = 2, Name ="Maria Mejia"}
            };
        }
    }
}
