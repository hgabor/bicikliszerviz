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
    partial void InsertOffer(Offer instance);
    partial void UpdateOffer(Offer instance);
    partial void DeleteOffer(Offer instance);
    partial void InsertService(Service instance);
    partial void UpdateService(Service instance);
    partial void DeleteService(Service instance);
    partial void InsertBicycle(Bicycle instance);
    partial void UpdateBicycle(Bicycle instance);
    partial void DeleteBicycle(Bicycle instance);
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
		
		public System.Data.Linq.Table<Offer> Offers
		{
			get
			{
				return this.GetTable<Offer>();
			}
		}
		
		public System.Data.Linq.Table<Service> Services
		{
			get
			{
				return this.GetTable<Service>();
			}
		}
		
		public System.Data.Linq.Table<Bicycle> Bicycles
		{
			get
			{
				return this.GetTable<Bicycle>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Offer")]
	public partial class Offer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ServiceId;
		
		private System.Guid _BicycleId;
		
		private decimal _Cost;
		
		private decimal _Times;
		
		private bool _Selected;
		
		private EntityRef<Service> _Service;
		
		private EntityRef<Bicycle> _Bicycle;
		
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
    partial void OnTimesChanging(decimal value);
    partial void OnTimesChanged();
    partial void OnSelectedChanging(bool value);
    partial void OnSelectedChanged();
    #endregion
		
		public Offer()
		{
			this._Service = default(EntityRef<Service>);
			this._Bicycle = default(EntityRef<Bicycle>);
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
					if (this._Service.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
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
					if (this._Bicycle.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Times", DbType="Decimal(3,0) NOT NULL")]
		public decimal Times
		{
			get
			{
				return this._Times;
			}
			set
			{
				if ((this._Times != value))
				{
					this.OnTimesChanging(value);
					this.SendPropertyChanging();
					this._Times = value;
					this.SendPropertyChanged("Times");
					this.OnTimesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Selected", DbType="Bit NOT NULL")]
		public bool Selected
		{
			get
			{
				return this._Selected;
			}
			set
			{
				if ((this._Selected != value))
				{
					this.OnSelectedChanging(value);
					this.SendPropertyChanging();
					this._Selected = value;
					this.SendPropertyChanged("Selected");
					this.OnSelectedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Service_Ajanlat", Storage="_Service", ThisKey="ServiceId", OtherKey="UserId", IsForeignKey=true)]
		public Service Service
		{
			get
			{
				return this._Service.Entity;
			}
			set
			{
				Service previousValue = this._Service.Entity;
				if (((previousValue != value) 
							|| (this._Service.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Service.Entity = null;
						previousValue.Offers.Remove(this);
					}
					this._Service.Entity = value;
					if ((value != null))
					{
						value.Offers.Add(this);
						this._ServiceId = value.UserId;
					}
					else
					{
						this._ServiceId = default(System.Guid);
					}
					this.SendPropertyChanged("Service");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bicycle_Ajanlat", Storage="_Bicycle", ThisKey="BicycleId", OtherKey="Id", IsForeignKey=true)]
		public Bicycle Bicycle
		{
			get
			{
				return this._Bicycle.Entity;
			}
			set
			{
				Bicycle previousValue = this._Bicycle.Entity;
				if (((previousValue != value) 
							|| (this._Bicycle.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Bicycle.Entity = null;
						previousValue.Offers.Remove(this);
					}
					this._Bicycle.Entity = value;
					if ((value != null))
					{
						value.Offers.Add(this);
						this._BicycleId = value.Id;
					}
					else
					{
						this._BicycleId = default(System.Guid);
					}
					this.SendPropertyChanged("Bicycle");
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
		
		private EntitySet<Offer> _Ajanlats;
		
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
			this._Ajanlats = new EntitySet<Offer>(new Action<Offer>(this.attach_Ajanlats), new Action<Offer>(this.detach_Ajanlats));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Service_Ajanlat", Storage="_Ajanlats", ThisKey="UserId", OtherKey="ServiceId")]
		public EntitySet<Offer> Offers
		{
			get
			{
				return this._Ajanlats;
			}
			set
			{
				this._Ajanlats.Assign(value);
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
		
		private void attach_Ajanlats(Offer entity)
		{
			this.SendPropertyChanging();
			entity.Service = this;
		}
		
		private void detach_Ajanlats(Offer entity)
		{
			this.SendPropertyChanging();
			entity.Service = null;
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
		
		private EntitySet<Offer> _Ajanlats;
		
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
			this._Ajanlats = new EntitySet<Offer>(new Action<Offer>(this.attach_Ajanlats), new Action<Offer>(this.detach_Ajanlats));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bicycle_Ajanlat", Storage="_Ajanlats", ThisKey="Id", OtherKey="BicycleId")]
		public EntitySet<Offer> Offers
		{
			get
			{
				return this._Ajanlats;
			}
			set
			{
				this._Ajanlats.Assign(value);
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
		
		private void attach_Ajanlats(Offer entity)
		{
			this.SendPropertyChanging();
			entity.Bicycle = this;
		}
		
		private void detach_Ajanlats(Offer entity)
		{
			this.SendPropertyChanging();
			entity.Bicycle = null;
		}
	}
}
#pragma warning restore 1591
