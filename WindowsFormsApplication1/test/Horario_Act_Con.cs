//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COMPLETE_FLAT_UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Horario_Act_Con
    {
        public int id { get; set; }
        public int id_act_concedida { get; set; }
        public int id_dia_semana { get; set; }
        public System.TimeSpan hora_inicio { get; set; }
        public System.TimeSpan hora_fin { get; set; }
    
        public virtual Act_concedida Act_concedida { get; set; }
        public virtual Dias_Semana Dias_Semana { get; set; }
    }
}
