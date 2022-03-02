using System.ComponentModel.DataAnnotations;

namespace SongApi.Models;

public class Song {
    // Properties
    public int Id { set; get; }

    [Required]
    public string? Artist { set; get; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Length { get; set; }
    [Required]
    public string? Category { get; set; }
}