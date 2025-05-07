Nazwa projektu: Aplikacja do zarządzania zadaniami (TaskManager)

Opis:
Aplikacja umożliwia dodawanie, edytowanie, usuwanie i przeglądanie zadań. 
Została zbudowana jako autonomiczna aplikacja typu Blazor WebAssembly współpracująca z internetowym interfejsem API opartym na ASP.NET Core (.NET 8). 
Projekt zawiera dwie główne części:
1. Interfejs użytkownika (frontend) stworzony z użyciem Blazor WebAssembly
2. Backend w formie REST API zbudowanego w ASP.NET Core z wykorzystaniem Entity Framework Core

Technologie i biblioteki:
- .NET 8
- Blazor WebAssembly
- ASP.NET Core Web API
- Entity Framework Core
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Swagger (Swashbuckle)
- Bootstrap (dla stylizacji komponentów)

Wymagania systemowe:
- Visual Studio 2022 lub nowszy
- .NET SDK 8.0
- SQL Server (np. LocalDB)
- Przeglądarka internetowa (np. Chrome, Edge)

Sposób uruchomienia:
1. Otwórz solucję w Visual Studio 2022.
2. Ustaw projekt API jako projekt startowy.
3. Uruchom migrację bazy danych (z Package Manager Console):
   - `Update-Database`
4. Uruchom oba projekty (API i Blazor WebAssembly) równolegle.
5. Otwórz aplikację w przeglądarce.