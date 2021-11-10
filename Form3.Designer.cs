
namespace Agencia_de_viajes
{
    partial class Consultas
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
            this.dtSugerencias = new System.Windows.Forms.DataGridView();
            this.ListaPaises = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEscribeUnPais = new System.Windows.Forms.Label();
            this.txtPaises = new System.Windows.Forms.TextBox();
            this.btDesear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtSugerencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSugerencias
            // 
            this.dtSugerencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSugerencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListaPaises});
            this.dtSugerencias.Location = new System.Drawing.Point(12, 344);
            this.dtSugerencias.Name = "dtSugerencias";
            this.dtSugerencias.RowTemplate.Height = 25;
            this.dtSugerencias.Size = new System.Drawing.Size(243, 145);
            this.dtSugerencias.TabIndex = 1;
            // 
            // ListaPaises
            // 
            this.ListaPaises.HeaderText = "¡Paises sugeridos!";
            this.ListaPaises.Name = "ListaPaises";
            this.ListaPaises.Width = 200;
            // 
            // lblEscribeUnPais
            // 
            this.lblEscribeUnPais.AutoSize = true;
            this.lblEscribeUnPais.BackColor = System.Drawing.Color.Transparent;
            this.lblEscribeUnPais.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEscribeUnPais.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEscribeUnPais.Location = new System.Drawing.Point(12, 272);
            this.lblEscribeUnPais.Name = "lblEscribeUnPais";
            this.lblEscribeUnPais.Size = new System.Drawing.Size(233, 19);
            this.lblEscribeUnPais.TabIndex = 2;
            this.lblEscribeUnPais.Text = "Escribe un país al que quisieras viajar";
            // 
            // txtPaises
            // 
            this.txtPaises.Location = new System.Drawing.Point(12, 306);
            this.txtPaises.Name = "txtPaises";
            this.txtPaises.Size = new System.Drawing.Size(167, 23);
            this.txtPaises.TabIndex = 3;
            // 
            // btDesear
            // 
            this.btDesear.Location = new System.Drawing.Point(185, 305);
            this.btDesear.Name = "btDesear";
            this.btDesear.Size = new System.Drawing.Size(95, 23);
            this.btDesear.TabIndex = 4;
            this.btDesear.Text = "Desear";
            this.btDesear.UseVisualStyleBackColor = true;
            this.btDesear.Click += new System.EventHandler(this.btDesear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(645, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDireccion.Location = new System.Drawing.Point(426, 290);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(92, 15);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Encontranos en:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(426, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Calle Falsa 123, Buenos Aires";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(426, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Calle Verdadera 789, Córdoba";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Agencia_de_viajes.Properties.Resources.Consultas_ahorasi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(751, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDesear);
            this.Controls.Add(this.txtPaises);
            this.Controls.Add(this.lblEscribeUnPais);
            this.Controls.Add(this.dtSugerencias);
            this.Name = "Consultas";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSugerencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtSugerencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListaPaises;
        private System.Windows.Forms.Label lblEscribeUnPais;
        private System.Windows.Forms.TextBox txtPaises;
        private System.Windows.Forms.Button btDesear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}