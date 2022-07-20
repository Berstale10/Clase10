using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab03Parte3.Data;

namespace Lab03Parte3.Pages
{
    public partial class ConsultaProvincia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (Lab03Entities1 db = new Lab03Entities1())
            {
                var Lista = db.sp_ConsultaProvincia().ToList();
                grv_Provincias.DataSource = Lista;
                grv_Provincias.DataBind();
            }
        }

        protected void grv_Provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("EditarProvincias.aspx?id=" + grv_Provincias.SelectedRow.Cells[1].Text);
        }
    }
}