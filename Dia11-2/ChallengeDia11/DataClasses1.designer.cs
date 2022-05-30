﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChallengeDia11
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ChallengeDia9-Ej3-Concesionaria")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertVehiculo(Vehiculo instance);
    partial void UpdateVehiculo(Vehiculo instance);
    partial void DeleteVehiculo(Vehiculo instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ChallengeDia11.Properties.Settings.Default.ChallengeDia9_Ej3_ConcesionariaConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Vehiculo> Vehiculo
		{
			get
			{
				return this.GetTable<Vehiculo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Vehiculo")]
	public partial class Vehiculo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Marca;
		
		private string _Modelo;
		
		private string _Importe;
		
		private System.Nullable<System.DateTime> _FechaBaja;
		
		private System.Nullable<int> _Año;
		
		private System.Nullable<int> _kilometraje;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnMarcaChanging(string value);
    partial void OnMarcaChanged();
    partial void OnModeloChanging(string value);
    partial void OnModeloChanged();
    partial void OnImporteChanging(string value);
    partial void OnImporteChanged();
    partial void OnFechaBajaChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaBajaChanged();
    partial void OnAñoChanging(System.Nullable<int> value);
    partial void OnAñoChanged();
    partial void OnkilometrajeChanging(System.Nullable<int> value);
    partial void OnkilometrajeChanged();
    #endregion
		
		public Vehiculo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Marca", DbType="VarChar(50)")]
		public string Marca
		{
			get
			{
				return this._Marca;
			}
			set
			{
				if ((this._Marca != value))
				{
					this.OnMarcaChanging(value);
					this.SendPropertyChanging();
					this._Marca = value;
					this.SendPropertyChanged("Marca");
					this.OnMarcaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modelo", DbType="VarChar(50)")]
		public string Modelo
		{
			get
			{
				return this._Modelo;
			}
			set
			{
				if ((this._Modelo != value))
				{
					this.OnModeloChanging(value);
					this.SendPropertyChanging();
					this._Modelo = value;
					this.SendPropertyChanged("Modelo");
					this.OnModeloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Importe", DbType="VarChar(50)")]
		public string Importe
		{
			get
			{
				return this._Importe;
			}
			set
			{
				if ((this._Importe != value))
				{
					this.OnImporteChanging(value);
					this.SendPropertyChanging();
					this._Importe = value;
					this.SendPropertyChanged("Importe");
					this.OnImporteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaBaja", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaBaja
		{
			get
			{
				return this._FechaBaja;
			}
			set
			{
				if ((this._FechaBaja != value))
				{
					this.OnFechaBajaChanging(value);
					this.SendPropertyChanging();
					this._FechaBaja = value;
					this.SendPropertyChanged("FechaBaja");
					this.OnFechaBajaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Año", DbType="Int")]
		public System.Nullable<int> Año
		{
			get
			{
				return this._Año;
			}
			set
			{
				if ((this._Año != value))
				{
					this.OnAñoChanging(value);
					this.SendPropertyChanging();
					this._Año = value;
					this.SendPropertyChanged("Año");
					this.OnAñoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kilometraje", DbType="Int")]
		public System.Nullable<int> kilometraje
		{
			get
			{
				return this._kilometraje;
			}
			set
			{
				if ((this._kilometraje != value))
				{
					this.OnkilometrajeChanging(value);
					this.SendPropertyChanging();
					this._kilometraje = value;
					this.SendPropertyChanged("kilometraje");
					this.OnkilometrajeChanged();
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