namespace PostService.Entities;

public class Post
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    // Foreign key
    public Guid UserId { get; set; }
    // Navigation property
    public required User User { get; set; }
}
