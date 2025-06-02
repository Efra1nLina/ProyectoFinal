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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            botonDisponibilidad = new Button();
            botonComprar = new Button();
            botonCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // botonDisponibilidad
            // 
            botonDisponibilidad.Image = (Image)resources.GetObject("botonDisponibilidad.Image");
            botonDisponibilidad.Location = new Point(71, 358);
            botonDisponibilidad.Name = "botonDisponibilidad";
            botonDisponibilidad.Size = new Size(122, 47);
            botonDisponibilidad.TabIndex = 0;
            botonDisponibilidad.UseVisualStyleBackColor = true;
            botonDisponibilidad.Click += botonDisponibilidad_Click;
            // 
            // botonComprar
            // 
            botonComprar.Image = (Image)resources.GetObject("botonComprar.Image");
            botonComprar.Location = new Point(323, 358);
            botonComprar.Name = "botonComprar";
            botonComprar.Size = new Size(131, 47);
            botonComprar.TabIndex = 1;
            botonComprar.UseVisualStyleBackColor = true;
            botonComprar.Click += botonComprar_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Image = Properties.Resources.cancelar__1_;
            botonCancelar.Location = new Point(557, 358);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(112, 47);
            botonCancelar.TabIndex = 2;
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 314);
            label1.Name = "label1";
            label1.Size = new Size(72, 44);
            label1.TabIndex = 3;
            label1.Text = "Comprar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(558, 311);
            label2.Name = "label2";
            label2.Size = new Size(111, 44);
            label2.TabIndex = 4;
            label2.Text = "Cancelar Boleto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 314);
            label3.Name = "label3";
            label3.Size = new Size(104, 44);
            label3.TabIndex = 5;
            label3.Text = "Disponibilidad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonCancelar);
            Controls.Add(botonComprar);
            Controls.Add(botonDisponibilidad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonDisponibilidad;
        private Button botonComprar;
        private Button botonCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}