select Nazwa, Cena, Ilo��, Rodzaj
from Produkt
join Rodzaj on Produkt.id_rodzaj=Rodzaj.id_rodzaj
order by Cena 