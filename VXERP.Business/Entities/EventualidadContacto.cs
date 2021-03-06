﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using CRM.Business.Entities.BaseEntities;

namespace CRM.Business.Entities
{
    [Table("EventualidadContactos")]
    public class EventualidadContacto : BaseEntity
    {
        public EventualidadContacto()
        { 
            
        }

        public int Eventualidad_Id { get; set; }

        [ForeignKey("Eventualidad_Id")]
        public virtual Eventualidad Eventualidad { get; set; }

        public int Contacto_Id { get; set; }

        public bool Visto { get; set; }

        #region Entity Data Generic

        [NotMappedAttribute]
        [Display(Name = "Fecha Última Actualización")]
        public DateTime FechaActualizacion { get; set; }

        [NotMappedAttribute]
        [Display(Name = "Fecha Creación")]
        [ColumnNameGridView(Name = "Fecha Creación")]
        public DateTime FechaCreacion { get; set; }

        [NotMappedAttribute]
        public bool Estado { get; set; }

        [NotMappedAttribute]
        public int? idUsuario { get; set; }

        #endregion
    }
}
