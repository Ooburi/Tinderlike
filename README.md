
  <h3 align="center">t.Like</h3>

  ## About The Project

  Bot, Web app, API

  ### Built With

* React
* TailwindCSS
* C#
* EntityFrameworkCore
* PostgreSQL

//CURREnt state
1) docker-compose up --build

//current tasks
1) remove appKey from API
# PORTS

* SPA - 8000

### Before local launch add secrets:
* cd API
* dotnet user-secrets init
* dotnet user-secrets set apikey '{some api key}'
* dotnet user-secrets set connectionstring "Host=localhost;Port=5432;Database=tLike;Username=postgres;Password={PASSWORD}"
* cd ..
* cd BOT
* dotnet user-secrets init
* dotnet user-secrets set Key '{Bot KEY}'
