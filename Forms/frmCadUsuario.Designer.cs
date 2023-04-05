namespace Forms
{
    partial class frmCadUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExckuir = new System.Windows.Forms.Button();
            this.btnLocalilzar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Forms.Properties.Resources.salvar;
            this.btnSalvar.Location = new System.Drawing.Point(404, 307);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(45, 35);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Forms.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(336, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 35);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Image = global::Forms.Properties.Resources.inserir;
            this.btnIncluir.Location = new System.Drawing.Point(183, 307);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(45, 35);
            this.btnIncluir.TabIndex = 11;
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Forms.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(234, 307);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 35);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExckuir
            // 
            this.btnExckuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExckuir.FlatAppearance.BorderSize = 0;
            this.btnExckuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExckuir.Image = global::Forms.Properties.Resources.excluir;
            this.btnExckuir.Location = new System.Drawing.Point(285, 307);
            this.btnExckuir.Name = "btnExckuir";
            this.btnExckuir.Size = new System.Drawing.Size(45, 35);
            this.btnExckuir.TabIndex = 9;
            this.btnExckuir.UseVisualStyleBackColor = true;
            // 
            // btnLocalilzar
            // 
            this.btnLocalilzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalilzar.FlatAppearance.BorderSize = 0;
            this.btnLocalilzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalilzar.Image = global::Forms.Properties.Resources.localizar;
            this.btnLocalilzar.Location = new System.Drawing.Point(476, 307);
            this.btnLocalilzar.Name = "btnLocalilzar";
            this.btnLocalilzar.Size = new System.Drawing.Size(45, 35);
            this.btnLocalilzar.TabIndex = 8;
            this.btnLocalilzar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::Forms.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(527, 307);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 35);
            this.btnSair.TabIndex = 7;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmCadUsuario
            // 
            this.ClientSize = new System.Drawing.Size(755, 649);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExckuir);
            this.Controls.Add(this.btnLocalilzar);
            this.Controls.Add(this.btnSair);
            this.Name = "frmCadUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnIncluir;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnExckuir;
        public System.Windows.Forms.Button btnLocalilzar;
        public System.Windows.Forms.Button btnSair;
    }
}