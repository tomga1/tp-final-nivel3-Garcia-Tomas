﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeblvl3
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["error"] != null)
            {
                //lblMensaje.Text = "No se pudo procesar el formulario debido a datos inválidos. Revisa los campos y vuelve a enviar.";
                lblMensaje.Text = Session["error"].ToString();

            }
        }
    }
}