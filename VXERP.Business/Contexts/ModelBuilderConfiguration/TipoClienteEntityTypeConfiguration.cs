﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using CRM.Business.Entities;

namespace CRM.Business.Contexts.ModelBuilderConfiguration
{
    public class TipoClienteEntityTypeConfiguration : EntityTypeConfiguration<TipoCliente>
    {
        public TipoClienteEntityTypeConfiguration()
        {
            this.Property(p => p.Id).HasColumnName("Id");

            this.ToTable("TiposCliente");
        }
    }
}
