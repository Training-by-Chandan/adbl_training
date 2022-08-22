using WinFormsApp.Db.CodeFirst.Models;
using WinFormsApp.Db.CodeFirst.Models.ViewModels;

namespace WinFormsApp.Db.CodeFirst.Services
{
    public class InventoryServices : BaseServices<Inventory>
    {
        public List<ComboBoxModel> GetItemsForComboBox()
        {
            return db.Inventories.Select(p => new ComboBoxModel { Key = p.Id, Value = p.Name }).ToList();
        }

        public List<Inventory> GetFilteredByText(string text)
        {
            return db.Inventories.Where(p => p.Code.Contains(text) || p.Name.Contains(text)).ToList();
        }

        //(bool, string) => tuples
        public override (bool, string) Create(Inventory inventory)
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