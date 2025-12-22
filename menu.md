# Diseño conceptual del menú (versión ordenada)

## 1. Pantalla Inicial

**Objetivo:** Dar contexto al usuario y dirigirlo al menú principal.

* Mostrar:

  * Nombre de la aplicación
  * Breve descripción de la funcionalidad
  * Estado del sistema: Conectado / Listo / Error

* Flujo:

  * Desde aquí el usuario pasa al menú principal

---

## 2. Menú Principal

**Opciones conceptuales:**

1. Gestión de Usuarios
2. Gestión de Tareas
3. Ayuda / Información
4. Salir

> Nota: En este nivel no se solicitan datos; solo se selecciona la acción a realizar.

---

## 3. Submenú: Gestión de Usuarios

**Acciones posibles:**

* Crear Usuario

  * Solicitar nombre de usuario y contraseña
  * Confirmación antes de crear
* Actualizar Usuario

  * Elegir cambiar username o password
  * Solicitar datos actuales y nuevos
  * Confirmación antes de actualizar
* Eliminar Usuario

  * Solicitar usuario y contraseña
  * Confirmación antes de eliminar
* Volver al Menú Principal

**Flujo mental:**

* Selección → Solicitud de datos → Confirmación → Retorno al submenú

---

## 4. Submenú: Gestión de Tareas

**Acciones posibles:**

* Ver Tareas
* Crear Tarea

  * Validar que exista al menos un usuario
  * Solicitar: title (obligatorio), descripción (obligatorio), diaFinished (opcional), prioridad (por defecto low), state (por defecto toDo)- Actualizar Tarea
  * Elegir qué campo actualizar: title, descripción, diaFinished, prioridad, state
* Eliminar Tarea

  * Mostrar lista de tareas
  * Confirmación antes de eliminar
* Volver al Menú Principal

**Flujo mental:**

* Selección → Solicitud de datos → Confirmación → Retorno al submenú

---

## 5. Submenú: Ayuda / Información

**Contenido típico:**

* Cómo usar la aplicación
* Atajos / flujos básicos
* Versión de la aplicación
* Volver al Menú Principal

---

## 6. Flujo de navegación (mental)

* Inicio → Menú Principal → Submenú → Acción → Submenú → Menú Principal → Salir
* Nunca dejar al usuario en un callejón sin salida

---

## 7. Preguntas de estudio

* ¿Cada opción responde a una intención clara?
* ¿Hay separación entre leer y modificar datos?
* ¿El usuario siempre sabe cómo volver atrás?
* ¿Podrías implementar este menú primero en consola y luego en GUI?
