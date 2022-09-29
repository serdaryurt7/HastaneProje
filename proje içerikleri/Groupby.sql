--Select PerSehir, COUNT(*) AS 'Þehir Sayýsý' FROM Tbl_Personel GROUP BY PerSehir
--Select PerMeslek,Count(*) AS 'Meslek Sayýsý' FROM Tbl_Personel Group By PerMeslek
Select PerMeslek,AVG(PerMaas) From Tbl_Personel Group By PerMeslek 