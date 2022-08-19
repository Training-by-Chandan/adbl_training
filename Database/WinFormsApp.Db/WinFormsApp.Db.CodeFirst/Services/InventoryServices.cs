using WinFormsApp.Db.CodeFirst.Models;

namespace WinFormsApp.Db.CodeFirst.Services
{
    public class InventoryServices : BaseServices
    {
        public List<Inventory> GetAll()
        {
            return db.Inventories.ToList();
        }

        public List<Inventory> GetFilteredByText(string text)
        {
            return db.Inventories.Where(p => p.Code.Contains(text) || p.Name.Contains(text)).ToList();
        }

        //(bool, string) => tuples
        public (bool, string) Create(Inventory inventory)
        {
            try
            {
                var existing = db.Inventories.FirstOrDefault(p => p.Code == inventory.Code);
                if (existing == null)
                {
                    db.Inventories.Add(inventory);
                    db.SaveChanges();
                    return (true, "Added Successfully");
                }
                else
                {
                    return (false, "Record with the same code already exists");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}