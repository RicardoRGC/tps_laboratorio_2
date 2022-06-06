# tps_laboratorio_2
TP3:
TP3 Sistema  Para una Liga De futbol
Este sistema se encarga de registrar y organizar Usuarios De esta liga de futbol , Jugadores, Director Técnicos, Árbitros y Equipos.
Tiene un registro de datos de cada uno de ellos, Relacionando jugadores y Dt con sus equipos.
Tanto jugadores como  Equipos tienen que pagar un arancel por mes , Esto queda registrado con id, nombre, monto pagado y fecha del pago. 
Excepciones: se trabajan por todo el tp.
Pruebas Unitarias: se realizan sobre los métodos de registrar usuarios y búsqueda.
Tipos Genéricos: Se encuentra en la Biblioteca.EntidadesTp3. clase LigaFutbol, Esta es genérica Conteniendo una lista genérica , Almacenando listas de Usuario:  jugador, Dt; Arbitro y Equipo. 
Interfaces: se implementa en la clase jugador y Equipo, Estas clases tienen la Interfaz de IPagoMensual.
Archivos: se utiliza para Guardar los Id de Jugadores como de Equipos y No perder el Autoincremento.
Serialización: se Utiliza para guardar y cargar las listas de Equipo como de Usuarios en formato xml.
------------------------------------------------------------------------------------------------------------------------------------------------
