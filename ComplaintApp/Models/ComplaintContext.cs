using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintApp.Models
{
    public class ComplaintContext
    {
		public ComplaintModel CreateComplaint(ComplaintModel complaint)
		{
			//_dbContext.Complaints.Add(complaint);
			//_dbContext.SaveChanges();
			return complaint;
		}
		public ComplaintModel GetComplaint(long Id)
		{
			//var complaint = _dbContext.Complaints.Find(Id);
			var complaint = new ComplaintModel { ID = Id, Complaint = "I am having trouble logging into the system", ComplaintDate = new DateTime(2020, 05, 09), Status = CompaintStatus.Open.ToString() };
			return complaint;
		}
	}
}
