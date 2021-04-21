
namespace CapaPresentacion
{
    partial class frmRector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRector));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnDirigir = new System.Windows.Forms.Button();
            this.btnOrganizar = new System.Windows.Forms.Button();
            this.btnPromover = new System.Windows.Forms.Button();
            this.btnContratar = new System.Windows.Forms.Button();
            this.txtGradoEstudios = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellidos : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grado de Estudios : ";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(354, 80);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(354, 126);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnDirigir
            // 
            this.btnDirigir.Location = new System.Drawing.Point(46, 266);
            this.btnDirigir.Name = "btnDirigir";
            this.btnDirigir.Size = new System.Drawing.Size(75, 23);
            this.btnDirigir.TabIndex = 6;
            this.btnDirigir.Text = "Dirigir";
            this.btnDirigir.UseVisualStyleBackColor = true;
            this.btnDirigir.Click += new System.EventHandler(this.btnDirigir_Click);
            // 
            // btnOrganizar
            // 
            this.btnOrganizar.Location = new System.Drawing.Point(179, 266);
            this.btnOrganizar.Name = "btnOrganizar";
            this.btnOrganizar.Size = new System.Drawing.Size(75, 23);
            this.btnOrganizar.TabIndex = 7;
            this.btnOrganizar.Text = "Organizar";
            this.btnOrganizar.UseVisualStyleBackColor = true;
            this.btnOrganizar.Click += new System.EventHandler(this.btnOrganizar_Click);
            // 
            // btnPromover
            // 
            this.btnPromover.Location = new System.Drawing.Point(300, 266);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(75, 23);
            this.btnPromover.TabIndex = 8;
            this.btnPromover.Text = "Promover";
            this.btnPromover.UseVisualStyleBackColor = true;
            this.btnPromover.Click += new System.EventHandler(this.btnPromover_Click);
            // 
            // btnContratar
            // 
            this.btnContratar.Location = new System.Drawing.Point(418, 266);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(75, 23);
            this.btnContratar.TabIndex = 9;
            this.btnContratar.Text = "Contratar";
            this.btnContratar.UseVisualStyleBackColor = true;
            this.btnContratar.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtGradoEstudios
            // 
            this.txtGradoEstudios.Location = new System.Drawing.Point(197, 190);
            this.txtGradoEstudios.Name = "txtGradoEstudios";
            this.txtGradoEstudios.Size = new System.Drawing.Size(100, 20);
            this.txtGradoEstudios.TabIndex = 10;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(197, 148);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 11;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(197, 108);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 12;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(197, 67);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 13;
            this.txtApellidos.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // frmRector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 408);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtGradoEstudios);
            this.Controls.Add(this.btnContratar);
            this.Controls.Add(this.btnPromover);
            this.Controls.Add(this.btnOrganizar);
            this.Controls.Add(this.btnDirigir);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRector";
            this.Text = "Rector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnDirigir;
        private System.Windows.Forms.Button btnOrganizar;
        private System.Windows.Forms.Button btnPromover;
        private System.Windows.Forms.Button btnContratar;
        private System.Windows.Forms.TextBox txtGradoEstudios;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
    }
}