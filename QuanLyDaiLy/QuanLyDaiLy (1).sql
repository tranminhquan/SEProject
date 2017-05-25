﻿USE master
GO
DROP DATABASE QuanLyDaiLy

CREATE DATABASE QuanLyDaiLy
GO
USE QuanLyDaiLy
GO

CREATE TABLE DAILY(
	MaDaiLy CHAR(4) NOT NULL,
	MaLoaiDaiLy CHAR(4) NOT NULL,
	TenDaiLy NVARCHAR(30) NOT NULL,
	DienThoai VARCHAR(11) NOT NULL,
	DiaChi NVARCHAR(200) NOT NULL,
	MaQuan CHAR(4) NOT NULL,
	NgayTiepNhan SMALLDATETIME NOT NULL,
	Email VARCHAR(30),
	NoDaiLy MONEY NOT NULL,
	CONSTRAINT PK_KEY_DL PRIMARY KEY (MaDaiLy)
)

CREATE TABLE LOAIDAILY(
	MaLoaiDaiLy CHAR(4) NOT NULL,
	TenLoaiDaiLy NVARCHAR(20) NOT NULL,
	NoToiDa MONEY NOT NULL,
	CONSTRAINT PK_KEY_LDL PRIMARY KEY (MaLoaiDaiLy)
)

CREATE TABLE QUAN(
	MaQuan CHAR(4) NOT NULL,
	TenQuan NVARCHAR(20) NOT NULL,
	CONSTRAINT PK_KEY_Q PRIMARY KEY (MaQuan)
)

CREATE TABLE THAMSO(
	SoLuongDLToiDa INT NOT NULL,
	ApDung BIT NOT NULL,
	--SoLoaiDaiLy INT NOT NULL,
	--SoQuan INT NOT NULL,
	--SoLoaiMatHang INT NOT NULL,
	--SoDonViTinh INT NOT NULL,
	--SoTienNoToiDaLoai1 MONEY NOT NULL,
	--SoTienNoToiDaLoai2 MONEY NOT NULL,
)

CREATE TABLE MATHANG(
	MaMatHang CHAR(4) NOT NULL,
	TenMatHang NVARCHAR(30) NOT NULL,
	SoLuongTon INT NOT NULL
	CONSTRAINT PK_KEY_MH PRIMARY KEY (MaMatHang)
)

CREATE TABLE DONVITINH(
	MaDonViTinh CHAR(4) NOT NULL,
	TenDonViTinh NVARCHAR(10) NOT NULL
	CONSTRAINT PK_KEY_DVT PRIMARY KEY (MaDonViTinh)
)

CREATE TABLE PHIEUXUAT(
	MaPhieuXuat CHAR(4) NOT NULL,
	MaDaiLy CHAR(4) NOT NULL,
	NgayLapPhieu SMALLDATETIME NOT NULL,
	TongTriGia Money NOT NULL
	CONSTRAINT PK_KEY_PX PRIMARY KEY (MaPhieuXuat)
)

CREATE TABLE CHITIETPHIEUXUAT(
	MaCTPhieuXuat CHAR(4) NOT NULL,
	MaPhieuXuat CHAR(4) NOT NULL,
	MaMatHang CHAR(4) NOT NULL,
	MaDonViTinh CHAR(4) NOT NULL,
	SoLuongXuat INT NOT NULL,
	DonGia MONEY NOT NULL,
	ThanhTien MONEY NOT NULL
	CONSTRAINT PK_KEY_CTPX PRIMARY KEY (MaCTPhieuXuat)
)

------------------------------------------------------------------------
CREATE TABLE PHIEUTHUTIEN(
	MaPhieuThu CHAR(4) NOT NULL,
	MaDaiLy CHAR(4) NOT NULL,
	NgayThuTien SMALLDATETIME NOT NULL,
	SoTienThu MONEY NOT NULL
	CONSTRAINT PK_KEY_PTT PRIMARY KEY (MaPhieuThu)
)

CREATE TABLE BAOCAODOANHSO(
	MaBaoCaoDoanhSo CHAR(4) NOT NULL,
	ThoiGian SMALLDATETIME NOT NULL,
	MaDaiLy CHAR(4) NOT NULL,
	SoPhieuXuat INT NOT NULL,
	TongTriGia MONEY NOT NULL,
	TyLe FLOAT NOT NULL,
	CONSTRAINT PK_KEY_BCDS PRIMARY KEY (MaBaoCaoDoanhSo)
)

CREATE TABLE BAOCAOCONGNO(
	MaBaoCaoCongNo CHAR(4) NOT NULL,
	ThoiGian SMALLDATETIME NOT NULL,
	MaDaiLy CHAR(4) NOT NULL,
	NoDau MONEY NOT NULL,
	PhatSinh MONEY NOT NULL,
	NoCuoi MONEY NOT NULL,
	CONSTRAINT PK_KEY_BCCN PRIMARY KEY (MaBaoCaoCongNo)
)

