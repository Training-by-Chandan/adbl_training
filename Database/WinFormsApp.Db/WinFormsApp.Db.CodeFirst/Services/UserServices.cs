using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Db.CodeFirst.Services
{
    public class UserServices : BaseServices
    {
        public (bool, string, int) Login(string username, string password)
        {
            try
            {
                //check if the user exists or not
                var existing = db.UserInfos.FirstOrDefault(p => p.Username == username);
                //if user doesnot exists : return user not found
                if (existing == null)
                {
                    return (false, "User not found", 1);
                }
                else
                {
                    if (existing.Password == password)
                    {
                        return (true, "login successful", 0);
                    }
                    else
                    {
                        return (false, "password did not match", 2);
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message, -1);
            }
        }
    }
}