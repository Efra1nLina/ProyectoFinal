namespace ProyectoFinal
{
    partial class QR
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
            pictureBox1 = new PictureBox();
            imprimirNombre = new Label();
            imprimirZona = new Label();
            imprimirAsiento = new Label();
            imprimirNumero = new Label();
            imprimirFecha = new Label();
            labelBeneficios = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Thistle;
            pictureBox1.Location = new Point(368, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // imprimirNombre
            // 
            imprimirNombre.AutoSize = true;
            imprimirNombre.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            imprimirNombre.Location = new Point(25, 36);
            imprimirNombre.Name = "imprimirNombre";
            imprimirNombre.Size = new Size(25, 41);
            imprimirNombre.TabIndex = 1;
            imprimirNombre.Text = ":)";
            // 
            // imprimirZona
            // 
            imprimirZona.AutoSize = true;
            imprimirZona.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            imprimirZona.Location = new Point(25, 77);
            imprimirZona.Name = "imprimirZona";
            imprimirZona.Size = new Size(25, 41);
            imprimirZona.TabIndex = 2;
            imprimirZona.Text = ":)";
            // 
            // imprimirAsiento
            // 
            imprimirAsiento.AutoSize = true;
            imprimirAsiento.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            imprimirAsiento.Location = new Point(25, 114);
            imprimirAsiento.Name = "imprimirAsiento";
            imprimirAsiento.Size = new Size(25, 41);
            imprimirAsiento.TabIndex = 3;
            imprimirAsiento.Text = ":)";
            // 
            // imprimirNumero
            // 
            imprimirNumero.AutoSize = true;
            imprimirNumero.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            imprimirNumero.Location = new Point(368, 9);
            imprimirNumero.Name = "imprimirNumero";
            imprimirNumero.Size = new Size(25, 41);
            imprimirNumero.TabIndex = 4;
            imprimirNumero.Text = ":)";
            imprimirNumero.Click += imprimirNumero_Click;
            // 
            // imprimirFecha
            // 
            imprimirFecha.AutoSize = true;
            imprimirFecha.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            imprimirFecha.Location = new Point(25, 144);
            imprimirFecha.Name = "imprimirFecha";
            imprimirFecha.Size = new Size(25, 41);
            imprimirFecha.TabIndex = 5;
            imprimirFecha.Text = ":)";
            // 
            // labelBeneficios
            // 
            labelBeneficios.AutoSize = true;
            labelBeneficios.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBeneficios.Location = new Point(25, 174);
            labelBeneficios.Name = "labelBeneficios";
            labelBeneficios.Size = new Size(25, 41);
            labelBeneficios.TabIndex = 6;
            labelBeneficios.Text = ":)";
            // 
            // QR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(550, 213);
            Controls.Add(labelBeneficios);
            Controls.Add(imprimirFecha);
            Controls.Add(imprimirNumero);
            Controls.Add(imprimirAsiento);
            Controls.Add(imprimirZona);
            Controls.Add(imprimirNombre);
            Controls.Add(pictureBox1);
            Name = "QR";
            Text = "QR";
            Load += QR_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label imprimirNombre;
        private Label imprimirZona;
        private Label imprimirAsiento;
        private Label imprimirNumero;
        private Label imprimirFecha;
        private Label labelBeneficios;
    }
}