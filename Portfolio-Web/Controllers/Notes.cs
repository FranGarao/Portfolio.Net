// *!- ILogger
// ILogger es una interfaz que nos permite escribir mensajes de log.
// Nos permite definir categorias de mensajes. 
// Hay niveles de prioridad de mensajes, de muy importantes a no importantes.
// Critical - Error - Warning - Information - Debug - Trace
// Por defecto se configura para que solo se muestren mensajes de nivel Warning o superior.
// Por defecto se configura en el appsettings.json

//_logger.LogCritical("Critico");
//_logger.LogError("Error");
//_logger.LogWarning("Warning");
//_logger.LogInformation("Infoooo");
//_logger.LogDebug("Debug");
//_logger.LogTrace("Trace");

// *!- Proveedor de configuracion
// El proveedor de configuracion es una interfaz que nos permite acceder a la configuracion de la aplicacion.
// La configuracion de la aplicacion se puede leer de diferentes fuentes, como archivos, variables de entorno, etc.
// La configuracion se puede leer en cualquier parte de la aplicacion, pero se recomienda leerla en el Startup.cs


