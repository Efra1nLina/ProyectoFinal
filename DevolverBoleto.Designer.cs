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
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(41, 89);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 0;
            label1.Text = "Zona:";
            // 
            // zonaEl
            // 
            zonaEl.FormattingEnabled = true;
            zonaEl.Items.AddRange(new object[] { "General", "Tribuna", "Vip" });
            zonaEl.Location = new Point(41, 115);
            zonaEl.Name = "zonaEl";
            zonaEl.Size = new Size(169, 23);
            zonaEl.TabIndex = 1;
            zonaEl.SelectedIndexChanged += zonaEl_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(41, 184);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 2;
            label2.Text = "Asientos:";
            // 
            // numTickets
            // 
            numTickets.Location = new Point(41, 210);
            numTickets.Name = "numTickets";
            numTickets.Size = new Size(123, 23);
            numTickets.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(41, 284);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // nombreCliente
            // 
            nombreCliente.Location = new Point(41, 310);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Size = new Size(123, 23);
            nombreCliente.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._124671;
            pictureBox5.Location = new Point(-16, -3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(475, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bote_de_basura;
            pictureBox1.Location = new Point(294, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(294, 271);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 18;
            label4.Text = "Devolver\r\n";
            // 
            // DevolverBoleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(441, 392);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(nombreCliente);
            Controls.Add(label3);
            Controls.Add(numTickets);
            Controls.Add(label2);
            Controls.Add(zonaEl);
            Controls.Add(label1);
            Name = "DevolverBoleto";
            Text = "DevolverBoleto";
            Load += DevolverBoleto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private Label label4;
    }
}