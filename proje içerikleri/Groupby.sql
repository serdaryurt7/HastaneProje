--Select PerSehir, COUNT(*) AS '�ehir Say�s�' FROM Tbl_Personel GROUP BY PerSehir
--Select PerMeslek,Count(*) AS 'Meslek Say�s�' FROM Tbl_Personel Group By PerMeslek
Select PerMeslek,AVG(PerMaas) From Tbl_Personel Group By PerMeslek 