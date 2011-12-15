


using System;
using System.ComponentModel;
using System.Linq;

namespace Armor.Data
{
    
    
    
    
    /// <summary>
    /// A class which represents the UserAuthenticationProfile table in the Armor Database.
    /// This class is queryable through ArmorDB.UserAuthenticationProfile 
    /// </summary>

	public partial class UserAuthenticationProfile: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserAuthenticationProfile(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
		
		private int _ID;
		public int ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnUserIDChanging(Guid value);
        partial void OnUserIDChanged();
		
		private Guid _UserID;
		public Guid UserID { 
		    get{
		        return _UserID;
		    } 
		    set{
		        this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._UserID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
		    }
		}
		
        partial void OnServiceChanging(string value);
        partial void OnServiceChanged();
		
		private string _Service;
		public string Service { 
		    get{
		        return _Service;
		    } 
		    set{
		        this.OnServiceChanging(value);
                this.SendPropertyChanging();
                this._Service = value;
                this.SendPropertyChanged("Service");
                this.OnServiceChanged();
		    }
		}
		
        partial void OnServiceUsernameChanging(string value);
        partial void OnServiceUsernameChanged();
		
		private string _ServiceUsername;
		public string ServiceUsername { 
		    get{
		        return _ServiceUsername;
		    } 
		    set{
		        this.OnServiceUsernameChanging(value);
                this.SendPropertyChanging();
                this._ServiceUsername = value;
                this.SendPropertyChanged("ServiceUsername");
                this.OnServiceUsernameChanged();
		    }
		}
		
        partial void OnTokenChanging(string value);
        partial void OnTokenChanged();
		
		private string _Token;
		public string Token { 
		    get{
		        return _Token;
		    } 
		    set{
		        this.OnTokenChanging(value);
                this.SendPropertyChanging();
                this._Token = value;
                this.SendPropertyChanged("Token");
                this.OnTokenChanged();
		    }
		}
		
        partial void OnTokenSecretChanging(string value);
        partial void OnTokenSecretChanged();
		
		private string _TokenSecret;
		public string TokenSecret { 
		    get{
		        return _TokenSecret;
		    } 
		    set{
		        this.OnTokenSecretChanging(value);
                this.SendPropertyChanging();
                this._TokenSecret = value;
                this.SendPropertyChanged("TokenSecret");
                this.OnTokenSecretChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<User> Users
        {
            get
            {
                  var db=new Armor.Data.ArmorDB();
                  return from items in db.Users
                       where items.ID == _UserID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the UserInRoles table in the Armor Database.
    /// This class is queryable through ArmorDB.UserInRole 
    /// </summary>

	public partial class UserInRole: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserInRole(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
		
		private int _ID;
		public int ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnUserIDChanging(Guid value);
        partial void OnUserIDChanged();
		
		private Guid _UserID;
		public Guid UserID { 
		    get{
		        return _UserID;
		    } 
		    set{
		        this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._UserID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
		    }
		}
		
        partial void OnRoleIDChanging(int value);
        partial void OnRoleIDChanged();
		
		private int _RoleID;
		public int RoleID { 
		    get{
		        return _RoleID;
		    } 
		    set{
		        this.OnRoleIDChanging(value);
                this.SendPropertyChanging();
                this._RoleID = value;
                this.SendPropertyChanged("RoleID");
                this.OnRoleIDChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<User> Users
        {
            get
            {
                  var db=new Armor.Data.ArmorDB();
                  return from items in db.Users
                       where items.ID == _UserID
                       select items;
            }
        }

        public IQueryable<Role> Roles
        {
            get
            {
                  var db=new Armor.Data.ArmorDB();
                  return from items in db.Roles
                       where items.ID == _RoleID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Roles table in the Armor Database.
    /// This class is queryable through ArmorDB.Role 
    /// </summary>

	public partial class Role: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Role(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
		
		private int _ID;
		public int ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnRoleXChanging(string value);
        partial void OnRoleXChanged();
		
		private string _RoleX;
		public string RoleX { 
		    get{
		        return _RoleX;
		    } 
		    set{
		        this.OnRoleXChanging(value);
                this.SendPropertyChanging();
                this._RoleX = value;
                this.SendPropertyChanged("RoleX");
                this.OnRoleXChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<UserInRole> UserInRoles
        {
            get
            {
                  var db=new Armor.Data.ArmorDB();
                  return from items in db.UserInRoles
                       where items.RoleID == _ID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the sysdiagrams table in the Armor Database.
    /// This class is queryable through ArmorDB.sysdiagram 
    /// </summary>

	public partial class sysdiagram: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public sysdiagram(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
		
		private string _name;
		public string name { 
		    get{
		        return _name;
		    } 
		    set{
		        this.OnnameChanging(value);
                this.SendPropertyChanging();
                this._name = value;
                this.SendPropertyChanged("name");
                this.OnnameChanged();
		    }
		}
		
        partial void Onprincipal_idChanging(int value);
        partial void Onprincipal_idChanged();
		
		private int _principal_id;
		public int principal_id { 
		    get{
		        return _principal_id;
		    } 
		    set{
		        this.Onprincipal_idChanging(value);
                this.SendPropertyChanging();
                this._principal_id = value;
                this.SendPropertyChanged("principal_id");
                this.Onprincipal_idChanged();
		    }
		}
		
        partial void Ondiagram_idChanging(int value);
        partial void Ondiagram_idChanged();
		
		private int _diagram_id;
		public int diagram_id { 
		    get{
		        return _diagram_id;
		    } 
		    set{
		        this.Ondiagram_idChanging(value);
                this.SendPropertyChanging();
                this._diagram_id = value;
                this.SendPropertyChanged("diagram_id");
                this.Ondiagram_idChanged();
		    }
		}
		
        partial void OnversionChanging(int? value);
        partial void OnversionChanged();
		
		private int? _version;
		public int? version { 
		    get{
		        return _version;
		    } 
		    set{
		        this.OnversionChanging(value);
                this.SendPropertyChanging();
                this._version = value;
                this.SendPropertyChanged("version");
                this.OnversionChanged();
		    }
		}
		
        partial void OndefinitionChanging(byte[] value);
        partial void OndefinitionChanged();
		
		private byte[] _definition;
		public byte[] definition { 
		    get{
		        return _definition;
		    } 
		    set{
		        this.OndefinitionChanging(value);
                this.SendPropertyChanging();
                this._definition = value;
                this.SendPropertyChanged("definition");
                this.OndefinitionChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the User table in the Armor Database.
    /// This class is queryable through ArmorDB.User 
    /// </summary>

	public partial class User: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public User(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIDChanging(Guid value);
        partial void OnIDChanged();
		
		private Guid _ID;
		public Guid ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime value);
        partial void OnCreatedDateChanged();
		
		private DateTime _CreatedDate;
		public DateTime CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnRoleIDChanging(int? value);
        partial void OnRoleIDChanged();
		
		private int? _RoleID;
		public int? RoleID { 
		    get{
		        return _RoleID;
		    } 
		    set{
		        this.OnRoleIDChanging(value);
                this.SendPropertyChanging();
                this._RoleID = value;
                this.SendPropertyChanged("RoleID");
                this.OnRoleIDChanged();
		    }
		}
		
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
		
		private string _Password;
		public string Password { 
		    get{
		        return _Password;
		    } 
		    set{
		        this.OnPasswordChanging(value);
                this.SendPropertyChanging();
                this._Password = value;
                this.SendPropertyChanged("Password");
                this.OnPasswordChanged();
		    }
		}
		
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
		
		private string _FirstName;
		public string FirstName { 
		    get{
		        return _FirstName;
		    } 
		    set{
		        this.OnFirstNameChanging(value);
                this.SendPropertyChanging();
                this._FirstName = value;
                this.SendPropertyChanged("FirstName");
                this.OnFirstNameChanged();
		    }
		}
		
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
		
		private string _LastName;
		public string LastName { 
		    get{
		        return _LastName;
		    } 
		    set{
		        this.OnLastNameChanging(value);
                this.SendPropertyChanging();
                this._LastName = value;
                this.SendPropertyChanged("LastName");
                this.OnLastNameChanged();
		    }
		}
		
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
		
		private string _EmailAddress;
		public string EmailAddress { 
		    get{
		        return _EmailAddress;
		    } 
		    set{
		        this.OnEmailAddressChanging(value);
                this.SendPropertyChanging();
                this._EmailAddress = value;
                this.SendPropertyChanged("EmailAddress");
                this.OnEmailAddressChanged();
		    }
		}
		
        partial void OnPhoneNumberChanging(string value);
        partial void OnPhoneNumberChanged();
		
		private string _PhoneNumber;
		public string PhoneNumber { 
		    get{
		        return _PhoneNumber;
		    } 
		    set{
		        this.OnPhoneNumberChanging(value);
                this.SendPropertyChanging();
                this._PhoneNumber = value;
                this.SendPropertyChanged("PhoneNumber");
                this.OnPhoneNumberChanged();
		    }
		}
		
        partial void OnFaxNumberChanging(string value);
        partial void OnFaxNumberChanged();
		
		private string _FaxNumber;
		public string FaxNumber { 
		    get{
		        return _FaxNumber;
		    } 
		    set{
		        this.OnFaxNumberChanging(value);
                this.SendPropertyChanging();
                this._FaxNumber = value;
                this.SendPropertyChanged("FaxNumber");
                this.OnFaxNumberChanged();
		    }
		}
		
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
		
		private string _Address;
		public string Address { 
		    get{
		        return _Address;
		    } 
		    set{
		        this.OnAddressChanging(value);
                this.SendPropertyChanging();
                this._Address = value;
                this.SendPropertyChanged("Address");
                this.OnAddressChanged();
		    }
		}
		
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
		
		private string _City;
		public string City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		
        partial void OnProvinceChanging(string value);
        partial void OnProvinceChanged();
		
		private string _Province;
		public string Province { 
		    get{
		        return _Province;
		    } 
		    set{
		        this.OnProvinceChanging(value);
                this.SendPropertyChanging();
                this._Province = value;
                this.SendPropertyChanged("Province");
                this.OnProvinceChanged();
		    }
		}
		
        partial void OnPostalCodeChanging(string value);
        partial void OnPostalCodeChanged();
		
		private string _PostalCode;
		public string PostalCode { 
		    get{
		        return _PostalCode;
		    } 
		    set{
		        this.OnPostalCodeChanging(value);
                this.SendPropertyChanging();
                this._PostalCode = value;
                this.SendPropertyChanged("PostalCode");
                this.OnPostalCodeChanged();
		    }
		}
		
        partial void OnGSTInformationChanging(string value);
        partial void OnGSTInformationChanged();
		
		private string _GSTInformation;
		public string GSTInformation { 
		    get{
		        return _GSTInformation;
		    } 
		    set{
		        this.OnGSTInformationChanging(value);
                this.SendPropertyChanging();
                this._GSTInformation = value;
                this.SendPropertyChanged("GSTInformation");
                this.OnGSTInformationChanged();
		    }
		}
		
        partial void OnForgotPasswordHashChanging(Guid? value);
        partial void OnForgotPasswordHashChanged();
		
		private Guid? _ForgotPasswordHash;
		public Guid? ForgotPasswordHash { 
		    get{
		        return _ForgotPasswordHash;
		    } 
		    set{
		        this.OnForgotPasswordHashChanging(value);
                this.SendPropertyChanging();
                this._ForgotPasswordHash = value;
                this.SendPropertyChanged("ForgotPasswordHash");
                this.OnForgotPasswordHashChanged();
		    }
		}
		
        partial void OnIsActiveChanging(bool value);
        partial void OnIsActiveChanged();
		
		private bool _IsActive;
		public bool IsActive { 
		    get{
		        return _IsActive;
		    } 
		    set{
		        this.OnIsActiveChanging(value);
                this.SendPropertyChanging();
                this._IsActive = value;
                this.SendPropertyChanged("IsActive");
                this.OnIsActiveChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<UserAuthenticationProfile> UserAuthenticationProfiles
        {
            get
            {
                  var db=new Armor.Data.ArmorDB();
                  return from items in db.UserAuthenticationProfiles
                       where items.UserID == _ID
                       select items;
            }
        }

        public IQueryable<UserInRole> UserInRoles
        {
            get
            {
                  var db=new Armor.Data.ArmorDB();
                  return from items in db.UserInRoles
                       where items.UserID == _ID
                       select items;
            }
        }

        public IQueryable<UserRole> UserRoles
        {
            get
            {
                  var db=new Armor.Data.ArmorDB();
                  return from items in db.UserRoles
                       where items.ID == _RoleID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProgramEvaluatorStage1 table in the Armor Database.
    /// This class is queryable through ArmorDB.ProgramEvaluatorStage1 
    /// </summary>

	public partial class ProgramEvaluatorStage1: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProgramEvaluatorStage1(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
		
		private int _ID;
		public int ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnUserIDChanging(Guid value);
        partial void OnUserIDChanged();
		
		private Guid _UserID;
		public Guid UserID { 
		    get{
		        return _UserID;
		    } 
		    set{
		        this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._UserID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
		    }
		}
		
        partial void OnDateTimeTakenUTCChanging(DateTime value);
        partial void OnDateTimeTakenUTCChanged();
		
		private DateTime _DateTimeTakenUTC;
		public DateTime DateTimeTakenUTC { 
		    get{
		        return _DateTimeTakenUTC;
		    } 
		    set{
		        this.OnDateTimeTakenUTCChanging(value);
                this.SendPropertyChanging();
                this._DateTimeTakenUTC = value;
                this.SendPropertyChanged("DateTimeTakenUTC");
                this.OnDateTimeTakenUTCChanged();
		    }
		}
		
        partial void OnQuestion1Changing(int? value);
        partial void OnQuestion1Changed();
		
		private int? _Question1;
		public int? Question1 { 
		    get{
		        return _Question1;
		    } 
		    set{
		        this.OnQuestion1Changing(value);
                this.SendPropertyChanging();
                this._Question1 = value;
                this.SendPropertyChanged("Question1");
                this.OnQuestion1Changed();
		    }
		}
		
        partial void OnQuestion2Changing(int? value);
        partial void OnQuestion2Changed();
		
		private int? _Question2;
		public int? Question2 { 
		    get{
		        return _Question2;
		    } 
		    set{
		        this.OnQuestion2Changing(value);
                this.SendPropertyChanging();
                this._Question2 = value;
                this.SendPropertyChanged("Question2");
                this.OnQuestion2Changed();
		    }
		}
		
        partial void OnQuestion3Changing(int? value);
        partial void OnQuestion3Changed();
		
		private int? _Question3;
		public int? Question3 { 
		    get{
		        return _Question3;
		    } 
		    set{
		        this.OnQuestion3Changing(value);
                this.SendPropertyChanging();
                this._Question3 = value;
                this.SendPropertyChanged("Question3");
                this.OnQuestion3Changed();
		    }
		}
		
        partial void OnQuestion4Changing(int? value);
        partial void OnQuestion4Changed();
		
		private int? _Question4;
		public int? Question4 { 
		    get{
		        return _Question4;
		    } 
		    set{
		        this.OnQuestion4Changing(value);
                this.SendPropertyChanging();
                this._Question4 = value;
                this.SendPropertyChanged("Question4");
                this.OnQuestion4Changed();
		    }
		}
		
        partial void OnQuestion5Changing(int? value);
        partial void OnQuestion5Changed();
		
		private int? _Question5;
		public int? Question5 { 
		    get{
		        return _Question5;
		    } 
		    set{
		        this.OnQuestion5Changing(value);
                this.SendPropertyChanging();
                this._Question5 = value;
                this.SendPropertyChanged("Question5");
                this.OnQuestion5Changed();
		    }
		}
		
        partial void OnQuestion6Changing(int? value);
        partial void OnQuestion6Changed();
		
		private int? _Question6;
		public int? Question6 { 
		    get{
		        return _Question6;
		    } 
		    set{
		        this.OnQuestion6Changing(value);
                this.SendPropertyChanging();
                this._Question6 = value;
                this.SendPropertyChanged("Question6");
                this.OnQuestion6Changed();
		    }
		}
		
        partial void OnQuestion7Changing(int? value);
        partial void OnQuestion7Changed();
		
		private int? _Question7;
		public int? Question7 { 
		    get{
		        return _Question7;
		    } 
		    set{
		        this.OnQuestion7Changing(value);
                this.SendPropertyChanging();
                this._Question7 = value;
                this.SendPropertyChanged("Question7");
                this.OnQuestion7Changed();
		    }
		}
		
        partial void OnQuestion8Changing(int? value);
        partial void OnQuestion8Changed();
		
		private int? _Question8;
		public int? Question8 { 
		    get{
		        return _Question8;
		    } 
		    set{
		        this.OnQuestion8Changing(value);
                this.SendPropertyChanging();
                this._Question8 = value;
                this.SendPropertyChanged("Question8");
                this.OnQuestion8Changed();
		    }
		}
		
        partial void OnQuestion9Changing(int? value);
        partial void OnQuestion9Changed();
		
		private int? _Question9;
		public int? Question9 { 
		    get{
		        return _Question9;
		    } 
		    set{
		        this.OnQuestion9Changing(value);
                this.SendPropertyChanging();
                this._Question9 = value;
                this.SendPropertyChanged("Question9");
                this.OnQuestion9Changed();
		    }
		}
		
        partial void OnQuestion10Changing(int? value);
        partial void OnQuestion10Changed();
		
		private int? _Question10;
		public int? Question10 { 
		    get{
		        return _Question10;
		    } 
		    set{
		        this.OnQuestion10Changing(value);
                this.SendPropertyChanging();
                this._Question10 = value;
                this.SendPropertyChanged("Question10");
                this.OnQuestion10Changed();
		    }
		}
		
        partial void OnQuestion11Changing(int? value);
        partial void OnQuestion11Changed();
		
		private int? _Question11;
		public int? Question11 { 
		    get{
		        return _Question11;
		    } 
		    set{
		        this.OnQuestion11Changing(value);
                this.SendPropertyChanging();
                this._Question11 = value;
                this.SendPropertyChanged("Question11");
                this.OnQuestion11Changed();
		    }
		}
		
        partial void OnQuestion12Changing(string value);
        partial void OnQuestion12Changed();
		
		private string _Question12;
		public string Question12 { 
		    get{
		        return _Question12;
		    } 
		    set{
		        this.OnQuestion12Changing(value);
                this.SendPropertyChanging();
                this._Question12 = value;
                this.SendPropertyChanged("Question12");
                this.OnQuestion12Changed();
		    }
		}
		
        partial void OnQuestion13Changing(string value);
        partial void OnQuestion13Changed();
		
		private string _Question13;
		public string Question13 { 
		    get{
		        return _Question13;
		    } 
		    set{
		        this.OnQuestion13Changing(value);
                this.SendPropertyChanging();
                this._Question13 = value;
                this.SendPropertyChanged("Question13");
                this.OnQuestion13Changed();
		    }
		}
		
        partial void OnQuestion14Changing(string value);
        partial void OnQuestion14Changed();
		
		private string _Question14;
		public string Question14 { 
		    get{
		        return _Question14;
		    } 
		    set{
		        this.OnQuestion14Changing(value);
                this.SendPropertyChanging();
                this._Question14 = value;
                this.SendPropertyChanged("Question14");
                this.OnQuestion14Changed();
		    }
		}
		
        partial void OnQuestion15Changing(string value);
        partial void OnQuestion15Changed();
		
		private string _Question15;
		public string Question15 { 
		    get{
		        return _Question15;
		    } 
		    set{
		        this.OnQuestion15Changing(value);
                this.SendPropertyChanging();
                this._Question15 = value;
                this.SendPropertyChanged("Question15");
                this.OnQuestion15Changed();
		    }
		}
		
        partial void OnQuestion16Changing(string value);
        partial void OnQuestion16Changed();
		
		private string _Question16;
		public string Question16 { 
		    get{
		        return _Question16;
		    } 
		    set{
		        this.OnQuestion16Changing(value);
                this.SendPropertyChanging();
                this._Question16 = value;
                this.SendPropertyChanged("Question16");
                this.OnQuestion16Changed();
		    }
		}
		
        partial void OnQuestion17Changing(string value);
        partial void OnQuestion17Changed();
		
		private string _Question17;
		public string Question17 { 
		    get{
		        return _Question17;
		    } 
		    set{
		        this.OnQuestion17Changing(value);
                this.SendPropertyChanging();
                this._Question17 = value;
                this.SendPropertyChanged("Question17");
                this.OnQuestion17Changed();
		    }
		}
		
        partial void OnQuestion18Changing(string value);
        partial void OnQuestion18Changed();
		
		private string _Question18;
		public string Question18 { 
		    get{
		        return _Question18;
		    } 
		    set{
		        this.OnQuestion18Changing(value);
                this.SendPropertyChanging();
                this._Question18 = value;
                this.SendPropertyChanged("Question18");
                this.OnQuestion18Changed();
		    }
		}
		
        partial void OnQuestion19Changing(string value);
        partial void OnQuestion19Changed();
		
		private string _Question19;
		public string Question19 { 
		    get{
		        return _Question19;
		    } 
		    set{
		        this.OnQuestion19Changing(value);
                this.SendPropertyChanging();
                this._Question19 = value;
                this.SendPropertyChanged("Question19");
                this.OnQuestion19Changed();
		    }
		}
		
        partial void OnQuestion20Changing(string value);
        partial void OnQuestion20Changed();
		
		private string _Question20;
		public string Question20 { 
		    get{
		        return _Question20;
		    } 
		    set{
		        this.OnQuestion20Changing(value);
                this.SendPropertyChanging();
                this._Question20 = value;
                this.SendPropertyChanged("Question20");
                this.OnQuestion20Changed();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the PatientAssessment table in the Armor Database.
    /// This class is queryable through ArmorDB.PatientAssessment 
    /// </summary>

	public partial class PatientAssessment: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public PatientAssessment(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
		
		private int _ID;
		public int ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnUserIDChanging(Guid value);
        partial void OnUserIDChanged();
		
		private Guid _UserID;
		public Guid UserID { 
		    get{
		        return _UserID;
		    } 
		    set{
		        this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._UserID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
		    }
		}
		
        partial void OnDateTimeTakenUTCChanging(DateTime value);
        partial void OnDateTimeTakenUTCChanged();
		
		private DateTime _DateTimeTakenUTC;
		public DateTime DateTimeTakenUTC { 
		    get{
		        return _DateTimeTakenUTC;
		    } 
		    set{
		        this.OnDateTimeTakenUTCChanging(value);
                this.SendPropertyChanging();
                this._DateTimeTakenUTC = value;
                this.SendPropertyChanged("DateTimeTakenUTC");
                this.OnDateTimeTakenUTCChanged();
		    }
		}
		
        partial void OnQuestion1Changing(string value);
        partial void OnQuestion1Changed();
		
		private string _Question1;
		public string Question1 { 
		    get{
		        return _Question1;
		    } 
		    set{
		        this.OnQuestion1Changing(value);
                this.SendPropertyChanging();
                this._Question1 = value;
                this.SendPropertyChanged("Question1");
                this.OnQuestion1Changed();
		    }
		}
		
        partial void OnQuestion2Changing(string value);
        partial void OnQuestion2Changed();
		
		private string _Question2;
		public string Question2 { 
		    get{
		        return _Question2;
		    } 
		    set{
		        this.OnQuestion2Changing(value);
                this.SendPropertyChanging();
                this._Question2 = value;
                this.SendPropertyChanged("Question2");
                this.OnQuestion2Changed();
		    }
		}
		
        partial void OnQuestion3Changing(string value);
        partial void OnQuestion3Changed();
		
		private string _Question3;
		public string Question3 { 
		    get{
		        return _Question3;
		    } 
		    set{
		        this.OnQuestion3Changing(value);
                this.SendPropertyChanging();
                this._Question3 = value;
                this.SendPropertyChanged("Question3");
                this.OnQuestion3Changed();
		    }
		}
		
        partial void OnQuestion4Changing(string value);
        partial void OnQuestion4Changed();
		
		private string _Question4;
		public string Question4 { 
		    get{
		        return _Question4;
		    } 
		    set{
		        this.OnQuestion4Changing(value);
                this.SendPropertyChanging();
                this._Question4 = value;
                this.SendPropertyChanged("Question4");
                this.OnQuestion4Changed();
		    }
		}
		
        partial void OnQuestion5Changing(string value);
        partial void OnQuestion5Changed();
		
		private string _Question5;
		public string Question5 { 
		    get{
		        return _Question5;
		    } 
		    set{
		        this.OnQuestion5Changing(value);
                this.SendPropertyChanging();
                this._Question5 = value;
                this.SendPropertyChanged("Question5");
                this.OnQuestion5Changed();
		    }
		}
		
        partial void OnQuestion6Changing(string value);
        partial void OnQuestion6Changed();
		
		private string _Question6;
		public string Question6 { 
		    get{
		        return _Question6;
		    } 
		    set{
		        this.OnQuestion6Changing(value);
                this.SendPropertyChanging();
                this._Question6 = value;
                this.SendPropertyChanged("Question6");
                this.OnQuestion6Changed();
		    }
		}
		
        partial void OnQuestion7Changing(string value);
        partial void OnQuestion7Changed();
		
		private string _Question7;
		public string Question7 { 
		    get{
		        return _Question7;
		    } 
		    set{
		        this.OnQuestion7Changing(value);
                this.SendPropertyChanging();
                this._Question7 = value;
                this.SendPropertyChanged("Question7");
                this.OnQuestion7Changed();
		    }
		}
		
        partial void OnQuestion8Changing(string value);
        partial void OnQuestion8Changed();
		
		private string _Question8;
		public string Question8 { 
		    get{
		        return _Question8;
		    } 
		    set{
		        this.OnQuestion8Changing(value);
                this.SendPropertyChanging();
                this._Question8 = value;
                this.SendPropertyChanged("Question8");
                this.OnQuestion8Changed();
		    }
		}
		
        partial void OnQuestion9Changing(string value);
        partial void OnQuestion9Changed();
		
		private string _Question9;
		public string Question9 { 
		    get{
		        return _Question9;
		    } 
		    set{
		        this.OnQuestion9Changing(value);
                this.SendPropertyChanging();
                this._Question9 = value;
                this.SendPropertyChanged("Question9");
                this.OnQuestion9Changed();
		    }
		}
		
        partial void OnQuestion10Changing(string value);
        partial void OnQuestion10Changed();
		
		private string _Question10;
		public string Question10 { 
		    get{
		        return _Question10;
		    } 
		    set{
		        this.OnQuestion10Changing(value);
                this.SendPropertyChanging();
                this._Question10 = value;
                this.SendPropertyChanged("Question10");
                this.OnQuestion10Changed();
		    }
		}
		
        partial void OnQuestion11Changing(string value);
        partial void OnQuestion11Changed();
		
		private string _Question11;
		public string Question11 { 
		    get{
		        return _Question11;
		    } 
		    set{
		        this.OnQuestion11Changing(value);
                this.SendPropertyChanging();
                this._Question11 = value;
                this.SendPropertyChanged("Question11");
                this.OnQuestion11Changed();
		    }
		}
		
        partial void OnQuestion12Changing(string value);
        partial void OnQuestion12Changed();
		
		private string _Question12;
		public string Question12 { 
		    get{
		        return _Question12;
		    } 
		    set{
		        this.OnQuestion12Changing(value);
                this.SendPropertyChanging();
                this._Question12 = value;
                this.SendPropertyChanged("Question12");
                this.OnQuestion12Changed();
		    }
		}
		
        partial void OnQuestion13Changing(string value);
        partial void OnQuestion13Changed();
		
		private string _Question13;
		public string Question13 { 
		    get{
		        return _Question13;
		    } 
		    set{
		        this.OnQuestion13Changing(value);
                this.SendPropertyChanging();
                this._Question13 = value;
                this.SendPropertyChanged("Question13");
                this.OnQuestion13Changed();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the UserRole table in the Armor Database.
    /// This class is queryable through ArmorDB.UserRole 
    /// </summary>

	public partial class UserRole: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserRole(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
		
		private int _ID;
		public int ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<User> Users
        {
            get
            {
                  var db=new Armor.Data.ArmorDB();
                  return from items in db.Users
                       where items.RoleID == _ID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
}