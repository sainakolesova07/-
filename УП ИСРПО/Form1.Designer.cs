
namespace УП_ИСРПО
{
    partial class Авторизация
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Войти = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.polzovateliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kolesovaSainaDataSet1 = new УП_ИСРПО.KolesovaSainaDataSet1();
            this.polzovateliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolesovaSainaDataSet = new УП_ИСРПО.KolesovaSainaDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.polzovateliTableAdapter = new УП_ИСРПО.KolesovaSainaDataSetTableAdapters.PolzovateliTableAdapter();
            this.polzovateliTableAdapter1 = new УП_ИСРПО.KolesovaSainaDataSet1TableAdapters.PolzovateliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.polzovateliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolesovaSainaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polzovateliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolesovaSainaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Войти
            // 
            this.Войти.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Войти.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Войти.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Войти.ForeColor = System.Drawing.Color.Black;
            this.Войти.Location = new System.Drawing.Point(161, 342);
            this.Войти.Name = "Войти";
            this.Войти.Size = new System.Drawing.Size(168, 60);
            this.Войти.TabIndex = 0;
            this.Войти.Text = "Войти";
            this.Войти.UseVisualStyleBackColor = false;
            this.Войти.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(88, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.polzovateliBindingSource1;
            this.comboBox1.DisplayMember = "Login";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // polzovateliBindingSource1
            // 
            this.polzovateliBindingSource1.DataMember = "Polzovateli";
            this.polzovateliBindingSource1.DataSource = this.kolesovaSainaDataSet1;
            // 
            // kolesovaSainaDataSet1
            // 
            this.kolesovaSainaDataSet1.DataSetName = "KolesovaSainaDataSet1";
            this.kolesovaSainaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polzovateliBindingSource
            // 
            this.polzovateliBindingSource.DataMember = "Polzovateli";
            this.polzovateliBindingSource.DataSource = this.kolesovaSainaDataSet;
            // 
            // kolesovaSainaDataSet
            // 
            this.kolesovaSainaDataSet.DataSetName = "KolesovaSainaDataSet";
            this.kolesovaSainaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 4;
            // 
            // polzovateliTableAdapter
            // 
            this.polzovateliTableAdapter.ClearBeforeFill = true;
            // 
            // polzovateliTableAdapter1
            // 
            this.polzovateliTableAdapter1.ClearBeforeFill = true;
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Войти);
            this.Name = "Авторизация";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.polzovateliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolesovaSainaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polzovateliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolesovaSainaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Войти;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private KolesovaSainaDataSet kolesovaSainaDataSet;
        private System.Windows.Forms.BindingSource polzovateliBindingSource;
        private KolesovaSainaDataSetTableAdapters.PolzovateliTableAdapter polzovateliTableAdapter;
        private KolesovaSainaDataSet1 kolesovaSainaDataSet1;
        private System.Windows.Forms.BindingSource polzovateliBindingSource1;
        private KolesovaSainaDataSet1TableAdapters.PolzovateliTableAdapter polzovateliTableAdapter1;
    }
}

