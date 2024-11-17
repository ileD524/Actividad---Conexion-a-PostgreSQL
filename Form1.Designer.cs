namespace Actividad___Conexión_a_PostgreSQL
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
            cmbSexo = new ComboBox();
            btnAlta = new Button();
            btnBaja = new Button();
            btnModificar = new Button();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(494, 36);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 23);
            cmbSexo.TabIndex = 0;
            // 
            // btnAlta
            // 
            btnAlta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlta.Location = new Point(303, 166);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(84, 42);
            btnAlta.TabIndex = 1;
            btnAlta.Text = "Enviar";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBaja.Location = new Point(13, 346);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(84, 42);
            btnBaja.TabIndex = 2;
            btnBaja.Text = "Eliminar";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.Location = new Point(12, 269);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(84, 42);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(78, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(212, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(78, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(212, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(78, 36);
            txtID.Name = "txtID";
            txtID.Size = new Size(212, 23);
            txtID.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(685, 224);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 83);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 125);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 12;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 36);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 13;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 39);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 14;
            label4.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 87);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 15;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(494, 83);
            dateTimePicker1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtID);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Controls.Add(cmbSexo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSexo;
        private Button btnAlta;
        private Button btnBaja;
        private Button btnModificar;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtID;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}
