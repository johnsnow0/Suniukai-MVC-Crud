using System.ComponentModel.DataAnnotations;

namespace Suniukai_MVC_Paskaita.Models
{
    public class Preke
    {
        [Key]
        public string Id { get; set; }
        public string? Pavadinimas { get; set; }
        public string? Nuotrauka { get; set; }
        public string? Aprasymas { get; set; }
        public double Kaina { get; set; } = 0;
    }
}
