using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab03Parte3.Data;

namespace Lab03Parte3.Pages
{
    public partial class Mantenimiento_de_usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (Lab03Entities1 db = new Lab03Entities1())
            {
                var Usuarios = db.sp_ConsultaUsuario();
                gv_Usuarios.DataSource = Usuarios;
                gv_Usuarios.DataBind();
            }
        }

        protected void gv_Usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = gv_Usuarios.SelectedRow.Cells[1].Text;
            txtNombre.Text = gv_Usuarios.SelectedRow.Cells[2].Text;
            txtNick.Text = gv_Usuarios.SelectedRow.Cells[3].Text;
            txtContra.Text = gv_Usuarios.SelectedRow.Cells[4].Text;
            txtFechaCrea.Text = gv_Usuarios.SelectedRow.Cells[5].Text;
            txtUActua.Text = gv_Usuarios.SelectedRow.Cells[6].Text;
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            using (Lab03Entities1 db = new Lab03Entities1())
            {
                db.sp_CrearUsuario(txtNombre.Text, txtNick.Text, txtContra.Text, System.DateTime.Today, System.DateTime.Today);

                var Usuarios = db.sp_ConsultaUsuario();
                gv_Usuarios.DataSource = Usuarios;
                gv_Usuarios.DataBind();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (Lab03Entities1 db = new Lab03Entities1())
            {
                db.sp_UpdateUsuario(int.Parse(txtID.Text), txtNombre.Text, txtNick.Text, txtContra.Text, System.DateTime.Today);

                var Usuarios = db.sp_ConsultaUsuario();
                gv_Usuarios.DataSource = Usuarios;
                gv_Usuarios.DataBind();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (Lab03Entities1 db = new Lab03Entities1())
            {
                db.sp_EliminaUsuario(int.Parse(txtID.Text));

                var Usuarios = db.sp_ConsultaUsuario();
                gv_Usuarios.DataSource = Usuarios;
                gv_Usuarios.DataBind();
            }
        }
    }
}