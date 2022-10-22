namespace Rifa
{
    partial class FormRifa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombrePersona = new System.Windows.Forms.Label();
            this.lblApellidoPersona = new System.Windows.Forms.Label();
            this.lblNumRifa = new System.Windows.Forms.Label();
            this.tboxNombrePersona = new System.Windows.Forms.TextBox();
            this.tboxApellidoPersona = new System.Windows.Forms.TextBox();
            this.tboxNumRifaElegido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.AutoSize = true;
            this.lblNombrePersona.Location = new System.Drawing.Point(165, 72);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(51, 15);
            this.lblNombrePersona.TabIndex = 0;
            this.lblNombrePersona.Text = "Nombre";
            // 
            // lblApellidoPersona
            // 
            this.lblApellidoPersona.AutoSize = true;
            this.lblApellidoPersona.Location = new System.Drawing.Point(165, 161);
            this.lblApellidoPersona.Name = "lblApellidoPersona";
            this.lblApellidoPersona.Size = new System.Drawing.Size(51, 15);
            this.lblApellidoPersona.TabIndex = 1;
            this.lblApellidoPersona.Text = "Apellido";
            // 
            // lblNumRifa
            // 
            this.lblNumRifa.AutoSize = true;
            this.lblNumRifa.Location = new System.Drawing.Point(165, 261);
            this.lblNumRifa.Name = "lblNumRifa";
            this.lblNumRifa.Size = new System.Drawing.Size(74, 15);
            this.lblNumRifa.TabIndex = 2;
            this.lblNumRifa.Text = "Numero Rifa";
            // 
            // tboxNombrePersona
            // 
            this.tboxNombrePersona.Location = new System.Drawing.Point(256, 64);
            this.tboxNombrePersona.Name = "tboxNombrePersona";
            this.tboxNombrePersona.Size = new System.Drawing.Size(373, 23);
            this.tboxNombrePersona.TabIndex = 3;
            // 
            // tboxApellidoPersona
            // 
            this.tboxApellidoPersona.Location = new System.Drawing.Point(256, 153);
            this.tboxApellidoPersona.Name = "tboxApellidoPersona";
            this.tboxApellidoPersona.Size = new System.Drawing.Size(373, 23);
            this.tboxApellidoPersona.TabIndex = 4;
            // 
            // tboxNumRifaElegido
            // 
            this.tboxNumRifaElegido.Location = new System.Drawing.Point(256, 253);
            this.tboxNumRifaElegido.Name = "tboxNumRifaElegido";
            this.tboxNumRifaElegido.Size = new System.Drawing.Size(373, 23);
            this.tboxNumRifaElegido.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(325, 341);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(164, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormRifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tboxNumRifaElegido);
            this.Controls.Add(this.tboxApellidoPersona);
            this.Controls.Add(this.tboxNombrePersona);
            this.Controls.Add(this.lblNumRifa);
            this.Controls.Add(this.lblApellidoPersona);
            this.Controls.Add(this.lblNombrePersona);
            this.Name = "FormRifa";
            this.Text = "FormRifa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombrePersona;
        private Label lblApellidoPersona;
        private Label lblNumRifa;
        private TextBox tboxNombrePersona;
        private TextBox tboxApellidoPersona;
        private TextBox tboxNumRifaElegido;
        private Button btnGuardar;
    }
}