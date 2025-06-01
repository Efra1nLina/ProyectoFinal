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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(368, 36);
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
            imprimirNombre.Location = new Point(25, 36);
            imprimirNombre.Name = "imprimirNombre";
            imprimirNombre.Size = new Size(14, 15);
            imprimirNombre.TabIndex = 1;
            imprimirNombre.Text = ":)";
            // 
            // imprimirZona
            // 
            imprimirZona.AutoSize = true;
            imprimirZona.Location = new Point(25, 77);
            imprimirZona.Name = "imprimirZona";
            imprimirZona.Size = new Size(14, 15);
            imprimirZona.TabIndex = 2;
            imprimirZona.Text = ":)";
            // 
            // imprimirAsiento
            // 
            imprimirAsiento.AutoSize = true;
            imprimirAsiento.Location = new Point(25, 114);
            imprimirAsiento.Name = "imprimirAsiento";
            imprimirAsiento.Size = new Size(14, 15);
            imprimirAsiento.TabIndex = 3;
            imprimirAsiento.Text = ":)";
            // 
            // imprimirNumero
            // 
            imprimirNumero.AutoSize = true;
            imprimirNumero.Location = new Point(368, 9);
            imprimirNumero.Name = "imprimirNumero";
            imprimirNumero.Size = new Size(14, 15);
            imprimirNumero.TabIndex = 4;
            imprimirNumero.Text = ":)";
            imprimirNumero.Click += imprimirNumero_Click;
            // 
            // imprimirFecha
            // 
            imprimirFecha.AutoSize = true;
            imprimirFecha.Location = new Point(25, 144);
            imprimirFecha.Name = "imprimirFecha";
            imprimirFecha.Size = new Size(14, 15);
            imprimirFecha.TabIndex = 5;
            imprimirFecha.Text = ":)";
            // 
            // QR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 198);
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
    }
}