namespace SRIU.WebForm
{
    partial class FrmEdicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblAtendido = new System.Windows.Forms.Label();
            this.chkAtendido = new System.Windows.Forms.CheckBox();
            this.lblLatitud = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.lblCodigoZona = new System.Windows.Forms.Label();
            this.txtCodigoZona = new System.Windows.Forms.TextBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 25);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(120, 22);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(28, 61);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(87, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de reporte:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(120, 57);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblAtendido
            // 
            this.lblAtendido.AutoSize = true;
            this.lblAtendido.Location = new System.Drawing.Point(28, 96);
            this.lblAtendido.Name = "lblAtendido";
            this.lblAtendido.Size = new System.Drawing.Size(58, 13);
            this.lblAtendido.TabIndex = 4;
            this.lblAtendido.Text = "¿Atendido?";
            // 
            // chkAtendido
            // 
            this.chkAtendido.AutoSize = true;
            this.chkAtendido.Location = new System.Drawing.Point(120, 95);
            this.chkAtendido.Name = "chkAtendido";
            this.chkAtendido.Size = new System.Drawing.Size(15, 14);
            this.chkAtendido.TabIndex = 5;
            this.chkAtendido.UseVisualStyleBackColor = true;
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.Location = new System.Drawing.Point(28, 130);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(42, 13);
            this.lblLatitud.TabIndex = 6;
            this.lblLatitud.Text = "Latitud:";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(120, 127);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(200, 20);
            this.txtLatitud.TabIndex = 7;
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(28, 165);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(51, 13);
            this.lblLongitud.TabIndex = 8;
            this.lblLongitud.Text = "Longitud:";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(120, 162);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(200, 20);
            this.txtLongitud.TabIndex = 9;
            // 
            // lblCodigoZona
            // 
            this.lblCodigoZona.AutoSize = true;
            this.lblCodigoZona.Location = new System.Drawing.Point(28, 200);
            this.lblCodigoZona.Name = "lblCodigoZona";
            this.lblCodigoZona.Size = new System.Drawing.Size(81, 13);
            this.lblCodigoZona.TabIndex = 10;
            this.lblCodigoZona.Text = "Código de zona:";
            // 
            // txtCodigoZona
            // 
            this.txtCodigoZona.Location = new System.Drawing.Point(120, 197);
            this.txtCodigoZona.Name = "txtCodigoZona";
            this.txtCodigoZona.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoZona.TabIndex = 11;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Location = new System.Drawing.Point(28, 235);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(66, 13);
            this.lblPresupuesto.TabIndex = 12;
            this.lblPresupuesto.Text = "Presupuesto:";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(120, 232);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(200, 20);
            this.txtPresupuesto.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(120, 275);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 32);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(230, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 32);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 329);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.txtCodigoZona);
            this.Controls.Add(this.lblCodigoZona);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.lblLatitud);
            this.Controls.Add(this.chkAtendido);
            this.Controls.Add(this.lblAtendido);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edición de Reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblAtendido;
        private System.Windows.Forms.CheckBox chkAtendido;
        private System.Windows.Forms.Label lblLatitud;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label lblCodigoZona;
        private System.Windows.Forms.TextBox txtCodigoZona;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
