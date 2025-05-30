namespace ProyectoFinal
{
    partial class Form1
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
            botonDisponibilidad = new Button();
            botonComprar = new Button();
            botonCancelar = new Button();
            SuspendLayout();
            // 
            // botonDisponibilidad
            // 
            botonDisponibilidad.Location = new Point(71, 358);
            botonDisponibilidad.Name = "botonDisponibilidad";
            botonDisponibilidad.Size = new Size(132, 30);
            botonDisponibilidad.TabIndex = 0;
            botonDisponibilidad.Text = "Disponibilidad";
            botonDisponibilidad.UseVisualStyleBackColor = true;
            botonDisponibilidad.Click += botonDisponibilidad_Click;
            // 
            // botonComprar
            // 
            botonComprar.Location = new Point(305, 352);
            botonComprar.Name = "botonComprar";
            botonComprar.Size = new Size(160, 36);
            botonComprar.TabIndex = 1;
            botonComprar.Text = "Comprar";
            botonComprar.UseVisualStyleBackColor = true;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(573, 351);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(144, 38);
            botonCancelar.TabIndex = 2;
            botonCancelar.Text = "Cancelar boleto";
            botonCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonCancelar);
            Controls.Add(botonComprar);
            Controls.Add(botonDisponibilidad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button botonDisponibilidad;
        private Button botonComprar;
        private Button botonCancelar;
    }
}