using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using WorldCart.Services.Interfaces;

namespace WorldCart.Services
{
  public class OrderService : IOrderService
  {
    /// <summary>
    /// Gets an order.
    /// </summary>
    /// <param name="orderNumber">An order number.</param>
    /// <returns>An <see cref="Order"/> object.</returns>
    public Order GetOrder(string orderNumber)
    {
      using (var db = new ServiceEntities())
      {
        try
        {
          return db.Orders.Single
            (o => o.order_number == orderNumber);
        }

        catch (InvalidOperationException)
        {
          // The order could not be found
          throw new WebFaultException(HttpStatusCode.NotFound);
        }
      }
    }
  }
}
