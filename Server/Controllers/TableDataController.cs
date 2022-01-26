using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UITable3.Shared;
using System.Drawing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UITable.Server.Controllers
{
    [Route("[controller]")]
    public class TableDataController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<TableData> Get()
        {
            int amount = 10;
            RandomFeatures Rf = new RandomFeatures();
            List<TableData> data = new List<TableData>(); 
            for (int i = 0; i < amount; i++)
            {
                var row = new TableData();
                row.ActivityName = string.Concat(Rf.RandomFirstName(), Rf.RandomLastName());
                row.ActivityDescription = Rf.RandomFirstName();
                row.ActivityContext = Rf.RandomLastName();
                row.Status = ((ActivityStatus)Rf.RandomNumber(Enum.GetNames(typeof(ActivityStatus)).Length)).ToString();
                row.ServiceUserId = Guid.NewGuid();
                row.CreatedDate = DateTime.Today.AddDays(-1*Rf.RandomNumber(14));
                row.DueDate = DateTime.Today.AddDays(Rf.RandomNumber(14));
                row.Priority = ((PriorityStates)Rf.RandomNumber(Enum.GetNames(typeof(PriorityStates)).Length)).ToString();
                row.Photo = (Rf.RandomNumber(8) + 1).ToString() + ".jpeg";
                data.Add(row);
            }
            return data.ToArray();
        }

        // GET api/imagepath
        /*[HttpGet("{imagePath}")]
        public byte[] Get(string imagePath)
        {
            RandomFeatures Rf = new RandomFeatures();
            return Image.FromFile((Rf.RandomNumber(8) + 1).ToString() + ".jpeg");
        }*/

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

