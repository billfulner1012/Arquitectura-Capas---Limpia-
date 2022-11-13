using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capanegocio;

namespace capapresentacion
{

  
    public partial class frmClientes : Form
    {

        bool esnuevo = false;
        bool eseditar = false;
        public frmClientes()
        {
            InitializeComponent();
        }

       private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema de clientes",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiar()
        {
            this.txtcodigo.Text = string.Empty;
            this.txtnombre.Text= string.Empty;
            this.txtapellidos.Text = string.Empty;
            this.cbosexo.SelectedValue = "M";
            this.cbotipodocumento.SelectedValue = "DNI";
            this.txtdocumento.Text= string.Empty;
            this.txtdireccion.Text = string.Empty;

        }

        private void habilitar(bool valor)
        {
            this.txtcodigo.ReadOnly = true;
            this.txtnombre.ReadOnly = !valor;
            this.txtapellidos.ReadOnly = !valor;
            this.txtdocumento.ReadOnly = !valor;
            this.txtdireccion.ReadOnly = !valor;
            this.cbosexo.Enabled = valor;
            this.cbotipodocumento.Enabled = valor;
            this.dtfechanacimiento.Enabled = valor;

        }

        private void botones()
        {
            if (esnuevo || this.eseditar)
            {
                habilitar(true);
                btnuevo.Enabled = false;
                this.btnguardar.Enabled = true;
                this.btneditar.Enabled = false;
                this.btncancelar.Enabled = true;

            }
            else
            {
                habilitar(false);
                btnuevo.Enabled = true;
                this.btnguardar.Enabled = false;
                this.btneditar.Enabled = true;
                this.btncancelar.Enabled = false;
            }
        }

        private void mostrarclientes()
        {
            this.datalistado.DataSource = NCliente.mostrarcliente();
            this.ocultarcolumnas();
            this.lbltotal.Text = "la cantidad total de clientes es :" + Convert.ToString(datalistado.Rows.Count);
        }

        private void ocultarcolumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            
            this.mostrarclientes();
            this.botones();
        }

        private void cbosexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            esnuevo = true;
            botones();
            limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if(this.txtnombre.Text==string.Empty || this.txtapellidos.Text == string.Empty ||
                    this.txtdocumento.Text == string.Empty)
                {
                    mensajeerror("faltan datos por ingresar seran remarcados");
                    this.iconoerror.SetError(this.txtnombre, "ingresar nombre");
                    this.iconoerror.SetError(this.txtapellidos, "ingresar apellidos");
                    this.iconoerror.SetError(this.txtdocumento, "ingresar documento");
                }
                else
                {
                    if (esnuevo)
                    {
                        rpta = NCliente.insertarcliente(this.txtnombre.Text.Trim().ToUpper(),this.txtapellidos.Text.Trim().ToUpper(),
                           this.cbosexo.Text,this.dtfechanacimiento.Value,cbotipodocumento.Text,this.txtdocumento.Text.Trim(),this.txtdireccion.Text.Trim());
                    }
                    else
                    {
                        rpta = NCliente.editarcliente(Convert.ToInt32(this.txtcodigo.Text),this.txtnombre.Text.Trim().ToUpper(), this.txtapellidos.Text.Trim().ToUpper(),
                           this.cbosexo.Text, this.dtfechanacimiento.Value, cbotipodocumento.Text, this.txtdocumento.Text.Trim(), this.txtdireccion.Text.Trim());
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("se inserto el cliente satisfactoriamente");
                        }
                        else
                        {
                            this.mensajeok("se actualizo el cliente satisfactoriamente");
                        }
                        
                    }
                    else
                    {
                        this.mensajeerror(rpta);
                    }
                    this.esnuevo = false;
                    this.eseditar = false;
                    botones();
                    this.limpiar();
                    this.mostrarclientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.StackTrace);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtcodigo.Text.Equals(""))
            {
                this.eseditar = true;
                this.botones();
                this.mostrarclientes();
            }
            else
            {
                this.mensajeerror("selleccione el registro a modificar");
            }
            
        }

        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtcodigo.Text = Convert.ToString(datalistado.CurrentRow.Cells["idcliente"].Value);
            this.txtnombre.Text = Convert.ToString(datalistado.CurrentRow.Cells["nombre"].Value);
            this.txtapellidos.Text = Convert.ToString(datalistado.CurrentRow.Cells["apellidos"].Value);
            this.cbosexo.SelectedValue = Convert.ToString(datalistado.CurrentRow.Cells["sexo"].Value);
            this.dtfechanacimiento.Text = Convert.ToString(datalistado.CurrentRow.Cells["fecha_nacimiento"].Value);
            this.cbotipodocumento.SelectedValue = Convert.ToString(datalistado.CurrentRow.Cells["tipo_documento"].Value);
            this.txtdocumento.Text = Convert.ToString(datalistado.CurrentRow.Cells["documento"].Value);
            this.txtdireccion.Text = Convert.ToString(datalistado.CurrentRow.Cells["direccion"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void buscarclientexnombre(string texto)
        {
            this.datalistado.DataSource = NCliente.buscarclientenombre(texto);
            this.ocultarcolumnas(); 
        }

        private void buscarclientexapellidos(string texto)
        {
            this.datalistado.DataSource = NCliente.buscarclienteapellidos(texto);
            this.ocultarcolumnas();
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cbobuscar.Text.Equals("NOMBRE"))
            {
                this.buscarclientexnombre(this.txtbuscar.Text);
            }
            if (this.cbobuscar.Text.Equals("APELLIDOS"))
            {
                this.buscarclientexapellidos(this.txtbuscar.Text);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (this.cbobuscar.Text.Equals("NOMBRE"))
            {
                this.buscarclientexnombre(this.txtbuscar.Text);
            }
            if (this.cbobuscar.Text.Equals("APELLIDOS"))
            {
                this.buscarclientexnombre(this.txtbuscar.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.datalistado.Columns[0].Visible = true;
            }
            else
            {
                this.datalistado.Columns[0].Visible = false;
            }
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==datalistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)datalistado.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente quiere eliminar las filas seleccionas?","sistema de clientes",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (opcion==DialogResult.OK)
                {
                    int codigo;
                    string rpta = "";
                    foreach (DataGridViewRow row in datalistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo =Convert.ToInt32( row.Cells[1].Value);
                            rpta = NCliente.eliminarcliente(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.mensajeok("se elimino el cliente corrextamente");
                            }
                            else
                            {
                                this.mensajeerror(rpta);
                            }
                        }
                    }
                    this.mostrarclientes();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
