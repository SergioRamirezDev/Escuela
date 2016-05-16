namespace Figuras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rellenarnum = new System.Windows.Forms.NumericUpDown();
            this.contornonum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dibujar = new System.Windows.Forms.RadioButton();
            this.recta = new System.Windows.Forms.RadioButton();
            this.rectangulo = new System.Windows.Forms.RadioButton();
            this.circulo = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rellenarnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contornonum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rellenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Rellenar);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Contorno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Contorno);
            // 
            // rellenarnum
            // 
            this.rellenarnum.Location = new System.Drawing.Point(93, 41);
            this.rellenarnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rellenarnum.Name = "rellenarnum";
            this.rellenarnum.Size = new System.Drawing.Size(64, 20);
            this.rellenarnum.TabIndex = 1;
            this.rellenarnum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // contornonum
            // 
            this.contornonum.Location = new System.Drawing.Point(93, 15);
            this.contornonum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.contornonum.Name = "contornonum";
            this.contornonum.Size = new System.Drawing.Size(64, 20);
            this.contornonum.TabIndex = 0;
            this.contornonum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.dibujar);
            this.groupBox1.Controls.Add(this.recta);
            this.groupBox1.Controls.Add(this.rectangulo);
            this.groupBox1.Controls.Add(this.circulo);
            this.groupBox1.Location = new System.Drawing.Point(9, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figuras";
            // 
            // dibujar
            // 
            this.dibujar.AutoSize = true;
            this.dibujar.Checked = true;
            this.dibujar.Location = new System.Drawing.Point(20, 25);
            this.dibujar.Name = "dibujar";
            this.dibujar.Size = new System.Drawing.Size(58, 17);
            this.dibujar.TabIndex = 3;
            this.dibujar.TabStop = true;
            this.dibujar.Text = "Dibujar";
            this.dibujar.UseVisualStyleBackColor = true;
            this.dibujar.CheckedChanged += new System.EventHandler(this.check);
            this.dibujar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorear);
            // 
            // recta
            // 
            this.recta.AutoSize = true;
            this.recta.Location = new System.Drawing.Point(19, 71);
            this.recta.Name = "recta";
            this.recta.Size = new System.Drawing.Size(54, 17);
            this.recta.TabIndex = 2;
            this.recta.Text = "Recta";
            this.recta.UseVisualStyleBackColor = true;
            // 
            // rectangulo
            // 
            this.rectangulo.AutoSize = true;
            this.rectangulo.Location = new System.Drawing.Point(19, 48);
            this.rectangulo.Name = "rectangulo";
            this.rectangulo.Size = new System.Drawing.Size(80, 17);
            this.rectangulo.TabIndex = 1;
            this.rectangulo.Text = "Rectangulo";
            this.rectangulo.UseVisualStyleBackColor = true;
            // 
            // circulo
            // 
            this.circulo.AutoSize = true;
            this.circulo.Location = new System.Drawing.Point(19, 94);
            this.circulo.Name = "circulo";
            this.circulo.Size = new System.Drawing.Size(57, 17);
            this.circulo.TabIndex = 0;
            this.circulo.Text = "Circulo";
            this.circulo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 395);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(781, 394);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contornonum);
            this.Controls.Add(this.rellenarnum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Figuras";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorear);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorear);
            ((System.ComponentModel.ISupportInitialize)(this.rellenarnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contornonum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown rellenarnum;
        private System.Windows.Forms.NumericUpDown contornonum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rectangulo;
        private System.Windows.Forms.RadioButton circulo;
        private System.Windows.Forms.RadioButton recta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton dibujar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
    }
}

