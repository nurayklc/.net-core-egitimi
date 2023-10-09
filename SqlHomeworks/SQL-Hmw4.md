#### 1) Query film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralayınız.
```SELECT DISTINCT replacement_cost FROM film; ```

#### 2) Query film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?
```SELECT COUNT(DISTINCT replacement_cost) FROM film;```

#### 3) Query film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?
``` SELECT COUNT(*) FROM film WHERE title LIKE 'T%' AND rating='G'```

#### 4) Query country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?
``` SELECT COUNT(*) FROM country WHERE country LIKE '_____';```

#### 5) Query city tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?
``` SELECT COUNT(*) FROM city WHERE city ILIKE '%R';```
