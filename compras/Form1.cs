using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            listViewItensCompra.Items.Add(textBoxcompras.Text);
            textBoxcompras.Text = "";
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in listViewItensCompra.SelectedItems)
            {

                listViewItensCompra.Items.Remove(listViewItem);

            }
        }
    }
}
