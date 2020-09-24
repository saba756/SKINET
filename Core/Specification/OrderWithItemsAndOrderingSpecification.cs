using Core.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Specification
{
   public class OrderWithItemsAndOrderingSpecification : BaseSpecification<Order>
    {
        public OrderWithItemsAndOrderingSpecification(string email): base(o => o.BuyerEmail == email)
        {
            AddInclude(O => O.OrderItems);
            AddInclude(o => o.DeliveryMethod);
            AddOrderByDescending(O => O.OrderDate);
        }
        public OrderWithItemsAndOrderingSpecification(int id, string email) : 
            base(o => o.Id == id && o.BuyerEmail == email)
        {

            AddInclude(O => O.OrderItems);
            AddInclude(o => o.DeliveryMethod);
        }
    }
}
