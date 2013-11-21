﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bicikliszerviz
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bicikli")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAjanlat(Ajanlat instance);
    partial void UpdateAjanlat(Ajanlat instance);
    partial void DeleteAjanlat(Ajanlat instance);
    partial void InsertBicycle(Bicycle instance);
    partial void UpdateBicycle(Bicycle instance);
    partial void DeleteBicycle(Bicycle instance);
    partial void InsertService(Service instance);
    partial void UpdateService(Service instance);
    partial void DeleteService(Service instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Ajanlat> Ajanlats
		{
			get
			{
				return this.GetTable<Ajanlat>();
			}
		}
		
		public System.Data.Linq.Table<Bicycle> Bicycles
		{
			get
			{
				return this.GetTable<Bicycle>();
			}
		}
		
		public System.Data.Linq.Table<Service> Services
		{
			get
			{
				return this.GetTable<Service>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ajanlat")]
	public partial class Ajanlat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ServiceId;
		
		private System.Guid _BicycleId;
		
		private decimal _Cost;
		
		private EntitySet<Bicycle> _Bicycles;
		
		private EntitySet<Service> _Services;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnServiceIdChanging(System.Guid value);
    partial void OnServiceIdChanged();
    partial void OnBicycleIdChanging(System.Guid value);
    partial void OnBicycleIdChanged();
    partial void OnCostChanging(decimal value);
    partial void OnCostChanged();
    #endregion
		
		public Ajanlat()
		{
			this._Bicycles = new EntitySet<Bicycle>(new Action<Bicycle>(this.attach_Bicycles), new Action<Bicycle>(this.detach_Bicycles));
			this._Services = new EntitySet<Service>(new Action<Service>(this.attach_Services), new Action<Service>(this.detach_Services));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ServiceId
		{
			get
			{
				return this._ServiceId;
			}
			set
			{
				if ((this._ServiceId != value))
				{
					this.OnServiceIdChanging(value);
					this.SendPropertyChanging();
					this._ServiceId = value;
					this.SendPropertyChanged("ServiceId");
					this.OnServiceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BicycleId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid BicycleId
		{
			get
			{
				return this._BicycleId;
			}
			set
			{
				if ((this._BicycleId != value))
				{
					this.OnBicycleIdChanging(value);
					this.SendPropertyChanging();
					this._BicycleId = value;
					this.SendPropertyChanged("BicycleId");
					this.OnBicycleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Decimal(20,0) NOT NULL")]
		public decimal Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ajanlat_Bicycle", Storage="_Bicycles", ThisKey="BicycleId", OtherKey="Id")]
		public EntitySet<Bicycle> Bicycles
		{
			get
			{
				return this._Bicycles;
			}
			set
			{
				this._Bicycles.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ajanlat_Service", Storage="_Services", ThisKey="ServiceId", OtherKey="UserId")]
		public EntitySet<Service> Services
		{
			get
			{
				return this._Services;
			}
			set
			{
				this._Services.Assign(value);
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
		
		private void attach_Bicycles(Bicycle entity)
		{
			this.SendPropertyChanging();
			entity.Ajanlat = this;
		}
		
		private void detach_Bicycles(Bicycle entity)
		{
			this.SendPropertyChanging();
			entity.Ajanlat = null;
		}
		
		private void attach_Services(Service entity)
		{
			this.SendPropertyChanging();
			entity.Ajanlat = this;
		}
		
		private void detach_Services(Service entity)
		{
			this.SendPropertyChanging();
			entity.Ajanlat = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bicycle")]
	public partial class Bicycle : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.Guid _UserId;
		
		private string _Type;
		
		private int _Size;
		
		private string _Fault;
		
		private EntityRef<Ajanlat> _Ajanlat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(System.Guid value);
    partial void OnUserIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnSizeChanging(int value);
    partial void OnSizeChanged();
    partial void OnFaultChanging(string value);
    partial void OnFaultChanged();
    #endregion
		
		public Bicycle()
		{
			this._Ajanlat = default(EntityRef<Ajanlat>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					if (this._Ajanlat.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="Int NOT NULL")]
		public int Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fault", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Fault
		{
			get
			{
				return this._Fault;
			}
			set
			{
				if ((this._Fault != value))
				{
					this.OnFaultChanging(value);
					this.SendPropertyChanging();
					this._Fault = value;
					this.SendPropertyChanged("Fault");
					this.OnFaultChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ajanlat_Bicycle", Storage="_Ajanlat", ThisKey="Id", OtherKey="BicycleId", IsForeignKey=true)]
		public Ajanlat Ajanlat
		{
			get
			{
				return this._Ajanlat.Entity;
			}
			set
			{
				Ajanlat previousValue = this._Ajanlat.Entity;
				if (((previousValue != value) 
							|| (this._Ajanlat.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ajanlat.Entity = null;
						previousValue.Bicycles.Remove(this);
					}
					this._Ajanlat.Entity = value;
					if ((value != null))
					{
						value.Bicycles.Add(this);
						this._Id = value.BicycleId;
					}
					else
					{
						this._Id = default(System.Guid);
					}
					this.SendPropertyChanged("Ajanlat");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Service")]
	public partial class Service : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _UserId;
		
		private string _Name;
		
		private string _Address;
		
		private EntityRef<Ajanlat> _Ajanlat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(System.Guid value);
    partial void OnUserIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
		
		public Service()
		{
			this._Ajanlat = default(EntityRef<Ajanlat>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._Ajanlat.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ajanlat_Service", Storage="_Ajanlat", ThisKey="UserId", OtherKey="ServiceId", IsForeignKey=true)]
		public Ajanlat Ajanlat
		{
			get
			{
				return this._Ajanlat.Entity;
			}
			set
			{
				Ajanlat previousValue = this._Ajanlat.Entity;
				if (((previousValue != value) 
							|| (this._Ajanlat.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ajanlat.Entity = null;
						previousValue.Services.Remove(this);
					}
					this._Ajanlat.Entity = value;
					if ((value != null))
					{
						value.Services.Add(this);
						this._UserId = value.ServiceId;
					}
					else
					{
						this._UserId = default(System.Guid);
					}
					this.SendPropertyChanged("Ajanlat");
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
