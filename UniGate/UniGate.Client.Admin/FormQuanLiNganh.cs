using Newtonsoft.Json;
using UniGate.Application.DTOs.School;
using UniGate.Application.DTOs.Major;

namespace UniGate.Client.Admin
{
    public partial class FormQuanLiNganh : Form
    {
        public static int SelectedSchoolId;
       
     

        public FormQuanLiNganh()
        {
            InitializeComponent();
        }

        // ================== FORM LOAD ==================
        private async void FormQuanLiNganh_Load(object sender, EventArgs e)
        {
            await LoadSchools();
            if (cbbTruong.Items.Count > 0)
            {
                SelectedSchoolId = (int)cbbTruong.SelectedValue;
            }

            cbbTruong.SelectedIndexChanged += cbbTruong_SelectedIndexChanged;
            SetupListView();




        }

        private async void cbbTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTruong.SelectedValue == null)
                return;

            SelectedSchoolId = (int)cbbTruong.SelectedValue;

            await LoadMajors();
        }


        private void SetupListView()
        {
            lvNganh.View = View.Details;
            lvNganh.FullRowSelect = true;
            lvNganh.Columns.Clear();

            lvNganh.Columns.Add("ID", 150);

            lvNganh.Columns.Add("Mã ngành", 120);
            lvNganh.Columns.Add("Tên ngành", 250);
            lvNganh.Columns.Add("Điểm chuẩn", 120);
            lvNganh.Columns.Add("Tổ hợp", 200);
        }

        // ================== LOAD TRƯỜNG ==================
        private async Task LoadSchools()
        {
            var schools = await ApiClient.GetAsync<List<SchoolDto>>("api/schools");

            cbbTruong.DisplayMember = "Name";
            cbbTruong.ValueMember = "Id";

            cbbTruong.DataSource = schools;
        }

        // ================== LOAD NGÀNH THEO TRƯỜNG ==================
        private async Task LoadMajors()
        {
            if (SelectedSchoolId == 0) return;

            var list = await ApiClient.GetAsync<List<MajorDto>>(
                $"api/majors?schoolId={SelectedSchoolId}"
            );

            lvNganh.Items.Clear();

            foreach (var m in list)
            {
                var row = new ListViewItem(m.Id.ToString());

                row.Tag = m.Id;   // ⭐⭐ BẮT BUỘC PHẢI CÓ DÒNG NÀY

                row.SubItems.Add(m.MajorCode);
                row.SubItems.Add(m.Name);
                row.SubItems.Add(m.CutoffScore.ToString());
                row.SubItems.Add(string.Join(", ", m.Combos));

                lvNganh.Items.Add(row);
            }
        }




       
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            var frm = new FormThemNganh(SelectedSchoolId);
            if (frm.ShowDialog() == DialogResult.OK)
                _ = LoadMajors();

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Guid id = (Guid)lvNganh.SelectedItems[0].Tag;

            var frm = new FormThemNganh(id, SelectedSchoolId);
            if (frm.ShowDialog() == DialogResult.OK)
                _ = LoadMajors();

        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (lvNganh.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn ngành cần xóa.");
                return;
            }

            Guid id = (Guid)lvNganh.SelectedItems[0].Tag;

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa ngành này?",
                "Xác nhận", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.No) return;

            await ApiClient.DeleteAsync($"api/majors/{id}");

            await LoadMajors();
        }
    }
}
