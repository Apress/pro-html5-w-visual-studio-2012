﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chapter9.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="aspnet-Chapter9-20120605204805")]
	public partial class StateDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertState(State instance);
    partial void UpdateState(State instance);
    partial void DeleteState(State instance);
    #endregion
		
		public StateDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["aspnet_Chapter9_20120605204805ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StateDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StateDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StateDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StateDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<State> States
		{
			get
			{
				return this.GetTable<State>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.State")]
	public partial class State : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _StateCode;
		
		private string _StateName;
		
		private string _Path;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStateCodeChanging(string value);
    partial void OnStateCodeChanged();
    partial void OnStateNameChanging(string value);
    partial void OnStateNameChanged();
    partial void OnPathChanging(string value);
    partial void OnPathChanged();
    #endregion
		
		public State()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateCode", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string StateCode
		{
			get
			{
				return this._StateCode;
			}
			set
			{
				if ((this._StateCode != value))
				{
					this.OnStateCodeChanging(value);
					this.SendPropertyChanging();
					this._StateCode = value;
					this.SendPropertyChanged("StateCode");
					this.OnStateCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string StateName
		{
			get
			{
				return this._StateName;
			}
			set
			{
				if ((this._StateName != value))
				{
					this.OnStateNameChanging(value);
					this.SendPropertyChanging();
					this._StateName = value;
					this.SendPropertyChanged("StateName");
					this.OnStateNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Path", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Path
		{
			get
			{
				return this._Path;
			}
			set
			{
				if ((this._Path != value))
				{
					this.OnPathChanging(value);
					this.SendPropertyChanging();
					this._Path = value;
					this.SendPropertyChanged("Path");
					this.OnPathChanged();
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