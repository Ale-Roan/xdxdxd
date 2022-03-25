

using Examen_Unidad_2.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Examen_Unidad_2.Controllers
{
    [ApiController]
    [Route("api/v1/works")]
   public class WorksCT : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public WorksCT(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult<Work>> GetOne(int id)
        {
            return await context.Works.FirstOrDefaultAsync(l => l.Id== id);

        }

        [HttpPost]

        public async Task<ActionResult<Work>> Post(Work work)
        {
            var workexist=await context.Works.AnyAsync(a=> a.Id==work.UserId);
            if (!workexist)
            {
                return BadRequest($"User Do not exist:{ work.UserId}.");

            }

            context.Add(work);
            await context.SaveChangesAsync();
            return Ok();
        }
        






    }
    
}
