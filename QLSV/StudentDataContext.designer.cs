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

namespace QLSV
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DBMS_QLSV")]
	public partial class StudentDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHeDT(HeDT instance);
    partial void UpdateHeDT(HeDT instance);
    partial void DeleteHeDT(HeDT instance);
    partial void InsertKhoa(Khoa instance);
    partial void UpdateKhoa(Khoa instance);
    partial void DeleteKhoa(Khoa instance);
    partial void InsertKhoaHoc(KhoaHoc instance);
    partial void UpdateKhoaHoc(KhoaHoc instance);
    partial void DeleteKhoaHoc(KhoaHoc instance);
    partial void InsertLop(Lop instance);
    partial void UpdateLop(Lop instance);
    partial void DeleteLop(Lop instance);
    partial void InsertMonHoc(MonHoc instance);
    partial void UpdateMonHoc(MonHoc instance);
    partial void DeleteMonHoc(MonHoc instance);
    partial void InsertSinhVien(SinhVien instance);
    partial void UpdateSinhVien(SinhVien instance);
    partial void DeleteSinhVien(SinhVien instance);
    #endregion
		
		public StudentDataContextDataContext() : 
				base(global::QLSV.Properties.Settings.Default.DBMS_QLSVConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Diem> Diems
		{
			get
			{
				return this.GetTable<Diem>();
			}
		}
		
		public System.Data.Linq.Table<HeDT> HeDTs
		{
			get
			{
				return this.GetTable<HeDT>();
			}
		}
		
		public System.Data.Linq.Table<Khoa> Khoas
		{
			get
			{
				return this.GetTable<Khoa>();
			}
		}
		
		public System.Data.Linq.Table<KhoaHoc> KhoaHocs
		{
			get
			{
				return this.GetTable<KhoaHoc>();
			}
		}
		
		public System.Data.Linq.Table<Lop> Lops
		{
			get
			{
				return this.GetTable<Lop>();
			}
		}
		
		public System.Data.Linq.Table<MonHoc> MonHocs
		{
			get
			{
				return this.GetTable<MonHoc>();
			}
		}
		
		public System.Data.Linq.Table<SinhVien> SinhViens
		{
			get
			{
				return this.GetTable<SinhVien>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ThemMoiSinhVien")]
		public int ThemMoiSinhVien([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaSV", DbType="Char(15)")] string maSV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenSV", DbType="NVarChar(30)")] string tenSV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GioiTinh", DbType="Bit")] System.Nullable<bool> gioiTinh, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgaySinh", DbType="Date")] System.Nullable<System.DateTime> ngaySinh, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="QueQuan", DbType="NVarChar(50)")] string queQuan, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoDienThoai", DbType="Char(20)")] string soDienThoai, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaLop", DbType="Char(10)")] string maLop)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSV, tenSV, gioiTinh, ngaySinh, queQuan, soDienThoai, maLop);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateSinhVien")]
		public int UpdateSinhVien([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaSV", DbType="Char(15)")] string maSV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenSV", DbType="NVarChar(30)")] string tenSV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GioiTinh", DbType="Bit")] System.Nullable<bool> gioiTinh, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgaySinh", DbType="Date")] System.Nullable<System.DateTime> ngaySinh, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="QueQuan", DbType="NVarChar(50)")] string queQuan, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoDienThoai", DbType="Char(20)")] string soDienThoai, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaLop", DbType="Char(10)")] string maLop)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSV, tenSV, gioiTinh, ngaySinh, queQuan, soDienThoai, maLop);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.XoaSinhVien")]
		public int XoaSinhVien([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaSV", DbType="Char(15)")] string maSV)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSV);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SuaDiemSinhVien")]
		public int SuaDiemSinhVien([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaSV", DbType="Char(15)")] string maSV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaMH", DbType="Char(15)")] string maMH, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HocKy", DbType="Int")] System.Nullable<int> hocKy, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiemQuaTrinhLan1", DbType="Real")] System.Nullable<float> diemQuaTrinhLan1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiemQuaTrinhLan2", DbType="Real")] System.Nullable<float> diemQuaTrinhLan2, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiemCuoiKi", DbType="Real")] System.Nullable<float> diemCuoiKi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSV, maMH, hocKy, diemQuaTrinhLan1, diemQuaTrinhLan2, diemCuoiKi);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SuaKhoa")]
		public int SuaKhoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhoa", DbType="Char(10)")] string maKhoa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenKhoa", DbType="NVarChar(30)")] string tenKhoa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiaChi", DbType="NVarChar(100)")] string diaChi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DienThoai", DbType="NVarChar(20)")] string dienThoai)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKhoa, tenKhoa, diaChi, dienThoai);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SuaThongTinLop")]
		public int SuaThongTinLop([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaLop", DbType="Char(10)")] string maLop, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenLop", DbType="NVarChar(30)")] string tenLop, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhoa", DbType="Char(10)")] string maKhoa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaHeDT", DbType="Char(10)")] string maHeDT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhoaHoc", DbType="Char(10)")] string maKhoaHoc)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maLop, tenLop, maKhoa, maHeDT, maKhoaHoc);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ThemDiemSinhVien")]
		public int ThemDiemSinhVien([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaSV", DbType="Char(15)")] string maSV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaMH", DbType="Char(15)")] string maMH, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HocKy", DbType="Int")] System.Nullable<int> hocKy, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiemQuaTrinhLan1", DbType="Real")] System.Nullable<float> diemQuaTrinhLan1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiemQuaTrinhLan2", DbType="Real")] System.Nullable<float> diemQuaTrinhLan2, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiemCuoiKi", DbType="Real")] System.Nullable<float> diemCuoiKi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSV, maMH, hocKy, diemQuaTrinhLan1, diemQuaTrinhLan2, diemCuoiKi);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ThemKhoa")]
		public int ThemKhoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhoa", DbType="Char(10)")] string maKhoa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenKhoa", DbType="NVarChar(30)")] string tenKhoa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiaChi", DbType="NVarChar(100)")] string diaChi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DienThoai", DbType="NVarChar(20)")] string dienThoai)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKhoa, tenKhoa, diaChi, dienThoai);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ThemLop")]
		public int ThemLop([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaLop", DbType="Char(10)")] string maLop, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenLop", DbType="NVarChar(30)")] string tenLop, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhoa", DbType="Char(10)")] string maKhoa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaHeDT", DbType="Char(10)")] string maHeDT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhoaHoc", DbType="Char(10)")] string maKhoaHoc)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maLop, tenLop, maKhoa, maHeDT, maKhoaHoc);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.XoaDiemSinhVien")]
		public int XoaDiemSinhVien([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaSV", DbType="Char(15)")] string maSV)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSV);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.XoaKhoa")]
		public int XoaKhoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhoa", DbType="Char(10)")] string maKhoa)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKhoa);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.XoaLop")]
		public int XoaLop([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaLop", DbType="Char(10)")] string maLop)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maLop);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Diem")]
	public partial class Diem
	{
		
		private string _MaSV;
		
		private string _MaMH;
		
		private int _HocKy;
		
		private System.Nullable<float> _DiemQuaTrinhLan1;
		
		private System.Nullable<float> _DiemQuaTrinhLan2;
		
		private System.Nullable<float> _DiemCuoiKi;
		
		public Diem()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="Char(15)")]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this._MaSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMH", DbType="Char(10)")]
		public string MaMH
		{
			get
			{
				return this._MaMH;
			}
			set
			{
				if ((this._MaMH != value))
				{
					this._MaMH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HocKy", DbType="Int NOT NULL")]
		public int HocKy
		{
			get
			{
				return this._HocKy;
			}
			set
			{
				if ((this._HocKy != value))
				{
					this._HocKy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemQuaTrinhLan1", DbType="Real")]
		public System.Nullable<float> DiemQuaTrinhLan1
		{
			get
			{
				return this._DiemQuaTrinhLan1;
			}
			set
			{
				if ((this._DiemQuaTrinhLan1 != value))
				{
					this._DiemQuaTrinhLan1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemQuaTrinhLan2", DbType="Real")]
		public System.Nullable<float> DiemQuaTrinhLan2
		{
			get
			{
				return this._DiemQuaTrinhLan2;
			}
			set
			{
				if ((this._DiemQuaTrinhLan2 != value))
				{
					this._DiemQuaTrinhLan2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemCuoiKi", DbType="Real")]
		public System.Nullable<float> DiemCuoiKi
		{
			get
			{
				return this._DiemCuoiKi;
			}
			set
			{
				if ((this._DiemCuoiKi != value))
				{
					this._DiemCuoiKi = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HeDT")]
	public partial class HeDT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHeDT;
		
		private string _TenHeDT;
		
		private EntitySet<Lop> _Lops;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHeDTChanging(string value);
    partial void OnMaHeDTChanged();
    partial void OnTenHeDTChanging(string value);
    partial void OnTenHeDTChanged();
    #endregion
		
		public HeDT()
		{
			this._Lops = new EntitySet<Lop>(new Action<Lop>(this.attach_Lops), new Action<Lop>(this.detach_Lops));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHeDT", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHeDT
		{
			get
			{
				return this._MaHeDT;
			}
			set
			{
				if ((this._MaHeDT != value))
				{
					this.OnMaHeDTChanging(value);
					this.SendPropertyChanging();
					this._MaHeDT = value;
					this.SendPropertyChanged("MaHeDT");
					this.OnMaHeDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHeDT", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string TenHeDT
		{
			get
			{
				return this._TenHeDT;
			}
			set
			{
				if ((this._TenHeDT != value))
				{
					this.OnTenHeDTChanging(value);
					this.SendPropertyChanging();
					this._TenHeDT = value;
					this.SendPropertyChanged("TenHeDT");
					this.OnTenHeDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HeDT_Lop", Storage="_Lops", ThisKey="MaHeDT", OtherKey="MaHeDT")]
		public EntitySet<Lop> Lops
		{
			get
			{
				return this._Lops;
			}
			set
			{
				this._Lops.Assign(value);
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
		
		private void attach_Lops(Lop entity)
		{
			this.SendPropertyChanging();
			entity.HeDT = this;
		}
		
		private void detach_Lops(Lop entity)
		{
			this.SendPropertyChanging();
			entity.HeDT = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Khoa")]
	public partial class Khoa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhoa;
		
		private string _TenKhoa;
		
		private string _DiaChi;
		
		private string _DienThoai;
		
		private EntitySet<Lop> _Lops;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhoaChanging(string value);
    partial void OnMaKhoaChanged();
    partial void OnTenKhoaChanging(string value);
    partial void OnTenKhoaChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    #endregion
		
		public Khoa()
		{
			this._Lops = new EntitySet<Lop>(new Action<Lop>(this.attach_Lops), new Action<Lop>(this.detach_Lops));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhoa", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenKhoa
		{
			get
			{
				return this._TenKhoa;
			}
			set
			{
				if ((this._TenKhoa != value))
				{
					this.OnTenKhoaChanging(value);
					this.SendPropertyChanging();
					this._TenKhoa = value;
					this.SendPropertyChanged("TenKhoa");
					this.OnTenKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khoa_Lop", Storage="_Lops", ThisKey="MaKhoa", OtherKey="MaKhoa")]
		public EntitySet<Lop> Lops
		{
			get
			{
				return this._Lops;
			}
			set
			{
				this._Lops.Assign(value);
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
		
		private void attach_Lops(Lop entity)
		{
			this.SendPropertyChanging();
			entity.Khoa = this;
		}
		
		private void detach_Lops(Lop entity)
		{
			this.SendPropertyChanging();
			entity.Khoa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhoaHoc")]
	public partial class KhoaHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhoaHoc;
		
		private string _TenKhoaHoc;
		
		private EntitySet<Lop> _Lops;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhoaHocChanging(string value);
    partial void OnMaKhoaHocChanged();
    partial void OnTenKhoaHocChanging(string value);
    partial void OnTenKhoaHocChanged();
    #endregion
		
		public KhoaHoc()
		{
			this._Lops = new EntitySet<Lop>(new Action<Lop>(this.attach_Lops), new Action<Lop>(this.detach_Lops));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoaHoc", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKhoaHoc
		{
			get
			{
				return this._MaKhoaHoc;
			}
			set
			{
				if ((this._MaKhoaHoc != value))
				{
					this.OnMaKhoaHocChanging(value);
					this.SendPropertyChanging();
					this._MaKhoaHoc = value;
					this.SendPropertyChanged("MaKhoaHoc");
					this.OnMaKhoaHocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhoaHoc", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TenKhoaHoc
		{
			get
			{
				return this._TenKhoaHoc;
			}
			set
			{
				if ((this._TenKhoaHoc != value))
				{
					this.OnTenKhoaHocChanging(value);
					this.SendPropertyChanging();
					this._TenKhoaHoc = value;
					this.SendPropertyChanged("TenKhoaHoc");
					this.OnTenKhoaHocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhoaHoc_Lop", Storage="_Lops", ThisKey="MaKhoaHoc", OtherKey="MaKhoaHoc")]
		public EntitySet<Lop> Lops
		{
			get
			{
				return this._Lops;
			}
			set
			{
				this._Lops.Assign(value);
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
		
		private void attach_Lops(Lop entity)
		{
			this.SendPropertyChanging();
			entity.KhoaHoc = this;
		}
		
		private void detach_Lops(Lop entity)
		{
			this.SendPropertyChanging();
			entity.KhoaHoc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lop")]
	public partial class Lop : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLop;
		
		private string _TenLop;
		
		private string _MaKhoa;
		
		private string _MaHeDT;
		
		private string _MaKhoaHoc;
		
		private EntitySet<SinhVien> _SinhViens;
		
		private EntityRef<HeDT> _HeDT;
		
		private EntityRef<Khoa> _Khoa;
		
		private EntityRef<KhoaHoc> _KhoaHoc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    partial void OnTenLopChanging(string value);
    partial void OnTenLopChanged();
    partial void OnMaKhoaChanging(string value);
    partial void OnMaKhoaChanged();
    partial void OnMaHeDTChanging(string value);
    partial void OnMaHeDTChanged();
    partial void OnMaKhoaHocChanging(string value);
    partial void OnMaKhoaHocChanged();
    #endregion
		
		public Lop()
		{
			this._SinhViens = new EntitySet<SinhVien>(new Action<SinhVien>(this.attach_SinhViens), new Action<SinhVien>(this.detach_SinhViens));
			this._HeDT = default(EntityRef<HeDT>);
			this._Khoa = default(EntityRef<Khoa>);
			this._KhoaHoc = default(EntityRef<KhoaHoc>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLop", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenLop
		{
			get
			{
				return this._TenLop;
			}
			set
			{
				if ((this._TenLop != value))
				{
					this.OnTenLopChanging(value);
					this.SendPropertyChanging();
					this._TenLop = value;
					this.SendPropertyChanged("TenLop");
					this.OnTenLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="Char(10)")]
		public string MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					if (this._Khoa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHeDT", DbType="Char(10)")]
		public string MaHeDT
		{
			get
			{
				return this._MaHeDT;
			}
			set
			{
				if ((this._MaHeDT != value))
				{
					if (this._HeDT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHeDTChanging(value);
					this.SendPropertyChanging();
					this._MaHeDT = value;
					this.SendPropertyChanged("MaHeDT");
					this.OnMaHeDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoaHoc", DbType="Char(10)")]
		public string MaKhoaHoc
		{
			get
			{
				return this._MaKhoaHoc;
			}
			set
			{
				if ((this._MaKhoaHoc != value))
				{
					if (this._KhoaHoc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhoaHocChanging(value);
					this.SendPropertyChanging();
					this._MaKhoaHoc = value;
					this.SendPropertyChanged("MaKhoaHoc");
					this.OnMaKhoaHocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lop_SinhVien", Storage="_SinhViens", ThisKey="MaLop", OtherKey="MaLop")]
		public EntitySet<SinhVien> SinhViens
		{
			get
			{
				return this._SinhViens;
			}
			set
			{
				this._SinhViens.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HeDT_Lop", Storage="_HeDT", ThisKey="MaHeDT", OtherKey="MaHeDT", IsForeignKey=true)]
		public HeDT HeDT
		{
			get
			{
				return this._HeDT.Entity;
			}
			set
			{
				HeDT previousValue = this._HeDT.Entity;
				if (((previousValue != value) 
							|| (this._HeDT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HeDT.Entity = null;
						previousValue.Lops.Remove(this);
					}
					this._HeDT.Entity = value;
					if ((value != null))
					{
						value.Lops.Add(this);
						this._MaHeDT = value.MaHeDT;
					}
					else
					{
						this._MaHeDT = default(string);
					}
					this.SendPropertyChanged("HeDT");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khoa_Lop", Storage="_Khoa", ThisKey="MaKhoa", OtherKey="MaKhoa", IsForeignKey=true)]
		public Khoa Khoa
		{
			get
			{
				return this._Khoa.Entity;
			}
			set
			{
				Khoa previousValue = this._Khoa.Entity;
				if (((previousValue != value) 
							|| (this._Khoa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Khoa.Entity = null;
						previousValue.Lops.Remove(this);
					}
					this._Khoa.Entity = value;
					if ((value != null))
					{
						value.Lops.Add(this);
						this._MaKhoa = value.MaKhoa;
					}
					else
					{
						this._MaKhoa = default(string);
					}
					this.SendPropertyChanged("Khoa");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhoaHoc_Lop", Storage="_KhoaHoc", ThisKey="MaKhoaHoc", OtherKey="MaKhoaHoc", IsForeignKey=true)]
		public KhoaHoc KhoaHoc
		{
			get
			{
				return this._KhoaHoc.Entity;
			}
			set
			{
				KhoaHoc previousValue = this._KhoaHoc.Entity;
				if (((previousValue != value) 
							|| (this._KhoaHoc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhoaHoc.Entity = null;
						previousValue.Lops.Remove(this);
					}
					this._KhoaHoc.Entity = value;
					if ((value != null))
					{
						value.Lops.Add(this);
						this._MaKhoaHoc = value.MaKhoaHoc;
					}
					else
					{
						this._MaKhoaHoc = default(string);
					}
					this.SendPropertyChanged("KhoaHoc");
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
		
		private void attach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.Lop = this;
		}
		
		private void detach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.Lop = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MonHoc")]
	public partial class MonHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaMH;
		
		private string _TenMH;
		
		private int _SoTinChi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaMHChanging(string value);
    partial void OnMaMHChanged();
    partial void OnTenMHChanging(string value);
    partial void OnTenMHChanged();
    partial void OnSoTinChiChanging(int value);
    partial void OnSoTinChiChanged();
    #endregion
		
		public MonHoc()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMH", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMH
		{
			get
			{
				return this._MaMH;
			}
			set
			{
				if ((this._MaMH != value))
				{
					this.OnMaMHChanging(value);
					this.SendPropertyChanging();
					this._MaMH = value;
					this.SendPropertyChanged("MaMH");
					this.OnMaMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMH", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenMH
		{
			get
			{
				return this._TenMH;
			}
			set
			{
				if ((this._TenMH != value))
				{
					this.OnTenMHChanging(value);
					this.SendPropertyChanging();
					this._TenMH = value;
					this.SendPropertyChanged("TenMH");
					this.OnTenMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTinChi", DbType="Int NOT NULL")]
		public int SoTinChi
		{
			get
			{
				return this._SoTinChi;
			}
			set
			{
				if ((this._SoTinChi != value))
				{
					this.OnSoTinChiChanging(value);
					this.SendPropertyChanging();
					this._SoTinChi = value;
					this.SendPropertyChanged("SoTinChi");
					this.OnSoTinChiChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SinhVien")]
	public partial class SinhVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSV;
		
		private string _TenSV;
		
		private System.Nullable<bool> _GioiTinh;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _QueQuan;
		
		private string _SoDienThoai;
		
		private string _MaLop;
		
		private EntityRef<Lop> _Lop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSVChanging(string value);
    partial void OnMaSVChanged();
    partial void OnTenSVChanging(string value);
    partial void OnTenSVChanged();
    partial void OnGioiTinhChanging(System.Nullable<bool> value);
    partial void OnGioiTinhChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnQueQuanChanging(string value);
    partial void OnQueQuanChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    #endregion
		
		public SinhVien()
		{
			this._Lop = default(EntityRef<Lop>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="Char(15) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this.OnMaSVChanging(value);
					this.SendPropertyChanging();
					this._MaSV = value;
					this.SendPropertyChanged("MaSV");
					this.OnMaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSV", DbType="NVarChar(30)")]
		public string TenSV
		{
			get
			{
				return this._TenSV;
			}
			set
			{
				if ((this._TenSV != value))
				{
					this.OnTenSVChanging(value);
					this.SendPropertyChanging();
					this._TenSV = value;
					this.SendPropertyChanged("TenSV");
					this.OnTenSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="Bit")]
		public System.Nullable<bool> GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QueQuan", DbType="NVarChar(50)")]
		public string QueQuan
		{
			get
			{
				return this._QueQuan;
			}
			set
			{
				if ((this._QueQuan != value))
				{
					this.OnQueQuanChanging(value);
					this.SendPropertyChanging();
					this._QueQuan = value;
					this.SendPropertyChanged("QueQuan");
					this.OnQueQuanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="Char(20)")]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="Char(10)")]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					if (this._Lop.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lop_SinhVien", Storage="_Lop", ThisKey="MaLop", OtherKey="MaLop", IsForeignKey=true)]
		public Lop Lop
		{
			get
			{
				return this._Lop.Entity;
			}
			set
			{
				Lop previousValue = this._Lop.Entity;
				if (((previousValue != value) 
							|| (this._Lop.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Lop.Entity = null;
						previousValue.SinhViens.Remove(this);
					}
					this._Lop.Entity = value;
					if ((value != null))
					{
						value.SinhViens.Add(this);
						this._MaLop = value.MaLop;
					}
					else
					{
						this._MaLop = default(string);
					}
					this.SendPropertyChanged("Lop");
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
