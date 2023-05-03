using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string? Image { get; set; }
        public double Price { get; set; }

        public Pizza()
        {

        }
        public Pizza(string nome, string descrizione, string image, double price)
        {
            Nome = nome;
            Descrizione = descrizione;
            Image = image;
            Price = price;
        }
    }
}
