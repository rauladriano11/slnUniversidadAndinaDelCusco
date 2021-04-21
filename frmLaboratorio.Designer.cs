
namespace CapaPresentacion
{
    partial class frmLaboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratorio));
            this.txtCantidadAlumnos = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnPracticar = new System.Windows.Forms.Button();
            this.bntModelar = new System.Windows.Forms.Button();
            this.btnExperimentar = new System.Windows.Forms.Button();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCantidadAlumnos
            // 
            this.txtCantidadAlumnos.Location = new System.Drawing.Point(168, 175);
            this.txtCantidadAlumnos.Name = "txtCantidadAlumnos";
            this.txtCantidadAlumnos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAlumnos.TabIndex = 0;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(168, 135);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(100, 20);
            this.txtAula.TabIndex = 1;
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(168, 95);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(100, 20);
            this.txtJefe.TabIndex = 2;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(168, 55);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(340, 76);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(340, 116);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnPracticar
            // 
            this.btnPracticar.Location = new System.Drawing.Point(44, 259);
            this.btnPracticar.Name = "btnPracticar";
            this.btnPracticar.Size = new System.Drawing.Size(75, 23);
            this.btnPracticar.TabIndex = 6;
            this.btnPracticar.Text = "Practicar";
            this.btnPracticar.UseVisualStyleBackColor = true;
            this.btnPracticar.Click += new System.EventHandler(this.btnPracticar_Click);
            // 
            // bntModelar
            // 
            this.bntModelar.Location = new System.Drawing.Point(150, 259);
            this.bntModelar.Name = "bntModelar";
            this.bntModelar.Size = new System.Drawing.Size(75, 23);
            this.bntModelar.TabIndex = 7;
            this.bntModelar.Text = "Modelar";
            this.bntModelar.UseVisualStyleBackColor = true;
            this.bntModelar.Click += new System.EventHandler(this.bntModelar_Click);
            // 
            // btnExperimentar
            // 
            this.btnExperimentar.Location = new System.Drawing.Point(259, 259);
            this.btnExperimentar.Name = "btnExperimentar";
            this.btnExperimentar.Size = new System.Drawing.Size(83, 23);
            this.btnExperimentar.TabIndex = 8;
            this.btnExperimentar.Text = "Experimentar";
            this.btnExperimentar.UseVisualStyleBackColor = true;
            this.btnExperimentar.Click += new System.EventHandler(this.btnExperimentar_Click);
            // 
            // btnProgramar
            // 
            this.btnProgramar.Location = new System.Drawing.Point(366, 259);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(75, 23);
            this.btnProgramar.TabIndex = 9;
            this.btnProgramar.Text = "Programar";
            this.btnProgramar.UseVisualStyleBackColor = true;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Curso :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jefe :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aula :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad de Alumnos :";
            // 
            // frmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProgramar);
            this.Controls.Add(this.btnExperimentar);
            this.Controls.Add(this.bntModelar);
            this.Controls.Add(this.btnPracticar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtJefe);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.txtCantidadAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLaboratorio";
            this.Text = "Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadAlumnos;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnPracticar;
        private System.Windows.Forms.Button bntModelar;
        private System.Windows.Forms.Button btnExperimentar;
        private System.Windows.Forms.Button btnProgramar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}