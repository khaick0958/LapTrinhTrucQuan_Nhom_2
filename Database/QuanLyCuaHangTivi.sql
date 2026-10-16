
IF DB_ID(N'QuanLyCuaHangTivi') IS NULL
    CREATE DATABASE QuanLyCuaHangTivi;
GO
USE QuanLyCuaHangTivi;
GO

DROP TABLE IF EXISTS ChiTietHoaDonBan;
DROP TABLE IF EXISTS ChiTietHoaDonNhap;
DROP TABLE IF EXISTS HoaDonBan;
DROP TABLE IF EXISTS HoaDonNhap;
DROP TABLE IF EXISTS Tivi;
DROP TABLE IF EXISTS NhanVien;
DROP TABLE IF EXISTS KhachHang;
DROP TABLE IF EXISTS NhaCungCap;
DROP TABLE IF EXISTS HangSanXuat;
DROP TABLE IF EXISTS KieuDang;
DROP TABLE IF EXISTS MauSac;
DROP TABLE IF EXISTS ManHinh;
DROP TABLE IF EXISTS CoManHinh;
DROP TABLE IF EXISTS NuocSanXuat;
DROP TABLE IF EXISTS CaLam;
DROP TABLE IF EXISTS CongViec;
GO

CREATE TABLE HangSanXuat (
    MaHang VARCHAR(10) PRIMARY KEY,
    TenHang NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE KieuDang (
    MaKieu VARCHAR(10) PRIMARY KEY,
    TenKieu NVARCHAR(100) NOT NULL
);

CREATE TABLE MauSac (
    MaMau VARCHAR(10) PRIMARY KEY,
    TenMau NVARCHAR(50) NOT NULL
);

CREATE TABLE ManHinh (
    MaManHinh VARCHAR(10) PRIMARY KEY,
    TenManHinh NVARCHAR(100) NOT NULL
);

CREATE TABLE CoManHinh (
    MaCo VARCHAR(10) PRIMARY KEY,
    KichThuocInch INT NOT NULL CHECK (KichThuocInch > 0)
);

CREATE TABLE NuocSanXuat (
    MaNuoc VARCHAR(10) PRIMARY KEY,
    TenNuoc NVARCHAR(100) NOT NULL
);

CREATE TABLE CaLam (
    MaCa VARCHAR(10) PRIMARY KEY,
    TenCa NVARCHAR(50) NOT NULL,
    GioBatDau TIME NULL,
    GioKetThuc TIME NULL
);

CREATE TABLE CongViec (
    MaCV VARCHAR(10) PRIMARY KEY,
    TenCV NVARCHAR(100) NOT NULL
);

CREATE TABLE NhanVien (
    MaNV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(10) NULL CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    NgaySinh DATE NULL,
    DienThoai VARCHAR(15) NULL,
    DiaChi NVARCHAR(200) NULL,
    MaCa VARCHAR(10) NULL REFERENCES CaLam(MaCa),
    MaCV VARCHAR(10) NULL REFERENCES CongViec(MaCV)
);

CREATE TABLE KhachHang (
    MaKhach VARCHAR(10) PRIMARY KEY,
    TenKhach NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200) NULL,
    DienThoai VARCHAR(15) NULL
);

CREATE TABLE NhaCungCap (
    MaNCC VARCHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(150) NOT NULL,
    DiaChi NVARCHAR(200) NULL,
    DienThoai VARCHAR(15) NULL
);

CREATE TABLE Tivi (
    MaTivi VARCHAR(10) PRIMARY KEY,
    TenTivi NVARCHAR(150) NOT NULL,
    MaHang VARCHAR(10) NOT NULL REFERENCES HangSanXuat(MaHang),
    MaKieu VARCHAR(10) NULL REFERENCES KieuDang(MaKieu),
    MaMau VARCHAR(10) NULL REFERENCES MauSac(MaMau),
    MaManHinh VARCHAR(10) NULL REFERENCES ManHinh(MaManHinh),
    MaCo VARCHAR(10) NULL REFERENCES CoManHinh(MaCo),
    MaNuoc VARCHAR(10) NULL REFERENCES NuocSanXuat(MaNuoc),
    SoLuong INT NOT NULL DEFAULT 0 CHECK (SoLuong >= 0),
    GiaNhap DECIMAL(18,2) NOT NULL CHECK (GiaNhap >= 0),
    GiaBan AS (CONVERT(DECIMAL(18,2), GiaNhap * 1.10)) PERSISTED,
    ThoiGianBaoHanhThang INT NOT NULL DEFAULT 24,
    Anh NVARCHAR(255) NULL
);

