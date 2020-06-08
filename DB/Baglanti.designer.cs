﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OZIRSALIYE.DB
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DBOZ")]
	public partial class BaglantiDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSoforler(Soforler instance);
    partial void UpdateSoforler(Soforler instance);
    partial void DeleteSoforler(Soforler instance);
    partial void InsertIrsaliyeTablo(IrsaliyeTablo instance);
    partial void UpdateIrsaliyeTablo(IrsaliyeTablo instance);
    partial void DeleteIrsaliyeTablo(IrsaliyeTablo instance);
    partial void InsertIrsaliyeDetay(IrsaliyeDetay instance);
    partial void UpdateIrsaliyeDetay(IrsaliyeDetay instance);
    partial void DeleteIrsaliyeDetay(IrsaliyeDetay instance);
    #endregion
		
		public BaglantiDataContext() : 
				base(global::OZIRSALIYE.Properties.Settings.Default.DBOZConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public BaglantiDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BaglantiDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BaglantiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BaglantiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Soforler> Soforlers
		{
			get
			{
				return this.GetTable<Soforler>();
			}
		}
		
		public System.Data.Linq.Table<IrsaliyeTablo> IrsaliyeTablos
		{
			get
			{
				return this.GetTable<IrsaliyeTablo>();
			}
		}
		
		public System.Data.Linq.Table<IrsaliyeDetay> IrsaliyeDetays
		{
			get
			{
				return this.GetTable<IrsaliyeDetay>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Soforler")]
	public partial class Soforler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SoforID;
		
		private string _AdiSoyadi;
		
		private string _HesapNo;
		
		private string _V_D;
		
		private System.Nullable<int> _Sil;
		
		private EntitySet<IrsaliyeTablo> _IrsaliyeTablos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSoforIDChanging(int value);
    partial void OnSoforIDChanged();
    partial void OnAdiSoyadiChanging(string value);
    partial void OnAdiSoyadiChanged();
    partial void OnHesapNoChanging(string value);
    partial void OnHesapNoChanged();
    partial void OnV_DChanging(string value);
    partial void OnV_DChanged();
    partial void OnSilChanging(System.Nullable<int> value);
    partial void OnSilChanged();
    #endregion
		
		public Soforler()
		{
			this._IrsaliyeTablos = new EntitySet<IrsaliyeTablo>(new Action<IrsaliyeTablo>(this.attach_IrsaliyeTablos), new Action<IrsaliyeTablo>(this.detach_IrsaliyeTablos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoforID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SoforID
		{
			get
			{
				return this._SoforID;
			}
			set
			{
				if ((this._SoforID != value))
				{
					this.OnSoforIDChanging(value);
					this.SendPropertyChanging();
					this._SoforID = value;
					this.SendPropertyChanged("SoforID");
					this.OnSoforIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdiSoyadi", DbType="VarChar(100)")]
		public string AdiSoyadi
		{
			get
			{
				return this._AdiSoyadi;
			}
			set
			{
				if ((this._AdiSoyadi != value))
				{
					this.OnAdiSoyadiChanging(value);
					this.SendPropertyChanging();
					this._AdiSoyadi = value;
					this.SendPropertyChanged("AdiSoyadi");
					this.OnAdiSoyadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HesapNo", DbType="VarChar(20)")]
		public string HesapNo
		{
			get
			{
				return this._HesapNo;
			}
			set
			{
				if ((this._HesapNo != value))
				{
					this.OnHesapNoChanging(value);
					this.SendPropertyChanging();
					this._HesapNo = value;
					this.SendPropertyChanged("HesapNo");
					this.OnHesapNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_V_D", DbType="VarChar(20)")]
		public string V_D
		{
			get
			{
				return this._V_D;
			}
			set
			{
				if ((this._V_D != value))
				{
					this.OnV_DChanging(value);
					this.SendPropertyChanging();
					this._V_D = value;
					this.SendPropertyChanged("V_D");
					this.OnV_DChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sil", DbType="Int")]
		public System.Nullable<int> Sil
		{
			get
			{
				return this._Sil;
			}
			set
			{
				if ((this._Sil != value))
				{
					this.OnSilChanging(value);
					this.SendPropertyChanging();
					this._Sil = value;
					this.SendPropertyChanged("Sil");
					this.OnSilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Soforler_IrsaliyeTablo", Storage="_IrsaliyeTablos", ThisKey="SoforID", OtherKey="SoforID")]
		public EntitySet<IrsaliyeTablo> IrsaliyeTablos
		{
			get
			{
				return this._IrsaliyeTablos;
			}
			set
			{
				this._IrsaliyeTablos.Assign(value);
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
		
		private void attach_IrsaliyeTablos(IrsaliyeTablo entity)
		{
			this.SendPropertyChanging();
			entity.Soforler = this;
		}
		
		private void detach_IrsaliyeTablos(IrsaliyeTablo entity)
		{
			this.SendPropertyChanging();
			entity.Soforler = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IrsaliyeTablo")]
	public partial class IrsaliyeTablo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IrsaliyeID;
		
		private System.Nullable<int> _SoforID;
		
		private string _PlakaNo;
		
		private System.Nullable<System.DateTime> _Tarih;
		
		private System.Nullable<int> _Sil;
		
		private EntitySet<IrsaliyeDetay> _IrsaliyeDetays;
		
		private EntityRef<Soforler> _Soforler;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIrsaliyeIDChanging(int value);
    partial void OnIrsaliyeIDChanged();
    partial void OnSoforIDChanging(System.Nullable<int> value);
    partial void OnSoforIDChanged();
    partial void OnPlakaNoChanging(string value);
    partial void OnPlakaNoChanged();
    partial void OnTarihChanging(System.Nullable<System.DateTime> value);
    partial void OnTarihChanged();
    partial void OnSilChanging(System.Nullable<int> value);
    partial void OnSilChanged();
    #endregion
		
		public IrsaliyeTablo()
		{
			this._IrsaliyeDetays = new EntitySet<IrsaliyeDetay>(new Action<IrsaliyeDetay>(this.attach_IrsaliyeDetays), new Action<IrsaliyeDetay>(this.detach_IrsaliyeDetays));
			this._Soforler = default(EntityRef<Soforler>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IrsaliyeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IrsaliyeID
		{
			get
			{
				return this._IrsaliyeID;
			}
			set
			{
				if ((this._IrsaliyeID != value))
				{
					this.OnIrsaliyeIDChanging(value);
					this.SendPropertyChanging();
					this._IrsaliyeID = value;
					this.SendPropertyChanged("IrsaliyeID");
					this.OnIrsaliyeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoforID", DbType="Int")]
		public System.Nullable<int> SoforID
		{
			get
			{
				return this._SoforID;
			}
			set
			{
				if ((this._SoforID != value))
				{
					if (this._Soforler.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSoforIDChanging(value);
					this.SendPropertyChanging();
					this._SoforID = value;
					this.SendPropertyChanged("SoforID");
					this.OnSoforIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlakaNo", DbType="VarChar(11)")]
		public string PlakaNo
		{
			get
			{
				return this._PlakaNo;
			}
			set
			{
				if ((this._PlakaNo != value))
				{
					this.OnPlakaNoChanging(value);
					this.SendPropertyChanging();
					this._PlakaNo = value;
					this.SendPropertyChanged("PlakaNo");
					this.OnPlakaNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tarih", DbType="DateTime")]
		public System.Nullable<System.DateTime> Tarih
		{
			get
			{
				return this._Tarih;
			}
			set
			{
				if ((this._Tarih != value))
				{
					this.OnTarihChanging(value);
					this.SendPropertyChanging();
					this._Tarih = value;
					this.SendPropertyChanged("Tarih");
					this.OnTarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sil", DbType="Int")]
		public System.Nullable<int> Sil
		{
			get
			{
				return this._Sil;
			}
			set
			{
				if ((this._Sil != value))
				{
					this.OnSilChanging(value);
					this.SendPropertyChanging();
					this._Sil = value;
					this.SendPropertyChanged("Sil");
					this.OnSilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IrsaliyeTablo_IrsaliyeDetay", Storage="_IrsaliyeDetays", ThisKey="IrsaliyeID", OtherKey="IrsaliyeID")]
		public EntitySet<IrsaliyeDetay> IrsaliyeDetays
		{
			get
			{
				return this._IrsaliyeDetays;
			}
			set
			{
				this._IrsaliyeDetays.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Soforler_IrsaliyeTablo", Storage="_Soforler", ThisKey="SoforID", OtherKey="SoforID", IsForeignKey=true)]
		public Soforler Soforler
		{
			get
			{
				return this._Soforler.Entity;
			}
			set
			{
				Soforler previousValue = this._Soforler.Entity;
				if (((previousValue != value) 
							|| (this._Soforler.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Soforler.Entity = null;
						previousValue.IrsaliyeTablos.Remove(this);
					}
					this._Soforler.Entity = value;
					if ((value != null))
					{
						value.IrsaliyeTablos.Add(this);
						this._SoforID = value.SoforID;
					}
					else
					{
						this._SoforID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Soforler");
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
		
		private void attach_IrsaliyeDetays(IrsaliyeDetay entity)
		{
			this.SendPropertyChanging();
			entity.IrsaliyeTablo = this;
		}
		
		private void detach_IrsaliyeDetays(IrsaliyeDetay entity)
		{
			this.SendPropertyChanging();
			entity.IrsaliyeTablo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IrsaliyeDetay")]
	public partial class IrsaliyeDetay : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _KayitID;
		
		private System.Nullable<int> _HalNo;
		
		private string _Gonderen;
		
		private System.Nullable<int> _Kilogram;
		
		private System.Nullable<int> _Adet;
		
		private string _Cinsi;
		
		private string _SandıkNevi;
		
		private System.Nullable<decimal> _Fiyat;
		
		private System.Nullable<int> _IrsaliyeID;
		
		private string _Hatirlatma;
		
		private System.Nullable<int> _Sil;
		
		private EntityRef<IrsaliyeTablo> _IrsaliyeTablo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKayitIDChanging(int value);
    partial void OnKayitIDChanged();
    partial void OnHalNoChanging(System.Nullable<int> value);
    partial void OnHalNoChanged();
    partial void OnGonderenChanging(string value);
    partial void OnGonderenChanged();
    partial void OnKilogramChanging(System.Nullable<int> value);
    partial void OnKilogramChanged();
    partial void OnAdetChanging(System.Nullable<int> value);
    partial void OnAdetChanged();
    partial void OnCinsiChanging(string value);
    partial void OnCinsiChanged();
    partial void OnSandıkNeviChanging(string value);
    partial void OnSandıkNeviChanged();
    partial void OnFiyatChanging(System.Nullable<decimal> value);
    partial void OnFiyatChanged();
    partial void OnIrsaliyeIDChanging(System.Nullable<int> value);
    partial void OnIrsaliyeIDChanged();
    partial void OnHatirlatmaChanging(string value);
    partial void OnHatirlatmaChanged();
    partial void OnSilChanging(System.Nullable<int> value);
    partial void OnSilChanged();
    #endregion
		
		public IrsaliyeDetay()
		{
			this._IrsaliyeTablo = default(EntityRef<IrsaliyeTablo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KayitID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int KayitID
		{
			get
			{
				return this._KayitID;
			}
			set
			{
				if ((this._KayitID != value))
				{
					this.OnKayitIDChanging(value);
					this.SendPropertyChanging();
					this._KayitID = value;
					this.SendPropertyChanged("KayitID");
					this.OnKayitIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HalNo", DbType="Int")]
		public System.Nullable<int> HalNo
		{
			get
			{
				return this._HalNo;
			}
			set
			{
				if ((this._HalNo != value))
				{
					this.OnHalNoChanging(value);
					this.SendPropertyChanging();
					this._HalNo = value;
					this.SendPropertyChanged("HalNo");
					this.OnHalNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gonderen", DbType="VarChar(100)")]
		public string Gonderen
		{
			get
			{
				return this._Gonderen;
			}
			set
			{
				if ((this._Gonderen != value))
				{
					this.OnGonderenChanging(value);
					this.SendPropertyChanging();
					this._Gonderen = value;
					this.SendPropertyChanged("Gonderen");
					this.OnGonderenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kilogram", DbType="Int")]
		public System.Nullable<int> Kilogram
		{
			get
			{
				return this._Kilogram;
			}
			set
			{
				if ((this._Kilogram != value))
				{
					this.OnKilogramChanging(value);
					this.SendPropertyChanging();
					this._Kilogram = value;
					this.SendPropertyChanged("Kilogram");
					this.OnKilogramChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adet", DbType="Int")]
		public System.Nullable<int> Adet
		{
			get
			{
				return this._Adet;
			}
			set
			{
				if ((this._Adet != value))
				{
					this.OnAdetChanging(value);
					this.SendPropertyChanging();
					this._Adet = value;
					this.SendPropertyChanged("Adet");
					this.OnAdetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cinsi", DbType="VarChar(100)")]
		public string Cinsi
		{
			get
			{
				return this._Cinsi;
			}
			set
			{
				if ((this._Cinsi != value))
				{
					this.OnCinsiChanging(value);
					this.SendPropertyChanging();
					this._Cinsi = value;
					this.SendPropertyChanged("Cinsi");
					this.OnCinsiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SandıkNevi", DbType="VarChar(100)")]
		public string SandıkNevi
		{
			get
			{
				return this._SandıkNevi;
			}
			set
			{
				if ((this._SandıkNevi != value))
				{
					this.OnSandıkNeviChanging(value);
					this.SendPropertyChanging();
					this._SandıkNevi = value;
					this.SendPropertyChanged("SandıkNevi");
					this.OnSandıkNeviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fiyat", DbType="Money")]
		public System.Nullable<decimal> Fiyat
		{
			get
			{
				return this._Fiyat;
			}
			set
			{
				if ((this._Fiyat != value))
				{
					this.OnFiyatChanging(value);
					this.SendPropertyChanging();
					this._Fiyat = value;
					this.SendPropertyChanged("Fiyat");
					this.OnFiyatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IrsaliyeID", DbType="Int")]
		public System.Nullable<int> IrsaliyeID
		{
			get
			{
				return this._IrsaliyeID;
			}
			set
			{
				if ((this._IrsaliyeID != value))
				{
					if (this._IrsaliyeTablo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIrsaliyeIDChanging(value);
					this.SendPropertyChanging();
					this._IrsaliyeID = value;
					this.SendPropertyChanged("IrsaliyeID");
					this.OnIrsaliyeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hatirlatma", DbType="VarChar(255)")]
		public string Hatirlatma
		{
			get
			{
				return this._Hatirlatma;
			}
			set
			{
				if ((this._Hatirlatma != value))
				{
					this.OnHatirlatmaChanging(value);
					this.SendPropertyChanging();
					this._Hatirlatma = value;
					this.SendPropertyChanged("Hatirlatma");
					this.OnHatirlatmaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sil", DbType="Int")]
		public System.Nullable<int> Sil
		{
			get
			{
				return this._Sil;
			}
			set
			{
				if ((this._Sil != value))
				{
					this.OnSilChanging(value);
					this.SendPropertyChanging();
					this._Sil = value;
					this.SendPropertyChanged("Sil");
					this.OnSilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IrsaliyeTablo_IrsaliyeDetay", Storage="_IrsaliyeTablo", ThisKey="IrsaliyeID", OtherKey="IrsaliyeID", IsForeignKey=true)]
		public IrsaliyeTablo IrsaliyeTablo
		{
			get
			{
				return this._IrsaliyeTablo.Entity;
			}
			set
			{
				IrsaliyeTablo previousValue = this._IrsaliyeTablo.Entity;
				if (((previousValue != value) 
							|| (this._IrsaliyeTablo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._IrsaliyeTablo.Entity = null;
						previousValue.IrsaliyeDetays.Remove(this);
					}
					this._IrsaliyeTablo.Entity = value;
					if ((value != null))
					{
						value.IrsaliyeDetays.Add(this);
						this._IrsaliyeID = value.IrsaliyeID;
					}
					else
					{
						this._IrsaliyeID = default(Nullable<int>);
					}
					this.SendPropertyChanged("IrsaliyeTablo");
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
