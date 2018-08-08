using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsEye.Domain.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public string JobUserId { get; set; }
        public string CreatedDate { get; set; }
        public string DueDate { get; set; }
        public string Location { get; set; }
        public List<Inventory> Inventory { get; set; }
        public List<JobToUser> JobToUser { get; set; }
        public List<JobNotes> JobNotes { get; set; }
    }
}
