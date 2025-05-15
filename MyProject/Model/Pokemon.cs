using System.ComponentModel.DataAnnotations;

namespace MyProject.Model
{
    public class Pokemon
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [Range(1, 800, ErrorMessage = "Total must be between 1-800")]
        public int Total { get; set; }

        [Required]
        [Range(1, 255, ErrorMessage = "HP must be between 1-255")]
        public int HP { get; set; }

        [Required]
        [Range(1, 255, ErrorMessage = "Attack must be between 1-255")]
        public int Attack { get; set; }

        [Required]
        [Range(1, 255, ErrorMessage = "Defence must be between 1-255")]
        public int Defence { get; set; }
    }
}

