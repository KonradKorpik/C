namespace CSM_Project
{
    partial class CarSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSell));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.PESELNumberBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.sellBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.nameBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.PESELNumberErrorIcon = new System.Windows.Forms.PictureBox();
            this.addressBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.phoneNumberBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.nameExpLbl = new System.Windows.Forms.Label();
            this.cnicExpLbl = new System.Windows.Forms.Label();
            this.addressExpLbl = new System.Windows.Forms.Label();
            this.contactExpLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PESELNumberErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberBoxErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name*";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "PESEL number*";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone number*";
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.Location = new System.Drawing.Point(53, 190);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.MaxLength = 50;
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(399, 34);
            this.nameBox.TabIndex = 14;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // PESELNumberBox
            // 
            this.PESELNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PESELNumberBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.PESELNumberBox.ForeColor = System.Drawing.Color.Black;
            this.PESELNumberBox.Location = new System.Drawing.Point(53, 300);
            this.PESELNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.PESELNumberBox.MaxLength = 13;
            this.PESELNumberBox.Multiline = true;
            this.PESELNumberBox.Name = "PESELNumberBox";
            this.PESELNumberBox.Size = new System.Drawing.Size(399, 34);
            this.PESELNumberBox.TabIndex = 15;
            this.PESELNumberBox.Enter += new System.EventHandler(this.PESELNumberBox_Enter);
            this.PESELNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PESELNumberBox_KeyPress);
            this.PESELNumberBox.Leave += new System.EventHandler(this.PESELNumberBox_Leave);
            // 
            // addressBox
            // 
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.addressBox.ForeColor = System.Drawing.Color.Black;
            this.addressBox.Location = new System.Drawing.Point(561, 190);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressBox.MaxLength = 50;
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(399, 34);
            this.addressBox.TabIndex = 16;
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressBox_KeyPress);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // contactBox
            // 
            this.contactBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.contactBox.ForeColor = System.Drawing.Color.Black;
            this.contactBox.Location = new System.Drawing.Point(561, 300);
            this.contactBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactBox.MaxLength = 9;
            this.contactBox.Multiline = true;
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(399, 34);
            this.contactBox.TabIndex = 17;
            this.contactBox.Enter += new System.EventHandler(this.contactBox_Enter);
            this.contactBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactBox_KeyPress);
            this.contactBox.Leave += new System.EventHandler(this.contactBox_Leave);
            // 
            // sellBtn
            // 
            this.sellBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sellBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellBtn.FlatAppearance.BorderSize = 0;
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.ForeColor = System.Drawing.Color.White;
            this.sellBtn.Location = new System.Drawing.Point(423, 404);
            this.sellBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(133, 53);
            this.sellBtn.TabIndex = 20;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = false;
            this.sellBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sellBtn_MouseClick);
            this.sellBtn.MouseEnter += new System.EventHandler(this.sellBtn_MouseEnter);
            this.sellBtn.MouseLeave += new System.EventHandler(this.sellBtn_MouseLeave);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(914, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(105, 97);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(286, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 75);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(396, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 32);
            this.label5.TabIndex = 40;
            this.label5.Text = "Customer\'s Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 97);
            this.panel1.TabIndex = 41;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(116, 97);
            this.backBtn.TabIndex = 41;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            this.backBtn.MouseEnter += new System.EventHandler(this.backBtn_MouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.backBtn_MouseLeave);
            // 
            // nameBoxErrorIcon
            // 
            this.nameBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.nameBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameBoxErrorIcon.BackgroundImage")));
            this.nameBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nameBoxErrorIcon.Location = new System.Drawing.Point(423, 192);
            this.nameBoxErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.nameBoxErrorIcon.Name = "nameBoxErrorIcon";
            this.nameBoxErrorIcon.Size = new System.Drawing.Size(28, 28);
            this.nameBoxErrorIcon.TabIndex = 42;
            this.nameBoxErrorIcon.TabStop = false;
            // 
            // PESELNumberErrorIcon
            // 
            this.PESELNumberErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.PESELNumberErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PESELNumberErrorIcon.BackgroundImage")));
            this.PESELNumberErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PESELNumberErrorIcon.Location = new System.Drawing.Point(423, 303);
            this.PESELNumberErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.PESELNumberErrorIcon.Name = "PESELNumberErrorIcon";
            this.PESELNumberErrorIcon.Size = new System.Drawing.Size(28, 28);
            this.PESELNumberErrorIcon.TabIndex = 43;
            this.PESELNumberErrorIcon.TabStop = false;
            // 
            // addressBoxErrorIcon
            // 
            this.addressBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.addressBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addressBoxErrorIcon.BackgroundImage")));
            this.addressBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addressBoxErrorIcon.Location = new System.Drawing.Point(931, 192);
            this.addressBoxErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.addressBoxErrorIcon.Name = "addressBoxErrorIcon";
            this.addressBoxErrorIcon.Size = new System.Drawing.Size(28, 28);
            this.addressBoxErrorIcon.TabIndex = 44;
            this.addressBoxErrorIcon.TabStop = false;
            // 
            // phoneNumberBoxErrorIcon
            // 
            this.phoneNumberBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("phoneNumberBoxErrorIcon.BackgroundImage")));
            this.phoneNumberBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.phoneNumberBoxErrorIcon.Location = new System.Drawing.Point(931, 303);
            this.phoneNumberBoxErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberBoxErrorIcon.Name = "phoneNumberBoxErrorIcon";
            this.phoneNumberBoxErrorIcon.Size = new System.Drawing.Size(28, 28);
            this.phoneNumberBoxErrorIcon.TabIndex = 45;
            this.phoneNumberBoxErrorIcon.TabStop = false;
            // 
            // nameExpLbl
            // 
            this.nameExpLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameExpLbl.ForeColor = System.Drawing.Color.Black;
            this.nameExpLbl.Location = new System.Drawing.Point(53, 224);
            this.nameExpLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameExpLbl.Name = "nameExpLbl";
            this.nameExpLbl.Size = new System.Drawing.Size(399, 22);
            this.nameExpLbl.TabIndex = 46;
            this.nameExpLbl.Text = "e.g. Jan Kowalski (max 50 chars)";
            // 
            // cnicExpLbl
            // 
            this.cnicExpLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicExpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.cnicExpLbl.Location = new System.Drawing.Point(53, 335);
            this.cnicExpLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cnicExpLbl.Name = "cnicExpLbl";
            this.cnicExpLbl.Size = new System.Drawing.Size(399, 18);
            this.cnicExpLbl.TabIndex = 47;
            this.cnicExpLbl.Text = "e.g. 12345678910 (11 Digits)";
            // 
            // addressExpLbl
            // 
            this.addressExpLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressExpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.addressExpLbl.Location = new System.Drawing.Point(561, 224);
            this.addressExpLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressExpLbl.Name = "addressExpLbl";
            this.addressExpLbl.Size = new System.Drawing.Size(399, 22);
            this.addressExpLbl.TabIndex = 48;
            this.addressExpLbl.Text = "e.g. Wrocław (max 50 chars)";
            // 
            // contactExpLbl
            // 
            this.contactExpLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactExpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.contactExpLbl.Location = new System.Drawing.Point(561, 335);
            this.contactExpLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactExpLbl.Name = "contactExpLbl";
            this.contactExpLbl.Size = new System.Drawing.Size(399, 18);
            this.contactExpLbl.TabIndex = 49;
            this.contactExpLbl.Text = "e.g. 123456789 (9 Digits)";
            // 
            // CarSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 502);
            this.Controls.Add(this.contactExpLbl);
            this.Controls.Add(this.addressExpLbl);
            this.Controls.Add(this.cnicExpLbl);
            this.Controls.Add(this.nameExpLbl);
            this.Controls.Add(this.phoneNumberBoxErrorIcon);
            this.Controls.Add(this.addressBoxErrorIcon);
            this.Controls.Add(this.PESELNumberErrorIcon);
            this.Controls.Add(this.nameBoxErrorIcon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PESELNumberBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Car";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PESELNumberErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberBoxErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox PESELNumberBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox nameBoxErrorIcon;
        private System.Windows.Forms.PictureBox PESELNumberErrorIcon;
        private System.Windows.Forms.PictureBox addressBoxErrorIcon;
        private System.Windows.Forms.PictureBox phoneNumberBoxErrorIcon;
        private System.Windows.Forms.Label nameExpLbl;
        private System.Windows.Forms.Label cnicExpLbl;
        private System.Windows.Forms.Label addressExpLbl;
        private System.Windows.Forms.Label contactExpLbl;
        private System.Windows.Forms.Button backBtn;
    }
}