using System.ComponentModel.DataAnnotations;

namespace Mission6_ajames26.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public uint Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        [MaxLength(5)]
        public string Rating { get; set; }
        public bool Edited { get; set; } = false;
        public string? LentTo { get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
