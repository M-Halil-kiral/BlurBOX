CREATE DATABASE blurBOX;
GO

USE blurBOX;
GO

CREATE TABLE Yoneticiler (
    yoneticiid INT IDENTITY(1,1) PRIMARY KEY,
    yoneticiadi NVARCHAR(50) NOT NULL,
    yoneticisifre NVARCHAR(255) NOT NULL
);

INSERT INTO Yoneticiler (yoneticiadi, yoneticisifre)
VALUES ('admin', '1234');

CREATE TABLE Uyeler (
    uyeid INT IDENTITY(1,1) PRIMARY KEY,
    uyeisim NVARCHAR(50) NOT NULL,
    uyesoyisim NVARCHAR(50) NOT NULL,
    uyekullanciadi NVARCHAR(50) NOT NULL,
    uyesifre NVARCHAR(255) NOT NULL,
    telno NVARCHAR(15)
);

INSERT INTO Uyeler (uyeisim, uyesoyisim, uyekullanciadi, uyesifre, telno)
VALUES ('Test', 'Kullanici', 'test', '1234', '05550000000');

CREATE TABLE Filmler (
    id INT IDENTITY(1,1) PRIMARY KEY,
    baslik NVARCHAR(100) NOT NULL,
    tur NVARCHAR(50) NOT NULL,
    dosya_yolu NVARCHAR(255) NOT NULL
);

CREATE TABLE Muzik (
    id INT IDENTITY(1,1) PRIMARY KEY,
    baslik NVARCHAR(100) NOT NULL,
    sanatci NVARCHAR(100) NOT NULL,
    dosya_yolu NVARCHAR(255) NOT NULL
);