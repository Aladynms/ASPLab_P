Technologie:
.Net 6.0
SQLite


Użytkownicy
login / pass:

admin / admin
user / user


Komendy do uruchomienia deweloperskiego w Commandline w projekcje Data:

dotnet tool install --global --version 6.0.25 dotnet-ef
// możliwe wymaganie uruchomienie programu ponownie
dotnet ef database drop
dotnet ef migrations remove
dotnet ef migrations add create
dotnet ef database update


Link do repozytorium z kodem aplikacji:
https://github.com/Aladynms/ASPLab_P
