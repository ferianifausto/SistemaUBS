namespace SistemaUBS.UI.Forms;

partial class FormCadastro
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
        panelCentral = new Panel();
        btnVoltar = new Button();
        btnCadastrar = new Button();
        txtEspecialidade = new TextBox();
        lblEspecialidade = new Label();
        cmbTipo = new ComboBox();
        lblTipo = new Label();
        txtSenha = new TextBox();
        lblSenha = new Label();
        txtEmail = new TextBox();
        lblEmail = new Label();
        txtNome = new TextBox();
        lblNome = new Label();
        lblTitulo = new Label();
        panelCentral.SuspendLayout();
        SuspendLayout();
        // 
        // panelCentral
        // 
        panelCentral.BackColor = Color.White;
        panelCentral.Controls.Add(btnVoltar);
        panelCentral.Controls.Add(btnCadastrar);
        panelCentral.Controls.Add(txtEspecialidade);
        panelCentral.Controls.Add(lblEspecialidade);
        panelCentral.Controls.Add(cmbTipo);
        panelCentral.Controls.Add(lblTipo);
        panelCentral.Controls.Add(txtSenha);
        panelCentral.Controls.Add(lblSenha);
        panelCentral.Controls.Add(txtEmail);
        panelCentral.Controls.Add(lblEmail);
        panelCentral.Controls.Add(txtNome);
        panelCentral.Controls.Add(lblNome);
        panelCentral.Controls.Add(lblTitulo);
        panelCentral.Location = new Point(50, 20);
        panelCentral.Name = "panelCentral";
        panelCentral.Size = new Size(300, 460);
        panelCentral.TabIndex = 0;
        // 
        // btnVoltar
        // 
        btnVoltar.FlatAppearance.BorderSize = 0;
        btnVoltar.FlatStyle = FlatStyle.Flat;
        btnVoltar.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
        btnVoltar.ForeColor = Color.Gray;
        btnVoltar.Location = new Point(30, 430);
        btnVoltar.Name = "btnVoltar";
        btnVoltar.Size = new Size(240, 25);
        btnVoltar.TabIndex = 12;
        btnVoltar.Text = "Voltar ao Login";
        btnVoltar.UseVisualStyleBackColor = true;
        btnVoltar.Click += btnVoltar_Click;
        // 
        // btnCadastrar
        // 
        btnCadastrar.BackColor = Color.FromArgb(41, 128, 185);
        btnCadastrar.FlatAppearance.BorderSize = 0;
        btnCadastrar.FlatStyle = FlatStyle.Flat;
        btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnCadastrar.ForeColor = Color.White;
        btnCadastrar.Location = new Point(30, 390);
        btnCadastrar.Name = "btnCadastrar";
        btnCadastrar.Size = new Size(240, 40);
        btnCadastrar.TabIndex = 11;
        btnCadastrar.Text = "CADASTRAR";
        btnCadastrar.UseVisualStyleBackColor = false;
        btnCadastrar.Click += btnCadastrar_Click;
        // 
        // txtEspecialidade
        // 
        txtEspecialidade.Font = new Font("Segoe UI", 12F);
        txtEspecialidade.Location = new Point(30, 350);
        txtEspecialidade.Name = "txtEspecialidade";
        txtEspecialidade.Size = new Size(240, 29);
        txtEspecialidade.TabIndex = 10;
        // 
        // lblEspecialidade
        // 
        lblEspecialidade.AutoSize = true;
        lblEspecialidade.Font = new Font("Segoe UI", 10F);
        lblEspecialidade.ForeColor = Color.Gray;
        lblEspecialidade.Location = new Point(30, 325);
        lblEspecialidade.Name = "lblEspecialidade";
        lblEspecialidade.Size = new Size(89, 19);
        lblEspecialidade.TabIndex = 9;
        lblEspecialidade.Text = "Especialidade";
        // 
        // cmbTipo
        // 
        cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipo.Font = new Font("Segoe UI", 11F);
        cmbTipo.FormattingEnabled = true;
        cmbTipo.Location = new Point(30, 290);
        cmbTipo.Name = "cmbTipo";
        cmbTipo.Size = new Size(240, 28);
        cmbTipo.TabIndex = 8;
        cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
        // 
        // lblTipo
        // 
        lblTipo.AutoSize = true;
        lblTipo.Font = new Font("Segoe UI", 10F);
        lblTipo.ForeColor = Color.Gray;
        lblTipo.Location = new Point(30, 265);
        lblTipo.Name = "lblTipo";
        lblTipo.Size = new Size(35, 19);
        lblTipo.TabIndex = 7;
        lblTipo.Text = "Tipo";
        // 
        // txtSenha
        // 
        txtSenha.Font = new Font("Segoe UI", 12F);
        txtSenha.Location = new Point(30, 225);
        txtSenha.Name = "txtSenha";
        txtSenha.PasswordChar = '*';
        txtSenha.Size = new Size(240, 29);
        txtSenha.TabIndex = 6;
        // 
        // lblSenha
        // 
        lblSenha.AutoSize = true;
        lblSenha.Font = new Font("Segoe UI", 10F);
        lblSenha.ForeColor = Color.Gray;
        lblSenha.Location = new Point(30, 200);
        lblSenha.Name = "lblSenha";
        lblSenha.Size = new Size(46, 19);
        lblSenha.TabIndex = 5;
        lblSenha.Text = "Senha";
        // 
        // txtEmail
        // 
        txtEmail.Font = new Font("Segoe UI", 12F);
        txtEmail.Location = new Point(30, 160);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(240, 29);
        txtEmail.TabIndex = 4;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new Font("Segoe UI", 10F);
        lblEmail.ForeColor = Color.Gray;
        lblEmail.Location = new Point(30, 135);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(41, 19);
        lblEmail.TabIndex = 3;
        lblEmail.Text = "Email";
        // 
        // txtNome
        // 
        txtNome.Font = new Font("Segoe UI", 12F);
        txtNome.Location = new Point(30, 95);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(240, 29);
        txtNome.TabIndex = 2;
        // 
        // lblNome
        // 
        lblNome.AutoSize = true;
        lblNome.Font = new Font("Segoe UI", 10F);
        lblNome.ForeColor = Color.Gray;
        lblNome.Location = new Point(30, 70);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(46, 19);
        lblNome.TabIndex = 1;
        lblNome.Text = "Nome";
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(26, 58, 90);
        lblTitulo.Location = new Point(85, 20);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(129, 30);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "CADASTRO";
        // 
        // FormCadastro
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 500);
        Controls.Add(panelCentral);
        Name = "FormCadastro";
        Text = "Cadastro - Sistema UBS";
        panelCentral.ResumeLayout(false);
        panelCentral.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelCentral;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblSenha;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.ComboBox cmbTipo;
    private System.Windows.Forms.Label lblEspecialidade;
    private System.Windows.Forms.TextBox txtEspecialidade;
    private System.Windows.Forms.Button btnCadastrar;
    private System.Windows.Forms.Button btnVoltar;
}