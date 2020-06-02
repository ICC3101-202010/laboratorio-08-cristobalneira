namespace Proyecto8Neira
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
            this.Revisar = new System.Windows.Forms.Button();
            this.Mas = new System.Windows.Forms.Button();
            this.ListadeObjetos = new System.Windows.Forms.Button();
            this.labelAlto = new System.Windows.Forms.Label();
            this.controladorTiendas1 = new Proyecto8Neira.ControladorTiendas();
            this.controlador = new Proyecto8Neira.Controlador();
            this.SuspendLayout();
            // 
            // Revisar
            // 
            this.Revisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Revisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revisar.Location = new System.Drawing.Point(80, 126);
            this.Revisar.Name = "Revisar";
            this.Revisar.Size = new System.Drawing.Size(159, 137);
            this.Revisar.TabIndex = 0;
            this.Revisar.Text = "Revisar Locales";
            this.Revisar.UseVisualStyleBackColor = false;
            this.Revisar.Click += new System.EventHandler(this.Revisar_Click);
            // 
            // Mas
            // 
            this.Mas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Mas.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mas.Location = new System.Drawing.Point(262, 126);
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(166, 137);
            this.Mas.TabIndex = 1;
            this.Mas.Text = "+";
            this.Mas.UseVisualStyleBackColor = false;
            this.Mas.Click += new System.EventHandler(this.Mas_Click);
            // 
            // ListadeObjetos
            // 
            this.ListadeObjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ListadeObjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListadeObjetos.Location = new System.Drawing.Point(80, 269);
            this.ListadeObjetos.Name = "ListadeObjetos";
            this.ListadeObjetos.Size = new System.Drawing.Size(348, 71);
            this.ListadeObjetos.TabIndex = 2;
            this.ListadeObjetos.Text = "Lista de Locales";
            this.ListadeObjetos.UseVisualStyleBackColor = false;
            this.ListadeObjetos.Click += new System.EventHandler(this.ListadeObjetos_Click);
            // 
            // labelAlto
            // 
            this.labelAlto.AutoSize = true;
            this.labelAlto.BackColor = System.Drawing.Color.Transparent;
            this.labelAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlto.Location = new System.Drawing.Point(117, 55);
            this.labelAlto.Name = "labelAlto";
            this.labelAlto.Size = new System.Drawing.Size(275, 33);
            this.labelAlto.TabIndex = 4;
            this.labelAlto.Text = "Mall Alto La Dehesa";
            this.labelAlto.Click += new System.EventHandler(this.labelAlto_Click);
            // 
            // controladorTiendas1
            // 
            this.controladorTiendas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorTiendas1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controladorTiendas1.BackgroundImage")));
            this.controladorTiendas1.Location = new System.Drawing.Point(30, 12);
            this.controladorTiendas1.Name = "controladorTiendas1";
            this.controladorTiendas1.Size = new System.Drawing.Size(521, 405);
            this.controladorTiendas1.TabIndex = 6;
            this.controladorTiendas1.Load += new System.EventHandler(this.controladorTiendas1_Load);
            // 
            // controlador
            // 
            this.controlador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlador.BackgroundImage")));
            this.controlador.Location = new System.Drawing.Point(30, 12);
            this.controlador.Name = "controlador";
            this.controlador.Size = new System.Drawing.Size(544, 405);
            this.controlador.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto8Neira.Properties.Resources.foto1;
            this.ClientSize = new System.Drawing.Size(617, 429);
            this.Controls.Add(this.controladorTiendas1);
            this.Controls.Add(this.controlador);
            this.Controls.Add(this.labelAlto);
            this.Controls.Add(this.ListadeObjetos);
            this.Controls.Add(this.Mas);
            this.Controls.Add(this.Revisar);
            this.Name = "Form1";
            this.Text = "Centro Comercial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Revisar;
        private System.Windows.Forms.Button Mas;
        private System.Windows.Forms.Button ListadeObjetos;
        private System.Windows.Forms.Label labelAlto;
        private Controlador controlador;
        private ControladorTiendas controladorTiendas1;
    }
}

