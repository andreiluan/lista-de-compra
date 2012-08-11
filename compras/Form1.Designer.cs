namespace compras
{
    partial class Form1
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
            this.label_Paracompra = new System.Windows.Forms.Label();
            this.textBoxcompras = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.listViewItensCompra = new System.Windows.Forms.ListView();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Paracompra
            // 
            this.label_Paracompra.AutoSize = true;
            this.label_Paracompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Paracompra.Location = new System.Drawing.Point(29, 34);
            this.label_Paracompra.Name = "label_Paracompra";
            this.label_Paracompra.Size = new System.Drawing.Size(131, 24);
            this.label_Paracompra.TabIndex = 0;
            this.label_Paracompra.Text = "&Para Comprar:";
            // 
            // textBoxcompras
            // 
            this.textBoxcompras.Location = new System.Drawing.Point(33, 73);
            this.textBoxcompras.Name = "textBoxcompras";
            this.textBoxcompras.Size = new System.Drawing.Size(250, 20);
            this.textBoxcompras.TabIndex = 1;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(338, 69);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 24);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // listViewItensCompra
            // 
            this.listViewItensCompra.Location = new System.Drawing.Point(33, 115);
            this.listViewItensCompra.Name = "listViewItensCompra";
            this.listViewItensCompra.Size = new System.Drawing.Size(380, 219);
            this.listViewItensCompra.TabIndex = 3;
            this.listViewItensCompra.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(338, 340);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "Remover";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 372);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.listViewItensCompra);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxcompras);
            this.Controls.Add(this.label_Paracompra);
            this.Name = "Form1";
            this.Text = "Lista de Compras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Paracompra;
        private System.Windows.Forms.TextBox textBoxcompras;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.ListView listViewItensCompra;
        private System.Windows.Forms.Button buttonSair;
    }
}

