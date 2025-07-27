# IZUMU

## OBTENER EL PROYECTO EN MAQUINA LOCAL

Descargue el proyecto en una carpeta llamada IZUMU

---
## PRE-REQUISITO:
-Instalar Docker 
  https://www.docker.com/
-Instalar nodejs
  https://www.nodejs.tech/es/download
-Instalar o tener instalado Microsoft Sql Server

---
## CREAR BASE DE DATOS IZUMU
-Abrir Sql management studio
-Crear una base de datos con el nombre IZUMU
-Abra una nueva consulta en Sql management studio
-Copie el contenido del script 01_ScriptCreacionDeTablasyDatos.sql de la ruta ~/IZUMU/Script
-Pegue el contendio en la consulta abierta en Sql management studio
-Ejecute la consulta

---
## PUBLICAR APP IZUMU

## Opción 1:

-Abra el proyecto.
-En la carpeta IZUMU.Clientes.UI abrir appsettings.json
-Actualice la cadena de conexión.
-Abra powershell y ubiquese en la carpeta: ~/IZUMU:
-Cree la imagen:
   docker build -t izumu-clientes-ui .
-Ejecute:
   docker run -p 8080:8080 izumu-clientes-ui
-En el navegador puede abrir el aplicativo en la url
   http://localhost:8080/



## Opcion 2:

Paso 1:
-En el explorador de archivos ubicarse en la carpeta: ~/IZUMU
-Abrir docker-compose.yml
-Ajuste puertos y red si es necesario.

Paso 2:
-En el explorador de archivos ubicarse en la carpeta: ~/IZUMU
-Abrir appsettings.override.json
-Ajusta la cadena de conexión de la base de datos a como loo tengas configurado.

Paso 3:
-Abrir powershell en modo administrador
-ubicarse en la carpeta: ~/IZUMU
-Entontrará dos archivos: izumu-clientes-ui.tar, docker-compose.yml y appsettings.override.json
-Cargue la imagen: 
   docker load -i izumu-clientes-ui.tar
-levante los contenedores: 
   docker-compose up -d

