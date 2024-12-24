
[Ctrl]+C to stop running program!!!

1. Start:
   a. ga eeerst naar de subdir van AutionService (waar prj staan).
   b. >dotnet watch
   c. http://localhost:7001 is actief
   
2. Check dotnet  
   >dotnet tool list -g
   >dotnet tool install dotnet-ef -g   
   >dotnet tool update dotnet-ef -g   
   
3. Database:
   >dotnet ef migrations add "InitialCreate" -o Data/Migrations   
   
   >dotnet ef database update

   Drop DB:
   >dotnet ef database drop
   >dotnet watch

4. Docker install:
   1. create docker-compose.yml
   2. >docker compose up -d      <---- very important !!!
   3. stop:
      >docker compose down

5. Update Entity Framework Tools:
   >dotnet tool update --global dotnet-ef    (Laatste versie)
   >dotnet tool update --global dotnet-ef --version 8.0.11   

6. Postgres database:
   Server: localhost
   DatabaseName: Autions   
   User: postgres
   Pass: postgrespw

7. Add _underscore
   add .editorconfig to the root.   

