﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppData
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FrameworkTable")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSystemMenuItem(SystemMenuItem instance);
    partial void UpdateSystemMenuItem(SystemMenuItem instance);
    partial void DeleteSystemMenuItem(SystemMenuItem instance);
    partial void InsertSystemMenuTree(SystemMenuTree instance);
    partial void UpdateSystemMenuTree(SystemMenuTree instance);
    partial void DeleteSystemMenuTree(SystemMenuTree instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::AppData.Properties.Settings.Default.FrameworkTableConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SystemMenuItem> SystemMenuItems
		{
			get
			{
				return this.GetTable<SystemMenuItem>();
			}
		}
		
		public System.Data.Linq.Table<SystemMenuTree> SystemMenuTrees
		{
			get
			{
				return this.GetTable<SystemMenuTree>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SystemMenuItem")]
	public partial class SystemMenuItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NameEn;
		
		private string _NameJa;
		
		private string _NameTh;
		
		private string _NameCh;
		
		private string _NameMy;
		
		private string _NameClass;
		
		private System.Data.Linq.Binary _ImageIcon;
		
		private string _PageUri;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameEnChanging(string value);
    partial void OnNameEnChanged();
    partial void OnNameJaChanging(string value);
    partial void OnNameJaChanged();
    partial void OnNameThChanging(string value);
    partial void OnNameThChanged();
    partial void OnNameChChanging(string value);
    partial void OnNameChChanged();
    partial void OnNameMyChanging(string value);
    partial void OnNameMyChanged();
    partial void OnNameClassChanging(string value);
    partial void OnNameClassChanged();
    partial void OnImageIconChanging(System.Data.Linq.Binary value);
    partial void OnImageIconChanged();
    partial void OnPageUriChanging(string value);
    partial void OnPageUriChanged();
    #endregion
		
		public SystemMenuItem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameEn", DbType="NVarChar(100)")]
		public string NameEn
		{
			get
			{
				return this._NameEn;
			}
			set
			{
				if ((this._NameEn != value))
				{
					this.OnNameEnChanging(value);
					this.SendPropertyChanging();
					this._NameEn = value;
					this.SendPropertyChanged("NameEn");
					this.OnNameEnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameJa", DbType="NVarChar(100)")]
		public string NameJa
		{
			get
			{
				return this._NameJa;
			}
			set
			{
				if ((this._NameJa != value))
				{
					this.OnNameJaChanging(value);
					this.SendPropertyChanging();
					this._NameJa = value;
					this.SendPropertyChanged("NameJa");
					this.OnNameJaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameTh", DbType="NVarChar(100)")]
		public string NameTh
		{
			get
			{
				return this._NameTh;
			}
			set
			{
				if ((this._NameTh != value))
				{
					this.OnNameThChanging(value);
					this.SendPropertyChanging();
					this._NameTh = value;
					this.SendPropertyChanged("NameTh");
					this.OnNameThChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameCh", DbType="NVarChar(100)")]
		public string NameCh
		{
			get
			{
				return this._NameCh;
			}
			set
			{
				if ((this._NameCh != value))
				{
					this.OnNameChChanging(value);
					this.SendPropertyChanging();
					this._NameCh = value;
					this.SendPropertyChanged("NameCh");
					this.OnNameChChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameMy", DbType="NVarChar(100)")]
		public string NameMy
		{
			get
			{
				return this._NameMy;
			}
			set
			{
				if ((this._NameMy != value))
				{
					this.OnNameMyChanging(value);
					this.SendPropertyChanging();
					this._NameMy = value;
					this.SendPropertyChanged("NameMy");
					this.OnNameMyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameClass", DbType="NVarChar(100)")]
		public string NameClass
		{
			get
			{
				return this._NameClass;
			}
			set
			{
				if ((this._NameClass != value))
				{
					this.OnNameClassChanging(value);
					this.SendPropertyChanging();
					this._NameClass = value;
					this.SendPropertyChanged("NameClass");
					this.OnNameClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageIcon", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ImageIcon
		{
			get
			{
				return this._ImageIcon;
			}
			set
			{
				if ((this._ImageIcon != value))
				{
					this.OnImageIconChanging(value);
					this.SendPropertyChanging();
					this._ImageIcon = value;
					this.SendPropertyChanged("ImageIcon");
					this.OnImageIconChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageUri", DbType="VarChar(500)")]
		public string PageUri
		{
			get
			{
				return this._PageUri;
			}
			set
			{
				if ((this._PageUri != value))
				{
					this.OnPageUriChanging(value);
					this.SendPropertyChanging();
					this._PageUri = value;
					this.SendPropertyChanged("PageUri");
					this.OnPageUriChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SystemMenuTree")]
	public partial class SystemMenuTree : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _PId;
		
		private int _DisplayIndex;
		
		private int _SystemMenuItemId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPIdChanging(int value);
    partial void OnPIdChanged();
    partial void OnDisplayIndexChanging(int value);
    partial void OnDisplayIndexChanged();
    partial void OnSystemMenuItemIdChanging(int value);
    partial void OnSystemMenuItemIdChanged();
    #endregion
		
		public SystemMenuTree()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PId", DbType="Int NOT NULL")]
		public int PId
		{
			get
			{
				return this._PId;
			}
			set
			{
				if ((this._PId != value))
				{
					this.OnPIdChanging(value);
					this.SendPropertyChanging();
					this._PId = value;
					this.SendPropertyChanged("PId");
					this.OnPIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisplayIndex", DbType="Int NOT NULL")]
		public int DisplayIndex
		{
			get
			{
				return this._DisplayIndex;
			}
			set
			{
				if ((this._DisplayIndex != value))
				{
					this.OnDisplayIndexChanging(value);
					this.SendPropertyChanging();
					this._DisplayIndex = value;
					this.SendPropertyChanged("DisplayIndex");
					this.OnDisplayIndexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SystemMenuItemId", DbType="Int NOT NULL")]
		public int SystemMenuItemId
		{
			get
			{
				return this._SystemMenuItemId;
			}
			set
			{
				if ((this._SystemMenuItemId != value))
				{
					this.OnSystemMenuItemIdChanging(value);
					this.SendPropertyChanging();
					this._SystemMenuItemId = value;
					this.SendPropertyChanged("SystemMenuItemId");
					this.OnSystemMenuItemIdChanged();
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
}
#pragma warning restore 1591
