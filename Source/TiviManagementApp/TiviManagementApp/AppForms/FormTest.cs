using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TiviManagementApp.Models;
using TiviManagementApp.Repositories;

namespace TiviManagementApp.AppForms
{
    public partial class FormTest : Form
    {
        private TiviRepositories repository = new TiviRepositories();

        public FormTest()
        {
            InitializeComponent();

            ShowDanhSach();
        }

        private void ShowDanhSach()
        {
            dataListBox.Items.Clear();

            var danhSach = repository.GetAll();

            foreach (var x in danhSach)
            {
                dataListBox.Items.Add(x);
            }
        }

        private void ShowProduct(string maTv)
        {
            FormDetail form = new FormDetail(maTv);

            form.Show();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (dataListBox.SelectedIndex != -1)
            {
                Tivi tv = (Tivi)dataListBox.SelectedItem;

                ShowProduct(tv.MaTivi);
            }
        }
    }
}
