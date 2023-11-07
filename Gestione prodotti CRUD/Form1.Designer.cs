namespace Gestione_prodotti_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.txtb_ProductName = new System.Windows.Forms.TextBox();
            this.txtb_ProductPrice = new System.Windows.Forms.TextBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.txtb_NewProductName = new System.Windows.Forms.TextBox();
            this.lbl_NewProductName = new System.Windows.Forms.Label();
            this.lbl_UpdateProduct = new System.Windows.Forms.Label();
            this.txtb_UpdateProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ProductName.Location = new System.Drawing.Point(12, 9);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(94, 13);
            this.lbl_ProductName.TabIndex = 0;
            this.lbl_ProductName.Text = "Nome prodotto:";
            this.lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtb_ProductName
            // 
            this.txtb_ProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_ProductName.Location = new System.Drawing.Point(12, 25);
            this.txtb_ProductName.Name = "txtb_ProductName";
            this.txtb_ProductName.Size = new System.Drawing.Size(174, 20);
            this.txtb_ProductName.TabIndex = 1;
            this.txtb_ProductName.TextChanged += new System.EventHandler(this.txtb_ProductName_TextChanged);
            // 
            // txtb_ProductPrice
            // 
            this.txtb_ProductPrice.Location = new System.Drawing.Point(12, 64);
            this.txtb_ProductPrice.Name = "txtb_ProductPrice";
            this.txtb_ProductPrice.Size = new System.Drawing.Size(174, 20);
            this.txtb_ProductPrice.TabIndex = 3;
            this.txtb_ProductPrice.TextChanged += new System.EventHandler(this.txtb_ProductPrice_TextChanged);
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(12, 48);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(100, 13);
            this.lbl_ProductPrice.TabIndex = 2;
            this.lbl_ProductPrice.Text = "Prezzo prodotto:";
            this.lbl_ProductPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_AddProduct.Location = new System.Drawing.Point(192, 26);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(205, 200);
            this.btn_AddProduct.TabIndex = 7;
            this.btn_AddProduct.Text = "Create";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_UpdateProduct.Location = new System.Drawing.Point(192, 242);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(205, 200);
            this.btn_UpdateProduct.TabIndex = 9;
            this.btn_UpdateProduct.Text = "Update";
            this.btn_UpdateProduct.UseVisualStyleBackColor = true;
            this.btn_UpdateProduct.Click += new System.EventHandler(this.btn_UpdateProduct_Click);
            // 
            // txtb_NewProductName
            // 
            this.txtb_NewProductName.Location = new System.Drawing.Point(12, 142);
            this.txtb_NewProductName.Name = "txtb_NewProductName";
            this.txtb_NewProductName.Size = new System.Drawing.Size(174, 20);
            this.txtb_NewProductName.TabIndex = 13;
            this.txtb_NewProductName.Visible = false;
            this.txtb_NewProductName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_NewProductName
            // 
            this.lbl_NewProductName.AutoSize = true;
            this.lbl_NewProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewProductName.Location = new System.Drawing.Point(12, 126);
            this.lbl_NewProductName.Name = "lbl_NewProductName";
            this.lbl_NewProductName.Size = new System.Drawing.Size(133, 13);
            this.lbl_NewProductName.TabIndex = 12;
            this.lbl_NewProductName.Text = "Nuovo nome prodotto:";
            this.lbl_NewProductName.Visible = false;
            this.lbl_NewProductName.Click += new System.EventHandler(this.lbl_NewProductName_Click);
            // 
            // lbl_UpdateProduct
            // 
            this.lbl_UpdateProduct.AutoSize = true;
            this.lbl_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UpdateProduct.Location = new System.Drawing.Point(12, 87);
            this.lbl_UpdateProduct.Name = "lbl_UpdateProduct";
            this.lbl_UpdateProduct.Size = new System.Drawing.Size(174, 13);
            this.lbl_UpdateProduct.TabIndex = 16;
            this.lbl_UpdateProduct.Text = "Nome prodotto da modificare:";
            this.lbl_UpdateProduct.Visible = false;
            // 
            // txtb_UpdateProduct
            // 
            this.txtb_UpdateProduct.Location = new System.Drawing.Point(12, 103);
            this.txtb_UpdateProduct.Name = "txtb_UpdateProduct";
            this.txtb_UpdateProduct.Size = new System.Drawing.Size(174, 20);
            this.txtb_UpdateProduct.TabIndex = 17;
            this.txtb_UpdateProduct.Visible = false;
            this.txtb_UpdateProduct.TextChanged += new System.EventHandler(this.txtb_UpdateProduct_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nuovo prezzo prodotto:";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(403, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 200);
            this.button1.TabIndex = 20;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(403, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 200);
            this.button2.TabIndex = 21;
            this.button2.Text = "Logica";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(614, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 200);
            this.button3.TabIndex = 22;
            this.button3.Text = "Fisica";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(614, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 200);
            this.button4.TabIndex = 23;
            this.button4.Text = "Recupera";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(825, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 200);
            this.button5.TabIndex = 24;
            this.button5.Text = "Apri File";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button6.Location = new System.Drawing.Point(825, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 200);
            this.button6.TabIndex = 25;
            this.button6.Text = "Cancella File";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Indice prodotto da ricercare:";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 27;
            this.textBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Prodotto da cancellare:";
            this.label3.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 259);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Prodotto da recuperare:";
            this.label4.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 20);
            this.textBox4.TabIndex = 31;
            this.textBox4.Visible = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button7.Location = new System.Drawing.Point(12, 324);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 117);
            this.button7.TabIndex = 32;
            this.button7.Text = "Esci";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 453);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_UpdateProduct);
            this.Controls.Add(this.lbl_UpdateProduct);
            this.Controls.Add(this.txtb_NewProductName);
            this.Controls.Add(this.lbl_NewProductName);
            this.Controls.Add(this.btn_UpdateProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.txtb_ProductPrice);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.txtb_ProductName);
            this.Controls.Add(this.lbl_ProductName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox txtb_ProductName;
        private System.Windows.Forms.TextBox txtb_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_UpdateProduct;
        private System.Windows.Forms.TextBox txtb_NewProductName;
        private System.Windows.Forms.Label lbl_NewProductName;
        private System.Windows.Forms.Label lbl_UpdateProduct;
        private System.Windows.Forms.TextBox txtb_UpdateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
    }
}

