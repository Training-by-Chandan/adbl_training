using WinFormsApp.Db.CodeFirst.Data;

namespace WinFormsApp.Db.CodeFirst.Services
{
    public abstract class BaseServices
    {
        protected DefaultContext db = new DefaultContext();
    }
}