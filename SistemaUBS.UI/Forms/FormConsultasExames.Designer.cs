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
        this.tabControl = new System.Windows.Forms.TabControl();
        this.tabConsultas = new System.Windows.Forms.TabPage();
        this.tabExames = new System.Windows.Forms.TabPage();

        // Consultas
        this.lblConsultas = new System.Windows.Forms.Label();
        this.dgvConsultasLista = new System.Windows.Forms.DataGridView();
        this.gbAgendar = new System.Windows.Forms.GroupBox();
        this.lblMedicoAgendar = new System.Windows.Forms.Label();
        this.cmbMedico = new System.Windows.Forms.ComboBox();
        this.lblDataAgendar = new System.Windows.Forms.Label();
        this.dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
        this.btnAgendarConsulta = new System.Windows.Forms.Button();

        // Exames
        this.lblExames = new System.Windows.Forms.Label();
        this.dgvExames = new System.Windows.Forms.DataGridView();
        this.gbExame = new System.Windows.Forms.GroupBox();
        this.lblConsultaRel = new System.Windows.Forms.Label();
        this.cmbConsultaRelacionada = new System.Windows.Forms.ComboBox();
        this.lblNomeExame = new System.Windows.Forms.Label();
        this.txtNomeExame = new System.Windows.Forms.TextBox();
        this.lblResultado = new System.Windows.Forms.Label();
        this.txtResultado = new System.Windows.Forms.TextBox();
        this.lblDataExame = new System.Windows.Forms.Label();
        this.dtpDataExame = new System.Windows.Forms.DateTimePicker();
        this.btnAdicionarExame = new System.Windows.Forms.Button();

        this.tabControl.SuspendLayout();
        this.tabConsultas.SuspendLayout();
        this.tabExames.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasLista)).BeginInit();
        this.gbAgendar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).BeginInit();
        this.gbExame.SuspendLayout();
        this.SuspendLayout();

        // tabControl
        this.tabControl.Controls.Add(this.tabConsultas);
        this.tabControl.Controls.Add(this.tabExames);
        this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl.Location = new System.Drawing.Point(0, 0);
        this.tabControl.Name = "tabControl";
        this.tabControl.SelectedIndex = 0;
        this.tabControl.Size = new System.Drawing.Size(780, 540);
        this.tabControl.TabIndex = 0;
        this.tabControl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

        // tabConsultas
        this.tabConsultas.Controls.Add(this.gbAgendar);
        this.tabConsultas.Controls.Add(this.dgvConsultasLista);
        this.tabConsultas.Controls.Add(this.lblConsultas);
        this.tabConsultas.Location = new System.Drawing.Point(4, 29);
        this.tabConsultas.Name = "tabConsultas";
        this.tabConsultas.Padding = new System.Windows.Forms.Padding(3);
        this.tabConsultas.Size = new System.Drawing.Size(772, 507);
        this.tabConsultas.TabIndex = 0;
        this.tabConsultas.Text = "  Agendamentos de Consultas  ";
        this.tabConsultas.UseVisualStyleBackColor = true;

        // lblConsultas
        this.lblConsultas.AutoSize = true;
        this.lblConsultas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
        this.lblConsultas.Location = new System.Drawing.Point(20, 20);
        this.lblConsultas.Name = "lblConsultas";
        this.lblConsultas.Size = new System.Drawing.Size(161, 25);
        this.lblConsultas.TabIndex = 0;
        this.lblConsultas.Text = "Lista de Consultas";

        // dgvConsultasLista
        this.dgvConsultasLista.AllowUserToAddRows = false;
        this.dgvConsultasLista.AllowUserToDeleteRows = false;
        this.dgvConsultasLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvConsultasLista.BackgroundColor = System.Drawing.Color.White;
        this.dgvConsultasLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvConsultasLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvConsultasLista.Location = new System.Drawing.Point(20, 55);
        this.dgvConsultasLista.Name = "dgvConsultasLista";
        this.dgvConsultasLista.ReadOnly = true;
        this.dgvConsultasLista.RowHeadersVisible = false;
        this.dgvConsultasLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvConsultasLista.Size = new System.Drawing.Size(720, 200);
        this.dgvConsultasLista.TabIndex = 1;

        // gbAgendar
        this.gbAgendar.Controls.Add(this.btnAgendarConsulta);
        this.gbAgendar.Controls.Add(this.dtpDataConsulta);
        this.gbAgendar.Controls.Add(this.lblDataAgendar);
        this.gbAgendar.Controls.Add(this.cmbMedico);
        this.gbAgendar.Controls.Add(this.lblMedicoAgendar);
        this.gbAgendar.Location = new System.Drawing.Point(20, 280);
        this.gbAgendar.Name = "gbAgendar";
        this.gbAgendar.Size = new System.Drawing.Size(720, 150);
        this.gbAgendar.TabIndex = 2;
        this.gbAgendar.TabStop = false;
        this.gbAgendar.Text = "Agendar Nova Consulta";

        // lblMedicoAgendar
        this.lblMedicoAgendar.AutoSize = true;
        this.lblMedicoAgendar.Location = new System.Drawing.Point(20, 40);
        this.lblMedicoAgendar.Name = "lblMedicoAgendar";
        this.lblMedicoAgendar.Size = new System.Drawing.Size(130, 20);
        this.lblMedicoAgendar.TabIndex = 0;
        this.lblMedicoAgendar.Text = "Selecione o Médico";

        // cmbMedico
        this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbMedico.FormattingEnabled = true;
        this.cmbMedico.Location = new System.Drawing.Point(20, 65);
        this.cmbMedico.Name = "cmbMedico";
        this.cmbMedico.Size = new System.Drawing.Size(250, 28);
        this.cmbMedico.TabIndex = 1;

        // lblDataAgendar
        this.lblDataAgendar.AutoSize = true;
        this.lblDataAgendar.Location = new System.Drawing.Point(300, 40);
        this.lblDataAgendar.Name = "lblDataAgendar";
        this.lblDataAgendar.Size = new System.Drawing.Size(89, 20);
        this.lblDataAgendar.TabIndex = 2;
        this.lblDataAgendar.Text = "Data e Hora";

        // dtpDataConsulta
        this.dtpDataConsulta.CustomFormat = "dd/MM/yyyy HH:mm";
        this.dtpDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpDataConsulta.Location = new System.Drawing.Point(300, 65);
        this.dtpDataConsulta.Name = "dtpDataConsulta";
        this.dtpDataConsulta.Size = new System.Drawing.Size(200, 27);
        this.dtpDataConsulta.TabIndex = 3;

        // btnAgendarConsulta
        this.btnAgendarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
        this.btnAgendarConsulta.FlatAppearance.BorderSize = 0;
        this.btnAgendarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAgendarConsulta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnAgendarConsulta.ForeColor = System.Drawing.Color.White;
        this.btnAgendarConsulta.Location = new System.Drawing.Point(530, 60);
        this.btnAgendarConsulta.Name = "btnAgendarConsulta";
        this.btnAgendarConsulta.Size = new System.Drawing.Size(160, 35);
        this.btnAgendarConsulta.TabIndex = 4;
        this.btnAgendarConsulta.Text = "Agendar";
        this.btnAgendarConsulta.UseVisualStyleBackColor = false;
        this.btnAgendarConsulta.Click += new System.EventHandler(this.btnAgendarConsulta_Click);


        // tabExames
        this.tabExames.Controls.Add(this.gbExame);
        this.tabExames.Controls.Add(this.dgvExames);
        this.tabExames.Controls.Add(this.lblExames);
        this.tabExames.Location = new System.Drawing.Point(4, 29);
        this.tabExames.Name = "tabExames";
        this.tabExames.Padding = new System.Windows.Forms.Padding(3);
        this.tabExames.Size = new System.Drawing.Size(772, 507);
        this.tabExames.TabIndex = 1;
        this.tabExames.Text = "  Exames e Resultados  ";
        this.tabExames.UseVisualStyleBackColor = true;

        // lblExames
        this.lblExames.AutoSize = true;
        this.lblExames.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblExames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
        this.lblExames.Location = new System.Drawing.Point(20, 20);
        this.lblExames.Name = "lblExames";
        this.lblExames.Size = new System.Drawing.Size(155, 25);
        this.lblExames.TabIndex = 0;
        this.lblExames.Text = "Lista de Exames";

        // dgvExames
        this.dgvExames.AllowUserToAddRows = false;
        this.dgvExames.AllowUserToDeleteRows = false;
        this.dgvExames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvExames.BackgroundColor = System.Drawing.Color.White;
        this.dgvExames.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvExames.Location = new System.Drawing.Point(20, 55);
        this.dgvExames.Name = "dgvExames";
        this.dgvExames.ReadOnly = true;
        this.dgvExames.RowHeadersVisible = false;
        this.dgvExames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvExames.Size = new System.Drawing.Size(720, 150);
        this.dgvExames.TabIndex = 1;

        // gbExame
        this.gbExame.Controls.Add(this.btnAdicionarExame);
        this.gbExame.Controls.Add(this.dtpDataExame);
        this.gbExame.Controls.Add(this.lblDataExame);
        this.gbExame.Controls.Add(this.txtResultado);
        this.gbExame.Controls.Add(this.lblResultado);
        this.gbExame.Controls.Add(this.txtNomeExame);
        this.gbExame.Controls.Add(this.lblNomeExame);
        this.gbExame.Controls.Add(this.cmbConsultaRelacionada);
        this.gbExame.Controls.Add(this.lblConsultaRel);
        this.gbExame.Location = new System.Drawing.Point(20, 220);
        this.gbExame.Name = "gbExame";
        this.gbExame.Size = new System.Drawing.Size(720, 200);
        this.gbExame.TabIndex = 2;
        this.gbExame.TabStop = false;
        this.gbExame.Text = "Adicionar Novo Exame";

        // lblConsultaRel
        this.lblConsultaRel.AutoSize = true;
        this.lblConsultaRel.Location = new System.Drawing.Point(20, 30);
        this.lblConsultaRel.Name = "lblConsultaRel";
        this.lblConsultaRel.Size = new System.Drawing.Size(149, 20);
        this.lblConsultaRel.TabIndex = 0;
        this.lblConsultaRel.Text = "Consulta Relacionada";

        // cmbConsultaRelacionada
        this.cmbConsultaRelacionada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbConsultaRelacionada.FormattingEnabled = true;
        this.cmbConsultaRelacionada.Location = new System.Drawing.Point(20, 55);
        this.cmbConsultaRelacionada.Name = "cmbConsultaRelacionada";
        this.cmbConsultaRelacionada.Size = new System.Drawing.Size(300, 28);
        this.cmbConsultaRelacionada.TabIndex = 1;

        // lblNomeExame
        this.lblNomeExame.AutoSize = true;
        this.lblNomeExame.Location = new System.Drawing.Point(20, 95);
        this.lblNomeExame.Name = "lblNomeExame";
        this.lblNomeExame.Size = new System.Drawing.Size(120, 20);
        this.lblNomeExame.TabIndex = 2;
        this.lblNomeExame.Text = "Nome do Exame";

        // txtNomeExame
        this.txtNomeExame.Location = new System.Drawing.Point(20, 120);
        this.txtNomeExame.Name = "txtNomeExame";
        this.txtNomeExame.Size = new System.Drawing.Size(300, 27);
        this.txtNomeExame.TabIndex = 3;

        // lblDataExame
        this.lblDataExame.AutoSize = true;
        this.lblDataExame.Location = new System.Drawing.Point(350, 30);
        this.lblDataExame.Name = "lblDataExame";
        this.lblDataExame.Size = new System.Drawing.Size(117, 20);
        this.lblDataExame.TabIndex = 4;
        this.lblDataExame.Text = "Data Realização";

        // dtpDataExame
        this.dtpDataExame.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpDataExame.Location = new System.Drawing.Point(350, 55);
        this.dtpDataExame.Name = "dtpDataExame";
        this.dtpDataExame.Size = new System.Drawing.Size(150, 27);
        this.dtpDataExame.TabIndex = 5;

        // lblResultado
        this.lblResultado.AutoSize = true;
        this.lblResultado.Location = new System.Drawing.Point(350, 95);
        this.lblResultado.Name = "lblResultado";
        this.lblResultado.Size = new System.Drawing.Size(75, 20);
        this.lblResultado.TabIndex = 6;
        this.lblResultado.Text = "Resultado";

        // txtResultado
        this.txtResultado.Location = new System.Drawing.Point(350, 120);
        this.txtResultado.Name = "txtResultado";
        this.txtResultado.Size = new System.Drawing.Size(340, 27);
        this.txtResultado.TabIndex = 7;

        // btnAdicionarExame
        this.btnAdicionarExame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
        this.btnAdicionarExame.FlatAppearance.BorderSize = 0;
        this.btnAdicionarExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAdicionarExame.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnAdicionarExame.ForeColor = System.Drawing.Color.White;
        this.btnAdicionarExame.Location = new System.Drawing.Point(530, 45);
        this.btnAdicionarExame.Name = "btnAdicionarExame";
        this.btnAdicionarExame.Size = new System.Drawing.Size(160, 35);
        this.btnAdicionarExame.TabIndex = 8;
        this.btnAdicionarExame.Text = "+ Novo Exame";
        this.btnAdicionarExame.UseVisualStyleBackColor = false;
        this.btnAdicionarExame.Click += new System.EventHandler(this.btnAdicionarExame_Click);


        // FormConsultasExames
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(780, 540);
        this.Controls.Add(this.tabControl);
        this.Name = "FormConsultasExames";
        this.Text = "Consultas e Exames";

        this.tabControl.ResumeLayout(false);
        this.tabConsultas.ResumeLayout(false);
        this.tabConsultas.PerformLayout();
        this.tabExames.ResumeLayout(false);
        this.tabExames.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasLista)).EndInit();
        this.gbAgendar.ResumeLayout(false);
        this.gbAgendar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).EndInit();
        this.gbExame.ResumeLayout(false);
        this.gbExame.PerformLayout();
        this.ResumeLayout(false);
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
    private System.Windows.Forms.Label lblResultado;
    private System.Windows.Forms.TextBox txtResultado;
    private System.Windows.Forms.Label lblDataExame;
    private System.Windows.Forms.DateTimePicker dtpDataExame;
    private System.Windows.Forms.Button btnAdicionarExame;
}