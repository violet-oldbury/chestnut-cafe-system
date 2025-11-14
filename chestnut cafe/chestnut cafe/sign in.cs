using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chestnut_cafe
{
    public partial class sign_in : Form
    {
        public string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "chestnut_cafe_usernpass.csv");
        public string filename_usrnm = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "chestnut_cafe_sign_in_usrnm.csv");
        public string filename_yorn = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "chestnut_cafe_sign_in_yorn.csv");
        public string usrnm;
        public string psswrd;
        public string fileyorn;
        public string fileusrnm;
        public static bool sign_in_yorn;
        private bool ismax;

        public sign_in()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // try read filename and if has signed in then sign in yorn=true and return true. if not able tp then show messagebox
        private bool validatecredentials(string username1, string password1)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] credentials = line.Split(',');
                    if (credentials.Length == 2)
                    {
                        string fileUsername = credentials[0];
                        string filePassword = credentials[1];

                        if (fileUsername == username1 && filePassword == password1)
                        {
                            sign_in_yorn = true;
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("file location not found");
                return false;
            }
            catch (IOException)
            {
                MessageBox.Show("cannot access the file because it is being used by another process.");
                return false;
            }
        }

        //go to home form
        private void home_button_Click(object sender, EventArgs e)
        {
            Hide();
            home_menu home_menu = new home_menu();
            home_menu.ShowDialog();
            Close();
        }

        //go to menu form
        private void menus_button_Click(object sender, EventArgs e)
        {
            Hide();
            menus menus = new menus();
            menus.ShowDialog();
            Close();
        }

        //go to booking if signed in is true, if not, show messagebox 
        private void booking_button_Click(object sender, EventArgs e)
        {
            if (signed_in(fileyorn))
            {
                Hide();
                booking booking = new booking();
                booking.ShowDialog();
                Close();
            }

            else
            {
                MessageBox.Show("not signed in");
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

        // go to info form
        private void info_button_Click(object sender, EventArgs e)
        {
            Hide();
            info info = new info();
            info.ShowDialog();
            Close();
        }

        //if validatecredentials is true then show messagebox then write username to filename_usrnm and a 1 to filename_yorn then open sign in form
        //else then show messagebox then write 0 to filename_yorn
        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            if (validatecredentials(usrnm, psswrd))
            {
                MessageBox.Show("signed in");

                using (StreamWriter writer = new StreamWriter(filename_usrnm, append: false))
                {
                    writer.Write(usernametxtbox.Text + "\n");
                    writer.Close();
                }

                using (StreamWriter writer = new StreamWriter(filename_yorn, append: false))
                {
                    writer.Write("1" + "\n");
                    writer.Close();
                }

                Hide();
                sign_in sign_in = new sign_in();
                sign_in.ShowDialog();
                Close();
            }

            else
            {
                MessageBox.Show("invalid credentials");
                using (StreamWriter writer = new StreamWriter(filename_yorn, append: false))
                {
                    writer.Write("0" + "\n");
                    writer.Close();
                }
            }
        }

        //open create account form
        private void create_account_btn_Click(object sender, EventArgs e)
        {
            Hide();
            create_account create_Account = new create_account();
            create_Account.ShowDialog();
            Close();
        }

        //show or hide the password
        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            passwordtxtbox.UseSystemPasswordChar = !showpass.Checked;
        }

        //on load hide the password then if signed_in is true then read filename_usrnm and put the value on username.text
        private void sign_in_Load(object sender, EventArgs e)
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

        //read filename_yorn, if 1 then return true, if else then return false
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
                        sign_in_yorn= false;
                        return false;
                    }
                }
            }
            return false;
        }

        //sets the value of usernametxtbox to usrnm
        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {
            usrnm = usernametxtbox.Text;
        }

        //sets the value of passwordtxtbox to psswrd
        private void passwordtxtbox_TextChanged(object sender, EventArgs e)
        {
            psswrd = passwordtxtbox.Text;
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

        //fits window to screen size
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

        //moves form
        private void movebox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
