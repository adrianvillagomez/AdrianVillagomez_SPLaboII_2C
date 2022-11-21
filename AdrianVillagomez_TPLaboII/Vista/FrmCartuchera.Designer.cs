namespace Vista
{
    partial class FrmCartuchera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCartuchera));
            this.btnAgregarUtil = new System.Windows.Forms.Button();
            this.btnAgregarSacaPuntas = new System.Windows.Forms.Button();
            this.btnAgregarGoma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerUtiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarUtil
            // 
            this.btnAgregarUtil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarUtil.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUtil.Location = new System.Drawing.Point(31, 104);
            this.btnAgregarUtil.Name = "btnAgregarUtil";
            this.btnAgregarUtil.Size = new System.Drawing.Size(143, 43);
            this.btnAgregarUtil.TabIndex = 0;
            this.btnAgregarUtil.Text = "Agregar Lapiz";
            this.btnAgregarUtil.UseVisualStyleBackColor = false;
            this.btnAgregarUtil.Click += new System.EventHandler(this.btnAgregarUtil_Click);
            // 
            // btnAgregarSacaPuntas
            // 
            this.btnAgregarSacaPuntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarSacaPuntas.ForeColor = System.Drawing.Color.White;
            this.btnAgregarSacaPuntas.Location = new System.Drawing.Point(31, 169);
            this.btnAgregarSacaPuntas.Name = "btnAgregarSacaPuntas";
            this.btnAgregarSacaPuntas.Size = new System.Drawing.Size(143, 43);
            this.btnAgregarSacaPuntas.TabIndex = 1;
            this.btnAgregarSacaPuntas.Text = "Agregar Sacapuntas";
            this.btnAgregarSacaPuntas.UseVisualStyleBackColor = false;
            this.btnAgregarSacaPuntas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregarGoma
            // 
            this.btnAgregarGoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarGoma.ForeColor = System.Drawing.Color.White;
            this.btnAgregarGoma.Location = new System.Drawing.Point(31, 234);
            this.btnAgregarGoma.Name = "btnAgregarGoma";
            this.btnAgregarGoma.Size = new System.Drawing.Size(143, 43);
            this.btnAgregarGoma.TabIndex = 2;
            this.btnAgregarGoma.Text = "Agregar Goma";
            this.btnAgregarGoma.UseVisualStyleBackColor = false;
            this.btnAgregarGoma.Click += new System.EventHandler(this.btnAgregarGoma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "CARTUCHERA";
            // 
            // btnVerUtiles
            // 
            this.btnVerUtiles.BackColor = System.Drawing.Color.Blue;
            this.btnVerUtiles.ForeColor = System.Drawing.Color.White;
            this.btnVerUtiles.Location = new System.Drawing.Point(31, 358);
            this.btnVerUtiles.Name = "btnVerUtiles";
            this.btnVerUtiles.Size = new System.Drawing.Size(143, 43);
            this.btnVerUtiles.TabIndex = 4;
            this.btnVerUtiles.Text = "Ver Utiles";
            this.btnVerUtiles.UseVisualStyleBackColor = false;
            // 
            // FrmCartuchera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(772, 549);
            this.Controls.Add(this.btnVerUtiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarGoma);
            this.Controls.Add(this.btnAgregarSacaPuntas);
            this.Controls.Add(this.btnAgregarUtil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCartuchera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregarUtil;
        private Button btnAgregarSacaPuntas;
        private Button btnAgregarGoma;
        private Label label1;
        private Button btnVerUtiles;
    }
}