--ENABLE RÀNG BUỘC KHÓA NGOẠI CHO CÁC BẢNG
ALTER TABLE DAILY ADD CONSTRAINT FK_KEY_DL_LDL FOREIGN KEY (MaLoaiDaiLy) REFERENCES LOAIDAILY(MaLoaiDaiLy)
ALTER TABLE DAILY ADD CONSTRAINT FK_KEY_DL_Q FOREIGN KEY (MaQuan) REFERENCES QUAN(MaQuan)
ALTER TABLE PHIEUXUAT ADD CONSTRAINT FK_KEY_PX_DL FOREIGN KEY (MaDaiLy) REFERENCES DAILY(MaDaiLy)
ALTER TABLE CHITIETPHIEUXUAT ADD CONSTRAINT FK_KEY_CTPX_PX FOREIGN KEY (MaPhieuXuat) REFERENCES PHIEUXUAT(MaPhieuXuat)
ALTER TABLE CHITIETPHIEUXUAT ADD CONSTRAINT FK_KEY_CTPX_MH FOREIGN KEY (MaMatHang) REFERENCES MATHANG(MaMatHang)
ALTER TABLE CHITIETPHIEUXUAT ADD CONSTRAINT FK_KEY_CTPX_DVT FOREIGN KEY (MaDonViTinh) REFERENCES DONVITINH(MaDonViTinh)
----------------------------------------------
ALTER TABLE PHIEUTHUTIEN ADD CONSTRAINT FK_KEY_PTT_DL FOREIGN KEY (MaDaiLy) REFERENCES DAILY(MaDaiLy)
ALTER TABLE BAOCAODOANHSO ADD CONSTRAINT FK_KEY_BCDS_DL FOREIGN KEY (MaDaiLy) REFERENCES DAILY(MaDaiLy)
ALTER TABLE BAOCAOCONGNO ADD CONSTRAINT FK_KEY_BCCN_DL FOREIGN KEY (MaDaiLy) REFERENCES DAILY(MaDaiLy)

--DISABLE RÀNG BUỘC KHÓA CHÍNH CHO CÁC BẢNG
ALTER TABLE DAILY DROP CONSTRAINT PK_KEY_DL
ALTER TABLE LOAIDAILY DROP CONSTRAINT PK_KEY_LDL
ALTER TABLE QUAN DROP CONSTRAINT PK_KEY_Q
ALTER TABLE MATHANG DROP CONSTRAINT PK_KEY_MH
ALTER TABLE DONVITINH DROP CONSTRAINT PK_KEY_DVT
ALTER TABLE PHIEUXUAT DROP CONSTRAINT PK_KEY_PX
ALTER TABLE CHITIETPHIEUXUAT DROP CONSTRAINT PK_KEY_CTPX
---------------------------------------------
ALTER TABLE PHIEUTHUTIEN DROP CONSTRAINT PK_KEY_PTT
ALTER TABLE BAOCAODOANHSO DROP CONSTRAINT PK_KEY_BCDS
ALTER TABLE BAOCAOCONGNO DROP CONSTRAINT PK_KEY_BCCN

--DISABLE RÀNG BUỘC KHÓA NGOẠI CHO CÁC BẢNG
ALTER TABLE DAILY DROP CONSTRAINT FK_KEY_DL_LDL
ALTER TABLE DAILY DROP CONSTRAINT FK_KEY_DL_Q
ALTER TABLE PHIEUXUAT DROP CONSTRAINT FK_KEY_PX_DL
ALTER TABLE CHITIETPHIEUXUAT DROP CONSTRAINT FK_KEY_CTPX_PX
ALTER TABLE CHITIETPHIEUXUAT DROP CONSTRAINT FK_KEY_CTPX_MH
ALTER TABLE CHITIETPHIEUXUAT DROP CONSTRAINT FK_KEY_CTPX_DVT
----------------------------------------------
ALTER TABLE PHIEUTHUTIEN DROP CONSTRAINT FK_KEY_PTT_DL 
ALTER TABLE BAOCAODOANHSO DROP CONSTRAINT FK_KEY_BCDS_DL 
ALTER TABLE BAOCAOCONGNO DROP CONSTRAINT FK_KEY_BCCN_DL

