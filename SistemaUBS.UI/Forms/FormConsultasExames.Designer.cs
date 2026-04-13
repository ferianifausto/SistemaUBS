namespace SistemaUBS.UI.Forms;

partial class FormConsultasExames
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tabControl = new TabControl();
        tabConsultas = new TabPage();
        gbAgendar = new GroupBox();
        btnExcluirConsulta = new Button();
        btnAgendarConsulta = new Button();
        dtpDataConsulta = new DateTimePicker();
        lblDataAgendar = new Label();
        cmbMedico = new ComboBox();
        lblMedicoAgendar = new Label();
        dgvConsultasLista = new DataGridView();
        lblConsultas = new Label();
        tabExames = new TabPage();
        gbExame = new GroupBox();
        btnSalvarExame = new Button();
        btnEditarExame = new Button();
        btnAdicionarExame = new Button();
        dtpDataExame = new DateTimePicker();
        lblDataExame = new Label();
        txtDescricao = new TextBox();
        txtResultado = new TextBox();
        label1 = new Label();
        lblDescricao = new Label();
        txtNomeExame = new TextBox();
        lblNomeExame = new Label();
        cmbConsultaRelacionada = new ComboBox();
        lblConsultaRel = new Label();
        dgvExames = new DataGridView();
        lblExames = new Label();
        tabControl.SuspendLayout();
        tabConsultas.SuspendLayout();
        gbAgendar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvConsultasLista).BeginInit();
        tabExames.SuspendLayout();
        gbExame.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvExames).BeginInit();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabConsultas);
        tabControl.Controls.Add(tabExames);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Font = new Font("Segoe UI", 11F);
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(780, 540);
        tabControl.TabIndex = 0;
        // 
        // tabConsultas
        // 
        tabConsultas.Controls.Add(gbAgendar);
        tabConsultas.Controls.Add(dgvConsultasLista);
        tabConsultas.Controls.Add(lblConsultas);
        tabConsultas.Location = new Point(4, 29);
        tabConsultas.Name = "tabConsultas";
        tabConsultas.Padding = new Padding(3);
        tabConsultas.Size = new Size(772, 507);
        tabConsultas.TabIndex = 0;
        tabConsultas.Text = "  Agendamentos de Consultas  ";
        tabConsultas.UseVisualStyleBackColor = true;
        // 
        // gbAgendar
        // 
        gbAgendar.Controls.Add(btnExcluirConsulta);
        gbAgendar.Controls.Add(btnAgendarConsulta);
        gbAgendar.Controls.Add(dtpDataConsulta);
        gbAgendar.Controls.Add(lblDataAgendar);
        gbAgendar.Controls.Add(cmbMedico);
        gbAgendar.Controls.Add(lblMedicoAgendar);
        gbAgendar.Location = new Point(20, 280);
        gbAgendar.Name = "gbAgendar";
        gbAgendar.Size = new Size(720, 181);
        gbAgendar.TabIndex = 2;
        gbAgendar.TabStop = false;
        gbAgendar.Text = "Agendar Nova Consulta";
        // 
        // btnExcluirConsulta
        // 
        btnExcluirConsulta.BackColor = Color.FromArgb(192, 0, 0);
        btnExcluirConsulta.FlatAppearance.BorderSize = 0;
        btnExcluirConsulta.FlatStyle = FlatStyle.Flat;
        btnExcluirConsulta.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnExcluirConsulta.ForeColor = Color.White;
        btnExcluirConsulta.Location = new Point(157, 126);
        btnExcluirConsulta.Name = "btnExcluirConsulta";
        btnExcluirConsulta.Size = new Size(160, 35);
        btnExcluirConsulta.TabIndex = 4;
        btnExcluirConsulta.Text = "Excluir";
        btnExcluirConsulta.UseVisualStyleBackColor = false;
        btnExcluirConsulta.Click += btnExcluirConsulta_Click;
        // 
        // btnAgendarConsulta
        // 
        btnAgendarConsulta.BackColor = Color.FromArgb(41, 128, 185);
        btnAgendarConsulta.FlatAppearance.BorderSize = 0;
        btnAgendarConsulta.FlatStyle = FlatStyle.Flat;
        btnAgendarConsulta.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnAgendarConsulta.ForeColor = Color.White;
        btnAgendarConsulta.Location = new Point(438, 126);
        btnAgendarConsulta.Name = "btnAgendarConsulta";
        btnAgendarConsulta.Size = new Size(160, 35);
        btnAgendarConsulta.TabIndex = 4;
        btnAgendarConsulta.Text = "Agendar";
        btnAgendarConsulta.UseVisualStyleBackColor = false;
        btnAgendarConsulta.Click += btnAgendarConsulta_Click;
        // 
        // dtpDataConsulta
        // 
        dtpDataConsulta.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpDataConsulta.Format = DateTimePickerFormat.Custom;
        dtpDataConsulta.Location = new Point(447, 63);
        dtpDataConsulta.Name = "dtpDataConsulta";
        dtpDataConsulta.Size = new Size(200, 27);
        dtpDataConsulta.TabIndex = 3;
        // 
        // lblDataAgendar
        // 
        lblDataAgendar.AutoSize = true;
        lblDataAgendar.Location = new Point(447, 40);
        lblDataAgendar.Name = "lblDataAgendar";
        lblDataAgendar.Size = new Size(90, 20);
        lblDataAgendar.TabIndex = 2;
        lblDataAgendar.Text = "Data e Hora";
        // 
        // cmbMedico
        // 
        cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMedico.FormattingEnabled = true;
        cmbMedico.Location = new Point(126, 65);
        cmbMedico.Name = "cmbMedico";
        cmbMedico.Size = new Size(250, 28);
        cmbMedico.TabIndex = 1;
        // 
        // lblMedicoAgendar
        // 
        lblMedicoAgendar.AutoSize = true;
        lblMedicoAgendar.Location = new Point(126, 40);
        lblMedicoAgendar.Name = "lblMedicoAgendar";
        lblMedicoAgendar.Size = new Size(140, 20);
        lblMedicoAgendar.TabIndex = 0;
        lblMedicoAgendar.Text = "Selecione o Médico";
        // 
        // dgvConsultasLista
        // 
        dgvConsultasLista.AllowUserToAddRows = false;
        dgvConsultasLista.AllowUserToDeleteRows = false;
        dgvConsultasLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvConsultasLista.BackgroundColor = Color.White;
        dgvConsultasLista.BorderStyle = BorderStyle.None;
        dgvConsultasLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvConsultasLista.Location = new Point(20, 55);
        dgvConsultasLista.Name = "dgvConsultasLista";
        dgvConsultasLista.ReadOnly = true;
        dgvConsultasLista.RowHeadersVisible = false;
        dgvConsultasLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvConsultasLista.Size = new Size(720, 200);
        dgvConsultasLista.TabIndex = 1;
        // 
        // lblConsultas
        // 
        lblConsultas.AutoSize = true;
        lblConsultas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblConsultas.ForeColor = Color.FromArgb(50, 50, 50);
        lblConsultas.Location = new Point(20, 20);
        lblConsultas.Name = "lblConsultas";
        lblConsultas.Size = new Size(170, 25);
        lblConsultas.TabIndex = 0;
        lblConsultas.Text = "Lista de Consultas";
        // 
        // tabExames
        // 
        tabExames.Controls.Add(gbExame);
        tabExames.Controls.Add(dgvExames);
        tabExames.Controls.Add(lblExames);
        tabExames.Location = new Point(4, 29);
        tabExames.Name = "tabExames";
        tabExames.Padding = new Padding(3);
        tabExames.Size = new Size(772, 507);
        tabExames.TabIndex = 1;
        tabExames.Text = "  Exames e Resultados  ";
        tabExames.UseVisualStyleBackColor = true;
        // 
        // gbExame
        // 
        gbExame.Controls.Add(btnSalvarExame);
        gbExame.Controls.Add(btnEditarExame);
        gbExame.Controls.Add(btnAdicionarExame);
        gbExame.Controls.Add(dtpDataExame);
        gbExame.Controls.Add(lblDataExame);
        gbExame.Controls.Add(txtDescricao);
        gbExame.Controls.Add(txtResultado);
        gbExame.Controls.Add(label1);
        gbExame.Controls.Add(lblDescricao);
        gbExame.Controls.Add(txtNomeExame);
        gbExame.Controls.Add(lblNomeExame);
        gbExame.Controls.Add(cmbConsultaRelacionada);
        gbExame.Controls.Add(lblConsultaRel);
        gbExame.Location = new Point(20, 220);
        gbExame.Name = "gbExame";
        gbExame.Size = new Size(720, 279);
        gbExame.TabIndex = 2;
        gbExame.TabStop = false;
        gbExame.Text = "Adicionar Novo Exame";
        // 
        // btnSalvarExame
        // 
        btnSalvarExame.BackColor = Color.MediumSeaGreen;
        btnSalvarExame.FlatAppearance.BorderSize = 0;
        btnSalvarExame.FlatStyle = FlatStyle.Flat;
        btnSalvarExame.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnSalvarExame.ForeColor = Color.White;
        btnSalvarExame.Location = new Point(556, 203);
        btnSalvarExame.Name = "btnSalvarExame";
        btnSalvarExame.Size = new Size(134, 35);
        btnSalvarExame.TabIndex = 9;
        btnSalvarExame.Text = "Salvar";
        btnSalvarExame.UseVisualStyleBackColor = false;
        btnSalvarExame.Click += btnSalvarExame_Click;
        // 
        // btnEditarExame
        // 
        btnEditarExame.BackColor = Color.DodgerBlue;
        btnEditarExame.FlatAppearance.BorderSize = 0;
        btnEditarExame.FlatStyle = FlatStyle.Flat;
        btnEditarExame.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnEditarExame.ForeColor = Color.White;
        btnEditarExame.Location = new Point(384, 203);
        btnEditarExame.Name = "btnEditarExame";
        btnEditarExame.Size = new Size(134, 35);
        btnEditarExame.TabIndex = 8;
        btnEditarExame.Text = "Editar";
        btnEditarExame.UseVisualStyleBackColor = false;
        btnEditarExame.Click += btnEditarExame_Click;
        // 
        // btnAdicionarExame
        // 
        btnAdicionarExame.BackColor = Color.FromArgb(39, 174, 96);
        btnAdicionarExame.FlatAppearance.BorderSize = 0;
        btnAdicionarExame.FlatStyle = FlatStyle.Flat;
        btnAdicionarExame.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnAdicionarExame.ForeColor = Color.White;
        btnAdicionarExame.Location = new Point(541, 51);
        btnAdicionarExame.Name = "btnAdicionarExame";
        btnAdicionarExame.Size = new Size(149, 35);
        btnAdicionarExame.TabIndex = 8;
        btnAdicionarExame.Text = "+ Novo Exame";
        btnAdicionarExame.UseVisualStyleBackColor = false;
        btnAdicionarExame.Click += btnAdicionarExame_Click;
        // 
        // dtpDataExame
        // 
        dtpDataExame.Format = DateTimePickerFormat.Short;
        dtpDataExame.Location = new Point(350, 55);
        dtpDataExame.Name = "dtpDataExame";
        dtpDataExame.Size = new Size(150, 27);
        dtpDataExame.TabIndex = 5;
        // 
        // lblDataExame
        // 
        lblDataExame.AutoSize = true;
        lblDataExame.Location = new Point(350, 30);
        lblDataExame.Name = "lblDataExame";
        lblDataExame.Size = new Size(117, 20);
        lblDataExame.TabIndex = 4;
        lblDataExame.Text = "Data Realização";
        // 
        // txtDescricao
        // 
        txtDescricao.Location = new Point(51, 177);
        txtDescricao.Multiline = true;
        txtDescricao.Name = "txtDescricao";
        txtDescricao.Size = new Size(311, 83);
        txtDescricao.TabIndex = 7;
        // 
        // txtResultado
        // 
        txtResultado.Location = new Point(350, 120);
        txtResultado.Name = "txtResultado";
        txtResultado.Size = new Size(340, 27);
        txtResultado.TabIndex = 7;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(350, 95);
        label1.Name = "label1";
        label1.Size = new Size(75, 20);
        label1.TabIndex = 6;
        label1.Text = "Resultado";
        // 
        // lblDescricao
        // 
        lblDescricao.AutoSize = true;
        lblDescricao.Location = new Point(163, 154);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Size = new Size(74, 20);
        lblDescricao.TabIndex = 6;
        lblDescricao.Text = "Descrição";
        // 
        // txtNomeExame
        // 
        txtNomeExame.Location = new Point(20, 120);
        txtNomeExame.Name = "txtNomeExame";
        txtNomeExame.Size = new Size(300, 27);
        txtNomeExame.TabIndex = 3;
        // 
        // lblNomeExame
        // 
        lblNomeExame.AutoSize = true;
        lblNomeExame.Location = new Point(20, 95);
        lblNomeExame.Name = "lblNomeExame";
        lblNomeExame.Size = new Size(120, 20);
        lblNomeExame.TabIndex = 2;
        lblNomeExame.Text = "Nome do Exame";
        // 
        // cmbConsultaRelacionada
        // 
        cmbConsultaRelacionada.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbConsultaRelacionada.FormattingEnabled = true;
        cmbConsultaRelacionada.Location = new Point(20, 55);
        cmbConsultaRelacionada.Name = "cmbConsultaRelacionada";
        cmbConsultaRelacionada.Size = new Size(300, 28);
        cmbConsultaRelacionada.TabIndex = 1;
        // 
        // lblConsultaRel
        // 
        lblConsultaRel.AutoSize = true;
        lblConsultaRel.Location = new Point(20, 30);
        lblConsultaRel.Name = "lblConsultaRel";
        lblConsultaRel.Size = new Size(152, 20);
        lblConsultaRel.TabIndex = 0;
        lblConsultaRel.Text = "Consulta Relacionada";
        // 
        // dgvExames
        // 
        dgvExames.AllowUserToAddRows = false;
        dgvExames.AllowUserToDeleteRows = false;
        dgvExames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvExames.BackgroundColor = Color.White;
        dgvExames.BorderStyle = BorderStyle.None;
        dgvExames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvExames.Location = new Point(20, 55);
        dgvExames.Name = "dgvExames";
        dgvExames.ReadOnly = true;
        dgvExames.RowHeadersVisible = false;
        dgvExames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvExames.Size = new Size(720, 150);
        dgvExames.TabIndex = 1;
        // 
        // lblExames
        // 
        lblExames.AutoSize = true;
        lblExames.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblExames.ForeColor = Color.FromArgb(50, 50, 50);
        lblExames.Location = new Point(20, 20);
        lblExames.Name = "lblExames";
        lblExames.Size = new Size(150, 25);
        lblExames.TabIndex = 0;
        lblExames.Text = "Lista de Exames";
        // 
        // FormConsultasExames
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(780, 540);
        Controls.Add(tabControl);
        Name = "FormConsultasExames";
        Text = "Consultas e Exames";
        tabControl.ResumeLayout(false);
        tabConsultas.ResumeLayout(false);
        tabConsultas.PerformLayout();
        gbAgendar.ResumeLayout(false);
        gbAgendar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvConsultasLista).EndInit();
        tabExames.ResumeLayout(false);
        tabExames.PerformLayout();
        gbExame.ResumeLayout(false);
        gbExame.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvExames).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabConsultas;
    private System.Windows.Forms.TabPage tabExames;

    // Controles Consultas
    private System.Windows.Forms.Label lblConsultas;
    private System.Windows.Forms.DataGridView dgvConsultasLista;
    private System.Windows.Forms.GroupBox gbAgendar;
    private System.Windows.Forms.Label lblMedicoAgendar;
    private System.Windows.Forms.ComboBox cmbMedico;
    private System.Windows.Forms.Label lblDataAgendar;
    private System.Windows.Forms.DateTimePicker dtpDataConsulta;
    private System.Windows.Forms.Button btnAgendarConsulta;

    // Controles Exames
    private System.Windows.Forms.Label lblExames;
    private System.Windows.Forms.DataGridView dgvExames;
    private System.Windows.Forms.GroupBox gbExame;
    private System.Windows.Forms.Label lblConsultaRel;
    private System.Windows.Forms.ComboBox cmbConsultaRelacionada;
    private System.Windows.Forms.Label lblNomeExame;
    private System.Windows.Forms.TextBox txtNomeExame;
    private System.Windows.Forms.Label lblDescricao;
    private System.Windows.Forms.TextBox txtResultado;
    private System.Windows.Forms.Label lblDataExame;
    private System.Windows.Forms.DateTimePicker dtpDataExame;
    private System.Windows.Forms.Button btnAdicionarExame;
    private TextBox txtDescricao;
    private Label label1;
    private Button btnExcluirConsulta;
    private Button btnEditarExame;
    private Button btnSalvarExame;
}