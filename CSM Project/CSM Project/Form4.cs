using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project {
    public partial class CarSell : Form {
        string empId,carID;
        bool nameFlag, PESELNumberFlag, phoneNumberFlag;

        public CarSell() {
            InitializeComponent();

            this.CenterToScreen();
        }
        public CarSell(string id) {
            InitializeComponent();

            empId = id;

            this.CenterToScreen();
        }
        public CarSell(string id,string carid) {
            InitializeComponent();

            empId = id;
            carID = carid;

            pictureVanish();
            startChecker();
        }

        private void pictureVanish() {
            nameBoxErrorIcon.Visible = false;
            PESELNumberErrorIcon.Visible = false;
            addressBoxErrorIcon.Visible = false;
            phoneNumberBoxErrorIcon.Visible = false;
        }
        private void startChecker() {
            if (nameBox.Text == "") {
                nameFlag = true;
            }
            if (PESELNumberBox.Text == "") {
                PESELNumberFlag = true;
            }
            if (contactBox.Text == "") {
                phoneNumberFlag = true;
            }
        }
        private void backBtn_MouseEnter(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void backBtn_MouseLeave(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e) {
            new SMMenu(empId).Show();

            this.Hide();
        }
        private void exitBtn_MouseEnter(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#ff0000");
            exitBtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#333333");
            exitBtn.ForeColor = ColorTranslator.FromHtml("#ff0000");
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

            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            nameBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void nameBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void addressBox_Enter(object sender, EventArgs e) {
            addressBoxErrorIcon.Visible = false;
            addressBox.BorderStyle = BorderStyle.None;
            addressBox.BackColor = ColorTranslator.FromHtml("#333333");
            addressBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void addressBox_Leave(object sender, EventArgs e) {
            addressBox.BorderStyle = BorderStyle.FixedSingle;
            addressBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            addressBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void addressBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == '/') || (e.KeyChar == '-') || char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void PESELNumberBox_Enter(object sender, EventArgs e) {
            PESELNumberErrorIcon.Visible = false;
            PESELNumberBox.BorderStyle = BorderStyle.None;
            PESELNumberBox.BackColor = ColorTranslator.FromHtml("#333333");
            PESELNumberBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void PESELNumberBox_Leave(object sender, EventArgs e) {
            if ((PESELNumberBox.Text == "") || (PESELNumberBox.Text.Length != 11)) {
                PESELNumberErrorIcon.Visible = true;
                PESELNumberFlag = true;
            }
            else if (PESELNumberBox.Text.Length == 11) {
                PESELNumberErrorIcon.Visible = false;
                PESELNumberFlag = false;
            }

            PESELNumberBox.BorderStyle = BorderStyle.FixedSingle;
            PESELNumberBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            PESELNumberBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void PESELNumberBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void contactBox_Enter(object sender, EventArgs e) {
            phoneNumberBoxErrorIcon.Visible = false;
            contactBox.BorderStyle = BorderStyle.None;
            contactBox.BackColor = ColorTranslator.FromHtml("#333333");
            contactBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void contactBox_Leave(object sender, EventArgs e) {
            if ((contactBox.Text == "") || ((contactBox.Text.Length) != 9)) {
                phoneNumberBoxErrorIcon.Visible = true;
                phoneNumberFlag = true;
            }
            else if (contactBox.Text.Length == 9) {
                phoneNumberBoxErrorIcon.Visible = false;
                phoneNumberFlag = false;
            }

            contactBox.BorderStyle = BorderStyle.FixedSingle;
            contactBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            contactBox.ForeColor = ColorTranslator.FromHtml("#333333");
        }
        private void contactBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void sellBtn_MouseEnter(object sender, EventArgs e) {
            sellBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void sellBtn_MouseLeave(object sender, EventArgs e) {
            sellBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void sellBtn_MouseClick(object sender, MouseEventArgs e) {
            string cust_name, cust_PESELNumber, cust_address, cust_contact;
            bool oldCustomer = false;
            bool newCustomer = true;

            cust_name = nameBox.Text;
            cust_PESELNumber = PESELNumberBox.Text;
            cust_address = addressBox.Text;
            cust_contact = contactBox.Text;

            if ((nameFlag || PESELNumberFlag || phoneNumberFlag) == true) {
                if (nameFlag) {
                    nameBoxErrorIcon.Visible = true;
                }
                if (PESELNumberFlag) {
                    PESELNumberErrorIcon.Visible = true;
                }
                if (phoneNumberFlag) {
                    phoneNumberBoxErrorIcon.Visible = true;
                }

                CustomMsgBox.Show("The given input is invalid.\nPlease enter correct information and fill fields to required information.", "OK");
            }
            else {
                redundantData.con.Open();

                string sqlQuery = "SELECT * FROM customer WHERE customer_cnic = @id";

                SqlCommand sqlCmd = new SqlCommand(sqlQuery, redundantData.con);

                sqlCmd.Parameters.AddWithValue("@id", cust_PESELNumber);

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);

                DataSet sqlSet = new DataSet();

                sqlAdapter.Fill(sqlSet);
                redundantData.con.Close();
                
                if (sqlSet.Tables[0].Rows.Count > 0) {
                    newCustomer = false;

                    redundantData.con.Open();

                    string sqlQuery2 = "SELECT * FROM customer WHERE customer_name = @name and customer_cnic = @id";

                    SqlCommand sqlCmd2 = new SqlCommand(sqlQuery2, redundantData.con);

                    sqlCmd2.Parameters.AddWithValue("@name", cust_name);
                    sqlCmd2.Parameters.AddWithValue("@id", cust_PESELNumber);

                    SqlDataAdapter sqlAdapter2 = new SqlDataAdapter(sqlCmd2);

                    DataSet sqlSet2 = new DataSet();

                    sqlAdapter2.Fill(sqlSet2);

                    redundantData.con.Close();

                    if (sqlSet2.Tables[0].Rows.Count > 0) {
                        oldCustomer = true;
                    }
                    else {
                        CustomMsgBox.Show("The given Name or PESEL number are invalid. Please input correct name and PESEL number.", "OK");
                    }
                }
                if (newCustomer) {
                    redundantData.con.Open();

                    string sqlQuery3 = "INSERT INTO CUSTOMER(CUSTOMER_CNIC,CUSTOMER_NAME,CUSTOMER_CONTACT,CUSTOMER_ADDRESS) VALUES(@PESELNumber,@name,@contact,@address)";

                    SqlCommand sqlCmd3 = new SqlCommand(sqlQuery3, redundantData.con);

                    sqlCmd3.Parameters.AddWithValue("@PESELNumber", cust_PESELNumber);
                    sqlCmd3.Parameters.AddWithValue("@name", cust_name);
                    sqlCmd3.Parameters.AddWithValue("@contact", cust_contact);
                    sqlCmd3.Parameters.AddWithValue("@address", cust_address);
                    sqlCmd3.ExecuteNonQuery();

                    redundantData.con.Close();
                }
                if (oldCustomer || newCustomer) {
                    redundantData.con.Open();

                    string sqlQuery4 = "SELECT MAX(substring(CUSTOMER_ORDER.ORDER_ID,4,LEN(customer_order.order_id))) FROM CUSTOMER_ORDER ";

                    SqlCommand sqlCmd4 = new SqlCommand(sqlQuery4, redundantData.con);

                    SqlDataAdapter sqlAdapter4 = new SqlDataAdapter(sqlCmd4);

                    DataSet sqlSet4 = new DataSet();

                    sqlAdapter4.Fill(sqlSet4);

                    string id;

                    if (sqlSet4.Tables[0].Rows.Count > 0) {
                        id = Convert.ToString(sqlSet4.Tables[0].Rows[0].ItemArray[0]);
                    }
                    else {
                        id = string.Empty;
                    }

                    string OrderID = idGenerator(id);
                    string sqlQuery5 = "SELECT car.car_price FROM car WHERE car.car_id = @id";

                    SqlCommand sqlCmd5 = new SqlCommand(sqlQuery5, redundantData.con);

                    sqlCmd5.Parameters.AddWithValue("@id", carID);

                    SqlDataAdapter sqlAdapter5 = new SqlDataAdapter(sqlCmd5);

                    DataSet sqlSet5 = new DataSet();

                    sqlAdapter5.Fill(sqlSet5);

                    int price = Convert.ToInt32(sqlSet5.Tables[0].Rows[0].ItemArray[0]);
                    int newBill = price + (price * 7 / 100);
                    string sqlQuery6 = "INSERT INTO Customer_Order(order_id,employee_id,car_id,customer_cnic,order_date,bill) VALUES(@Oid,@EmpID,@CiD,@PESELNumber,getDate(),@bill)";
                    
                    SqlCommand sqlCmd6 = new SqlCommand(sqlQuery6, redundantData.con);

                    sqlCmd6.Parameters.AddWithValue("@Oid", OrderID);
                    sqlCmd6.Parameters.AddWithValue("@EmpID", empId);
                    sqlCmd6.Parameters.AddWithValue("@CiD", carID);
                    sqlCmd6.Parameters.AddWithValue("@PESELNumber", cust_PESELNumber);
                    sqlCmd6.Parameters.AddWithValue("@bill", newBill);
                    sqlCmd6.ExecuteNonQuery();

                    string sqlQuery7 = "INSERT INTO SELL_PAYMENT(Order_ID,payment_Date) VALUES(@order,getDate())";

                    SqlCommand sqlCmd7 = new SqlCommand(sqlQuery7, redundantData.con);

                    sqlCmd7.Parameters.AddWithValue("@order", OrderID);
                    sqlCmd7.ExecuteNonQuery();

                    string sqlQuery8 = "UPDATE Car SET car.car_status='Sold' WHERE car_id = @carid";

                    SqlCommand sqlCmd8 = new SqlCommand(sqlQuery8, redundantData.con);

                    sqlCmd8.Parameters.AddWithValue("@carid", carID);
                    sqlCmd8.ExecuteNonQuery();

                    string sqlQuery9 = "UPDATE employee SET EMPLOYEE_SALES = (Employee_sales+1) WHERE EMPLOYEE_ID = @id";

                    SqlCommand sqlCmd9 = new SqlCommand(sqlQuery9, redundantData.con);

                    sqlCmd9.Parameters.AddWithValue("@id", empId);
                    sqlCmd9.ExecuteNonQuery();

                    string sqlQuery10 = "INSERT INTO Account(Cust_Order,AMOUNT,IS_PAID,PAYMENT_DATE) VALUES(@order,@amount,'FALSE',GETDATE())";

                    SqlCommand sqlCmd10 = new SqlCommand(sqlQuery10, redundantData.con);

                    sqlCmd10.Parameters.AddWithValue("@order", OrderID);
                    sqlCmd10.Parameters.AddWithValue("@amount", newBill);
                    sqlCmd10.ExecuteNonQuery();

                    CustomSuccessBox.Show("Transaction has been completed successfuly.");

                    redundantData.con.Close();

                    new SMMenu(empId).Show();

                    this.Close();

                    nameBox.Text = "";
                    PESELNumberBox.Text = "";
                    addressBox.Text = "";
                    contactBox.Text = "";
                }
            }
        }
        private string idGenerator(string id) {
            string digits,letters;

            letters = "COD";

            if (id == string.Empty) {
                digits = "000";
            }
            else {
                digits = new string(id.Where(char.IsDigit).ToArray());
            }

            int number;
            int.TryParse(digits, out number);
            string new_id = letters + (++number).ToString("D4");
            
            return new_id;
        }
    }
}
