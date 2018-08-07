using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsEye.Domain.Models
{
    public class JobUser
    {
        public int JobId { get; set; }
        public Job Job { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
