using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API;

[ApiController]
[Route("api/[controller]")]//apiusers
public class UsersController(DataContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users= await context.User.ToListAsync();

        return users;

    }

    [HttpGet("{id:int}")] //api /users/2

    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
       var user=await context.User.FindAsync(id);

       if(user==null) return NotFound();

       return user;
    }
 
}
