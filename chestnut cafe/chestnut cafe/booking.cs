using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chestnut_cafe
{
    public partial class booking : Form
    {
        public string filename_usrnm = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "chestnut_cafe_sign_in_usrnm.csv");
        public string filename_yorn = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "chestnut_cafe_sign_in_yorn.csv");
        public string filereciept = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "chestnut cafe reciept.txt");
        public string fileyorn;
        public string fileusrnm;
        public static bool sign_in_yorn;
        private bool ismax;
        public string tables;
        public decimal amountnum;
        public string fileUser_name;
        public string fileEmail;

        public booking()
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

        // on load if signed_in is true then read all of filename_usrnm and set username.text to the text in the file
        private void booking_Load(object sender, EventArgs e)
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

        //read filename_yorn then if is 1 then return true, if is 0 return false
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

        //makes screen maximised/unmaximised
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

        //minimises/ unminimises screen
        private void minimise_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //if date/tables selected doesnt equal 0 then write to file in documents what date, what table and how much it was then show that it has been created. if not then show messagebox
        private void purchase_btn_Click(object sender, EventArgs e)
        {
            if (amount.Text != "deposit: £0.00")
            {
                string[] lines = File.ReadAllLines(filename_usrnm);

                foreach (string line in lines)
                {
                    string[] credentials = line.Split(',');
                    if (credentials.Length == 4)
                    {
                        string fileUsername = credentials[0];
                        string filePassword = credentials[1];
                        fileUser_name = credentials[2];
                        fileEmail = credentials[3];

                        
                    }
                }
                
                using (StreamWriter writer = new StreamWriter(filereciept, append: false))
                {
                    writer.Write("purchased by " + fileusrnm + "\n");
                    writer.Write("\n" + "tables:" + "\n");

                    if (table1.BackColor == Color.Gainsboro)
                    {
                        writer.Write("table 1" + "\n");
                    }

                    if (table2.BackColor == Color.Gainsboro)
                    {
                        writer.Write("table 2" + "\n");
                    }

                    if (table3.BackColor == Color.Gainsboro)
                    {
                        writer.Write("table 3" + "\n");
                    }

                    if (table4.BackColor == Color.Gainsboro)
                    {
                        writer.Write("table 4" + "\n");
                    }

                    if (table5.BackColor == Color.Gainsboro)
                    {
                        writer.Write("table 5" + "\n");
                    }

                    DateTime datetime = calender.SelectionStart;
                    writer.Write("\n" + "date: " + datetime + "\n");

                    writer.Write("\n" + amount.Text);
                    writer.Close();
                    MessageBox.Show("reciept made. find it at " + filereciept);
                }
            }

            else
            {
                MessageBox.Show("no tables selected");
            }
        }

        //if table1 is gainsboro then set it to white and the minus 1 to amount.text. otherwise then set the colour to gainsboro then add 1 to amount.text
        private void table1_Click(object sender, EventArgs e)
        {
            decimal amnt = Convert.ToDecimal(5.00);

            if (this.table1.BackColor == Color.Gainsboro)
            {
                this.table1.BackColor = Color.White;

                amountnum = amountnum - Convert.ToDecimal(amnt);
                amount.Text = "deposit: £" + Convert.ToString(amountnum);
            }

            else
            {
                this.table1.BackColor = Color.Gainsboro;

                amountnum = amountnum + Convert.ToDecimal(amnt);
                amount.Text = "deposit: £" + Convert.ToString(amountnum);
            }
        }

        //if table2 is gainsboro then set it to white and the minus 1 to amount.text. otherwise then set the colour to gainsboro then add 1 to amount.text
        private void table2_Click(object sender, EventArgs e)
        {
            decimal amnt = Convert.ToDecimal(3.00);

            if (this.table2.BackColor == Color.Gainsboro)
            {
                this.table2.BackColor = Color.White;

                amountnum = amountnum - Convert.ToDecimal(amnt);
                amount.Text = "deposit: £" + Convert.ToString(amountnum);
            }

            else
            {
                this.table2.BackColor = Color.Gainsboro;

                amountnum = amountnum + Convert.ToDecimal(amnt);
                amount.Text = "deposit: £" + Convert.ToString(amountnum);
            }
        }

        //if table3 is gainsboro then set it to white and the minus 1 to amount.text. otherwise then set the colour to gainsboro then add 1 to amount.text
        private void table3_Click(object sender, EventArgs e)
        {
            decimal amnt = Convert.ToDecimal(4.00);

            if (this.table3.BackColor == Color.Gainsboro)
            {
                this.table3.BackColor = Color.White;

                amountnum = amountnum - Convert.ToDecimal(amnt);
                amount.Text = "deposit: £" + Convert.ToString(amountnum);
            }

            else
            {
                this.table3.BackColor = Color.Gainsboro;

                amountnum = amountnum + Convert.ToDecimal(amnt);
                amount.Text = "deposit: £" + Convert.ToString(amountnum);
            }
        }

        //if table4 is gainsboro then set it to white and the minus 1 to amount.text. otherwise then set the colour to gainsboro then add 1 to amount.text
        private void table4_Click(object sender, EventArgs e)
        {
            decimal amnt = Convert.ToDecimal(3.50);

            if (this.table4.BackColor == Color.Gainsboro)
            {
                this.table4.BackColor = Color.White;

                amountnum = amountnum - Convert.ToDecimal(amnt);
                amount.Text = "deposit: £" + Convert.ToString(amountnum);
            }

            else
            {
                this.table4.BackColor = Color.Gainsboro;

                amountnum = amountnum + Convert.ToDecimal(amnt);
                amount.Text = "deposit: £" + Convert.ToString(amountnum);
            }
        }

        //if table5 is gainsboro then set it to white and the minus 1 to amount.text. otherwise then set the colour to gainsboro then add 1 to amount.text
        private void table5_Click(object sender, EventArgs e)
        {
            decimal amnt = Convert.ToDecimal(3.00);

            if (this.table5.BackColor == Color.Gainsboro)
            {
                this.table5.BackColor = Color.White;

                amountnum = amountnum - Convert.ToDecimal(amnt);
                amount.Text = "deposit: £" + Convert.ToString(amountnum);
            }

            else
            {
                this.table5.BackColor = Color.Gainsboro;

                amountnum = amountnum + Convert.ToDecimal(amnt);
                amount.Text = "deposit: £" + Convert.ToString(amountnum);
            }
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
