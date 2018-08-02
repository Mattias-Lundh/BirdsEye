using System;
using BirdsEye.Domain.Models;

namespace BirdsEye.Data
{
    public class DatabaseAccess
    {
        public void AddUser(User user)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
