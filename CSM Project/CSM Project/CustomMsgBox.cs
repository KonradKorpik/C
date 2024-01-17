using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project {
    public partial class CustomMsgBox : Form {
        public CustomMsgBox() {
            InitializeComponent();
        }

        static CustomMsgBox MsgBox;
        static DialogResult result = DialogResult.No;
        
        public static DialogResult Show(string Text, string btnOK) {
            MsgBox = new CustomMsgBox();
            MsgBox.label1.Text = Text;
            MsgBox.button1.Text = btnOK;
            result = DialogResult.No;

            MsgBox.ShowDialog();

            return result;
        }
        
        private void button1_MouseEnter(object sender, EventArgs e) {
            button1.BackColor = ColorTranslator.FromHtml("#11a19b");
        }
        private void button1_MouseLeave(object sender, EventArgs e) {
            button1.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void button1_MouseClick(object sender, MouseEventArgs e) {
            result = DialogResult.Yes;
            
            MsgBox.Close();
        }
    }
}
