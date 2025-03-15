# Proyecto Fullstack: Task

Este proyecto contiene un backend desarrollado en .NET Core y un frontend desarrollado en Angular. El backend utiliza una base de datos SQLite para almacenar las tareas.


## Video



https://github.com/user-attachments/assets/9502f2cd-262c-4c7d-984f-4bccef3563e2


## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)

## Instrucciones para levantar el proyecto

### Clonar el repositorio

Primero, clona el repositorio en tu máquina local:

git clone https://github.com/DiAmb/tasks.git


### Configuración del Backend (TaskAPI)

Asegúrate de tener instalado .NET SDK.

1. Navega al directorio del backend:

cd TaskAPI


2. Restaura las dependencias de NuGet:

dotnet restore


3. Aplica las migraciones para configurar la base de datos SQLite:

dotnet ef database update


4. Inicia el servidor backend:

dotnet run


El backend estará disponible en `http://localhost:5099`.

### Configuración del Frontend (Task)

Asegúrate de tener instalado Node.js y Angular CLI.

1. Navega al directorio del frontend:

cd Task


2. Instala las dependencias de npm:

npm install


3. Inicia el servidor de desarrollo de Angular:

ng serve


El frontend estará disponible en `http://localhost:4200`.

## Acceso a la aplicación

- El backend estará disponible en `http://localhost:5099`.
- El frontend estará disponible en `http://localhost:4200`.
