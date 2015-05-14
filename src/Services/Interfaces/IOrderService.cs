using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WorldCart.Services.Interfaces
{
  [ServiceContract]
  public interface IOrderService
  {
    [OperationContract]
    Order GetOrder(string orderNumber);

    // TODO: Add your service operations here
  }
}
