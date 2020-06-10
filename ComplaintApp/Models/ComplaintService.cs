using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintApp.Models
{
    public class ComplaintService : IComplaintService
    {
		private ComplaintContext _context;
		public ComplaintService(ComplaintContext context) => _context = context;
        public ComplaintModel CreateComplaint(ComplaintModel complaint)
        {
            complaint.ID = 6;
            complaint.ComplaintDate = DateTime.Now;
            complaint.Status = CompaintStatus.Open.ToString();
            return _context.CreateComplaint(complaint);
        }

        public ComplaintModel GetComplaint(long id)
        {
			return _context.GetComplaint(id);
        }
    }
}
