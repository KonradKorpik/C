namespace CSM_Project
{
    partial class SaleManCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleManCtrl));
            this.hireBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.contactBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.addressBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.pinBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.emailBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.nameExpLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBoxErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // hireBtn
            // 
            this.hireBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.hireBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hireBtn.FlatAppearance.BorderSize = 0;
            this.hireBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hireBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireBtn.ForeColor = System.Drawing.Color.White;
            this.hireBtn.Location = new System.Drawing.Point(404, 479);
            this.hireBtn.Margin = new System.Windows.Forms.Padding(4);
            this.hireBtn.Name = "hireBtn";
            this.hireBtn.Size = new System.Drawing.Size(117, 65);
            this.hireBtn.TabIndex = 2;
            this.hireBtn.Text = "Hire";
            this.hireBtn.UseVisualStyleBackColor = false;
            this.hireBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hireBtn_MouseClick_1);
            this.hireBtn.MouseEnter += new System.EventHandler(this.hireBtn_MouseEnter);
            this.hireBtn.MouseLeave += new System.EventHandler(this.hireBtn_MouseLeave);
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(83, 182);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.MaxLength = 50;
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(399, 34);
            this.nameBox.TabIndex = 3;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // pinBox
            // 
            this.pinBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBox.Location = new System.Drawing.Point(673, 182);
            this.pinBox.Margin = new System.Windows.Forms.Padding(4);
            this.pinBox.MaxLength = 50;
            this.pinBox.Multiline = true;
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(399, 34);
            this.pinBox.TabIndex = 4;
            this.pinBox.TextChanged += new System.EventHandler(this.pinBox_TextChanged);
            this.pinBox.Enter += new System.EventHandler(this.pinBox_Enter);
            this.pinBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pinBox_KeyPress);
            this.pinBox.Leave += new System.EventHandler(this.pinBox_Leave);
            // 
            // contactBox
            // 
            this.contactBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactBox.Location = new System.Drawing.Point(83, 276);
            this.contactBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactBox.MaxLength = 9;
            this.contactBox.Multiline = true;
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(399, 34);
            this.contactBox.TabIndex = 5;
            this.contactBox.TextChanged += new System.EventHandler(this.contactBox_TextChanged);
            this.contactBox.Enter += new System.EventHandler(this.contactBox_Enter);
            this.contactBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactBox_KeyPress);
            this.contactBox.Leave += new System.EventHandler(this.contactBox_Leave);
            // 
            // addressBox
            // 
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(673, 276);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressBox.MaxLength = 50;
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(399, 34);
            this.addressBox.TabIndex = 6;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressBox_KeyPress);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(377, 366);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.MaxLength = 50;
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(399, 34);
            this.emailBox.TabIndex = 7;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            this.emailBox.Enter += new System.EventHandler(this.emailBox_Enter);
            this.emailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailBox_KeyPress);
            this.emailBox.Leave += new System.EventHandler(this.emailBox_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label2.Location = new System.Drawing.Point(673, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password*";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label3.Location = new System.Drawing.Point(83, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name*";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label4.Location = new System.Drawing.Point(82, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label5.Location = new System.Drawing.Point(673, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(399, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label6.Location = new System.Drawing.Point(377, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email*";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(607, 479);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(117, 65);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateBtn_MouseClick);
            this.updateBtn.MouseEnter += new System.EventHandler(this.updateBtn_MouseEnter);
            this.updateBtn.MouseLeave += new System.EventHandler(this.updateBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 97);
            this.panel1.TabIndex = 42;
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
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1072, 0);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(444, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "Employee\'s Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(334, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 75);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // nameBoxErrorIcon
            // 
            this.nameBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.nameBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameBoxErrorIcon.BackgroundImage")));
            this.nameBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nameBoxErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("nameBoxErrorIcon.Image")));
            this.nameBoxErrorIcon.Location = new System.Drawing.Point(451, 185);
            this.nameBoxErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.nameBoxErrorIcon.Name = "nameBoxErrorIcon";
            this.nameBoxErrorIcon.Size = new System.Drawing.Size(28, 28);
            this.nameBoxErrorIcon.TabIndex = 43;
            this.nameBoxErrorIcon.TabStop = false;
            // 
            // contactBoxErrorIcon
            // 
            this.contactBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.contactBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contactBoxErrorIcon.BackgroundImage")));
            this.contactBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.contactBoxErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("contactBoxErrorIcon.Image")));
            this.contactBoxErrorIcon.Location = new System.Drawing.Point(451, 278);
            this.contactBoxErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.contactBoxErrorIcon.Name = "contactBoxErrorIcon";
            this.contactBoxErrorIcon.Size = new System.Drawing.Size(28, 28);
            this.contactBoxErrorIcon.TabIndex = 44;
            this.contactBoxErrorIcon.TabStop = false;
            // 
            // addressBoxErrorIcon
            // 
            this.addressBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.addressBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addressBoxErrorIcon.BackgroundImage")));
            this.addressBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addressBoxErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("addressBoxErrorIcon.Image")));
            this.addressBoxErrorIcon.Location = new System.Drawing.Point(1043, 278);
            this.addressBoxErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.addressBoxErrorIcon.Name = "addressBoxErrorIcon";
            this.addressBoxErrorIcon.Size = new System.Drawing.Size(28, 28);
            this.addressBoxErrorIcon.TabIndex = 45;
            this.addressBoxErrorIcon.TabStop = false;
            // 
            // pinBoxErrorIcon
            // 
            this.pinBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.pinBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pinBoxErrorIcon.BackgroundImage")));
            this.pinBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pinBoxErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("pinBoxErrorIcon.Image")));
            this.pinBoxErrorIcon.Location = new System.Drawing.Point(1043, 185);
            this.pinBoxErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pinBoxErrorIcon.Name = "pinBoxErrorIcon";
            this.pinBoxErrorIcon.Size = new System.Drawing.Size(28, 28);
            this.pinBoxErrorIcon.TabIndex = 46;
            this.pinBoxErrorIcon.TabStop = false;
            // 
            // emailBoxErrorIcon
            // 
            this.emailBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.emailBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailBoxErrorIcon.BackgroundImage")));
            this.emailBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emailBoxErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("emailBoxErrorIcon.Image")));
            this.emailBoxErrorIcon.Location = new System.Drawing.Point(747, 368);
            this.emailBoxErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.emailBoxErrorIcon.Name = "emailBoxErrorIcon";
            this.emailBoxErrorIcon.Size = new System.Drawing.Size(28, 28);
            this.emailBoxErrorIcon.TabIndex = 47;
            this.emailBoxErrorIcon.TabStop = false;
            // 
            // nameExpLbl
            // 
            this.nameExpLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameExpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.nameExpLbl.Location = new System.Drawing.Point(82, 217);
            this.nameExpLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameExpLbl.Name = "nameExpLbl";
            this.nameExpLbl.Size = new System.Drawing.Size(400, 18);
            this.nameExpLbl.TabIndex = 48;
            this.nameExpLbl.Text = "e.g. Jan Kowalski (max 50 chars)";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label12.Location = new System.Drawing.Point(83, 310);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(399, 18);
            this.label12.TabIndex = 50;
            this.label12.Text = "e.g. 123456789 (9 char)";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label13.Location = new System.Drawing.Point(673, 310);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(398, 18);
            this.label13.TabIndex = 51;
            this.label13.Text = "e.g. Wrocław (max 50 chars)";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label14.Location = new System.Drawing.Point(377, 400);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(398, 18);
            this.label14.TabIndex = 52;
            this.label14.Text = "e.g. jankowalski@gmail.com (max 50 chars)";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label17.Location = new System.Drawing.Point(673, 217);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(398, 18);
            this.label17.TabIndex = 55;
            this.label17.Text = "e.g. a1b2c3d4 (max 50 chars)";
            // 
            // SaleManCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 576);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nameExpLbl);
            this.Controls.Add(this.emailBoxErrorIcon);
            this.Controls.Add(this.pinBoxErrorIcon);
            this.Controls.Add(this.addressBoxErrorIcon);
            this.Controls.Add(this.contactBoxErrorIcon);
            this.Controls.Add(this.nameBoxErrorIcon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.pinBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.hireBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaleManCtrl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Managment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBoxErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button hireBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox nameBoxErrorIcon;
        private System.Windows.Forms.PictureBox contactBoxErrorIcon;
        private System.Windows.Forms.PictureBox addressBoxErrorIcon;
        private System.Windows.Forms.PictureBox pinBoxErrorIcon;
        private System.Windows.Forms.PictureBox emailBoxErrorIcon;
        private System.Windows.Forms.Label nameExpLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
    }
}