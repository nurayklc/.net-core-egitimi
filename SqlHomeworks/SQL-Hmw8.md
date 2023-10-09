#### 1) Test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
```CREATE TABLE employee(id INTEGER,name VARCHAR(50),birthday DATE,	email VARCHAR(100)); ```

#### 2) Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
- ``` insert into employee (id, name, birthday, email) values (1, 'Daffy Truran', '2023-07-21', 'dtruran0@constantcontact.com');	```	
- ```insert into employee (id, name, birthday, email) values (2, 'Francklin Daveridge', '2023-07-01', 'fdaveridge1@un.org');	```	
- ```insert into employee (id, name, birthday, email) values (3, 'Ailene Vickress', '2023-03-19', 'avickress2@i2i.jp');	```	

#### 3) Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
- ```UPDATE employee SET name = 'TEST' ```	  	
- ```UPDATE employee SET birthday ='1998-01-01',	email='example@com.tr'	```	
- ```UPDATE employee SET name ='youngEmployee'	```	
- ```UPDATE employee SET name ='Example', birthday='2023-01-01'	```	
- ```UPDATE employee SET email='example@com.tr'	```		

#### 4) Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
- ``` DELETE FROM employee WHERE id =2;	```
- ``` DELETE FROM employee WHERE name ILIKE '%a%a%a%'	```	
- ``` DELETE FROM employee WHERE name ='Example'```	
- ``` DELETE FROM employee WHERE id>40;```	
- ``` DELETE FROM employee WHERE (id>10 AND id<20) OR```	
