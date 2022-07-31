using System.ComponentModel.DataAnnotations;

namespace VNotes.Models;

public class Note 
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
}