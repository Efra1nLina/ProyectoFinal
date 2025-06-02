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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprar));
            label1 = new Label();
            zonaElejida = new ComboBox();
            label2 = new Label();
            nombreCliente = new TextBox();
            label3 = new Label();
            asiento = new TextBox();
            aceptarComprar = new Button();
            cantBoletos = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(88, 44);
            label1.TabIndex = 0;
            label1.Text = "Elija la zona:";
            // 
            // zonaElejida
            // 
            zonaElejida.ForeColor = Color.DarkCyan;
            zonaElejida.FormattingEnabled = true;
            zonaElejida.Items.AddRange(new object[] { "General", "Tribuna", "VIP" });
            zonaElejida.Location = new Point(35, 55);
            zonaElejida.Name = "zonaElejida";
            zonaElejida.Size = new Size(121, 23);
            zonaElejida.TabIndex = 1;
            zonaElejida.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 118);
            label2.Name = "label2";
            label2.Size = new Size(148, 31);
            label2.TabIndex = 2;
            label2.Text = "Ingrese su nombre:";
            // 
            // nombreCliente
            // 
            nombreCliente.Location = new Point(35, 152);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Size = new Size(148, 23);
            nombreCliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 204);
            label3.Name = "label3";
            label3.Size = new Size(118, 33);
            label3.TabIndex = 4;
            label3.Text = "Elija su asiento:";
            // 
            // asiento
            // 
            asiento.Location = new Point(38, 240);
            asiento.Name = "asiento";
            asiento.Size = new Size(100, 23);
            asiento.TabIndex = 5;
            // 
            // aceptarComprar
            // 
            aceptarComprar.Image = Properties.Resources.verificar;
            aceptarComprar.Location = new Point(35, 278);
            aceptarComprar.Name = "aceptarComprar";
            aceptarComprar.Size = new Size(85, 64);
            aceptarComprar.TabIndex = 6;
            aceptarComprar.Text = "Comprar";
            aceptarComprar.TextAlign = ContentAlignment.BottomCenter;
            aceptarComprar.UseVisualStyleBackColor = true;
            aceptarComprar.Click += aceptarComprar_Click;
            // 
            // cantBoletos
            // 
            cantBoletos.Location = new Point(250, 52);
            cantBoletos.Name = "cantBoletos";
            cantBoletos.Size = new Size(100, 23);
            cantBoletos.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(239, 20);
            label4.Name = "label4";
            label4.Size = new Size(144, 29);
            label4.TabIndex = 9;
            label4.Text = "Cantidad de boletos:";
            // 
            // label5
            // 
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(189, 104);
            label5.Name = "label5";
            label5.Size = new Size(266, 200);
            label5.TabIndex = 10;
            // 
            // Comprar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(414, 362);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cantBoletos);
            Controls.Add(aceptarComprar);
            Controls.Add(asiento);
            Controls.Add(label3);
            Controls.Add(nombreCliente);
            Controls.Add(label2);
            Controls.Add(zonaElejida);
            Controls.Add(label1);
            Name = "Comprar";
            Text = "Comprar";
            Load += Comprar_Load;
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
        private Button aceptarComprar;
        private ComboBox zonaElejida;
        private TextBox nombreCliente;
        private TextBox asiento;
        private TextBox textBox3;
        private Label label4;
        private TextBox cantBoletos;
        private Label label5;
    }
}