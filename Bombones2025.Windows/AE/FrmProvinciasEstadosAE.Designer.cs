﻿namespace Bombones2025.Windows.AE
{
    partial class FrmProvinciasEstadosAE
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
            components = new System.ComponentModel.Container();
            textBoxProvEst = new TextBox();
            labelProvEst = new Label();
            btnCancel = new Button();
            btnOk = new Button();
            labelPaisProvEst = new Label();
            cbPaisProvEst = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBoxProvEst
            // 
            textBoxProvEst.Location = new Point(199, 25);
            textBoxProvEst.Margin = new Padding(3, 2, 3, 2);
            textBoxProvEst.Name = "textBoxProvEst";
            textBoxProvEst.Size = new Size(242, 23);
            textBoxProvEst.TabIndex = 0;
            // 
            // labelProvEst
            // 
            labelProvEst.AutoSize = true;
            labelProvEst.Location = new Point(89, 27);
            labelProvEst.Name = "labelProvEst";
            labelProvEst.Size = new Size(99, 15);
            labelProvEst.TabIndex = 4;
            labelProvEst.Text = "Provincia/Estado:";
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.CANCEL40;
            btnCancel.Location = new Point(356, 91);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 69);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCELAR";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Image = Properties.Resources.OK40;
            btnOk.Location = new Point(89, 91);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(85, 69);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // labelPaisProvEst
            // 
            labelPaisProvEst.AutoSize = true;
            labelPaisProvEst.Location = new Point(89, 62);
            labelPaisProvEst.Name = "labelPaisProvEst";
            labelPaisProvEst.Size = new Size(31, 15);
            labelPaisProvEst.TabIndex = 5;
            labelPaisProvEst.Text = "Pais:";
            // 
            // cbPaisProvEst
            // 
            cbPaisProvEst.FormattingEnabled = true;
            cbPaisProvEst.Location = new Point(199, 59);
            cbPaisProvEst.Name = "cbPaisProvEst";
            cbPaisProvEst.Size = new Size(242, 23);
            cbPaisProvEst.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmProvinciasEstadosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 171);
            Controls.Add(cbPaisProvEst);
            Controls.Add(labelPaisProvEst);
            Controls.Add(textBoxProvEst);
            Controls.Add(labelProvEst);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Name = "FrmProvinciasEstadosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProvinciasEstadosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProvEst;
        private Label labelProvEst;
        private Button btnCancel;
        private Button btnOk;
        private Label labelPaisProvEst;
        private ComboBox cbPaisProvEst;
        private ErrorProvider errorProvider1;
    }
}