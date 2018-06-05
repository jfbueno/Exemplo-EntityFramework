namespace ExemploEntityFramework
{
    partial class FormCadastroFuncionario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeOffice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Equipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkHomeOffice = new System.Windows.Forms.CheckBox();
            this.groupEquip = new System.Windows.Forms.GroupBox();
            this.tbTablet = new System.Windows.Forms.RadioButton();
            this.rbNotebook = new System.Windows.Forms.RadioButton();
            this.rbComputador = new System.Windows.Forms.RadioButton();
            this.btDelete = new System.Windows.Forms.Button();
            this.btVer = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupEquip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Idade,
            this.HomeOffice,
            this.Equipamento});
            this.dataGridView1.Location = new System.Drawing.Point(12, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(512, 132);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "Idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            this.Idade.Width = 50;
            // 
            // HomeOffice
            // 
            this.HomeOffice.DataPropertyName = "HomeOffice";
            this.HomeOffice.HeaderText = "Home Office";
            this.HomeOffice.Name = "HomeOffice";
            this.HomeOffice.ReadOnly = true;
            this.HomeOffice.Width = 50;
            // 
            // Equipamento
            // 
            this.Equipamento.DataPropertyName = "Equipamento";
            this.Equipamento.HeaderText = "Equipamento";
            this.Equipamento.Name = "Equipamento";
            this.Equipamento.ReadOnly = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(6, 113);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(109, 32);
            this.btCadastrar.TabIndex = 1;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 21);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Idade";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(262, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(89, 21);
            this.numericUpDown1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHomeOffice);
            this.groupBox1.Controls.Add(this.groupEquip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btCadastrar);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // chkHomeOffice
            // 
            this.chkHomeOffice.AutoSize = true;
            this.chkHomeOffice.Location = new System.Drawing.Point(6, 64);
            this.chkHomeOffice.Name = "chkHomeOffice";
            this.chkHomeOffice.Size = new System.Drawing.Size(96, 17);
            this.chkHomeOffice.TabIndex = 9;
            this.chkHomeOffice.Text = "Home Office";
            this.chkHomeOffice.UseVisualStyleBackColor = true;
            // 
            // groupEquip
            // 
            this.groupEquip.Controls.Add(this.tbTablet);
            this.groupEquip.Controls.Add(this.rbNotebook);
            this.groupEquip.Controls.Add(this.rbComputador);
            this.groupEquip.Location = new System.Drawing.Point(357, 17);
            this.groupEquip.Name = "groupEquip";
            this.groupEquip.Size = new System.Drawing.Size(200, 89);
            this.groupEquip.TabIndex = 8;
            this.groupEquip.TabStop = false;
            this.groupEquip.Text = "Equipamento";
            // 
            // tbTablet
            // 
            this.tbTablet.AutoSize = true;
            this.tbTablet.Location = new System.Drawing.Point(6, 69);
            this.tbTablet.Name = "tbTablet";
            this.tbTablet.Size = new System.Drawing.Size(59, 17);
            this.tbTablet.TabIndex = 9;
            this.tbTablet.TabStop = true;
            this.tbTablet.Tag = "3";
            this.tbTablet.Text = "Tablet";
            this.tbTablet.UseVisualStyleBackColor = true;
            // 
            // rbNotebook
            // 
            this.rbNotebook.AutoSize = true;
            this.rbNotebook.Location = new System.Drawing.Point(6, 46);
            this.rbNotebook.Name = "rbNotebook";
            this.rbNotebook.Size = new System.Drawing.Size(79, 17);
            this.rbNotebook.TabIndex = 8;
            this.rbNotebook.TabStop = true;
            this.rbNotebook.Tag = "2";
            this.rbNotebook.Text = "Notebook";
            this.rbNotebook.UseVisualStyleBackColor = true;
            // 
            // rbComputador
            // 
            this.rbComputador.AutoSize = true;
            this.rbComputador.Location = new System.Drawing.Point(6, 23);
            this.rbComputador.Name = "rbComputador";
            this.rbComputador.Size = new System.Drawing.Size(123, 17);
            this.rbComputador.TabIndex = 7;
            this.rbComputador.TabStop = true;
            this.rbComputador.Tag = "1";
            this.rbComputador.Text = "Computador Fixo";
            this.rbComputador.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Image = global::ExemploEntityFramework.Properties.Resources.delete;
            this.btDelete.Location = new System.Drawing.Point(530, 318);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(45, 40);
            this.btDelete.TabIndex = 10;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btVer
            // 
            this.btVer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVer.Image = global::ExemploEntityFramework.Properties.Resources.magnify;
            this.btVer.Location = new System.Drawing.Point(530, 272);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(45, 40);
            this.btVer.TabIndex = 9;
            this.btVer.UseVisualStyleBackColor = false;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Image = global::ExemploEntityFramework.Properties.Resources.refresh;
            this.btRefresh.Location = new System.Drawing.Point(530, 226);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(45, 40);
            this.btRefresh.TabIndex = 8;
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // FormCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 368);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btVer);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.FormCadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupEquip.ResumeLayout(false);
            this.groupEquip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupEquip;
        private System.Windows.Forms.RadioButton tbTablet;
        private System.Windows.Forms.RadioButton rbNotebook;
        private System.Windows.Forms.RadioButton rbComputador;
        private System.Windows.Forms.CheckBox chkHomeOffice;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btVer;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HomeOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipamento;
    }
}

