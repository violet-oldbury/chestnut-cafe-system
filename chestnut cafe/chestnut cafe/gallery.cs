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

namespace chestnut_cafe
{
    public partial class gallery : Form
    {
        public string filename_usrnm = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "chestnut_cafe_sign_in_usrnm.csv");
        public string filename_yorn = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "chestnut_cafe_sign_in_yorn.csv");
        public string fileyorn;
        public static bool sign_in_yorn;
        public string fileusrnm;
        private bool ismax;

        public gallery()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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
        
        //go to sign in form
        private void sign_in_button_Click(object sender, EventArgs e)
        {
            Hide();
            sign_in sign_in = new sign_in();
            sign_in.ShowDialog();
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

        //go to info form
        private void info_button_Click(object sender, EventArgs e)
        {
            Hide();
            info info = new info();
            info.ShowDialog();
            Close();
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

        //if signed_in is true then read filename_usrnm and put the value on username.text
        private void gallery_Load(object sender, EventArgs e)
        {
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

        //read filename_yorn then if it is 1 return true, if it is 0 return false
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

        //moves window to mouse
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
