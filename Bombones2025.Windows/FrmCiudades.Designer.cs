namespace Bombones2025.Windows
{
    partial class FrmCiudades
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            dgvCiudades = new DataGridView();
            CiudadId = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            ProvinciaEstado = new DataGridViewTextBoxColumn();
            NombrePais = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnBorrar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnPrint = new ToolStripButton();
            btnCerrar = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvCiudades);
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            splitContainer1.Size = new Size(700, 338);
            splitContainer1.SplitterDistance = 287;
            splitContainer1.TabIndex = 0;
            // 
            // dgvCiudades
            // 
            dgvCiudades.AllowUserToAddRows = false;
            dgvCiudades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dgvCiudades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudades.Columns.AddRange(new DataGridViewColumn[] { CiudadId, Ciudad, ProvinciaEstado, NombrePais });
            dgvCiudades.Dock = DockStyle.Fill;
            dgvCiudades.Location = new Point(0, 62);
            dgvCiudades.Margin = new Padding(3, 2, 3, 2);
            dgvCiudades.Name = "dgvCiudades";
            dgvCiudades.ReadOnly = true;
            dgvCiudades.RowHeadersVisible = false;
            dgvCiudades.RowHeadersWidth = 51;
            dgvCiudades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudades.Size = new Size(700, 225);
            dgvCiudades.TabIndex = 3;
            // 
            // CiudadId
            // 
            CiudadId.HeaderText = "CiudadId";
            CiudadId.MinimumWidth = 6;
            CiudadId.Name = "CiudadId";
            CiudadId.ReadOnly = true;
            CiudadId.Visible = false;
            CiudadId.Width = 125;
            // 
            // Ciudad
            // 
            Ciudad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ciudad.HeaderText = "Ciudad";
            Ciudad.MinimumWidth = 6;
            Ciudad.Name = "Ciudad";
            Ciudad.ReadOnly = true;
            // 
            // ProvinciaEstado
            // 
            ProvinciaEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProvinciaEstado.HeaderText = "Provincia/Estado";
            ProvinciaEstado.Name = "ProvinciaEstado";
            ProvinciaEstado.ReadOnly = true;
            // 
            // NombrePais
            // 
            NombrePais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombrePais.HeaderText = "Pais";
            NombrePais.Name = "NombrePais";
            NombrePais.ReadOnly = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnBorrar, btnEditar, toolStripSeparator1, btnFiltrar, btnRefresh, toolStripSeparator2, btnPrint, btnCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(700, 62);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources.NEW40;
            btnNuevo.ImageScaling = ToolStripItemImageScaling.None;
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(50, 59);
            btnNuevo.Text = "NUEVO";
            btnNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Image = Properties.Resources.DELETE40;
            btnBorrar.ImageScaling = ToolStripItemImageScaling.None;
            btnBorrar.ImageTransparentColor = Color.Magenta;
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(56, 59);
            btnBorrar.Text = "BORRAR";
            btnBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.EDIT40;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(49, 59);
            btnEditar.Text = "EDITAR";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // btnFiltrar
            // 
            btnFiltrar.Image = Properties.Resources.FILTRO40;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(54, 59);
            btnFiltrar.Text = "FILTRAR";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.REFRESH40;
            btnRefresh.ImageScaling = ToolStripItemImageScaling.None;
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(58, 59);
            btnRefresh.Text = "REFRESH";
            btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 62);
            // 
            // btnPrint
            // 
            btnPrint.Image = Properties.Resources.PRINT40;
            btnPrint.ImageScaling = ToolStripItemImageScaling.None;
            btnPrint.ImageTransparentColor = Color.Magenta;
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(44, 59);
            btnPrint.Text = "PRINT";
            btnPrint.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = Properties.Resources.CLOSE40;
            btnCerrar.ImageScaling = ToolStripItemImageScaling.None;
            btnCerrar.ImageTransparentColor = Color.Magenta;
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(54, 59);
            btnCerrar.Text = "CERRAR";
            btnCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmCiudades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(716, 377);
            MinimumSize = new Size(716, 377);
            Name = "FrmCiudades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ciudades";
            Load += FrmCiudades_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnBorrar;
        private ToolStripButton btnEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnFiltrar;
        private ToolStripButton btnRefresh;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnPrint;
        private ToolStripButton btnCerrar;
        private DataGridView dgvCiudades;
        private DataGridViewTextBoxColumn CiudadId;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn ProvinciaEstado;
        private DataGridViewTextBoxColumn NombrePais;
    }
}