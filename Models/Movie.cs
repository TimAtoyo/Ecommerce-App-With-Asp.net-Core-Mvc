using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public double Price { get; set; }
    public string? Genre { get; set; }
     
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public List<Cinema>? CinemaName { get; set; }
    public List<Actor>? MovieActors { get; set; }

    public List<Actor_Movie>? Actor_Movie { get; set; }
    public Producer? Producer { get; set; }
    public Cinema? Cinema { get; set; }
    [ForeignKey("CinemaId")]
    public int CinemaId { get; set; }


}