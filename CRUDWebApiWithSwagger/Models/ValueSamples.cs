using System.ComponentModel.DataAnnotations;

namespace WebApiWithSwagger.Models
{
    public class ValueSamples
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}