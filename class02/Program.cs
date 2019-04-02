using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class02.Entities;

namespace class02
{
    class Program
    {
        static void Main(string[] args)
        {
           var guest1 = new Guest(1234,"Vasil");
            guest1.PrintUser();
            guest1.ReadComment("this is comment");
            guest1.PostComment("postcomment");

            var poster1 = new Poster("Nikola");
            poster1.PrintUser();
            poster1.PostComment("comment");
            poster1.IsPosterOfTheWeek();
            poster1.IsPosterOfTheWeek();
            poster1.CheckStatus();

            var moderator1 = new Modertor("Modname");
            moderator1.PrintUser();
            moderator1.AddUser(guest1);
            moderator1.AddUser(poster1);
            moderator1.ShowUsers();

     
            
            Console.ReadLine();
        }
    }
}
