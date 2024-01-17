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
    public partial class SMMenu : Form {
        string empId = "";
        string CarID = "";
        string C_Status = "";

        public SMMenu() {
            InitializeComponent();
            gridFill();

            this.CenterToScreen();
        }
        public SMMenu(string id) {
            InitializeComponent();
            gridFill();

            this.CenterToScreen();
            
            empId = id;
        }

        private void gridFill() {
            redundantData.con.Open();

            string sqlQuery = "SELECT * FROM CAR";

            SqlCommand sqlCmd = new SqlCommand(sqlQuery, redundantData.con);

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);

            DataSet sqlSet = new DataSet();

            sqlAdapter.Fill(sqlSet);

            viewCarGrid.Rows.Clear();

            for ( int i = 0; i < (sqlSet.Tables[0].Rows.Count); i++ ) {
                string ID = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[3]);
                string Status = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[4]);
                string Price = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[5]);

                DataGridViewRow pushData = new DataGridViewRow();

                pushData.CreateCells(viewCarGrid);

                pushData.Cells[0].Value = Name;
                pushData.Cells[1].Value = Model;
                pushData.Cells[2].Value = Company;
                pushData.Cells[3].Value = Price;
                pushData.Cells[4].Value = Status;
                pushData.Cells[5].Value = ID;

                viewCarGrid.Rows.Add(pushData);
            }

            redundantData.con.Close();
        }
        private void viewCarGrid_CellEnter(object sender, DataGridViewCellEventArgs e) {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = viewCarGrid.Rows[rowIndex];

            string id = Convert.ToString(row.Cells[5].Value);
            string status = Convert.ToString(row.Cells[4].Value);
            CarID = id;
            C_Status = status;
        }
        private void backBtn_MouseEnter(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void backBtn_MouseLeave(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e) {
            if ((empId[0].ToString() + empId[1].ToString()).ToUpper() == "MG") {
                new Manager_Menu(empId).Show();

                this.Hide();
            }
            else {
                new LogInForm().Show();

                this.Hide();
            }
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
        private void carSell() {
            string id, status;

            id = CarID;
            status = C_Status;

            if (status == "") {
                CustomMsgBox.Show("No cars remaining.\nContact higher authority.", "OK");
            }
            else if (status.ToLower() == "available") {
                new CarSell(empId, CarID).Show();

                this.Hide();
            }
            else if (status.ToLower() == "sold") {
                CustomMsgBox.Show("This car has already been sold.\nSelect another one.", "OK");
            }
        }
        private void sellCarPanel_MouseEnter(object sender, EventArgs e) {
            sellCarPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void sellCarPanel_MouseLeave(object sender, EventArgs e) {
            sellCarPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e) {
            carSell();
        }
        private void buyCar() {
            redundantData.con.Open();

            string sqlQuery4 = "SELECT employee_designation FROM employee WHERE employee_id = @id";

            SqlCommand sqlCmd4 = new SqlCommand(sqlQuery4, redundantData.con);

            sqlCmd4.Parameters.AddWithValue("@id", empId);

            SqlDataAdapter sqlAdapter4 = new SqlDataAdapter(sqlCmd4);

            DataSet sqlSet4 = new DataSet();

            sqlAdapter4.Fill(sqlSet4);

            string empDesig = Convert.ToString(sqlSet4.Tables[0].Rows[0].ItemArray[0]);

            redundantData.con.Close();

            if (empDesig.ToLower() == "manager") {
                new carCtrl(empId).Show();

                this.Hide();
            }
            else if (empDesig.ToLower() == "salesman") {
                CustomMsgBox.Show("You do not have Administrator Privilages.\nFor addition of new stock inform higher authority.","OK");
            }
        }
        private void buyCarPanel_MouseEnter(object sender, EventArgs e) {
            buyCarPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void buyCarPanel_MouseLeave(object sender, EventArgs e) {
            buyCarPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e) {
            buyCar();
        }
        private void viewSold() {
            redundantData.con.Open();

            string sqlQuery3 = "SELECT * FROM CAR WHERE car_status = 'Sold'";

            SqlCommand sqlCmd3 = new SqlCommand(sqlQuery3, redundantData.con);

            SqlDataAdapter sqlAdapter3 = new SqlDataAdapter(sqlCmd3);

            DataSet sqlSet3 = new DataSet();

            sqlAdapter3.Fill(sqlSet3);

            viewCarGrid.Rows.Clear();

            for (int i = 0; i < (sqlSet3.Tables[0].Rows.Count); i++) {
                string ID = Convert.ToString(sqlSet3.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(sqlSet3.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(sqlSet3.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(sqlSet3.Tables[0].Rows[i].ItemArray[3]);
                string Status = Convert.ToString(sqlSet3.Tables[0].Rows[i].ItemArray[4]);
                string Price = Convert.ToString(sqlSet3.Tables[0].Rows[i].ItemArray[5]);

                DataGridViewRow pushData = new DataGridViewRow();

                pushData.CreateCells(viewCarGrid);

                pushData.Cells[0].Value = Name;
                pushData.Cells[1].Value = Model;
                pushData.Cells[2].Value = Company;
                pushData.Cells[3].Value = Price;
                pushData.Cells[4].Value = Status;
                pushData.Cells[5].Value = ID;

                viewCarGrid.Rows.Add(pushData);
            }

            redundantData.con.Close();
        }
        private void viewSoldPanel_MouseEnter(object sender, EventArgs e) {
            viewSoldPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void viewSoldPanel_MouseLeave(object sender, EventArgs e) {
            viewSoldPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void viewSoldPanel_MouseClick(object sender, MouseEventArgs e) {
            viewSold();
        }
        private void viewAvailable() {
            redundantData.con.Open();

            string sqlQuery2 = "SELECT * FROM CAR WHERE car_status = 'Available'";

            SqlCommand sqlCmd2 = new SqlCommand(sqlQuery2, redundantData.con);

            SqlDataAdapter sqlAdapter2 = new SqlDataAdapter(sqlCmd2);

            DataSet sqlSet2 = new DataSet();

            sqlAdapter2.Fill(sqlSet2);

            viewCarGrid.Rows.Clear();

            for (int i = 0; i < (sqlSet2.Tables[0].Rows.Count); i++) {
                string ID = Convert.ToString(sqlSet2.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(sqlSet2.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(sqlSet2.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(sqlSet2.Tables[0].Rows[i].ItemArray[3]);
                string Status = Convert.ToString(sqlSet2.Tables[0].Rows[i].ItemArray[4]);
                string Price = Convert.ToString(sqlSet2.Tables[0].Rows[i].ItemArray[5]);

                DataGridViewRow pushData = new DataGridViewRow();

                pushData.CreateCells(viewCarGrid);

                pushData.Cells[0].Value = Name;
                pushData.Cells[1].Value = Model;
                pushData.Cells[2].Value = Company;
                pushData.Cells[3].Value = Price;
                pushData.Cells[4].Value = Status;
                pushData.Cells[5].Value = ID;

                viewCarGrid.Rows.Add(pushData);
            }

            redundantData.con.Close();
        }
        private void viewAvailPanel_MouseEnter(object sender, EventArgs e) {
            viewAvailPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void viewAvailPanel_MouseLeave(object sender, EventArgs e) {
            viewAvailPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void viewAvailPanel_MouseClick(object sender, MouseEventArgs e) {
            viewAvailable();
        }
    }
}
