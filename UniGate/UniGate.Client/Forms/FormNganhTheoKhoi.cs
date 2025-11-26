using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UniGate.Client;
using UniGate.Client.Models;
using UniGate.Client.Utils;

namespace UniGate.Client
{
    public partial class FormNganhTheoKhoi : Form
    {
        private List<string> _selectedCombos;
        private Dictionary<string, float> _dsDiemToHop;

        public FormNganhTheoKhoi(List<string> selectedCombos,
                                 Dictionary<string, float> dsDiemToHop)
        {
            InitializeComponent();
            _selectedCombos = selectedCombos;
            _dsDiemToHop = dsDiemToHop;
        }
        public FormNganhTheoKhoi(List<string> selectedCombos)
        {
            InitializeComponent();
            _selectedCombos = selectedCombos;
        }


        private async void FormNganhTheoKhoi_Load(object sender, EventArgs e)
        {
            SessionManager.UserId = Guid.Parse("11111111-1111-1111-1111-111111111111");
            try
            {
                Guid uid = SessionManager.UserId;
                // TEST TẠM
                // uid = Guid.Parse("11111111-1111-1111-1111-111111111111");

                var majors = await ApiClient.GetAsync<List<MajorResponse>>(
                    $"api/majors/by-combos/{uid}"
                );

                majors ??= new List<MajorResponse>();

                LoadListView(majors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu ngành:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void LoadListView(List<MajorResponse> list)
        {
            listViewNganh.View = View.Details;
            listViewNganh.FullRowSelect = true;
            listViewNganh.GridLines = true;

            listViewNganh.Columns.Clear();
            listViewNganh.Columns.Add("Ngành", 300);
            listViewNganh.Columns.Add("Trường", 300);
            listViewNganh.Columns.Add("Tổ hợp xét tuyển", 250);
            listViewNganh.Columns.Add("Điểm chuẩn", 130);

            listViewNganh.Items.Clear();

            foreach (var m in list)
            {
                var item = new ListViewItem(m.Name);
                item.SubItems.Add(m.SchoolName);
                item.SubItems.Add(string.Join(", ", m.ComboCodes));
                item.SubItems.Add(m.LastYearScore?.ToString("0.00") ?? "-");

                listViewNganh.Items.Add(item);
            }
        }
    }
}
