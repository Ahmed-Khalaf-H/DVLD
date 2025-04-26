using DVLDDataAccessLayer;
using System;
using System.Data;

namespace DVLDBusinessLayer
{

    public class clsPerson
    {
        enum enMode { Add = 1, Edit = 2 }
        enMode Mode;
        public int ID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public string ImagePath { set; get; }
        public string NationalNo { set; get; }
        public int NationalityCountryID { set; get; }

        public DateTime DateOfBirth { set; get; }
        public byte Gender { set; get; }


        public clsPerson()
        {
            this.ID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.ImagePath = "";
            this.NationalNo = "";
            this.NationalityCountryID = 0;

            this.DateOfBirth = DateTime.Now;
            this.Gender = 0;

            Mode = enMode.Add;
        }

        private clsPerson(int ID, string FirstName, string SecondName, string ThirdName, string LastName, string Email, string Phone, string Address, string ImagePath, string NationalNo, int NationalityCountryID, DateTime DateOfBirth, byte Gender)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.ImagePath = ImagePath;
            this.NationalNo = NationalNo;
            this.NationalityCountryID = NationalityCountryID;

            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;

            Mode = enMode.Edit;
        }

        private bool _AddNewPerson()
        {
            this.ID = clsDVLDData.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Email, this.Phone,
                this.Address, this.ImagePath, this.NationalNo, this.NationalityCountryID, this.DateOfBirth, this.Gender);

