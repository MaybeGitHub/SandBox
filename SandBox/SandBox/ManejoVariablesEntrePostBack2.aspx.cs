﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SandBox
{
    public partial class ManejoVariablesEntrePostBack2 : System.Web.UI.Page
    {       
        private string algo = "algo";
        private string nada = "null";

        protected void Page_Load(object sender, EventArgs e)
        {
            label_Cookie.Text = "Soy una label que coge valor de una Cookie, guardo los datos en el cliente y valgo ";
            label_PostBack.Text = "Soy una label que coge valor de una PostBack y valgo ";
            label_Session.Text = "Soy una label que coge valor de una Session, guardo los datos en el servidor y valgo ";
            label_ViewState.Text = "Soy una label que coge valor de un ViewState, guardo los datos en la info de la pagina y valgo ";

            if (Session["session"] != null)
            {
                label_Session.Text += Session["session"].ToString();
            }
            else
            {
                label_Session.Text += nada;
            }

            if (Request.Cookies["cookie"] != null)
            {
                label_Cookie.Text += Request.Cookies["cookie"].Value;
            }
            else
            {                
                label_Cookie.Text += nada;
            }

            if (ViewState["viewstate"] != null)
            {
                label_ViewState.Text += ViewState["viewstate"];
            }
            else
            {               
                label_ViewState.Text += nada;
            }

            if (IsPostBack)
            {
                label_PostBack.Text += algo;
            }
            else
            {
                label_PostBack.Text += nada;
            }
        }

        protected void button_CambioPagina_Click(object sender, EventArgs e)
        {
            Server.Transfer("ManejoVariablesEntrePostBack1.aspx");
        }
    }
}
