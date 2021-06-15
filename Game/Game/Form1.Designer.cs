
namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btInserir = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.ndPontos = new System.Windows.Forms.NumericUpDown();
            this.dgvRanking = new System.Windows.Forms.DataGridView();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.lbEditando = new System.Windows.Forms.Label();
            this.ndPontosEditar = new System.Windows.Forms.NumericUpDown();
            this.tbNomeEditar = new System.Windows.Forms.TextBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.gbInserir = new System.Windows.Forms.GroupBox();
            this.btDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndPontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
            this.gbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndPontosEditar)).BeginInit();
            this.gbInserir.SuspendLayout();
            this.SuspendLayout();
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(15, 71);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(15, 42);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 23);
            this.tbNome.TabIndex = 1;
            // 
            // ndPontos
            // 
            this.ndPontos.Location = new System.Drawing.Point(121, 42);
            this.ndPontos.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ndPontos.Name = "ndPontos";
            this.ndPontos.Size = new System.Drawing.Size(120, 23);
            this.ndPontos.TabIndex = 2;
            // 
            // dgvRanking
            // 
            this.dgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRanking.Location = new System.Drawing.Point(563, 21);
            this.dgvRanking.Name = "dgvRanking";
            this.dgvRanking.RowTemplate.Height = 25;
            this.dgvRanking.Size = new System.Drawing.Size(405, 446);
            this.dgvRanking.TabIndex = 3;
            this.dgvRanking.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRanking_CellEnter);
            this.dgvRanking.SelectionChanged += new System.EventHandler(this.dgvRanking_SelectionChanged);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(563, 473);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 4;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.lbEditando);
            this.gbEditar.Controls.Add(this.ndPontosEditar);
            this.gbEditar.Controls.Add(this.tbNomeEditar);
            this.gbEditar.Controls.Add(this.btEditar);
            this.gbEditar.Enabled = false;
            this.gbEditar.Location = new System.Drawing.Point(42, 223);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(298, 211);
            this.gbEditar.TabIndex = 5;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar";
            // 
            // lbEditando
            // 
            this.lbEditando.AutoSize = true;
            this.lbEditando.Location = new System.Drawing.Point(36, 39);
            this.lbEditando.Name = "lbEditando";
            this.lbEditando.Size = new System.Drawing.Size(54, 15);
            this.lbEditando.TabIndex = 6;
            this.lbEditando.Text = "Editando";
            // 
            // ndPontosEditar
            // 
            this.ndPontosEditar.Location = new System.Drawing.Point(142, 79);
            this.ndPontosEditar.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ndPontosEditar.Name = "ndPontosEditar";
            this.ndPontosEditar.Size = new System.Drawing.Size(120, 23);
            this.ndPontosEditar.TabIndex = 5;
            // 
            // tbNomeEditar
            // 
            this.tbNomeEditar.Location = new System.Drawing.Point(36, 79);
            this.tbNomeEditar.Name = "tbNomeEditar";
            this.tbNomeEditar.Size = new System.Drawing.Size(100, 23);
            this.tbNomeEditar.TabIndex = 4;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(36, 108);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // gbInserir
            // 
            this.gbInserir.Controls.Add(this.btInserir);
            this.gbInserir.Controls.Add(this.tbNome);
            this.gbInserir.Controls.Add(this.ndPontos);
            this.gbInserir.Location = new System.Drawing.Point(42, 101);
            this.gbInserir.Name = "gbInserir";
            this.gbInserir.Size = new System.Drawing.Size(288, 116);
            this.gbInserir.TabIndex = 6;
            this.gbInserir.TabStop = false;
            this.gbInserir.Text = "Inserir";
            // 
            // btDeletar
            // 
            this.btDeletar.Enabled = false;
            this.btDeletar.Location = new System.Drawing.Point(893, 473);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 7;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 601);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.gbInserir);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.dgvRanking);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ndPontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndPontosEditar)).EndInit();
            this.gbInserir.ResumeLayout(false);
            this.gbInserir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.NumericUpDown ndPontos;
        private System.Windows.Forms.DataGridView dgvRanking;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Label lbEditando;
        private System.Windows.Forms.NumericUpDown ndPontosEditar;
        private System.Windows.Forms.TextBox tbNomeEditar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.GroupBox gbInserir;
        private System.Windows.Forms.Button btDeletar;
    }
}

