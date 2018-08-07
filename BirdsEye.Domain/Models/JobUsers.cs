using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsEye.Domain.Models
{
    public class JobUsers
    {
        public int JobsId { get; set; }
        public Jobs Jobs { get; set; }
        public int UsersId { get; set; }
        public User User { get; set; }
    }
}
