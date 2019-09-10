using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class BLLogin
    {

        public BLLogin()
        {

        }

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }


        public UserModel CheckUser(string userName, string password, out int status)
        {
            UserModel User = new UserModel();         

            DALogin da = new DALogin();
            DataTable tableusers = da.CheckUser(userName);
            if (tableusers.Rows.Count == 0)
                status = 1; // Username Wrong

            else
            {                
               if (Base64Encode(password) == tableusers.Rows[0]["UserPassword"].ToString())
               {
                        status = 2;
                        User.UserId = Convert.ToInt32(tableusers.Rows[0]["UserId"]);
                        User.UserName = tableusers.Rows[0]["UserName"].ToString();
                        User.UserPassword = tableusers.Rows[0]["UserPassword"].ToString();
                        User.LastLogin = DateTime.Now;
                        da.UpdateDateTime(User.LastLogin, User.UserId);
                    
               }
                else
                {
                    status = 0; // Password Wrong
                }
                
            }

            return User;
        }
    }
}
