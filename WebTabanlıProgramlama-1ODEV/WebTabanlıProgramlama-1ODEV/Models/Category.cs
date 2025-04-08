using System.ComponentModel.DataAnnotations;

namespace WebTabanlıProgramlama_1ODEV.Models
{
    public class Category
    {
        [Key] // Anahtar olduğunu belirtmek için kullanılır.
        public int Id { get; set; }

        public string Name { get; set; }
    }



}
