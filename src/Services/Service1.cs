using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using WorldCart.Data;

namespace WorldCart.Services
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
  public class Service1 : IService1
  {
    public Order GetData(int value)
    {
      using (var db = new CheckoutEntities())
      {
        return new Order { ID = value };
        //return db.WorldCart_Orders.SingleOrDefault(o => o.ID == value);
      }
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
      if (composite == null)
      {
        throw new ArgumentNullException("composite");
      }
      if (composite.BoolValue)
      {
        composite.StringValue += "Suffix";
      }
      return composite;
    }
  }
}