--DISABLE CONSTRAINTS (use for update) 
ALTER TABLE DAILY NOCHECK CONSTRAINT ALL
ALTER TABLE LOAIDAILY NOCHECK CONSTRAINT ALL
ALTER TABLE QUAN NOCHECK CONSTRAINT ALL
ALTER TABLE MATHANG NOCHECK CONSTRAINT ALL
ALTER TABLE DONVITINH NOCHECK CONSTRAINT ALL
ALTER TABLE PHIEUXUAT NOCHECK CONSTRAINT ALL
ALTER TABLE CHITIETPHIEUXUAT NOCHECK CONSTRAINT ALL
ALTER TABLE PHIEUTHUTIEN NOCHECK CONSTRAINT ALL
ALTER TABLE BAOCAODOANHSO NOCHECK CONSTRAINT ALL
ALTER TABLE BAOCAOCONGNO NOCHECK CONSTRAINT ALL

--RE-ENABLE CONSTRAINTS 
ALTER TABLE DAILY WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE LOAIDAILY WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE QUAN WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE MATHANG WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE DONVITINH WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE PHIEUXUAT WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE CHITIETPHIEUXUAT WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE PHIEUTHUTIEN WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE BAOCAODOANHSO WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE BAOCAOCONGNO WITH CHECK CHECK CONSTRAINT ALL

--XÓA TẤT CẢ BẢNG (PHẢI XÓA CÁC RÀNG BUỘC TRƯỚC)
DROP TABLE DAILY
DROP TABLE LOAIDAILY
DROP TABLE QUAN
DROP TABLE DONVITINH
DROP TABLE MATHANG
DROP TABLE THAMSO
DROP TABLE PHIEUXUAT
DROP TABLE CHITIETPHIEUXUAT
DROP TABLE PHIEUTHUTIEN 
DROP TABLE BAOCAODOANHSO 
DROP TABLE BAOCAOCONGNO

--FORMAT DATE
set dateformat dmy

--INSERT DATA FOR DAILY
INSERT INTO DAILY VALUES('DL01', 'LDL1', N'Đại lý Binh Minh', 351615426, '68 Chu Văn An', 'QU15', '8/5/2016','',15000)
INSERT INTO DAILY VALUES('DL02', 'LDL2', N'Đại lý Asus', 627941517, '69 Bui Dinh Tuy', 'QU15', '10/6/2016','asus@gmail.com',29000)
INSERT INTO DAILY VALUES('DL03', 'LDL1', N'Đại lýy Acer', 351617836, '70 Nam Ky Khoi Nghia', 'QU03', '12/4/2015','acer@yahoo.com',18000)
INSERT INTO DAILY VALUES('DL04', 'LDL2', N'Đại lý Gigabyte', 352825546, '78 Le Hong Phong', 'QU10', '13/7/2014','Gigabyte@hotmail.com',50000)
INSERT INTO DAILY VALUES('DL05', 'LDL2', N'Đại lý Sony', 351784746, '167 Ba Thang Hai', 'QU10', '22/5/2015','Sony@gmail.com',45000)
INSERT INTO DAILY VALUES('DL06', 'LDL1', N'Đại lý DELL', 351222486, '462 Su Van Hanh', 'QU10', '28/12/2014','DELL@gmail.com',12000)
INSERT INTO DAILY VALUES('DL07', 'LDL1', N'Đại lý Baby', 621591957, '265 Le Thanh Ton', 'QU01', '18/3/2016','',1000)
INSERT INTO DAILY VALUES('DL08', 'LDL2', N'Đại lý Sport', 627941257, '165/27 Nguyen Trai', 'QU01', '23/1/2016','',15000)
INSERT INTO DAILY VALUES('DL09', 'LDL1', N'Đại lý Foody', 351313346, '24 Nguyen Duy Trinh', 'QU02', '14/9/2015','',6000)
INSERT INTO DAILY VALUES('DL10', 'LDL2', N'Dai Ly MTP', 627941357, '33 Hong Bang', 'QU05', '25/10/2015','',25000)
INSERT INTO DAILY VALUES('DL11', 'LDL1', N'Đại lý Kaspersky', 350444546, '45 An Duong Vuong', 'QU05', '24/9/2013','',12000)
INSERT INTO DAILY VALUES('DL12', 'LDL2', N'Đại lý AVG', 351708946, '25 Tan Trao', 'QU07', '21/8/2014','',37000)
INSERT INTO DAILY VALUES('DL13', 'LDL1', N'Đại lý Panda', 627213157, '12 Kha Van Can', 'QU13', '17/5/2013','',8000)
INSERT INTO DAILY VALUES('DL14', 'LDL2', N'Đại lý Nvdia', 351201446, '24 Pham Van Dong', 'QU13', '20/10/2016','',44000)
INSERT INTO DAILY VALUES('DL15', 'LDL1', N'Đại lý AMD', 627140157, '99 Quang Trung', 'QU14', '21/2/2015','',10000)
INSERT INTO DAILY VALUES('DL16', 'LDL2', N'Đại lý Intel', 351153746, '74 Hoang Van Thu', 'QU17', '18/11/2014','',36000)

