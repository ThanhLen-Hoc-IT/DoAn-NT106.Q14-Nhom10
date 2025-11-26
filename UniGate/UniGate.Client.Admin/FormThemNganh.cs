using UniGate.Application.DTOs.Major;
using UniGate.Application.DTOs.Combo;
using Newtonsoft.Json;

namespace UniGate.Client.Admin
{
    public partial class FormThemNganh : Form
    {
        private Guid? editingId;  // null = thêm, !null = sửa

        // ======== CONSTRUCTOR ========
        private int _schoolId;

        public FormThemNganh(int schoolId)
        {
            InitializeComponent();
            _schoolId = schoolId;
        }

       
        public FormThemNganh(Guid id, int schoolId)
        {
            InitializeComponent();
            editingId = id;
            _schoolId = schoolId;
        }


        // ======== LOAD TỔ HỢP ========
        private async Task LoadCombos()
        {
            var list = await ApiClient.GetAsync<List<ComboDto>>("api/combos");

            // Sắp xếp theo mã tổ hợp
            list = list.OrderBy(x => x.Code).ToList();

            chcklbToHop.Items.Clear();

            foreach (var combo in list)
            {
                chcklbToHop.Items.Add(combo);
            }
        }

        // ======== LOAD DỮ LIỆU NGÀNH KHI SỬA ========
        private async Task LoadMajorEditingData()
        {
            var m = await ApiClient.GetAsync<MajorDto>($"api/majors/{editingId}");

            txt_MaNganh.Text = m.MajorCode;
            txt_TenNganh.Text = m.Name;
            txtDiemChuan.Text = m.CutoffScore.ToString();

            // tick tổ hợp
            for (int i = 0; i < chcklbToHop.Items.Count; i++)
            {
                var item = chcklbToHop.Items[i] as ComboDto;

                if (item != null && m.Combos.Contains(item.Code))
                    chcklbToHop.SetItemChecked(i, true);
            }

            btnSave.Text = "Cập nhật";
        }



        // ======== THÊM NGÀNH ========
        private async Task CreateMajor()
        {
            var req = new MajorCreateRequest
            {
                MajorCode = txt_MaNganh.Text.Trim(),
                Name = txt_TenNganh.Text.Trim(),
                CutoffScore = float.Parse(txtDiemChuan.Text.Trim()),

                // lấy từ form cha
                SchoolId = _schoolId,


                ComboIds = GetSelectedComboIds()
            };

            string kq = await ApiClient.PostAsync("api/majors", req);
            MessageBox.Show(kq);
        }

        // ======== CẬP NHẬT NGÀNH ========
        private async Task UpdateMajor()
        {
            var req = new MajorUpdateRequest
            {
                Id = editingId.Value,
                MajorCode = txt_MaNganh.Text.Trim(),
                Name = txt_TenNganh.Text.Trim(),
                CutoffScore = float.Parse(txtDiemChuan.Text.Trim()),

                SchoolId = _schoolId,


                ComboIds = GetSelectedComboIds()
            };

            string kq = await ApiClient.PutAsync($"api/majors/{editingId}", req);
            MessageBox.Show(kq);
        }

        // ======== LẤY DANH SÁCH TỔ HỢP CHECKED ========
        private List<Guid> GetSelectedComboIds()
        {
            var list = new List<Guid>();

            foreach (var item in chcklbToHop.CheckedItems)
            {
                if (item is ComboDto cb)
                    list.Add(cb.Id);
            }

            return list;
        }

        // ======== VALIDATE ========
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txt_MaNganh.Text))
            {
                MessageBox.Show("Mã ngành không được để trống!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_TenNganh.Text))
            {
                MessageBox.Show("Tên ngành không được để trống!");
                return false;
            }

            if (!float.TryParse(txtDiemChuan.Text.Trim(), out _))
            {
                MessageBox.Show("Điểm chuẩn phải là số!");
                return false;
            }

            if (chcklbToHop.CheckedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn ít nhất 1 tổ hợp!");
                return false;
            }

            return true;
        }



        private async void btnImport_Click_1(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Excel File|*.xlsx";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtImport.Text = dlg.FileName;

                // Chỉ chọn file, chưa lưu DB
                txtImport.Text = dlg.FileName;

                MessageBox.Show("File đã được chọn. Bấm LƯU để lưu vào hệ thống.");

            }
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            // Nếu có file import thì lưu bằng file
            if (!string.IsNullOrWhiteSpace(txtImport.Text))
            {
                bool success = await ApiClient.UploadFileAsync("api/import/majors", txtImport.Text);

                MessageBox.Show(success ? "Lưu thành công từ file Excel!" : "Lưu thất bại!");
                this.DialogResult = DialogResult.OK;
                Close();
                return;
            }

            // Ngược lại → thêm ngành thủ công
            if (!ValidateInput()) return;

            if (editingId == null)
                await CreateMajor();
            else
                await UpdateMajor();

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private async void FormThemNganh_Load_1(object sender, EventArgs e)
        {
            await LoadCombos();

            if (editingId.HasValue)
                await LoadMajorEditingData();
        }
    }

    // ======== CLASS ITEM TỔ HỢP ========
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString() => Text;
    }
}
