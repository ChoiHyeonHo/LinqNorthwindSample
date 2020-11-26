using NorthwindDAC;
using NorthwindVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinNorthwind.Services
{
    class OrderService
    {
        public List<ProductInfoVO> GetProductAllList()
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetProductAllList();
        }
        public bool RegisterOrder(OrderVO order, List<OrderDetailVO> ordDatail)
        {
            OrderDAC dac = new OrderDAC();
            return dac.RegisterOrder(order, ordDatail);
        }
        public List<OrderVO> GetOrderSearchList(int custID, int empID, string dtFrom, string dtTo)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetOrderSearchList(custID, empID, dtFrom, dtTo);
        }
    }
}
