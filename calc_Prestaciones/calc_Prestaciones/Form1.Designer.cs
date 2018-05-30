namespace calc_Prestaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbpreaviso = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbvacaciones = new System.Windows.Forms.CheckBox();
            this.cbcesantia = new System.Windows.Forms.CheckBox();
            this.cbsalarionavidad = new System.Windows.Forms.CheckBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmesestrabajados = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtcedula = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 16;
            this.lista.Location = new System.Drawing.Point(12, 83);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(157, 212);
            this.lista.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(205, 140);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(100, 22);
            this.txtsueldo.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbpreaviso
            // 
            this.cbpreaviso.AutoSize = true;
            this.cbpreaviso.Location = new System.Drawing.Point(375, 125);
            this.cbpreaviso.Name = "cbpreaviso";
            this.cbpreaviso.Size = new System.Drawing.Size(91, 21);
            this.cbpreaviso.TabIndex = 6;
            this.cbpreaviso.Text = "Pre-Aviso";
            this.cbpreaviso.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbvacaciones
            // 
            this.cbvacaciones.AutoSize = true;
            this.cbvacaciones.Location = new System.Drawing.Point(514, 125);
            this.cbvacaciones.Name = "cbvacaciones";
            this.cbvacaciones.Size = new System.Drawing.Size(103, 21);
            this.cbvacaciones.TabIndex = 8;
            this.cbvacaciones.Text = "Vacaciones";
            this.cbvacaciones.UseVisualStyleBackColor = true;
            // 
            // cbcesantia
            // 
            this.cbcesantia.AutoSize = true;
            this.cbcesantia.Location = new System.Drawing.Point(375, 174);
            this.cbcesantia.Name = "cbcesantia";
            this.cbcesantia.Size = new System.Drawing.Size(85, 21);
            this.cbcesantia.TabIndex = 9;
            this.cbcesantia.Text = "Cesantia";
            this.cbcesantia.UseVisualStyleBackColor = true;
            // 
            // cbsalarionavidad
            // 
            this.cbsalarionavidad.AutoSize = true;
            this.cbsalarionavidad.Location = new System.Drawing.Point(514, 174);
            this.cbsalarionavidad.Name = "cbsalarionavidad";
            this.cbsalarionavidad.Size = new System.Drawing.Size(150, 21);
            this.cbsalarionavidad.TabIndex = 10;
            this.cbsalarionavidad.Text = "Salario de Navidad";
            this.cbsalarionavidad.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 53);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(135, 22);
            this.txtnombre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cedula Identidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ultimos 12 Sueldos";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(205, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 42);
            this.button4.TabIndex = 16;
            this.button4.Text = "Completar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Meses Trabajados";
            // 
            // txtmesestrabajados
            // 
            this.txtmesestrabajados.Location = new System.Drawing.Point(473, 53);
            this.txtmesestrabajados.Name = "txtmesestrabajados";
            this.txtmesestrabajados.Size = new System.Drawing.Size(135, 22);
            this.txtmesestrabajados.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(473, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 42);
            this.button5.TabIndex = 19;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(232, 53);
            this.txtcedula.Mask = "000-0000000-0";
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(135, 22);
            this.txtcedula.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 334);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtmesestrabajados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cbsalarionavidad);
            this.Controls.Add(this.cbcesantia);
            this.Controls.Add(this.cbvacaciones);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbpreaviso);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calc_Prestaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbpreaviso;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbvacaciones;
        private System.Windows.Forms.CheckBox cbcesantia;
        private System.Windows.Forms.CheckBox cbsalarionavidad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmesestrabajados;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox txtcedula;
    }
}

