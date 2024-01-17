using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project {
    public partial class Form8 : Form {
        string OrderID,userID;
        bool isPurchase;

        public Form8(string empID) {
            InitializeComponent();
            purchGridFill();

            userID = empID;
        }
        
        private void purchGridFill() {
            viewCarGrid.Columns[3].Visible = true;
            viewCarGrid.Columns[4].Visible = false;
            isPurchase = true;

            redundantData.con.Open();

            string sqlQuery = "SELECT STOCK_PAYMENT.ORDER_ID, CAR.CAR_NAME,EMPLOYEE.EMPLOYEE_NAME,MANUFACTURER.MANUFACTURER_NAME,MANUF_ORDER.BILL, STOCK_PAYMENT.PAYMENT_DATE FROM STOCK_PAYMENT JOIN MANUF_ORDER ON STOCK_PAYMENT.ORDER_ID = MANUF_ORDER.ORDER_ID JOIN CAR ON MANUF_ORDER.CAR_ID = CAR.CAR_ID JOIN EMPLOYEE ON MANUF_ORDER.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID JOIN MANUFACTURER ON MANUF_ORDER.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID";
            
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, redundantData.con);
            
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
            
            DataSet sqlData = new DataSet();
            
            sqlAdapter.Fill(sqlData);

            viewCarGrid.Rows.Clear();

            for (int i = 0; i < (sqlData.Tables[0].Rows.Count); i++) {
                string PaymentID = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[0]);
                string CarName = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[1]);
                string EmployeeName = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[2]);
                string ManufacturerName = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[3]);
                string Bill = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[4]);
                string Date = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[5]);

                DateTime newDate = Convert.ToDateTime(Date).Date;

                DataGridViewRow pushData = new DataGridViewRow();

                pushData.CreateCells(viewCarGrid);

                pushData.Cells[0].Value = PaymentID;
                pushData.Cells[1].Value = CarName;
                pushData.Cells[2].Value = EmployeeName;
                pushData.Cells[3].Value = ManufacturerName;
                pushData.Cells[5].Value = Bill;
                pushData.Cells[6].Value = newDate;

                viewCarGrid.Rows.Add(pushData);
            }
            
            redundantData.con.Close();
        }

        private void salesGridFill() {
            viewCarGrid.Columns[3].Visible = false;
            viewCarGrid.Columns[4].Visible = true ;
            isPurchase = false;

            redundantData.con.Open();

            string sqlQuery2 = "SELECT SELL_PAYMENT.ORDER_ID, CAR.CAR_NAME, EMPLOYEE.EMPLOYEE_NAME, CUSTOMER.CUSTOMER_NAME,CUSTOMER_ORDER.BILL, SELL_PAYMENT.PAYMENT_DATE FROM SELL_PAYMENT JOIN CUSTOMER_ORDER ON SELL_PAYMENT.ORDER_ID = CUSTOMER_ORDER.ORDER_ID JOIN CAR ON CUSTOMER_ORDER.CAR_ID = CAR.CAR_ID JOIN EMPLOYEE ON CUSTOMER_ORDER.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID JOIN CUSTOMER ON CUSTOMER_ORDER.CUSTOMER_CNIC = CUSTOMER.CUSTOMER_CNIC";
            
            SqlCommand sqlCmd2 = new SqlCommand(sqlQuery2, redundantData.con);
            
            SqlDataAdapter sqlAdapter2 = new SqlDataAdapter(sqlCmd2);
            
            DataSet sqlData = new DataSet();
            
            sqlAdapter2.Fill(sqlData);

            viewCarGrid.Rows.Clear();

            for (int i = 0; i < (sqlData.Tables[0].Rows.Count); i++) {
                string PaymentID = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[0]);
                string CarName = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[1]);
                string EmployeeName = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[2]);
                string CustomerName = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[3]);
                string Bill = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[4]);
                string Date = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[5]);

                DateTime newDate = Convert.ToDateTime(Date).Date;

                DataGridViewRow pushData = new DataGridViewRow();

                pushData.CreateCells(viewCarGrid);

                pushData.Cells[0].Value = PaymentID;
                pushData.Cells[1].Value = CarName;
                pushData.Cells[2].Value = EmployeeName;
                pushData.Cells[4].Value = CustomerName;
                pushData.Cells[5].Value = Bill;
                pushData.Cells[6].Value = newDate;

                viewCarGrid.Rows.Add(pushData);
            }

            redundantData.con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
        private void backBtn_MouseEnter(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void backBtn_MouseLeave(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e) {
            this.Hide();

            new Manager_Menu(userID).Show();
        }
        private void exitBtn_MouseEnter(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#ff0000");
            exitBtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#ffffff");
            exitBtn.ForeColor = ColorTranslator.FromHtml("#ff0000");
        }
        private void exitBtn_MouseClick(object sender, MouseEventArgs e) {
            Application.Exit();
        }
        private void sellCarPanel_MouseEnter(object sender, EventArgs e) {
            sellCarPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void sellCarPanel_MouseLeave(object sender, EventArgs e) {
            sellCarPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e) {
            salesGridFill();

            viewCarGrid.Refresh();
        }
        private void buyCarPanel_MouseEnter(object sender, EventArgs e) {
            buyCarPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void buyCarPanel_MouseLeave(object sender, EventArgs e) {
            buyCarPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e) {
            purchGridFill();

            viewCarGrid.Refresh();
        }
        private void viewCarGrid_CellEnter(object sender, DataGridViewCellEventArgs e) {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = viewCarGrid.Rows[rowIndex];

            OrderID = Convert.ToString(row.Cells[0].Value);
        }
        private void viewCarGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Form formBackground = new Form();

            try {
                using (Form9 uu = new Form9(OrderID, isPurchase, userID, false)) {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Normal;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                    formBackground.Hide();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                formBackground.Dispose();
                formBackground.Hide();
            }
        }
    }
}
