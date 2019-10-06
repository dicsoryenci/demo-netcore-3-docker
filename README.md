## Crear un Proyecto Nuevo
    dotnet new mvc -n webmvc

    dotnet restore

    dotnet run


## Comandos Docker

	docker ps

	docker ps -a

	docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=rqee.4432' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu 

	docker run --name sql_express --hostname sql_express --network=net_demo_sql_server --publish 1433:1433 --detach crobles10/summit_dev:3.0

	u: SA
	p: SqLr0ck$!
	BD: HumanResources

	docker start sql_express

	docker stop sql_express


## Librerias que agregar al proyecto de .net core

	dotnet add package Microsoft.EntityFrameworkCore.SqlServer
	dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
	dotnet add package Microsoft.EntityFrameworkCore.Design
	dotnet tool install --global dotnet-aspnet-codegenerator

## Comandos de asp codegenerator
	dotnet aspnet-codegenerator controller -name RegionsController -actions -nv -m Regions -dc Contexto -outDir Controllers

	dotnet aspnet-codegenerator view Index List -outDir Views/Regions -udl -m Regions
	dotnet aspnet-codegenerator view Create Create -outDir Views/Regions -udl -m Regions
	dotnet aspnet-codegenerator view Edit Edit -outDir Views/Regions -udl -m Regions
	dotnet aspnet-codegenerator view Details Details -outDir Views/Regions -udl -m Regions
	dotnet aspnet-codegenerator view Delete Delete -outDir Views/Regions -udl -m Regions


## Generar el contenedor de la aplicación a partir del DockerFile

docker build -t webmvc-app:latest .

docker run --rm -d -p 5000:80 --name webmvc  --network=net_demo_sql_server webmvc-app:latest
