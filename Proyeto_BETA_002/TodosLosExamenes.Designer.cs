namespace Proyeto_BETA_002
{
    partial class TodosLosExamenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosLosExamenes));
            this.dgvExamenes = new System.Windows.Forms.DataGridView();
            this.ID_EXAMEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CREADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROFESOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ULTIMA_FECHA_MODIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_DE_PREGUNTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAbrirEnPdf = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExamenes
            // 
            this.dgvExamenes.AllowUserToAddRows = false;
            this.dgvExamenes.AllowUserToDeleteRows = false;
            this.dgvExamenes.AllowUserToResizeColumns = false;
            this.dgvExamenes.AllowUserToResizeRows = false;
            this.dgvExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_EXAMEN,
            this.NOMBRE,
            this.ID_CREADOR,
            this.CURSO,
            this.PROFESOR,
            this.GRUPO,
            this.FECHA_CREACION,
            this.ULTIMA_FECHA_MODIFICACION,
            this.NUMERO_DE_PREGUNTAS});
            this.dgvExamenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvExamenes.GridColor = System.Drawing.Color.Turquoise;
            this.dgvExamenes.Location = new System.Drawing.Point(12, 223);
            this.dgvExamenes.Name = "dgvExamenes";
            this.dgvExamenes.ReadOnly = true;
            this.dgvExamenes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExamenes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamenes.Size = new System.Drawing.Size(953, 170);
            this.dgvExamenes.TabIndex = 15;
            // 
            // ID_EXAMEN
            // 
            this.ID_EXAMEN.HeaderText = "ID_EXAMEN";
            this.ID_EXAMEN.Name = "ID_EXAMEN";
            this.ID_EXAMEN.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // ID_CREADOR
            // 
            this.ID_CREADOR.HeaderText = "ID_CREADOR";
            this.ID_CREADOR.Name = "ID_CREADOR";
            this.ID_CREADOR.ReadOnly = true;
            // 
            // CURSO
            // 
            this.CURSO.HeaderText = "CURSO";
            this.CURSO.Name = "CURSO";
            this.CURSO.ReadOnly = true;
            // 
            // PROFESOR
            // 
            this.PROFESOR.HeaderText = "PROFESOR";
            this.PROFESOR.Name = "PROFESOR";
            this.PROFESOR.ReadOnly = true;
            // 
            // GRUPO
            // 
            this.GRUPO.HeaderText = "GRUPO";
            this.GRUPO.Name = "GRUPO";
            this.GRUPO.ReadOnly = true;
            // 
            // FECHA_CREACION
            // 
            this.FECHA_CREACION.HeaderText = "FECHA_CREACION";
            this.FECHA_CREACION.Name = "FECHA_CREACION";
            this.FECHA_CREACION.ReadOnly = true;
            // 
            // ULTIMA_FECHA_MODIFICACION
            // 
            this.ULTIMA_FECHA_MODIFICACION.HeaderText = "ULTIMA_FECHA_MODIFICACION";
            this.ULTIMA_FECHA_MODIFICACION.Name = "ULTIMA_FECHA_MODIFICACION";
            this.ULTIMA_FECHA_MODIFICACION.ReadOnly = true;
            // 
            // NUMERO_DE_PREGUNTAS
            // 
            this.NUMERO_DE_PREGUNTAS.HeaderText = "NUMERO_DE_PREGUNTAS";
            this.NUMERO_DE_PREGUNTAS.Name = "NUMERO_DE_PREGUNTAS";
            this.NUMERO_DE_PREGUNTAS.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(350, 418);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(280, 44);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(685, 418);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(280, 44);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(9, 418);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(280, 44);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyeto_BETA_002.Properties.Resources.eccLogo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnAbrirEnPdf
            // 
            this.btnAbrirEnPdf.BackColor = System.Drawing.Color.Black;
            this.btnAbrirEnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirEnPdf.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirEnPdf.ForeColor = System.Drawing.Color.White;
            this.btnAbrirEnPdf.Location = new System.Drawing.Point(218, 80);
            this.btnAbrirEnPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirEnPdf.Name = "btnAbrirEnPdf";
            this.btnAbrirEnPdf.Size = new System.Drawing.Size(747, 123);
            this.btnAbrirEnPdf.TabIndex = 22;
            this.btnAbrirEnPdf.Text = "Abrir en PDF";
            this.btnAbrirEnPdf.UseVisualStyleBackColor = false;
            this.btnAbrirEnPdf.Click += new System.EventHandler(this.btnAbrirEnPdf_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 58);
            this.panel2.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "El mejor creador de exámenes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "ECC - Exam Creator Corporation";
            // 
            // TodosLosExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(985, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAbrirEnPdf);
            this.Controls.Add(this.dgvExamenes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TodosLosExamenes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECC - Exam Creator Corporation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamenes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EXAMEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CREADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFESOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ULTIMA_FECHA_MODIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_DE_PREGUNTAS;
        private System.Windows.Forms.Button btnAbrirEnPdf;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}