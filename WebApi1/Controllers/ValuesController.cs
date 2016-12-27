using System;
using System.Collections.Generic;
using System.Web.Http;
using PersonLib;

namespace WebApi1.Controllers
{
    [ServiceRequestActionFilter]
    public class ValuesController : ApiController
    {
        // GET api/values 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        //public string Get(int id)
        //{
        //    return string.Format("id:{0} ts:{1}", id,
        //          TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Pacific Standard Time"));
        //}

        // GET api/values/5 
        public Person Get(string id)
        {
            Person p = new Person();
            p.name = id;
            p.id = Guid.NewGuid().ToString();
            p.timeStamp = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Pacific Standard Time").ToString();
            return p;
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}
