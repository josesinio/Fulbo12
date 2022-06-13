## Código Persistencia.EFC

### Preparando el entorno

Para poder crear la migración, es importante primero haber instalado las herramientas de _Entity Framework Core_ 🦄 con el comando
```shell
dotnet tool install --global dotnet-ef
```

Después en este directorio `src\Fulbo12.Core.Persistencia.EFC` crea tu archivo `appsettings.json` con la siguiente estructura:
```json
{
    "SerVersion": "8.0.29",
    "ConnectionStrings": {
        "dev": "server=localhost;port=3306;user=root;password=root;database=Fulbo12"
    }
}
```
En este ejemplo use la versión de MySQL instalada en la secu junto con su usuario y contraseña de _root_ de las compus de los labos; **si vas a correrlo en tu compu, no te olvides de completar los campos con los de tu SGBD**.

### Manipulando las migraciones

Después de tener configurado tu entorno, corriendo el servicio de `MySQL` 🐬, podes crear la migración posicionandote en el path `src\Fulbo12.Core.Persistencia.EFC` y ejecutar el comando:
```shell
dotnet ef migrations add Migracion
```
Esto va a crear el directorio `src\Fulbo12.Core.Persistencia.EFC\Migrations` con 3 archivos; vas desplegar esta migración en `MySQL` 🐬 con el comando:
```shell
dotnet ef database update
```
