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

        public (bool, string) Edit(Inventory inventory)
        {
            try
            {
                var existing = db.Inventories.Find(inventory.Id);
                if (existing == null)
                {
                    return (false, "Record not found");
                }
                existing.Quantity = inventory.Quantity;
                existing.Units = inventory.Units;
                existing.Price = inventory.Price;
                existing.Code = inventory.Code;
                existing.Name = inventory.Name;
                //above can be optimized by using automapper which we will be learning in ASP.NET Core

                db.Inventories.Update(existing);
                db.SaveChanges();

                return (true, "updated sucessful");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(int id)
        {
            try
            {
                var existing = db.Inventories.Find(id);
                if (existing == null)
                {
                    return (false, "Record not found");
                }

                db.Inventories.Remove(existing);
                db.SaveChanges();

                return (true, "deleted sucessful");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}