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
    public partial class Form10 : Form {
        string userID,OrderID,isPurch;

        public Form10(string id) {
            InitializeComponent();
            gridFill();
            cashCollector();

            userID = id;
        }

        private void gridFill() {
            redundantData.con.Open();

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Account", redundantData.con);

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);

            DataSet sqlData = new DataSet();

            sqlAdapter.Fill(sqlData);

            viewCarGrid.Rows.Clear();

            for (int i = 0; i < (sqlData.Tables[0].Rows.Count); i++) {
                string manufOrder = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[0]);
                string custOrder = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[1]);
                string Amount = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[2]);
                string isPayment = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[3]);
                string payDate = Convert.ToString(sqlData.Tables[0].Rows[i].ItemArray[4]);

                DataGridViewRow pushData = new DataGridViewRow();

                pushData.CreateCells(viewCarGrid);

                if (manufOrder.Count() < 1) {
                    pushData.Cells[0].Value = custOrder;
                    pushData.Cells[3].Value = "Sale";
                }
                else {
                    pushData.Cells[0].Value = manufOrder;
                    pushData.Cells[3].Value = "Purchase";
                }

                pushData.Cells[1].Value = Amount;
                pushData.Cells[2].Value = Convert.ToDateTime(payDate).Date;
                
                viewCarGrid.Rows.Add(pushData);
            }

            redundantData.con.Close();
        }

        void checkSale() {
            redundantData.con.Open();

            SqlCommand sqlCmd2 = new SqlCommand("SELECT * FROM Account WHERE IS_PAID = 'FALSE'", redundantData.con);

            SqlDataAdapter sqlAdapter2 = new SqlDataAdapter(sqlCmd2);

            DataSet sqlData2 = new DataSet();

            sqlAdapter2.Fill(sqlData2);

            viewCarGrid.Rows.Clear();

            for (int i = 0; i < (sqlData2.Tables[0].Rows.Count); i++) {
                string custOrder = Convert.ToString(sqlData2.Tables[0].Rows[i].ItemArray[1]);
                string Amount = Convert.ToString(sqlData2.Tables[0].Rows[i].ItemArray[2]);
                string isPayment = Convert.ToString(sqlData2.Tables[0].Rows[i].ItemArray[3]);
                string payDate = Convert.ToString(sqlData2.Tables[0].Rows[i].ItemArray[4]);

                DataGridViewRow pushData = new DataGridViewRow();

                pushData.CreateCells(viewCarGrid);

                pushData.Cells[0].Value = custOrder;
                pushData.Cells[1].Value = Amount;
                pushData.Cells[2].Value = Convert.ToDateTime(payDate).Date;
                pushData.Cells[3].Value = "Sale";

                viewCarGrid.Rows.Add(pushData);
            }

            redundantData.con.Close();
        }
        void checkPurch() {
            redundantData.con.Open();

            SqlCommand sqlCmd3 = new SqlCommand("SELECT * FROM Account WHERE IS_PAID = 'TRUE'", redundantData.con);

            SqlDataAdapter sqlAdapter3 = new SqlDataAdapter(sqlCmd3);

            DataSet sqlData3 = new DataSet();

            sqlAdapter3.Fill(sqlData3);

            viewCarGrid.Rows.Clear();

            for (int i = 0; i < (sqlData3.Tables[0].Rows.Count); i++) {
                string manfOrder = Convert.ToString(sqlData3.Tables[0].Rows[i].ItemArray[0]);
                string Amount = Convert.ToString(sqlData3.Tables[0].Rows[i].ItemArray[2]);
                string isPayment = Convert.ToString(sqlData3.Tables[0].Rows[i].ItemArray[3]);
                string payDate = Convert.ToString(sqlData3.Tables[0].Rows[i].ItemArray[4]);

                DataGridViewRow pushData = new DataGridViewRow();

                pushData.CreateCells(viewCarGrid);

                pushData.Cells[0].Value = manfOrder;
                pushData.Cells[1].Value = Amount;
                pushData.Cells[2].Value = Convert.ToDateTime(payDate).Date;
                pushData.Cells[3].Value = "Purchase";

                viewCarGrid.Rows.Add(pushData);
            }

            redundantData.con.Close();
        }
        private void cashCollector() {
            redundantData.con.Open();

            SqlCommand sqlCmd4 = new SqlCommand("SELECT SUM(Account.Amount) FROM Account WHERE Account.IS_PAID = 'FALSE' ", redundantData.con);

            SqlDataAdapter sqlAdapter4 = new SqlDataAdapter(sqlCmd4);

            DataSet sqlData4 = new DataSet();

            sqlAdapter4.Fill(sqlData4);

            string amountRecieved = Convert.ToString(sqlData4.Tables[0].Rows[0].ItemArray[0]);

            SqlCommand sqlCmd5 = new SqlCommand("SELECT SUM(Account.Amount) FROM Account WHERE Account.IS_PAID = 'TRUE' ", redundantData.con);

            SqlDataAdapter sqlAdapter5 = new SqlDataAdapter(sqlCmd5);

            DataSet sqlData5 = new DataSet();

            sqlAdapter5.Fill(sqlData5);

            string amountSpent = Convert.ToString(sqlData5.Tables[0].Rows[0].ItemArray[0]);

            SqlCommand sqlCmd6 = new SqlCommand("SELECT (SELECT SUM(ACCOUNT.AMOUNT) FROM ACCOUNT WHERE ACCOUNT.IS_PAID = 'FALSE') - (SELECT SUM(ACCOUNT.AMOUNT) FROM ACCOUNT WHERE ACCOUNT.IS_PAID = 'TRUE')", redundantData.con);
            
            SqlDataAdapter sqlAdapter6 = new SqlDataAdapter(sqlCmd6);

            DataSet sqlData6 = new DataSet();

            sqlAdapter6.Fill(sqlData6);

            string amountNet = Convert.ToString(sqlData6.Tables[0].Rows[0].ItemArray[0]);

            redundantData.con.Close();

            amountRecLbl.Text = amountRecieved;
            amountSpentLbl.Text = amountSpent;
            netAmountLbl.Text = amountNet;
        }

        private void backBtn_MouseEnter(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void backBtn_MouseLeave(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e) {
            new Manager_Menu(userID).Show();

            this.Hide();
        }
        private void exitBtn_MouseEnter(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#ff0000");
            exitBtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#ffffff");
            exitBtn.ForeColor = ColorTranslator.FromHtml("#ff0000");
        }
        private void exitBtn_MouseClick(object sender, EventArgs e) {
            Application.Exit();
        }
        private void sellCarPanel_MouseEnter(object sender, EventArgs e) {
            sellCarPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void sellCarPanel_MouseLeave(object sender, EventArgs e) {
            sellCarPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e) {
            checkSale();
        }
        private void buyCarPanel_MouseEnter(object sender, EventArgs e) {
            buyCarPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void buyCarPanel_MouseLeave(object sender, EventArgs e) {
            buyCarPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e) {
            checkPurch();
        }
        private void panel4_MouseEnter(object sender, EventArgs e) {
            panel4.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void panel4_MouseLeave(object sender, EventArgs e) {
            panel4.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void panel4_MouseClick(object sender, MouseEventArgs e) {
            gridFill();
        }
        private void viewCarGrid_CellEnter(object sender, DataGridViewCellEventArgs e) {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = viewCarGrid.Rows[rowIndex];

            OrderID = Convert.ToString(row.Cells[0].Value);
            isPurch = Convert.ToString(row.Cells[3].Value);
        }
        private void viewCarGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            bool isPurchase;

            if (isPurch == "Sale") {
                isPurchase = false;
            }
            else {
                isPurchase = true;
            }

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
