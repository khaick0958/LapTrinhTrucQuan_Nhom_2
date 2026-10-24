/* =========================================================
   1. TAO DATABASE
   ========================================================= */

USE TelevisionDB;
GO

-- Kiem tra database hien tai
SELECT DB_NAME() AS CurrentDatabase;
GO

-- Neu can doi chu so huu database sang sa,
-- bo comment 2 dong duoi va chay bang tai khoan sysadmin:
-- USE master;
-- ALTER AUTHORIZATION ON DATABASE::[QuanLyCuaHangTivi] TO [sa];
-- GO
-- USE QuanLyCuaHangTivi;
-- GO


/* =========================================================
   2. XOA CAC BANG CU
   ========================================================= */

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


/* =========================================================
   3. TAO CAC BANG DANH MUC
   ========================================================= */

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
    KichThuocInch INT NOT NULL
        CHECK (KichThuocInch > 0)
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


/* =========================================================
   4. TAO CAC BANG NGHIEP VU
   ========================================================= */

CREATE TABLE NhanVien (
    MaNV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(10) NULL
        CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
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
    MaHang VARCHAR(10) NOT NULL
        REFERENCES HangSanXuat(MaHang),
    MaKieu VARCHAR(10) NULL
        REFERENCES KieuDang(MaKieu),
    MaMau VARCHAR(10) NULL
        REFERENCES MauSac(MaMau),
    MaManHinh VARCHAR(10) NULL
        REFERENCES ManHinh(MaManHinh),
    MaCo VARCHAR(10) NULL
        REFERENCES CoManHinh(MaCo),
    MaNuoc VARCHAR(10) NULL
        REFERENCES NuocSanXuat(MaNuoc),
    SoLuong INT NOT NULL DEFAULT 0
        CHECK (SoLuong >= 0),
    GiaNhap DECIMAL(18,2) NOT NULL
        CHECK (GiaNhap >= 0),
    GiaBan AS (
        CONVERT(DECIMAL(18,2), GiaNhap * 1.10)
    ) PERSISTED,
    ThoiGianBaoHanhThang INT NOT NULL DEFAULT 24,
    Anh NVARCHAR(255) NULL
);

CREATE TABLE HoaDonNhap (
    SoHDN VARCHAR(15) PRIMARY KEY,
    MaNV VARCHAR(10) NOT NULL
        REFERENCES NhanVien(MaNV),
    MaNCC VARCHAR(10) NOT NULL
        REFERENCES NhaCungCap(MaNCC),
    NgayNhap DATE NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0
        CHECK (TongTien >= 0)
);

CREATE TABLE ChiTietHoaDonNhap (
    SoHDN VARCHAR(15) NOT NULL
        REFERENCES HoaDonNhap(SoHDN),
    MaTivi VARCHAR(10) NOT NULL
        REFERENCES Tivi(MaTivi),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    GiamGia DECIMAL(5,2) NOT NULL DEFAULT 0
        CHECK (GiamGia BETWEEN 0 AND 100),
    ThanhTien AS (
        CONVERT(
            DECIMAL(18,2),
            SoLuong * DonGia * (1 - GiamGia / 100.0)
        )
    ) PERSISTED,
    CONSTRAINT PK_ChiTietHoaDonNhap
        PRIMARY KEY (SoHDN, MaTivi)
);

CREATE TABLE HoaDonBan (
    SoHDB VARCHAR(15) PRIMARY KEY,
    MaNV VARCHAR(10) NOT NULL
        REFERENCES NhanVien(MaNV),
    MaKhach VARCHAR(10) NOT NULL
        REFERENCES KhachHang(MaKhach),
    NgayBan DATE NOT NULL DEFAULT GETDATE(),
    Thue DECIMAL(5,2) NOT NULL DEFAULT 0
        CHECK (Thue BETWEEN 0 AND 100),
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0
        CHECK (TongTien >= 0)
);

CREATE TABLE ChiTietHoaDonBan (
    SoHDB VARCHAR(15) NOT NULL
        REFERENCES HoaDonBan(SoHDB),
    MaTivi VARCHAR(10) NOT NULL
        REFERENCES Tivi(MaTivi),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    GiamGia DECIMAL(5,2) NOT NULL DEFAULT 0
        CHECK (GiamGia BETWEEN 0 AND 100),
    ThanhTien AS (
        CONVERT(
            DECIMAL(18,2),
            SoLuong * DonGia * (1 - GiamGia / 100.0)
        )
    ) PERSISTED,
    CONSTRAINT PK_ChiTietHoaDonBan
        PRIMARY KEY (SoHDB, MaTivi)
);
GO


