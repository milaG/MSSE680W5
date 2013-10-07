using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace ServiceLayer
{
    /// <summary>
    /// Another service layer class, which validates the user login. 
    /// </summary>
    public class ValidateLogin
    {
        public String Message { get; set; }
        public Boolean Result { get; set; }

        // readonly DbContext _dataContext;

        public ValidateLogin(string username, string password)
        {
            //     _dataContext = new DbContext(ConfigurationManager.ConnectionStrings["LibraryEntities"].ConnectionString);

            LibraryEntities Db = new LibraryEntities();

            //var user = Db.Members.SequenceEqual(m=> m.Username == username && m.password == passwrd);

            var user = (from check in Db.Members where check.Username == username && check.Password == password select check).FirstOrDefault();

            if (user != null)
            {
                Result = true;
                Message = "Member login validated.";
            }
            else
            {
                Result = false;
                Message = "Invalid login";
            }

        }

    }
}
