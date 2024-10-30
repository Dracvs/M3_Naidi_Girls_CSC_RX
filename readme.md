# NaidiW

## Inicializar el repositorio

```bash
# ¿Qué es lo primero que hago al empezar a trabajar?
Inicio > Windows > Terminal
cd C:\
cd naidiw

# En su defecto, abro el terminal de VS Code cuando yua tengo el proyecto abierto.

# Creación del proyecto de cero
mkdir NaidiW
dotnet new sln -n NaidiW
dotnet new webapi -o NaidiW.API
dotnet sln add NaidiW.API
dotnet build
dotnet new classlib -n NaidiW.Business
dotnet sln add NaidiW.Business

# Comandos para trabajar una vez inicializados

# Compilar
dotnet build

# Correr
dotnet run --project NaidiW.API
dotnet watch --project NaidiW.API

# Limpiar
dotnet clean

```

## Ejercicios del cifrado númerico

*Decodificar*
8-15-12-1 8-15-12-1

*Decodificar 2*
8-15-12-1 12-21-3-8-15