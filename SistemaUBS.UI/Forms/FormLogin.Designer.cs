namespace SistemaUBS.UI.Forms;

partial class FormLogin
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
        this.btnSair = new System.Windows.Forms.Button();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblEmail = new System.Windows.Forms.Label();
        this.txtSenha = new System.Windows.Forms.TextBox();
        this.lblSenha = new System.Windows.Forms.Label();
        this.btnEntrar = new System.Windows.Forms.Button();
        this.btnCadastrar = new System.Windows.Forms.Button();
        this.panelCentral.SuspendLayout();
        this.SuspendLayout();

        // panelCentral
        this.panelCentral.BackColor = System.Drawing.Color.White;
        this.panelCentral.Controls.Add(this.btnSair);
        this.panelCentral.Controls.Add(this.btnCadastrar);
        this.panelCentral.Controls.Add(this.btnEntrar);
        this.panelCentral.Controls.Add(this.txtSenha);
        this.panelCentral.Controls.Add(this.lblSenha);
        this.panelCentral.Controls.Add(this.txtEmail);
        this.panelCentral.Controls.Add(this.lblEmail);
        this.panelCentral.Controls.Add(this.lblTitulo);
        this.panelCentral.Location = new System.Drawing.Point(50, 50);
        this.panelCentral.Name = "panelCentral";
        this.panelCentral.Size = new System.Drawing.Size(300, 400);
        this.panelCentral.TabIndex = 0;

        // lblTitulo
        this.lblTitulo.AutoSize = true;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
        this.lblTitulo.Location = new System.Drawing.Point(60, 40);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(180, 32);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "SISTEMA UBS";

        // lblEmail
        this.lblEmail.AutoSize = true;
        this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblEmail.ForeColor = System.Drawing.Color.Gray;
        this.lblEmail.Location = new System.Drawing.Point(30, 110);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(44, 19);
        this.lblEmail.TabIndex = 1;
        this.lblEmail.Text = "Email";

        // txtEmail
        this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtEmail.Location = new System.Drawing.Point(30, 135);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(240, 29);
        this.txtEmail.TabIndex = 2;

        // lblSenha
        this.lblSenha.AutoSize = true;
        this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblSenha.ForeColor = System.Drawing.Color.Gray;
        this.lblSenha.Location = new System.Drawing.Point(30, 185);
        this.lblSenha.Name = "lblSenha";
        this.lblSenha.Size = new System.Drawing.Size(46, 19);
        this.lblSenha.TabIndex = 3;
        this.lblSenha.Text = "Senha";

        // txtSenha
        this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtSenha.Location = new System.Drawing.Point(30, 210);
        this.txtSenha.Name = "txtSenha";
        this.txtSenha.PasswordChar = '*';
        this.txtSenha.Size = new System.Drawing.Size(240, 29);
        this.txtSenha.TabIndex = 4;

        // btnEntrar
        this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
        this.btnEntrar.FlatAppearance.BorderSize = 0;
        this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnEntrar.ForeColor = System.Drawing.Color.White;
        this.btnEntrar.Location = new System.Drawing.Point(30, 265);
        this.btnEntrar.Name = "btnEntrar";
        this.btnEntrar.Size = new System.Drawing.Size(240, 45);
        this.btnEntrar.TabIndex = 5;
        this.btnEntrar.Text = "ENTRAR";
        this.btnEntrar.UseVisualStyleBackColor = false;
        this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);

        // btnCadastrar
        this.btnCadastrar.FlatAppearance.BorderSize = 0;
        this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
        this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
        this.btnCadastrar.Location = new System.Drawing.Point(30, 320);
        this.btnCadastrar.Name = "btnCadastrar";
        this.btnCadastrar.Size = new System.Drawing.Size(240, 30);
        this.btnCadastrar.TabIndex = 6;
        this.btnCadastrar.Text = "Ir para Cadastro";
        this.btnCadastrar.UseVisualStyleBackColor = true;
        this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

        // btnSair
        this.btnSair.FlatAppearance.BorderSize = 0;
        this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSair.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSair.ForeColor = System.Drawing.Color.IndianRed;
        this.btnSair.Location = new System.Drawing.Point(260, 5);
        this.btnSair.Name = "btnSair";
        this.btnSair.Size = new System.Drawing.Size(35, 35);
        this.btnSair.TabIndex = 7;
        this.btnSair.Text = "X";
        this.btnSair.UseVisualStyleBackColor = true;
        this.btnSair.Click += new System.EventHandler(this.btnSair_Click);

        // FormLogin
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 500);
        this.Controls.Add(this.panelCentral);
        this.Name = "FormLogin";
        this.Text = "Login - Sistema UBS";
        this.panelCentral.ResumeLayout(false);
        this.panelCentral.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelCentral;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblSenha;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.Button btnEntrar;
    private System.Windows.Forms.Button btnCadastrar;
    private System.Windows.Forms.Button btnSair;
}