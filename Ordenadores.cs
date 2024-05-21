using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Final
{
    public partial class Ordenadores : Form
    {
        public static bool Nuevo = false;
        public static bool Consulta = false;
        public static bool Buscar = false;
        public static bool Eliminar = false;
        public Ordenadores()
        {
            InitializeComponent();
        }

        private void Ordenadores_Load(object sender, EventArgs e)
        {
            lsbacciones.Items.Add("Introducir nuevo producto");
            lsbacciones.Items.Add("Realizar consulta");
            lsbacciones.Items.Add("Buscar por codigo");
            lsbacciones.Items.Add("Eliminar producto");
        }

        private void lsbacciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            String accion = (String)lsbacciones.SelectedItem;

            if (accion == "Introducir nuevo producto")
            {
                Nuevo = true;
                Consulta = false;
                Buscar = false;
                Eliminar=false;
            }
            else if(accion == "Realizar consulta")
            {
                Nuevo = false;
                Consulta = true;
                Buscar = false;
                Eliminar = false;
            }
            else if(accion == "Buscar por codigo")
            {
                Nuevo = false;
                Consulta = false;
                Buscar = true;
                Eliminar = false;
            }
            else if(accion == "Eliminar producto")
            {
                Nuevo = false;
                Consulta = false;
                Buscar = false;
                Eliminar = true;
            }
            else
            {
                
            }
            if (Nuevo == true)
            {
                lblCode.Visible = true;
                txtCode.Visible = true;
                lblHdd.Visible = true;
                txthdd.Visible = true;
                lblMarc.Visible = true;
                txtMarc.Visible = true;
                lblModel.Visible = true;
                txtModel.Visible = true;
                lblPrecio.Visible = true;
                txtPrecio.Visible = true;
                lblProcesador.Visible = true;
                txtProcesador.Visible = true;
                lblRam.Visible = true;
                txtRam.Visible = true;
                lblSsd.Visible = true;
                txtSsd.Visible = true;
            }
            else
            {
                lblCode.Visible = false;
                txtCode.Visible = false;
                lblHdd.Visible = false;
                txthdd.Visible = false;                   
                lblMarc.Visible = false;
                txtMarc.Visible = false;
                lblPrecio.Visible = false;
                txtPrecio.Visible = false;
                lblProcesador.Visible = false;
                txtProcesador.Visible = false;
                lblRam.Visible = false;
                txtRam.Visible = false;
                lblSsd.Visible = false;
                txtSsd.Visible = false; 
                lblModel.Visible = false;
                txtModel.Visible = false;
            }
        }
    }
}
