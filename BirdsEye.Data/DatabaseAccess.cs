using System;
using BirdsEye.Domain.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;



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

        public User GetUserByEmailAddress(string emailAddress)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
               return context.Users.Where(u => u.EmailAddress == emailAddress).FirstOrDefault();
            }
        }

        public User GetUserById(int id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Users.Where(u => u.Id == id).FirstOrDefault();
            }
        }

        // Example code: fetch while including link table data.
        /*

        public User GetUserByIdDeleteME(int id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Users
                    .Where(u => u.Id == id)
                    .Include(u => u.JobUsers)
                        .ThenInclude(j => j.Job)
                    .FirstOrDefault();
            }
        }
        */
    }
}
