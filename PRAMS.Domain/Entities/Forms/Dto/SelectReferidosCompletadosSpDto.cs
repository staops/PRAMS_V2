namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class SelectReferidosCompletadosSpDto
    {
        public int ID_FORM_FlujoPantalla { get; set; }
        public int ID_Formulario { get; set; }
        public int ID_Forma { get; set; }
        public int OrdenEtapa { get; set; }
        public string FlujoEtapa { get; set; }
        public DateTime Fecha_Flujo { get; set; }
        public string ID_User_Flujo { get; set; }
        public string RMO { get; set; }
        public string Numero_Caso { get; set; }
        public string Persona { get; set; }
        public string ID_User_Asigna { get; set; }
        public string ID_User_Asignado { get; set; }
        public string Flujo_Status { get; set; }
        public string Notas { get; set; }
        public string Comentarios { get; set; }
        public bool EtapaCompletada { get; set; }
        public string Region { get; set; }
        public string Local { get; set; }
        public string rank { get; set; }
        public string NombreFlujo { get; set; }
        public string NombreAsigna { get; set; }
        public string NombreAsignado { get; set; }
        public string NombreSujeto { get; set; }
        public string NombreRefiere { get; set; }
    }
}
