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
    public partial class SaleManCtrl : Form {
        string mainEmpID;
        bool isUpdateData,isNewData = false;
        bool nameChange, contactChange, pinChange, addressChange, emailChange = false;
        bool nameFlag, pinFlag, addressFlag, contactFlag ,emailFlag;

        redundantData.empInfo updateEmp;
       
        public SaleManCtrl() {
            InitializeComponent();
        }
        public SaleManCtrl(string id) {
            InitializeComponent();
            pictureVanish();
            startChecker();

            isNewData = true;
            mainEmpID = id;
            hireBtn.Location = new Point(383, 384);
            updateBtn.Enabled = updateBtn.Visible = false;
        }
        public SaleManCtrl(redundantData.empInfo emp, string empID) {
            InitializeComponent();
            pictureVanish();

            updateBtn.Location = new Point(383, 384);
            hireBtn.Enabled =  hireBtn.Visible = false;
            isUpdateData = true;
            mainEmpID = empID;
            updateEmp = emp;
            nameBox.Text = emp.name;
            pinBox.Text = emp.pin;
            addressBox.Text = emp.address;
            contactBox.Text = emp.contact;
            emailBox.Text = emp.email;
        }

        private void startChecker() {
            if (nameBox.Text == "") {
                nameFlag = true;
            }
            if (pinBox.Text == "") {
                pinFlag = true;
            }
            if (addressBox.Text == "") {
                addressFlag = false;
            }
            if (contactBox.Text == "") {
                contactFlag = false;
            }
            if (emailBox.Text == "") {
                emailFlag = false;
            }
        }
        private void pictureVanish() {
            nameBoxErrorIcon.Visible = false;
            pinBoxErrorIcon.Visible = false;
            addressBoxErrorIcon.Visible = false;
            contactBoxErrorIcon.Visible = false;
            emailBoxErrorIcon.Visible = false;
        }
        private void backBtn_MouseEnter(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void backBtn_MouseLeave(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e) {
            new empControl(mainEmpID).Show();
            this.Hide();
        }
        private void exitBtn_MouseEnter(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#ff0000");
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void nameBox_Enter(object sender, EventArgs e) {
            nameBoxErrorIcon.Visible = false;
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.BackColor = ColorTranslator.FromHtml("#333333");
            nameBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void nameBox_Leave(object sender, EventArgs e) {
            if (nameBox.Text == "") {
                nameBoxErrorIcon.Visible = true;
                nameFlag = true;
            }
            else {
                nameBoxErrorIcon.Visible = false;
                nameFlag = false;
            }

            nameBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            nameBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void nameBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each field.", "OK");

                e.Handled = true;
            }
        }
        private void nameBox_TextChanged(object sender, EventArgs e) {
            if (updateEmp.name != nameBox.Text) {
                nameChange = true;
            }
        }
        private void pinBox_Enter(object sender, EventArgs e) {
            pinBoxErrorIcon.Visible = false;
            pinBox.BorderStyle = BorderStyle.None;
            nameBox.BackColor = ColorTranslator.FromHtml("#333333");
            nameBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void pinBox_Leave(object sender, EventArgs e) {
            if (pinBox.Text == "") {
                pinBoxErrorIcon.Visible = true;
                pinFlag = true;
            }
            else {
                pinBoxErrorIcon.Visible = false;
                pinFlag = false;
            }

            nameBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            nameBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void pinBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each field.", "OK");

                e.Handled = true;
            }
        }
        private void pinBox_TextChanged(object sender, EventArgs e) {
            if (updateEmp.pin != pinBox.Text) {
                pinChange = true;
            }
        }
        private void contactBox_Enter(object sender, EventArgs e) {
            contactBoxErrorIcon.Visible = false;
            contactBox.BorderStyle = BorderStyle.None;
            nameBox.BackColor = ColorTranslator.FromHtml("#333333");
            nameBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void contactBox_Leave(object sender, EventArgs e) {
            if ((contactBox.Text.Length != 0) && ((contactBox.Text.Length) != 9)) {
                contactBoxErrorIcon.Visible = true;
                contactFlag = true;
            }
            else if ((contactBox.Text.Length == 0) || (contactBox.Text.Length == 9)) {
                contactBoxErrorIcon.Visible = false;
                contactFlag = false;
            }

            nameBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            nameBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void contactBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each field.", "OK");

                e.Handled = true;
            }
        }
        private void contactBox_TextChanged(object sender, EventArgs e) {
            if (updateEmp.contact != contactBox.Text) {
                contactChange = true;
            }
        }
        private void addressBox_Enter(object sender, EventArgs e) {
            addressBoxErrorIcon.Visible = false;
            addressBox.BorderStyle = BorderStyle.None;
            addressBox.BackColor = ColorTranslator.FromHtml("#333333");
            addressBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void addressBox_Leave(object sender, EventArgs e) {
            addressBoxErrorIcon.Visible = false;
            addressFlag = false;

            addressBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            addressBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void addressBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == '/') || (e.KeyChar == '-') || char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each field.", "OK");

                e.Handled = true;
            }
        }
        private void addressBox_TextChanged(object sender, EventArgs e) {
            if (updateEmp.address != addressBox.Text) {
                addressChange = true;
            }
        }
        private void emailBox_Enter(object sender, EventArgs e) {
            emailBoxErrorIcon.Visible = false;
            emailBox.BorderStyle = BorderStyle.None;
            emailBox.BackColor = ColorTranslator.FromHtml("#333333");
            emailBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void emailBox_Leave(object sender, EventArgs e) {
            emailBoxErrorIcon.Visible = false;
            emailFlag = false;

            emailBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            emailBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void emailBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == '@') || (e.KeyChar == '.')) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each field.", "OK");

                e.Handled = true;
            }
        }
        private void emailBox_TextChanged(object sender, EventArgs e) {
            if (updateEmp.email != emailBox.Text) {
                emailChange = true;
            }
        }
        private void hireBtn_MouseEnter(object sender, EventArgs e) {
            hireBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void hireBtn_MouseLeave(object sender, EventArgs e) {
            hireBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void hireBtn_MouseClick_1(object sender, MouseEventArgs e) {
            if (isNewData) {
                string name = nameBox.Text;
                string pin = pinBox.Text;
                string contact = contactBox.Text;
                string address = addressBox.Text;
                string email = emailBox.Text;

                if ((nameFlag || contactFlag || pinFlag || addressFlag || emailFlag) == true) {
                    if (nameFlag) {
                        nameBoxErrorIcon.Visible = true;
                    }
                    if (pinFlag) {
                        pinBoxErrorIcon.Visible = true;
                    }
                    if (addressFlag) {
                        addressBoxErrorIcon.Visible = true;
                    }
                    if (contactFlag) {
                        contactBoxErrorIcon.Visible = true;
                    }
                    if (emailFlag) {
                        emailBoxErrorIcon.Visible = true;
                    }

                    CustomMsgBox.Show("The given input is invalid.\nPlease enter correct information and fill fields to required information.", "OK");
                }
                else {
                    redundantData.con.Open();

                    string sqlQuery = "SELECT * FROM employee WHERE employee_email = @email";

                    SqlCommand sqlCmd = new SqlCommand(sqlQuery, redundantData.con);

                    sqlCmd.Parameters.AddWithValue("@email", email);

                    SqlDataAdapter mEmailCheckAdapter = new SqlDataAdapter(sqlCmd);
                    DataSet sqlSet = new DataSet();

                    mEmailCheckAdapter.Fill(sqlSet);

                    redundantData.con.Close();

                    if (sqlSet.Tables[0].Rows.Count == 0) {
                        redundantData.con.Open();

                        string sqlQuery2 = "SELECT MAX(substring(employee.employee_ID,3,len(EMPLOYEE.EMPLOYEE_ID))) FROM employee WHERE EMPLOYEE_DESIGNATION = 'Salesman' ";

                        SqlCommand sqlCmd2 = new SqlCommand(sqlQuery2, redundantData.con);
                        SqlDataAdapter empIdAdapter = new SqlDataAdapter(sqlCmd2);
                        DataSet sqlSet2 = new DataSet();

                        empIdAdapter.Fill(sqlSet2);

                        string id;

                        if ((sqlSet2.Tables[0].Rows.Count) > 0) {
                            id = Convert.ToString(sqlSet2.Tables[0].Rows[0].ItemArray[0]);
                        }
                        else {
                            id = string.Empty;
                        }

                        string newEmpID = idGenerator(id);
                        string sqlQuery3 = "INSERT INTO EMPLOYEE(EMPLOYEE_ID,EMPLOYEE_NAME,EMPLOYEE_PASSWORD,EMPLOYEE_CONTACT,EMPLOYEE_ADDRESS,EMPLOYEE_EMAIL,EMPLOYEE_DESIGNATION,EMPLOYEE_HIREDATE,EMPLOYEE_STATUS,EMPLOYEE_SALES) VALUES(@id,@name,@password,@contact,@address,@email,'Salesman',(CONVERT(DATE, GETDATE())),'Working',0)";

                        SqlCommand sqlCmd3 = new SqlCommand(sqlQuery3, redundantData.con);

                        sqlCmd3.Parameters.AddWithValue("@id", newEmpID);
                        sqlCmd3.Parameters.AddWithValue("@name", name);
                        sqlCmd3.Parameters.AddWithValue("@contact", contact);
                        sqlCmd3.Parameters.AddWithValue("@address", address);
                        sqlCmd3.Parameters.AddWithValue("@email", email);
                        sqlCmd3.Parameters.AddWithValue("@password", pin);
                        sqlCmd3.ExecuteNonQuery();

                        redundantData.con.Close();

                        CustomSuccessBox.Show("New employee has been added.");

                        nameBox.Text = contactBox.Text = pinBox.Text = addressBox.Text = contactBox.Text = emailBox.Text = "";
                    }
                    else {
                        CustomMsgBox.Show("The given email is invalid.\nPlease recheck it", "OK");

                        emailBoxErrorIcon.Visible = true;
                    }
                }
            }
        }
        private void updateBtn_MouseEnter(object sender, EventArgs e) {
            updateBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void updateBtn_MouseLeave(object sender, EventArgs e) {
            updateBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void updateBtn_MouseClick(object sender, MouseEventArgs e) {
            if (isUpdateData) {
                if (nameChange || pinChange || addressChange || contactChange || emailChange) {
                    string name = nameBox.Text;
                    string pin = pinBox.Text;
                    string contact = contactBox.Text;
                    string address = addressBox.Text;
                    string email = emailBox.Text;
                    string employeeId = updateEmp.id;

                    redundantData.con.Open();

                    string sqlQuery = "SELECT * FROM employee WHERE employee_email = @email AND employee_id <> @id";

                    SqlCommand sqlCmd = new SqlCommand(sqlQuery, redundantData.con);

                    sqlCmd.Parameters.AddWithValue("@email", email);
                    sqlCmd.Parameters.AddWithValue("@id", employeeId);

                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                    DataSet sqlSet = new DataSet();

                    sqlAdapter.Fill(sqlSet);

                    redundantData.con.Close();

                    if (sqlSet.Tables[0].Rows.Count == 0) {

                        redundantData.con.Open();

                        string sqlQuery2 = "UPDATE employee SET EMPLOYEE_Name = @newName, EMPLOYEE_Password = @newPin, EMPLOYEE_Contact = @newContact, EMPLOYEE_Address = @newAddress, EMPLOYEE_Email = @newEmail WHERE EMPLOYEE_ID = @updateId";

                        SqlCommand sqlCmd2 = new SqlCommand(sqlQuery2, redundantData.con);

                        sqlCmd2.Parameters.AddWithValue("@newName", name);
                        sqlCmd2.Parameters.AddWithValue("@newPin", pin);
                        sqlCmd2.Parameters.AddWithValue("@newContact", contact);
                        sqlCmd2.Parameters.AddWithValue("@newAddress", address);
                        sqlCmd2.Parameters.AddWithValue("@newEmail", email);
                        sqlCmd2.Parameters.AddWithValue("@updateId", employeeId);
                        sqlCmd2.ExecuteNonQuery();

                        redundantData.con.Close();

                        CustomSuccessBox.Show("Employee data has been updated.");

                        nameBox.Text = contactBox.Text = pinBox.Text = addressBox.Text = contactBox.Text = emailBox.Text = "";
                    }
                    else {
                        CustomMsgBox.Show("The given email is invalid.\nPlease recheck it", "OK");

                        emailBoxErrorIcon.Visible = true;
                    }
                }
                else {
                    CustomMsgBox.Show("You haven't changed any data.", "OK");
                }
            }
        }

        private string idGenerator(string id) {
            string digits, letters;

            letters = "SM";

            if (id == string.Empty) {
                digits = "000";
            }
            else {
                digits = new string(id.Where(char.IsDigit).ToArray());
            }

            int number;
            int.TryParse(digits, out number);
            string new_id = letters + (++number).ToString("D3");

            return new_id;
        }
    }
}
