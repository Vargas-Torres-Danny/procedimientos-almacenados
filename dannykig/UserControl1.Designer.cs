namespace dannykig
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTAlumno = new System.Windows.Forms.Button();
            this.btnTDocente = new System.Windows.Forms.Button();
            this.btnTAsignatura = new System.Windows.Forms.Button();
            this.btnTCarrera = new System.Windows.Forms.Button();
            this.dgvTAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTAlumno
            // 
            this.btnTAlumno.Location = new System.Drawing.Point(13, 64);
            this.btnTAlumno.Name = "btnTAlumno";
            this.btnTAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnTAlumno.TabIndex = 0;
            this.btnTAlumno.Text = "TAlumno";
            this.btnTAlumno.UseVisualStyleBackColor = true;
            this.btnTAlumno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTDocente
            // 
            this.btnTDocente.Location = new System.Drawing.Point(230, 64);
            this.btnTDocente.Name = "btnTDocente";
            this.btnTDocente.Size = new System.Drawing.Size(75, 23);
            this.btnTDocente.TabIndex = 1;
            this.btnTDocente.Text = "TDocente";
            this.btnTDocente.UseVisualStyleBackColor = true;
            this.btnTDocente.Click += new System.EventHandler(this.btnTDocente_Click);
            // 
            // btnTAsignatura
            // 
            this.btnTAsignatura.Location = new System.Drawing.Point(474, 64);
            this.btnTAsignatura.Name = "btnTAsignatura";
            this.btnTAsignatura.Size = new System.Drawing.Size(75, 23);
            this.btnTAsignatura.TabIndex = 2;
            this.btnTAsignatura.Text = "TAsignatura";
            this.btnTAsignatura.UseVisualStyleBackColor = true;
            this.btnTAsignatura.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTCarrera
            // 
            this.btnTCarrera.Location = new System.Drawing.Point(677, 64);
            this.btnTCarrera.Name = "btnTCarrera";
            this.btnTCarrera.Size = new System.Drawing.Size(75, 23);
            this.btnTCarrera.TabIndex = 3;
            this.btnTCarrera.Text = "TCarrera";
            this.btnTCarrera.UseVisualStyleBackColor = true;
            this.btnTCarrera.Click += new System.EventHandler(this.btnTCarrera_Click);
            // 
            // dgvTAlumnos
            // 
            this.dgvTAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTAlumnos.Location = new System.Drawing.Point(13, 140);
            this.dgvTAlumnos.Name = "dgvTAlumnos";
            this.dgvTAlumnos.Size = new System.Drawing.Size(739, 290);
            this.dgvTAlumnos.TabIndex = 4;
            this.dgvTAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTAlumnos);
            this.Controls.Add(this.btnTCarrera);
            this.Controls.Add(this.btnTAsignatura);
            this.Controls.Add(this.btnTDocente);
            this.Controls.Add(this.btnTAlumno);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTAlumno;
        private System.Windows.Forms.Button btnTDocente;
        private System.Windows.Forms.Button btnTAsignatura;
        private System.Windows.Forms.Button btnTCarrera;
        private System.Windows.Forms.DataGridView dgvTAlumnos;
    }
}
