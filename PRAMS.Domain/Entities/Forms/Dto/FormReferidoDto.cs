using PRAMS.Domain.Models.People;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace PRAMS.Domain.Entities.Forms.Dto
{
    /// <summary>
    /// DTO of FormReferido entity
    /// </summary>
    public class FormReferidoDto
    {
        public required int ReferidoId { get; set; }

        /// <summary>
        /// Campo RMO este es el número de referido, hay que determinar cómo estos son 
        /// generados para automatizarlos y que sean secuenciales. Estos deben estar 
        /// basados en la región y lugar según entendemos por lo que estos campos 
        /// puede que sean necesarios al completar el caso para poder generarlo. 
        /// 
        /// Al iniciar el caso no tendremos el numero de Referido de forma inmediata, 
        /// así que estaremos trabajando algunas de las pantallas relacionadas 
        /// como es Personas Link con el numero de ID_Referido que ya lo tenemos 
        /// en la definición de esa tabla de Personas Link.
        /// 
        /// </summary>
        public string? RMO { get; set; }

        public int? CasoId { get; set; }

        /// <summary>
        /// Tenemos tres tipos de Referidos
        ///     o   Referido Orientación
        ///     o   Referido Orientación y Referimiento
        ///     o   Referido Protección
        ///     
        /// o   Estos tres tipos de referidos están en Multi Tablas(Categoría 24) ya definidos en TipoCasos y podemos usar el campo TX_Filtro2 que indica que son Referido
        /// 	Ya estamos usando estos datos para Flujos, pero son los mismos y ya tienen a propósito los diferentes filtros para que puedan ser seleccionados y presentados en esta pantalla.
        /// 	Este seria un ejemplo de uso mixto de un campo en el que para una pantalla o tabla solo requiere un solo nivel para ser presentado como en la tabla de flujos para TipoCaso, pero en el referido estamos usando dos niveles ya que queremos poder llamar la función que retorna multi tabla pasando el campo de filtro para TipoCaso por el parámetro de formulario que estamos usando (Referido).
        /// 	En otros formularios que tengan múltiples usos se estará usando este filtro pero el valor no seria Referido seria otro como el caso de Formularios de Visitas que se estará preparando mas adelante.
        /// 
        /// MULTITABLA
        /// 
        /// </summary>
        public string? TipoReferido { get; set; }

        /// <summary>
        /// La Fecha del Referido deben poder ser seleccionadas. 
        /// Para llamadas luego hay que averiguar si estos campos pueden ser llenados con la 
        /// fecha y hora actual y que ellos los puedan modificar.
        /// </summary>
        public DateTime? FechaRecibo { get; set; }
        /// <summary>
        /// Hora del Referido deben poder ser seleccionadas. 
        /// Para llamadas luego hay que averiguar si estos campos pueden ser llenados con la 
        /// fecha y hora actual y que ellos los puedan modificar.
        /// </summary>
        public DateTime? HoraRecibo { get; set; }

        public string? AccionTomada { get; set; }
        /// <summary>
        /// Permite la entrada de hasta 2000 caracteres o sea debe ser extenso o que pueda ser agrandado 
        /// por el personal que hace la entrada o tener para hacer scroll down. Esto será mejor determinado 
        /// con los usuarios mas adelante.
        /// </summary>
        public string? NarrativaSituacion { get; set; }

        /// <summary>
        /// En estos momentos no tenemos como definir este campo hasta que se discuta con el cliente, 
        /// pero se estaría manejando en Pantalla para cualquiera de los dos casos que son presentados.
        /// </summary>
        public string? ReferidoPor { get; set; }

        /// <summary>
        /// Este puede ser un campo de Selección o puede que este atado a Personas igual que Referido Por
        /// 
        /// En la categoría 32 tenemos la Relación que es usada para la pantalla de personas link, 
        /// en este caso tenemos que determinar si son los mismos tipos de relaciones, deberían ser 
        /// las mismas pero puede que cambie o que haya que definir nuevas en Multi Tablas según se discuta con el cliente.
        /// 
        /// MULTITABLA
        /// 
        /// </summary>
        public string? RelacionAdulto { get; set; }

        /// <summary>
        /// . Puede que este campo necesite una entrada adicional para escoger el tipo de servicio y 
        /// luego poder seleccionar el campo se servicios. Puede ser manejado por multi tablas por ahora 
        /// en el sistema con una definición de dos niveles. Se incluyen ejemplos en la DB
        /// 
        /// (Categoría 33) debe salir de una tabla de servicios que será preparada
        /// 
        /// MULTITABLA
        /// 
        /// </summary>
        public string? ServicioSolicitado { get; set; }
        public DateTime? ServicioFechaNotificacion { get; set; }

        /// <summary>
        /// Es para indicar si tiene o no antecedentes la persona referida. Este dato sale de multi tabla con la debida definición.
        /// 
        /// Campo Antecedentes (Categoría 35) 
        /// 
        /// MULTITABLA
        /// 
        /// </summary>
        public string? Antecedentes { get; set; }




        public string? Determinacion { get; set; }
        public DateTime? DeterminacionFecha { get; set; }
        public string? DeterminacionRazon { get; set; }




        /// <summary>
        /// En estos campos siempre debemos tener la misma región por si es solo para la región y que luego se el caso asignado. 
        /// Esta parte hay que determinarla para el proceso de asignación de casos que tienen determinación adecuada para continuar los procesos.
        /// 
        /// Para los campos de Asignación de Localización (Categoría 37)
        /// 
        /// MULTITABLA
        /// 
        /// </summary>
        public string? AsignacionRegion { get; set; }

        /// <summary>
        /// En estos campos siempre debemos tener la misma región por si es solo para la región y que luego se el caso asignado. 
        /// Esta parte hay que determinarla para el proceso de asignación de casos que tienen determinación adecuada para continuar los procesos.
        /// 
        /// Para los campos de Asignación de Localización (Categoría 37)
        /// 
        /// MULTITABLA
        /// 
        /// </summary>
        public string? AsignacionOficina { get; set; }





        public string? Clasificacion { get; set; }






        /// <summary>
        /// Campo de Origen del Referido este será un campo de selección basado en multi tablas que se pueden 
        /// ver en el sistema implementadas. El listado será uno bastante extenso y hay que hacer una selección 
        /// por el personal para determinar de donde proviene el referido. 
        /// Esto es principalmente para referidos que vienen de otros lugares, 
        /// no tiene que ser un campo requerido, solo para los referidos de referimiento.
        /// 
        /// MULTITABLA
        /// 
        /// </summary>
        public string? OrigenReferido { get; set; }
        public string? AsignacionReferido { get; set; }
        public int? AgenciaId { get; set; }

        /// <summary>
        /// Es de selección y tiene solo dos opciones que están definidas en multi tablas para este mismo nombre.
        /// 
        /// Para algunos de los tipos de referidos hay que llenar el campo de ID_Agencia y estamos incluyendo 
        /// todos los campos del referido y luego podemos usar procesos para escoger que se presenta al usuario en la pantalla.
        /// 
        /// Estos datos no vienen de multi tabla, vienen de la tabla de Conf_Agencias que fue preparada 
        /// y que solo debe mostrar cuando se entra el referido aquellas que estén activas en sistema.
        /// 
        /// El campo de Agencia Solicitado Para (Categoría 38) 
        /// 
        /// MULTITABLA
        /// 
        /// </summary>
        public string? AgenciaSolicitadoPara { get; set; }

        /// <summary>
        /// El campo de Agencia Solicitud es para poder llenar una narrativa que explique porque se está refiriendo a la agencia de ser necesario
        /// </summary>
        public string? AgenciaSolicitud { get; set; }
        public required string CreateUser { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public required bool Activo { get; set; } = true;
        public string? SupervisorUser { get; set; }
        public DateTime? SupervisorDate { get; set; }

        /// <summary>
        /// El campo de ID_ReferidoOrigen será usado más adelante para el manejo de referidos que tienen que ver con el mismo caso. 
        /// Estos se refieren a que pueden llegar múltiples referidos para el mismo Adulto y estos deben ser unificados con este campo 
        /// más adelante para que puedan estar relacionados los referidos y que se sepa que son del mismo incidente.
        /// </summary>
        public string? ReferidoOrgenId { get; set; }

    }
}
