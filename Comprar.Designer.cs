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
            aceptarComprar = new Button();
            comprarDeNuevo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 33);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Elija la zona:";
            // 
            // zonaElejida
            // 
            zonaElejida.FormattingEnabled = true;
            zonaElejida.Items.AddRange(new object[] { "General", "Tribuna", "Vip" });
            zonaElejida.Location = new Point(38, 70);
            zonaElejida.Name = "zonaElejida";
            zonaElejida.Size = new Size(121, 23);
            zonaElejida.TabIndex = 1;
            zonaElejida.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 118);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese su nombre:";
            // 
            // nombreCliente
            // 
            nombreCliente.Location = new Point(38, 152);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Size = new Size(148, 23);
            nombreCliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 204);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
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
            aceptarComprar.Location = new Point(38, 284);
            aceptarComprar.Name = "aceptarComprar";
            aceptarComprar.Size = new Size(75, 23);
            aceptarComprar.TabIndex = 6;
            aceptarComprar.Text = "Comprar";
            aceptarComprar.UseVisualStyleBackColor = true;
            aceptarComprar.Click += aceptarComprar_Click;
            // 
            // comprarDeNuevo
            // 
            comprarDeNuevo.Location = new Point(38, 343);
            comprarDeNuevo.Name = "comprarDeNuevo";
            comprarDeNuevo.Size = new Size(131, 35);
            comprarDeNuevo.TabIndex = 7;
            comprarDeNuevo.Text = "Realizar otra compra";
            comprarDeNuevo.UseVisualStyleBackColor = true;
            // 
            // Comprar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 418);
            Controls.Add(comprarDeNuevo);
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
        private Button comprarDeNuevo;
        private ComboBox zonaElejida;
        private TextBox nombreCliente;
        private TextBox asiento;
    }
}