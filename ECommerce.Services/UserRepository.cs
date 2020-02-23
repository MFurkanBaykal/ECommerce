using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Services
{
    public class UserRepository : Repository<Data.Entities.User>, Data.Interfaces.IUserRepository 
    {
        private readonly Data.Contexts.DataContext _dataContext;
        public UserRepository(Data.Contexts.DataContext dataContext) : base(dataContext)
        {

        }
    }
}
