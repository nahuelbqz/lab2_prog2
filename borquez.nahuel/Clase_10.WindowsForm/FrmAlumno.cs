﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10.Entidades;

namespace Clase_10.WindowsForm
{
    public partial class FrmAlumno : Form
    { 
        private Alumno miAlumno;

        public Alumno Alumno{  get{  return this.miAlumno; } }//property solo lectura (s/l), devuelve un alumno


        public FrmAlumno()
        {
            InitializeComponent();
            foreach(ETipoExamen a in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoExamen.Items.Add(a);
            }
            this.cmbTipoExamen.SelectedItem = ETipoExamen.Final;
            this.cmbTipoExamen.DropDownStyle = ComboBoxStyle.DropDownList;
            StartPosition = FormStartPosition.CenterScreen;
        }
        //otro constructor del frmAlumno que inicie el alumno en el frm
        public FrmAlumno(Alumno alumnoUno):this()
        {
            this.txtNombre.Text = alumnoUno.Nombre;
            this.txtApellido.Text = alumnoUno.Apellido;
            this.txtLegajo.Text = alumnoUno.Legajo.ToString();
            this.cmbTipoExamen.SelectedIndex = (int)alumnoUno.Examen;
            
            this.txtLegajo.Enabled = false;

        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            miAlumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, Convert.ToInt32(this.txtLegajo.Text), (ETipoExamen)(this.cmbTipoExamen.SelectedItem));

            DialogResult = DialogResult.OK;
        }
    }
}
