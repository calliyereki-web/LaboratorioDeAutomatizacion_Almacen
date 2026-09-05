using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioDeAutomatizacion_Almacen
{
    public abstract class UsuarioLaboratorio
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Expediente { get; set; } = string.Empty;
    }

    public class Administrativo : UsuarioLaboratorio
    {
        public string Departamento { get; set; } = string.Empty;
    }

    public class Almacenista : UsuarioLaboratorio
    {
        public string Turno { get; set; } = string.Empty;
    }

    public class Prestatario : UsuarioLaboratorio
    {
        public string Carrera { get; set; } = string.Empty;
        public int Semestre { get; set; }
    }

}
