using System;

namespace ComplaintApp.Models
{
    public class ComplaintModel
    {
        public long ID { get; set; }
        public string Complaint { get; set; }
        public DateTime ComplaintDate { get; set; }
        public string Status { get; set; }

    }
    public enum CompaintStatus
    {
        Open = 0,
        Resolved = 1
    }
}