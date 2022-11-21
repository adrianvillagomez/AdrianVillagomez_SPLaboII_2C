namespace Vista
{
    partial class FrmSerializar
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
            this.btnSerialziarJson = new System.Windows.Forms.Button();
            this.btnSerializarXML = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSerialziarJson
            // 
            this.btnSerialziarJson.Location = new System.Drawing.Point(17, 81);
            this.btnSerialziarJson.Name = "btnSerialziarJson";
            this.btnSerialziarJson.Size = new System.Drawing.Size(122, 23);
            this.btnSerialziarJson.TabIndex = 0;
            this.btnSerialziarJson.Text = "SerializarJson";
            this.btnSerialziarJson.UseVisualStyleBackColor = true;
            this.btnSerialziarJson.Click += new System.EventHandler(this.btnSerialziarJson_Click);
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.Location = new System.Drawing.Point(17, 110);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(122, 23);
            this.btnSerializarXML.TabIndex = 1;
            this.btnSerializarXML.Text = "SerializarML";
            this.btnSerializarXML.UseVisualStyleBackColor = true;
            this.btnSerializarXML.Click += new System.EventHandler(this.btnSerializarXML_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(17, 163);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Lapiz";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Archivo :";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(17, 39);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(122, 23);
            this.txtNombreArchivo.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(17, 65);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 5;
            // 
            // FrmSerializar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 230);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSerializarXML);
            this.Controls.Add(this.btnSerialziarJson);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSerializar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSerializar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSerialziarJson;
        private Button btnSerializarXML;
        private Button btnEliminar;
        private Label label1;
        private TextBox txtNombreArchivo;
        private Label lblError;
    }
}