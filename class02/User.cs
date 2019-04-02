using class02.Entities;
using class02.ProjectInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class02
{
    public abstract class User : IUser
    {
        public string Username { get; set; }
        public Role Role { get; set; }
        public List<string> Comments { get; set; }

        public virtual void PostComment(string comment)
        {
            Console.WriteLine("Comment is added in comment list");
            Comments.Add(comment);
        }

        public abstract void PrintUser();
 
    }
}
