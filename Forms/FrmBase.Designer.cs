namespace Forms
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.pnlcentral = new System.Windows.Forms.Panel();
            this.lblrodape = new System.Windows.Forms.Label();
            this.pctImg = new System.Windows.Forms.PictureBox();
            this.pnlRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(106)))));
            this.pnlRodape.Controls.Add(this.lblrodape);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 683);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(1348, 38);
            this.pnlRodape.TabIndex = 0;
            // 
            // pnlTopo
            // 
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1348, 37);
            this.pnlTopo.TabIndex = 1;
            // 
            // pnlcentral
            // 
            this.pnlcentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.pnlcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcentral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlcentral.Location = new System.Drawing.Point(0, 0);
            this.pnlcentral.Name = "pnlcentral";
            this.pnlcentral.Size = new System.Drawing.Size(1348, 721);
            this.pnlcentral.TabIndex = 2;
            // 
            // lblrodape
            // 
            this.lblrodape.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrodape.ForeColor = System.Drawing.Color.White;
            this.lblrodape.Location = new System.Drawing.Point(40, 5);
            this.lblrodape.Name = "lblrodape";
            this.lblrodape.Size = new System.Drawing.Size(124, 29);
            this.lblrodape.TabIndex = 0;
            this.lblrodape.Text = "label1";
            this.lblrodape.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctImg
            // 
            this.pctImg.Image = global::Forms.Properties.Resources.icone;
            this.pctImg.Location = new System.Drawing.Point(15, 7);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(80, 80);
            this.pctImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImg.TabIndex = 3;
            this.pctImg.TabStop = false;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pctImg);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlcentral);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBase";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.pnlRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlRodape;
        public System.Windows.Forms.Panel pnlTopo;
        public System.Windows.Forms.Panel pnlcentral;
        public System.Windows.Forms.PictureBox pctImg;
        public System.Windows.Forms.Label lblrodape;
    }
}