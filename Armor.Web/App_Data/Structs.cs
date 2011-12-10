


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace Armor.Data {
	
        /// <summary>
        /// Table: UserAuthenticationProfile
        /// Primary Key: ID
        /// </summary>

        public class UserAuthenticationProfileTable: DatabaseTable {
            
            public UserAuthenticationProfileTable(IDataProvider provider):base("UserAuthenticationProfile",provider){
                ClassName = "UserAuthenticationProfile";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Service", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("ServiceUsername", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Token", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("TokenSecret", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });
                    
                
                
            }
            
            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
            				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn Service{
                get{
                    return this.GetColumn("Service");
                }
            }
            				
   			public static string ServiceColumn{
			      get{
        			return "Service";
      			}
		    }
           
            public IColumn ServiceUsername{
                get{
                    return this.GetColumn("ServiceUsername");
                }
            }
            				
   			public static string ServiceUsernameColumn{
			      get{
        			return "ServiceUsername";
      			}
		    }
           
            public IColumn Token{
                get{
                    return this.GetColumn("Token");
                }
            }
            				
   			public static string TokenColumn{
			      get{
        			return "Token";
      			}
		    }
           
            public IColumn TokenSecret{
                get{
                    return this.GetColumn("TokenSecret");
                }
            }
            				
   			public static string TokenSecretColumn{
			      get{
        			return "TokenSecret";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserInRoles
        /// Primary Key: ID
        /// </summary>

        public class UserInRolesTable: DatabaseTable {
            
            public UserInRolesTable(IDataProvider provider):base("UserInRoles",provider){
                ClassName = "UserInRole";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RoleID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
            				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn RoleID{
                get{
                    return this.GetColumn("RoleID");
                }
            }
            				
   			public static string RoleIDColumn{
			      get{
        			return "RoleID";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Roles
        /// Primary Key: ID
        /// </summary>

        public class RolesTable: DatabaseTable {
            
            public RolesTable(IDataProvider provider):base("Roles",provider){
                ClassName = "Role";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Role", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }
            
            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
            				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
           
            public IColumn Role{
                get{
                    return this.GetColumn("Role");
                }
            }
            				
   			public static string RoleColumn{
			      get{
        			return "Role";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserRole
        /// Primary Key: ID
        /// </summary>

        public class UserRoleTable: DatabaseTable {
            
            public UserRoleTable(IDataProvider provider):base("UserRole",provider){
                ClassName = "UserRole";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });
                    
                
                
            }
            
            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
            				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: User
        /// Primary Key: ID
        /// </summary>

        public class UserTable: DatabaseTable {
            
            public UserTable(IDataProvider provider):base("User",provider){
                ClassName = "User";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RoleID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Username", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("FirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("LastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("EmailAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DateOfBirth", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ForgotPasswordHash", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProfilePicture", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("TimeZoneOffSet", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsActive", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
            				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
           
            public IColumn RoleID{
                get{
                    return this.GetColumn("RoleID");
                }
            }
            				
   			public static string RoleIDColumn{
			      get{
        			return "RoleID";
      			}
		    }
           
            public IColumn Username{
                get{
                    return this.GetColumn("Username");
                }
            }
            				
   			public static string UsernameColumn{
			      get{
        			return "Username";
      			}
		    }
           
            public IColumn Password{
                get{
                    return this.GetColumn("Password");
                }
            }
            				
   			public static string PasswordColumn{
			      get{
        			return "Password";
      			}
		    }
           
            public IColumn FirstName{
                get{
                    return this.GetColumn("FirstName");
                }
            }
            				
   			public static string FirstNameColumn{
			      get{
        			return "FirstName";
      			}
		    }
           
            public IColumn LastName{
                get{
                    return this.GetColumn("LastName");
                }
            }
            				
   			public static string LastNameColumn{
			      get{
        			return "LastName";
      			}
		    }
           
            public IColumn EmailAddress{
                get{
                    return this.GetColumn("EmailAddress");
                }
            }
            				
   			public static string EmailAddressColumn{
			      get{
        			return "EmailAddress";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn DateOfBirth{
                get{
                    return this.GetColumn("DateOfBirth");
                }
            }
            				
   			public static string DateOfBirthColumn{
			      get{
        			return "DateOfBirth";
      			}
		    }
           
            public IColumn ForgotPasswordHash{
                get{
                    return this.GetColumn("ForgotPasswordHash");
                }
            }
            				
   			public static string ForgotPasswordHashColumn{
			      get{
        			return "ForgotPasswordHash";
      			}
		    }
           
            public IColumn ProfilePicture{
                get{
                    return this.GetColumn("ProfilePicture");
                }
            }
            				
   			public static string ProfilePictureColumn{
			      get{
        			return "ProfilePicture";
      			}
		    }
           
            public IColumn TimeZoneOffSet{
                get{
                    return this.GetColumn("TimeZoneOffSet");
                }
            }
            				
   			public static string TimeZoneOffSetColumn{
			      get{
        			return "TimeZoneOffSet";
      			}
		    }
           
            public IColumn IsActive{
                get{
                    return this.GetColumn("IsActive");
                }
            }
            				
   			public static string IsActiveColumn{
			      get{
        			return "IsActive";
      			}
		    }
           
                    
        }
        
}