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
    public partial class empControl : Form {
        string employeeUsername;
       
        redundantData.empInfo empUpdateInfo = new redundantData.empInfo("");
       
        public empControl() {
            InitializeComponent();
            gridFill();
        }
        public empControl(string id) {
            InitializeComponent();
            gridFill();

            employeeUsername = id;
        }
        private void gridFill() {
            bool isFired = false;

            DateTime fireDate = default(DateTime);

            redundantData.con.Open();

            string sqlQuery = "SELECT * FROM employee WHERE employee_designation = 'salesman' ORDER BY employee_designation";

            SqlCommand sqlCmd = new SqlCommand(sqlQuery, redundantData.con);

            SqlDataAdapter sqlAdpater = new SqlDataAdapter(sqlCmd);

            DataSet sqlSet = new DataSet();

            sqlAdpater.Fill(sqlSet);

            empGrid.Rows.Clear();

            for (int i = 0; i < (sqlSet.Tables[0].Rows.Count); i++) {
                string id = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[0]);
                string name = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[1]);
                string pin = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[2]);
                string contact = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[3]);
                string address = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[4]);
                string email = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[5]);
                string designation = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[6]);
                string hire = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[7]);
                string fire = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[8]);
                string status = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[9]);
                string sales = Convert.ToString(sqlSet.Tables[0].Rows[i].ItemArray[10]);

                DateTime hireDate = (Convert.ToDateTime(hire)).Date;

                if (fire == string.Empty) {
                    isFired = false;
                    fire = "---";
                }
                else {
                    isFired = true;
                    fireDate = (Convert.ToDateTime(fire)).Date;
                }

                DataGridViewRow pushData = new DataGridViewRow();

                pushData.CreateCells(empGrid);

                pushData.Cells[0].Value = id;
                pushData.Cells[1].Value = name;
                pushData.Cells[2].Value = pin;
                pushData.Cells[3].Value = contact;
                pushData.Cells[4].Value = address;
                pushData.Cells[5].Value = email;
                pushData.Cells[6].Value = hireDate;

                if (isFired) {
                    pushData.Cells[7].Value = fireDate;
                }
                else {
                    pushData.Cells[7].Value = fire;
                }

                pushData.Cells[8].Value = status;
                pushData.Cells[9].Value = sales;

                empGrid.Rows.Add(pushData);
            }

            redundantData.con.Close();
        }
        private void fireEmp() {
            if (empUpdateInfo.status == "Fired") {
                CustomMsgBox.Show("The selected employee is already fired.\nPlease select valid employee.", "OK");
            }
            else {
                if (empUpdateInfo.id == "") {
                    CustomMsgBox.Show("Please select the employee, that you want to fire.", "OK");
                }
                else {
                    redundantData.con.Open();

                    string sqlQuery = "UPDATE employee SET EMPLOYEE_Status = 'Fired', Employee_FIREDATE = CONVERT(DATE, GETDATE()) WHERE EMPLOYEE_ID = @username";

                    SqlCommand sqlCmd = new SqlCommand(sqlQuery, redundantData.con);

                    sqlCmd.Parameters.AddWithValue("@username", empUpdateInfo.id);
                    sqlCmd.ExecuteNonQuery();

                    redundantData.con.Close();

                    gridFill();
                }
            }
        }
        private void rehireEmp() {
            if (empUpdateInfo.status == "Working") {
                CustomMsgBox.Show("The selected employee is already Working.\nPlease select valid employee.", "OK");
            }
            else {
                if (empUpdateInfo.id == "") {
                    CustomMsgBox.Show("Please select the employee, that you want to hire.", "OK");
                }
                else {
                    redundantData.con.Open();

                    string sqlQuery = "UPDATE employee SET EMPLOYEE_Status = 'Working', Employee_HIREDATE = CONVERT(DATE, GETDATE()), Employee_firedate = NULL, Employee_Sales = 0 WHERE EMPLOYEE_ID = @username";
                    
                    SqlCommand sqlCmd = new SqlCommand(sqlQuery, redundantData.con);

                    sqlCmd.Parameters.AddWithValue("@username", empUpdateInfo.id);
                    sqlCmd.ExecuteNonQuery();

                    redundantData.con.Close();

                    gridFill();
                }
            }
        }
        private void backBtn_MouseEnter(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void backBtn_MouseLeave(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e) {
            new Manager_Menu(employeeUsername).Show();

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
        private void exitBtn_MouseClick(object sender, MouseEventArgs e) {
            Application.Exit();
        }
        private void hireEmpPanel_MouseEnter(object sender, EventArgs e) {
            hireEmpPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void hireEmpPanel_MouseLeave(object sender, EventArgs e) {
            hireEmpPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void hireEmpPanel_MouseClick(object sender, MouseEventArgs e) {
            new SaleManCtrl(employeeUsername).Show();

            this.Hide();
        }
        private void updateEmpPanel_MouseEnter(object sender, EventArgs e) {
            updateEmpPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void updateEmpPanel_MouseLeave(object sender, EventArgs e) {
            updateEmpPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void updateEmpPanel_MouseClick(object sender, MouseEventArgs e) {
            new SaleManCtrl(empUpdateInfo, employeeUsername).Show();

            this.Hide();
        }
        private void fireEmpPanel_MouseEnter(object sender, EventArgs e) {
            fireEmpPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void fireEmpPanel_MouseLeave(object sender, EventArgs e) {
            fireEmpPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void fireEmpPanel_MouseClick(object sender, MouseEventArgs e) {
            fireEmp();
        }
        private void rehireEmpPanel_MouseEnter(object sender, EventArgs e) {
            rehireEmpPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void rehireEmpPanel_MouseLeave(object sender, EventArgs e) {
            rehireEmpPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void rehireEmpPanel_MouseClick(object sender, MouseEventArgs e) {
            rehireEmp();
        }
        private void empGrid_CellEnter(object sender, DataGridViewCellEventArgs e) {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = empGrid.Rows[rowIndex];

            empUpdateInfo.name = Convert.ToString(row.Cells[1].Value);
            empUpdateInfo.pin = Convert.ToString(row.Cells[2].Value);
            empUpdateInfo.contact = Convert.ToString(row.Cells[3].Value);
            empUpdateInfo.address = Convert.ToString(row.Cells[4].Value);
            empUpdateInfo.email = Convert.ToString(row.Cells[5].Value);
            empUpdateInfo.id = Convert.ToString(row.Cells[0].Value);
            empUpdateInfo.status = Convert.ToString(row.Cells[8].Value);
        }
    }
}
