
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


// INSTRUCTIONS -----------------------------------------

1) Купить или любым другим способом получить домен. У меня уже был куплен домен rinerte.ru.
0)Привязать домен к серверу
3) Инструкция : https://help.reg.ru/support/dns-servery-i-nastroyka-zony/nastroyka-resursnykh-zapisey-dns/nastroyka-resursnykh-zapisey-v-lichnom-kabinete#0
1)apt install snapd
2)sudo snap install --classic certbot
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
