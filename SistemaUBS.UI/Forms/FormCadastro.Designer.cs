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
        this.panelCentral = new System.Windows.Forms.Panel();
        this.lblTitulo = new System.Windows.Forms.Label();

        this.lblNome = new System.Windows.Forms.Label();
        this.txtNome = new System.Windows.Forms.TextBox();

        this.lblEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();

        this.lblSenha = new System.Windows.Forms.Label();
        this.txtSenha = new System.Windows.Forms.TextBox();

        this.lblTipo = new System.Windows.Forms.Label();
        this.cmbTipo = new System.Windows.Forms.ComboBox();

        this.lblEspecialidade = new System.Windows.Forms.Label();
        this.txtEspecialidade = new System.Windows.Forms.TextBox();

        this.btnCadastrar = new System.Windows.Forms.Button();
        this.btnVoltar = new System.Windows.Forms.Button();

        this.panelCentral.SuspendLayout();
        this.SuspendLayout();

        // panelCentral
        this.panelCentral.BackColor = System.Drawing.Color.White;
        this.panelCentral.Controls.Add(this.btnVoltar);
        this.panelCentral.Controls.Add(this.btnCadastrar);
        this.panelCentral.Controls.Add(this.txtEspecialidade);
        this.panelCentral.Controls.Add(this.lblEspecialidade);
        this.panelCentral.Controls.Add(this.cmbTipo);
        this.panelCentral.Controls.Add(this.lblTipo);
        this.panelCentral.Controls.Add(this.txtSenha);
        this.panelCentral.Controls.Add(this.lblSenha);
        this.panelCentral.Controls.Add(this.txtEmail);
        this.panelCentral.Controls.Add(this.lblEmail);
        this.panelCentral.Controls.Add(this.txtNome);
        this.panelCentral.Controls.Add(this.lblNome);
        this.panelCentral.Controls.Add(this.lblTitulo);
        this.panelCentral.Location = new System.Drawing.Point(50, 20);
        this.panelCentral.Name = "panelCentral";
        this.panelCentral.Size = new System.Drawing.Size(300, 460);
        this.panelCentral.TabIndex = 0;

        // lblTitulo
        this.lblTitulo.AutoSize = true;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(26, 58, 90);
        this.lblTitulo.Location = new System.Drawing.Point(85, 20);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(129, 30);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "CADASTRO";

        // lblNome
        this.lblNome.AutoSize = true;
        this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblNome.ForeColor = System.Drawing.Color.Gray;
        this.lblNome.Location = new System.Drawing.Point(30, 70);
        this.lblNome.Name = "lblNome";
        this.lblNome.Size = new System.Drawing.Size(46, 19);
        this.lblNome.TabIndex = 1;
        this.lblNome.Text = "Nome";

        // txtNome
        this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtNome.Location = new System.Drawing.Point(30, 95);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(240, 29);
        this.txtNome.TabIndex = 2;

        // lblEmail
        this.lblEmail.AutoSize = true;
        this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblEmail.ForeColor = System.Drawing.Color.Gray;
        this.lblEmail.Location = new System.Drawing.Point(30, 135);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(41, 19);
        this.lblEmail.TabIndex = 3;
        this.lblEmail.Text = "Email";

        // txtEmail
        this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtEmail.Location = new System.Drawing.Point(30, 160);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(240, 29);
        this.txtEmail.TabIndex = 4;

        // lblSenha
        this.lblSenha.AutoSize = true;
        this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblSenha.ForeColor = System.Drawing.Color.Gray;
        this.lblSenha.Location = new System.Drawing.Point(30, 200);
        this.lblSenha.Name = "lblSenha";
        this.lblSenha.Size = new System.Drawing.Size(46, 19);
        this.lblSenha.TabIndex = 5;
        this.lblSenha.Text = "Senha";

        // txtSenha
        this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtSenha.Location = new System.Drawing.Point(30, 225);
        this.txtSenha.Name = "txtSenha";
        this.txtSenha.PasswordChar = '*';
        this.txtSenha.Size = new System.Drawing.Size(240, 29);
        this.txtSenha.TabIndex = 6;

        // lblTipo
        this.lblTipo.AutoSize = true;
        this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblTipo.ForeColor = System.Drawing.Color.Gray;
        this.lblTipo.Location = new System.Drawing.Point(30, 265);
        this.lblTipo.Name = "lblTipo";
        this.lblTipo.Size = new System.Drawing.Size(35, 19);
        this.lblTipo.TabIndex = 7;
        this.lblTipo.Text = "Tipo";

        // cmbTipo
        this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.cmbTipo.FormattingEnabled = true;
        this.cmbTipo.Location = new System.Drawing.Point(30, 290);
        this.cmbTipo.Name = "cmbTipo";
        this.cmbTipo.Size = new System.Drawing.Size(240, 28);
        this.cmbTipo.TabIndex = 8;
        this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);

        // lblEspecialidade
        this.lblEspecialidade.AutoSize = true;
        this.lblEspecialidade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblEspecialidade.ForeColor = System.Drawing.Color.Gray;
        this.lblEspecialidade.Location = new System.Drawing.Point(30, 325);
        this.lblEspecialidade.Name = "lblEspecialidade";
        this.lblEspecialidade.Size = new System.Drawing.Size(92, 19);
        this.lblEspecialidade.TabIndex = 9;
        this.lblEspecialidade.Text = "Especialidade";

        // txtEspecialidade
        this.txtEspecialidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtEspecialidade.Location = new System.Drawing.Point(30, 350);
        this.txtEspecialidade.Name = "txtEspecialidade";
        this.txtEspecialidade.Size = new System.Drawing.Size(240, 29);
        this.txtEspecialidade.TabIndex = 10;

        // btnCadastrar
        this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
        this.btnCadastrar.FlatAppearance.BorderSize = 0;
        this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnCadastrar.ForeColor = System.Drawing.Color.White;
        this.btnCadastrar.Location = new System.Drawing.Point(30, 390);
        this.btnCadastrar.Name = "btnCadastrar";
        this.btnCadastrar.Size = new System.Drawing.Size(240, 40);
        this.btnCadastrar.TabIndex = 11;
        this.btnCadastrar.Text = "CADASTRAR";
        this.btnCadastrar.UseVisualStyleBackColor = false;
        this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

        // btnVoltar
        this.btnVoltar.FlatAppearance.BorderSize = 0;
        this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
        this.btnVoltar.ForeColor = System.Drawing.Color.Gray;
        this.btnVoltar.Location = new System.Drawing.Point(30, 430);
        this.btnVoltar.Name = "btnVoltar";
        this.btnVoltar.Size = new System.Drawing.Size(240, 25);
        this.btnVoltar.TabIndex = 12;
        this.btnVoltar.Text = "Voltar ao Login";
        this.btnVoltar.UseVisualStyleBackColor = true;
        this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

        // FormCadastro
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 500);
        this.Controls.Add(this.panelCentral);
        this.Name = "FormCadastro";
        this.Text = "Cadastro - Sistema UBS";
        this.panelCentral.ResumeLayout(false);
        this.panelCentral.PerformLayout();
        this.ResumeLayout(false);
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