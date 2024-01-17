namespace CSM_Project
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.exitBtn = new System.Windows.Forms.Button();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.lockImage = new System.Windows.Forms.PictureBox();
            this.pinPnl = new System.Windows.Forms.Panel();
            this.pinErrorIcon = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.namePnl = new System.Windows.Forms.Panel();
            this.nameErrorIcon = new System.Windows.Forms.PictureBox();
            this.logBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lockImage)).BeginInit();
            this.pinPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.namePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.exitBtn.Location = new System.Drawing.Point(733, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(61, 49);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // pinBox
            // 
            this.pinBox.BackColor = System.Drawing.Color.White;
            this.pinBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinBox.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBox.ForeColor = System.Drawing.Color.Black;
            this.pinBox.Location = new System.Drawing.Point(71, 14);
            this.pinBox.Margin = new System.Windows.Forms.Padding(4);
            this.pinBox.Multiline = true;
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(312, 32);
            this.pinBox.TabIndex = 18;
            this.pinBox.Text = "Password";
            this.pinBox.Enter += new System.EventHandler(this.pinBox_Enter);
            this.pinBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pinBox_KeyPress);
            this.pinBox.Leave += new System.EventHandler(this.pinBox_Leave);
            // 
            // lockImage
            // 
            this.lockImage.BackColor = System.Drawing.Color.White;
            this.lockImage.Image = ((System.Drawing.Image)(resources.GetObject("lockImage.Image")));
            this.lockImage.Location = new System.Drawing.Point(10, 4);
            this.lockImage.Margin = new System.Windows.Forms.Padding(10);
            this.lockImage.Name = "lockImage";
            this.lockImage.Size = new System.Drawing.Size(49, 51);
            this.lockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockImage.TabIndex = 24;
            this.lockImage.TabStop = false;
            // 
            // pinPnl
            // 
            this.pinPnl.BackColor = System.Drawing.Color.White;
            this.pinPnl.Controls.Add(this.pinErrorIcon);
            this.pinPnl.Controls.Add(this.lockImage);
            this.pinPnl.Controls.Add(this.pinBox);
            this.pinPnl.Location = new System.Drawing.Point(203, 418);
            this.pinPnl.Margin = new System.Windows.Forms.Padding(0);
            this.pinPnl.Name = "pinPnl";
            this.pinPnl.Padding = new System.Windows.Forms.Padding(10);
            this.pinPnl.Size = new System.Drawing.Size(387, 59);
            this.pinPnl.TabIndex = 37;
            // 
            // pinErrorIcon
            // 
            this.pinErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.pinErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pinErrorIcon.BackgroundImage")));
            this.pinErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pinErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("pinErrorIcon.Image")));
            this.pinErrorIcon.Location = new System.Drawing.Point(330, 4);
            this.pinErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pinErrorIcon.Name = "pinErrorIcon";
            this.pinErrorIcon.Size = new System.Drawing.Size(53, 51);
            this.pinErrorIcon.TabIndex = 42;
            this.pinErrorIcon.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.Location = new System.Drawing.Point(71, 11);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(312, 36);
            this.nameBox.TabIndex = 25;
            this.nameBox.Text = "Username";
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(10, 4);
            this.userImage.Margin = new System.Windows.Forms.Padding(10);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(49, 51);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 24;
            this.userImage.TabStop = false;
            // 
            // namePnl
            // 
            this.namePnl.BackColor = System.Drawing.Color.White;
            this.namePnl.Controls.Add(this.nameErrorIcon);
            this.namePnl.Controls.Add(this.userImage);
            this.namePnl.Controls.Add(this.nameBox);
            this.namePnl.ForeColor = System.Drawing.Color.Black;
            this.namePnl.Location = new System.Drawing.Point(203, 323);
            this.namePnl.Margin = new System.Windows.Forms.Padding(0);
            this.namePnl.Name = "namePnl";
            this.namePnl.Padding = new System.Windows.Forms.Padding(10);
            this.namePnl.Size = new System.Drawing.Size(387, 59);
            this.namePnl.TabIndex = 36;
            // 
            // nameErrorIcon
            // 
            this.nameErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.nameErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameErrorIcon.BackgroundImage")));
            this.nameErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nameErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("nameErrorIcon.Image")));
            this.nameErrorIcon.Location = new System.Drawing.Point(330, 4);
            this.nameErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.nameErrorIcon.Name = "nameErrorIcon";
            this.nameErrorIcon.Size = new System.Drawing.Size(53, 51);
            this.nameErrorIcon.TabIndex = 41;
            this.nameErrorIcon.TabStop = false;
            // 
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.White;
            this.logBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logBtn.FlatAppearance.BorderSize = 0;
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.ForeColor = System.Drawing.Color.Black;
            this.logBtn.Location = new System.Drawing.Point(203, 510);
            this.logBtn.Margin = new System.Windows.Forms.Padding(0);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(387, 49);
            this.logBtn.TabIndex = 38;
            this.logBtn.Text = "LOG IN";
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            this.logBtn.MouseEnter += new System.EventHandler(this.logBtn_MouseEnter);
            this.logBtn.MouseLeave += new System.EventHandler(this.logBtn_MouseLeave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 41);
            this.label3.TabIndex = 44;
            this.label3.Text = "Sign In";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(155)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 612);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.pinPnl);
            this.Controls.Add(this.namePnl);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.lockImage)).EndInit();
            this.pinPnl.ResumeLayout(false);
            this.pinPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.namePnl.ResumeLayout(false);
            this.namePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.PictureBox lockImage;
        private System.Windows.Forms.Panel pinPnl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Panel namePnl;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.PictureBox pinErrorIcon;
        private System.Windows.Forms.PictureBox nameErrorIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

