using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Actor {
    [Key]
    public int Id { get; set;}
    public string? ProfilePicUrl { get; set; }
    public string? FullName { get; set; }
    public string? Biography { get; set; }
    public List<Actor_Movie>? Actor_Movie { get; set; }
}