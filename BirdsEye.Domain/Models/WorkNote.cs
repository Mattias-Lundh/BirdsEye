using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsEye.Domain.Models
{
    public class WorkNote
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Text { get; set; }
    }
}
