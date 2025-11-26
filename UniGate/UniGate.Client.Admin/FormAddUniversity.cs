using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniGate.Application.DTOs.School;

namespace UniGate.Client.Admin
{
    public partial class FormAddUniversity : Form
    {
        private int? editingId;   // null = thêm mới, != null = sửa

        public FormAddUniversity()
        {
            InitializeComponent();
        }

        public FormAddUniversity(int id)
        {
            InitializeComponent();
            editingId = id;
        }

        // =============================
        // ⭕ FORM LOAD
        // =============================
        private async void FormAddUniversity_Load(object sender, EventArgs e)
        {
            LoadProvince();

            if (editingId.HasValue)
            {
                // ======= LOAD DATA TỪ API =======
                var school = await ApiClient.GetAsync<SchoolDto>($"api/schools/{editingId.Value}");

                txtName.Text = school.Name;
                txtCode.Text = school.Code;
                txtDescription.Text = school.Description;
                cboProvince.SelectedItem = school.Province;

                txtLogo.Text = school.LogoUrl;

                // nếu đường dẫn logo là file thật → hiển thị
                if (!string.IsNullOrWhiteSpace(school.LogoUrl) && File.Exists(school.LogoUrl))
                {
                    picLogo.Image = Image.FromFile(school.LogoUrl);
                }

                btnLuu.Text = "Cập nhật";
            }
        }

        // =============================
        // ⭐ LOAD TỈNH
        // =============================
        private void LoadProvince()
        {
            string[] provinces =
            {
                "TP.HCM", "Hà Nội", "Đà Nẵng", "Cần Thơ", "An Giang", "Bà Rịa – Vũng Tàu",
                "Bắc Giang", "Bắc Kạn", "Bạc Liêu", "Bắc Ninh", "Bến Tre", "Bình Dương",
                "Bình Định", "Bình Phước", "Bình Thuận", "Cà Mau", "Cao Bằng", "Đắk Lắk",
                "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang",
                "Hà Nam", "Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hậu Giang", "Hòa Bình",
                "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lạng Sơn",
                "Lào Cai", "Lâm Đồng", "Long An", "Nam Định", "Nghệ An", "Ninh Bình",
                "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi",
                "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình",
                "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế", "Tiền Giang", "Trà Vinh",
                "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái"
            };

            cboProvince.Items.AddRange(provinces);

            if (cboProvince.Items.Count > 0)
                cboProvince.SelectedIndex = 0;
        }

        // =============================
        // ⭐ NÚT CHỌN LOGO
        // =============================
        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLogo.Text = dlg.FileName;
                picLogo.Image = Image.FromFile(dlg.FileName);
            }
        }

        // =============================
        // ⭐ NÚT IMPORT EXCEL
        // =============================
        private async void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel Files|*.xlsx;*.xls";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtImportFile.Text = dlg.FileName;

                bool ok = await ApiClient.UploadFileAsync("api/import/schools", dlg.FileName);
                if (ok)
                    MessageBox.Show("Import thành công!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Import thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================
        // ⭐ NÚT LƯU (THÊM HOẶC SỬA)
        // =============================
        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (editingId == null)
                await CreateSchool();
            else
                await UpdateSchool();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        // =============================
        // ⭐ THÊM TRƯỜNG
        // =============================
        private async Task CreateSchool()
        {
            var req = new SchoolCreateRequest
            {
                Name = txtName.Text.Trim(),
                Code = txtCode.Text.Trim(),
                Province = cboProvince.SelectedItem.ToString(),
                Description = txtDescription.Text.Trim(),
                LogoUrl = txtLogo.Text.Trim()
            };

            string result = await ApiClient.PostAsync("api/schools", req);
            MessageBox.Show(result);
        }

        // =============================
        // ⭐ SỬA TRƯỜNG
        // =============================
        private async Task UpdateSchool()
        {
            var req = new SchoolUpdateRequest
            {
                Id = editingId.Value,
                Name = txtName.Text.Trim(),
                Code = txtCode.Text.Trim(),
                Province = cboProvince.SelectedItem.ToString(),
                Description = txtDescription.Text.Trim(),
                LogoUrl = txtLogo.Text.Trim()
            };

            string result = await ApiClient.PutAsync($"api/schools/{editingId.Value}", req);
            MessageBox.Show(result);
        }
    }
}
