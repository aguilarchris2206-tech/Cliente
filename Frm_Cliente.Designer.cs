namespace Cliente
{
    partial class Frm_Cliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Txt_Mensaje = new TextBox();
            Bnt_Enviar = new Button();
            Btn_Conectar = new Button();
            Btn_Desconectar = new Button();
            Txt_Servidor = new TextBox();
            lblText2 = new Label();
            lblText1 = new Label();
            lblEstado = new Label();
            lblText3 = new Label();
            txtRuta = new TextBox();
            lblText4 = new Label();
            txtBoxFila1 = new TextBox();
            txtBoxFila2 = new TextBox();
            lblText5 = new Label();
            txtBoxMonto = new TextBox();
            Banner = new PictureBox();
            lblTexto6 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)Banner).BeginInit();
            SuspendLayout();
            // 
            // Txt_Mensaje
            // 
            Txt_Mensaje.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Mensaje.Location = new Point(24, 217);
            Txt_Mensaje.Margin = new Padding(3, 2, 3, 2);
            Txt_Mensaje.Multiline = true;
            Txt_Mensaje.Name = "Txt_Mensaje";
            Txt_Mensaje.Size = new Size(754, 44);
            Txt_Mensaje.TabIndex = 4;
            // 
            // Bnt_Enviar
            // 
            Bnt_Enviar.Enabled = false;
            Bnt_Enviar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Bnt_Enviar.Location = new Point(934, 531);
            Bnt_Enviar.Margin = new Padding(3, 2, 3, 2);
            Bnt_Enviar.Name = "Bnt_Enviar";
            Bnt_Enviar.Size = new Size(110, 37);
            Bnt_Enviar.TabIndex = 5;
            Bnt_Enviar.Text = "&Enviar";
            Bnt_Enviar.UseVisualStyleBackColor = true;
            Bnt_Enviar.Click += Bnt_Enviar_Click;
            // 
            // Btn_Conectar
            // 
            Btn_Conectar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Conectar.Location = new Point(543, 143);
            Btn_Conectar.Margin = new Padding(3, 2, 3, 2);
            Btn_Conectar.Name = "Btn_Conectar";
            Btn_Conectar.Size = new Size(108, 37);
            Btn_Conectar.TabIndex = 2;
            Btn_Conectar.Text = "&Conectar";
            Btn_Conectar.UseVisualStyleBackColor = true;
            Btn_Conectar.Click += Btn_Conectar_Click;
            // 
            // Btn_Desconectar
            // 
            Btn_Desconectar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Desconectar.Location = new Point(671, 143);
            Btn_Desconectar.Margin = new Padding(3, 2, 3, 2);
            Btn_Desconectar.Name = "Btn_Desconectar";
            Btn_Desconectar.Size = new Size(132, 37);
            Btn_Desconectar.TabIndex = 3;
            Btn_Desconectar.Text = "&Desconectar";
            Btn_Desconectar.UseVisualStyleBackColor = true;
            Btn_Desconectar.Click += Btn_Desconectar_Click;
            // 
            // Txt_Servidor
            // 
            Txt_Servidor.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Servidor.Location = new Point(24, 143);
            Txt_Servidor.Name = "Txt_Servidor";
            Txt_Servidor.Size = new Size(502, 39);
            Txt_Servidor.TabIndex = 1;
            // 
            // lblText2
            // 
            lblText2.AutoSize = true;
            lblText2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblText2.Location = new Point(24, 185);
            lblText2.Name = "lblText2";
            lblText2.Size = new Size(85, 30);
            lblText2.TabIndex = 6;
            lblText2.Text = "Trama";
            // 
            // lblText1
            // 
            lblText1.AutoSize = true;
            lblText1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblText1.Location = new Point(24, 110);
            lblText1.Name = "lblText1";
            lblText1.Size = new Size(132, 30);
            lblText1.TabIndex = 7;
            lblText1.Text = "Dirrección";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(24, 518);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(65, 22);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "label1";
            // 
            // lblText3
            // 
            lblText3.AutoSize = true;
            lblText3.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblText3.Location = new Point(24, 276);
            lblText3.Name = "lblText3";
            lblText3.Size = new Size(61, 27);
            lblText3.TabIndex = 9;
            lblText3.Text = "Ruta";
            // 
            // txtRuta
            // 
            txtRuta.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtRuta.Location = new Point(105, 273);
            txtRuta.Name = "txtRuta";
            txtRuta.ReadOnly = true;
            txtRuta.Size = new Size(391, 34);
            txtRuta.TabIndex = 10;
            // 
            // lblText4
            // 
            lblText4.AutoSize = true;
            lblText4.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblText4.Location = new Point(24, 317);
            lblText4.Name = "lblText4";
            lblText4.Size = new Size(224, 27);
            lblText4.TabIndex = 11;
            lblText4.Text = "Asientos asignados:";
            // 
            // txtBoxFila1
            // 
            txtBoxFila1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFila1.Location = new Point(24, 347);
            txtBoxFila1.Name = "txtBoxFila1";
            txtBoxFila1.ReadOnly = true;
            txtBoxFila1.Size = new Size(449, 32);
            txtBoxFila1.TabIndex = 12;
            // 
            // txtBoxFila2
            // 
            txtBoxFila2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFila2.Location = new Point(24, 385);
            txtBoxFila2.Name = "txtBoxFila2";
            txtBoxFila2.ReadOnly = true;
            txtBoxFila2.Size = new Size(449, 32);
            txtBoxFila2.TabIndex = 13;
            // 
            // lblText5
            // 
            lblText5.AutoSize = true;
            lblText5.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblText5.Location = new Point(24, 430);
            lblText5.Name = "lblText5";
            lblText5.Size = new Size(171, 27);
            lblText5.TabIndex = 14;
            lblText5.Text = "Monto Cobrado";
            // 
            // txtBoxMonto
            // 
            txtBoxMonto.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxMonto.Location = new Point(24, 460);
            txtBoxMonto.Name = "txtBoxMonto";
            txtBoxMonto.ReadOnly = true;
            txtBoxMonto.Size = new Size(449, 32);
            txtBoxMonto.TabIndex = 15;
            // 
            // Banner
            // 
            Banner.BackColor = Color.Black;
            Banner.BorderStyle = BorderStyle.FixedSingle;
            Banner.Dock = DockStyle.Top;
            Banner.Location = new Point(0, 0);
            Banner.Name = "Banner";
            Banner.Size = new Size(1085, 90);
            Banner.TabIndex = 16;
            Banner.TabStop = false;
            // 
            // lblTexto6
            // 
            lblTexto6.AutoSize = true;
            lblTexto6.BackColor = Color.Black;
            lblTexto6.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTexto6.ForeColor = Color.White;
            lblTexto6.Location = new Point(442, 21);
            lblTexto6.Name = "lblTexto6";
            lblTexto6.Size = new Size(178, 44);
            lblTexto6.TabIndex = 17;
            lblTexto6.Text = "Boletería";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(818, 531);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 37);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Frm_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 591);
            Controls.Add(btnLimpiar);
            Controls.Add(lblTexto6);
            Controls.Add(Banner);
            Controls.Add(txtBoxMonto);
            Controls.Add(lblText5);
            Controls.Add(txtBoxFila2);
            Controls.Add(txtBoxFila1);
            Controls.Add(lblText4);
            Controls.Add(txtRuta);
            Controls.Add(lblText3);
            Controls.Add(lblEstado);
            Controls.Add(lblText1);
            Controls.Add(lblText2);
            Controls.Add(Txt_Servidor);
            Controls.Add(Btn_Desconectar);
            Controls.Add(Btn_Conectar);
            Controls.Add(Bnt_Enviar);
            Controls.Add(Txt_Mensaje);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Cliente";
            Text = "Peticiones de Cliente";
            ((System.ComponentModel.ISupportInitialize)Banner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Mensaje;
        private Button Bnt_Enviar;
        private Button Btn_Conectar;
        private Button Btn_Desconectar;
        private TextBox Txt_Servidor;
        private Label lblText2;
        private Label lblText1;
        private Label lblEstado;
        private Label lblText3;
        private TextBox txtRuta;
        private Label lblText4;
        private TextBox txtBoxFila1;
        private TextBox txtBoxFila2;
        private Label lblText5;
        private TextBox txtBoxMonto;
        private PictureBox Banner;
        private Label lblTexto6;
        private Button btnLimpiar;
    }
}