/* =========================================================
   5. DU LIEU MAU DANH MUC
   ========================================================= */

INSERT INTO HangSanXuat VALUES
('HSX01', N'Samsung'),
('HSX02', N'LG'),
('HSX03', N'Sony'),
('HSX04', N'TCL'),
('HSX05', N'Xiaomi');

INSERT INTO KieuDang VALUES
('KD01', N'Tivi phẳng'),
('KD02', N'Tivi cong'),
('KD03', N'Tivi khung tranh');

INSERT INTO MauSac VALUES
('M01', N'Đen'),
('M02', N'Bạc'),
('M03', N'Trắng');

INSERT INTO ManHinh VALUES
('MH01', N'LED'),
('MH02', N'QLED'),
('MH03', N'OLED'),
('MH04', N'Mini LED'),
('MH05', N'Crystal UHD');

INSERT INTO CoManHinh VALUES
('C32', 32),
('C43', 43),
('C50', 50),
('C55', 55),
('C65', 65),
('C75', 75);

INSERT INTO NuocSanXuat VALUES
('N01', N'Hàn Quốc'),
('N02', N'Nhật Bản'),
('N03', N'Trung Quốc'),
('N04', N'Việt Nam');

INSERT INTO CaLam VALUES
('CA01', N'Ca sáng', '08:00', '12:00'),
('CA02', N'Ca chiều', '13:00', '17:00'),
('CA03', N'Ca tối', '17:00', '21:00');

INSERT INTO CongViec VALUES
('CV01', N'Quản lý'),
('CV02', N'Thu ngân'),
('CV03', N'Bán hàng'),
('CV04', N'Kho hàng');


/* =========================================================
   6. DU LIEU MAU NHAN VIEN, KHACH HANG, NHA CUNG CAP
   ========================================================= */

INSERT INTO NhanVien VALUES
('NV01', N'Nguyen Van An', N'Nam',
 '2000-03-15', '0901000001', N'Ha Noi', 'CA01', 'CV01'),
('NV02', N'Tran Thi Binh', N'Nữ',
 '2001-07-22', '0901000002', N'Ha Noi', 'CA02', 'CV02'),
('NV03', N'Le Quang Huy', N'Nam',
 '2002-11-09', '0901000003', N'Bac Ninh', 'CA01', 'CV03'),
('NV04', N'Pham Thu Ha', N'Nữ',
 '1999-05-30', '0901000004', N'Ha Noi', 'CA03', 'CV04');

INSERT INTO KhachHang VALUES
('KH01', N'Pham Minh Duc', N'Ha Noi', '0912000001'),
('KH02', N'Nguyen Thu Trang', N'Bac Ninh', '0912000002'),
('KH03', N'Tran Hoang Nam', N'Ha Noi', '0912000003'),
('KH04', N'Le Mai Anh', N'Hai Duong', '0912000004'),
('KH05', N'Vu Tuan Kiet', N'Ha Noi', '0912000005');

INSERT INTO NhaCungCap VALUES
('NCC01', N'Cong ty Dien may An Phat',
 N'Ha Noi', '0243000001'),
('NCC02', N'Cong ty Tivi Viet',
 N'Bac Ninh', '0222000002'),
('NCC03', N'Cong ty Dien tu Minh Long',
 N'Ha Noi', '0243000003'),
('NCC04', N'Cong ty Phan phoi Sao Viet',
 N'Hai Phong', '0225000004');


/* =========================================================
   7. DU LIEU MAU TIVI
   ========================================================= */

INSERT INTO Tivi
(MaTivi, TenTivi, MaHang, MaKieu, MaMau,
 MaManHinh, MaCo, MaNuoc, SoLuong,
 GiaNhap, ThoiGianBaoHanhThang, Anh)
VALUES
('TV01', N'Samsung Crystal UHD 43 inch',
 'HSX01', 'KD01', 'M01', 'MH05', 'C43', 'N01',
 0, 6500000, 24, N'samsung43.jpg'),

