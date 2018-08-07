using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsEye.Domain.Models
{
    public class JobWorkNotes
    {
        public int JobsId { get; set; }
        public Jobs Jobs { get; set; }
        public int WorkNotesId { get; set; }
        public WorkNotes WorkNotes { get; set; }
    }
}