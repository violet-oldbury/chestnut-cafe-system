namespace chestnut_cafe
{
    partial class menus
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.movebox = new System.Windows.Forms.PictureBox();
            this.minimise_btn = new System.Windows.Forms.Label();
            this.maximise_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.booking_button = new System.Windows.Forms.Button();
            this.gallery_button = new System.Windows.Forms.Button();
            this.menus_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximise_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::chestnut_cafe.Properties.Resources.chestnut_menu;
            this.pictureBox3.Location = new System.Drawing.Point(0, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 342);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::chestnut_cafe.Properties.Resources.low_poly_grid_haikei__1_;
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.movebox);
            this.panel1.Controls.Add(this.minimise_btn);
            this.panel1.Controls.Add(this.maximise_btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.close_btn);
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
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(3, 3);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(82, 16);
            this.username.TabIndex = 2;
            this.username.Text = "not signed in";
            // 
            // movebox
            // 
            this.movebox.BackColor = System.Drawing.Color.Transparent;
            this.movebox.Image = global::chestnut_cafe.Properties.Resources.arrow;
            this.movebox.Location = new System.Drawing.Point(698, 0);
            this.movebox.Name = "movebox";
            this.movebox.Size = new System.Drawing.Size(25, 25);
            this.movebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movebox.TabIndex = 9;
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
            this.minimise_btn.TabIndex = 8;
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
            this.maximise_btn.TabIndex = 10;
            this.maximise_btn.TabStop = false;
            this.maximise_btn.Click += new System.EventHandler(this.maximise_btn_Click);
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
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Image = global::chestnut_cafe.Properties.Resources.close_x;
            this.close_btn.Location = new System.Drawing.Point(775, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(25, 25);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_btn.TabIndex = 9;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
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
            this.menus_button.BackColor = System.Drawing.Color.Gainsboro;
            this.menus_button.Location = new System.Drawing.Point(222, 80);
            this.menus_button.Name = "menus_button";
            this.menus_button.Size = new System.Drawing.Size(74, 23);
            this.menus_button.TabIndex = 4;
            this.menus_button.Text = "menus";
            this.menus_button.UseVisualStyleBackColor = false;
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
            this.sign_in_button.Location = new System.Drawing.Point(316, 80);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(74, 23);
            this.sign_in_button.TabIndex = 1;
            this.sign_in_button.Text = "sign in";
            this.sign_in_button.UseVisualStyleBackColor = true;
            this.sign_in_button.Click += new System.EventHandler(this.sign_in_button_Click);
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
            // menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menus";
            this.Load += new System.EventHandler(this.menus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximise_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label minimise_btn;
        private System.Windows.Forms.PictureBox maximise_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.PictureBox movebox;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}