            return (this.ID != -1);
        }
        private bool _UpdatePerson()
        {
            return clsDVLDData.UpdatePerson(this.ID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Email, this.Phone,
                this.Address, this.ImagePath, this.NationalNo, this.NationalityCountryID, this.DateOfBirth, this.Gender);

        }
        public static bool DeletePerson(int ID)
        {
            return clsDVLDData.DeletePerson(ID);

        }
        public static clsPerson Find(int ID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",
               Email = "", Phone = "", Address = "", ImagePath = "", NationalNo = "";

            int NationalityCountryID = 0;
            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;

            if (clsDVLDData.GetPersonInfoByID(ID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref Email, ref Phone, ref Address, ref ImagePath, ref NationalNo, ref NationalityCountryID, ref DateOfBirth, ref Gender))
            {
                return new clsPerson(ID, FirstName, SecondName, ThirdName, LastName, Email, Phone, Address, ImagePath, NationalNo, NationalityCountryID, DateOfBirth, Gender);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Edit;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Edit:
                    return _UpdatePerson();

            }
            return false;

        }


        public static DataTable GetAllPeople()
        {
            return clsDVLDData.GetAllPeople();
        }

        public static DataTable GetAllPeopleWithCountriesAndGenderNames()
        {
            return clsDVLDData.GetAllPeopleWithCountriesAndGenderNames();
        }
        public static DataTable GetAllCountries()
        {
            return clsDVLDData.GetAllCountries();
        }

        public static string GetCountryNameByID(int CountryID)
        {
            return clsDVLDData.GetCountryNameByID(CountryID);
        }


        public static bool isPersonExist(int ID)
        {
            return clsDVLDData.IsPersonExist(ID);
        }

        public static bool isPersonExistByNationalNo(string NationalNo)
        {
            return clsDVLDData.IsPersonExistByNationalNo(NationalNo);

        }
        public static bool isImagePathExist(string ImagePath)
        {
            return clsDVLDData.IsImagePathExist(ImagePath);
        }


        public static int GetPersonIDByNationalNo(string NationalNo)
        {
            return clsDVLDData.GetPersonIDByNationalNo(NationalNo);
        }

    }




    public class clsUser
    {
        enum enMode { Add = 1, Edit = 2 }
        enMode _Mode;
        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }

        public string Password { set; get; }

        public bool isActive { set; get; }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.isActive = false;

            _Mode = enMode.Add;
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool isActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.isActive = isActive;


            _Mode = enMode.Edit;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Edit;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Edit:
                    return _UpdateUser();

            }
            return false;

        }

        private bool _AddNewUser()
        {
            this.UserID = clsDVLDData_User.AddNewUser(this.PersonID, this.UserName, this.Password, this.isActive);
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsDVLDData_User.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.isActive);
        }
        public static bool DeleteUser(int UserID)
        {
            return clsDVLDData_User.DeleteUser(UserID);
        }
        public static clsUser FindUser(int UserID)
        {
            string UserName = "", Password = "";
            bool isActive = false;
            int PersonID = 0;

            if (clsDVLDData_User.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref isActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, isActive);
            }
            else
            {
                return null;
            }
        }
        public static bool isPersonAUser(int PersonID)
        {
            return clsDVLDData_User.IsPersonAUser(PersonID);

        }
        public static DataTable GetAllUsers()
        {
            return clsDVLDData_User.GetAllUsers();
        }
        public static bool isUserNameExist(string UserName)
        {
            return clsDVLDData_User.IsUserNameExist(UserName);
        }
        public static int GetUserIdByUserName(string UserName)
        {
            return clsDVLDData_User.GetUserIdByUserName(UserName);
        }
    }







    public class clsApplicationType
    {
        public int ApplicationTypeID { set; get; }
        public string ApplicationTypeTitle { set; get; }

        public decimal ApplicationFee { set; get; }

        private clsApplicationType(int applicationTypeID, string applicationTypeTitle, decimal applicationTypeFee)
        {
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeTitle = applicationTypeTitle;
            this.ApplicationFee = applicationTypeFee;
        }
        public static DataTable GetAllApplicationTypes()
        {
            return clsDVLDData_ApplicationTyps.GetAllApplicationTypes();
        }

        public static clsApplicationType FindApplicationTypeByID(int ID)
        {
            string ApplicationTypeTitel = "";
            decimal ApplicationTypeFee = 0;
            if (clsDVLDData_ApplicationTyps.GetApplicationTypeByID(ID, ref ApplicationTypeTitel, ref ApplicationTypeFee))
            {
                return new clsApplicationType(ID, ApplicationTypeTitel, ApplicationTypeFee);
            }
            else
            {
                return null;
            }
        }
        private bool _UpdateApplicationType()
        {
            return clsDVLDData_ApplicationTyps.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFee);
        }

        public bool Save()
        {
            if (_UpdateApplicationType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }








    public class clsTestTypes
    {
        public int TestTypesID { get; set; }
        public string TestTypesTitle { get; set; }
        public string TestTypeDiscription { get; set; }
        public decimal TestTypesFee { get; set; }

        private clsTestTypes(int testTypeID, string testTypeTitle, string testTypeDiscription, decimal testTypesFee)
        {
            this.TestTypesID = testTypeID;
            this.TestTypesTitle = testTypeTitle;
            this.TestTypeDiscription = testTypeDiscription;
            this.TestTypesFee = testTypesFee;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsDVLDData_ManageTestTypes.GetAllTestTypes();
        }
        public static clsTestTypes FindTestTypeByID(int ID)
        {
            string Title = "";
            string Discription = "";
            decimal Fee = 0;

            if (clsDVLDData_ManageTestTypes.GetTestTypeByID(ID, ref Title, ref Discription, ref Fee))
            {
                return new clsTestTypes(ID, Title, Discription, Fee);
            }
            else
            {
                return null;
            }

        }



        private bool _UpdateTestType()
        {
            return clsDVLDData_ManageTestTypes.UpdateTestType(this.TestTypesID, this.TestTypesTitle, this.TestTypeDiscription, this.TestTypesFee);
        }
        public bool Save()
        {
            if (_UpdateTestType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }



    public class clsApplications
    {
        enum enMode { Add = 1, Edit = 2 }
        enMode _Mode;
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public int ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public clsApplications()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.MinValue;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = -1;
            this.LastStatusDate = DateTime.MinValue;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;

            _Mode = enMode.Add;

        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsDVLDData_Applications.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return (this.ApplicationID != -1);

        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewApplication())
                    {
                        // _Mode = enMode.Edit;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                    //case enMode.Edit:
                    //    return _UpdateUser();

            }
            return false;

        }
        public static bool hasActiveApplication(int ApplicantPersonID, int ApplicationTypeID , int LicenseClassID)
        {
            return clsDVLDData_Applications.hasActiveApplication(ApplicantPersonID, ApplicationTypeID , LicenseClassID);
        }
        public static DataTable GetAllApplications()
        {
            return clsDVLDData_Applications.GetAllApplications();
        }

        public static DataTable GetAllLicenseClassesNames()
        {
            return clsDVLDData_Applications.GetAllLicenseClassesNames();
        }

    }


    public class clsLocalDrivingLicenseApplication
    {
        public int LocalApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplication()
        {
            this.LocalApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
        }
        private int _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalApplicationID = clsDVLDData_LocalDrivingLicenseApplication.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);
            return this.LocalApplicationID; //(this.LocalApplicationID != -1);
        }

        public bool Save()
        {
            if (_AddNewLocalDrivingLicenseApplication() != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class clsTestAppointment
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public short isLocked { get; set; }


        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this
                .TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = new DateTime();
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.isLocked = 0;

        }


        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsDVLDData_Appointments.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.isLocked);
            return (this.TestAppointmentID != -1);

        }

        public bool Save()
        {
            if (_AddNewTestAppointment())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

