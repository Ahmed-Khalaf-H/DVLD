using DVLD.Properties;
using DVLDBusinessLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace DVLD
{
    public partial class frm_AddEditPerson : Form
    {
        private bool _isImageChanged = false;
        private enum enMode { Add = 0, Edit = 1 };
        //public enum Gender { Male = 0, Female = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPerson _Person1;

        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;
        public frm_AddEditPerson(int ID)
        {
            InitializeComponent();

            _PersonID = ID;
            if (_PersonID == -1)
                _Mode = enMode.Add;
            else
                _Mode = enMode.Edit;

        }

        private void frm_AddEditPerson_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl__Title_AddNewPerson, "Add New Person");

            _LoadData();
        }
        private void _LoadData()
        {
            _MinDateInDatePicker();
            _CountriesNamesInTheComboBox();
            if (_Mode == enMode.Add)
            {
                lbl__Title_AddNewPerson.Text = "Add New Person";
                _Person1 = new clsPerson();
                _isImageChanged = false;
                return;
            }

            _Person1 = clsPerson.Find(_PersonID);
            if (_Person1 == null)
            {
                MessageBox.Show("this will be closed becuase no perosn is there");
                return;
            }
            lbl__Title_AddNewPerson.Text = "Updating Person Information ID =" + _PersonID;
            lbl_PersonIDNumber.Text = _PersonID.ToString();
            txt_FirstName.Text = _Person1.FirstName;
            txt_SecondName.Text = _Person1.SecondName;
            txt_ThirdName.Text = _Person1.ThirdName;
            txt_LastName.Text = _Person1.LastName;
            txt_NationalNo.Text = _Person1.NationalNo;
            txt_PhoneNumber.Text = _Person1.Phone;
            txt_Email.Text = _Person1.Email;
            txt_Adress.Text = _Person1.Address;

            if (_Person1.ImagePath != null)
            {
                using (FileStream fs = new FileStream(_Person1.ImagePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }
                   // pictureBox1.Load(_Person1.ImagePath);
                _isImageChanged = false;
            }

            dtp_DateOfBirth.Value = _Person1.DateOfBirth;


            if (_Person1.Gender == 1)
            {
                rb_Female.Checked = true;
            }
            else
            {
                rb_Male.Checked = true; 
            }

            cb_Countries.SelectedIndex = _Person1.NationalityCountryID - 1;


        }

        private void _CountriesNamesInTheComboBox()
        {
            cb_Countries.DataSource = clsPerson.GetAllCountries();
            cb_Countries.DisplayMember = "CountryName"; // this linecan specify which column to show in the combobox in the data table 
            cb_Countries.SelectedIndex = 89;
        }

        private void _MinDateInDatePicker()
        {
            dtp_DateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
        }

        private string _CopyImageToNewPath()
        {
            if (string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                MessageBox.Show("No image selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                Guid guidNum = Guid.NewGuid();

                string destinationDirectory = "C:\\ImagesFromDVLD\\";
                string extension = Path.GetExtension(openFileDialog1.FileName);
                string destinationPath = Path.Combine(destinationDirectory, $"{guidNum}{extension}");

                if (!Directory.Exists(destinationDirectory))
                    Directory.CreateDirectory(destinationDirectory);




                File.Copy(openFileDialog1.FileName, destinationPath);

                return destinationPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to copy image: {ex.Message}",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        private bool _isControlEmpty(Control control, string Message)
        {
            if (control.Text == string.Empty)
            {
                errorProvider1.SetError(control, Message);
                return true;
            }
            else
            {
                errorProvider1.SetError(control, "");
                return false;
            }
        }
        private bool ValidateForm()
        {
            bool isValid = true;

            if (_isControlEmpty(txt_NationalNo, "National Number is required."))
            {
                isValid = false;
            }
            else if (clsPerson.isPersonExistByNationalNo(txt_NationalNo.Text))
            {
                if (_Mode == enMode.Add)
                {
                    errorProvider1.SetError(txt_NationalNo, "This National Number already exists.");
                    isValid = false;
                }

            }
            else
            {
                errorProvider1.SetError(txt_NationalNo, "");
            }


            if (_isControlEmpty(txt_PhoneNumber, "Phone Number Is Required."))
            {
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txt_PhoneNumber, "");
            }


            if (_isControlEmpty(txt_Adress, "The Address Is Required."))
            {
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txt_Adress, "");
            }


            if (!rb_Female.Checked && !rb_Male.Checked)
            {
                errorProvider1.SetError(rb_Female, "Please Select Gender");

                isValid = false;
            }
            else
            {
                errorProvider1.SetError(rb_Female, "");
            }


            if (txt_Email.Text != string.Empty)
            {
                if (!txt_Email.Text.EndsWith(".com") || !txt_Email.Text.Contains("@"))
                {
                    errorProvider1.SetError(txt_Email, "Enter a valid email address.");
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(txt_Email, "");
                }
            }



            return isValid;
        }



        private void rb_GenderChange(object sender, EventArgs e)
        {
            if (_Mode == enMode.Edit)
            {
                _isImageChanged = true;
            }
            if (!_isImageChanged)
            {
                if (rb_Female.Checked)
                {
                    pictureBox1.Image = Resources.Female_512;
                }
                else
                {
                    pictureBox1.Image = Resources.Male_512;
                }
            }

        }

        private void btn_SetImage_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();    
                }
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                { //// this is used to unlock the image ( prevent memory leaks ) which happen when trying to delete the image it will stay
                    //// used by another process ,this way (FileStream) will saave the image in the memory and not lock it 
                    //// NOTE: we will need to dispos it later 
                    pictureBox1.Image = Image.FromStream(fs);
                }
               // pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                _isImageChanged = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.Add && !_isImageChanged)
            {
                MessageBox.Show("Please select an image.", "Image Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newImagePath = null;
            if (_isImageChanged && openFileDialog1.FileName != string.Empty)
            {
                newImagePath = _CopyImageToNewPath();
                if (newImagePath == null)
                {
                    // If image copying fails, do not proceed with saving
                    return;
                }
            }
            if (_Mode == enMode.Edit && !string.IsNullOrEmpty(_Person1.ImagePath)&& _isImageChanged)
            {
                try
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                       // pictureBox1.Image = null;
                    }
                    File.Delete(_Person1.ImagePath);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete old image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ;
                }

            }

            _Person1.FirstName = txt_FirstName.Text;
            _Person1.SecondName = txt_SecondName.Text;
            _Person1.ThirdName = txt_ThirdName.Text;
            _Person1.LastName = txt_LastName.Text;
            _Person1.Email = txt_Email.Text;
            _Person1.Phone = txt_PhoneNumber.Text;
            _Person1.Address = txt_Adress.Text;
            _Person1.DateOfBirth = dtp_DateOfBirth.Value;
            _Person1.NationalityCountryID = cb_Countries.SelectedIndex + 1;


            if (newImagePath != null)
            {
                _Person1.ImagePath = newImagePath;
            }


            _Person1.Gender = (byte)(rb_Female.Checked ? 1 : 0);
            _Person1.NationalNo = txt_NationalNo.Text;

            if (_Person1.Save())
            {
                MessageBox.Show("The record was added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Failed to save the record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _Mode = enMode.Edit;
            lbl__Title_AddNewPerson.Text = "Updating Person Information ID =" + _Person1.ID;
            lbl_PersonIDNumber.Text = _Person1.ID.ToString();



            DataBack?.Invoke(this, _Person1.ID); // to return the PersonID to the AddUser Form

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
