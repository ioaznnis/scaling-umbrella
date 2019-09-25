# База данных

## Cтруктура:

Таблица: People
Поля: 
0. Id (PK)
1. ФИО 
2. Квалификация (FK)
3. Отдел (FK)
4. Стаж
5. Личный транспорт
6. Номер телефона

Таблица: Квалификация
1. Id (PK)
2. Name

Таблица: Отдел
1. Id (PK)
2. Name
3. Type (0 = отдел кадров/ 1 = отдел продаж)

## Запросы 

### Сотрудники отдела кадров

``` sql
Select 
  ФИО
 ,Стаж
 ,Номер телефона
from People
join Отдел on Отдел.Id = People.Отдел
where Отдел.Type = 0
```

### Сотрудники отдела продаж

``` sql
Select 
  ФИО
 ,Квалификация.Name as Квалификация
 ,Отдел.Name as Отдел
 ,Стаж
 ,Личный транспорт
from People
join Отдел on Отдел.Id = People.Отдел
join Квалификация on Квалификация.Id = People.Квалификация
where Отдел.Type = 1
```

## Обновление отдела

update People
set People.Отдел = :Отдел
where People.Id = :Id

## Дата рождения

Добавим таблицу вида для хранения атрибутов:
Таблица: Attribute
1. Id (PK)
2. People (FK)
3. Value
4. Type (0 = Дата рождения, 1 = номер паспорта, 2 = серия паспорта, etc...)

И Запрос будет выглядеть как:

``` sql
Select 
  ФИО
 ,Attribute.Value
from People
left join Attribute on Attribute.People = People.Id and Attribute.Type = 0
```