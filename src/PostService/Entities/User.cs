namespace PostService.Entities;

public class User
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public required string LoginId { get; set; }
    public required string Password { get; set; }
    // Navigation property
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}
