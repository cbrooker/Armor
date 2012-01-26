


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

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RoleID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
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

                Columns.Add(new DatabaseColumn("PhoneNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("FaxNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("Address", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Province", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("PostalCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("GSTInformation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
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
           
            public IColumn PhoneNumber{
                get{
                    return this.GetColumn("PhoneNumber");
                }
            }
            				
   			public static string PhoneNumberColumn{
			      get{
        			return "PhoneNumber";
      			}
		    }
           
            public IColumn FaxNumber{
                get{
                    return this.GetColumn("FaxNumber");
                }
            }
            				
   			public static string FaxNumberColumn{
			      get{
        			return "FaxNumber";
      			}
		    }
           
            public IColumn Address{
                get{
                    return this.GetColumn("Address");
                }
            }
            				
   			public static string AddressColumn{
			      get{
        			return "Address";
      			}
		    }
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
           
            public IColumn Province{
                get{
                    return this.GetColumn("Province");
                }
            }
            				
   			public static string ProvinceColumn{
			      get{
        			return "Province";
      			}
		    }
           
            public IColumn PostalCode{
                get{
                    return this.GetColumn("PostalCode");
                }
            }
            				
   			public static string PostalCodeColumn{
			      get{
        			return "PostalCode";
      			}
		    }
           
            public IColumn GSTInformation{
                get{
                    return this.GetColumn("GSTInformation");
                }
            }
            				
   			public static string GSTInformationColumn{
			      get{
        			return "GSTInformation";
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
        
        /// <summary>
        /// Table: ProgramEvaluatorStage1
        /// Primary Key: ID
        /// </summary>

        public class ProgramEvaluatorStage1Table: DatabaseTable {
            
            public ProgramEvaluatorStage1Table(IDataProvider provider):base("ProgramEvaluatorStage1",provider){
                ClassName = "ProgramEvaluatorStage1";
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
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DateTimeTakenUTC", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question3", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question4", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question5", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question6", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question7", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question8", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question9", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question10", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question11", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question12", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question13", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question14", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question15", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question16", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question17", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question18", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question19", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question20", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
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
           
            public IColumn DateTimeTakenUTC{
                get{
                    return this.GetColumn("DateTimeTakenUTC");
                }
            }
            				
   			public static string DateTimeTakenUTCColumn{
			      get{
        			return "DateTimeTakenUTC";
      			}
		    }
           
            public IColumn Question1{
                get{
                    return this.GetColumn("Question1");
                }
            }
            				
   			public static string Question1Column{
			      get{
        			return "Question1";
      			}
		    }
           
            public IColumn Question2{
                get{
                    return this.GetColumn("Question2");
                }
            }
            				
   			public static string Question2Column{
			      get{
        			return "Question2";
      			}
		    }
           
            public IColumn Question3{
                get{
                    return this.GetColumn("Question3");
                }
            }
            				
   			public static string Question3Column{
			      get{
        			return "Question3";
      			}
		    }
           
            public IColumn Question4{
                get{
                    return this.GetColumn("Question4");
                }
            }
            				
   			public static string Question4Column{
			      get{
        			return "Question4";
      			}
		    }
           
            public IColumn Question5{
                get{
                    return this.GetColumn("Question5");
                }
            }
            				
   			public static string Question5Column{
			      get{
        			return "Question5";
      			}
		    }
           
            public IColumn Question6{
                get{
                    return this.GetColumn("Question6");
                }
            }
            				
   			public static string Question6Column{
			      get{
        			return "Question6";
      			}
		    }
           
            public IColumn Question7{
                get{
                    return this.GetColumn("Question7");
                }
            }
            				
   			public static string Question7Column{
			      get{
        			return "Question7";
      			}
		    }
           
            public IColumn Question8{
                get{
                    return this.GetColumn("Question8");
                }
            }
            				
   			public static string Question8Column{
			      get{
        			return "Question8";
      			}
		    }
           
            public IColumn Question9{
                get{
                    return this.GetColumn("Question9");
                }
            }
            				
   			public static string Question9Column{
			      get{
        			return "Question9";
      			}
		    }
           
            public IColumn Question10{
                get{
                    return this.GetColumn("Question10");
                }
            }
            				
   			public static string Question10Column{
			      get{
        			return "Question10";
      			}
		    }
           
            public IColumn Question11{
                get{
                    return this.GetColumn("Question11");
                }
            }
            				
   			public static string Question11Column{
			      get{
        			return "Question11";
      			}
		    }
           
            public IColumn Question12{
                get{
                    return this.GetColumn("Question12");
                }
            }
            				
   			public static string Question12Column{
			      get{
        			return "Question12";
      			}
		    }
           
            public IColumn Question13{
                get{
                    return this.GetColumn("Question13");
                }
            }
            				
   			public static string Question13Column{
			      get{
        			return "Question13";
      			}
		    }
           
            public IColumn Question14{
                get{
                    return this.GetColumn("Question14");
                }
            }
            				
   			public static string Question14Column{
			      get{
        			return "Question14";
      			}
		    }
           
            public IColumn Question15{
                get{
                    return this.GetColumn("Question15");
                }
            }
            				
   			public static string Question15Column{
			      get{
        			return "Question15";
      			}
		    }
           
            public IColumn Question16{
                get{
                    return this.GetColumn("Question16");
                }
            }
            				
   			public static string Question16Column{
			      get{
        			return "Question16";
      			}
		    }
           
            public IColumn Question17{
                get{
                    return this.GetColumn("Question17");
                }
            }
            				
   			public static string Question17Column{
			      get{
        			return "Question17";
      			}
		    }
           
            public IColumn Question18{
                get{
                    return this.GetColumn("Question18");
                }
            }
            				
   			public static string Question18Column{
			      get{
        			return "Question18";
      			}
		    }
           
            public IColumn Question19{
                get{
                    return this.GetColumn("Question19");
                }
            }
            				
   			public static string Question19Column{
			      get{
        			return "Question19";
      			}
		    }
           
            public IColumn Question20{
                get{
                    return this.GetColumn("Question20");
                }
            }
            				
   			public static string Question20Column{
			      get{
        			return "Question20";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: PatientAssessment
        /// Primary Key: ID
        /// </summary>

        public class PatientAssessmentTable: DatabaseTable {
            
            public PatientAssessmentTable(IDataProvider provider):base("PatientAssessment",provider){
                ClassName = "PatientAssessment";
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
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DateTimeTakenUTC", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question3", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question4", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question5", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question6", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question7", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question8", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question9", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("Question10", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question11", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question12", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question13", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
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
           
            public IColumn DateTimeTakenUTC{
                get{
                    return this.GetColumn("DateTimeTakenUTC");
                }
            }
            				
   			public static string DateTimeTakenUTCColumn{
			      get{
        			return "DateTimeTakenUTC";
      			}
		    }
           
            public IColumn Question1{
                get{
                    return this.GetColumn("Question1");
                }
            }
            				
   			public static string Question1Column{
			      get{
        			return "Question1";
      			}
		    }
           
            public IColumn Question2{
                get{
                    return this.GetColumn("Question2");
                }
            }
            				
   			public static string Question2Column{
			      get{
        			return "Question2";
      			}
		    }
           
            public IColumn Question3{
                get{
                    return this.GetColumn("Question3");
                }
            }
            				
   			public static string Question3Column{
			      get{
        			return "Question3";
      			}
		    }
           
            public IColumn Question4{
                get{
                    return this.GetColumn("Question4");
                }
            }
            				
   			public static string Question4Column{
			      get{
        			return "Question4";
      			}
		    }
           
            public IColumn Question5{
                get{
                    return this.GetColumn("Question5");
                }
            }
            				
   			public static string Question5Column{
			      get{
        			return "Question5";
      			}
		    }
           
            public IColumn Question6{
                get{
                    return this.GetColumn("Question6");
                }
            }
            				
   			public static string Question6Column{
			      get{
        			return "Question6";
      			}
		    }
           
            public IColumn Question7{
                get{
                    return this.GetColumn("Question7");
                }
            }
            				
   			public static string Question7Column{
			      get{
        			return "Question7";
      			}
		    }
           
            public IColumn Question8{
                get{
                    return this.GetColumn("Question8");
                }
            }
            				
   			public static string Question8Column{
			      get{
        			return "Question8";
      			}
		    }
           
            public IColumn Question9{
                get{
                    return this.GetColumn("Question9");
                }
            }
            				
   			public static string Question9Column{
			      get{
        			return "Question9";
      			}
		    }
           
            public IColumn Question10{
                get{
                    return this.GetColumn("Question10");
                }
            }
            				
   			public static string Question10Column{
			      get{
        			return "Question10";
      			}
		    }
           
            public IColumn Question11{
                get{
                    return this.GetColumn("Question11");
                }
            }
            				
   			public static string Question11Column{
			      get{
        			return "Question11";
      			}
		    }
           
            public IColumn Question12{
                get{
                    return this.GetColumn("Question12");
                }
            }
            				
   			public static string Question12Column{
			      get{
        			return "Question12";
      			}
		    }
           
            public IColumn Question13{
                get{
                    return this.GetColumn("Question13");
                }
            }
            				
   			public static string Question13Column{
			      get{
        			return "Question13";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: PreAssessment
        /// Primary Key: ID
        /// </summary>

        public class PreAssessmentTable: DatabaseTable {
            
            public PreAssessmentTable(IDataProvider provider):base("PreAssessment",provider){
                ClassName = "PreAssessment";
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
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DateTimeTakenUTC", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question3", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question4", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question5", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question6", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question7", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question8", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question9", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Question10", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Question11", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question12", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
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
           
            public IColumn DateTimeTakenUTC{
                get{
                    return this.GetColumn("DateTimeTakenUTC");
                }
            }
            				
   			public static string DateTimeTakenUTCColumn{
			      get{
        			return "DateTimeTakenUTC";
      			}
		    }
           
            public IColumn Question1{
                get{
                    return this.GetColumn("Question1");
                }
            }
            				
   			public static string Question1Column{
			      get{
        			return "Question1";
      			}
		    }
           
            public IColumn Question2{
                get{
                    return this.GetColumn("Question2");
                }
            }
            				
   			public static string Question2Column{
			      get{
        			return "Question2";
      			}
		    }
           
            public IColumn Question3{
                get{
                    return this.GetColumn("Question3");
                }
            }
            				
   			public static string Question3Column{
			      get{
        			return "Question3";
      			}
		    }
           
            public IColumn Question4{
                get{
                    return this.GetColumn("Question4");
                }
            }
            				
   			public static string Question4Column{
			      get{
        			return "Question4";
      			}
		    }
           
            public IColumn Question5{
                get{
                    return this.GetColumn("Question5");
                }
            }
            				
   			public static string Question5Column{
			      get{
        			return "Question5";
      			}
		    }
           
            public IColumn Question6{
                get{
                    return this.GetColumn("Question6");
                }
            }
            				
   			public static string Question6Column{
			      get{
        			return "Question6";
      			}
		    }
           
            public IColumn Question7{
                get{
                    return this.GetColumn("Question7");
                }
            }
            				
   			public static string Question7Column{
			      get{
        			return "Question7";
      			}
		    }
           
            public IColumn Question8{
                get{
                    return this.GetColumn("Question8");
                }
            }
            				
   			public static string Question8Column{
			      get{
        			return "Question8";
      			}
		    }
           
            public IColumn Question9{
                get{
                    return this.GetColumn("Question9");
                }
            }
            				
   			public static string Question9Column{
			      get{
        			return "Question9";
      			}
		    }
           
            public IColumn Question10{
                get{
                    return this.GetColumn("Question10");
                }
            }
            				
   			public static string Question10Column{
			      get{
        			return "Question10";
      			}
		    }
           
            public IColumn Question11{
                get{
                    return this.GetColumn("Question11");
                }
            }
            				
   			public static string Question11Column{
			      get{
        			return "Question11";
      			}
		    }
           
            public IColumn Question12{
                get{
                    return this.GetColumn("Question12");
                }
            }
            				
   			public static string Question12Column{
			      get{
        			return "Question12";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProgramEvaluatorStage2
        /// Primary Key: ID
        /// </summary>

        public class ProgramEvaluatorStage2Table: DatabaseTable {
            
            public ProgramEvaluatorStage2Table(IDataProvider provider):base("ProgramEvaluatorStage2",provider){
                ClassName = "ProgramEvaluatorStage2";
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
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DateTimeTakenUTC", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question3", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question4", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question5", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question6", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question7", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question8", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question9", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question10", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question11", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question12", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question13", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question14", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question15", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question16", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question17", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question18", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question19", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question20", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
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
           
            public IColumn DateTimeTakenUTC{
                get{
                    return this.GetColumn("DateTimeTakenUTC");
                }
            }
            				
   			public static string DateTimeTakenUTCColumn{
			      get{
        			return "DateTimeTakenUTC";
      			}
		    }
           
            public IColumn Question1{
                get{
                    return this.GetColumn("Question1");
                }
            }
            				
   			public static string Question1Column{
			      get{
        			return "Question1";
      			}
		    }
           
            public IColumn Question2{
                get{
                    return this.GetColumn("Question2");
                }
            }
            				
   			public static string Question2Column{
			      get{
        			return "Question2";
      			}
		    }
           
            public IColumn Question3{
                get{
                    return this.GetColumn("Question3");
                }
            }
            				
   			public static string Question3Column{
			      get{
        			return "Question3";
      			}
		    }
           
            public IColumn Question4{
                get{
                    return this.GetColumn("Question4");
                }
            }
            				
   			public static string Question4Column{
			      get{
        			return "Question4";
      			}
		    }
           
            public IColumn Question5{
                get{
                    return this.GetColumn("Question5");
                }
            }
            				
   			public static string Question5Column{
			      get{
        			return "Question5";
      			}
		    }
           
            public IColumn Question6{
                get{
                    return this.GetColumn("Question6");
                }
            }
            				
   			public static string Question6Column{
			      get{
        			return "Question6";
      			}
		    }
           
            public IColumn Question7{
                get{
                    return this.GetColumn("Question7");
                }
            }
            				
   			public static string Question7Column{
			      get{
        			return "Question7";
      			}
		    }
           
            public IColumn Question8{
                get{
                    return this.GetColumn("Question8");
                }
            }
            				
   			public static string Question8Column{
			      get{
        			return "Question8";
      			}
		    }
           
            public IColumn Question9{
                get{
                    return this.GetColumn("Question9");
                }
            }
            				
   			public static string Question9Column{
			      get{
        			return "Question9";
      			}
		    }
           
            public IColumn Question10{
                get{
                    return this.GetColumn("Question10");
                }
            }
            				
   			public static string Question10Column{
			      get{
        			return "Question10";
      			}
		    }
           
            public IColumn Question11{
                get{
                    return this.GetColumn("Question11");
                }
            }
            				
   			public static string Question11Column{
			      get{
        			return "Question11";
      			}
		    }
           
            public IColumn Question12{
                get{
                    return this.GetColumn("Question12");
                }
            }
            				
   			public static string Question12Column{
			      get{
        			return "Question12";
      			}
		    }
           
            public IColumn Question13{
                get{
                    return this.GetColumn("Question13");
                }
            }
            				
   			public static string Question13Column{
			      get{
        			return "Question13";
      			}
		    }
           
            public IColumn Question14{
                get{
                    return this.GetColumn("Question14");
                }
            }
            				
   			public static string Question14Column{
			      get{
        			return "Question14";
      			}
		    }
           
            public IColumn Question15{
                get{
                    return this.GetColumn("Question15");
                }
            }
            				
   			public static string Question15Column{
			      get{
        			return "Question15";
      			}
		    }
           
            public IColumn Question16{
                get{
                    return this.GetColumn("Question16");
                }
            }
            				
   			public static string Question16Column{
			      get{
        			return "Question16";
      			}
		    }
           
            public IColumn Question17{
                get{
                    return this.GetColumn("Question17");
                }
            }
            				
   			public static string Question17Column{
			      get{
        			return "Question17";
      			}
		    }
           
            public IColumn Question18{
                get{
                    return this.GetColumn("Question18");
                }
            }
            				
   			public static string Question18Column{
			      get{
        			return "Question18";
      			}
		    }
           
            public IColumn Question19{
                get{
                    return this.GetColumn("Question19");
                }
            }
            				
   			public static string Question19Column{
			      get{
        			return "Question19";
      			}
		    }
           
            public IColumn Question20{
                get{
                    return this.GetColumn("Question20");
                }
            }
            				
   			public static string Question20Column{
			      get{
        			return "Question20";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProgramEvaluatorStage3
        /// Primary Key: ID
        /// </summary>

        public class ProgramEvaluatorStage3Table: DatabaseTable {
            
            public ProgramEvaluatorStage3Table(IDataProvider provider):base("ProgramEvaluatorStage3",provider){
                ClassName = "ProgramEvaluatorStage3";
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
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DateTimeTakenUTC", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question3", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question4", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question5", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question6", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question7", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question8", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question9", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question10", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question11", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question12", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question13", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question14", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question15", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question16", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question17", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question18", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question19", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Question20", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
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
           
            public IColumn DateTimeTakenUTC{
                get{
                    return this.GetColumn("DateTimeTakenUTC");
                }
            }
            				
   			public static string DateTimeTakenUTCColumn{
			      get{
        			return "DateTimeTakenUTC";
      			}
		    }
           
            public IColumn Question1{
                get{
                    return this.GetColumn("Question1");
                }
            }
            				
   			public static string Question1Column{
			      get{
        			return "Question1";
      			}
		    }
           
            public IColumn Question2{
                get{
                    return this.GetColumn("Question2");
                }
            }
            				
   			public static string Question2Column{
			      get{
        			return "Question2";
      			}
		    }
           
            public IColumn Question3{
                get{
                    return this.GetColumn("Question3");
                }
            }
            				
   			public static string Question3Column{
			      get{
        			return "Question3";
      			}
		    }
           
            public IColumn Question4{
                get{
                    return this.GetColumn("Question4");
                }
            }
            				
   			public static string Question4Column{
			      get{
        			return "Question4";
      			}
		    }
           
            public IColumn Question5{
                get{
                    return this.GetColumn("Question5");
                }
            }
            				
   			public static string Question5Column{
			      get{
        			return "Question5";
      			}
		    }
           
            public IColumn Question6{
                get{
                    return this.GetColumn("Question6");
                }
            }
            				
   			public static string Question6Column{
			      get{
        			return "Question6";
      			}
		    }
           
            public IColumn Question7{
                get{
                    return this.GetColumn("Question7");
                }
            }
            				
   			public static string Question7Column{
			      get{
        			return "Question7";
      			}
		    }
           
            public IColumn Question8{
                get{
                    return this.GetColumn("Question8");
                }
            }
            				
   			public static string Question8Column{
			      get{
        			return "Question8";
      			}
		    }
           
            public IColumn Question9{
                get{
                    return this.GetColumn("Question9");
                }
            }
            				
   			public static string Question9Column{
			      get{
        			return "Question9";
      			}
		    }
           
            public IColumn Question10{
                get{
                    return this.GetColumn("Question10");
                }
            }
            				
   			public static string Question10Column{
			      get{
        			return "Question10";
      			}
		    }
           
            public IColumn Question11{
                get{
                    return this.GetColumn("Question11");
                }
            }
            				
   			public static string Question11Column{
			      get{
        			return "Question11";
      			}
		    }
           
            public IColumn Question12{
                get{
                    return this.GetColumn("Question12");
                }
            }
            				
   			public static string Question12Column{
			      get{
        			return "Question12";
      			}
		    }
           
            public IColumn Question13{
                get{
                    return this.GetColumn("Question13");
                }
            }
            				
   			public static string Question13Column{
			      get{
        			return "Question13";
      			}
		    }
           
            public IColumn Question14{
                get{
                    return this.GetColumn("Question14");
                }
            }
            				
   			public static string Question14Column{
			      get{
        			return "Question14";
      			}
		    }
           
            public IColumn Question15{
                get{
                    return this.GetColumn("Question15");
                }
            }
            				
   			public static string Question15Column{
			      get{
        			return "Question15";
      			}
		    }
           
            public IColumn Question16{
                get{
                    return this.GetColumn("Question16");
                }
            }
            				
   			public static string Question16Column{
			      get{
        			return "Question16";
      			}
		    }
           
            public IColumn Question17{
                get{
                    return this.GetColumn("Question17");
                }
            }
            				
   			public static string Question17Column{
			      get{
        			return "Question17";
      			}
		    }
           
            public IColumn Question18{
                get{
                    return this.GetColumn("Question18");
                }
            }
            				
   			public static string Question18Column{
			      get{
        			return "Question18";
      			}
		    }
           
            public IColumn Question19{
                get{
                    return this.GetColumn("Question19");
                }
            }
            				
   			public static string Question19Column{
			      get{
        			return "Question19";
      			}
		    }
           
            public IColumn Question20{
                get{
                    return this.GetColumn("Question20");
                }
            }
            				
   			public static string Question20Column{
			      get{
        			return "Question20";
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
        
}