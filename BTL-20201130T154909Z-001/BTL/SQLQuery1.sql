create view SPtheoNV
as
select nv.MaNV,bg.MaBinh,bg.TenBinh,bg.MaLoai,bg.MaMau,bg.MaKL,bg.MaNSX,bg.DonGiaBan,bg.DonGiaNhap,bg.Anh,bg.GhiChu
from BinhGa as bg,HoaDonBan as hdb, ChiTietHDB as cthdb,NhanVien as nv
where bg.MaBinh=cthdb.MaBinh and cthdb.SoHDB=hdb.SoHDB and hdb.MaNV=nv.MaNV


select * from SPtheoNV


select *
from BinhGa as bg,HoaDonBan as hdb, ChiTietHDB as cthdb,NhanVien as nv
where bg.MaBinh=cthdb.MaBinh and cthdb.SoHDB=hdb.SoHDB and hdb.MaNV=nv.MaNV


alter proc SP_NV(@MaNV nvarchar(20))
as
begin
	select top(3) with ties bg.MaBinh,bg.TenBinh,bg.MaLoai,bg.MaMau,bg.MaKL,bg.MaNSX,bg.DonGiaBan,bg.DonGiaNhap,bg.GhiChu
	from BinhGa as bg,HoaDonBan as hdb, ChiTietHDB as cthdb,NhanVien as nv
	where bg.MaBinh=cthdb.MaBinh and cthdb.SoHDB=hdb.SoHDB and hdb.MaNV=nv.MaNV and nv.MaNV=@MaNV
	group by bg.MaBinh,bg.TenBinh,bg.MaLoai,bg.MaMau,bg.MaKL,bg.MaNSX,bg.DonGiaBan,bg.DonGiaNhap,bg.GhiChu
	order by sum(cthdb.SoLuong) asc
end

exec SP_NV 'NV1'


alter proc HD_TTN_NCC(@MaNCC nvarchar(20),@Thang int,@Nam int)
as
begin
	select isnull(SoHDN,'Tong Tien') as SoHDN,hdn.MaNV,hdn.MaNCC,hdn.NgayNhap,SUM(hdn.TongTien) as Tien
	from HoaDonNhap as hdn
	where hdn.MaNCC=@MaNCC and Month(hdn.NgayNhap)=@Thang and Year(NgayNhap)=@Nam
	group by grouping sets((SoHDN,hdn.MaNV,hdn.MaNCC,hdn.NgayNhap),())
end

exec HD_TTN_NCC 'T',11,2020

alter proc DoanhThu_Thang(@Thang int,@Nam int)
as
begin
	select sum(hdb.TongTien)
	from HoaDonBan as hdb
	where Month(hdb.NgayBan)=@Thang and Year(hdb.NgayBan)=@Nam
end

alter proc KH_Thang(@Thang int,@Nam int)
as
begin
	select distinct kh.MaKH,kh.TenKH,kh.DienThoai,kh.DiaChi
	from HoaDonBan as hdb,KhachHang as kh
	where hdb.MaKH=kh.MaKH and Month(hdb.NgayBan)=@Thang and Year(hdb.NgayBan)=@Nam
end

exec KH_Thang 11,2020