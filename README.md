#  RetroWave_Facturacion

> **⚠️ Aviso de Confidencialidad:** Este repositorio contiene código fuente propietario y de uso restringido. Queda estrictamente prohibida su distribución, copia, modificación o uso no autorizado. 

##  Descripción General

**RetroWave_Facturacion** es una aplicación compacta diseñada para la generación y gestión de facturación, construida sobre `.NET Framework 4.7.2`. Este repositorio contiene la solución completa, el código fuente y los archivos de soporte necesarios para compilar y ejecutar la aplicación de forma local utilizando Visual Studio 2022.

---

##  Tecnologías y Entorno

* **Framework:** `.NET Framework 4.7.2`
* **Entorno de Desarrollo (IDE):** `Visual Studio 2022`
* **Base de Datos:** `SQL Server` (Express / LocalDB / Full)
* **Gestor de Paquetes:** `NuGet`
* **Configuración:** `App.config` / `Web.config`
* **Estándares de Código:** Gestionados mediante `.editorconfig`.

---

##  Requisitos Previos

Para desplegar este proyecto en un entorno local, tu equipo debe cumplir con los siguientes requisitos:

* **Sistema Operativo:** Windows 10/11 (o compatible).
* **Visual Studio 2022** con las cargas de trabajo de *Desarrollo de escritorio de .NET* y/o *Desarrollo de ASP.NET y web* instaladas.
* **.NET Framework 4.7.2 Developer Pack** (en caso de no venir incluido con tu instalación de VS).
* **Motor de Base de Datos:** SQL Server configurado y en ejecución.
* Conexión a internet activa para la restauración de paquetes de dependencias.

---

##  Pasos de Instalación y Ejecución

Sigue estos pasos para compilar la aplicación en tu entorno de desarrollo. Solo el personal autorizado debe ejecutar este flujo.

**1. Clonar el repositorio:**
```bash
git clone [https://github.com/carls21x/RetroWave_Facturacion.git](https://github.com/carls21x/RetroWave_Facturacion.git)

```

**2. Abrir la solución:**
Navega a la carpeta clonada y abre el archivo `RetroWave_Facturacion.sln` en Visual Studio 2022.

**3. Restaurar paquetes NuGet:**
Por lo general, Visual Studio restaurará los paquetes automáticamente al abrir el proyecto. Si no ocurre, haz clic derecho sobre la solución en el *Explorador de soluciones* y selecciona **Restaurar paquetes NuGet**.

**4. Configurar la conexión a la Base de Datos:**
Abre el archivo de configuración correspondiente (`App.config` o `Web.config`) y ajusta tu cadena de conexión (`connectionString`). Reemplaza los valores con los de tu servidor local.

*Ejemplo de estructura esperada:*

```xml
<connectionStrings>
  <add name="DefaultConnection" 
       connectionString="Server=.\SQLEXPRESS;Database=RetroWaveDB;Trusted_Connection=True;" 
       providerName="System.Data.SqlClient" />
</connectionStrings>

```

**5. Compilar y Ejecutar:**

* Selecciona el proyecto de inicio.
* Compila la solución desde el menú: **Compilar > Compilar solución** (`Ctrl+Shift+B`).
* Ejecuta la aplicación: **Depurar > Iniciar depuración** (`F5`) o **Iniciar sin depurar** (`Ctrl+F5`).

---

##  Gestión de Base de Datos

Si el proyecto utiliza un ORM (como Entity Framework o Dapper), asegúrate de aplicar las migraciones antes de iniciar la aplicación por primera vez:

* **Para Entity Framework Code First:** Abre la *Consola del Administrador de paquetes* (Package Manager Console) y ejecuta:
```powershell
Update-Database -ProjectName <NombreDelProyectoDeMigraciones> -StartupProjectName <ProyectoDeInicio>

```


* **Scripts Manuales:** Si el proyecto incluye scripts `.sql`, ejecútalos directamente en tu instancia de SQL Server para crear los esquemas y datos semilla.

---

##  Seguridad y Credenciales

* **Entornos de Producción:** Bajo ninguna circunstancia se deben hacer *commit* de contraseñas, tokens o cadenas de conexión de producción en este repositorio.
* **Desarrollo Local:** Utiliza variables de entorno o *User Secrets* para manejar valores sensibles durante el desarrollo.

---

##  Solución de Problemas (Troubleshooting)

* **Fallo al restaurar paquetes NuGet:** Verifica tu conexión a internet o limpia la caché local de paquetes ejecutando `nuget locals all -clear` en tu terminal.
* **Errores de SDK o Framework faltante:** Asegúrate de haber instalado el *Developer Pack de .NET 4.7.2* a través del Visual Studio Installer.
* **Error de conexión a la Base de Datos:** Verifica que el servicio de SQL Server esté corriendo y que el nombre del servidor en tu `App.config` sea el correcto (ej. `.\SQLEXPRESS`).

---

##  Licencia y Derechos

**© 2026. Todos los derechos reservados.**
Este software es de uso privativo. El acceso a este código no otorga permisos de distribución, modificación ni explotación comercial sin el consentimiento expreso y por escrito del autor y propietario del proyecto.

---

##  Soporte y Contacto

Para consultas sobre la arquitectura, reporte de fallos o problemas con los accesos al repositorio, por favor abre un *Issue* en GitHub (si tienes los permisos) o contacta directamente con el administrador del proyecto (carls21x).

```

```
