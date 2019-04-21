using Surf.Core;
using Surf.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Surf.Services.Users
{
    public partial interface IUserService
    {
        IPagedList<User> Search(int pageIndex = 0, int pageSize = 15);

        User GetById(int id);

        void Delete(User entity);
        void Insert(User entity);
        void Update(User entity);
    }
}
