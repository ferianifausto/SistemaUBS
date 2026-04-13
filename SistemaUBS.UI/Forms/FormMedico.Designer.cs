namespace SistemaUBS.UI.Forms;

partial class FormMedico
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
        panelCard = new Panel();
        lblCRM = new Label();
        lblEspecialidade = new Label();
        lblNome = new Label();
        lblTituloCartao = new Label();
        lblConsultas = new Label();
        dgvPacientes = new DataGridView();
        btnDarDiagnostico = new Button();
        panelCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
        SuspendLayout();
        // 
        // panelCard
        // 
        panelCard.BackColor = Color.White;
        panelCard.Controls.Add(lblCRM);
        panelCard.Controls.Add(lblEspecialidade);
        panelCard.Controls.Add(lblNome);
        panelCard.Controls.Add(lblTituloCartao);
        panelCard.Location = new Point(30, 30);
        panelCard.Name = "panelCard";
        panelCard.Size = new Size(350, 150);
        panelCard.TabIndex = 0;
        // 
        // lblCRM
        // 
        lblCRM.AutoSize = true;
        lblCRM.Font = new Font("Segoe UI", 10F);
        lblCRM.ForeColor = Color.Gray;
        lblCRM.Location = new Point(20, 115);
        lblCRM.Name = "lblCRM";
        lblCRM.Size = new Size(39, 19);
        lblCRM.TabIndex = 3;
        lblCRM.Text = "CRM";
        // 
        // lblEspecialidade
        // 
        lblEspecialidade.AutoSize = true;
        lblEspecialidade.Font = new Font("Segoe UI", 10F);
        lblEspecialidade.ForeColor = Color.Gray;
        lblEspecialidade.Location = new Point(20, 90);
        lblEspecialidade.Name = "lblEspecialidade";
        lblEspecialidade.Size = new Size(89, 19);
        lblEspecialidade.TabIndex = 2;
        lblEspecialidade.Text = "Especialidade";
        // 
        // lblNome
        // 
        lblNome.AutoSize = true;
        lblNome.Font = new Font("Segoe UI", 14F);
        lblNome.Location = new Point(20, 60);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(63, 25);
        lblNome.TabIndex = 1;
        lblNome.Text = "Nome";
        // 
        // lblTituloCartao
        // 
        lblTituloCartao.AutoSize = true;
        lblTituloCartao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTituloCartao.ForeColor = Color.FromArgb(41, 128, 185);
        lblTituloCartao.Location = new Point(20, 20);
        lblTituloCartao.Name = "lblTituloCartao";
        lblTituloCartao.Size = new Size(159, 21);
        lblTituloCartao.TabIndex = 0;
        lblTituloCartao.Text = "Dados Profissionais";
        // 
        // lblConsultas
        // 
        lblConsultas.AutoSize = true;
        lblConsultas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblConsultas.ForeColor = Color.FromArgb(50, 50, 50);
        lblConsultas.Location = new Point(30, 220);
        lblConsultas.Name = "lblConsultas";
        lblConsultas.Size = new Size(167, 25);
        lblConsultas.TabIndex = 1;
        lblConsultas.Text = "Minhas Consultas";
        // 
        // dgvPacientes
        // 
        dgvPacientes.AllowUserToAddRows = false;
        dgvPacientes.AllowUserToDeleteRows = false;
        dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPacientes.BackgroundColor = Color.White;
        dgvPacientes.BorderStyle = BorderStyle.None;
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPacientes.Location = new Point(30, 260);
        dgvPacientes.Name = "dgvPacientes";
        dgvPacientes.ReadOnly = true;
        dgvPacientes.RowHeadersVisible = false;
        dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPacientes.Size = new Size(700, 250);
        dgvPacientes.TabIndex = 2;
        // 
        // btnDarDiagnostico
        // 
        btnDarDiagnostico.BackColor = Color.FromArgb(39, 174, 96);
        btnDarDiagnostico.FlatAppearance.BorderSize = 0;
        btnDarDiagnostico.FlatStyle = FlatStyle.Flat;
        btnDarDiagnostico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnDarDiagnostico.ForeColor = Color.White;
        btnDarDiagnostico.Location = new Point(530, 215);
        btnDarDiagnostico.Name = "btnDarDiagnostico";
        btnDarDiagnostico.Size = new Size(200, 35);
        btnDarDiagnostico.TabIndex = 3;
        btnDarDiagnostico.Text = "+ Inserir Diagnóstico";
        btnDarDiagnostico.UseVisualStyleBackColor = false;
        btnDarDiagnostico.Click += btnDarDiagnostico_Click;
        // 
        // FormMedico
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(780, 540);
        Controls.Add(btnDarDiagnostico);
        Controls.Add(dgvPacientes);
        Controls.Add(lblConsultas);
        Controls.Add(panelCard);
        Name = "FormMedico";
        Text = "Área do Médico";
        panelCard.ResumeLayout(false);
        panelCard.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel panelCard;
    private System.Windows.Forms.Label lblTituloCartao;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.Label lblEspecialidade;
    private System.Windows.Forms.Label lblCRM;
    private System.Windows.Forms.Label lblConsultas;
    private System.Windows.Forms.DataGridView dgvPacientes;
    private System.Windows.Forms.Button btnDarDiagnostico;
}
