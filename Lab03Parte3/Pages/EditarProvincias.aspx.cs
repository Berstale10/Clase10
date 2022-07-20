using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab03Parte3.Data;

namespace Lab03Parte3.Pages
{
    public partial class EditarProvincias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack) { }
                string id = Request.QueryString["id"];
                using (Lab03Entities1 db = new Lab03Entities1())
                {
                    var Provincia = db.spConsultarProvinciaPorId(Int32.Parse(id)).ToList();
                    txtID.Text = Provincia[0].id_Provincia.ToString();
                    txtNombre.Text = Provincia[0].Nombre.ToString();
                }
            }
            catch
            {

            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (Lab03Entities1 db = new Lab03Entities1())
                {
                    int Afectadas = db.spEditarProvincia(Int32.Parse(txtID.Text),txtNombre.Text,"A");
                    if (Afectadas > 0)
                    {
                        Response.Redirect("ResultadoDeEditarProvincia.aspx", false);
                    }
                }
            }
            catch
            {
                Response.Redirect("ConsultaProvincia.aspx", false);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                using (Lab03Entities1 db = new Lab03Entities1())
                {
                    int Afectadas = db.spEliminarProvinciapt3(Int32.Parse(txtID.Text));
                    if (Afectadas > 0)
                    {
                        Response.Redirect("ResultadoDeEditarProvincia.aspx", false);
                    }
                }
            }
            catch
            {
                Response.Redirect("ConsultaProvincia.aspx", false);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultaProvincia.aspx", false);
        }
    }
}