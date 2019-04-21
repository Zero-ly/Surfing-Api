using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Engine;
using Surf.Core;
using Surf.Core.Entities.Users;

namespace Surf.Services.Users
{
    public partial class UserService : IUserService
    {
        #region Fields
        private readonly IRepository<User> _userRepository;
        #endregion

        #region Ctor
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion
        public IPagedList<User> Search(int pageIndex = 0, int pageSize = 15)
        {
            var query = _userRepository.Table;

            query = query.Where(e => !e.Deleted).OrderByDescending(e => e.Id);
            return new PagedList<User>(query, pageIndex, pageSize);
        }

        public User GetById(int id)
        {
            if (id == 0)
                return null;

            return _userRepository.GetById(id);
        }
        public void Delete(User entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            entity.Deleted = true;
            _userRepository.Update(entity);
        }
        public void Insert(User entity)
        {
            if (entity == null)
                throw new ArgumentNullException("user");

            _userRepository.Insert(entity);
        }
        public void Update(User entity)
        {
            if (entity == null)
                throw new ArgumentNullException("user");

            _userRepository.Update(entity);
        }
    }
}
