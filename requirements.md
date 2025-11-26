TASK:

Id — identificador único (GUID o int autoincremental).

Titulo — string (no vacío, longitud máxima p. ej. 200).

Descripcion — string (opcional, longitud máxima p. ej. 2000).

FechaCreacion — DateTime (set al crear).

HoraFinalizacion — DateTime? (nullable; se añade cuando pasa a Terminado, se borra si vuelve a En proceso).

Estado — enum { EnProceso, Terminado }.

Prioridad — enum { Critica, Importante, Basico, Divertido }.

FechaUltimaModificacion — DateTime (opcional, para auditoría).

(Opcional) OwnerUserId — referencia al usuario que creó la tarea (si añades multiusuario).

USER:

UserId, Username, PasswordHash, CreatedAt, Role (opcional)



Reglas de negocio y transiciones (claras y verificables)

Al crear: FechaCreacion = ahora, Estado = EnProceso por defecto (o configurable), HoraFinalizacion = null.

Al actualizar estado → Terminado: si cambia a Terminado y HoraFinalizacion == null → set HoraFinalizacion = ahora.

Al actualizar estado → EnProceso desde Terminado: set HoraFinalizacion = null.

Al actualizar título/descripcion/prioridad: actualizar FechaUltimaModificacion = ahora.

Eliminación automática futura: si Estado == Terminado y HoraFinalizacion tiene más de X días (p. ej. 30 días) → marcar para eliminación o eliminar directamente (define comportamiento: soft-delete vs hard-delete).

Validaciones:

Título no puede estar vacío.

Prioridad debe ser uno de los enum permitidos.

No permitir HoraFinalizacion en creación (solo sistema la maneja).

Consistencia:

No permitir HoraFinalizacion si Estado != Terminado.


4) Errores y excepciones a contemplar (lista priorizada)

UserNotFoundException / InvalidCredentialsException (login).

TaskNotFoundException (al actualizar/eliminar).

ValidationException (título vacío, prioridad inválida, longitud excedida).

ConcurrencyException (si implementas control de versiones o multithreading).

Errores de I/O si guardas logs en fichero.

UnauthorizedException (si añades roles y permisos).

Captura global: registrar errores inesperados en el logger y mostrar mensaje amigable al usuario.