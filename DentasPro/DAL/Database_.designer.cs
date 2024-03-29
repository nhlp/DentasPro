﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dentas_Pro.DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DentasPro")]
	public partial class Database_DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    #endregion
		
		public Database_DataContext() : 
				base(global::Dentas_Pro.DAL.Properties.Settings.Default.DentasProConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Database_DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Database_DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Database_DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Database_DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Title> Titles
		{
			get
			{
				return this.GetTable<Title>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Obj_Id;
		
		private string _Code;
		
		private string _Name;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnObj_IdChanging(int value);
    partial void OnObj_IdChanged();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Department()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Obj_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Obj_Id
		{
			get
			{
				return this._Obj_Id;
			}
			set
			{
				if ((this._Obj_Id != value))
				{
					this.OnObj_IdChanging(value);
					this.SendPropertyChanging();
					this._Obj_Id = value;
					this.SendPropertyChanged("Obj_Id");
					this.OnObj_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="NVarChar(20)")]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(250)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Title")]
	public partial class Title
	{
		
		private int _Obj_Id;
		
		private string _Code;
		
		private string _Name;
		
		private string _Description;
		
		public Title()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Obj_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Obj_Id
		{
			get
			{
				return this._Obj_Id;
			}
			set
			{
				if ((this._Obj_Id != value))
				{
					this._Obj_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="NChar(20)")]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this._Code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(250)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User
	{
		
		private int _Obj_Id;
		
		private System.Nullable<short> _Registration_Number;
		
		private string _Name;
		
		private string _Surname;
		
		private System.Nullable<System.DateTime> _Birth_Date;
		
		private string _Birth_Place;
		
		private System.Nullable<int> _Insert_User;
		
		private System.Nullable<System.DateTime> _Insert_Date;
		
		private System.Nullable<int> _Edit_User;
		
		private System.Nullable<System.DateTime> _Edit_Date;
		
		public User()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Obj_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Obj_Id
		{
			get
			{
				return this._Obj_Id;
			}
			set
			{
				if ((this._Obj_Id != value))
				{
					this._Obj_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Registration_Number", DbType="SmallInt")]
		public System.Nullable<short> Registration_Number
		{
			get
			{
				return this._Registration_Number;
			}
			set
			{
				if ((this._Registration_Number != value))
				{
					this._Registration_Number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this._Surname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birth_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Birth_Date
		{
			get
			{
				return this._Birth_Date;
			}
			set
			{
				if ((this._Birth_Date != value))
				{
					this._Birth_Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birth_Place", DbType="NChar(10)")]
		public string Birth_Place
		{
			get
			{
				return this._Birth_Place;
			}
			set
			{
				if ((this._Birth_Place != value))
				{
					this._Birth_Place = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Insert_User", DbType="Int")]
		public System.Nullable<int> Insert_User
		{
			get
			{
				return this._Insert_User;
			}
			set
			{
				if ((this._Insert_User != value))
				{
					this._Insert_User = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Insert_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Insert_Date
		{
			get
			{
				return this._Insert_Date;
			}
			set
			{
				if ((this._Insert_Date != value))
				{
					this._Insert_Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Edit_User", DbType="Int")]
		public System.Nullable<int> Edit_User
		{
			get
			{
				return this._Edit_User;
			}
			set
			{
				if ((this._Edit_User != value))
				{
					this._Edit_User = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Edit_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Edit_Date
		{
			get
			{
				return this._Edit_Date;
			}
			set
			{
				if ((this._Edit_Date != value))
				{
					this._Edit_Date = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
