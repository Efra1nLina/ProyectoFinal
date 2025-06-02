namespace ProyectoFinal
{
    partial class Comprar
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
            zonaElejida = new ComboBox();
            label2 = new Label();
            nombreCliente = new TextBox();
            label3 = new Label();
            asiento = new TextBox();
            cantBoletos = new TextBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(109, 72);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 0;
            label1.Text = "Elija la zona:";
            // 
            // zonaElejida
            // 
            zonaElejida.ForeColor = Color.DarkCyan;
            zonaElejida.FormattingEnabled = true;
            zonaElejida.Items.AddRange(new object[] { "General", "Tribuna", "VIP" });
            zonaElejida.Location = new Point(109, 98);
            zonaElejida.Name = "zonaElejida";
            zonaElejida.Size = new Size(121, 23);
            zonaElejida.TabIndex = 1;
            zonaElejida.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(109, 155);
            label2.Name = "label2";
            label2.Size = new Size(201, 31);
            label2.TabIndex = 2;
            label2.Text = "Ingrese su nombre:";
            // 
            // nombreCliente
            // 
            nombreCliente.Location = new Point(109, 189);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Size = new Size(148, 23);
            nombreCliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(109, 249);
            label3.Name = "label3";
            label3.Size = new Size(170, 33);
            label3.TabIndex = 4;
            label3.Text = "Elija su asiento:";
            // 
            // asiento
            // 
            asiento.Location = new Point(109, 285);
            asiento.Name = "asiento";
            asiento.Size = new Size(100, 23);
            asiento.TabIndex = 5;
            // 
            // cantBoletos
            // 
            cantBoletos.Location = new Point(109, 374);
            cantBoletos.Name = "cantBoletos";
            cantBoletos.Size = new Size(100, 23);
            cantBoletos.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(109, 345);
            label4.Name = "label4";
            label4.Size = new Size(211, 29);
            label4.TabIndex = 9;
            label4.Text = "Cantidad de boletos:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._124671;
            pictureBox5.Location = new Point(-16, -2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(442, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pago_seguro;
            pictureBox1.Location = new Point(157, 434);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(157, 514);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 19;
            label5.Text = "Comprar";
            // 
            // Comprar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(414, 572);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(cantBoletos);
            Controls.Add(asiento);
            Controls.Add(label3);
            Controls.Add(nombreCliente);
            Controls.Add(label2);
            Controls.Add(zonaElejida);
            Controls.Add(label1);
            Name = "Comprar";
            Text = "Comprar";
            Load += Comprar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private ComboBox zonaElejida;
        private TextBox nombreCliente;
        private TextBox asiento;
        private TextBox textBox3;
        private Label label4;
        private TextBox cantBoletos;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private Label label5;
    }
}