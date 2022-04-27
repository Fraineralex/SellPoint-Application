﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layers.Framework.ADO.Net;

namespace Splash_Screen
{
    public partial class FormRegistrarEntidad : Form
    {
        public bool actualizando = false;

        clsBeEntidades entidad = new clsBeEntidades();
        clsLnEntidades logicaEntidad = new clsLnEntidades();

        public FormRegistrarEntidad()
        {
            InitializeComponent();
        }

        public void CargarComboBoxesSelectIndex()
        {
            comboBoxTipoEntidadRegistrarEntidad.SelectedIndex = 0;
            comboBoxTipoDocumentoRegistrarEntidad.SelectedIndex = 0;
            comboBoxRolUserRegistrarEntidad.SelectedIndex = 0;
            comboBoxStatusRegistrarEntidad.SelectedIndex = 0;
            comboBoxNoEliminableRegistrarEntidad.SelectedIndex = 1;
        }

        private void RegistrarEntidad(object sender, EventArgs e)
        {
            if (!actualizando)
            {
                try
                {
                    entidad.Descripcion = textBoxDescripcionRegistrarEntidad.Text.ToString();
                    entidad.Direccion = textBoxDireccionResgistrarEntidad.Text.ToString();
                    entidad.Localidad = textBoxLocalidadRegistrarEntidad.Text.ToString();
                    entidad.TipoEntidad = comboBoxTipoEntidadRegistrarEntidad.Text.ToString();
                    entidad.TipoDocumento = comboBoxTipoDocumentoRegistrarEntidad.Text.ToString();
                    entidad.NumeroDocumento = Convert.ToDouble(textBoxNumeroDocumentoRegistrarEntidad.Text.ToString());
                    entidad.Telefono = textBoxTelefonoRegistrarEntidad.Text.ToString();
                    entidad.URLPaginaWeb = textBoxURLPáginaWebRegistrarEntidad.Text.ToString();
                    entidad.URLFacebook = textBoxURLFacebookRegistrarEntidad.Text.ToString();
                    entidad.URLInstagram = textBoxURLInstagramRegistrarEntidad.Text.ToString();
                    entidad.URLTwitter = textBoxURLTwitterRegistrarEntidad.Text.ToString();
                    entidad.URLTiktok = textBoxURLTikTokRegistrarEntidad.Text.ToString();
                    entidad.IdGrupoEntidad = Convert.ToInt32(textBoxIdGrupoEntidadRegistrarEntidad.Text.ToString());
                    entidad.IdTipoEntidad = Convert.ToInt32(textBoxIdTipoEntidadRegistrarEntidad.Text.ToString());
                    entidad.LimiteCredito = Convert.ToDouble(textBoxLimiteCreditoRegistrarEntidad.Text.ToString());
                    entidad.UserNameEntidad = textBoxUsernameRegistrarEntidad.Text.ToString();
                    entidad.PasswordEntidad = textBoxPasswordRegistrarEntidad.Text.ToString();
                    entidad.RolUserEntidad = comboBoxRolUserRegistrarEntidad.Text.ToString();
                    entidad.Comentario = textBoxComentarioRegistrarEntidad.Text.ToString();
                    entidad.Status = comboBoxStatusRegistrarEntidad.Text.ToString();
                    entidad.NoEliminable = Convert.ToBoolean(comboBoxNoEliminableRegistrarEntidad.Text.ToString());
                    entidad.FechaRegistro = Convert.ToDateTime(dateTimePickerRegistrarEntidad.Text.ToString());

                    logicaEntidad.Insertar(ref entidad);

                    MessageBox.Show("Entidad guardada exitosamente.", "Guardada!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Asegúrese de llenar todos los campos.", "Atención");
                }

            }

            if (actualizando)
            {
                try
                {
                    entidad.IdEntidad = Convert.ToInt32(textBoxIdEntidadRegistrarEntidad.Text.ToString());
                    entidad.Descripcion = textBoxDescripcionRegistrarEntidad.Text.ToString();
                    entidad.Direccion = textBoxDireccionResgistrarEntidad.Text.ToString();
                    entidad.Localidad = textBoxLocalidadRegistrarEntidad.Text.ToString();
                    entidad.TipoEntidad = comboBoxTipoEntidadRegistrarEntidad.Text.ToString();
                    entidad.TipoDocumento = comboBoxTipoDocumentoRegistrarEntidad.Text.ToString();
                    entidad.NumeroDocumento = Convert.ToDouble(textBoxNumeroDocumentoRegistrarEntidad.Text.ToString());
                    entidad.Telefono = textBoxTelefonoRegistrarEntidad.Text.ToString();
                    entidad.URLPaginaWeb = textBoxURLPáginaWebRegistrarEntidad.Text.ToString();
                    entidad.URLFacebook = textBoxURLFacebookRegistrarEntidad.Text.ToString();
                    entidad.URLInstagram = textBoxURLInstagramRegistrarEntidad.Text.ToString();
                    entidad.URLTwitter = textBoxURLTwitterRegistrarEntidad.Text.ToString();
                    entidad.URLTiktok = textBoxURLTikTokRegistrarEntidad.Text.ToString();
                    entidad.IdGrupoEntidad = Convert.ToInt32(textBoxIdGrupoEntidadRegistrarEntidad.Text.ToString());
                    entidad.IdTipoEntidad = Convert.ToInt32(textBoxIdTipoEntidadRegistrarEntidad.Text.ToString());
                    entidad.LimiteCredito = Convert.ToDouble(textBoxLimiteCreditoRegistrarEntidad.Text.ToString());
                    entidad.UserNameEntidad = textBoxUsernameRegistrarEntidad.Text.ToString();
                    entidad.PasswordEntidad = textBoxPasswordRegistrarEntidad.Text.ToString();
                    entidad.RolUserEntidad = comboBoxRolUserRegistrarEntidad.Text.ToString();
                    entidad.Comentario = textBoxComentarioRegistrarEntidad.Text.ToString();
                    entidad.Status = comboBoxStatusRegistrarEntidad.Text.ToString();
                    entidad.NoEliminable = Convert.ToBoolean(comboBoxNoEliminableRegistrarEntidad.Text);
                    entidad.FechaRegistro = Convert.ToDateTime(dateTimePickerRegistrarEntidad.Text.ToString());

                    logicaEntidad.Actualizar(ref entidad);

                    MessageBox.Show("Entidad actualizada exitosamente.", "Actualizada!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Asegúrese de llenar todos los campos.", "Atención");
                }
            }
        }
    }
}