('TV02', N'LG QNED 50 inch',
 'HSX02', 'KD01', 'M01', 'MH02', 'C50', 'N01',
 0, 9200000, 24, N'lg50.jpg'),

('TV03', N'Sony Bravia OLED 55 inch',
 'HSX03', 'KD01', 'M01', 'MH03', 'C55', 'N02',
 0, 18500000, 36, N'sony55.jpg'),

('TV04', N'TCL QLED 55 inch',
 'HSX04', 'KD01', 'M02', 'MH02', 'C55', 'N03',
 0, 7800000, 24, N'tcl55.jpg'),

('TV05', N'Xiaomi A Pro 43 inch',
 'HSX05', 'KD01', 'M01', 'MH02', 'C43', 'N03',
 0, 4800000, 24, N'xiaomi43.jpg'),

('TV06', N'Samsung Neo QLED 65 inch',
 'HSX01', 'KD01', 'M01', 'MH04', 'C65', 'N01',
 0, 24000000, 36, N'samsung65.jpg'),

('TV07', N'LG LED 32 inch',
 'HSX02', 'KD01', 'M03', 'MH01', 'C32', 'N01',
 0, 3200000, 24, N'lg32.jpg'),

('TV08', N'Sony LED 43 inch',
 'HSX03', 'KD01', 'M01', 'MH01', 'C43', 'N02',
 0, 5900000, 24, N'sony43.jpg');
GO


/* =========================================================
   8. TRIGGER NHAP HANG
   - Cong don ton kho theo MaTivi
   - Cap nhat tong tien cac hoa don bi anh huong
   ========================================================= */

CREATE OR ALTER TRIGGER TR_ChiTietHoaDonNhap_Insert
ON ChiTietHoaDonNhap
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Tong hop so luong theo tung tivi
    ;WITH X AS (
        SELECT
            MaTivi,
            SUM(SoLuong) AS TongSoLuong,
            MAX(DonGia) AS GiaNhapThamChieu
        FROM inserted
        GROUP BY MaTivi
    )
    UPDATE T
    SET T.SoLuong = T.SoLuong + X.TongSoLuong,
        T.GiaNhap = X.GiaNhapThamChieu
    FROM Tivi T
    JOIN X ON X.MaTivi = T.MaTivi;

    -- Cap nhat tong tien cac hoa don nhap bi anh huong
    ;WITH HDAnhHuong AS (
        SELECT DISTINCT SoHDN
        FROM inserted
    ),
    Tong AS (
        SELECT
            C.SoHDN,
            SUM(C.ThanhTien) AS TongTien
        FROM ChiTietHoaDonNhap C
        JOIN HDAnhHuong A ON A.SoHDN = C.SoHDN
        GROUP BY C.SoHDN
    )
    UPDATE H
    SET H.TongTien = T.TongTien
    FROM HoaDonNhap H
    JOIN Tong T ON T.SoHDN = H.SoHDN;
END;
GO


/* =========================================================
   9. TRIGGER BAN HANG
   - Kiem tra du ton kho
   - Tru ton kho theo tong so luong tung tivi
   - Cap nhat tong tien hoa don ban
   ========================================================= */

CREATE OR ALTER TRIGGER TR_ChiTietHoaDonBan_Insert
ON ChiTietHoaDonBan
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiem tra tong so luong can ban theo tung tivi
    IF EXISTS (
        SELECT 1
        FROM (
            SELECT MaTivi, SUM(SoLuong) AS TongSoLuong
            FROM inserted
            GROUP BY MaTivi
        ) X
        JOIN Tivi T ON T.MaTivi = X.MaTivi
        WHERE T.SoLuong < X.TongSoLuong
    )
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50001, N'So luong ton kho khong du de ban.', 1;
    END;

    -- Tru ton kho theo tong so luong
    ;WITH X AS (
        SELECT MaTivi, SUM(SoLuong) AS TongSoLuong
        FROM inserted
        GROUP BY MaTivi
    )
    UPDATE T
    SET T.SoLuong = T.SoLuong - X.TongSoLuong
    FROM Tivi T
    JOIN X ON X.MaTivi = T.MaTivi;

    -- Cap nhat tong tien cac hoa don ban bi anh huong
    ;WITH HDAnhHuong AS (
        SELECT DISTINCT SoHDB
        FROM inserted
    ),
    Tong AS (
        SELECT
            C.SoHDB,
            SUM(C.ThanhTien) *
                (1 + MAX(H.Thue) / 100.0) AS TongTien
        FROM ChiTietHoaDonBan C
        JOIN HoaDonBan H ON H.SoHDB = C.SoHDB
        JOIN HDAnhHuong A ON A.SoHDB = C.SoHDB
        GROUP BY C.SoHDB
    )
    UPDATE H
    SET H.TongTien = T.TongTien
    FROM HoaDonBan H
    JOIN Tong T ON T.SoHDB = H.SoHDB;
