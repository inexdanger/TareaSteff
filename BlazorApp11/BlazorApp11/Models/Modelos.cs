namespace BlazorApp11.Models
{
    // Definición de las clases que representan las tablas en la base de datos

    public class FlujoNodo
    {
        public int Id { get; set; }
        public string Flujo { get; set; }
        public string CongestionMaxima { get; set; }
        public string TiempoEstimado { get; set; }
        public string EstadoActual { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class Nodo
    {
        public int Id { get; set; }  // Asegúrate de tener un campo de identificación para cada tabla
        public string Nombre { get; set; }
        // Agrega otras propiedades relevantes aquí
    }

    public class Via
    {
        public int Id { get; set; }
        public int NodoOrigen { get; set; }  // Nodo de origen
        public int NodoDestino { get; set; }  // Nodo de destino
        public string Direccion { get; set; }  // Dirección de la vía (Norte, Sur, Este, Oeste)
    }

    public class Semaforo
    {
        public int Id { get; set; }
        public int Nodo { get; set; }  // Nodo al que pertenece el semáforo
        public string Estado { get; set; }  // Estado del semáforo (Rojo o Verde)
    }

    public class VehiculosEnEspera
    {
        public int Id { get; set; }
        public int Nodo { get; set; }  // Nodo donde los vehículos están esperando
        public int Cantidad { get; set; }  // Cantidad de vehículos esperando
    }

    public class TiempoTransito
    {
        public int Id { get; set; }
        public int NodoOrigen { get; set; }  // Nodo de origen
        public int NodoDestino { get; set; }  // Nodo de destino
        public int TiempoPromedio { get; set; }  // Tiempo promedio de tránsito entre los nodos (en segundos)
    }

    public class EstadoNodo
    {
        public int Id { get; set; }
        public int NodoId { get; set; }
        public int CantidadEncolados { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
//-----------------------------------------------------------
    public class Flujo
    {
        public int Id { get; set; }
        public int NodoOrigen { get; set; }
        public int NodoDestino { get; set; }
        public int CantidadOrigen { get; set; }
        public int CantidadDestino { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

    public class TiempoEstimado
    {
        public int Id { get; set; }
        public int NodoOrigen { get; set; }
        public int NodoDestino { get; set; }
        public double Tiempo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

}
