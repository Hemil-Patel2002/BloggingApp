using Microsoft.Extensions.Hosting;

public class Blog
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public int BlogTypeId { get; set; }
    public BlogType BlogType { get; set; }
    public List<Post> Posts { get; set; } = new List<Post>();
}
