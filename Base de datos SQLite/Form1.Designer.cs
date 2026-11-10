namespace Base_de_datos_SQLite
{
    partial class Form1
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
            label1 = new Label();
            lblnombre = new Label();
            lblid = new Label();
            txtnombre = new TextBox();
            txtid = new TextBox();
            btninsertar = new Button();
            btnactualizar = new Button();
            btneliminar = new Button();
            dgvbasededatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvbasededatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 54);
            label1.Name = "label1";
            label1.Size = new Size(356, 27);
            label1.TabIndex = 0;
            label1.Text = "BASE DE DATOS EN SQLite";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(47, 102);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(54, 15);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "Nombre:";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(63, 146);
            lblid.Name = "lblid";
            lblid.Size = new Size(20, 15);
            lblid.TabIndex = 2;
            lblid.Text = "Id:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(115, 100);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(117, 23);
            txtnombre.TabIndex = 3;
            txtnombre.TextChanged += textBox1_TextChanged;
            // 
            // txtid
            // 
            txtid.Location = new Point(115, 146);
            txtid.Name = "txtid";
            txtid.Size = new Size(117, 23);
            txtid.TabIndex = 4;
            // 
            // btninsertar
            // 
            btninsertar.Location = new Point(115, 237);
            btninsertar.Name = "btninsertar";
            btninsertar.Size = new Size(117, 23);
            btninsertar.TabIndex = 5;
            btninsertar.Text = "INSERTAR";
            btninsertar.UseVisualStyleBackColor = true;
            btninsertar.Click += btninsertar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(115, 341);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(117, 23);
            btnactualizar.TabIndex = 6;
            btnactualizar.Text = "ACTUALIZAR";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(115, 454);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(117, 23);
            btneliminar.TabIndex = 7;
            btneliminar.Text = "ELIMINAR";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // dgvbasededatos
            // 
            dgvbasededatos.BackgroundColor = Color.White;
            dgvbasededatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbasededatos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Id });
            dgvbasededatos.Location = new Point(269, 100);
            dgvbasededatos.Name = "dgvbasededatos";
            dgvbasededatos.Size = new Size(510, 377);
            dgvbasededatos.TabIndex = 8;
            dgvbasededatos.CellContentClick += dgvbasededatos_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 684);
            Controls.Add(dgvbasededatos);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(btninsertar);
            Controls.Add(txtid);
            Controls.Add(txtnombre);
            Controls.Add(lblid);
            Controls.Add(lblnombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbasededatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblnombre;
        private Label lblid;
        private TextBox txtnombre;
        private TextBox txtid;
        private Button btninsertar;
        private Button btnactualizar;
        private Button btneliminar;
        private DataGridView dgvbasededatos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Id;
    }
}
