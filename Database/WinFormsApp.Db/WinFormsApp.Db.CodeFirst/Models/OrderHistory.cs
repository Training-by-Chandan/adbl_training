using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp.Db.CodeFirst.Models
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int InventoryId { get; set; }
        public double Quantity { get; set; }

        [ForeignKey("InventoryId")]
        public virtual Inventory Inventory { get; set; }
    }
}