--INSERT DATA FOR MATHANG
INSERT INTO MATHANG VALUES('MH01', N'Mì gói',27)
INSERT INTO MATHANG VALUES('MH02', N'Sữa',103)
INSERT INTO MATHANG VALUES('MH03', N'Gạo',69)
INSERT INTO MATHANG VALUES('MH04', N'Điện thoại', 13)
INSERT INTO MATHANG VALUES('MH05', N'Bút chì', 46)

--INSERT DATA FOR PHIEUXUAT
INSERT INTO PHIEUXUAT VALUES('PX01','DL01','30/04/2017', 22000)
INSERT INTO PHIEUXUAT VALUES('PX02','DL01','21/12/2016', 22000)
INSERT INTO PHIEUXUAT VALUES('PX03','DL02','25/10/2016', 12500)

--INSERT DATA FOR CHITIETPHIEUXUAT
INSERT INTO CHITIETPHIEUXUAT VALUES('CT01','PX01','MH02', 'DV01', 12, 1000, 12000)
INSERT INTO CHITIETPHIEUXUAT VALUES('CT02','PX02','MH01', 'DV01', 20, 500, 10000)
INSERT INTO CHITIETPHIEUXUAT VALUES('CT03','PX03','MH03', 'DV02', 5, 2500, 12500)

--INSERT DATA FOR LOAIDAILY
INSERT INTO DONVITINH VALUES('DV01', N'Thùng')
INSERT INTO DONVITINH VALUES('DV02', N'Kg')
INSERT INTO DONVITINH VALUES('DV03', N'Cái')

--INSERT DATA FOR LOAIDAILY
INSERT INTO LOAIDAILY VALUES('LDL1', N'Đại lý loại 1', 20000)
INSERT INTO LOAIDAILY VALUES('LDL2', N'Đại lý loại 2', 50000)

--INSERT DATA FOR QUAN
INSERT INTO QUAN VALUES('QU01', N'Quận 1')
INSERT INTO QUAN VALUES('QU02', N'Quận 2')
INSERT INTO QUAN VALUES('QU03', N'Quận 3')
INSERT INTO QUAN VALUES('QU04', N'Quận 4')
INSERT INTO QUAN VALUES('QU05', N'Quận 5')
INSERT INTO QUAN VALUES('QU06', N'Quận 6')
INSERT INTO QUAN VALUES('QU07', N'Quận 7')
INSERT INTO QUAN VALUES('QU08', N'Quận 8')
INSERT INTO QUAN VALUES('QU09', N'Quận 9')
INSERT INTO QUAN VALUES('QU10', N'Quận 10')
INSERT INTO QUAN VALUES('QU11', N'Quận 11')
INSERT INTO QUAN VALUES('QU12', N'Quận 12')
INSERT INTO QUAN VALUES('QU13', N'Quận Thủ Đức')
INSERT INTO QUAN VALUES('QU14', N'Quận Gò Vấp')
INSERT INTO QUAN VALUES('QU15', N'Quận Bình Thạnh')
INSERT INTO QUAN VALUES('QU16', N'Quận Bình Tân')
INSERT INTO QUAN VALUES('QU17', N'Quận Phú Nhuận')
INSERT INTO QUAN VALUES('QU18', N'Quận Tân Bình')
INSERT INTO QUAN VALUES('QU19', N'Quận Tân Phú')

--INSERT DATA FOR THAMSO
INSERT INTO THAMSO(SoLuongDLToiDa, ApDung) VALUES(4, 0)

--INSERT DATA FOR PHIEUTHUTIEN
INSERT INTO PHIEUTHUTIEN VALUES('PT01','DL01','02/06/2017', 25000)
INSERT INTO PHIEUTHUTIEN VALUES('PT02','DL02','11/02/2017', 10000)

--DELETE ALL DATA (Phải xóa ràng buộc)
DELETE FROM DAILY
DELETE FROM LOAIDAILY
DELETE FROM QUAN
DELETE FROM DONVITINH
DELETE FROM MATHANG
DELETE FROM THAMSO
DELETE FROM PHIEUXUAT
DELETE FROM CHITIETPHIEUXUAT
DELETE FROM PHIEUTHUTIEN 
DELETE FROM BAOCAODOANHSO 
DELETE FROM BAOCAOCONGNO

--CHECK ALL DATA
SELECT * FROM DAILY
SELECT * FROM LOAIDAILY
SELECT * FROM DONVITINH
SELECT * FROM MATHANG
SELECT * FROM QUAN
SELECT * FROM PHIEUXUAT
SELECT * FROM CHITIETPHIEUXUAT
SELECT * FROM PHIEUTHUTIEN 
SELECT * FROM BAOCAODOANHSO 
SELECT * FROM BAOCAOCONGNO