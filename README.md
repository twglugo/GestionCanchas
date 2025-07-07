
# ⚽ Sistema de Gestión de Alquiler de Canchas

Este proyecto es una **aplicación de escritorio en C#** conectada a una base de datos **MySQL**, diseñada para gestionar de forma eficiente el alquiler de canchas deportivas.

---

## 📌 Características principales

- 🧾 Registro de clientes.
- 📅 Gestión de reservas (rentas) por fecha y hora.
- 💳 Generación de recibos de pago por alquiler.
- 📋 Consulta de historial de rentas y estado de canchas.
- ⚙️ Arquitectura en capas (Conexión, Modelo, Lógica, Controlador, Interfaz Gráfica).
- 🗃️ Persistencia mediante MySQL.

---

## 🧱 Estructura del Proyecto

```
Micanchas/
│
├── Conexion/           # Lógica de conexión a MySQL
├── Controlador/        # Control de flujo entre UI y lógica de negocio
├── Logica/             # Reglas de negocio (CRUD, validaciones)
├── Modelos/            # Clases que representan entidades de BD
├── Scripts/            # Scripts SQL para crear la BD y tablas
├── GestionCanchas.app/ # Proyecto principal de la interfaz gráfica
└── GestionCanchas.sln  # Archivo de solución (Visual Studio)
```

---

## 🧩 Base de Datos

La base de datos se llama: `GestionCanchas`.

### Tablas:

- **Clientes**: Registro de los usuarios.
- **Cancha**: Información de las canchas (número, estado, precio).
- **Renta**: Registro de reservas de canchas (fecha, duración, cliente, cancha).
- **Recibo**: Pagos realizados por las rentas.

### Script de creación:

Puedes encontrar el script completo en: `Scripts/Canchas.txt`

```sql
CREATE TABLE Clientes (
  Cli_Cedula INT PRIMARY KEY,
  Cli_Nombre VARCHAR(55) NOT NULL,
  Cli_Telefono INT NOT NULL
);

CREATE TABLE Cancha (
  Can_Id INT PRIMARY KEY AUTO_INCREMENT,
  Can_Numero INT NOT NULL,
  Can_Estado TINYINT NOT NULL, -- 0: Mantenimiento | 1: Disponible
  Can_Precio DECIMAL NOT NULL
);

CREATE TABLE Renta (
  Ren_Id INT PRIMARY KEY,
  Ren_Fecha DATETIME NOT NULL,
  Ren_Horas INT NOT NULL,
  Ren_Abono INT NOT NULL,
  Clientes_Cli_Cedula INT,
  Cancha_idCancha INT,
  FOREIGN KEY (Clientes_Cli_Cedula) REFERENCES Clientes(Cli_Cedula),
  FOREIGN KEY (Cancha_idCancha) REFERENCES Cancha(Can_Id)
);

CREATE TABLE Recibo (
  Rec_Id INT PRIMARY KEY AUTO_INCREMENT,
  Rec_Fecha DATETIME NOT NULL,
  Rec_total DECIMAL(10,2),
  Rec_Metodo VARCHAR(50),
  Renta_Ren_Id INT,
  FOREIGN KEY (Renta_Ren_Id) REFERENCES Renta(Ren_Id)
);
```

---

## 🚀 ¿Cómo ejecutar el proyecto?

1. Clona el repositorio:

```bash
git clone https://github.com/twglugo/GestionCanchas.git
```

2. Abre la solución con Visual Studio o Visual Studio Code.

3. Restaura los paquetes necesarios:

```bash
dotnet restore
```

4. Ejecuta el script `Canchas.txt` en tu base de datos MySQL.

5. Asegúrate de configurar la cadena de conexión en el archivo `Conexion/Conecta.cs`.

6. Corre el proyecto desde `GestionCanchas.app`.

---

## 🧠 Tecnologías usadas

- **Lenguaje:** C#
- **Base de datos:** MySQL
- **Acceso a datos:** MySql.Data
- **IDE recomendado:** Visual Studio 2022 / VS Code
- **Framework:** .NET 6 / 7 (según tu configuración)

---

## 📸 Diagrama Entidad-Relación

> Imagen sugerida: Guarda tu diagrama como `Scripts/Diagrama.png` y GitHub lo mostrará automáticamente.

```markdown
![Diagrama ER](Scripts/diagrama.png)
```

---

## 🙋 Autor

- **Miguel Lugo**  
- GitHub: [@twglugo](https://github.com/twglugo)

---

## 📄 Licencia

Este proyecto se distribuye con fines educativos y de aprendizaje. Eres libre de modificarlo, compartirlo y adaptarlo según tus necesidades.

---
