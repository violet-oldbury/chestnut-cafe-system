namespace chestnut_cafe
{
    partial class sign_in
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
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.sign_in_btn = new System.Windows.Forms.Button();
            this.create_account_btn = new System.Windows.Forms.Button();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.movebox = new System.Windows.Forms.PictureBox();
            this.minimise_btn = new System.Windows.Forms.Label();
            this.maximise_btn = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.booking_button = new System.Windows.Forms.Button();
            this.gallery_button = new System.Windows.Forms.Button();
            this.menus_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximise_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxtbox.Location = new System.Drawing.Point(328, 150);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(144, 29);
            this.usernametxtbox.TabIndex = 0;
            this.usernametxtbox.TextChanged += new System.EventHandler(this.usernametxtbox_TextChanged);
            // 
            // sign_in_btn
            // 
            this.sign_in_btn.Location = new System.Drawing.Point(362, 325);
            this.sign_in_btn.Name = "sign_in_btn";
            this.sign_in_btn.Size = new System.Drawing.Size(76, 23);
            this.sign_in_btn.TabIndex = 4;
            this.sign_in_btn.Text = "sign in";
            this.sign_in_btn.UseVisualStyleBackColor = true;
            this.sign_in_btn.Click += new System.EventHandler(this.sign_in_btn_Click);
            // 
            // create_account_btn
            // 
            this.create_account_btn.Location = new System.Drawing.Point(355, 377);
            this.create_account_btn.Name = "create_account_btn";
            this.create_account_btn.Size = new System.Drawing.Size(90, 23);
            this.create_account_btn.TabIndex = 5;
            this.create_account_btn.Text = "create account";
            this.create_account_btn.UseVisualStyleBackColor = true;
            this.create_account_btn.Click += new System.EventHandler(this.create_account_btn_Click);
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxtbox.Location = new System.Drawing.Point(328, 248);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(144, 29);
            this.passwordtxtbox.TabIndex = 6;
            this.passwordtxtbox.TextChanged += new System.EventHandler(this.passwordtxtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "password";
            // 
            // showpass
            // 
            this.showpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showpass.AutoSize = true;
            this.showpass.BackColor = System.Drawing.Color.Transparent;
            this.showpass.Location = new System.Drawing.Point(331, 285);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(106, 17);
            this.showpass.TabIndex = 20;
            this.showpass.Text = "unhide password";
            this.showpass.UseVisualStyleBackColor = false;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::chestnut_cafe.Properties.Resources.low_poly_grid_haikei__1_;
            this.panel1.Controls.Add(this.movebox);
            this.panel1.Controls.Add(this.minimise_btn);
            this.panel1.Controls.Add(this.maximise_btn);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.booking_button);
            this.panel1.Controls.Add(this.gallery_button);
            this.panel1.Controls.Add(this.menus_button);
            this.panel1.Controls.Add(this.home_button);
            this.panel1.Controls.Add(this.info_button);
            this.panel1.Controls.Add(this.sign_in_button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 111);
            this.panel1.TabIndex = 1;
            // 
            // movebox
            // 
            this.movebox.BackColor = System.Drawing.Color.Transparent;
            this.movebox.Image = global::chestnut_cafe.Properties.Resources.arrow;
            this.movebox.Location = new System.Drawing.Point(698, 0);
            this.movebox.Name = "movebox";
            this.movebox.Size = new System.Drawing.Size(25, 25);
            this.movebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movebox.TabIndex = 21;
            this.movebox.TabStop = false;
            this.movebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movebox_MouseDown);
            // 
            // minimise_btn
            // 
            this.minimise_btn.AutoSize = true;
            this.minimise_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimise_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimise_btn.Location = new System.Drawing.Point(729, 0);
            this.minimise_btn.Name = "minimise_btn";
            this.minimise_btn.Size = new System.Drawing.Size(22, 24);
            this.minimise_btn.TabIndex = 21;
            this.minimise_btn.Text = "--";
            this.minimise_btn.Click += new System.EventHandler(this.minimise_btn_Click);
            // 
            // maximise_btn
            // 
            this.maximise_btn.BackColor = System.Drawing.Color.Transparent;
            this.maximise_btn.Image = global::chestnut_cafe.Properties.Resources.pngimg_com___square_PNG89;
            this.maximise_btn.Location = new System.Drawing.Point(751, 0);
            this.maximise_btn.Name = "maximise_btn";
            this.maximise_btn.Size = new System.Drawing.Size(25, 25);
            this.maximise_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximise_btn.TabIndex = 23;
            this.maximise_btn.TabStop = false;
            this.maximise_btn.Click += new System.EventHandler(this.maximise_btn_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(3, 3);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(82, 16);
            this.username.TabIndex = 6;
            this.username.Text = "not signed in";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Image = global::chestnut_cafe.Properties.Resources.close_x;
            this.close_btn.Location = new System.Drawing.Point(775, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(25, 25);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_btn.TabIndex = 22;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::chestnut_cafe.Properties.Resources.chestnut_cafe_cup_leaf_white_back;
            this.pictureBox2.Location = new System.Drawing.Point(350, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // booking_button
            // 
            this.booking_button.Location = new System.Drawing.Point(410, 80);
            this.booking_button.Name = "booking_button";
            this.booking_button.Size = new System.Drawing.Size(74, 23);
            this.booking_button.TabIndex = 6;
            this.booking_button.Text = "booking";
            this.booking_button.UseVisualStyleBackColor = true;
            this.booking_button.Click += new System.EventHandler(this.booking_button_Click);
            // 
            // gallery_button
            // 
            this.gallery_button.Location = new System.Drawing.Point(504, 80);
            this.gallery_button.Name = "gallery_button";
            this.gallery_button.Size = new System.Drawing.Size(74, 23);
            this.gallery_button.TabIndex = 5;
            this.gallery_button.Text = "gallery";
            this.gallery_button.UseVisualStyleBackColor = true;
            this.gallery_button.Click += new System.EventHandler(this.gallery_button_Click);
            // 
            // menus_button
            // 
            this.menus_button.Location = new System.Drawing.Point(222, 80);
            this.menus_button.Name = "menus_button";
            this.menus_button.Size = new System.Drawing.Size(74, 23);
            this.menus_button.TabIndex = 4;
            this.menus_button.Text = "menus";
            this.menus_button.UseVisualStyleBackColor = true;
            this.menus_button.Click += new System.EventHandler(this.menus_button_Click);
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(128, 80);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(74, 23);
            this.home_button.TabIndex = 3;
            this.home_button.Text = "home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(598, 80);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(74, 23);
            this.info_button.TabIndex = 2;
            this.info_button.Text = "info";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // sign_in_button
            // 
            this.sign_in_button.BackColor = System.Drawing.Color.Gainsboro;
            this.sign_in_button.Location = new System.Drawing.Point(316, 80);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(74, 23);
            this.sign_in_button.TabIndex = 1;
            this.sign_in_button.Text = "sign in";
            this.sign_in_button.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.create_account_btn);
            this.Controls.Add(this.sign_in_btn);
            this.Controls.Add(this.usernametxtbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sign_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sign_in";
            this.Load += new System.EventHandler(this.sign_in_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximise_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button booking_button;
        private System.Windows.Forms.Button gallery_button;
        private System.Windows.Forms.Button menus_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.Button sign_in_btn;
        private System.Windows.Forms.Button create_account_btn;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Label minimise_btn;
        private System.Windows.Forms.PictureBox maximise_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.PictureBox movebox;
    }
}