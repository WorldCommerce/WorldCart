using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;

using WorldCart.Services;
using WorldCart.Services.Clients;

namespace WorldCart.Controllers
{
    public class OrdersController : ApiController
    {
        // GET api/orders
        public async Task<IEnumerable<Order>> Get()
        {
            throw new NotImplementedException(/* TODO */);
        }

        // GET api/orders/5
        public async Task<Order> Get(string orderNumber)
        {
            using (var client = new OrderServiceClient())
            {
                return await client.GetOrderAsync(orderNumber);
            }
        }

        // POST api/orders
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException(/* TODO */);
        }

        // PUT api/orders/5
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException(/* TODO */);
        }

        // DELETE api/orders/5
        public void Delete(int id)
        {
            throw new NotImplementedException(/* TODO */);
        }
    }
}
