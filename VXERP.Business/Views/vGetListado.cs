﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CRM.Business.Views
{
    public class vPaneldeControlActualizarValor : BaseViews.BaseViewString
    {

        private const string SP_NAME = "PaneldeControlActualizarValor";



        public vPaneldeControlActualizarValor()
            : base(SP_NAME, true,null)
        {

        }

        public DataTable ActualizarValores(int segundosPorPaso)
        {
            DataTable datos = base.GetViewModel_SP(new System.Data.SqlClient.SqlParameter("@Valor", segundosPorPaso));

            return datos;
        }

        public decimal ObtenerValor()
        {
            try
            {
                DataTable dt = base.GetCoustomSP("PaneldeControlObtenerValor", null);

                return decimal.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        
    }
}
