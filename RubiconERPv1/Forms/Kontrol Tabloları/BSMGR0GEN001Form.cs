﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataAccessLayer;

namespace RubiconERPv1.Forms.Kontrol_Tabloları
{
    public partial class BSMGR0GEN001Form : Form
    {
        private BSMGR0GEN001DAL _dataAccessLayer;

        public BSMGR0GEN001Form()
        {
            InitializeComponent();
            string connectionString = DbConnection.GetConnectionString();
            _dataAccessLayer = new BSMGR0GEN001DAL(connectionString);

            // Olay tanımlamaları
            dgvCompanies.CellClick += dgvCompanies_CellClick;

            // Verileri yükle
            LoadData();
            LoadComboBoxData();
            CustomizeDataGridView();
        }

        private void LoadData()
        {
            try
            {
                DataTable dtCompanies = _dataAccessLayer.GetAllRecords();
                dgvCompanies.DataSource = dtCompanies;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxData()
        {
            try
            {
                // Şehir kodlarını comboBox1'e yükle
                DataTable cityCodes = _dataAccessLayer.GetCityCodes();
                comboBox1.DataSource = cityCodes;
                comboBox1.DisplayMember = "CITYCODE";
                comboBox1.ValueMember = "CITYCODE";

                // Ülke kodlarını comboBox2'ye yükle
                DataTable countryCodes = _dataAccessLayer.GetCountryCodes();
                comboBox2.DataSource = countryCodes;
                comboBox2.DisplayMember = "COUNTRYCODE";
                comboBox2.ValueMember = "COUNTRYCODE";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ComboBox verileri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeDataGridView()
        {
            dgvCompanies.Dock = DockStyle.Top;
            dgvCompanies.Height = this.ClientSize.Height / 2;

            dgvCompanies.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dgvCompanies.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCompanies.DefaultCellStyle.Font = new Font("Arial", 10F);
            dgvCompanies.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCompanies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompanies.MultiSelect = false;
            dgvCompanies.AllowUserToAddRows = false;
            dgvCompanies.AllowUserToDeleteRows = false;
            dgvCompanies.ReadOnly = true;

            dgvCompanies.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvCompanies.RowsDefaultCellStyle.BackColor = Color.White;
            dgvCompanies.RowsDefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
            dgvCompanies.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgvCompanies.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvCompanies.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCompanies.EnableHeadersVisualStyles = false;

            foreach (DataGridViewColumn column in dgvCompanies.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvCompanies.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCompanies.GridColor = Color.DarkGray;
            dgvCompanies.RowTemplate.Height = 30;
            dgvCompanies.BackgroundColor = Color.LightSteelBlue;
        }

        private void ClearFields()
        {
            txtComCode.Clear();
            txtComText.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            comboBox1.SelectedIndex = -1; // Şehir kodu temizle
            comboBox2.SelectedIndex = -1; // Ülke kodu temizle
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string comCode = txtComCode.Text.Trim();
            string comText = txtComText.Text.Trim();
            string address1 = txtAddress1.Text.Trim();
            string address2 = txtAddress2.Text.Trim();
            string cityCode = comboBox1.SelectedValue?.ToString();
            string countryCode = comboBox2.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(comCode) || string.IsNullOrEmpty(comText))
            {
                MessageBox.Show("Firma Kodu ve Firma Adı zorunludur!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _dataAccessLayer.AddRecord(comCode, comText, address1, address2, cityCode, countryCode);
                MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt ekleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCompanies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir kayıt seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string oldComCode = dgvCompanies.SelectedRows[0].Cells["COMCODE"].Value?.ToString();
            string comCode = txtComCode.Text.Trim();
            string comText = txtComText.Text.Trim();
            string address1 = txtAddress1.Text.Trim();
            string address2 = txtAddress2.Text.Trim();
            string cityCode = comboBox1.SelectedValue?.ToString();
            string countryCode = comboBox2.SelectedValue?.ToString();

            try
            {
                bool result = _dataAccessLayer.UpdateRecord(oldComCode, comCode, comText, address1, address2, cityCode, countryCode);

                if (result)
                {
                    MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCompanies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir kayıt seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string comCode = dgvCompanies.SelectedRows[0].Cells["COMCODE"].Value?.ToString();

            try
            {
                _dataAccessLayer.DeleteRecord(comCode);
                MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCompanies.Rows.Count <= e.RowIndex)
            {
                MessageBox.Show("Geçersiz satır seçimi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtComCode.Text = dgvCompanies.Rows[e.RowIndex].Cells["COMCODE"].Value?.ToString() ?? string.Empty;
            txtComText.Text = dgvCompanies.Rows[e.RowIndex].Cells["COMTEXT"].Value?.ToString() ?? string.Empty;
            txtAddress1.Text = dgvCompanies.Rows[e.RowIndex].Cells["ADDRESS1"].Value?.ToString() ?? string.Empty;
            txtAddress2.Text = dgvCompanies.Rows[e.RowIndex].Cells["ADDRESS2"].Value?.ToString() ?? string.Empty;
            comboBox1.SelectedValue = dgvCompanies.Rows[e.RowIndex].Cells["CITYCODE"].Value?.ToString();
            comboBox2.SelectedValue = dgvCompanies.Rows[e.RowIndex].Cells["COUNTRYCODE"].Value?.ToString();
        }

        private void txtComText_TextChanged(object sender, EventArgs e)
        {
            // Firma adı değiştiğinde yapılacak işlemler
        }
    }
}