END;
GO


/* =========================================================
   10. HOA DON NHAP MAU
   ========================================================= */

INSERT INTO HoaDonNhap (SoHDN, MaNV, MaNCC, NgayNhap)
VALUES
('HDN001', 'NV04', 'NCC01', '2026-01-05'),
('HDN002', 'NV04', 'NCC02', '2026-02-10'),
('HDN003', 'NV04', 'NCC01', '2026-03-15'),
('HDN004', 'NV01', 'NCC03', '2026-04-02'),
('HDN005', 'NV04', 'NCC04', '2026-05-20');

INSERT INTO ChiTietHoaDonNhap
(SoHDN, MaTivi, SoLuong, DonGia, GiamGia)
VALUES
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


/* =========================================================
   11. HOA DON BAN MAU
   ========================================================= */

INSERT INTO HoaDonBan
(SoHDB, MaNV, MaKhach, NgayBan, Thue)
VALUES
('HDB001', 'NV02', 'KH01', '2026-01-12', 8),
('HDB002', 'NV03', 'KH01', '2026-02-18', 8),
('HDB003', 'NV02', 'KH02', '2026-03-22', 8),
('HDB004', 'NV03', 'KH03', '2026-04-10', 8),
('HDB005', 'NV02', 'KH01', '2026-05-08', 8),
('HDB006', 'NV03', 'KH04', '2026-07-19', 8),
('HDB007', 'NV02', 'KH05', '2026-08-11', 8);

INSERT INTO ChiTietHoaDonBan
(SoHDB, MaTivi, SoLuong, DonGia, GiamGia)
VALUES
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


/* =========================================================
   12. STORED PROCEDURE 1
   Tim kiem tivi theo hang, man hinh, co man hinh
   ========================================================= */

CREATE OR ALTER PROCEDURE sp_TimKiemTivi
    @MaHang VARCHAR(10) = NULL,
    @MaManHinh VARCHAR(10) = NULL,
    @MaCo VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        T.MaTivi,
        T.TenTivi,
        H.TenHang,
        M.TenManHinh,
        C.KichThuocInch,
        T.SoLuong,
        T.GiaNhap,
        T.GiaBan
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


/* =========================================================
   13. STORED PROCEDURE 2
   Tim hoa don nhap theo tivi va khoang so luong
   ========================================================= */

CREATE OR ALTER PROCEDURE sp_TimHoaDonNhapTheoTivi
    @MaTivi VARCHAR(10),
    @SoLuongTu INT = 1,
    @SoLuongDen INT = 2147483647
AS
BEGIN
    SET NOCOUNT ON;

    IF @SoLuongTu < 0 OR @SoLuongDen < @SoLuongTu
        THROW 50004, N'Khoang so luong khong hop le.', 1;

    SELECT
        H.SoHDN,
        H.NgayNhap,
        N.TenNCC,
        C.MaTivi,
        C.SoLuong,
        C.DonGia,
        C.ThanhTien
    FROM ChiTietHoaDonNhap C
    JOIN HoaDonNhap H ON H.SoHDN = C.SoHDN
    JOIN NhaCungCap N ON N.MaNCC = H.MaNCC
    WHERE C.MaTivi = @MaTivi
      AND C.SoLuong BETWEEN @SoLuongTu AND @SoLuongDen
    ORDER BY H.NgayNhap DESC;
END;
GO


/* =========================================================
   14. STORED PROCEDURE 3
   Top 3 tivi duoc mua nhieu nhat boi mot khach hang
   ========================================================= */

