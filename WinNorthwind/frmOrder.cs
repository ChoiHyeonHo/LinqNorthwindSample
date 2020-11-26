using NorthwindVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinNorthwind.Services;
using WinNorthwind.Utils;

namespace WinNorthwind
{
    public partial class frmOrder : Form
    {
        List<ProductInfoVO> prodAllList = null; //전체 제품목록을 전역으로 놓고 null 초기값.
        List<OrderDetailVO> cartList = null; //장바구니 목록을 전역으로 놓고 null 초기값
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            //코드 데이터들을 조회해서 콤보박스 바인딩
            string[] gubun = { "Customer", "Employee", "Category", "Shipper" };

            CommonService service = new CommonService();
            List<ComboItemVO> allList = service.GetCodeInfoByCodeTypes(gubun);

            #region 주문 신규등록 탭
            CommonUtil.ComboBinding(cboCustomer, allList, "Customer", true, "선택");
            CommonUtil.ComboBinding(cboEmployee, allList, "Employee");
            CommonUtil.ComboBinding(cboCategory, allList, "Category");

            //배송희망일(납기희망일) 7일 후 
            dtpRequired.Value = DateTime.Now.AddDays(7);

            //장바구니 데이터 그리드뷰 항목을 세팅
            CommonUtil.SetInitGridView(dgvCart);
            CommonUtil.AddGridTextColumn(dgvCart, "카테고리", "CategoryName", 150);
            CommonUtil.AddGridTextColumn(dgvCart, "제품ID", "ProductID", visibility: false);
            CommonUtil.AddGridTextColumn(dgvCart, "제품명", "ProductName", 360);
            CommonUtil.AddGridTextColumn(dgvCart, "제품단가", "UnitPrice");
            CommonUtil.AddGridTextColumn(dgvCart, "주문수량", "Quantity");
            #endregion

            #region 주문 조회 관리 탭
            CommonUtil.ComboBinding(cboCustomer2, allList, "Customer");
            CommonUtil.ComboBinding(cboEmployee2, allList, "Employee");
            CommonUtil.ComboBinding(cboShipper, allList, "Shipper");

            //주문일자 검색조건 
            dtpFrom.Value = DateTime.Now.AddDays(-3);
            dtpTo.Value = DateTime.Now;

            //주문목록, 주문 상세 목록 데이터그리드뷰의 항목을 세팅
            CommonUtil.SetInitGridView(dgvOrder);
            CommonUtil.AddGridTextColumn(dgvOrder, "주문ID", "OrderID");
            CommonUtil.AddGridTextColumn(dgvOrder, "거래처명", "CompanyName", 200);
            CommonUtil.AddGridTextColumn(dgvOrder, "직원명", "EmployeeName", 200);
            CommonUtil.AddGridTextColumn(dgvOrder, "주문일", "OrderDate");
            CommonUtil.AddGridTextColumn(dgvOrder, "요청일", "RequiredDate");
            CommonUtil.AddGridTextColumn(dgvOrder, "배송일", "ShippedDate");
            CommonUtil.AddGridTextColumn(dgvOrder, "업체명", "ShipCompanyName", 150);
            CommonUtil.AddGridTextColumn(dgvOrder, "배송료", "Freight");

            CommonUtil.SetInitGridView(dgvOrderDetail);
            CommonUtil.AddGridTextColumn(dgvOrderDetail, "카테고리", "CategoryName");
            CommonUtil.AddGridTextColumn(dgvOrderDetail, "제품명", "ProductName", 250);
            CommonUtil.AddGridTextColumn(dgvOrderDetail, "제품단가", "UnitPrice");
            CommonUtil.AddGridTextColumn(dgvOrderDetail, "주문수량", "Quantity");
            #endregion
        }

        #region 주문 신규등록 탭
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //이 콤보박스를 수정한다는 것은 목록을 보겠다는 의사가 있는것으로 간주하여 이 때 DB를 갔다온다.

            //카테고리를 실제 선택했을때만 아래의 코드 실행(데이터 바인딩으로 인한 이벤트는 무시)
            if (cboCategory.SelectedIndex < 1) return;

