namespace Vista
{
    partial class FrmVerUtiles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtvLapices = new System.Windows.Forms.DataGridView();
            this.dtvSacapuntaz = new System.Windows.Forms.DataGridView();
            this.dtvGoma = new System.Windows.Forms.DataGridView();
            this.btnDeserializar = new System.Windows.Forms.Button();
            this.btnDeserializarXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvLapices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSacapuntaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvGoma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SacaPuntaz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(31, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = " Lápices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(480, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gomas de Borrar";
            // 
            // dtvLapices
            // 
            this.dtvLapices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvLapices.Location = new System.Drawing.Point(31, 290);
            this.dtvLapices.Name = "dtvLapices";
            this.dtvLapices.ReadOnly = true;
            this.dtvLapices.RowTemplate.Height = 25;
            this.dtvLapices.Size = new System.Drawing.Size(425, 180);
            this.dtvLapices.TabIndex = 7;
            this.dtvLapices.DoubleClick += new System.EventHandler(this.dtvUtiles_DoubleClick);
            // 
            // dtvSacapuntaz
            // 
            this.dtvSacapuntaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvSacapuntaz.Location = new System.Drawing.Point(31, 77);
            this.dtvSacapuntaz.Name = "dtvSacapuntaz";
            this.dtvSacapuntaz.ReadOnly = true;
            this.dtvSacapuntaz.RowTemplate.Height = 25;
            this.dtvSacapuntaz.Size = new System.Drawing.Size(425, 150);
            this.dtvSacapuntaz.TabIndex = 8;
            // 
            // dtvGoma
            // 
            this.dtvGoma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvGoma.Location = new System.Drawing.Point(480, 77);
            this.dtvGoma.Name = "dtvGoma";
            this.dtvGoma.ReadOnly = true;
            this.dtvGoma.RowTemplate.Height = 25;
            this.dtvGoma.Size = new System.Drawing.Size(355, 150);
            this.dtvGoma.TabIndex = 9;
            // 
            // btnDeserializar
            // 
            this.btnDeserializar.Location = new System.Drawing.Point(480, 290);
            this.btnDeserializar.Name = "btnDeserializar";
            this.btnDeserializar.Size = new System.Drawing.Size(216, 49);
            this.btnDeserializar.TabIndex = 10;
            this.btnDeserializar.Text = "Deserializar Lapiz Json";
            this.btnDeserializar.UseVisualStyleBackColor = true;
            this.btnDeserializar.Click += new System.EventHandler(this.btnDeserializar_Click);
            // 
            // btnDeserializarXml
            // 
            this.btnDeserializarXml.Location = new System.Drawing.Point(480, 367);
            this.btnDeserializarXml.Name = "btnDeserializarXml";
            this.btnDeserializarXml.Size = new System.Drawing.Size(216, 49);
            this.btnDeserializarXml.TabIndex = 11;
            this.btnDeserializarXml.Text = "Deserializar Lapiz Xml";
            this.btnDeserializarXml.UseVisualStyleBackColor = true;
            this.btnDeserializarXml.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmVerUtiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 482);
            this.Controls.Add(this.btnDeserializarXml);
            this.Controls.Add(this.btnDeserializar);
            this.Controls.Add(this.dtvGoma);
            this.Controls.Add(this.dtvSacapuntaz);
            this.Controls.Add(this.dtvLapices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVerUtiles";
            this.Text = "FrmVerUtiles";
            this.Load += new System.EventHandler(this.FrmVerUtiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvLapices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSacapuntaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvGoma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dtvLapices;
        private DataGridView dtvSacapuntaz;
        private DataGridView dtvGoma;
        private Button btnDeserializar;
        private Button btnDeserializarXml;
    }
}