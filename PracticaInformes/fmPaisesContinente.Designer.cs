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
            this.bd_paisesDataSet = new PracticaInformes.bd_paisesDataSet();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisesTableAdapter = new PracticaInformes.bd_paisesDataSetTableAdapters.paisesTableAdapter();
            this.tableAdapterManager = new PracticaInformes.bd_paisesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bd_paisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // fmPaisesContinente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 462);
            this.Name = "fmPaisesContinente";
            this.Text = "fmPaisesContinente";
            this.Load += new System.EventHandler(this.fmPaisesContinente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_paisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bd_paisesDataSet bd_paisesDataSet;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private bd_paisesDataSetTableAdapters.paisesTableAdapter paisesTableAdapter;
        private bd_paisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}