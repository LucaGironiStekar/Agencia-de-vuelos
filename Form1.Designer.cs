
namespace Agencia_de_viajes
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
            this.btSalir = new System.Windows.Forms.Button();
            this.btConsultas = new System.Windows.Forms.Button();
            this.btOfertas = new System.Windows.Forms.Button();
            this.BtDestinos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.Transparent;
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Location = new System.Drawing.Point(25, 416);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(59, 26);
            this.btSalir.TabIndex = 0;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btConsultas
            // 
            this.btConsultas.BackColor = System.Drawing.Color.Transparent;
            this.btConsultas.FlatAppearance.BorderSize = 0;
            this.btConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultas.Location = new System.Drawing.Point(641, 251);
            this.btConsultas.Name = "btConsultas";
            this.btConsultas.Size = new System.Drawing.Size(131, 26);
            this.btConsultas.TabIndex = 1;
            this.btConsultas.UseVisualStyleBackColor = false;
            this.btConsultas.Click += new System.EventHandler(this.btConsultas_Click);
            // 
            // btOfertas
            // 
            this.btOfertas.BackColor = System.Drawing.Color.Transparent;
            this.btOfertas.FlatAppearance.BorderSize = 0;
            this.btOfertas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btOfertas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btOfertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOfertas.Location = new System.Drawing.Point(678, 208);
            this.btOfertas.Name = "btOfertas";
            this.btOfertas.Size = new System.Drawing.Size(94, 26);
            this.btOfertas.TabIndex = 2;
            this.btOfertas.UseVisualStyleBackColor = false;
            this.btOfertas.Click += new System.EventHandler(this.btOfertas_Click);
            // 
            // BtDestinos
            // 
            this.BtDestinos.BackColor = System.Drawing.Color.Transparent;
            this.BtDestinos.FlatAppearance.BorderSize = 0;
            this.BtDestinos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtDestinos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDestinos.Location = new System.Drawing.Point(641, 165);
            this.BtDestinos.Name = "BtDestinos";
            this.BtDestinos.Size = new System.Drawing.Size(131, 26);
            this.BtDestinos.TabIndex = 3;
            this.BtDestinos.UseVisualStyleBackColor = false;
            this.BtDestinos.Click += new System.EventHandler(this.BtDestinos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Agencia_de_viajes.Properties.Resources.WhatsApp_Image_2021_11_05_at_7_13_44_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 467);
            this.Controls.Add(this.BtDestinos);
            this.Controls.Add(this.btOfertas);
            this.Controls.Add(this.btConsultas);
            this.Controls.Add(this.btSalir);
            this.Name = "Form1";
            this.Text = "FLAWAY";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btConsultas;
        private System.Windows.Forms.Button btOfertas;
        private System.Windows.Forms.Button BtDestinos;
    }
}

