
namespace CapaPresentacion
{
    partial class frmAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignatura));
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnElaborarDocumentos = new System.Windows.Forms.Button();
            this.btnDebatir = new System.Windows.Forms.Button();
            this.btnDiseñar = new System.Windows.Forms.Button();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(331, 73);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(331, 124);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(411, 281);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 2;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnElaborarDocumentos
            // 
            this.btnElaborarDocumentos.Location = new System.Drawing.Point(255, 281);
            this.btnElaborarDocumentos.Name = "btnElaborarDocumentos";
            this.btnElaborarDocumentos.Size = new System.Drawing.Size(126, 23);
            this.btnElaborarDocumentos.TabIndex = 3;
            this.btnElaborarDocumentos.Text = "Elaborar Documentos";
            this.btnElaborarDocumentos.UseVisualStyleBackColor = true;
            this.btnElaborarDocumentos.Click += new System.EventHandler(this.btnElaborarDocumentos_Click);
            // 
            // btnDebatir
            // 
            this.btnDebatir.Location = new System.Drawing.Point(154, 281);
            this.btnDebatir.Name = "btnDebatir";
            this.btnDebatir.Size = new System.Drawing.Size(75, 23);
            this.btnDebatir.TabIndex = 4;
            this.btnDebatir.Text = "Debatir";
            this.btnDebatir.UseVisualStyleBackColor = true;
            this.btnDebatir.Click += new System.EventHandler(this.btnDebatir_Click);
            // 
            // btnDiseñar
            // 
            this.btnDiseñar.Location = new System.Drawing.Point(45, 281);
            this.btnDiseñar.Name = "btnDiseñar";
            this.btnDiseñar.Size = new System.Drawing.Size(75, 23);
            this.btnDiseñar.TabIndex = 5;
            this.btnDiseñar.Text = "Diseñar";
            this.btnDiseñar.UseVisualStyleBackColor = true;
            this.btnDiseñar.Click += new System.EventHandler(this.btnDiseñar_Click);
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(154, 163);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(100, 20);
            this.txtAula.TabIndex = 6;
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(154, 127);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(100, 20);
            this.txtCreditos.TabIndex = 7;
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(154, 91);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(100, 20);
            this.txtCiclo.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ciclo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Creditos :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Aula :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.btnDiseñar);
            this.Controls.Add(this.btnDebatir);
            this.Controls.Add(this.btnElaborarDocumentos);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsignatura";
            this.Text = "Asignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnElaborarDocumentos;
        private System.Windows.Forms.Button btnDebatir;
        private System.Windows.Forms.Button btnDiseñar;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}