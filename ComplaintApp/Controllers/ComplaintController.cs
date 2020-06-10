using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplaintApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ComplaintApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintController : ControllerBase
    {
        private IComplaintService _db;
        private readonly ILogger<ComplaintController> _logger;
        public ComplaintController(IComplaintService db, ILogger<ComplaintController> logger) { _db = db; _logger = logger; }
        
        // GET: api/Complaint/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<ComplaintModel> Get(int id)
        {
            _logger.LogInformation("Request for Complaint id {0}", id);

            var complaintItem = _db.GetComplaint(id);
            if (complaintItem == null)
            {
                _logger.LogError("Complaint Not Found for id {0}", id);
                return NotFound();
            }

            _logger.LogInformation("Complaint id {0} request completed", id);
            return complaintItem;
        }

        // POST: api/Complaint
        [HttpPost]
        public ActionResult<ComplaintModel> Post([FromBody] ComplaintModel complaintItem)
        {
            _logger.LogInformation("Request to log new Complaint received");

            _db.CreateComplaint(complaintItem);

            _logger.LogInformation("Complaint successfully logged with ID {0}", complaintItem.ID);
            return complaintItem;
        }

    }
}
