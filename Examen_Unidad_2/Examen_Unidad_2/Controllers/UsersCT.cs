using Microsoft.AspNetCore.Mvc;
using Examen_Unidad_2.Entities;
using Examen_Unidad_2;
using Microsoft.EntityFrameworkCore;

namespace Examen_Unidad_2.Controllers
{

    [ApiController]
    [Route("api/v1/users")]

    
    public class UsersCT : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public UsersCT(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public async Task<ActionResult< List<User>>> Get([FromHeader] int id, [FromQuery] string name)
        {
            return await context.Users.Include(l =>l.Works).ToListAsync();
        }

       

        [HttpPost]
        public async Task<ActionResult> Post(User user)
        {
            context.Add(user);
            await context.SaveChangesAsync();
            return Ok();
        }

        

        [HttpPut("{id:int}")]

        public async Task<ActionResult> Put(User user, int id)
        {
           if (user.Id != id)
            {
                return BadRequest("El Usuario no existed");

            }

           context.Update(user);
           await context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {
            var exist=await context.Users.AnyAsync(a=> a.Id==id);
            if (!exist)
            {
                return NotFound();
            }
            context.Remove(new User { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }



    }
}
