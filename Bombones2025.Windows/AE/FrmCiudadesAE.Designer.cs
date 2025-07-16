namespace Bombones2025.Windows.AE
{
    partial class FrmCiudadesAE
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
            cbCiudadesPais = new ComboBox();
            labelPaisProvEst = new Label();
            textBoxCiudad = new TextBox();
            labelProvEst = new Label();
            btnCancel = new Button();
            btnOk = new Button();
            cbCiudadesProvEstado = new ComboBox();
            labelProEst = new Label();
            SuspendLayout();
            // 
            // cbCiudadesPais
            // 
            cbCiudadesPais.FormattingEnabled = true;
            cbCiudadesPais.Location = new Point(199, 100);
            cbCiudadesPais.Name = "cbCiudadesPais";
            cbCiudadesPais.Size = new Size(242, 23);
            cbCiudadesPais.TabIndex = 7;
            cbCiudadesPais.SelectedIndexChanged += cbCiudadesPais_SelectedIndexChanged;
            // 
            // labelPaisProvEst
            // 
            labelPaisProvEst.AutoSize = true;
            labelPaisProvEst.Location = new Point(89, 103);
            labelPaisProvEst.Name = "labelPaisProvEst";
            labelPaisProvEst.Size = new Size(31, 15);
            labelPaisProvEst.TabIndex = 11;
            labelPaisProvEst.Text = "Pais:";
            // 
            // textBoxCiudad
            // 
            textBoxCiudad.Location = new Point(199, 41);
            textBoxCiudad.Margin = new Padding(3, 2, 3, 2);
            textBoxCiudad.Name = "textBoxCiudad";
            textBoxCiudad.Size = new Size(242, 23);
            textBoxCiudad.TabIndex = 6;
            // 
            // labelProvEst
            // 
            labelProvEst.AutoSize = true;
            labelProvEst.Location = new Point(89, 43);
            labelProvEst.Name = "labelProvEst";
            labelProvEst.Size = new Size(48, 15);
            labelProvEst.TabIndex = 10;
            labelProvEst.Text = "Ciudad:";
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.CANCEL40;
            btnCancel.Location = new Point(356, 128);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 69);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "CANCELAR";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Image = Properties.Resources.OK40;
            btnOk.Location = new Point(89, 128);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(85, 69);
            btnOk.TabIndex = 8;
            btnOk.Text = "OK";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            // 
            // cbCiudadesProvEstado
            // 
            cbCiudadesProvEstado.FormattingEnabled = true;
            cbCiudadesProvEstado.Location = new Point(199, 71);
            cbCiudadesProvEstado.Name = "cbCiudadesProvEstado";
            cbCiudadesProvEstado.Size = new Size(242, 23);
            cbCiudadesProvEstado.TabIndex = 7;
            // 
            // labelProEst
            // 
            labelProEst.AutoSize = true;
            labelProEst.Location = new Point(89, 74);
            labelProEst.Name = "labelProEst";
            labelProEst.Size = new Size(99, 15);
            labelProEst.TabIndex = 11;
            labelProEst.Text = "Provincia/Estado:";
            // 
            // FrmCiudadesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 217);
            Controls.Add(cbCiudadesProvEstado);
            Controls.Add(cbCiudadesPais);
            Controls.Add(labelProEst);
            Controls.Add(labelPaisProvEst);
            Controls.Add(textBoxCiudad);
            Controls.Add(labelProvEst);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            MaximumSize = new Size(547, 256);
            MinimumSize = new Size(547, 256);
            Name = "FrmCiudadesAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CiudadesAE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCiudadesPais;
        private Label labelPaisProvEst;
        private TextBox textBoxCiudad;
        private Label labelProvEst;
        private Button btnCancel;
        private Button btnOk;
        private ComboBox cbCiudadesProvEstado;
        private Label labelProEst;
    }
}