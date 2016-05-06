using SXBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SXBWebApi.Controllers
{
    public class SYS_USERController : ApiController
    {
        // GET: api/SYS_USER
        public IEnumerable<SYS_USER> Get()
        {
            return users.ToList();
        }

        // GET: api/SYS_USER/5
        public SYS_USER Get(string id = null)
        {
            return users.Where(p => id == null || p.ROW_ID.Equals(id)).FirstOrDefault(); ;
        }

        // POST: api/SYS_USER
        public void Post([FromBody]SYS_USER value)
        {
            users.Add(value);
        }

        // PUT: api/SYS_USER/5
        public void Put(int id, [FromBody]SYS_USER value)
        {
            users.Remove(users.FirstOrDefault(u => value.ROW_ID.Equals(u.ROW_ID)));
            users.Add(value);
        }

        // DELETE: api/SYS_USER/5
        public void Delete(int id)
        {
            users.Remove(users.FirstOrDefault(u => id.Equals(u.ROW_ID)));
        }

        static List<SYS_USER> users = new List<SYS_USER>();
        static SYS_USERController()
        {
            users = new List<SYS_USER>
            {
                new SYS_USER
                {
                    ROW_ID = "1",
                    USERNAME = "张三1",
                    PASSWORD = "123",
                },
                new SYS_USER
                {
                    ROW_ID = "2",
                    USERNAME = "张三2",
                    PASSWORD = "123",
                },
                new SYS_USER
                {
                    ROW_ID = "3",
                    USERNAME = "张三3",
                    PASSWORD = "123",
                },
                new SYS_USER
                {
                    ROW_ID = "4",
                    USERNAME = "张三4",
                    PASSWORD = "123",
                },
                new SYS_USER
                {
                    ROW_ID = "5",
                    USERNAME = "张三5",
                    PASSWORD = "123",
                },
            };
        }

    }
}