CREATE TABLE HoaDonNhap (
    SoHDN VARCHAR(15) PRIMARY KEY,
    MaNV VARCHAR(10) NOT NULL REFERENCES NhanVien(MaNV),
    MaNCC VARCHAR(10) NOT NULL REFERENCES NhaCungCap(MaNCC),
    NgayNhap DATE NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TongTien >= 0)
);

CREATE TABLE ChiTietHoaDonNhap (
    SoHDN VARCHAR(15) NOT NULL REFERENCES HoaDonNhap(SoHDN),
    MaTivi VARCHAR(10) NOT NULL REFERENCES Tivi(MaTivi),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    GiamGia DECIMAL(5,2) NOT NULL DEFAULT 0 CHECK (GiamGia BETWEEN 0 AND 100),
    ThanhTien AS (CONVERT(DECIMAL(18,2), SoLuong * DonGia * (1 - GiamGia / 100.0))) PERSISTED,
    CONSTRAINT PK_ChiTietHoaDonNhap PRIMARY KEY (SoHDN, MaTivi)
);

CREATE TABLE HoaDonBan (
    SoHDB VARCHAR(15) PRIMARY KEY,
    MaNV VARCHAR(10) NOT NULL REFERENCES NhanVien(MaNV),
    MaKhach VARCHAR(10) NOT NULL REFERENCES KhachHang(MaKhach),
    NgayBan DATE NOT NULL DEFAULT GETDATE(),
    Thue DECIMAL(5,2) NOT NULL DEFAULT 0 CHECK (Thue BETWEEN 0 AND 100),
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TongTien >= 0)
);

CREATE TABLE ChiTietHoaDonBan (
    SoHDB VARCHAR(15) NOT NULL REFERENCES HoaDonBan(SoHDB),
    MaTivi VARCHAR(10) NOT NULL REFERENCES Tivi(MaTivi),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    GiamGia DECIMAL(5,2) NOT NULL DEFAULT 0 CHECK (GiamGia BETWEEN 0 AND 100),
    ThanhTien AS (CONVERT(DECIMAL(18,2), SoLuong * DonGia * (1 - GiamGia / 100.0))) PERSISTED,
    CONSTRAINT PK_ChiTietHoaDonBan PRIMARY KEY (SoHDB, MaTivi)
);
GO

-- Du lieu mau danh muc
INSERT INTO HangSanXuat VALUES
('HSX01', N'Samsung'), ('HSX02', N'LG'), ('HSX03', N'Sony'),
('HSX04', N'TCL'), ('HSX05', N'Xiaomi');

INSERT INTO KieuDang VALUES
('KD01', N'Tivi phang'), ('KD02', N'Tivi cong'), ('KD03', N'Tivi khung tranh');

INSERT INTO MauSac VALUES
('M01', N'Den'), ('M02', N'Bac'), ('M03', N'Trang');

INSERT INTO ManHinh VALUES
('MH01', N'LED'), ('MH02', N'QLED'), ('MH03', N'OLED'),
('MH04', N'Mini LED'), ('MH05', N'Crystal UHD');

INSERT INTO CoManHinh VALUES
('C32', 32), ('C43', 43), ('C50', 50), ('C55', 55), ('C65', 65), ('C75', 75);

INSERT INTO NuocSanXuat VALUES
('N01', N'Han Quoc'), ('N02', N'Nhat Ban'), ('N03', N'Trung Quoc'), ('N04', N'Viet Nam');

INSERT INTO CaLam VALUES
('CA01', N'Ca sang', '08:00', '12:00'),
('CA02', N'Ca chieu', '13:00', '17:00'),
('CA03', N'Ca toi', '17:00', '21:00');

INSERT INTO CongViec VALUES
('CV01', N'Quan ly'), ('CV02', N'Thu ngan'), ('CV03', N'Ban hang'), ('CV04', N'Kho hang');

