
namespace ödev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partiNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyOranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiOyDataSet = new ödev1.PartiOyDataSet();
            this.Button1 = new System.Windows.Forms.Button();
            this.oyTableAdapter = new ödev1.PartiOyDataSetTableAdapters.OyTableAdapter();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiOyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partiNameDataGridViewTextBoxColumn,
            this.oyOranDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(786, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(722, 478);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // partiNameDataGridViewTextBoxColumn
            // 
            this.partiNameDataGridViewTextBoxColumn.DataPropertyName = "Parti_Name";
            this.partiNameDataGridViewTextBoxColumn.HeaderText = "Parti_Name";
            this.partiNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partiNameDataGridViewTextBoxColumn.Name = "partiNameDataGridViewTextBoxColumn";
            // 
            // oyOranDataGridViewTextBoxColumn
            // 
            this.oyOranDataGridViewTextBoxColumn.DataPropertyName = "Oy_Oran";
            this.oyOranDataGridViewTextBoxColumn.HeaderText = "Oy_Oran";
            this.oyOranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oyOranDataGridViewTextBoxColumn.Name = "oyOranDataGridViewTextBoxColumn";
            // 
            // oyBindingSource
            // 
            this.oyBindingSource.DataMember = "Oy";
            this.oyBindingSource.DataSource = this.partiOyDataSet;
            // 
            // partiOyDataSet
            // 
            this.partiOyDataSet.DataSetName = "PartiOyDataSet";
            this.partiOyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(723, 648);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(97, 35);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Load";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oyTableAdapter
            // 
            this.oyTableAdapter.ClearBeforeFill = true;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(12, 83);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(768, 510);
            this.pieChart1.TabIndex = 3;
            this.pieChart1.Text = "pieChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 763);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiOyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button1;
        private PartiOyDataSet partiOyDataSet;
        private System.Windows.Forms.BindingSource oyBindingSource;
        private PartiOyDataSetTableAdapters.OyTableAdapter oyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partiNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyOranDataGridViewTextBoxColumn;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}

