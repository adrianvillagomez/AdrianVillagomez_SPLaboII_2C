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
            this.btnLeerTickets = new System.Windows.Forms.Button();
            this.LabelHora = new System.Windows.Forms.Label();
            this.btnbuckup = new System.Windows.Forms.Button();
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
            this.btnVerUtiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVerUtiles.ForeColor = System.Drawing.Color.White;
            this.btnVerUtiles.Location = new System.Drawing.Point(31, 358);
            this.btnVerUtiles.Name = "btnVerUtiles";
            this.btnVerUtiles.Size = new System.Drawing.Size(143, 43);
            this.btnVerUtiles.TabIndex = 4;
            this.btnVerUtiles.Text = "Ver Utiles";
            this.btnVerUtiles.UseVisualStyleBackColor = false;
            this.btnVerUtiles.Click += new System.EventHandler(this.btnVerUtiles_Click);
            // 
            // btnLeerTickets
            // 
            this.btnLeerTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLeerTickets.ForeColor = System.Drawing.Color.White;
            this.btnLeerTickets.Location = new System.Drawing.Point(600, 441);
            this.btnLeerTickets.Name = "btnLeerTickets";
            this.btnLeerTickets.Size = new System.Drawing.Size(143, 43);
            this.btnLeerTickets.TabIndex = 5;
            this.btnLeerTickets.Text = "Leer Tickets";
            this.btnLeerTickets.UseVisualStyleBackColor = false;
            this.btnLeerTickets.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LabelHora
            // 
            this.LabelHora.AutoSize = true;
            this.LabelHora.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LabelHora.Location = new System.Drawing.Point(582, 45);
            this.LabelHora.Name = "LabelHora";
            this.LabelHora.Size = new System.Drawing.Size(45, 17);
            this.LabelHora.TabIndex = 6;
            this.LabelHora.Text = "label2";
            // 
            // btnbuckup
            // 
            this.btnbuckup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbuckup.ForeColor = System.Drawing.Color.White;
            this.btnbuckup.Location = new System.Drawing.Point(600, 78);
            this.btnbuckup.Name = "btnbuckup";
            this.btnbuckup.Size = new System.Drawing.Size(143, 43);
            this.btnbuckup.TabIndex = 7;
            this.btnbuckup.Text = "Lista Buckup";
            this.btnbuckup.UseVisualStyleBackColor = false;
            this.btnbuckup.Click += new System.EventHandler(this.btnbuckup_Click);
            // 
            // FrmCartuchera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(772, 549);
            this.Controls.Add(this.btnbuckup);
            this.Controls.Add(this.LabelHora);
            this.Controls.Add(this.btnLeerTickets);
            this.Controls.Add(this.btnVerUtiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarGoma);
            this.Controls.Add(this.btnAgregarSacaPuntas);
            this.Controls.Add(this.btnAgregarUtil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCartuchera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCartuchera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregarUtil;
        private Button btnAgregarSacaPuntas;
        private Button btnAgregarGoma;
        private Label label1;
        private Button btnVerUtiles;
        private Button btnLeerTickets;
        private Label LabelHora;
        private Button btnbuckup;
    }
}