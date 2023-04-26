
namespace УП_ИСРПО
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kolesovaSainaDataSet4 = new УП_ИСРПО.KolesovaSainaDataSet4();
            this.avtomobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtomobilTableAdapter = new УП_ИСРПО.KolesovaSainaDataSet4TableAdapters.AvtomobilTableAdapter();
            this.iDAvtomobilyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godvupyskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPostavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kolesovaSainaDataSet5 = new УП_ИСРПО.KolesovaSainaDataSet5();
            this.komplectaciyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komplectaciyaTableAdapter = new УП_ИСРПО.KolesovaSainaDataSet5TableAdapters.KomplectaciyaTableAdapter();
            this.iDPokupatelyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokpostavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolesovaSainaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolesovaSainaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komplectaciyaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(49, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить новый автомобиль";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(320, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAvtomobilyaDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.svetDataGridViewTextBoxColumn,
            this.godvupyskaDataGridViewTextBoxColumn,
            this.iDPostavkiDataGridViewTextBoxColumn,
            this.scenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.avtomobilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 120);
            this.dataGridView1.TabIndex = 3;
            // 
            // kolesovaSainaDataSet4
            // 
            this.kolesovaSainaDataSet4.DataSetName = "KolesovaSainaDataSet4";
            this.kolesovaSainaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtomobilBindingSource
            // 
            this.avtomobilBindingSource.DataMember = "Avtomobil";
            this.avtomobilBindingSource.DataSource = this.kolesovaSainaDataSet4;
            // 
            // avtomobilTableAdapter
            // 
            this.avtomobilTableAdapter.ClearBeforeFill = true;
            // 
            // iDAvtomobilyaDataGridViewTextBoxColumn
            // 
            this.iDAvtomobilyaDataGridViewTextBoxColumn.DataPropertyName = "ID_Avtomobilya";
            this.iDAvtomobilyaDataGridViewTextBoxColumn.HeaderText = "ID_Avtomobilya";
            this.iDAvtomobilyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDAvtomobilyaDataGridViewTextBoxColumn.Name = "iDAvtomobilyaDataGridViewTextBoxColumn";
            this.iDAvtomobilyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            this.nazvanieDataGridViewTextBoxColumn.Width = 125;
            // 
            // svetDataGridViewTextBoxColumn
            // 
            this.svetDataGridViewTextBoxColumn.DataPropertyName = "Svet";
            this.svetDataGridViewTextBoxColumn.HeaderText = "Svet";
            this.svetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.svetDataGridViewTextBoxColumn.Name = "svetDataGridViewTextBoxColumn";
            this.svetDataGridViewTextBoxColumn.Width = 125;
            // 
            // godvupyskaDataGridViewTextBoxColumn
            // 
            this.godvupyskaDataGridViewTextBoxColumn.DataPropertyName = "God_vupyska";
            this.godvupyskaDataGridViewTextBoxColumn.HeaderText = "God_vupyska";
            this.godvupyskaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.godvupyskaDataGridViewTextBoxColumn.Name = "godvupyskaDataGridViewTextBoxColumn";
            this.godvupyskaDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPostavkiDataGridViewTextBoxColumn
            // 
            this.iDPostavkiDataGridViewTextBoxColumn.DataPropertyName = "ID_Postavki";
            this.iDPostavkiDataGridViewTextBoxColumn.HeaderText = "ID_Postavki";
            this.iDPostavkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPostavkiDataGridViewTextBoxColumn.Name = "iDPostavkiDataGridViewTextBoxColumn";
            this.iDPostavkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // scenaDataGridViewTextBoxColumn
            // 
            this.scenaDataGridViewTextBoxColumn.DataPropertyName = "Scena";
            this.scenaDataGridViewTextBoxColumn.HeaderText = "Scena";
            this.scenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scenaDataGridViewTextBoxColumn.Name = "scenaDataGridViewTextBoxColumn";
            this.scenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPokupatelyaDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn1,
            this.scenaDataGridViewTextBoxColumn1,
            this.srokpostavkiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.komplectaciyaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(49, 296);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(884, 92);
            this.dataGridView2.TabIndex = 4;
            // 
            // kolesovaSainaDataSet5
            // 
            this.kolesovaSainaDataSet5.DataSetName = "KolesovaSainaDataSet5";
            this.kolesovaSainaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // komplectaciyaBindingSource
            // 
            this.komplectaciyaBindingSource.DataMember = "Komplectaciya";
            this.komplectaciyaBindingSource.DataSource = this.kolesovaSainaDataSet5;
            // 
            // komplectaciyaTableAdapter
            // 
            this.komplectaciyaTableAdapter.ClearBeforeFill = true;
            // 
            // iDPokupatelyaDataGridViewTextBoxColumn
            // 
            this.iDPokupatelyaDataGridViewTextBoxColumn.DataPropertyName = "ID_Pokupatelya";
            this.iDPokupatelyaDataGridViewTextBoxColumn.HeaderText = "ID_Pokupatelya";
            this.iDPokupatelyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPokupatelyaDataGridViewTextBoxColumn.Name = "iDPokupatelyaDataGridViewTextBoxColumn";
            this.iDPokupatelyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazvanieDataGridViewTextBoxColumn1
            // 
            this.nazvanieDataGridViewTextBoxColumn1.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn1.HeaderText = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nazvanieDataGridViewTextBoxColumn1.Name = "nazvanieDataGridViewTextBoxColumn1";
            this.nazvanieDataGridViewTextBoxColumn1.Width = 125;
            // 
            // scenaDataGridViewTextBoxColumn1
            // 
            this.scenaDataGridViewTextBoxColumn1.DataPropertyName = "Scena";
            this.scenaDataGridViewTextBoxColumn1.HeaderText = "Scena";
            this.scenaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.scenaDataGridViewTextBoxColumn1.Name = "scenaDataGridViewTextBoxColumn1";
            this.scenaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // srokpostavkiDataGridViewTextBoxColumn
            // 
            this.srokpostavkiDataGridViewTextBoxColumn.DataPropertyName = "Srok_postavki";
            this.srokpostavkiDataGridViewTextBoxColumn.HeaderText = "Srok_postavki";
            this.srokpostavkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.srokpostavkiDataGridViewTextBoxColumn.Name = "srokpostavkiDataGridViewTextBoxColumn";
            this.srokpostavkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(49, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 56);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавить новую комплектацию";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(320, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1213, 494);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Данные об автомолей";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolesovaSainaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolesovaSainaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komplectaciyaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KolesovaSainaDataSet4 kolesovaSainaDataSet4;
        private System.Windows.Forms.BindingSource avtomobilBindingSource;
        private KolesovaSainaDataSet4TableAdapters.AvtomobilTableAdapter avtomobilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAvtomobilyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godvupyskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPostavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private KolesovaSainaDataSet5 kolesovaSainaDataSet5;
        private System.Windows.Forms.BindingSource komplectaciyaBindingSource;
        private KolesovaSainaDataSet5TableAdapters.KomplectaciyaTableAdapter komplectaciyaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPokupatelyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokpostavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}