INSERT INTO NhanVien VALUES
('NV01', N'Nguyen Van An', N'Nam', '2000-03-15', '0901000001', N'Ha Noi', 'CA01', 'CV01'),
('NV02', N'Tran Thi Binh', N'Nu', '2001-07-22', '0901000002', N'Ha Noi', 'CA02', 'CV02'),
('NV03', N'Le Quang Huy', N'Nam', '2002-11-09', '0901000003', N'Bac Ninh', 'CA01', 'CV03'),
('NV04', N'Pham Thu Ha', N'Nu', '1999-05-30', '0901000004', N'Ha Noi', 'CA03', 'CV04');

INSERT INTO KhachHang VALUES
('KH01', N'Pham Minh Duc', N'Ha Noi', '0912000001'),
('KH02', N'Nguyen Thu Trang', N'Bac Ninh', '0912000002'),
('KH03', N'Tran Hoang Nam', N'Ha Noi', '0912000003'),
('KH04', N'Le Mai Anh', N'Hai Duong', '0912000004'),
('KH05', N'Vu Tuan Kiet', N'Ha Noi', '0912000005');

INSERT INTO NhaCungCap VALUES
('NCC01', N'Cong ty Dien may An Phat', N'Ha Noi', '0243000001'),
('NCC02', N'Cong ty Tivi Viet', N'Bac Ninh', '0222000002'),
('NCC03', N'Cong ty Dien tu Minh Long', N'Ha Noi', '0243000003'),
('NCC04', N'Cong ty Phan phoi Sao Viet', N'Hai Phong', '0225000004');

-- Ton kho ban dau la 0; so luong va gia se duoc cap nhat qua phieu nhap.
INSERT INTO Tivi (MaTivi, TenTivi, MaHang, MaKieu, MaMau, MaManHinh, MaCo, MaNuoc, SoLuong, GiaNhap, ThoiGianBaoHanhThang, Anh) VALUES
('TV01', N'Samsung Crystal UHD 43 inch', 'HSX01', 'KD01', 'M01', 'MH05', 'C43', 'N01', 0, 6500000, 24, N'samsung43.jpg'),
('TV02', N'LG QNED 50 inch', 'HSX02', 'KD01', 'M01', 'MH02', 'C50', 'N01', 0, 9200000, 24, N'lg50.jpg'),
('TV03', N'Sony Bravia OLED 55 inch', 'HSX03', 'KD01', 'M01', 'MH03', 'C55', 'N02', 0, 18500000, 36, N'sony55.jpg'),
('TV04', N'TCL QLED 55 inch', 'HSX04', 'KD01', 'M02', 'MH02', 'C55', 'N03', 0, 7800000, 24, N'tcl55.jpg'),
('TV05', N'Xiaomi A Pro 43 inch', 'HSX05', 'KD01', 'M01', 'MH02', 'C43', 'N03', 0, 4800000, 24, N'xiaomi43.jpg'),
('TV06', N'Samsung Neo QLED 65 inch', 'HSX01', 'KD01', 'M01', 'MH04', 'C65', 'N01', 0, 24000000, 36, N'samsung65.jpg'),
('TV07', N'LG LED 32 inch', 'HSX02', 'KD01', 'M03', 'MH01', 'C32', 'N01', 0, 3200000, 24, N'lg32.jpg'),
('TV08', N'Sony LED 43 inch', 'HSX03', 'KD01', 'M01', 'MH01', 'C43', 'N02', 0, 5900000, 24, N'sony43.jpg');
GO
-- Trigger nhap hang: tang ton kho va cap nhat tong tien hoa don nhap
CREATE TRIGGER TR_ChiTietHoaDonNhap_Insert
ON ChiTietHoaDonNhap
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE T SET T.SoLuong = T.SoLuong + I.SoLuong,
                 T.GiaNhap = I.DonGia
    FROM Tivi T JOIN inserted I ON T.MaTivi = I.MaTivi;

    UPDATE H SET H.TongTien = X.Tong
    FROM HoaDonNhap H
    JOIN (SELECT SoHDN, SUM(ThanhTien) Tong FROM ChiTietHoaDonNhap GROUP BY SoHDN) X
      ON X.SoHDN = H.SoHDN;
END;
GO

