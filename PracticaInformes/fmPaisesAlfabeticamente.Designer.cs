namespace PracticaInformes
{
    partial class fmPaisesAlfabeticamente
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btMostrar = new System.Windows.Forms.Button();
            this.bd_paisesDataSet = new PracticaInformes.bd_paisesDataSet();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisesTableAdapter = new PracticaInformes.bd_paisesDataSetTableAdapters.paisesTableAdapter();
            this.tableAdapterManager = new PracticaInformes.bd_paisesDataSetTableAdapters.TableAdapterManager();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_paisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btMostrar);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 73);
            this.panel1.TabIndex = 1;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(168, 25);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(127, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Nombre Usuario Informe: ";
            // 
            // tbNombre
            // 
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Location = new System.Drawing.Point(292, 23);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(239, 20);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyDown);
            // 
            // btMostrar
            // 
            this.btMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMostrar.Location = new System.Drawing.Point(537, 23);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(106, 23);
            this.btMostrar.TabIndex = 2;
            this.btMostrar.Text = "Mostrar Informe";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // bd_paisesDataSet
            // 
            this.bd_paisesDataSet.DataSetName = "bd_paisesDataSet";
            this.bd_paisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "paises";
            this.paisesBindingSource.DataSource = this.bd_paisesDataSet;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.paisesTableAdapter = this.paisesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PracticaInformes.bd_paisesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.paisesBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "PracticaInformes.ReportAlfabetico2.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 79);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1025, 504);
            this.reportViewer.TabIndex = 2;
            // 
            // fmPaisesAlfabeticamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 583);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panel1);
            this.Name = "fmPaisesAlfabeticamente";
            this.Text = "fmPaisesAlfabeticamente";
            this.Load += new System.EventHandler(this.fmPaisesAlfabeticamente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_paisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label labelUsuario;
        private bd_paisesDataSet bd_paisesDataSet;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private bd_paisesDataSetTableAdapters.paisesTableAdapter paisesTableAdapter;
        private bd_paisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}