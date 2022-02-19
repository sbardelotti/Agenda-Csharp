
namespace Agenda
{
    partial class f_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_contato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_contato
            // 
            this.bt_contato.Location = new System.Drawing.Point(12, 12);
            this.bt_contato.Name = "bt_contato";
            this.bt_contato.Size = new System.Drawing.Size(112, 49);
            this.bt_contato.TabIndex = 0;
            this.bt_contato.Text = "Contato";
            this.bt_contato.UseVisualStyleBackColor = true;
            this.bt_contato.Click += new System.EventHandler(this.bt_contato_Click);
            // 
            // f_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.bt_contato);
            this.Name = "f_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_contato;
    }
}