-- Trigger ban hang: tru ton kho, khong cho ban vuot ton, cap nhat tong tien hoa don
CREATE TRIGGER TR_ChiTietHoaDonBan_Insert
ON ChiTietHoaDonBan
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1 FROM inserted I JOIN Tivi T ON T.MaTivi = I.MaTivi
        WHERE T.SoLuong < I.SoLuong
    )
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50001, N'So luong ton kho khong du de ban.', 1;
    END;

    UPDATE T SET T.SoLuong = T.SoLuong - I.SoLuong
    FROM Tivi T JOIN inserted I ON T.MaTivi = I.MaTivi;

    UPDATE H SET H.TongTien = X.Tong
    FROM HoaDonBan H
    JOIN (
        SELECT C.SoHDB,
               SUM(C.ThanhTien) * (1 + MAX(H2.Thue) / 100.0) AS Tong
        FROM ChiTietHoaDonBan C JOIN HoaDonBan H2 ON H2.SoHDB = C.SoHDB
        GROUP BY C.SoHDB
    ) X ON X.SoHDB = H.SoHDB;
END;
GO

-- Hoa don nhap mau
INSERT INTO HoaDonNhap (SoHDN, MaNV, MaNCC, NgayNhap) VALUES
('HDN001', 'NV04', 'NCC01', '2026-01-05'),
('HDN002', 'NV04', 'NCC02', '2026-02-10'),
('HDN003', 'NV04', 'NCC01', '2026-03-15'),
('HDN004', 'NV01', 'NCC03', '2026-04-02'),
('HDN005', 'NV04', 'NCC04', '2026-05-20');

INSERT INTO ChiTietHoaDonNhap (SoHDN, MaTivi, SoLuong, DonGia, GiamGia) VALUES
('HDN001', 'TV01', 10, 6500000, 0),
('HDN001', 'TV07', 8, 3200000, 0),
('HDN002', 'TV02', 6, 9200000, 2),
('HDN002', 'TV05', 10, 4800000, 0),
('HDN003', 'TV03', 4, 18500000, 0),
('HDN003', 'TV04', 8, 7800000, 1),
('HDN004', 'TV06', 3, 24000000, 0),
('HDN004', 'TV01', 5, 6500000, 0),
('HDN005', 'TV08', 10, 5900000, 0),
('HDN005', 'TV05', 6, 4800000, 0);

-- Hoa don ban mau
INSERT INTO HoaDonBan (SoHDB, MaNV, MaKhach, NgayBan, Thue) VALUES
('HDB001', 'NV02', 'KH01', '2026-01-12', 8),
('HDB002', 'NV03', 'KH01', '2026-02-18', 8),
('HDB003', 'NV02', 'KH02', '2026-03-22', 8),
('HDB004', 'NV03', 'KH03', '2026-04-10', 8),
('HDB005', 'NV02', 'KH01', '2026-05-08', 8),
('HDB006', 'NV03', 'KH04', '2026-07-19', 8),
('HDB007', 'NV02', 'KH05', '2026-08-11', 8);

INSERT INTO ChiTietHoaDonBan (SoHDB, MaTivi, SoLuong, DonGia, GiamGia) VALUES
('HDB001', 'TV01', 1, 7150000, 0),
('HDB001', 'TV07', 1, 3520000, 0),
('HDB002', 'TV01', 1, 7150000, 5),
('HDB002', 'TV05', 1, 5280000, 0),
('HDB003', 'TV02', 1, 10120000, 0),
('HDB004', 'TV04', 2, 8580000, 3),
('HDB005', 'TV01', 2, 7150000, 0),
('HDB005', 'TV08', 1, 6490000, 0),
('HDB006', 'TV03', 1, 20350000, 5),
('HDB007', 'TV05', 2, 5280000, 0);
GO

-- 1. Tim kiem Tivi theo hang, man hinh, co man hinh (tham so NULL la bo qua dieu kien)
CREATE OR ALTER PROCEDURE sp_TimKiemTivi
    @MaHang VARCHAR(10) = NULL,
    @MaManHinh VARCHAR(10) = NULL,
    @MaCo VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT T.MaTivi, T.TenTivi, H.TenHang, M.TenManHinh, C.KichThuocInch,
           T.SoLuong, T.GiaNhap, T.GiaBan
    FROM Tivi T
    JOIN HangSanXuat H ON H.MaHang = T.MaHang
    LEFT JOIN ManHinh M ON M.MaManHinh = T.MaManHinh
    LEFT JOIN CoManHinh C ON C.MaCo = T.MaCo
    WHERE (@MaHang IS NULL OR T.MaHang = @MaHang)
      AND (@MaManHinh IS NULL OR T.MaManHinh = @MaManHinh)
      AND (@MaCo IS NULL OR T.MaCo = @MaCo)
    ORDER BY T.TenTivi;
END;
GO

