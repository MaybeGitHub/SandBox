using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SandBox
{
    public partial class ManejoVariablesEntrePostBack1 : System.Web.UI.Page
    {
        private string algo = "algo";
        private string nada = "null";
        protected void Page_Load(object sender, EventArgs e)
        {
            label_Cookie.Text = "Soy una label que coge valor de una Cookie, guardo los datos en el cliente y valgo "; 
            label_PostBack.Text = "Soy una label que coge valor de una PostBack y valgo ";
            label_Session.Text = "Soy una label que coge valor de una Session, guardo los datos en el servidor  y valgo ";
            label_ViewState.Text = "Soy una label que coge valor de un ViewState, guardo los datos en la info de la pagina  y valgo ";
            button_A.Text = "Pulsame";
            button_B.Text = "Pulsame";
            button_C.Text = "Pulsame";
            button_D.Text = "Pulsame";
            label_Tree.Text = "Hoja del tree pulsada: ";          
            
            // Session

            if (Session["session"] != null)
            {
                label_Session.Text += Session["session"].ToString();
            }
            else
            {
                Session["session"] =  algo;
                label_Session.Text += nada;
            }

            // Cookie

            if (Request.Cookies["cookie"] != null)
            {
                label_Cookie.Text += Request.Cookies["cookie"].Value;
            }
            else
            {
                HttpCookie miCookie = new HttpCookie("cookie");
                miCookie.Value = algo;
                Response.Cookies.Add(miCookie);
                label_Cookie.Text += nada;
            }

            // ViewState

            if (ViewState["viewstate"] != null)
            {
                label_ViewState.Text += ViewState["viewstate"];
            }
            else
            {
                ViewState["viewstate"] = algo;
                label_ViewState.Text += nada;
            }

            // Creando Celdas Nuevas de Table a mano, a diferencia del treeView no se guarda entre postbacks, asique hay que crearlo de nuevo siempre

            TableRow nuevaFila = new TableRow();

            TableCell nuevaColumna = new TableCell();
            nuevaColumna.Text = "Celda Dinamica 1";
            nuevaColumna.BorderWidth = 1;
            nuevaFila.Cells.Add(nuevaColumna);

            nuevaColumna = new TableCell();
            nuevaColumna.Text = "Celda Dinamica 2";
            nuevaColumna.BorderWidth = 1;
            nuevaFila.Cells.Add(nuevaColumna);

            nuevaColumna = new TableCell();
            nuevaColumna.Text = "Celda Dinamica 3";
            nuevaColumna.BorderWidth = 1;
            nuevaFila.Cells.Add(nuevaColumna);

            tabla_Predefinida.Rows.Add(nuevaFila);

            //PostBack

            if (IsPostBack)
            {
                label_PostBack.Text += algo;
                cajaInfo.Text = "Cosas que afectan a este ejercicio\n----------------------------------\n";
                foreach (string clave in Request.Params)
                {
                    if (clave.Contains(button_PostBack.ID) && Request.Params[clave] != null)
                    {
                        cajaInfo.Text += "Clave: " + clave + "   Valor: " + Request.Params[clave] + "\n";
                    }

                    if ( clave.Contains("button_A") && Request.Params[clave] != null)
                    {
                        cajaInfo.Text += "Clave: " + clave + "   Valor: " + Request.Params[clave] + "\n";
                        button_A.Text = "He sido pulsado";
                    }                    

                    if (clave.Contains("button_B") && Request.Params[clave] != null)
                    {
                        cajaInfo.Text += "Clave: " + clave + "   Valor: " + Request.Params[clave] + "\n";
                        button_B.Text = "He sido pulsado";
                    }                    

                    if (clave.Contains("button_C") && Request.Params[clave] != null)
                    {
                        cajaInfo.Text += "Clave: " + clave + "   Valor: " + Request.Params[clave] + "\n";
                        button_C.Text = "He sido pulsado";
                    }

                    if (clave.Contains("button_D") && Request.Params[clave] != null)
                    {
                        cajaInfo.Text += "Clave: " + clave + "   Valor: " + Request.Params[clave] + "\n";
                        button_D.Text = "He sido pulsado";
                    }

                    // TreeView

                    if (clave.Contains("EVENTARGUMENT") && Request.Params[clave] != "")
                    {
                        cajaInfo.Text += "Clave: " + clave + "   Valor: " + Request.Params[clave] + "\n";
                        string[] pathHojaPulsadaTree = Request.Params[clave].Split('\\');
                        int profundidadHoja = pathHojaPulsadaTree.Count();
                        switch (profundidadHoja)
                        {
                            case 1: label_Tree.Text += pathHojaPulsadaTree.ElementAt(0).Substring(1); break;
                            case 2: label_Tree.Text += pathHojaPulsadaTree.ElementAt(1); break;
                            case 3: label_Tree.Text += pathHojaPulsadaTree.ElementAt(2); break;
                            case 4: label_Tree.Text += pathHojaPulsadaTree.ElementAt(3); break;
                        }
                    }
                }
            }
            else
            {
                cajaInfo.Text += "Tengo mucho que mostrar pero para este ejercicio nada que interese";
               
                // Creando Hojas Nuevas de TreeView a mano, lo pongo en el !IsPostBack para que solo se haga al cargar la pagina

                TreeNode ramaB = new TreeNode("Rama Creada con C#", "Rama Creada con C#");
                ramaB.ChildNodes.Add(new TreeNode("Hoja Dinamica 1", "Hoja Dinamica 1"));
                ramaB.ChildNodes[0].ChildNodes.Add(new TreeNode("Hoja Dinamica 2", "Hoja Dinamica 2"));
                ramaB.ChildNodes[0].ChildNodes[0].ChildNodes.Add(new TreeNode("Hoja Dinamica 3", "Hoja Dinamica 3"));
                treeViewPredefinido.Nodes.Add(ramaB);                

                label_PostBack.Text += nada;
            }
        }

        protected void button_CambioPagina_Click_ServerTransfer(object sender, EventArgs e)
        {
            Server.Transfer("ManejoVariablesEntrePostBack2.aspx");
        }

        protected void button_CambioPagina_Click_ResponseRedirect(object sender, EventArgs e)
        {
            Response.Redirect("ManejoVariablesEntrePostBack2.aspx");
        }
    }
}