using System.ComponentModel.DataAnnotations;

namespace GameStoreAPI.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public double Rating { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
