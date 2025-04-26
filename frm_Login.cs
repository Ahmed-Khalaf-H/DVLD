using DVLDBusinessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{






    public partial class frm_Login : Form
    {
        private clsUser _User1;

        

        private const string _CredentialsFile = "user_credentials.txt";
        public frm_Login()
        {
            InitializeComponent();
        }

        private void _SaveCredentials(string username, string password)
        {
            //_DeleteCredentails();

            //try
            //{
            //    using (FileStream fs = new FileStream(_CredentialsFile, FileMode.OpenOrCreate, FileAccess.Write))
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        sw.WriteLine($"{username}|||{password}");

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error saving credentials: {ex.Message}");
            //}

            try
            {
                File.WriteAllText(_CredentialsFile, $"{username}|{password}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving credentials: {ex.Message}");
            }
        }
        private string _ReadCredentials()
        {
            string Content = "";
            if (File.Exists(_CredentialsFile))
            {
                try
                {
                    using (FileStream fs = new FileStream(_CredentialsFile, FileMode.Open, FileAccess.Read))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Content = sr.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading credentials: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No credentials file exists yet.");
            }
            return Content;
        }

        private bool _isUserNameExist()
        {
            return clsUser.isUserNameExist(txt_Username.Text);
        }
        private bool _ValidateForm()
        {
            bool isValid = false;
            if (_isUserNameExist())
            {
                _User1 = clsUser.FindUser(clsUser.GetUserIdByUserName(txt_Username.Text));

                if (_User1.Password == txt_Password.Text)
                {
                    if (_User1.isActive == true)
                    {
                        isValid = true;
                        Console.WriteLine( "hiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii");
                    }
                    else
                    {
                        MessageBox.Show("Your Account Has Been Deactivated , Please Contact Your Admin");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password ", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password ", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }

        private void _DeleteCredentails()
        {
            if (File.Exists(_CredentialsFile))
            {
                File.WriteAllText("user_credentials.txt", string.Empty);
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (_ValidateForm())
            {
                if (cb_RememberMe.Checked == true)
                {
                    _SaveCredentials(txt_Username.Text, txt_Password.Text);
                }
                else
                {
                    _DeleteCredentails();
                }
                //Form1 frm = new Form1();

                clsGlobalUserSettings.GlobalUserID=_User1.UserID; 
                clsGlobalUserSettings.GlobalUserName=_User1.UserName;
                this.DialogResult = DialogResult.OK;
               // frm.ShowDialog();
            }

        }
        private bool isFileEmpty(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length == 0;
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {

            cls_FormStyler.TitleStyle(lbl_Title_Login, "Login Into Your Account");


            if (!isFileEmpty(_CredentialsFile))
            {
                cb_RememberMe.Checked = true;
                string content = _ReadCredentials();
                string[] arrContent = content.Split(new char[] { '|' });

                txt_Username.Text = arrContent[0].Trim();
                txt_Password.Text = arrContent[1].Trim();
            }
            else
            {
                cb_RememberMe.Checked = false;
                txt_Password.Text = string.Empty;
                txt_Username.Text = string.Empty;
            }

        }
    }
}
