using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab03Parte3.Data;

namespace Lab03Parte3.Pages
{
    public partial class ListaProvincias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (Lab03Entities1 bd = new Lab03Entities1())
            {
                var Provincias = bd.sp_ConsultaProvincia();
                gv_Provincias.DataSource = Provincias;
                gv_Provincias.DataBind();
            }
        }

        protected void gv_Provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Response.Redirect("EditarProvincias.aspx?id=" + gv_Provincias.SelectedRow.Cells[1].Text);
            ///txtNombre.Text = gv_Provincias.SelectedRow.Cells[1].Text;
            ///txtEstado.Text = gv_Provincias.SelectedRow.Cells[2].Text;
        }

        ///protected void btnInsertar_Click(object sender, EventArgs e)
        //{
            ///using (Lab03Entities1 bd = new Lab03Entities1())
            //{
                ///bd.sp_CrearProvincia(txtNombre.Text, txtEstado.Text);
                ///var Provincias = bd.sp_ConsultaProvincia();
                ///gv_Provincias.DataSource = Provincias;
                //gv_Provincias.DataBind();
            //}
        ///}

        ///protected void btnActualizar_Click(object sender, EventArgs e)
        //{
            ///using(Lab03Entities1 bd = new Lab03Entities1())
            ///{
                ///bd.sp_UpdateProvincia(txtNombre.Text, txtEstado.Text);
                ///var Provincias = bd.sp_ConsultaProvincia();
                ///gv_Provincias.DataSource = Provincias;
                ///gv_Provincias.DataBind();
            //}
        ///}

        ///protected void btnEliminar_Click(object sender, EventArgs e)
        ///{
            ///using (Lab03Entities1 bd = new Lab03Entities1())
            ///{
                ///bd.sp_EliminaProvincia(txtNombre.Text);
                ///var Provincias = bd.sp_ConsultaProvincia();
                ///gv_Provincias.DataSource = Provincias;
                ///gv_Provincias.DataBind();
            ///}
        ///}
    }
}