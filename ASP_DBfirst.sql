use master
drop database SinhVienDBFirst
go
create database SinhVienDBFirst
go
use SinhVienDBFirst


CREATE TABLE Khoa (
    KhoaId INT PRIMARY KEY,
    TenKhoa VARCHAR(255)
);
INSERT INTO Khoa (KhoaId, TenKhoa)
VALUES (1, 'Cong nghe so'),
       (2, 'Dien - Dien tu'),
       (3, 'Xay dung');
CREATE TABLE Lop (
    LopId INT PRIMARY KEY,
    TenLop VARCHAR(255),
	KhoaId int FOREIGN KEY REFERENCES Khoa(KhoaId)
);
INSERT INTO Lop (LopId, TenLop, KhoaId)
VALUES (1, 'LTC01', 1),
       (2, 'VKT01', 3),
       (3, 'KTĐ01', 2);
CREATE TABLE SinhVien (
    SinhVienId INT PRIMARY KEY,
    Ten VARCHAR(255),
    Tuoi INT,
    LopId INT,
    FOREIGN KEY (LopId) REFERENCES Lop(LopId)
);
INSERT INTO SinhVien (SinhVienId, Ten, Tuoi, LopId)
VALUES (1, 'Le Ha Binh', 19, 1),
(2, 'Le Ha Binh 2', 24, 2),
(3, 'Le Ha Binh 2', 20, 2),
(4, 'Le Ha Binh 3', 17, 3),
(5, 'Le Ha Binh 4', 18, 1),
(6, 'Le Ha Binh 5', 19, 1),
(7, 'Le Ha Binh 6', 20, 1),
(8, 'Le Ha Binh 7', 19, 1),
(9, 'Le Ha Binh 8', 22, 1),
(10, 'Le Ha Binh 9', 23, 1);
