using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class02.ProjectInterfaces
{
    public interface IModerator
    {
        void BanUser(User user, string reason);

    }
}
