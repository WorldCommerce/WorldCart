using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using WorldCart.Data;
using WorldCart.Services.Interfaces;

namespace WorldCart.Services
{
  public class OrderService : IOrderService
  {
    public Order GetOrder(string orderNumber)
    {
      using (var db = new WorldCartEntities())
      {
        return db.Orders.Single(o => o.OrderNumber == orderNumber);
      }
    }
  }
}
