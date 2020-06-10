using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintApp.Models
{
    public interface IComplaintService
    {
        ComplaintModel CreateComplaint(ComplaintModel complaint);
        ComplaintModel GetComplaint(long id);
    }
}
