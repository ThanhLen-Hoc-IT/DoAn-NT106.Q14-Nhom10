using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// ***************************************************************
// CHỈ GIỮ LẠI CÁC USING CẦN THIẾT NHẤT VÀ KHÔNG TRÙNG LẶP
// ***************************************************************
using UniGate.Domain;           // Chứa ScoreInputModel
using UniGate.Client.Services;  // Chứa SuggestClient
using UniGate.Shared.DTOs;      // <== BẠN CẦN THÊM DÒNG NÀY! (Chứa AdmissionResultDTO)

namespace UniGate.Client.Forms
{
    public partial class SuggestForm : Form
    {
        // THAY THẾ AdmissionService bằng SuggestClient (hoặc lớp Service/Client đúng của bạn)
        private readonly SuggestClient _admissionService = new SuggestClient();

        // Vẫn dùng AdmissionData, giả định nó được tìm thấy trong UniGate.Domain
        private List<AdmissionResultDTO> _allAdmissionData = new List<AdmissionResultDTO>();

        public SuggestForm()
        {
            InitializeComponent();
            LoadInitialData();
            SetupDataGridView();
        }

        private void LoadInitialData()
        {
            try
            {
                // Gọi phương thức từ SuggestClient (Giả định có phương thức này)
                _allAdmissionData = _admissionService.GetAdmissionDataFromDatabaseOrAPI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _allAdmissionData = new List<AdmissionResultDTO>();
            }

            var combinations = _allAdmissionData
                                .Select(d => d.CombinationCode)
                                .Distinct()
                                .OrderBy(c => c)
                                .ToList();

            // Giả định tên Control trên Form: cboToHop, cboChonVung
            cboToHop.DataSource = combinations;
            cboToHop.SelectedIndex = -1;
            cboChonVung.Items.AddRange(new object[] { "Khu vực 1 (KV1)", "Khu vực 2 (KV2)", "Khu vực 3 (KV3)" });
            cboChonVung.SelectedIndex = -1;
        }

        private void SetupDataGridView()
        {
            // SỬA LỖI CS1061 (Đã làm ở bước trước, chỉ giữ lại code đã sửa đúng)
            dgvKetQua.AutoGenerateColumns = false;

            // Xóa cột cũ để tránh lỗi.
            dgvKetQua.Columns.Clear();

            // Khai báo cột
            dgvKetQua.Columns.Add("UniversityName", "Trường");
            dgvKetQua.Columns.Add("MajorCode", "Mã Ngành");
            dgvKetQua.Columns.Add("MajorName", "Tên Ngành");
            dgvKetQua.Columns.Add("BenchmarkScore", "Điểm Chuẩn");
            dgvKetQua.Columns.Add("ScoreDifference", "Chênh Lệch");
            dgvKetQua.Columns.Add("Probability", "Khả Năng");

            // Gán DataPropertyName
            dgvKetQua.Columns["UniversityName"].DataPropertyName = "UniversityName";
            dgvKetQua.Columns["MajorCode"].DataPropertyName = "MajorCode";
            dgvKetQua.Columns["MajorName"].DataPropertyName = "MajorName";
            dgvKetQua.Columns["BenchmarkScore"].DataPropertyName = "BenchmarkScore";
            dgvKetQua.Columns["ScoreDifference"].DataPropertyName = "ScoreDifference";
            dgvKetQua.Columns["Probability"].DataPropertyName = "Probability";

            dgvKetQua.Columns["BenchmarkScore"].DefaultCellStyle.Format = "N2";
            dgvKetQua.Columns["ScoreDifference"].DefaultCellStyle.Format = "N2";
            dgvKetQua.CellFormatting += DgvKetQua_CellFormatting;
        }

        private void DgvKetQua_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            // SỬA LỖI NULLABILITY (CS8602)
            if (e.ColumnIndex == dgvKetQua.Columns["Probability"]?.Index && e.RowIndex >= 0)
            {
                if (e.Value is string probability)
                {
                    if (probability.Contains("Rất Cao")) e.CellStyle.ForeColor = Color.Green;
                    else if (probability.Contains("Cao")) e.CellStyle.ForeColor = Color.DarkGreen;
                    else if (probability.Contains("Cân nhắc")) e.CellStyle.ForeColor = Color.Orange;
                    else if (probability.Contains("Khó")) e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btnXemGoiY_Click(object? sender, EventArgs e)
        {
            double tongDiemThi, diemUT;

            // Giả định tên Control trên Form: txtTongDiem, txtDiemUT
            if (!double.TryParse(txtTongDiem.Text, out tongDiemThi) || tongDiemThi <= 0)
            {
                MessageBox.Show("Vui lòng nhập Tổng điểm thi hợp lệ và lớn hơn 0.", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongDiem.Focus();
                return;
            }

            if (!double.TryParse(txtDiemUT.Text, out diemUT)) diemUT = 0;

            double finalScore = tongDiemThi + diemUT;

            string selectedCombination = cboToHop.SelectedItem as string ?? string.Empty;

            if (string.IsNullOrEmpty(selectedCombination))
            {
                MessageBox.Show("Vui lòng chọn Tổ hợp môn.", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SỬA: UserInput được tìm thấy qua using UniGate.Domain;
            var userInput = new ScoreInputModel
            {
                UserTotalScore = finalScore,
                SelectedCombination = selectedCombination
            };

            // Gọi phương thức từ SuggestClient (Giả định có phương thức này)
            var possibleMajors = _admissionService.FindPossibleMajors(userInput, _allAdmissionData);

            dgvKetQua.DataSource = possibleMajors;

            if (possibleMajors.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy ngành nào phù hợp với điểm {finalScore} và tổ hợp {selectedCombination}.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}