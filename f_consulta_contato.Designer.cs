
namespace Agenda
{
    partial class f_consulta_contato
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
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.bt_executar = new System.Windows.Forms.Button();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Contato";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(12, 25);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(687, 20);
            this.txt_valor.TabIndex = 1;
            // 
            // bt_executar
            // 
            this.bt_executar.Location = new System.Drawing.Point(705, 22);
            this.bt_executar.Name = "bt_executar";
            this.bt_executar.Size = new System.Drawing.Size(75, 23);
            this.bt_executar.TabIndex = 2;
            this.bt_executar.Text = "Procurar";
            this.bt_executar.UseVisualStyleBackColor = true;
            this.bt_executar.Click += new System.EventHandler(this.bt_executar_Click);
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(12, 68);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dados.Size = new System.Drawing.Size(768, 493);
            this.dgv_dados.TabIndex = 3;
            this.dgv_dados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellDoubleClick);
            // 
            // f_consulta_contato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.bt_executar);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label1);
            this.Name = "f_consulta_contato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_consulta_contato";
            this.Load += new System.EventHandler(this.f_consulta_contato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button bt_executar;
        private System.Windows.Forms.DataGridView dgv_dados;
    }
}