CREATE OR ALTER PROCEDURE sp_Top3TiviTheoKhach
    @MaKhach VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 3
        T.MaTivi,
        T.TenTivi,
        SUM(C.SoLuong) AS TongSoLuongMua
    FROM HoaDonBan H
    JOIN ChiTietHoaDonBan C ON C.SoHDB = H.SoHDB
    JOIN Tivi T ON T.MaTivi = C.MaTivi
    WHERE H.MaKhach = @MaKhach
    GROUP BY T.MaTivi, T.TenTivi
    ORDER BY SUM(C.SoLuong) DESC, T.TenTivi;
END;
GO


/* =========================================================
   15. STORED PROCEDURE 4
   Hoa don nhap theo nha cung cap
   ========================================================= */

CREATE OR ALTER PROCEDURE sp_HoaDonNhapTheoNCC
    @MaNCC VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        H.SoHDN,
        H.NgayNhap,
        N.TenNCC,
        H.TongTien
    FROM HoaDonNhap H
    JOIN NhaCungCap N ON N.MaNCC = H.MaNCC
    WHERE H.MaNCC = @MaNCC
    ORDER BY H.NgayNhap DESC;
END;
GO


/* =========================================================
   16. STORED PROCEDURE 5
   Hoa don ban theo quy va nam
   ========================================================= */

CREATE OR ALTER PROCEDURE sp_HoaDonBanTheoQuy
    @Nam INT,
    @Quy INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @Quy NOT BETWEEN 1 AND 4
        THROW 50002, N'Quy phai tu 1 den 4.', 1;

    SELECT
        SoHDB,
        NgayBan,
        MaKhach,
        TongTien
    FROM HoaDonBan
    WHERE NgayBan >= DATEFROMPARTS(
        @Nam, (@Quy - 1) * 3 + 1, 1
    )
      AND NgayBan < DATEADD(
        QUARTER, 1,
        DATEFROMPARTS(@Nam, (@Quy - 1) * 3 + 1, 1)
    )
    ORDER BY NgayBan;
END;
GO


/* =========================================================
   17. STORED PROCEDURE 6
   Top 5 nha cung cap giao nhieu tivi nhat trong thang
   ========================================================= */

CREATE OR ALTER PROCEDURE sp_Top5NCCTheoThang
    @Nam INT,
    @Thang INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @Thang NOT BETWEEN 1 AND 12
        THROW 50003, N'Thang phai tu 1 den 12.', 1;

    SELECT TOP 5
        N.MaNCC,
        N.TenNCC,
        SUM(C.SoLuong) AS TongSoLuongGiao
    FROM NhaCungCap N
    JOIN HoaDonNhap H ON H.MaNCC = N.MaNCC
    JOIN ChiTietHoaDonNhap C ON C.SoHDN = H.SoHDN
    WHERE H.NgayNhap >= DATEFROMPARTS(@Nam, @Thang, 1)
      AND H.NgayNhap < DATEADD(
          MONTH, 1, DATEFROMPARTS(@Nam, @Thang, 1)
      )
    GROUP BY N.MaNCC, N.TenNCC
    ORDER BY SUM(C.SoLuong) DESC, N.TenNCC;
END;
GO


/* =========================================================
   18. KIEM TRA DU LIEU
   ========================================================= */

-- Danh sach tivi va ton kho
SELECT * FROM Tivi;

-- Danh sach nhan vien
SELECT * FROM NhanVien;

-- Danh sach hoa don nhap va tong tien
SELECT * FROM HoaDonNhap;

-- Danh sach hoa don ban va tong tien
SELECT * FROM HoaDonBan;

-- Tim tivi thuoc hang Samsung
EXEC sp_TimKiemTivi @MaHang = 'HSX01';

-- Tim hoa don nhap co tivi TV01
EXEC sp_TimHoaDonNhapTheoTivi @MaTivi = 'TV01';

-- Top 3 tivi khach KH01 mua nhieu nhat
EXEC sp_Top3TiviTheoKhach @MaKhach = 'KH01';

-- Hoa don nhap tu nha cung cap NCC01
EXEC sp_HoaDonNhapTheoNCC @MaNCC = 'NCC01';

-- Hoa don ban trong quy 1 nam 2026
EXEC sp_HoaDonBanTheoQuy @Nam = 2026, @Quy = 1;

-- Top nha cung cap giao tivi trong thang 1 nam 2026
EXEC sp_Top5NCCTheoThang @Nam = 2026, @Thang = 1;
GO

USE QuanLyCuaHangTivi;
GO

SELECT name
FROM sys.tables
ORDER BY name;