namespace SistemaUBS.UI.Forms;

partial class FormPaciente
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
        this.lblEmail = new System.Windows.Forms.Label();

        this.lblConsultas = new System.Windows.Forms.Label();
        this.dgvConsultas = new System.Windows.Forms.DataGridView();

        this.panelCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
        this.SuspendLayout();

        // panelCard
        this.panelCard.BackColor = System.Drawing.Color.White;
        this.panelCard.Controls.Add(this.lblEmail);
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
        this.lblTituloCartao.Text = "Dados Pessoais";

        // lblNome
        this.lblNome.AutoSize = true;
        this.lblNome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblNome.Location = new System.Drawing.Point(20, 60);
        this.lblNome.Name = "lblNome";
        this.lblNome.Size = new System.Drawing.Size(63, 25);
        this.lblNome.TabIndex = 1;
        this.lblNome.Text = "Nome";

        // lblEmail
        this.lblEmail.AutoSize = true;
        this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblEmail.ForeColor = System.Drawing.Color.Gray;
        this.lblEmail.Location = new System.Drawing.Point(20, 95);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(41, 19);
        this.lblEmail.TabIndex = 2;
        this.lblEmail.Text = "Email";

        // lblConsultas
        this.lblConsultas.AutoSize = true;
        this.lblConsultas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
        this.lblConsultas.Location = new System.Drawing.Point(30, 220);
        this.lblConsultas.Name = "lblConsultas";
        this.lblConsultas.Size = new System.Drawing.Size(183, 25);
        this.lblConsultas.TabIndex = 1;
        this.lblConsultas.Text = "Minhas Consultas";

        // dgvConsultas
        this.dgvConsultas.AllowUserToAddRows = false;
        this.dgvConsultas.AllowUserToDeleteRows = false;
        this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvConsultas.BackgroundColor = System.Drawing.Color.White;
        this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvConsultas.Location = new System.Drawing.Point(30, 260);
        this.dgvConsultas.Name = "dgvConsultas";
        this.dgvConsultas.ReadOnly = true;
        this.dgvConsultas.RowHeadersVisible = false;
        this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvConsultas.Size = new System.Drawing.Size(700, 250);
        this.dgvConsultas.TabIndex = 2;

        // FormPaciente
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(780, 540);
        this.Controls.Add(this.dgvConsultas);
        this.Controls.Add(this.lblConsultas);
        this.Controls.Add(this.panelCard);
        this.Name = "FormPaciente";
        this.Text = "Área do Paciente";
        this.panelCard.ResumeLayout(false);
        this.panelCard.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Panel panelCard;
    private System.Windows.Forms.Label lblTituloCartao;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblConsultas;
    private System.Windows.Forms.DataGridView dgvConsultas;
}
