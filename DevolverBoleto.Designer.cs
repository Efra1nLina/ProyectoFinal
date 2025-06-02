namespace ProyectoFinal
{
    partial class DevolverBoleto
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
            zonaEl = new ComboBox();
            label2 = new Label();
            numTickets = new TextBox();
            label3 = new Label();
            nombreCliente = new TextBox();
            botonCancelar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 52);
            label1.Name = "label1";
            label1.Size = new Size(52, 44);
            label1.TabIndex = 0;
            label1.Text = "Zona:";
            // 
            // zonaEl
            // 
            zonaEl.FormattingEnabled = true;
            zonaEl.Items.AddRange(new object[] { "General", "Tribuna", "Vip" });
            zonaEl.Location = new Point(32, 85);
            zonaEl.Name = "zonaEl";
            zonaEl.Size = new Size(169, 23);
            zonaEl.TabIndex = 1;
            zonaEl.SelectedIndexChanged += zonaEl_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 144);
            label2.Name = "label2";
            label2.Size = new Size(73, 44);
            label2.TabIndex = 2;
            label2.Text = "Asientos:";
            // 
            // numTickets
            // 
            numTickets.Location = new Point(32, 177);
            numTickets.Name = "numTickets";
            numTickets.Size = new Size(123, 23);
            numTickets.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 235);
            label3.Name = "label3";
            label3.Size = new Size(67, 41);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // nombreCliente
            // 
            nombreCliente.Location = new Point(32, 264);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Size = new Size(123, 23);
            nombreCliente.TabIndex = 5;
            // 
            // botonCancelar
            // 
            botonCancelar.Image = Properties.Resources.cancelacion;
            botonCancelar.Location = new Point(267, 213);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(107, 74);
            botonCancelar.TabIndex = 6;
            botonCancelar.Text = "Devolver";
            botonCancelar.TextAlign = ContentAlignment.BottomCenter;
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.notas_musicales;
            label4.Location = new Point(267, 52);
            label4.Name = "label4";
            label4.Size = new Size(126, 118);
            label4.TabIndex = 7;
            // 
            // DevolverBoleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(441, 340);
            Controls.Add(label4);
            Controls.Add(botonCancelar);
            Controls.Add(nombreCliente);
            Controls.Add(label3);
            Controls.Add(numTickets);
            Controls.Add(label2);
            Controls.Add(zonaEl);
            Controls.Add(label1);
            Name = "DevolverBoleto";
            Text = "DevolverBoleto";
            Load += DevolverBoleto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox zonaEl;
        private Label label2;
        private TextBox numTickets;
        private Label label3;
        private TextBox nombreCliente;
        private Button botonCancelar;
        private Label label4;
    }
}