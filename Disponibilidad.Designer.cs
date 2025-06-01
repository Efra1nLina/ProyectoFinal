namespace ProyectoFinal
{
    partial class Disponibilidad
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
            label1 = new Label();
            label2 = new Label();
            libre = new Label();
            label4 = new Label();
            ocupado = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Capacidad: 72\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Disponibles:";
            // 
            // libre
            // 
            libre.AutoSize = true;
            libre.Location = new Point(89, 61);
            libre.Name = "libre";
            libre.Size = new Size(14, 15);
            libre.TabIndex = 2;
            libre.Text = ":)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 89);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Reservados:";
            // 
            // ocupado
            // 
            ocupado.AutoSize = true;
            ocupado.Location = new Point(89, 89);
            ocupado.Name = "ocupado";
            ocupado.Size = new Size(14, 15);
            ocupado.TabIndex = 4;
            ocupado.Text = ":)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(730, 35);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Precios:";
            // 
            // Disponibilidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 549);
            Controls.Add(label3);
            Controls.Add(ocupado);
            Controls.Add(label4);
            Controls.Add(libre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Disponibilidad";
            Text = "Disponibilidad";
            Load += Disponibilidad_Load;
            Paint += Disponibilidad_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label libre;
        private Label label4;
        private Label ocupado;
        private Label label3;
    }
}