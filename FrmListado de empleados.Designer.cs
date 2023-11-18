namespace PryChestaTP2
{
    partial class FrmListado_de_empleados
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
            this.btnListar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFiltrarApellido = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFiltrarBarrio = new System.Windows.Forms.Button();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(572, 718);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(137, 28);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(209, 107);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 22);
            this.txtApellido.TabIndex = 1;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(205, 94);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(132, 22);
            this.txtCiudad.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(156, 57);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 305);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFiltrarApellido);
            this.tabPage1.Controls.Add(this.lblApellido);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(551, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apellido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarApellido
            // 
            this.btnFiltrarApellido.Location = new System.Drawing.Point(372, 110);
            this.btnFiltrarApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrarApellido.Name = "btnFiltrarApellido";
            this.btnFiltrarApellido.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrarApellido.TabIndex = 6;
            this.btnFiltrarApellido.Text = "Filtrar";
            this.btnFiltrarApellido.UseVisualStyleBackColor = true;
            this.btnFiltrarApellido.Click += new System.EventHandler(this.btnFiltrarApellido_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(124, 116);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFiltrarBarrio);
            this.tabPage2.Controls.Add(this.lblBarrio);
            this.tabPage2.Controls.Add(this.txtCiudad);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(551, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ciudad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarBarrio
            // 
            this.btnFiltrarBarrio.Location = new System.Drawing.Point(384, 97);
            this.btnFiltrarBarrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrarBarrio.Name = "btnFiltrarBarrio";
            this.btnFiltrarBarrio.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrarBarrio.TabIndex = 5;
            this.btnFiltrarBarrio.Text = "Filtrar";
            this.btnFiltrarBarrio.UseVisualStyleBackColor = true;
            this.btnFiltrarBarrio.Click += new System.EventHandler(this.btnFiltrarBarrio_Click);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(103, 97);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(50, 16);
            this.lblBarrio.TabIndex = 5;
            this.lblBarrio.Text = "Ciudad";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(156, 390);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.Size = new System.Drawing.Size(553, 299);
            this.dgvEmpleados.TabIndex = 4;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(737, 718);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(137, 28);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver ";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmListado_de_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 779);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnListar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListado_de_empleados";
            this.Text = "FrmListado_de_empleados";
            this.Load += new System.EventHandler(this.FrmListado_de_empleados_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnFiltrarBarrio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnFiltrarApellido;
    }
}