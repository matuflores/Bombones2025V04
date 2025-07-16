﻿namespace Bombones2025.Windows
{
    partial class FrmPrincipal
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
            btnPais = new Button();
            btnRellenos = new Button();
            btnFrutosSecos = new Button();
            btnChocolates = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripUserLogin = new ToolStripStatusLabel();
            btnOFF = new Button();
            btnFormasDePagos = new Button();
            btnProvEst = new Button();
            btnCiudades = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPais
            // 
            btnPais.Location = new Point(60, 38);
            btnPais.Margin = new Padding(3, 2, 3, 2);
            btnPais.Name = "btnPais";
            btnPais.Size = new Size(88, 38);
            btnPais.TabIndex = 0;
            btnPais.Text = "Paises";
            btnPais.UseVisualStyleBackColor = true;
            btnPais.Click += btnPais_Click;
            // 
            // btnRellenos
            // 
            btnRellenos.Location = new Point(263, 38);
            btnRellenos.Margin = new Padding(3, 2, 3, 2);
            btnRellenos.Name = "btnRellenos";
            btnRellenos.Size = new Size(88, 38);
            btnRellenos.TabIndex = 1;
            btnRellenos.Text = "Rellenos";
            btnRellenos.UseVisualStyleBackColor = true;
            btnRellenos.Click += btnRellenos_Click;
            // 
            // btnFrutosSecos
            // 
            btnFrutosSecos.Location = new Point(60, 105);
            btnFrutosSecos.Margin = new Padding(3, 2, 3, 2);
            btnFrutosSecos.Name = "btnFrutosSecos";
            btnFrutosSecos.Size = new Size(88, 38);
            btnFrutosSecos.TabIndex = 2;
            btnFrutosSecos.Text = "Frutos Secos";
            btnFrutosSecos.UseVisualStyleBackColor = true;
            btnFrutosSecos.Click += btnFrutosSecos_Click;
            // 
            // btnChocolates
            // 
            btnChocolates.Location = new Point(263, 105);
            btnChocolates.Margin = new Padding(3, 2, 3, 2);
            btnChocolates.Name = "btnChocolates";
            btnChocolates.Size = new Size(88, 38);
            btnChocolates.TabIndex = 3;
            btnChocolates.Text = "Chocolates";
            btnChocolates.UseVisualStyleBackColor = true;
            btnChocolates.Click += btnChocolates_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripUserLogin });
            statusStrip1.Location = new Point(0, 280);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(422, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(50, 17);
            toolStripStatusLabel1.Text = "Usuario:";
            // 
            // toolStripUserLogin
            // 
            toolStripUserLogin.Name = "toolStripUserLogin";
            toolStripUserLogin.Size = new Size(12, 17);
            toolStripUserLogin.Text = "-";
            // 
            // btnOFF
            // 
            btnOFF.FlatStyle = FlatStyle.Flat;
            btnOFF.Image = Properties.Resources.OFF30;
            btnOFF.Location = new Point(367, 231);
            btnOFF.Name = "btnOFF";
            btnOFF.Size = new Size(43, 46);
            btnOFF.TabIndex = 5;
            btnOFF.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOFF.UseVisualStyleBackColor = true;
            btnOFF.Click += btnOFF_Click;
            // 
            // btnFormasDePagos
            // 
            btnFormasDePagos.Location = new Point(60, 171);
            btnFormasDePagos.Margin = new Padding(3, 2, 3, 2);
            btnFormasDePagos.Name = "btnFormasDePagos";
            btnFormasDePagos.Size = new Size(88, 38);
            btnFormasDePagos.TabIndex = 6;
            btnFormasDePagos.Text = "Formas de Pago";
            btnFormasDePagos.UseVisualStyleBackColor = true;
            btnFormasDePagos.Click += btnFormasDePagos_Click;
            // 
            // btnProvEst
            // 
            btnProvEst.Location = new Point(263, 171);
            btnProvEst.Margin = new Padding(3, 2, 3, 2);
            btnProvEst.Name = "btnProvEst";
            btnProvEst.Size = new Size(88, 38);
            btnProvEst.TabIndex = 7;
            btnProvEst.Text = "Provincias Estados";
            btnProvEst.UseVisualStyleBackColor = true;
            btnProvEst.Click += btnProvEst_Click;
            // 
            // btnCiudades
            // 
            btnCiudades.Location = new Point(60, 239);
            btnCiudades.Margin = new Padding(3, 2, 3, 2);
            btnCiudades.Name = "btnCiudades";
            btnCiudades.Size = new Size(88, 38);
            btnCiudades.TabIndex = 6;
            btnCiudades.Text = "Ciudades";
            btnCiudades.UseVisualStyleBackColor = true;
            btnCiudades.Click += btnFormasDePagos_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 302);
            ControlBox = false;
            Controls.Add(btnProvEst);
            Controls.Add(btnCiudades);
            Controls.Add(btnFormasDePagos);
            Controls.Add(btnOFF);
            Controls.Add(statusStrip1);
            Controls.Add(btnChocolates);
            Controls.Add(btnFrutosSecos);
            Controls.Add(btnRellenos);
            Controls.Add(btnPais);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPais;
        private Button btnRellenos;
        private Button btnFrutosSecos;
        private Button btnChocolates;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripUserLogin;
        private Button btnOFF;
        private Button btnFormasDePagos;
        private Button btnProvEst;
        private Button btnCiudades;
    }
}