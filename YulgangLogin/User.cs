using System;
using System.Collections.Generic;
using System.Data;

namespace YulgangLogin
{
    public class User
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int Save()
        {
            return User.AddUser(this);
        }

        public int Update()
        {
            return User.EditUser(this);
        }
        public static int AddUser(User user)
        {
            const string query = "INSERT INTO User(Title, Username, Password) VALUES(@Title, @Username, @Password)";

            //here we are setting the parameter values that will be actually 
            //replaced in the query in Execute method
            var args = new Dictionary<string, object>
            {
                {"@Title", user.Title},
                {"@Username", user.Username},
                {"@Password", user.Password}
            };

            return Database.ExecuteWrite(query, args);
        }

        public static int EditUser(User user)
        {
            const string query = "UPDATE User SET Title = @Title, Username = @Username, Password = @Password WHERE Id = @Id";

            //here we are setting the parameter values that will be actually 
            //replaced in the query in Execute method
            var args = new Dictionary<string, object>
            {
                {"@Id", user.Id},
                {"@Title", user.Title},
                {"@Username", user.Username},
                {"@Password", user.Password}
            };

            return Database.ExecuteWrite(query, args);
        }

        public static int DeleteUser(User user)
        {
            const string query = "Delete from User WHERE Id = @id";

            //here we are setting the parameter values that will be actually 
            //replaced in the query in Execute method
            var args = new Dictionary<string, object>
            {
                {"@id", user.Id}
            };

            return Database.ExecuteWrite(query, args);
        }

        public static User GetUserById(int id)
        {
            var query = "SELECT * FROM User WHERE Id = @id";

            var args = new Dictionary<string, object>
            {
                {"@id", id}
            };

            DataTable dt = Database.ExecuteRead(query, args);

            if( dt == null || dt.Rows.Count == 0 )
            {
                return null;
            }

            var user = new User
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                Title = Convert.ToString(dt.Rows[0]["Title"]),
                Username = Convert.ToString(dt.Rows[0]["Username"]),
                Password = Convert.ToString(dt.Rows[0]["Password"])
            };

            return user;
        }

        public static List<User> Lists()
        {
            var query = "SELECT * FROM User";


            DataTable dt = Database.ExecuteRead(query, new Dictionary<string, object>());

            if( dt == null || dt.Rows.Count == 0 )
            {
                return null;
            }

            List<User> users = new List<User>();
            foreach( DataRow r in dt.Rows )
            {
                var user = new User
                {
                    Id = Convert.ToInt32(r["Id"]),
                    Title = Convert.ToString(r["Title"]),
                    Username = Convert.ToString(r["Username"]),
                    Password = Convert.ToString(r["Password"])
                };
                users.Add(user);
            }

            return users;
        }
    }
}