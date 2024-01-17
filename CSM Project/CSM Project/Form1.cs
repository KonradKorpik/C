using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project {
    public partial class LogInForm : Form {
        public LogInForm() {
            InitializeComponent();
            LblVanish();
        }

        private void nameBox_Enter(object sender, EventArgs e) {
            userImage.Image = Image.FromFile(@"C:\Users\adkno\source\repos\CSM Project\CSM Project\Resources\User2.png");

            if (nameBox.Text == "Username") {
                nameBox.Text = "";
            }

            namePnl.BackColor = ColorTranslator.FromHtml("#333333"); 
            nameBox.BackColor = ColorTranslator.FromHtml("#333333");
            nameBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
            userImage.BackColor = ColorTranslator.FromHtml("#333333");

            LblVanish();
        }
        private void nameBox_Leave(object sender, EventArgs e) {
            userImage.Image = Image.FromFile(@"C:\Users\adkno\source\repos\CSM Project\CSM Project\Resources\User.png");

            if (nameBox.Text == "") {
                nameBox.Text = "Username";
            }

            namePnl.BackColor = ColorTranslator.FromHtml("#ffffff");
            nameBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            nameBox.ForeColor = ColorTranslator.FromHtml("#000000");
            userImage.BackColor = ColorTranslator.FromHtml("#ffffff");

        }
        private void nameBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar)) {
                e.Handled = false;

                if (e.KeyChar == (char)Keys.Enter) {
                    logBtn_Click(sender, e);
                }
            }
            else {
                CustomMsgBox.Show("Incorrect data has been entered.\nTry using letters (without Polish characters) or numbers.", "OK");

                e.Handled = true;
            }
        }
        private void pinBox_Enter(object sender, EventArgs e) {
            lockImage.Image = Image.FromFile(@"C:\Users\adkno\source\repos\CSM Project\CSM Project\Resources\Password2.png");

            if (pinBox.Text == "Password") {
                pinBox.Text = "";
                pinBox.PasswordChar = '*';
            }

            pinPnl.BackColor = ColorTranslator.FromHtml("#333333");
            pinBox.BackColor = ColorTranslator.FromHtml("#333333");
            pinBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
            lockImage.BackColor = ColorTranslator.FromHtml("#333333");

            LblVanish();
        }
        private void pinBox_Leave(object sender, EventArgs e) {
            lockImage.Image = Image.FromFile(@"C:\Users\adkno\source\repos\CSM Project\CSM Project\Resources\Password.png");

            if (pinBox.Text == "") {
                pinBox.Text = "Password";
                pinBox.PasswordChar = '\0';
            }

            pinPnl.BackColor = ColorTranslator.FromHtml("#ffffff");
            pinBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            pinBox.ForeColor = ColorTranslator.FromHtml("#000000");
            lockImage.BackColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void pinBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar)) {
                e.Handled = false;

                if (e.KeyChar == (char)Keys.Enter) {
                    logBtn_Click(sender, e);
                }
            }
            else {
                CustomMsgBox.Show("Incorrect data has been entered.\nTry using letters (without Polish characters) or numbers.", "OK");

                e.Handled = true;
            }
        }
        private void logBtn_MouseEnter(object sender, EventArgs e) {
            logBtn.BackColor = ColorTranslator.FromHtml("#333333");
            logBtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void logBtn_MouseLeave(object sender, EventArgs e) {
            logBtn.BackColor = ColorTranslator.FromHtml("#ffffff");
            logBtn.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        private void logBtn_Click(object sender, EventArgs e) {
            string employeeUsername, employeePassword, employeeDesgination;

            employeeUsername = nameBox.Text;
            employeePassword = pinBox.Text;

            string sqlQuery = "SELECT * FROM employee WHERE employee_id = @username and EMPLOYEE_PASSWORD = @password and employee_status = @status";

            SqlCommand sqlCmd = new SqlCommand(sqlQuery, redundantData.con);

            sqlCmd.Parameters.AddWithValue("@username", employeeUsername);
            sqlCmd.Parameters.AddWithValue("@password", employeePassword);
            sqlCmd.Parameters.AddWithValue("@status", "Working");

            SqlDataAdapter sqlAdpater = new SqlDataAdapter(sqlCmd);
            DataSet sqlSet = new DataSet();

            sqlAdpater.Fill(sqlSet);

            if ((sqlSet.Tables[0].Rows.Count) > 0) {
                employeeDesgination = Convert.ToString(sqlSet.Tables[0].Rows[0].ItemArray[6]);

                if (employeeDesgination.ToLower() == "salesman") {
                    //new SMMenu(empID).Show();

                    this.Hide();
                }
                else if (employeeDesgination.ToLower() == "manager") {
                    new Manager_Menu(employeeUsername).Show();

                    this.Hide();
                }
            }
            else {
                LblVisible();
            }
        }
        private void exitBtn_MouseEnter(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#ff0000");
            exitBtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
            exitBtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void exitBtn_MouseClick(object sender, MouseEventArgs e) {
            Application.Exit();
        }
        private void LblVisible() {
            nameErrorIcon.Visible = true;
            pinErrorIcon.Visible = true;

            CustomMsgBox.Show("Wrong Name/Password.\nPlease check that your data is correct.", "OK");
        }
        private void LblVanish() {
            nameErrorIcon.Visible = false;
            pinErrorIcon.Visible = false;
        }
    }
}