            //제품 전체목록이 없는 경우 제품 정보를 조회
            if (prodAllList == null)
            {
                OrderService service = new OrderService();
                prodAllList = service.GetProductAllList();
            }
            //제품 전체 목록에서 선택된 카테고리에 해당하는 제품만 콤보바인딩
            List<ComboItemVO> list =
                (from product in prodAllList
                 where product.CategoryID == Convert.ToInt32(cboCategory.SelectedValue.ToString())
                 select new ComboItemVO
                 {
                     Code = product.ProductID.ToString(),
                     CodeName = product.ProductName,
                     Gubun = "Product"
                 }).ToList();
            CommonUtil.ComboBinding(cboProduct, list, "Product");
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProduct.SelectedIndex > 0)
            {
                //선택된 제품 ID를 전체 제품 목록에서 찾아서 제품 정보를 컨트롤에 바인딩
                int proId = Convert.ToInt32(cboProduct.SelectedValue);
                List<ProductInfoVO> selProdList = (from prod in prodAllList where prod.ProductID == proId select prod).ToList();
                if (selProdList.Count > 0)
                {
                    txtQuantityPerUnit.Text = selProdList[0].QuantityPerUnit;
                    txtUnitPrice.Text = selProdList[0].UnitPrice.ToString();
                    nuQuantity.Value = selProdList[0].UnitsOnOrder;
                    nuQuantity.Increment = (selProdList[0].UnitsOnOrder > 0) ? selProdList[0].UnitsOnOrder : 1;
                }
            }
            else
            {
                txtQuantityPerUnit.Text = txtUnitPrice.Text = "";
                nuQuantity.Value = 0;
            }
        }

        private void btnCartAdd_Click(object sender, EventArgs e)
        {
            //유효성 검사 (제품 선택을 하지 않았거나 주문수량이 0인경우)
            if (cartList == null)
            {
                cartList = new List<OrderDetailVO>();
            }
            if(cboProduct.SelectedIndex  < 1 || nuQuantity.Value < 1)
            {
                MessageBox.Show("장바구니에 추가할 제품을 선택하여 주십시오.");
                return;
            }
            //1. 선택된 제품으로 OrderDetailVO 객체를 만들어서 cartList에 추가

            //2. 이미 장바구니에 추가가 된 경우=> 리스트에서 그 제품을 찾아 수량을 증가
            int proID = Convert.ToInt32(cboProduct.SelectedValue);
            int idx = cartList.FindIndex(p => p.ProductID == proID); // 찾으면 0이상, 못찾으면 -1 리턴

            if (idx > -1)
            {
                cartList[idx].Quantity += (int)nuQuantity.Value;
            }
            else
            {
                //3. 장바구니에 없는 경우 => 리스트에 새로운 VO를 추가
                OrderDetailVO newItem = new OrderDetailVO();
                newItem.CategoryName = cboCategory.Text;
                newItem.ProductID = Convert.ToInt32(cboProduct.SelectedValue);
                newItem.ProductName = cboProduct.Text;
                newItem.Quantity = (int)nuQuantity.Value;
                newItem.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                cartList.Add(newItem);
                cboCategory.SelectedItem = cboProduct.SelectedItem = null;
            }
            dgvCart.DataSource = null;
            dgvCart.DataSource = cartList; //내부 데이터는 바뀌는데 바인딩이 바로 바뀌진 않는다. 그렇기 때문에 초기 null 할당.
            dgvCart.ClearSelection();

            cboProduct.SelectedIndex = 0;
        }

        private void btnCartDel_Click(object sender, EventArgs e)
        {
            //유효성
            if (dgvCart.SelectedRows.Count < 1)
            {
                MessageBox.Show("장바구니에서 삭제할 제품을 선택하여 주십시오.");
                return;
            }
            //그리드뷰에서 선택된 제품을 장바구니에서 찾아 List에서 삭제하고
            int proID = Convert.ToInt32(dgvCart.SelectedRows[0].Cells[1].Value);
            int idx = cartList.FindIndex(p => p.ProductID == proID); // 찾으면 0이상, 못찾으면 -1 리턴

            if (idx > -1)
            {
                cartList.RemoveAt(idx);
                dgvCart.DataSource = null;
                dgvCart.DataSource = cartList; //내부 데이터는 바뀌는데 바인딩이 바로 바뀌진 않는다. 그렇기 때문에 초기 null 할당.
            }

            //다시 List를 DataGridView에 바인딩
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //유효성 체크
            if (dgvCart.Rows.Count < 1)
            {
                MessageBox.Show("주문할 제품을 선택하여 주십시오");
                return;
            }
            if (cboCustomer.SelectedIndex < 1 || cboEmployee.SelectedIndex < 1)
            {
                MessageBox.Show("주문 정보를 선택하여 주십시오");
                return;
            }
            //Order에 추가, Identity값 조회해서 OrderDetails에 여러 건 추가 (1:多, Master:Detail 관계)
            try
            {
                OrderVO order = new OrderVO()
                {
                    CustomerID = cboCustomer.SelectedValue.ToString(),
                    EmployeeID = Convert.ToInt32(cboEmployee.SelectedValue),
                    RequiredDate = dtpRequired.Value.ToShortDateString()
                };
                OrderService service = new OrderService();
                bool bResult = service.RegisterOrder(order, cartList);
                if (bResult)
                {
                    cartList.Clear();
                    dgvCart.DataSource = null;

                    MessageBox.Show("주문이 완료되었습니다");
                }
                else
                    MessageBox.Show("주문 처리중 오류가 발생했습니다.\n다시 시도하여 주십시오");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dtFrom = dtpFrom.Value.ToShortDateString();
            string dtTo = dtpTo.Value.ToShortDateString();

            OrderService service = new OrderService();
            service.
        }
    }
}