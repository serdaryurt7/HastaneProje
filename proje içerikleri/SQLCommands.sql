-- TBLERSLER tablosu olu�turma
--Create Table TBLDERSLER(DERSID tinyint, DERSAD varchar(20))
--------------------------------------------------------------------------------------------
--Ekleme
--Alter Table TBLDERSLER
--Add KONTENJAN Smallint
--------------------------------------------------------------------------------------------
--Silme
--Alter Table TBLDERSLER
--Drop Column KONTENJAN
--------------------------------------------------------------------------------------------
--Select OGRAD, OGRSOYAD From TBLOGRENCILER
--Select OGRSEHIR From TBLOGRENCILER
--------------------------------------------------------------------------------------------

--Select * From TBLOGRENCILER Where OGRAD='Ali'

--Select * From TBLOGRENCILER Where OGRSEHIR='�zmir' And OGRKULUP='Satran�'

--Select * From TBLOGRENCILER Where OGRSEHIR='Adana' And OGRKULUP ='Kitapl�k'

--Select * From TBLOGRENCILER Where OGRSEHIR='Adana' Or OGRKULUP ='Satran�'
--------------------------------------------------------------------------------------------
--Decimal(x,y)

--x: Virg�lden �nceki basamak say�s�
--y: Virg�lden sonraki basamak say�s�
-- Ortalama: 78,65 ** 100.00 
-- Decimal(5,2)
------------------------------------------------------------------------------------
--SELECT * FROM TBLNOTLAR
--SELECT (SINAV1+SINAV2+SINAV3)/3 FROM TBLNOTLAR

--Insert Into TBLOGRENCILER (OGRAD,OGRSOYAD,OGRSEHIR) Values ('Baran', 'Y�ceda�', 'Elaz��')
--Select * From TBLOGRENCILER

--Insert Into TBLNOTLAR (OGRENCI,DERS, SINAV1, SINAV3) values (6,2,88,67)
-----------------------------------------------------------------------------------------------
--Delete From TBLDERSLER

--Delete From TBLDERSLER Where DERSID=6

--Delete From TBLDERSLER Where DERSAD='Algoritma'
-----------------------------------------------------------------------------------------------
--Truncate Table TBLDERSLER
-----------------------------------------------------------------------------------------------
--Update TBLOGRENCILER Set OGRCINSIYET='Erkek' Where OGRAD='Baran'
--Update TBLOGRENCILER Set OGRKULUP='Kitapl�k' Where OGRAD='Baran'

--Update TBLNOTLAR Set DERS='2'

--Insert Into TBLNOTLAR (OGRENCI,DERS, SINAV1,SINAV2) Values (1,2,85,90)
--Insert Into TBLNOTLAR (OGRENCI,DERS, SINAV1,SINAV2) Values (2,2,45,35)
--Insert Into TBLNOTLAR (OGRENCI,DERS, SINAV1,SINAV2) Values (5,2,78,66)

--Update TBLNOTLAR Set ORTALAMA=(SINAV1+SINAV2+SINAV3)/3
--Update TBLNOTLAR SET DURUM='1' WHERE ORTALAMA >= 50
--UPDATE TBLNOTLAR SET DURUM='0' WHERE ORTALAMA<50
-----------------------------------------------------------------------------------------------
--Select Count(*) From TBLOGRENCILER
--Select Count(*) As 'Toplam Kay�t' From TBLOGRENCILER
--Select Count(*) As 'Toplam Kay�t' From TBLOGRENCILER Where OGRSEHIR='Adana'
--SELECT SUM(SINAV1) FROM TBLNOTLAR
--SELECT SUM(SINAV1), SUM(SINAV2), SUM(SINAV3) FROM TBLNOTLAR
--SELECT AVG(SINAV1), AVG(SINAV2), AVG(SINAV3) FROM TBLNOTLAR
--SELECT MAX(SINAV1), MAX(SINAV2), MAX(SINAV3) FROM TBLNOTLAR
--SELECT MIN(SINAV1), MIN(SINAV2), MIN(SINAV3) FROM TBLNOTLAR
------------------------------------------------------------------------------------------------
--GROUP BY
--SELECT OGRSEHIR,COUNT(*) FROM TBLOGRENCILER GROUP BY OGRSEHIR
--SELECT OGRSEHIR,COUNT(*) AS 'TOPLAM' FROM TBLOGRENCILER GROUP BY OGRSEHIR
--SELECT OGRCINSIYET,COUNT(*) AS 'TOPLAM CINSIYET' FROM TBLOGRENCILER GROUP BY OGRCINSIYET
------------------------------------------------------------------------------------------------
--Ge�en ��renci say�s� ve kalan ��renci say�s�n� bulunuz.

--SELECT DURUM,COUNT(*) AS 'Ge�ti[1] - Kald�[0]' FROM TBLNOTLAR GROUP BY DURUM

SELECT OGRKULUP, COUNT(*) FROM TBLOGRENCILER GROUP BY OGRKULUP