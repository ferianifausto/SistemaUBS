namespace SistemaUBS.UI.Forms;

partial class FormPrincipal
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
        this.panelSidebar = new System.Windows.Forms.Panel();
        this.panelLogo = new System.Windows.Forms.Panel();
        this.lblLogo = new System.Windows.Forms.Label();

        this.btnAreaPaciente = new System.Windows.Forms.Button();
        this.btnAreaMedico = new System.Windows.Forms.Button();
        this.btnConsultasExames = new System.Windows.Forms.Button();
        this.btnLogout = new System.Windows.Forms.Button();

        this.panelTop = new System.Windows.Forms.Panel();
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblUserName = new System.Windows.Forms.Label();
        this.btnClose = new System.Windows.Forms.Button();

        this.panelDesktop = new System.Windows.Forms.Panel();

        this.panelSidebar.SuspendLayout();
        this.panelLogo.SuspendLayout();
        this.panelTop.SuspendLayout();
        this.SuspendLayout();

        // panelSidebar
        this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
        this.panelSidebar.Controls.Add(this.btnLogout);
        this.panelSidebar.Controls.Add(this.btnConsultasExames);
        this.panelSidebar.Controls.Add(this.btnAreaMedico);
        this.panelSidebar.Controls.Add(this.btnAreaPaciente);
        this.panelSidebar.Controls.Add(this.panelLogo);
        this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.panelSidebar.Location = new System.Drawing.Point(0, 0);
        this.panelSidebar.Name = "panelSidebar";
        this.panelSidebar.Size = new System.Drawing.Size(220, 600);
        this.panelSidebar.TabIndex = 0;

        // panelLogo
        this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
        this.panelLogo.Controls.Add(this.lblLogo);
        this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelLogo.Location = new System.Drawing.Point(0, 0);
        this.panelLogo.Name = "panelLogo";
        this.panelLogo.Size = new System.Drawing.Size(220, 80);
        this.panelLogo.TabIndex = 0;

        // lblLogo
        this.lblLogo.AutoSize = true;
        this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblLogo.ForeColor = System.Drawing.Color.White;
        this.lblLogo.Location = new System.Drawing.Point(30, 25);
        this.lblLogo.Name = "lblLogo";
        this.lblLogo.Size = new System.Drawing.Size(147, 30);
        this.lblLogo.TabIndex = 0;
        this.lblLogo.Text = "Sistema UBS";

        // btnAreaPaciente
        this.btnAreaPaciente.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnAreaPaciente.FlatAppearance.BorderSize = 0;
        this.btnAreaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAreaPaciente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnAreaPaciente.ForeColor = System.Drawing.Color.White;
        this.btnAreaPaciente.Location = new System.Drawing.Point(0, 80);
        this.btnAreaPaciente.Name = "btnAreaPaciente";
        this.btnAreaPaciente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        this.btnAreaPaciente.Size = new System.Drawing.Size(220, 50);
        this.btnAreaPaciente.TabIndex = 1;
        this.btnAreaPaciente.Text = "Área do Paciente";
        this.btnAreaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnAreaPaciente.UseVisualStyleBackColor = true;
        this.btnAreaPaciente.Click += new System.EventHandler(this.btnAreaPaciente_Click);

        // btnAreaMedico
        this.btnAreaMedico.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnAreaMedico.FlatAppearance.BorderSize = 0;
        this.btnAreaMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAreaMedico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnAreaMedico.ForeColor = System.Drawing.Color.White;
        this.btnAreaMedico.Location = new System.Drawing.Point(0, 130);
        this.btnAreaMedico.Name = "btnAreaMedico";
        this.btnAreaMedico.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        this.btnAreaMedico.Size = new System.Drawing.Size(220, 50);
        this.btnAreaMedico.TabIndex = 2;
        this.btnAreaMedico.Text = "Área do Médico";
        this.btnAreaMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnAreaMedico.UseVisualStyleBackColor = true;
        this.btnAreaMedico.Click += new System.EventHandler(this.btnAreaMedico_Click);

        // btnConsultasExames
        this.btnConsultasExames.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnConsultasExames.FlatAppearance.BorderSize = 0;
        this.btnConsultasExames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnConsultasExames.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnConsultasExames.ForeColor = System.Drawing.Color.White;
        this.btnConsultasExames.Location = new System.Drawing.Point(0, 180);
        this.btnConsultasExames.Name = "btnConsultasExames";
        this.btnConsultasExames.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        this.btnConsultasExames.Size = new System.Drawing.Size(220, 50);
        this.btnConsultasExames.TabIndex = 3;
        this.btnConsultasExames.Text = "Consultas e Exames";
        this.btnConsultasExames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnConsultasExames.UseVisualStyleBackColor = true;
        this.btnConsultasExames.Click += new System.EventHandler(this.btnConsultasExames_Click);

        // btnLogout
        this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.btnLogout.FlatAppearance.BorderSize = 0;
        this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnLogout.ForeColor = System.Drawing.Color.LightCoral;
        this.btnLogout.Location = new System.Drawing.Point(0, 550);
        this.btnLogout.Name = "btnLogout";
        this.btnLogout.Size = new System.Drawing.Size(220, 50);
        this.btnLogout.TabIndex = 4;
        this.btnLogout.Text = "Sair (Logout)";
        this.btnLogout.UseVisualStyleBackColor = true;
        this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

        // panelTop
        this.panelTop.BackColor = System.Drawing.Color.White;
        this.panelTop.Controls.Add(this.lblUserName);
        this.panelTop.Controls.Add(this.btnClose);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelTop.Location = new System.Drawing.Point(220, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new System.Drawing.Size(780, 60);
        this.panelTop.TabIndex = 1;
        this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(124, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Dashboard";

        // lblUserName
        this.lblUserName.AutoSize = true;
        this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblUserName.ForeColor = System.Drawing.Color.Gray;
        this.lblUserName.Location = new System.Drawing.Point(550, 20);
        this.lblUserName.Name = "lblUserName";
        this.lblUserName.Size = new System.Drawing.Size(89, 20);
        this.lblUserName.TabIndex = 1;
        this.lblUserName.Text = "Olá, Usuário";

        // btnClose
        this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
        this.btnClose.FlatAppearance.BorderSize = 0;
        this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnClose.ForeColor = System.Drawing.Color.Gray;
        this.btnClose.Location = new System.Drawing.Point(730, 0);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(50, 60);
        this.btnClose.TabIndex = 2;
        this.btnClose.Text = "X";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

        // panelDesktop
        this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
        this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelDesktop.Location = new System.Drawing.Point(220, 60);
        this.panelDesktop.Name = "panelDesktop";
        this.panelDesktop.Size = new System.Drawing.Size(780, 540);
        this.panelDesktop.TabIndex = 2;

        // FormPrincipal
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 600);
        this.Controls.Add(this.panelDesktop);
        this.Controls.Add(this.panelTop);
        this.Controls.Add(this.panelSidebar);
        this.Name = "FormPrincipal";
        this.Text = "Sistema UBS";

        this.panelSidebar.ResumeLayout(false);
        this.panelLogo.ResumeLayout(false);
        this.panelLogo.PerformLayout();
        this.panelTop.ResumeLayout(false);
        this.panelTop.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelSidebar;
    private System.Windows.Forms.Panel panelLogo;
    private System.Windows.Forms.Label lblLogo;
    private System.Windows.Forms.Button btnAreaPaciente;
    private System.Windows.Forms.Button btnAreaMedico;
    private System.Windows.Forms.Button btnConsultasExames;
    private System.Windows.Forms.Button btnLogout;
    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Panel panelDesktop;
}