


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
		
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
		
		private string _Username;
		public string Username { 
		    get{
		        return _Username;
		    } 
		    set{
		        this.OnUsernameChanging(value);
                this.SendPropertyChanging();
                this._Username = value;
                this.SendPropertyChanged("Username");
                this.OnUsernameChanged();
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
		
        partial void OnDateOfBirthChanging(DateTime? value);
        partial void OnDateOfBirthChanged();
		
		private DateTime? _DateOfBirth;
		public DateTime? DateOfBirth { 
		    get{
		        return _DateOfBirth;
		    } 
		    set{
		        this.OnDateOfBirthChanging(value);
                this.SendPropertyChanging();
                this._DateOfBirth = value;
                this.SendPropertyChanged("DateOfBirth");
                this.OnDateOfBirthChanged();
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
		
        partial void OnProfilePictureChanging(string value);
        partial void OnProfilePictureChanged();
		
		private string _ProfilePicture;
		public string ProfilePicture { 
		    get{
		        return _ProfilePicture;
		    } 
		    set{
		        this.OnProfilePictureChanging(value);
                this.SendPropertyChanging();
                this._ProfilePicture = value;
                this.SendPropertyChanged("ProfilePicture");
                this.OnProfilePictureChanged();
		    }
		}
		
        partial void OnTimeZoneOffSetChanging(int value);
        partial void OnTimeZoneOffSetChanged();
		
		private int _TimeZoneOffSet;
		public int TimeZoneOffSet { 
		    get{
		        return _TimeZoneOffSet;
		    } 
		    set{
		        this.OnTimeZoneOffSetChanging(value);
                this.SendPropertyChanging();
                this._TimeZoneOffSet = value;
                this.SendPropertyChanged("TimeZoneOffSet");
                this.OnTimeZoneOffSetChanged();
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
	
}