-- 2. Tim cac hoa don nhap theo ma tivi va khoang so luong nhap
CREATE OR ALTER PROCEDURE sp_TimHoaDonNhapTheoTivi
    @MaTivi VARCHAR(10),
    @SoLuongTu INT = 1,
    @SoLuongDen INT = 2147483647
AS
BEGIN
    SELECT H.SoHDN, H.NgayNhap, N.TenNCC, C.MaTivi, C.SoLuong, C.DonGia, C.ThanhTien
    FROM ChiTietHoaDonNhap C
    JOIN HoaDonNhap H ON H.SoHDN = C.SoHDN
    JOIN NhaCungCap N ON N.MaNCC = H.MaNCC
    WHERE C.MaTivi = @MaTivi AND C.SoLuong BETWEEN @SoLuongTu AND @SoLuongDen
    ORDER BY H.NgayNhap DESC;
END;
GO

-- 3. Top 3 san pham duoc mua nhieu nhat boi mot khach hang
CREATE OR ALTER PROCEDURE sp_Top3TiviTheoKhach
    @MaKhach VARCHAR(10)
AS
BEGIN
    SELECT TOP 3 T.MaTivi, T.TenTivi, SUM(C.SoLuong) AS TongSoLuongMua
    FROM HoaDonBan H
    JOIN ChiTietHoaDonBan C ON C.SoHDB = H.SoHDB
    JOIN Tivi T ON T.MaTivi = C.MaTivi
    WHERE H.MaKhach = @MaKhach
    GROUP BY T.MaTivi, T.TenTivi
    ORDER BY SUM(C.SoLuong) DESC, T.TenTivi;
END;
GO

-- 4. Hoa don va tong tien nhap tu mot nha cung cap
CREATE OR ALTER PROCEDURE sp_HoaDonNhapTheoNCC
    @MaNCC VARCHAR(10)
AS
BEGIN
    SELECT H.SoHDN, H.NgayNhap, N.TenNCC, H.TongTien
    FROM HoaDonNhap H JOIN NhaCungCap N ON N.MaNCC = H.MaNCC
    WHERE H.MaNCC = @MaNCC
    ORDER BY H.NgayNhap DESC;
END;
GO

-- 5. Hoa don ban va tong tien theo quy/nam
CREATE OR ALTER PROCEDURE sp_HoaDonBanTheoQuy
    @Nam INT,
    @Quy INT
AS
BEGIN
    IF @Quy NOT BETWEEN 1 AND 4
        THROW 50002, N'Quy phai tu 1 den 4.', 1;

    SELECT SoHDB, NgayBan, MaKhach, TongTien
    FROM HoaDonBan
    WHERE YEAR(NgayBan) = @Nam AND DATEPART(QUARTER, NgayBan) = @Quy
    ORDER BY NgayBan;
END;
GO

-- 6. Top 5 nha cung cap giao nhieu Tivi nhat trong thang/nam
CREATE OR ALTER PROCEDURE sp_Top5NCCTheoThang
    @Nam INT,
    @Thang INT
AS
BEGIN
    IF @Thang NOT BETWEEN 1 AND 12
        THROW 50003, N'Thang phai tu 1 den 12.', 1;

    SELECT TOP 5 N.MaNCC, N.TenNCC, SUM(C.SoLuong) AS TongSoLuongGiao
    FROM NhaCungCap N
    JOIN HoaDonNhap H ON H.MaNCC = N.MaNCC
    JOIN ChiTietHoaDonNhap C ON C.SoHDN = H.SoHDN
    WHERE YEAR(H.NgayNhap) = @Nam AND MONTH(H.NgayNhap) = @Thang
    GROUP BY N.MaNCC, N.TenNCC
    ORDER BY SUM(C.SoLuong) DESC, N.TenNCC;
END;
GO

-- Cau lenh kiem tra nhanh
SELECT * FROM Tivi;
EXEC sp_TimKiemTivi @MaHang = 'HSX01';
EXEC sp_TimHoaDonNhapTheoTivi @MaTivi = 'TV01';
EXEC sp_Top3TiviTheoKhach @MaKhach = 'KH01';
EXEC sp_HoaDonNhapTheoNCC @MaNCC = 'NCC01';
EXEC sp_HoaDonBanTheoQuy @Nam = 2026, @Quy = 1;
EXEC sp_Top5NCCTheoThang @Nam = 2026, @Thang = 1;
GO
