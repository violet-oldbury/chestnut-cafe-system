using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace chestnut_cafe
{
    public partial class create_account : Form
    {
        public string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "chestnut_cafe_usernpass.csv");
        public string filename_usrnm = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "chestnut_cafe_sign_in_usrnm.csv");
        public string filename_yorn = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "chestnut_cafe_sign_in_yorn.csv");
        public static bool sign_in_yorn;
        public string fileusrnm;
        public string fileyorn;
        private bool ismax;
        public create_account()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //goes to home form
        private void home_button_Click(object sender, EventArgs e)
        {
            Hide();
            home_menu home_menu = new home_menu();
            home_menu.ShowDialog();
            Close();
        }

        //goes to menu form
        private void menus_button_Click(object sender, EventArgs e)
        {
            Hide();
            menus menus = new menus();
            menus.ShowDialog();
            Close();
        }

        //goes to sign in form
        private void sign_in_button_Click(object sender, EventArgs e)
        {
            Hide();
            sign_in sign_in = new sign_in();
            sign_in.ShowDialog();
            Close();
        }

        //if sign_in_yorn is true then go to booking form
        private void booking_button_Click(object sender, EventArgs e)
        {
            if(sign_in_yorn ==  true)
            {
                Hide();
                booking booking = new booking();
                booking.ShowDialog();
                Close();
            }
        }

        //go to gallery form 
        private void gallery_button_Click(object sender, EventArgs e)
        {
            Hide();
            gallery gallery = new gallery();
            gallery.ShowDialog();
            Close();
        }

        //go to info form
        private void info_button_Click(object sender, EventArgs e)
        {
            Hide();
            info info = new info();
            info.ShowDialog();
            Close();
        }

        //if the text boxes are not empty then write then to filename, show messagebox and then goes to sign in form. if they are empty then show messagebox
        private void create_account_btn_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filename, append: true))
            {
                if (usernametxtbox.Text != "" && passwordtxtbox.Text != "" && nametxtbox.Text != "")
                {

                    writer.Write(usernametxtbox.Text + "," + passwordtxtbox.Text + "\n");

                    MessageBox.Show("created sign in");
                    writer.Close();

                    Hide();
                    sign_in sign_in = new sign_in();
                    sign_in.ShowDialog();
                    Close();
                }

                else
                {
                    MessageBox.Show("please input text into the username, password and email boxes please");
                }
            }
        }

        //hides/ unhides password
        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            passwordtxtbox.UseSystemPasswordChar = !showpass.Checked;
        }

        //on load hides password then if signed in is true then read all of filename_usrnm then make username.txt the username
        private void create_account_Load(object sender, EventArgs e)
        {
            passwordtxtbox.UseSystemPasswordChar = !showpass.Checked;

            if (signed_in(fileyorn))
            {
                string[] lines = File.ReadAllLines(filename_usrnm);
                foreach (string line in lines)
                {
                    string[] credentials = line.Split(',');
                    if (credentials.Length == 1)
                    {
                        fileusrnm = credentials[0];

                    }
                }
                username.Text = fileusrnm;
            }
        }

        //read all of filename_yorn then if 1 then return true, if 0 then return false
        private bool signed_in(string yorn)
        {
            string[] lines = File.ReadAllLines(filename_yorn);

            foreach (string line in lines)
            {
                string[] credentials = line.Split(',');
                if (credentials.Length == 1)
                {
                    string fileyorn = credentials[0];


                    if (fileyorn == "1")
                    {
                        sign_in_yorn = true;
                        return true;
                    }
                    else if (fileyorn == "0")
                    {
                        sign_in_yorn = false;
                        return false;
                    }
                }
            }
            return false;
        }

        //clears filename_usrnm and filename_yorn then closes program
        private void close_btn_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filename_usrnm, append: false))
            {
                writer.Close();
            }

            using (StreamWriter writer = new StreamWriter(filename_yorn, append: false))
            {
                writer.Close();
            }

            this.Close();
        }

        //maximises window
        private void maximise_btn_Click(object sender, EventArgs e)
        {
            if (ismax == false)
            {
                this.WindowState = FormWindowState.Maximized;
                ismax = true;
            }

            else if (ismax == true)
            {
                this.WindowState = FormWindowState.Normal;
                ismax = false;
            }
        }

        //minimises window
        private void minimise_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //moves form to mouse
        private void movebox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //go to gallery form
        private void gallery_button_Click_1(object sender, EventArgs e)
        {
            Hide();
            gallery gallery = new gallery();
            gallery.ShowDialog();
            Close();
        }

        // go to info form
        private void info_button_Click_1(object sender, EventArgs e)
        {
            Hide();
            info info = new info();
            info.ShowDialog();
            Close();
        }
    }
}
