using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_prodotti_CRUD
{
    public partial class Form1 : Form
    {
        public struct Prodotti
        {
            public string Nome;
            public float Prezzo;
        }

        public Prodotti[] p;
        public int dim;
        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Prodotti[100];
            dim = 0;
        }
        public void WriteOnFile(string nome, float prezzo, string filePath)
        {
            var oStream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            int line = 64;
            
            sw.WriteLine($"{nome};{prezzo};1;0;".PadRight(line - 4) + "##");
            sw.Close();
        }
        public void U() //Funzione "Modifica"
        {
            string researchName = txtb_UpdateProduct.Text; //Vecchio prodotto da modificare
            string newName = txtb_NewProductName.Text; //Nuovo nome da assegnare

            for (int i = 0; i < dim; i++)
            {
                if (p[i].Nome == researchName)
                {
                    if (newName == "")
                    {
                        MessageBox.Show("Inserisci il nuovo nome da inserire.");
                    }
                    else
                    {
                        p[i].Nome = newName;
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void txtb_ProductName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtb_ProductPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            bool insert = true;

            if (txtb_ProductName.Text == "" || txtb_ProductPrice.Text == "")
            {
                MessageBox.Show("Inserire qualcosa.");
                insert = false;
            }

            if (insert == true)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtb_ProductPrice.Text, "[^0-9]"))
                {
                    MessageBox.Show("Inserisci un valore numererico nella casella del prezzo.");
                }
                else
                {
                    WriteOnFile(txtb_ProductName.Text, float.Parse(txtb_ProductPrice.Text), @"Articoli.csv");
                    lbl_UpdateProduct.Show();
                    txtb_UpdateProduct.Show();
                    lbl_NewProductName.Show();
                    txtb_NewProductName.Show();
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_NewProductName_Click(object sender, EventArgs e)
        {

        }
        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            U();
        }
        private void txtb_UpdateProduct_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
