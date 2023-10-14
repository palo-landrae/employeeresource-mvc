build:
	dotnet build

clean:
	dotnet clean

restore:
	dotnet restore

watch:
	dotnet watch --project EmployeeResourceWeb/EmployeeResourceWeb.csproj run

start:
	dotnet run --project EmployeeResourceWeb/EmployeeResourceWeb.csproj
