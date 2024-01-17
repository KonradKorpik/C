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
    public partial class carCtrl : Form {
        string empID;
        bool mLicenceFlag, mNameFlag, mAddressFlag, mContactFlag, mEmailFlag;
        bool cIDFlag, cNameFlag, cModelFlag, cCompanyFlag, cPriceFlag;
        
        public carCtrl() {
            InitializeComponent();
        }
        public carCtrl(string id) {
            InitializeComponent();
            pictureVanish();
            emptyChecker();

            empID = id;
        }
        
        private void emptyChecker() {
            if (licenseBox.Text == "") {
                mLicenceFlag = true;
            }
            if (nameBox.Text == "") {
                mNameFlag = true;
            }
            if (emailBox.Text == "") {
                mEmailFlag = true;
            }
            if (cIDBox.Text == "") {
                cIDFlag = true;
            }
            if (cNameBox.Text == "") {
                cNameFlag = true;
            }
            if (cModelBox.Text == "") {
                cModelFlag = true;
            }
            if (cCmpyBox.Text == "") {
                cCompanyFlag = true;
            }
            if (cPriceBox.Text == "") {
                cPriceFlag = true;
            }
        }
        private void pictureVanish() {
            manufLicenseErrorIcon.Visible = false;
            manufNameErrorIcon.Visible = false;
            manufContactErrorIcon.Visible = false;
            manufAddressErrorIcon.Visible = false;
            manufEmailErrorIcon.Visible = false;
            carIDErrorIcon.Visible = false;
            carNameErrorIcon.Visible = false;
            carModelErrorIcon.Visible = false;
            carCompanyErrorIcon.Visible = false;
            carPriceErrorIcon.Visible = false;
        }
        private void clearRows() {
            licenseBox.Text = "";
            nameBox.Text = "";
            emailBox.Text = "";
            addressBox.Text = "";
            contactBox.Text = "";
            cIDBox.Text = "";
            cNameBox.Text = "";
            cModelBox.Text = "";
            cCmpyBox.Text = "";
            cPriceBox.Text = "";
        }
        private void backBtn_MouseEnter(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void backBtn_MouseLeave(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e) {
            new SMMenu(empID).Show();

            this.Hide();
        }
        private void exitBtn_MouseEnter(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#ff0000");
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void licenseBox_Enter(object sender, EventArgs e) {
            manufLicenseErrorIcon.Visible = false;

            licenseBox.BorderStyle = BorderStyle.None;
            licenseBox.BackColor = ColorTranslator.FromHtml("#333333");
            licenseBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void licenseBox_Leave(object sender, EventArgs e) {
            if (licenseBox.Text == "") {
                manufLicenseErrorIcon.Visible = true;
                mLicenceFlag = true;
            }
            else {
                manufLicenseErrorIcon.Visible = false;
                mLicenceFlag = false;
            }

            licenseBox.BorderStyle = BorderStyle.Fixed3D;
            licenseBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            licenseBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void licenseBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void nameBox_Enter(object sender, EventArgs e) {
            manufNameErrorIcon.Visible = false;
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.BackColor = ColorTranslator.FromHtml("#333333");
            nameBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void nameBox_Leave(object sender, EventArgs e) {
            if (nameBox.Text == "") {
                manufNameErrorIcon.Visible = true;
                mNameFlag = true;
            }
            else {
                manufNameErrorIcon.Visible = false;
                mNameFlag = false;
            }

            nameBox.BorderStyle = BorderStyle.Fixed3D;
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
        private void contactBox_Enter(object sender, EventArgs e) {
            manufContactErrorIcon.Visible = false;
            contactBox.BorderStyle = BorderStyle.None;
            contactBox.BackColor = ColorTranslator.FromHtml("#333333");
            contactBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void contactBox_Leave(object sender, EventArgs e) {
            if (contactBox.Text != "" && contactBox.Text.Length != 9) {
                manufContactErrorIcon.Visible = true;
                mContactFlag = true;
            }
            else {
                manufContactErrorIcon.Visible = false;
                mContactFlag = false;
            }

            contactBox.BorderStyle = BorderStyle.Fixed3D;
            contactBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            contactBox.ForeColor = ColorTranslator.FromHtml("#000000");
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
        private void addressBox_Enter(object sender, EventArgs e) {
            manufAddressErrorIcon.Visible = false;
            addressBox.BorderStyle = BorderStyle.None;
            addressBox.BackColor = ColorTranslator.FromHtml("#333333");
            addressBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void addressBox_Leave(object sender, EventArgs e) {
            addressBox.BorderStyle = BorderStyle.Fixed3D;
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
        private void emailBox_Enter(object sender, EventArgs e) {
            manufEmailErrorIcon.Visible = false;
            emailBox.BorderStyle = BorderStyle.None;
            emailBox.BackColor = ColorTranslator.FromHtml("#333333");
            emailBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void emailBox_Leave(object sender, EventArgs e) {
            if (emailBox.Text == "") {
                manufEmailErrorIcon.Visible = true;
                mEmailFlag = true;
            }
            else {
                manufEmailErrorIcon.Visible = false;
                mEmailFlag = false;
            }

            emailBox.BorderStyle = BorderStyle.Fixed3D;
            emailBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            emailBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void emailBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == '@') || (e.KeyChar == '.') || (e.KeyChar == '-')) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void cIDBox_Enter(object sender, EventArgs e) {
            carIDErrorIcon.Visible = false;
            cIDBox.BorderStyle = BorderStyle.None;
            cIDBox.BackColor = ColorTranslator.FromHtml("#333333");
            cIDBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void cIDBox_Leave(object sender, EventArgs e) {
            if (cIDBox.Text == "") {
                carIDErrorIcon.Visible = true;
                cIDFlag = true;
            }
            else {
                carIDErrorIcon.Visible = false;
                cIDFlag = false;
            }

            cIDBox.BorderStyle = BorderStyle.Fixed3D;
            cIDBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            cIDBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void cIDBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void cNameBox_Enter(object sender, EventArgs e) {
            carNameErrorIcon.Visible = false;
            cNameBox.BorderStyle = BorderStyle.None;
            cNameBox.BackColor = ColorTranslator.FromHtml("#333333");
            cNameBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void cNameBox_Leave(object sender, EventArgs e) {
            if (cNameBox.Text == "") {
                carNameErrorIcon.Visible = true;
                cNameFlag = true;
            }
            else {
                carNameErrorIcon.Visible = false;
                cNameFlag = false;
            }

            cNameBox.BorderStyle = BorderStyle.Fixed3D;
            cNameBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            cNameBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void cNameBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void cModelBox_Enter(object sender, EventArgs e) {
            carModelErrorIcon.Visible = false;
            cModelBox.BorderStyle = BorderStyle.None;
            cModelBox.BackColor = ColorTranslator.FromHtml("#333333");
            cModelBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void cModelBox_Leave(object sender, EventArgs e) {
            if (cModelBox.Text == "" || cModelBox.Text.Length != 4) {
                carModelErrorIcon.Visible = true;
                cModelFlag = true;
            }
            else {
                carModelErrorIcon.Visible = false;
                cModelFlag = false;
            }

            cModelBox.BorderStyle = BorderStyle.Fixed3D;
            cModelBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            cModelBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void cModelBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void cCmpyBox_Enter(object sender, EventArgs e) {
            carCompanyErrorIcon.Visible = false;
            cCmpyBox.BorderStyle = BorderStyle.None;
            cCmpyBox.BackColor = ColorTranslator.FromHtml("#333333");
            cCmpyBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void cCmpyBox_Leave(object sender, EventArgs e) {
            if (cCmpyBox.Text == "") {
                carCompanyErrorIcon.Visible = true;
                cCompanyFlag = true;
            }
            else {
                carCompanyErrorIcon.Visible = false;
                cCompanyFlag = false;
            }

            cCmpyBox.BorderStyle = BorderStyle.Fixed3D;
            cCmpyBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            cCmpyBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void cCmpyBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void cPriceBox_Enter(object sender, EventArgs e) {
            carPriceErrorIcon.Visible = false;
            cPriceBox.BorderStyle = BorderStyle.None;
            cPriceBox.BackColor = ColorTranslator.FromHtml("#333333");
            cPriceBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void cPriceBox_Leave(object sender, EventArgs e) {
            if (cPriceBox.Text == "") {
                carPriceErrorIcon.Visible = true;
                cPriceFlag = true;
            }
            else {
                carPriceErrorIcon.Visible = false;
                cPriceFlag = false;
            }

            cPriceBox.BorderStyle = BorderStyle.Fixed3D;
            cPriceBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            cPriceBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void cPriceBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                CustomMsgBox.Show("Input incorrect.\nPlease input in the way shown below each text field.", "OK");

                e.Handled = true;
            }
        }
        private void buyBtn_MouseEnter(object sender, EventArgs e) {
            buyBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void buyBtn_MouseLeave(object sender, EventArgs e) {
            buyBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void buyBtn_MouseClick(object sender, MouseEventArgs e) {
            bool isOldSeller = false;
            bool isnewSeller = true;
            string manfID = licenseBox.Text;
            string manfName = nameBox.Text;
            string manfEmail = emailBox.Text;
            string manfAddress = addressBox.Text;
            string manfContact = contactBox.Text;
            string carID = cIDBox.Text;
            string carName = cNameBox.Text;
            string carModel = cModelBox.Text;
            string carCompany = cCmpyBox.Text;
            string carPrice = cPriceBox.Text;

            if (mLicenceFlag || mNameFlag || mEmailFlag || cIDFlag || cNameFlag || cModelFlag || cPriceFlag || cCompanyFlag) {
                if (mLicenceFlag) {
                    manufLicenseErrorIcon.Visible = true;
                }
                if (mNameFlag) {
                    manufNameErrorIcon.Visible = true;
                }
                if (mEmailFlag) {
                    manufEmailErrorIcon.Visible = true;
                }
                if (cIDFlag) {
                    carIDErrorIcon.Visible = true;
                }
                if (cNameFlag) {
                    carNameErrorIcon.Visible = true;
                }
                if (cModelFlag) {
                    carModelErrorIcon.Visible = true;
                }
                if (cCompanyFlag) {
                    carCompanyErrorIcon.Visible = true;
                }
                if (cPriceFlag) {
                    carPriceErrorIcon.Visible = true;
                }

                CustomMsgBox.Show("The given input is invalid.\nPlease enter correct information.", "OK");
            }
            else {
                redundantData.con.Open();

                string sqlQuery = "SELECT * FROM car WHERE car_ID = @id";

                SqlCommand sqlCmd = new SqlCommand(sqlQuery, redundantData.con);

                sqlCmd.Parameters.AddWithValue("@id", carID);

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);

                DataSet sqlSet = new DataSet();

                sqlAdapter.Fill(sqlSet);

                redundantData.con.Close();

                if (sqlSet.Tables[0].Rows.Count > 0) {
                    CustomMsgBox.Show("The entered Car's ID is incorrect.\nPlease recheck it", "OK");

                    carIDErrorIcon.Visible = true;
                }
                else {
                    redundantData.con.Open();

                    string sqlQuery2 = "SELECT * FROM manufacturer WHERE MANUFACTURER_ID = @id";

                    SqlCommand sqlCmd2 = new SqlCommand(sqlQuery2, redundantData.con);

                    sqlCmd2.Parameters.AddWithValue("@id", manfID);

                    SqlDataAdapter sqlAdapter2 = new SqlDataAdapter(sqlCmd2);

                    DataSet sqlSet2 = new DataSet();

                    sqlAdapter2.Fill(sqlSet2);

                    redundantData.con.Close();

                    if (sqlSet2.Tables[0].Rows.Count > 0) {
                        isnewSeller = false;

                        redundantData.con.Open();

                        string sqlQuery3 = "SELECT * FROM manufacturer WHERE manufacturer_name = @name AND manufacturer_id = @id " + "AND manufacturer_email = @email";

                        SqlCommand sqlCmd3 = new SqlCommand(sqlQuery3, redundantData.con);

                        sqlCmd3.Parameters.AddWithValue("@name", manfName);
                        sqlCmd3.Parameters.AddWithValue("@id", manfID);
                        sqlCmd3.Parameters.AddWithValue("@email", manfEmail);

                        SqlDataAdapter sqlAdapter3 = new SqlDataAdapter(sqlCmd3);

                        DataSet sqlSet3 = new DataSet();

                        sqlAdapter3.Fill(sqlSet3);

                        redundantData.con.Close();

                        if (sqlSet3.Tables[0].Rows.Count > 0) {
                            isOldSeller = true;
                        }
                        else {
                            CustomMsgBox.Show("The given Manufacturer's License or Name are invalid. Please recheck them.", "OK");

                            manufLicenseErrorIcon.Visible = manufNameErrorIcon.Visible = true;
                        }
                    }
                    if (isnewSeller) {
                        redundantData.con.Open();

                        string sqlQuery4 = "SELECT * FROM manufacturer WHERE manufacturer_email = @email";

                        SqlCommand sqlCmd4 = new SqlCommand(sqlQuery4, redundantData.con);

                        sqlCmd4.Parameters.AddWithValue("@email", manfEmail);

                        SqlDataAdapter sqlAdapter4 = new SqlDataAdapter(sqlCmd4);

                        DataSet sqlSet4 = new DataSet();

                        sqlAdapter4.Fill(sqlSet4);

                        redundantData.con.Close();

                        if (sqlSet4.Tables[0].Rows.Count == 0) {
                            redundantData.con.Open();

                            string sqlQuery5 = "INSERT INTO MANUFACTURER(MANUFACTURER_ID,MANUFACTURER_NAME,MANUFACTURER_CONTACT,MANUFACTURER_EMAIL,MANUFACTURER_ADDRESS) Values(@id,@name,@contact,@email,@address)";

                            SqlCommand sqlCmd5 = new SqlCommand(sqlQuery5, redundantData.con);

                            sqlCmd5.Parameters.AddWithValue("@id", manfID);
                            sqlCmd5.Parameters.AddWithValue("@name", manfName);
                            sqlCmd5.Parameters.AddWithValue("@email", manfEmail);
                            sqlCmd5.Parameters.AddWithValue("@address", manfAddress);
                            sqlCmd5.Parameters.AddWithValue("@contact", manfContact);
                            sqlCmd5.ExecuteNonQuery();

                            redundantData.con.Close();
                        }
                        else {
                            isnewSeller = false;

                            CustomMsgBox.Show("The given Email is invalid.\nPlease recheck it", "OK");

                            manufEmailErrorIcon.Visible = true;
                        }
                    }
                    if (isOldSeller || isnewSeller) {
                        redundantData.con.Open();

                        string sqlQuery6 = "INSERT INTO CAR(CAR_ID,CAR_NAME,CAR_MODEL,CAR_COMPANY,CAR_STATUS,CAR_PRICE) Values(@cID,@cName,@cModel,@cCompany,'Available',@cPrice)";

                        SqlCommand sqlCmd6 = new SqlCommand(sqlQuery6, redundantData.con);

                        sqlCmd6.Parameters.AddWithValue("@cID", carID);
                        sqlCmd6.Parameters.AddWithValue("@cName", carName);
                        sqlCmd6.Parameters.AddWithValue("@cModel", carModel);
                        sqlCmd6.Parameters.AddWithValue("@cCompany", carCompany);
                        sqlCmd6.Parameters.AddWithValue("@cPrice", carPrice);
                        sqlCmd6.ExecuteNonQuery();

                        string sqlQuery7 = "SELECT MAX(SUBSTRING(manuf_order.ORDER_ID,4,LEN(manuf_order.order_id))) FROM MANUF_ORDER ";

                        SqlCommand sqlCmd7 = new SqlCommand(sqlQuery7, redundantData.con);

                        SqlDataAdapter sqlAdapter6 = new SqlDataAdapter(sqlCmd7);

                        DataSet sqlSet6 = new DataSet();

                        sqlAdapter6.Fill(sqlSet6);

                        string id;

                        if (sqlSet6.Tables[0].Rows.Count > 0) {
                            id = Convert.ToString(sqlSet6.Tables[0].Rows[0].ItemArray[0]);
                        }
                        else {
                            id = string.Empty;
                        }

                        string OrderID = idGenerator(id);
                        string sqlQuery8 = "INSERT INTO MANUF_ORDER(ORDER_ID,EMPLOYEE_ID,CAR_ID,MANUFACTURER_ID,ORDER_DATE,BILL) Values(@orderID,@empID,@carID,@manfID,getdate(),@bill)";

                        SqlCommand sqlCmd8 = new SqlCommand(sqlQuery8, redundantData.con);

                        sqlCmd8.Parameters.AddWithValue("@orderID", OrderID);
                        sqlCmd8.Parameters.AddWithValue("@empID", empID);
                        sqlCmd8.Parameters.AddWithValue("@carID", carID);
                        sqlCmd8.Parameters.AddWithValue("@manfID", manfID);
                        sqlCmd8.Parameters.AddWithValue("@bill", carPrice);
                        sqlCmd8.ExecuteNonQuery();

                        string sqlQuery9 = "INSERT INTO STOCK_PAYMENT(ORDER_ID,PAYMENT_DATE) Values(@id,getdate())";

                        SqlCommand sqlCmd9 = new SqlCommand(sqlQuery9, redundantData.con);

                        sqlCmd9.Parameters.AddWithValue("@id", OrderID);
                        sqlCmd9.ExecuteNonQuery();

                        string sqlQuery10 = "INSERT INTO Stock(Order_ID,Car_ID,REC_DATE) Values(@oID,@cID,getdate())";

                        SqlCommand sqlCmd10 = new SqlCommand(sqlQuery10, redundantData.con);

                        sqlCmd10.Parameters.AddWithValue("@oID", OrderID);
                        sqlCmd10.Parameters.AddWithValue("@cID", carID);
                        sqlCmd10.ExecuteNonQuery();

                        string sqlQuery11 = "INSERT INTO Account(MANF_Order,AMOUNT,IS_PAID,PAYMENT_DATE) Values(@order,@amount,'TRUE',GETDATE())";

                        SqlCommand sqlCmd11 = new SqlCommand(sqlQuery11, redundantData.con);

                        sqlCmd11.Parameters.AddWithValue("@order", OrderID);
                        sqlCmd11.Parameters.AddWithValue("@amount", carPrice);
                        sqlCmd11.ExecuteNonQuery();

                        redundantData.con.Close();

                        CustomSuccessBox.Show("New car has been successfuly added.");

                        clearRows();
                    }
                }
            }
        }
        private string idGenerator(string id) {
            string digits, letters;

            letters = "MOD";

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
