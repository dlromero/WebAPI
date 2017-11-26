using LocalAccountsApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocalAccountsApp.Controllers
{
    [Authorize]
    [RoutePrefix("api/Hope")]
    public class HopeController : ApiController
    {
        // GET: api/Hope
        public IHttpActionResult Get()
        {
            //List<cOrders> lsOrder = new List<cOrders>();            
            //for (int i = 0; i < 5; i++)
            //{
            //    cOrders objOrder = new cOrders();
            //    objOrder.iIdentifier = i;
            //    objOrder.iOrderNumber = i;
            //    objOrder.sOrderDescription = "Desc" + i;
            //    lsOrder.Add(objOrder);
            //}
            //return new string[] { "value1", "value2" };


            DataTable dt = new DataTable();
            dt.Columns.Add("col1");
            dt.Columns.Add("col2");
            DataRow row = dt.NewRow();
            row["col1"] = "Col1";
            row["col2"] = "Col2";
            dt.Rows.Add(row);
            DataSet dsData = new DataSet();
            dsData.Tables.Add(dt);

            return Ok(dsData);

        }

        // GET: api/Hope/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Hope
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Hope/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Hope/5
        public void Delete(int id)
        {
        }
    }
}
