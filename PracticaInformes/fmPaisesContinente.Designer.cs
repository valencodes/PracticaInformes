namespace PracticaInformes
{
    partial class fmPaisesContinente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbContinentes = new System.Windows.Forms.ComboBox();
            this.btMostrar = new System.Windows.Forms.Button();
            this.paises1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_paisesDataSet = new PracticaInformes.bd_paisesDataSet();
            this.paises1TableAdapter = new PracticaInformes.bd_paisesDataSetTableAdapters.paises1TableAdapter();
            this.tableAdapterManager = new PracticaInformes.bd_paisesDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paises1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_paisesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.paises1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaInformes.ReportPaisesContinente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(816, 354);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 40);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btMostrar);
            this.panel2.Controls.Add(this.cbContinentes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 75);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar Países del Continente Elegido";
            // 
            // cbContinentes
            // 
            this.cbContinentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContinentes.FormattingEnabled = true;
            this.cbContinentes.Items.AddRange(new object[] {
            "Europa",
            "América",
            "Asia",
            "Oceanía",
            "Africa"});
            this.cbContinentes.Location = new System.Drawing.Point(236, 26);
            this.cbContinentes.Name = "cbContinentes";
            this.cbContinentes.Size = new System.Drawing.Size(141, 21);
            this.cbContinentes.TabIndex = 0;
            // 
            // btMostrar
            // 
            this.btMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMostrar.Location = new System.Drawing.Point(392, 24);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(134, 23);
            this.btMostrar.TabIndex = 1;
            this.btMostrar.Text = "Mostrar Países";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // paises1BindingSource
            // 
            this.paises1BindingSource.DataMember = "paises1";
            this.paises1BindingSource.DataSource = this.bd_paisesDataSet;
            // 
            // bd_paisesDataSet
            // 
            this.bd_paisesDataSet.DataSetName = "bd_paisesDataSet";
            this.bd_paisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paises1TableAdapter
            // 
            this.paises1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.paises1TableAdapter = this.paises1TableAdapter;
            this.tableAdapterManager.paisesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PracticaInformes.bd_paisesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fmPaisesContinente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fmPaisesContinente";
            this.Text = "fmPaisesContinente";
            this.Load += new System.EventHandler(this.fmPaisesContinente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paises1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_paisesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bd_paisesDataSet bd_paisesDataSet;
        private System.Windows.Forms.BindingSource paises1BindingSource;
        private bd_paisesDataSetTableAdapters.paises1TableAdapter paises1TableAdapter;
        private bd_paisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbContinentes;
        private System.Windows.Forms.Button btMostrar;
    }
}