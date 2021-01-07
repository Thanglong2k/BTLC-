alter trigger updateSLBinhGa on ChiTietHDN
for insert
as
begin
	declare @SoLuong int,@maBinh nvarchar(20),@DonGia bigint
	select @maBinh=maBinh,@SoLuong=SoLuong,@DonGia=DonGia from inserted
	update BinhGa set SoLuong=SoLuong+@SoLuong, DonGiaNhap=@DonGia,DonGiaBan=@DonGia*1.1 where MaBinh=@maBinh
end

create trigger updateSLBinhGaBan on ChiTietHDB
for insert
as
begin
	declare @SoLuong int,@maBinh nvarchar(20)
	select @maBinh=maBinh,@SoLuong=SoLuong from inserted
	update BinhGa set SoLuong=SoLuong-@SoLuong where MaBinh=@maBinh
end

create trigger updateDonGiaBan on BinhGa
for insert
as
begin
	declare @DonGia int,@maBinh nvarchar(20)
	select @maBinh=MaBinh, @DonGia=DonGia from inserted
	update BinhGa
end




