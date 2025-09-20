# MyLibraryAPI

RESTful API для управления личной библиотекой (книги и авторы) на ASP.NET Core 8.

## Возможности

* CRUD для авторов (`/api/Authors`)
* CRUD для книг (`/api/Books`)
* Фильтрация книг по жанру и статусу прочтения (`/api/Authors/filter`)
* Swagger UI для тестирования API

## Технологии

* ASP.NET Core 8 Web API
* Entity Framework Core с SQLite
* C# 11
* Swagger / OpenAPI для документации

## Запуск проекта

1. Клонировать репозиторий:

```bash
git clone https://github.com/USERNAME/MyLibraryAPI.git
```

2. Открыть проект в Visual Studio.

3. В **Package Manager Console** выполнить миграции:

```powershell
Update-Database
```

4. Запустить проект (**F5**).

5. Открыть Swagger UI для тестирования API:

```
http://localhost:<порт>/swagger
```

## Примеры запросов

### Создание автора

```json
POST /api/Authors
{
  "name": "Дж. Р. Р. Толкин",
  "country": "Великобритания"
}
```

### Создание книги

```json
POST /api/Books
{
  "title": "Хоббит",
  "genre": "Фэнтези",
  "year": 1937,
  "isRead": true,
  "authorId": 2
}
```

### Фильтрация книг по жанру

```
GET /api/Authors/filter?genre=Фэнтези&isRead=true
```

## Примечания

* SQLite база создается локально при первом запуске.
* Swagger UI позволяет тестировать все API без внешних клиентов.

## Структура проекта

```
MyLibraryAPI/
├─ Controllers/      # Контроллеры AuthorsController и BooksController
├─ Models/           # Модели Author и Book
├─ Data/             # LibraryContext и миграции
├─ Program.cs        # Настройка приложения
└─ appsettings.json  # Конфигурация подключения к SQLite
```
