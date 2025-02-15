using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly AppDbContext _context;

    public PostController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddPost()
    {
        var user = await _context.Users.FirstOrDefaultAsync();
        if (user == null) return NotFound("No users found.");

        var post = new Post
        {
            Content = "This is my first post!",
            PostTypeId = 1,
            UserId = user.UserId
        };

        _context.Posts.Add(post);
        await _context.SaveChangesAsync();
        return Ok("Post added successfully!");
    }
}
