
namespace form_2._1_cadastro_conta
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.cbmsexo = new System.Windows.Forms.ComboBox();
            this.cbmestado = new System.Windows.Forms.ComboBox();
            this.txtcodid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.final_dbDataSet2 = new form_2._1_cadastro_conta.final_dbDataSet2();
            this.tabelahBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabelahTableAdapter1 = new form_2._1_cadastro_conta.final_dbDataSet2TableAdapters.tabelahTableAdapter();
            this.tableAdapterManager1 = new form_2._1_cadastro_conta.final_dbDataSet2TableAdapters.TableAdapterManager();
            this.tabelahDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.final_dbDataSet = new form_2._1_cadastro_conta.final_dbDataSet();
            this.tabelahTableAdapter = new form_2._1_cadastro_conta.final_dbDataSetTableAdapters.tabelahTableAdapter();
            this.tableAdapterManager = new form_2._1_cadastro_conta.final_dbDataSetTableAdapters.TableAdapterManager();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.final_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelahBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelahDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(55, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(55, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(55, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "sexo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(55, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "cidade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(251, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(55, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "código";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(122, 135);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(269, 20);
            this.txtemail.TabIndex = 8;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(122, 177);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(100, 20);
            this.txtcidade.TabIndex = 9;
            // 
            // cbmsexo
            // 
            this.cbmsexo.FormattingEnabled = true;
            this.cbmsexo.Location = new System.Drawing.Point(122, 217);
            this.cbmsexo.Name = "cbmsexo";
            this.cbmsexo.Size = new System.Drawing.Size(55, 21);
            this.cbmsexo.TabIndex = 10;
            this.cbmsexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbmestado
            // 
            this.cbmestado.FormattingEnabled = true;
            this.cbmestado.Location = new System.Drawing.Point(336, 174);
            this.cbmestado.Name = "cbmestado";
            this.cbmestado.Size = new System.Drawing.Size(55, 21);
            this.cbmestado.TabIndex = 11;
            this.cbmestado.SelectedIndexChanged += new System.EventHandler(this.cbmestado_SelectedIndexChanged);
            // 
            // txtcodid
            // 
            this.txtcodid.Location = new System.Drawing.Point(122, 49);
            this.txtcodid.Name = "txtcodid";
            this.txtcodid.Size = new System.Drawing.Size(69, 20);
            this.txtcodid.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "pesquisa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // final_dbDataSet2
            // 
            this.final_dbDataSet2.DataSetName = "final_dbDataSet2";
            this.final_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelahBindingSource1
            // 
            this.tabelahBindingSource1.DataMember = "tabelah";
            this.tabelahBindingSource1.DataSource = this.final_dbDataSet2;
            // 
            // tabelahTableAdapter1
            // 
            this.tabelahTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tabelahTableAdapter = this.tabelahTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = form_2._1_cadastro_conta.final_dbDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabelahDataGridView
            // 
            this.tabelahDataGridView.AllowUserToOrderColumns = true;
            this.tabelahDataGridView.AutoGenerateColumns = false;
            this.tabelahDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelahDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tabelahDataGridView.DataSource = this.tabelahBindingSource1;
            this.tabelahDataGridView.Location = new System.Drawing.Point(12, 320);
            this.tabelahDataGridView.Name = "tabelahDataGridView";
            this.tabelahDataGridView.Size = new System.Drawing.Size(622, 220);
            this.tabelahDataGridView.TabIndex = 16;
            this.tabelahDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelahDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_codid";
            this.dataGridViewTextBoxColumn1.HeaderText = "cd_codid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nm_Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "em_email";
            this.dataGridViewTextBoxColumn3.HeaderText = "em_email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cid_cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "cid_cidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "es_estado";
            this.dataGridViewTextBoxColumn5.HeaderText = "es_estado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "se_sexo";
            this.dataGridViewTextBoxColumn6.HeaderText = "se_sexo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tabelahBindingSource
            // 
            this.tabelahBindingSource.DataMember = "tabelah";
            this.tabelahBindingSource.DataSource = this.final_dbDataSet;
            // 
            // final_dbDataSet
            // 
            this.final_dbDataSet.DataSetName = "final_dbDataSet";
            this.final_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelahTableAdapter
            // 
            this.tabelahTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Table1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = form_2._1_cadastro_conta.final_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(487, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 36);
            this.button4.TabIndex = 17;
            this.button4.Text = "atualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 694);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabelahDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtcodid);
            this.Controls.Add(this.cbmestado);
            this.Controls.Add(this.cbmsexo);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.final_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelahBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelahDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.ComboBox cbmsexo;
        private System.Windows.Forms.ComboBox cbmestado;
        private System.Windows.Forms.TextBox txtcodid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private final_dbDataSet final_dbDataSet;
        private System.Windows.Forms.BindingSource tabelahBindingSource;
        private final_dbDataSetTableAdapters.tabelahTableAdapter tabelahTableAdapter;
        private final_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private final_dbDataSet2 final_dbDataSet2;
        private System.Windows.Forms.BindingSource tabelahBindingSource1;
        private final_dbDataSet2TableAdapters.tabelahTableAdapter tabelahTableAdapter1;
        private final_dbDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView tabelahDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button4;
    }
}

