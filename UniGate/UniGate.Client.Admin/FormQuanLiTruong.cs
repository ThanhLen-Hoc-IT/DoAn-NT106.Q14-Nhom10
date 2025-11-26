using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniGate.Application.DTOs.School;
using UniGate.Client;   // nơi chứa ApiClient

namespace UniGate.Client.Admin
{
    public partial class FormQuanLiTruong : Form
    {
        public FormQuanLiTruong()
        {
            InitializeComponent();
        }

        // ================================
        //  FORM LOAD → LOAD DANH SÁCH TRƯỜNG
        // ================================
        private async void FormQuanLiTruong_Load(object sender, EventArgs e)
        {
            await LoadSchools();
            SetupListView();
        }

        // Format ListView
        private void SetupListView()
        {
            lvSchools.View = View.Details;
            lvSchools.FullRowSelect = true;
            lvSchools.Columns.Clear();

            lvSchools.Columns.Add("ID", 80);
            lvSchools.Columns.Add("Mã Trường", 150);
            lvSchools.Columns.Add("Tên Trường", 400);
            lvSchools.Columns.Add("Tỉnh", 150);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await LoadSchools(txtSearch.Text.Trim());
        }

        // Load API
        private async Task LoadSchools(string keyword = "")
        {
            lvSchools.Items.Clear();

            string link = "api/schools";
            if (!string.IsNullOrWhiteSpace(keyword))
                link += $"?keyword={keyword}";

            var list = await ApiClient.GetAsync<List<SchoolDto>>(link);

            foreach (var s in list)
            {
                var item = new ListViewItem(s.Id.ToString());
                item.SubItems.Add(s.Code);
                item.SubItems.Add(s.Name);
                item.SubItems.Add(s.Province);

                lvSchools.Items.Add(item);
            }
        }

        // ================================
        //  NÚT TÌM KIẾM
        // ================================
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadSchools(txtSearch.Text.Trim());
        }

        // ================================
        //  NÚT THÊM TRƯỜNG
        // ================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new FormAddUniversity(); // chế độ ADD
            if (f.ShowDialog() == DialogResult.OK)
                _ = LoadSchools();
        }

        // ================================
        //  NÚT SỬA TRƯỜNG
        // ================================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvSchools.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn trường để sửa!");
                return;
            }

            int id = int.Parse(lvSchools.SelectedItems[0].Text);

            var f = new FormAddUniversity(id); // chế độ EDIT
            if (f.ShowDialog() == DialogResult.OK)
                _ = LoadSchools();
        }

        // ================================
        //  NÚT XÓA TRƯỜNG
        // ================================
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvSchools.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn trường để xóa!");
                return;
            }

            int id = int.Parse(lvSchools.SelectedItems[0].Text);

            if (MessageBox.Show("Bạn có chắc muốn xóa trường này?",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            await ApiClient.DeleteAsync($"api/schools/{id}");
            await LoadSchools();
        }
    }
}
