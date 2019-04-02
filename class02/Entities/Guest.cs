using class02.ProjectInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class02.Entities
{
    class Guest : User, IGuest
    {
        public int Id { get; set; }

        public Guest(int id, string username) :base()
        {
            Id = id;
            Role = Role.Guest;
            Username = username;
        }

        public override void PostComment(string comment)
        {
            Console.WriteLine("Guest cannot post comments");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"The user {Username} has role of {Role}" );
        }

        public void ReadComment(string comment)
        {
            Console.WriteLine($"The guest whit id: {Id} read comment: {comment}");
        }
    }
}
