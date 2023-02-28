//using DBapplication;
using Receptionist;
using System.Data;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Welcome : Form
    {
        Controller controllerObj;

        // tarok: +bxn3XW72zLwDS8mQigQdA==
        // 3my  : Ot7nOdfMTwE7TubTCV0SFg==
        // zoz  : cX1IV9JGJEiczfT/wKOf0g==
        // hoda : OhhvSNxSn6vh+WaybjKiKQ==

        // jojo     : RAv0DyUqCLwVnTMaZqA0Ew==
        // metwaly  : g5/7lN6RNQGUdwgKRV1oAg==

        // TODO: when adding new user -> make sure he is either a manager or receptionist
        //      (i.e. search for him first in the other table before adding him)

        public Welcome()
        {
            InitializeComponent();
            animation.Enabled = true;
            // opacity
            welcomePanel.BackColor = Color.FromArgb(125, Color.Black);
            //left_panel.BackColor = Color.FromArgb(125, Color.White);
            //right_panel.BackColor = Color.FromArgb(125, Color.White);
            controllerObj = new Controller();
        }

        private void log_in_button_Click(object sender, EventArgs e)
        {

            bool manager = false;

            string email = username_tb.Text;
            string password = password_tb.Text;

            String theEmailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";

            if (!Regex.IsMatch(email, theEmailPattern))
            {
                MessageBox.Show("Invalid email.");
                return;
            }

            //try
            //{
            //    MailAddress m = new MailAddress(email);
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Invalid email.");
            //    return;
            //}


            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            var str = password_tb.Text;
            password = EncryptionClass.EncryptString(key, str);


            // Search in manager
            DataTable dt = controllerObj.loginManager(email, password);
            if (dt == null)
            {
                manager = false;

                // Search in receptionist
                if (!manager)
                {
                    dt = controllerObj.loginReceptionist(email, password);
                }
                
                if (dt == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

            }
            else
            {
                manager = true;
            }

            string ssn = (string) dt.Rows[0][0];

            //MessageBox.Show(ssn);

            // otherwise, navigate to the appropriate form object
            if (manager)
            {
                //Manager
                ManagerMain managerMain = new ManagerMain(ssn, this);
                managerMain.Show();
                this.Hide();
            }
            else
            {
                //Receptionist
                ReceptionistMain receptionistMain = new ReceptionistMain(ssn, this);
                receptionistMain.Show();
                this.Hide();

            }

        }

        private void animation_Tick(object sender, EventArgs e)
        {

            left_panel.Height += 2;
            right_panel.Location = new Point(right_panel.Location.X, right_panel.Location.Y - 2);

            if (animation.Interval < 100)
            {
                animation.Interval += 1;
            }

            if (left_panel.Height >= 300)
            {
                animation.Enabled = false;
            }


        }

    }
}


//// see encrypted version and copy it to clipboard

//var key = "b14ca5898a4e4133bbce2ea2315a1916";

////Console.WriteLine("Please enter a secret key for the symmetric algorithm.");  
////var key = Console.ReadLine();  

////Console.WriteLine("Please enter a string for encryption");
//var str = password_tb.Text;
//var encryptedString = EncryptionClass.EncryptString(key, str);
//MessageBox.Show($"encrypted string = {encryptedString}");
//Clipboard.SetText(encryptedString);

//var decryptedString = EncryptionClass.DecryptString(key, encryptedString);
////MessageBox.Show($"decrypted string = {decryptedString}");

////Console.ReadKey();

////