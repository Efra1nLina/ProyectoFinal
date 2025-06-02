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
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(86, 41);
            label1.TabIndex = 0;
            label1.Text = "Capacidad:   \r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(86, 41);
            label2.TabIndex = 1;
            label2.Text = "Disponibles:";
            // 
            // libre
            // 
            libre.AutoSize = true;
            libre.BackColor = SystemColors.Control;
            libre.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            libre.ForeColor = Color.Chartreuse;
            libre.Location = new Point(94, 76);
            libre.Name = "libre";
            libre.Size = new Size(25, 41);
            libre.TabIndex = 2;
            libre.Text = ":)";
            libre.Click += libre_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(86, 41);
            label4.TabIndex = 3;
            label4.Text = "Reservados:";
            // 
            // ocupado
            // 
            ocupado.AutoSize = true;
            ocupado.BackColor = SystemColors.Control;
            ocupado.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ocupado.ForeColor = Color.Red;
            ocupado.Location = new Point(94, 117);
            ocupado.Name = "ocupado";
            ocupado.Size = new Size(25, 41);
            ocupado.TabIndex = 4;
            ocupado.Text = ":)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(730, 35);
            label3.Name = "label3";
            label3.Size = new Size(62, 41);
            label3.TabIndex = 5;
            label3.Text = "Precios:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(94, 35);
            label5.Name = "label5";
            label5.Size = new Size(32, 41);
            label5.TabIndex = 6;
            label5.Text = "72";
            // 
            // Disponibilidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 549);
            Controls.Add(label5);
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
        private Label label5;
    }
}