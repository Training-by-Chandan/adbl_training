using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp.Db.CodeFirst.Models
{
    [Table("InventoryInfo")]
    public class Inventory
    {
        public int Id { get; set; }

        [Column("CodeName")]
        public string Code { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public Units Units { get; set; }
    }

    public enum Units
    {
        Pieces = 0,
        KG = 1,
        Pounds = 2,
        Dozen = 3,
        Score = 4,
        Quintal = 5,
        Ton = 6
    }
}