using DVLDBusinessLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrl_PersonInfo : UserControl
    {
        private int _personID;
        public int PersonID
        {
            get { return _personID; }
            set
            {
                _personID = value;
                LoadPersonInfo(); // Load person info whenever PersonID is set
            }
        }

        private clsPerson Person ;

        public ctrl_PersonInfo()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo()
        {
            if (_personID <= 0)
                return;

            Person = clsPerson.Find(_personID);
            if (Person != null)
            {
                lbl_PersonID_Value.Text = Person.ID.ToString();
                lbl_Name_Value.Text = $"{Person.FirstName} {Person.SecondName} {Person.ThirdName} {Person.LastName}";
                lbl_Gender_Value.Text = Person.Gender.ToString();
                lbl_Phone_Value.Text = Person.Phone;
                lbl_Email_Value.Text = Person.Email;

                lbl_Country_Value.Text = clsPerson.GetCountryNameByID(Person.NationalityCountryID);

                lbl_DateOfBirth_Value.Text = Person.DateOfBirth.ToString("yyyy-MM-dd");
                lbl_Address_Value.Text = Person.Address;
                lbl_NationalNo_Value.Text = Person.NationalNo;

                if (Person.ImagePath != null)
                {
                    using (FileStream fs = new FileStream(Person.ImagePath, FileMode.Open, FileAccess.Read))
                    {
                        pb_PersonInfo.Image = Image.FromStream(fs);
                    }
                }
            }
        }

        private void btn_UpdatePersonInfo_Click(object sender, EventArgs e)
        {
            if (Person == null)
            {
                MessageBox.Show("Please Select A Person","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                return;
            }

            frm_AddEditPerson form = new frm_AddEditPerson(Person.ID);
            form.DataBack += frm_AddEditUser_DataBack; //this is for the user form when updating the person we will need to refresh the person info 
            //// so this will do the trick 
            form.ShowDialog();
        }
        private void frm_AddEditUser_DataBack(object sender, int PersonID)
        {
            LoadPersonInfo();
        }
    }
}