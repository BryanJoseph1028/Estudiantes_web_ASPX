
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_estudiantes_asp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Estudiante estudiante;
        protected void Page_Load(object sender, EventArgs e){
            if (!IsPostBack){
                estudiante = new Estudiante();
                estudiante.drop_sangre(drop_sangre);
                estudiante.grid_estudiante(grid_estudiante);

                
            }

        }

        protected void grid_estudiante_SelectedIndexChanged(object sender, EventArgs e){
            txt_carne.Text = grid_estudiante.SelectedRow.Cells[2].Text;
            txt_nombres.Text = grid_estudiante.SelectedRow.Cells[3].Text;
            txt_apellidos.Text = grid_estudiante.SelectedRow.Cells[4].Text;
            txt_direccion.Text = grid_estudiante.SelectedRow.Cells[5].Text;
            txt_correo.Text = grid_estudiante.SelectedRow.Cells[6].Text;
            DateTime fecha = Convert.ToDateTime(grid_estudiante.SelectedRow.Cells[7].Text);
            txt_fn.Text = fecha.ToString("yyy-mm-dd");
            int indice = grid_estudiante.SelectedRow.RowIndex;
            drop_sangre.SelectedValue = grid_estudiante.dataKeys[indice].value["id_tipo_sangre"].ToString();
        }

        protected void btn_crear_Click(object sender, EventArgs e) {
           estudiante=new Estudiante();
            if (estudiante.crear(txt_carne.Text,txt_nombres.Text,txt_apellidos.Text,txt_direccion.Text,txt_correo.Text,Convert.ToInt32(drop_sangre.SelectedValue),txt_fn.Text) > 0){
                lbl_mensaje.Text = "ingreso exitoso ";
                estudiante.grid_estudiante(grid_estudiante);

            }


        }

        protected void grid_estudiante_RowDeleting(object sender, GridViewDeleteEventArgs e){
            estudiante = new Estudiante();
            if (estudiante.borrar(Convert.ToInt32(e.Keys["id"])) > 0 )
            {
                lbl_mensaje.Text = "actualizado exitoso ";
                estudiante.grid_estudiante(grid_estudiante);

            }

        }

        protected void btn_actualizar_Click(object sender, EventArgs e){
            estudiante = new Estudiante();
            if (estudiante.actualizar(Convert.ToInt32(grid_estudiante.SelectedValue), txt_carne.Text, txt_nombres.Text, txt_apellidos.Text, txt_direccion.Text, txt_correo.Text, Convert.ToInt32(drop_sangre.SelectedValue), txt_fn.Text) > 0)
            {
                lbl_mensaje.Text = "actualizado exitoso ";
                estudiante.grid_estudiante(grid_estudiante);

            }

        }
    }
}