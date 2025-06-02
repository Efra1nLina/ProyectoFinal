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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(33, 60);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 0;
            label1.Text = "Capacidad:   \r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(33, 101);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 1;
            label2.Text = "Disponibles:";
            // 
            // libre
            // 
            libre.AutoSize = true;
            libre.BackColor = Color.AliceBlue;
            libre.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            libre.ForeColor = Color.Black;
            libre.Location = new Point(156, 101);
            libre.Name = "libre";
            libre.Size = new Size(25, 41);
            libre.TabIndex = 2;
            libre.Text = ":)";
            libre.Click += libre_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(33, 142);
            label4.Name = "label4";
            label4.Size = new Size(128, 23);
            label4.TabIndex = 3;
            label4.Text = "Reservados:";
            // 
            // ocupado
            // 
            ocupado.AutoSize = true;
            ocupado.BackColor = Color.AliceBlue;
            ocupado.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ocupado.ForeColor = Color.Black;
            ocupado.Location = new Point(156, 141);
            ocupado.Name = "ocupado";
            ocupado.Size = new Size(25, 41);
            ocupado.TabIndex = 4;
            ocupado.Text = ":)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(716, 59);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 5;
            label3.Text = "Precios:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(156, 59);
            label5.Name = "label5";
            label5.Size = new Size(32, 41);
            label5.TabIndex = 6;
            label5.Text = "72";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AliceBlue;
            label6.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(716, 100);
            label6.Name = "label6";
            label6.Size = new Size(61, 41);
            label6.TabIndex = 7;
            label6.Text = "Vip: 600";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AliceBlue;
            label7.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(716, 142);
            label7.Name = "label7";
            label7.Size = new Size(86, 41);
            label7.TabIndex = 8;
            label7.Text = "Tribuna: 500";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AliceBlue;
            label8.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(716, 183);
            label8.Name = "label8";
            label8.Size = new Size(89, 41);
            label8.TabIndex = 9;
            label8.Text = "General: 400";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._124671;
            pictureBox5.Location = new Point(-5, -5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(863, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // Disponibilidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(851, 577);
            Controls.Add(pictureBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox5;
    }
}