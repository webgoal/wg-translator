namespace wg_translator
{
    partial class Translator
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
            this.tbTextoATraduzir = new System.Windows.Forms.TextBox();
            this.btTraduzir = new System.Windows.Forms.Button();
            this.tbTextoTraduzido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbTextoATraduzir
            // 
            this.tbTextoATraduzir.Location = new System.Drawing.Point(12, 12);
            this.tbTextoATraduzir.Multiline = true;
            this.tbTextoATraduzir.Name = "tbTextoATraduzir";
            this.tbTextoATraduzir.Size = new System.Drawing.Size(365, 67);
            this.tbTextoATraduzir.TabIndex = 0;
            // 
            // btTraduzir
            // 
            this.btTraduzir.Location = new System.Drawing.Point(302, 85);
            this.btTraduzir.Name = "btTraduzir";
            this.btTraduzir.Size = new System.Drawing.Size(75, 23);
            this.btTraduzir.TabIndex = 1;
            this.btTraduzir.Text = "Traduzir";
            this.btTraduzir.UseVisualStyleBackColor = true;
            this.btTraduzir.Click += new System.EventHandler(this.btTraduzir_Click);
            // 
            // tbTextoTraduzido
            // 
            this.tbTextoTraduzido.Location = new System.Drawing.Point(12, 114);
            this.tbTextoTraduzido.Multiline = true;
            this.tbTextoTraduzido.Name = "tbTextoTraduzido";
            this.tbTextoTraduzido.Size = new System.Drawing.Size(365, 67);
            this.tbTextoTraduzido.TabIndex = 2;
            // 
            // Translator
            // 
            this.AcceptButton = this.btTraduzir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 192);
            this.Controls.Add(this.tbTextoTraduzido);
            this.Controls.Add(this.btTraduzir);
            this.Controls.Add(this.tbTextoATraduzir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Translator";
            this.Text = "WGTranslator - webgoal.com.br";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTextoATraduzir;
        private System.Windows.Forms.Button btTraduzir;
        private System.Windows.Forms.TextBox tbTextoTraduzido;
    }
}

