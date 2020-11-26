using NorthwindVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NorthwindDAC
{
    public class OrderDAC : ConnectionAccess
    {
        private string strConn;
        SqlConnection conn;
        public OrderDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        
        public List<ProductInfoVO> GetProductAllList()
        {
            string sql = @"select ProductID, ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsOnOrder from Products";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductInfoVO> list = Helper.DataReaderMapToList<ProductInfoVO>(reader);

                conn.Close();
                return list;
            }
        }

        /// <summary>
        /// 검색조건에 따른 주문 정보 조회
        /// </summary>
        /// <param name="custID">거래처ID</param>
        /// <param name="empID">담당직원ID</param>
        /// <param name="dtFrom">주문일자 Form</param>
        /// <param name="dtTo">주문일자 To</param>
        /// <returns>주문정보 목록</returns>
        public List<OrderVO> GetOrderSearchList(int custID, int empID, string dtFrom, string dtTo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 신규 주문 등록
        /// </summary>
        /// <param name="order">주문정보</param>
        /// <param name="ordDatails">주문상세내역</param>
        /// <returns>주문등록 성공여부</returns>
        public bool RegisterOrder(OrderVO order, List<OrderDetailVO> ordDatails)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlTransaction trans = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = trans;
                
                try
                {
                    //Order 테이블에 1건 Insert
                    cmd.CommandText = @"insert into Orders (CustomerID, EmployeeID, OrderDate, RequiredDate) 
                                                            values (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate); 
                                                            select @@IDENTITY";
                    
                    cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                    cmd.Parameters.AddWithValue("@EmployeeID", order.EmployeeID);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);

                    int orderID = Convert.ToInt32(cmd.ExecuteScalar());

                    //OrderDatail에 여러 건 Insert

                    cmd.CommandText = @"insert into [dbo].[Order Details] (OrderID, ProductID, UnitPrice, Quantity) 
                                                            values (@OrderID, @ProductID, @UnitPrice, @Quantity)";
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.Parameters.Add("@ProductID", SqlDbType.Int);
                    cmd.Parameters.Add("@UnitPrice", SqlDbType.Money);
                    cmd.Parameters.Add("@Quantity", SqlDbType.SmallInt);

                    foreach (OrderDetailVO detail in ordDatails)
                    {
                        cmd.Parameters["@ProductID"].Value = detail.ProductID;
                        cmd.Parameters["@UnitPrice"].Value = detail.UnitPrice;
                        cmd.Parameters["@Quantity"].Value = detail.Quantity;

                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    conn.Close();
                    return true;
                }
                catch (Exception err)
                {
                    string msg = err.Message;
                    trans.Rollback();
                    conn.Close();
                    return false;
                }
            }
        }
    }
}
