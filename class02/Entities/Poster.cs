using class02.ProjectInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class02.Entities
{
    class Poster : User, IPoster

    {

        public int Points { get; set; }




        public Poster(string username) : base()
        {
            Username = username;
            Comments = new List<string>();
            Role = Role.Poster;
        }

        public void CheckStatus()
        {
            Console.WriteLine($"{Username} has {Points} points and {Comments.Count} comments");
        }

        public void IsPosterOfTheWeek()
        {
            Console.WriteLine($"The user {Username} is Poster of the week");
            Points++;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"{Username}  has a role of {Role}");
        }
    }
}
