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
    public partial class Manager_Menu : Form {
        string employeeUsername;

        public Manager_Menu() {
            InitializeComponent();

            this.CenterToScreen();
        }
        public Manager_Menu(string username) {
            InitializeComponent();

            this.CenterToScreen();

            employeeUsername = username;
        }

        private void backBtn_MouseEnter(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void backBtn_MouseLeave(object sender, EventArgs e) {
            backBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e) {
            new LogInForm().Show();

            this.Hide();
        }
        private void exitBtn_MouseEnter(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#ff0000");
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e) {
            exitBtn.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void exitBtn_MouseClick(object sender, MouseEventArgs e) {
            Application.Exit();
        }
        private void empCtrlPanel_MouseEnter(object sender, EventArgs e) {
            empCtrlPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void empCtrlPanel_MouseLeave(object sender, EventArgs e) {
            empCtrlPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void empCtrlPanel_MouseClick(object sender, MouseEventArgs e) {
            new empControl(employeeUsername).Show();

            this.Hide();
        }
        private void carCtrlPanel_MouseEnter(object sender, EventArgs e) {
            carCtrlPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void carCtrlPanel_MouseLeave(object sender, EventArgs e) {
            carCtrlPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void carCtrlPanel_MouseClick(object sender, MouseEventArgs e) {
            new SMMenu(employeeUsername).Show();

            this.Hide();
        }
        private void salesCtrlPanel_MouseEnter(object sender, EventArgs e) {
            salesCtrlPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void salesCtrlPanel_MouseLeave(object sender, EventArgs e) {
            salesCtrlPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void salesCtrlPanel_MouseClick(object sender, MouseEventArgs e) {
            new Form8(employeeUsername).Show();

            this.Hide();
        }
        private void accountCtrlPanel_MouseEnter(object sender, EventArgs e) {
            accountCtrlPanel.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void accountCtrlPanel_MouseLeave(object sender, EventArgs e) {
            accountCtrlPanel.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void accountCtrlPanel_MouseClick(object sender, MouseEventArgs e) {
            new Form10(employeeUsername).Show();

            this.Hide();
        }
    }
}
