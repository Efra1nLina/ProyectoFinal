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
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Navy;
            pictureBox1.Location = new Point(370, 88);
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
            imprimirNombre.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            imprimirNombre.Location = new Point(26, 82);
            imprimirNombre.Name = "imprimirNombre";
            imprimirNombre.Size = new Size(17, 14);
            imprimirNombre.TabIndex = 1;
            imprimirNombre.Text = ":)";
            // 
            // imprimirZona
            // 
            imprimirZona.AutoSize = true;
            imprimirZona.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            imprimirZona.Location = new Point(26, 123);
            imprimirZona.Name = "imprimirZona";
            imprimirZona.Size = new Size(17, 14);
            imprimirZona.TabIndex = 2;
            imprimirZona.Text = ":)";
            // 
            // imprimirAsiento
            // 
            imprimirAsiento.AutoSize = true;
            imprimirAsiento.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            imprimirAsiento.Location = new Point(26, 160);
            imprimirAsiento.Name = "imprimirAsiento";
            imprimirAsiento.Size = new Size(17, 14);
            imprimirAsiento.TabIndex = 3;
            imprimirAsiento.Text = ":)";
            // 
            // imprimirNumero
            // 
            imprimirNumero.AutoSize = true;
            imprimirNumero.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            imprimirNumero.Location = new Point(370, 70);
            imprimirNumero.Name = "imprimirNumero";
            imprimirNumero.Size = new Size(17, 14);
            imprimirNumero.TabIndex = 4;
            imprimirNumero.Text = ":)";
            imprimirNumero.Click += imprimirNumero_Click;
            // 
            // imprimirFecha
            // 
            imprimirFecha.AutoSize = true;
            imprimirFecha.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            imprimirFecha.Location = new Point(26, 197);
            imprimirFecha.Name = "imprimirFecha";
            imprimirFecha.Size = new Size(17, 14);
            imprimirFecha.TabIndex = 5;
            imprimirFecha.Text = ":)";
            // 
            // labelBeneficios
            // 
            labelBeneficios.AutoSize = true;
            labelBeneficios.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelBeneficios.Location = new Point(26, 237);
            labelBeneficios.Name = "labelBeneficios";
            labelBeneficios.Size = new Size(17, 14);
            labelBeneficios.TabIndex = 6;
            labelBeneficios.Text = ":)";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._124671;
            pictureBox5.Location = new Point(-130, -3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(807, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // QR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(550, 292);
            Controls.Add(pictureBox5);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private PictureBox pictureBox5;
    }
}