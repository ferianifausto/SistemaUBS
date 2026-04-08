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
        this.panelCard = new System.Windows.Forms.Panel();
        this.lblTituloCartao = new System.Windows.Forms.Label();
        this.lblNome = new System.Windows.Forms.Label();
        this.lblEspecialidade = new System.Windows.Forms.Label();
        this.lblCRM = new System.Windows.Forms.Label();

        this.lblConsultas = new System.Windows.Forms.Label();
        this.dgvPacientes = new System.Windows.Forms.DataGridView();
        this.btnDarDiagnostico = new System.Windows.Forms.Button();

        this.panelCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
        this.SuspendLayout();

        // panelCard
        this.panelCard.BackColor = System.Drawing.Color.White;
        this.panelCard.Controls.Add(this.lblCRM);
        this.panelCard.Controls.Add(this.lblEspecialidade);
        this.panelCard.Controls.Add(this.lblNome);
        this.panelCard.Controls.Add(this.lblTituloCartao);
        this.panelCard.Location = new System.Drawing.Point(30, 30);
        this.panelCard.Name = "panelCard";
        this.panelCard.Size = new System.Drawing.Size(350, 150);
        this.panelCard.TabIndex = 0;

        // lblTituloCartao
        this.lblTituloCartao.AutoSize = true;
        this.lblTituloCartao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTituloCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
        this.lblTituloCartao.Location = new System.Drawing.Point(20, 20);
        this.lblTituloCartao.Name = "lblTituloCartao";
        this.lblTituloCartao.Size = new System.Drawing.Size(127, 21);
        this.lblTituloCartao.TabIndex = 0;
        this.lblTituloCartao.Text = "Dados Profissionais";

        // lblNome
        this.lblNome.AutoSize = true;
        this.lblNome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblNome.Location = new System.Drawing.Point(20, 60);
        this.lblNome.Name = "lblNome";
        this.lblNome.Size = new System.Drawing.Size(63, 25);
        this.lblNome.TabIndex = 1;
        this.lblNome.Text = "Nome";

        // lblEspecialidade
        this.lblEspecialidade.AutoSize = true;
        this.lblEspecialidade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblEspecialidade.ForeColor = System.Drawing.Color.Gray;
        this.lblEspecialidade.Location = new System.Drawing.Point(20, 90);
        this.lblEspecialidade.Name = "lblEspecialidade";
        this.lblEspecialidade.Size = new System.Drawing.Size(89, 19);
        this.lblEspecialidade.TabIndex = 2;
        this.lblEspecialidade.Text = "Especialidade";

        // lblCRM
        this.lblCRM.AutoSize = true;
        this.lblCRM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblCRM.ForeColor = System.Drawing.Color.Gray;
        this.lblCRM.Location = new System.Drawing.Point(20, 115);
        this.lblCRM.Name = "lblCRM";
        this.lblCRM.Size = new System.Drawing.Size(38, 19);
        this.lblCRM.TabIndex = 3;
        this.lblCRM.Text = "CRM";

        // lblConsultas
        this.lblConsultas.AutoSize = true;
        this.lblConsultas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
        this.lblConsultas.Location = new System.Drawing.Point(30, 220);
        this.lblConsultas.Name = "lblConsultas";
        this.lblConsultas.Size = new System.Drawing.Size(183, 25);
        this.lblConsultas.TabIndex = 1;
        this.lblConsultas.Text = "Minhas Consultas";

        // btnDarDiagnostico
        this.btnDarDiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
        this.btnDarDiagnostico.FlatAppearance.BorderSize = 0;
        this.btnDarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDarDiagnostico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnDarDiagnostico.ForeColor = System.Drawing.Color.White;
        this.btnDarDiagnostico.Location = new System.Drawing.Point(530, 215);
        this.btnDarDiagnostico.Name = "btnDarDiagnostico";
        this.btnDarDiagnostico.Size = new System.Drawing.Size(200, 35);
        this.btnDarDiagnostico.TabIndex = 3;
        this.btnDarDiagnostico.Text = "+ Inserir Diagnóstico";
        this.btnDarDiagnostico.UseVisualStyleBackColor = false;
        this.btnDarDiagnostico.Click += new System.EventHandler(this.btnDarDiagnostico_Click);

        // dgvPacientes
        this.dgvPacientes.AllowUserToAddRows = false;
        this.dgvPacientes.AllowUserToDeleteRows = false;
        this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
        this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvPacientes.Location = new System.Drawing.Point(30, 260);
        this.dgvPacientes.Name = "dgvPacientes";
        this.dgvPacientes.ReadOnly = true;
        this.dgvPacientes.RowHeadersVisible = false;
        this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvPacientes.Size = new System.Drawing.Size(700, 250);
        this.dgvPacientes.TabIndex = 2;

        // FormMedico
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(780, 540);
        this.Controls.Add(this.btnDarDiagnostico);
        this.Controls.Add(this.dgvPacientes);
        this.Controls.Add(this.lblConsultas);
        this.Controls.Add(this.panelCard);
        this.Name = "FormMedico";
        this.Text = "Área do Médico";
        this.panelCard.ResumeLayout(false);
        this.panelCard.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
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
