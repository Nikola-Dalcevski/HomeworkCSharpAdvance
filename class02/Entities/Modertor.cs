using class02.ProjectInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class02.Entities
{
    class Modertor : User, IModerator
    {
        public List<User> Users { get; set; }

       public Modertor (string username) : base()
	{
            Users = new List<User>();
            Comments = new List<string>();
            Username = username;
	}
            

         public override void PrintUser()
        {
            Console.WriteLine($"The user {Username} has role of {Role}" );
        }


        public void BanUser(User user, string reason)
        {

            Console.WriteLine($"The User {Username} is baned beacose {reason}");
        }



      
        public void AddUser(User user) 
        {
            Console.WriteLine("user is added");
            Users.Add(user);
        }

        

        public void ShowUsers()
        {

            Console.WriteLine($"The moderator {Username} have these users in users list");

                foreach (var item in Users)
	            {
                     Console.WriteLine($" - {item.Username} has a row of {item.Role}");
	            }

        }

    }
}
