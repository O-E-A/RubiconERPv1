﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubiconERPv1.Forms.Alt_Tablolar
{
    public partial class RotaOperasyonBomEklemeEkraniForm : Form
    {
        public RotaOperasyonBomEklemeEkraniForm()
        {
            InitializeComponent();
        }

        private void RotaOperasyonBomEklemeEkraniForm_Load(object sender, EventArgs e)
        {

            // Ekran boyutlarını al
            this.Size = Screen.PrimaryScreen.Bounds.Size;

            // Formun konumunu ekranın köşesine ayarla
            this.Location = Screen.PrimaryScreen.Bounds.Location;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRotaNumarasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFirmaKodu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbRotaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
