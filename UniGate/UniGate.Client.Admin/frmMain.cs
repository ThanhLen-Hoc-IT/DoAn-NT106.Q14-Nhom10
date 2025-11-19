namespace UniGate.Client.Admin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        void btnAdd_Click(object sender, EventArgs e)
        {
            menuAdd.Show(btnAdd,
                           new Point(0, btnAdd.Height));
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            menuDelete.Show(btnDelete,
                           new Point(0, btnDelete.Height));
        }

        void btnUpdate_Click(object sender, EventArgs e)
        {
            menuUpdate.Show(btnUpdate,
                           new Point(0, btnUpdate.Height));
        }

    }
}
