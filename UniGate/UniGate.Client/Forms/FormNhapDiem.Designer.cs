namespace UniGate.Client.Forms
{
    partial class FormNhapDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapDiem));
            label1 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableHocBa = new TableLayoutPanel();
            txt12_Tin = new TextBox();
            txt11_Tin = new TextBox();
            txt10_Tin = new TextBox();
            txt12_Dia = new TextBox();
            txt11_Dia = new TextBox();
            txt10_Dia = new TextBox();
            txt12_Su = new TextBox();
            txt11_Su = new TextBox();
            txt10_Su = new TextBox();
            txt12_Sinh = new TextBox();
            txt11_Sinh = new TextBox();
            txt10_Sinh = new TextBox();
            txt12_Hoa = new TextBox();
            txt11_Hoa = new TextBox();
            txt10_Hoa = new TextBox();
            txt12_Ly = new TextBox();
            txt11_Ly = new TextBox();
            txt10_Ly = new TextBox();
            txt12_GDKTPL = new TextBox();
            txt11_GDKTPL = new TextBox();
            txt10_GDKTPL = new TextBox();
            txt12_Anh = new TextBox();
            txt11_Anh = new TextBox();
            txt10_Anh = new TextBox();
            txt12_Van = new TextBox();
            txt11_Van = new TextBox();
            txt10_Van = new TextBox();
            txt12_Toan = new TextBox();
            txt11_Toan = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txt10_Toan = new TextBox();
            tabPage2 = new TabPage();
            label22 = new Label();
            gbTuChon2 = new GroupBox();
            txtTHPT_Mon2 = new TextBox();
            label21 = new Label();
            cbTHPT_Mon2 = new ComboBox();
            label20 = new Label();
            gbTuChon1 = new GroupBox();
            txtTHPT_Mon1 = new TextBox();
            label19 = new Label();
            label18 = new Label();
            cbTHPT_Mon1 = new ComboBox();
            gbBatBuoc = new GroupBox();
            txtTHPT_Van = new TextBox();
            txtTHPT_Toan = new TextBox();
            label17 = new Label();
            label16 = new Label();
            tabPage3 = new TabPage();
            label26 = new Label();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            tabPage4 = new TabPage();
            button2 = new Button();
            panel2 = new Panel();
            txtDiemCong = new TextBox();
            label29 = new Label();
            cbKhuVuc = new ComboBox();
            label27 = new Label();
            cbDoiTuong = new ComboBox();
            label28 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableHocBa.SuspendLayout();
            tabPage2.SuspendLayout();
            gbTuChon2.SuspendLayout();
            gbTuChon1.SuspendLayout();
            gbBatBuoc.SuspendLayout();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            tabPage4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(415, 40);
            label1.Name = "label1";
            label1.Size = new Size(229, 52);
            label1.TabIndex = 2;
            label1.Text = "Nhập Điểm";
            // 
            // button1
            // 
            button1.Location = new Point(267, 143);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 3;
            button1.Text = "Nhập điểm ";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(85, 124);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(831, 889);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableHocBa);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(815, 835);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Học Bạ";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tableHocBa
            // 
            tableHocBa.ColumnCount = 4;
            tableHocBa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 183F));
            tableHocBa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 204F));
            tableHocBa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 208F));
            tableHocBa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableHocBa.Controls.Add(txt12_Tin, 3, 10);
            tableHocBa.Controls.Add(txt11_Tin, 2, 10);
            tableHocBa.Controls.Add(txt10_Tin, 1, 10);
            tableHocBa.Controls.Add(txt12_Dia, 3, 9);
            tableHocBa.Controls.Add(txt11_Dia, 2, 9);
            tableHocBa.Controls.Add(txt10_Dia, 1, 9);
            tableHocBa.Controls.Add(txt12_Su, 3, 8);
            tableHocBa.Controls.Add(txt11_Su, 2, 8);
            tableHocBa.Controls.Add(txt10_Su, 1, 8);
            tableHocBa.Controls.Add(txt12_Sinh, 3, 7);
            tableHocBa.Controls.Add(txt11_Sinh, 2, 7);
            tableHocBa.Controls.Add(txt10_Sinh, 1, 7);
            tableHocBa.Controls.Add(txt12_Hoa, 3, 6);
            tableHocBa.Controls.Add(txt11_Hoa, 2, 6);
            tableHocBa.Controls.Add(txt10_Hoa, 1, 6);
            tableHocBa.Controls.Add(txt12_Ly, 3, 5);
            tableHocBa.Controls.Add(txt11_Ly, 2, 5);
            tableHocBa.Controls.Add(txt10_Ly, 1, 5);
            tableHocBa.Controls.Add(txt12_GDKTPL, 3, 4);
            tableHocBa.Controls.Add(txt11_GDKTPL, 2, 4);
            tableHocBa.Controls.Add(txt10_GDKTPL, 1, 4);
            tableHocBa.Controls.Add(txt12_Anh, 3, 3);
            tableHocBa.Controls.Add(txt11_Anh, 2, 3);
            tableHocBa.Controls.Add(txt10_Anh, 1, 3);
            tableHocBa.Controls.Add(txt12_Van, 3, 2);
            tableHocBa.Controls.Add(txt11_Van, 2, 2);
            tableHocBa.Controls.Add(txt10_Van, 1, 2);
            tableHocBa.Controls.Add(txt12_Toan, 3, 1);
            tableHocBa.Controls.Add(txt11_Toan, 2, 1);
            tableHocBa.Controls.Add(label2, 0, 0);
            tableHocBa.Controls.Add(label3, 1, 0);
            tableHocBa.Controls.Add(label4, 2, 0);
            tableHocBa.Controls.Add(label5, 3, 0);
            tableHocBa.Controls.Add(label6, 0, 1);
            tableHocBa.Controls.Add(label7, 0, 2);
            tableHocBa.Controls.Add(label8, 0, 3);
            tableHocBa.Controls.Add(label9, 0, 4);
            tableHocBa.Controls.Add(label10, 0, 5);
            tableHocBa.Controls.Add(label11, 0, 6);
            tableHocBa.Controls.Add(label12, 0, 7);
            tableHocBa.Controls.Add(label13, 0, 8);
            tableHocBa.Controls.Add(label14, 0, 9);
            tableHocBa.Controls.Add(label15, 0, 10);
            tableHocBa.Controls.Add(txt10_Toan, 1, 1);
            tableHocBa.Dock = DockStyle.Left;
            tableHocBa.Location = new Point(3, 3);
            tableHocBa.Name = "tableHocBa";
            tableHocBa.RowCount = 11;
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Percent, 50.37594F));
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Percent, 49.62406F));
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableHocBa.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableHocBa.Size = new Size(794, 829);
            tableHocBa.TabIndex = 0;
            // 
            // txt12_Tin
            // 
            txt12_Tin.Dock = DockStyle.Fill;
            txt12_Tin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12_Tin.Location = new Point(598, 757);
            txt12_Tin.Multiline = true;
            txt12_Tin.Name = "txt12_Tin";
            txt12_Tin.Size = new Size(193, 69);
            txt12_Tin.TabIndex = 42;
            txt12_Tin.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11_Tin
            // 
            txt11_Tin.Dock = DockStyle.Fill;
            txt11_Tin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11_Tin.Location = new Point(390, 757);
            txt11_Tin.Multiline = true;
            txt11_Tin.Name = "txt11_Tin";
            txt11_Tin.Size = new Size(202, 69);
            txt11_Tin.TabIndex = 41;
            txt11_Tin.TextAlign = HorizontalAlignment.Center;
            // 
            // txt10_Tin
            // 
            txt10_Tin.Dock = DockStyle.Fill;
            txt10_Tin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt10_Tin.Location = new Point(186, 757);
            txt10_Tin.Multiline = true;
            txt10_Tin.Name = "txt10_Tin";
            txt10_Tin.Size = new Size(198, 69);
            txt10_Tin.TabIndex = 40;
            txt10_Tin.TextAlign = HorizontalAlignment.Center;
            // 
            // txt12_Dia
            // 
            txt12_Dia.Dock = DockStyle.Fill;
            txt12_Dia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12_Dia.Location = new Point(598, 675);
            txt12_Dia.Multiline = true;
            txt12_Dia.Name = "txt12_Dia";
            txt12_Dia.Size = new Size(193, 76);
            txt12_Dia.TabIndex = 39;
            txt12_Dia.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11_Dia
            // 
            txt11_Dia.Dock = DockStyle.Fill;
            txt11_Dia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11_Dia.Location = new Point(390, 675);
            txt11_Dia.Multiline = true;
            txt11_Dia.Name = "txt11_Dia";
            txt11_Dia.Size = new Size(202, 76);
            txt11_Dia.TabIndex = 38;
            txt11_Dia.TextAlign = HorizontalAlignment.Center;
            // 
            // txt10_Dia
            // 
            txt10_Dia.Dock = DockStyle.Fill;
            txt10_Dia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt10_Dia.Location = new Point(186, 675);
            txt10_Dia.Multiline = true;
            txt10_Dia.Name = "txt10_Dia";
            txt10_Dia.Size = new Size(198, 76);
            txt10_Dia.TabIndex = 37;
            txt10_Dia.TextAlign = HorizontalAlignment.Center;
            // 
            // txt12_Su
            // 
            txt12_Su.Dock = DockStyle.Fill;
            txt12_Su.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12_Su.Location = new Point(598, 594);
            txt12_Su.Multiline = true;
            txt12_Su.Name = "txt12_Su";
            txt12_Su.Size = new Size(193, 75);
            txt12_Su.TabIndex = 36;
            txt12_Su.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11_Su
            // 
            txt11_Su.Dock = DockStyle.Fill;
            txt11_Su.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11_Su.Location = new Point(390, 594);
            txt11_Su.Multiline = true;
            txt11_Su.Name = "txt11_Su";
            txt11_Su.Size = new Size(202, 75);
            txt11_Su.TabIndex = 35;
            txt11_Su.TextAlign = HorizontalAlignment.Center;
            // 
            // txt10_Su
            // 
            txt10_Su.Dock = DockStyle.Fill;
            txt10_Su.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt10_Su.Location = new Point(186, 594);
            txt10_Su.Multiline = true;
            txt10_Su.Name = "txt10_Su";
            txt10_Su.Size = new Size(198, 75);
            txt10_Su.TabIndex = 34;
            txt10_Su.TextAlign = HorizontalAlignment.Center;
            // 
            // txt12_Sinh
            // 
            txt12_Sinh.Dock = DockStyle.Fill;
            txt12_Sinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12_Sinh.Location = new Point(598, 514);
            txt12_Sinh.Multiline = true;
            txt12_Sinh.Name = "txt12_Sinh";
            txt12_Sinh.Size = new Size(193, 74);
            txt12_Sinh.TabIndex = 33;
            txt12_Sinh.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11_Sinh
            // 
            txt11_Sinh.Dock = DockStyle.Fill;
            txt11_Sinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11_Sinh.Location = new Point(390, 514);
            txt11_Sinh.Multiline = true;
            txt11_Sinh.Name = "txt11_Sinh";
            txt11_Sinh.Size = new Size(202, 74);
            txt11_Sinh.TabIndex = 32;
            txt11_Sinh.TextAlign = HorizontalAlignment.Center;
            // 
            // txt10_Sinh
            // 
            txt10_Sinh.Dock = DockStyle.Fill;
            txt10_Sinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt10_Sinh.Location = new Point(186, 514);
            txt10_Sinh.Multiline = true;
            txt10_Sinh.Name = "txt10_Sinh";
            txt10_Sinh.Size = new Size(198, 74);
            txt10_Sinh.TabIndex = 31;
            txt10_Sinh.TextAlign = HorizontalAlignment.Center;
            // 
            // txt12_Hoa
            // 
            txt12_Hoa.Dock = DockStyle.Fill;
            txt12_Hoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12_Hoa.Location = new Point(598, 439);
            txt12_Hoa.Multiline = true;
            txt12_Hoa.Name = "txt12_Hoa";
            txt12_Hoa.Size = new Size(193, 69);
            txt12_Hoa.TabIndex = 30;
            txt12_Hoa.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11_Hoa
            // 
            txt11_Hoa.Dock = DockStyle.Fill;
            txt11_Hoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11_Hoa.Location = new Point(390, 439);
            txt11_Hoa.Multiline = true;
            txt11_Hoa.Name = "txt11_Hoa";
            txt11_Hoa.Size = new Size(202, 69);
            txt11_Hoa.TabIndex = 29;
            txt11_Hoa.TextAlign = HorizontalAlignment.Center;
            // 
            // txt10_Hoa
            // 
            txt10_Hoa.Dock = DockStyle.Fill;
            txt10_Hoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt10_Hoa.Location = new Point(186, 439);
            txt10_Hoa.Multiline = true;
            txt10_Hoa.Name = "txt10_Hoa";
            txt10_Hoa.Size = new Size(198, 69);
            txt10_Hoa.TabIndex = 28;
            txt10_Hoa.TextAlign = HorizontalAlignment.Center;
            // 
            // txt12_Ly
            // 
            txt12_Ly.Dock = DockStyle.Fill;
            txt12_Ly.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12_Ly.Location = new Point(598, 363);
            txt12_Ly.Multiline = true;
            txt12_Ly.Name = "txt12_Ly";
            txt12_Ly.Size = new Size(193, 70);
            txt12_Ly.TabIndex = 27;
            txt12_Ly.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11_Ly
            // 
            txt11_Ly.Dock = DockStyle.Fill;
            txt11_Ly.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11_Ly.Location = new Point(390, 363);
            txt11_Ly.Multiline = true;
            txt11_Ly.Name = "txt11_Ly";
            txt11_Ly.Size = new Size(202, 70);
            txt11_Ly.TabIndex = 26;
            txt11_Ly.TextAlign = HorizontalAlignment.Center;
            // 
            // txt10_Ly
            // 
            txt10_Ly.Dock = DockStyle.Fill;
            txt10_Ly.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt10_Ly.Location = new Point(186, 363);
            txt10_Ly.Multiline = true;
            txt10_Ly.Name = "txt10_Ly";
            txt10_Ly.Size = new Size(198, 70);
            txt10_Ly.TabIndex = 25;
            txt10_Ly.TextAlign = HorizontalAlignment.Center;
            // 
            // txt12_GDKTPL
            // 
            txt12_GDKTPL.Dock = DockStyle.Fill;
            txt12_GDKTPL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12_GDKTPL.Location = new Point(598, 293);
            txt12_GDKTPL.Multiline = true;
            txt12_GDKTPL.Name = "txt12_GDKTPL";
            txt12_GDKTPL.Size = new Size(193, 64);
            txt12_GDKTPL.TabIndex = 24;
            txt12_GDKTPL.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11_GDKTPL
            // 
            txt11_GDKTPL.Dock = DockStyle.Fill;
            txt11_GDKTPL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11_GDKTPL.Location = new Point(390, 293);
            txt11_GDKTPL.Multiline = true;
            txt11_GDKTPL.Name = "txt11_GDKTPL";
            txt11_GDKTPL.Size = new Size(202, 64);
            txt11_GDKTPL.TabIndex = 23;
            txt11_GDKTPL.TextAlign = HorizontalAlignment.Center;
            // 
            // txt10_GDKTPL
            // 
            txt10_GDKTPL.Dock = DockStyle.Fill;
            txt10_GDKTPL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt10_GDKTPL.Location = new Point(186, 293);
            txt10_GDKTPL.Multiline = true;
            txt10_GDKTPL.Name = "txt10_GDKTPL";
            txt10_GDKTPL.Size = new Size(198, 64);
            txt10_GDKTPL.TabIndex = 22;
            txt10_GDKTPL.TextAlign = HorizontalAlignment.Center;
            // 
            // txt12_Anh
            // 
            txt12_Anh.Dock = DockStyle.Fill;
            txt12_Anh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12_Anh.Location = new Point(598, 217);
            txt12_Anh.Multiline = true;
            txt12_Anh.Name = "txt12_Anh";
            txt12_Anh.Size = new Size(193, 70);
            txt12_Anh.TabIndex = 21;
            txt12_Anh.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11_Anh
            // 
            txt11_Anh.Dock = DockStyle.Fill;
            txt11_Anh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11_Anh.Location = new Point(390, 217);
            txt11_Anh.Multiline = true;
            txt11_Anh.Name = "txt11_Anh";
            txt11_Anh.Size = new Size(202, 70);
            txt11_Anh.TabIndex = 20;
            txt11_Anh.TextAlign = HorizontalAlignment.Center;
            // 
            // txt10_Anh
            // 
            txt10_Anh.Dock = DockStyle.Fill;
            txt10_Anh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt10_Anh.Location = new Point(186, 217);
            txt10_Anh.Multiline = true;
            txt10_Anh.Name = "txt10_Anh";
            txt10_Anh.Size = new Size(198, 70);
            txt10_Anh.TabIndex = 19;
            txt10_Anh.TextAlign = HorizontalAlignment.Center;
            // 
            // txt12_Van
            // 
            txt12_Van.Dock = DockStyle.Fill;
            txt12_Van.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12_Van.Location = new Point(598, 142);
            txt12_Van.Multiline = true;
            txt12_Van.Name = "txt12_Van";
            txt12_Van.Size = new Size(193, 69);
            txt12_Van.TabIndex = 18;
            txt12_Van.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11_Van
            // 
            txt11_Van.Dock = DockStyle.Fill;
            txt11_Van.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11_Van.Location = new Point(390, 142);
            txt11_Van.Multiline = true;
            txt11_Van.Name = "txt11_Van";
            txt11_Van.Size = new Size(202, 69);
            txt11_Van.TabIndex = 17;
            txt11_Van.TextAlign = HorizontalAlignment.Center;
            // 
            // txt10_Van
            // 
            txt10_Van.Dock = DockStyle.Fill;
            txt10_Van.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt10_Van.Location = new Point(186, 142);
            txt10_Van.Multiline = true;
            txt10_Van.Name = "txt10_Van";
            txt10_Van.Size = new Size(198, 69);
            txt10_Van.TabIndex = 16;
            txt10_Van.TextAlign = HorizontalAlignment.Center;
            // 
            // txt12_Toan
            // 
            txt12_Toan.Dock = DockStyle.Fill;
            txt12_Toan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12_Toan.Location = new Point(598, 73);
            txt12_Toan.Multiline = true;
            txt12_Toan.Name = "txt12_Toan";
            txt12_Toan.Size = new Size(193, 63);
            txt12_Toan.TabIndex = 15;
            txt12_Toan.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11_Toan
            // 
            txt11_Toan.Dock = DockStyle.Fill;
            txt11_Toan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11_Toan.Location = new Point(390, 73);
            txt11_Toan.Multiline = true;
            txt11_Toan.Name = "txt11_Toan";
            txt11_Toan.Size = new Size(202, 63);
            txt11_Toan.TabIndex = 14;
            txt11_Toan.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 70);
            label2.TabIndex = 0;
            label2.Text = "Môn Học";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(186, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 70);
            label3.TabIndex = 1;
            label3.Text = "Cả năm lớp 10";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 70);
            label4.TabIndex = 2;
            label4.Text = "Cả năm lớp 11";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(598, 0);
            label5.Name = "label5";
            label5.Size = new Size(193, 70);
            label5.TabIndex = 3;
            label5.Text = "Cả năm lớp 12";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 70);
            label6.Name = "label6";
            label6.Size = new Size(177, 69);
            label6.TabIndex = 4;
            label6.Text = "Toán";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 139);
            label7.Name = "label7";
            label7.Size = new Size(177, 75);
            label7.TabIndex = 5;
            label7.Text = "Văn";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 214);
            label8.Name = "label8";
            label8.Size = new Size(177, 76);
            label8.TabIndex = 6;
            label8.Text = "Tiếng Anh";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 290);
            label9.Name = "label9";
            label9.Size = new Size(177, 70);
            label9.TabIndex = 7;
            label9.Text = "GDKTPL";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 360);
            label10.Name = "label10";
            label10.Size = new Size(177, 76);
            label10.TabIndex = 8;
            label10.Text = "Vật Lí";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 436);
            label11.Name = "label11";
            label11.Size = new Size(177, 75);
            label11.TabIndex = 9;
            label11.Text = "Hóa Học";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 511);
            label12.Name = "label12";
            label12.Size = new Size(177, 80);
            label12.TabIndex = 10;
            label12.Text = "Sinh Học";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 591);
            label13.Name = "label13";
            label13.Size = new Size(177, 81);
            label13.TabIndex = 11;
            label13.Text = "Lịch Sử";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 672);
            label14.Name = "label14";
            label14.Size = new Size(177, 82);
            label14.TabIndex = 12;
            label14.Text = "Địa Lí";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 754);
            label15.Name = "label15";
            label15.Size = new Size(177, 75);
            label15.TabIndex = 13;
            label15.Text = "Tin Học";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt10_Toan
            // 
            txt10_Toan.Dock = DockStyle.Fill;
            txt10_Toan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt10_Toan.Location = new Point(186, 73);
            txt10_Toan.Multiline = true;
            txt10_Toan.Name = "txt10_Toan";
            txt10_Toan.Size = new Size(198, 63);
            txt10_Toan.TabIndex = 6;
            txt10_Toan.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(gbTuChon2);
            tabPage2.Controls.Add(gbTuChon1);
            tabPage2.Controls.Add(gbBatBuoc);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(815, 835);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "THPT QG";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.IndianRed;
            label22.Location = new Point(32, 743);
            label22.Name = "label22";
            label22.Size = new Size(657, 45);
            label22.TabIndex = 9;
            label22.Text = "⚠ Hai môn tự chọn không được trùng nhau";
            // 
            // gbTuChon2
            // 
            gbTuChon2.BackgroundImageLayout = ImageLayout.Stretch;
            gbTuChon2.Controls.Add(txtTHPT_Mon2);
            gbTuChon2.Controls.Add(label21);
            gbTuChon2.Controls.Add(cbTHPT_Mon2);
            gbTuChon2.Controls.Add(label20);
            gbTuChon2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTuChon2.Location = new Point(32, 509);
            gbTuChon2.Name = "gbTuChon2";
            gbTuChon2.Size = new Size(736, 210);
            gbTuChon2.TabIndex = 5;
            gbTuChon2.TabStop = false;
            gbTuChon2.Text = "Môn Tự Chọn 2";
            // 
            // txtTHPT_Mon2
            // 
            txtTHPT_Mon2.Location = new Point(333, 129);
            txtTHPT_Mon2.Name = "txtTHPT_Mon2";
            txtTHPT_Mon2.Size = new Size(200, 50);
            txtTHPT_Mon2.TabIndex = 8;
            txtTHPT_Mon2.TextAlign = HorizontalAlignment.Center;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(217, 134);
            label21.Name = "label21";
            label21.Size = new Size(95, 45);
            label21.TabIndex = 8;
            label21.Text = "Điểm";
            // 
            // cbTHPT_Mon2
            // 
            cbTHPT_Mon2.FormattingEnabled = true;
            cbTHPT_Mon2.Location = new Point(333, 57);
            cbTHPT_Mon2.Name = "cbTHPT_Mon2";
            cbTHPT_Mon2.Size = new Size(242, 53);
            cbTHPT_Mon2.TabIndex = 8;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(142, 65);
            label20.Name = "label20";
            label20.Size = new Size(170, 45);
            label20.TabIndex = 8;
            label20.Text = "Chọn Môn";
            // 
            // gbTuChon1
            // 
            gbTuChon1.BackgroundImageLayout = ImageLayout.Stretch;
            gbTuChon1.Controls.Add(txtTHPT_Mon1);
            gbTuChon1.Controls.Add(label19);
            gbTuChon1.Controls.Add(label18);
            gbTuChon1.Controls.Add(cbTHPT_Mon1);
            gbTuChon1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTuChon1.Location = new Point(32, 284);
            gbTuChon1.Name = "gbTuChon1";
            gbTuChon1.Size = new Size(736, 201);
            gbTuChon1.TabIndex = 4;
            gbTuChon1.TabStop = false;
            gbTuChon1.Text = "Môn Tự Chọn 1";
            // 
            // txtTHPT_Mon1
            // 
            txtTHPT_Mon1.Location = new Point(333, 128);
            txtTHPT_Mon1.Name = "txtTHPT_Mon1";
            txtTHPT_Mon1.Size = new Size(200, 50);
            txtTHPT_Mon1.TabIndex = 4;
            txtTHPT_Mon1.TextAlign = HorizontalAlignment.Center;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(217, 133);
            label19.Name = "label19";
            label19.Size = new Size(95, 45);
            label19.TabIndex = 7;
            label19.Text = "Điểm";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(142, 57);
            label18.Name = "label18";
            label18.Size = new Size(170, 45);
            label18.TabIndex = 4;
            label18.Text = "Chọn Môn";
            // 
            // cbTHPT_Mon1
            // 
            cbTHPT_Mon1.FormattingEnabled = true;
            cbTHPT_Mon1.Location = new Point(333, 54);
            cbTHPT_Mon1.Name = "cbTHPT_Mon1";
            cbTHPT_Mon1.Size = new Size(242, 53);
            cbTHPT_Mon1.TabIndex = 6;
            // 
            // gbBatBuoc
            // 
            gbBatBuoc.BackgroundImageLayout = ImageLayout.Stretch;
            gbBatBuoc.Controls.Add(txtTHPT_Van);
            gbBatBuoc.Controls.Add(txtTHPT_Toan);
            gbBatBuoc.Controls.Add(label17);
            gbBatBuoc.Controls.Add(label16);
            gbBatBuoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbBatBuoc.Location = new Point(32, 25);
            gbBatBuoc.Name = "gbBatBuoc";
            gbBatBuoc.Size = new Size(736, 200);
            gbBatBuoc.TabIndex = 0;
            gbBatBuoc.TabStop = false;
            gbBatBuoc.Text = "Môn Bắt Buộc";
            // 
            // txtTHPT_Van
            // 
            txtTHPT_Van.Location = new Point(333, 125);
            txtTHPT_Van.Name = "txtTHPT_Van";
            txtTHPT_Van.Size = new Size(200, 50);
            txtTHPT_Van.TabIndex = 3;
            txtTHPT_Van.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTHPT_Toan
            // 
            txtTHPT_Toan.Location = new Point(333, 52);
            txtTHPT_Toan.Name = "txtTHPT_Toan";
            txtTHPT_Toan.Size = new Size(200, 50);
            txtTHPT_Toan.TabIndex = 2;
            txtTHPT_Toan.TextAlign = HorizontalAlignment.Center;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(159, 130);
            label17.Name = "label17";
            label17.Size = new Size(143, 45);
            label17.TabIndex = 1;
            label17.Text = "Ngữ Văn";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(159, 57);
            label16.Name = "label16";
            label16.Size = new Size(153, 45);
            label16.TabIndex = 0;
            label16.Text = "Toán Học";
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(label26);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(815, 835);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "DGNL";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.IndianRed;
            label26.Location = new Point(86, 694);
            label26.Name = "label26";
            label26.Size = new Size(609, 45);
            label26.TabIndex = 10;
            label26.Text = "*Điểm mỗi thành phần phải từ 0 đến 300!";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label23);
            panel1.Location = new Point(86, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 480);
            panel1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(344, 324);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 50);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(344, 197);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 50);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(344, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 50);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(46, 329);
            label25.Name = "label25";
            label25.Size = new Size(267, 45);
            label25.TabIndex = 3;
            label25.Text = "Tư Duy Khoa Học";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(160, 202);
            label24.Name = "label24";
            label24.Size = new Size(153, 45);
            label24.TabIndex = 2;
            label24.Text = "Toán Học";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(142, 79);
            label23.Name = "label23";
            label23.Size = new Size(171, 45);
            label23.TabIndex = 1;
            label23.Text = "Ngôn Ngữ";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel2);
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(815, 835);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Điểm ưu tiên";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.PeachPuff;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(430, 1042);
            button2.Name = "button2";
            button2.Size = new Size(176, 66);
            button2.TabIndex = 5;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label28);
            panel2.Controls.Add(cbDoiTuong);
            panel2.Controls.Add(label27);
            panel2.Controls.Add(cbKhuVuc);
            panel2.Controls.Add(txtDiemCong);
            panel2.Controls.Add(label29);
            panel2.Location = new Point(96, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 460);
            panel2.TabIndex = 3;
            // 
            // txtDiemCong
            // 
            txtDiemCong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiemCong.Location = new Point(378, 324);
            txtDiemCong.Multiline = true;
            txtDiemCong.Name = "txtDiemCong";
            txtDiemCong.Size = new Size(200, 50);
            txtDiemCong.TabIndex = 6;
            txtDiemCong.TextAlign = HorizontalAlignment.Center;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(46, 79);
            label29.Name = "label29";
            label29.Size = new Size(326, 45);
            label29.TabIndex = 1;
            label29.Text = "Khu Vực Ưu Tiên (KV)";
            // 
            // cbKhuVuc
            // 
            cbKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhuVuc.FormattingEnabled = true;
            cbKhuVuc.Location = new Point(378, 86);
            cbKhuVuc.Name = "cbKhuVuc";
            cbKhuVuc.Size = new Size(242, 40);
            cbKhuVuc.TabIndex = 7;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(16, 214);
            label27.Name = "label27";
            label27.Size = new Size(356, 45);
            label27.TabIndex = 8;
            label27.Text = "Đối Tượng Ưu Tiên (DT)";
            // 
            // cbDoiTuong
            // 
            cbDoiTuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoiTuong.FormattingEnabled = true;
            cbDoiTuong.Location = new Point(378, 219);
            cbDoiTuong.Name = "cbDoiTuong";
            cbDoiTuong.Size = new Size(242, 40);
            cbDoiTuong.TabIndex = 9;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(67, 329);
            label28.Name = "label28";
            label28.Size = new Size(305, 45);
            label28.TabIndex = 10;
            label28.Text = "Điểm Cộng (nếu có)";
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 1139);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FormNhapDiem";
            Text = "FormNhapDiem";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableHocBa.ResumeLayout(false);
            tableHocBa.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            gbTuChon2.ResumeLayout(false);
            gbTuChon2.PerformLayout();
            gbTuChon1.ResumeLayout(false);
            gbTuChon1.PerformLayout();
            gbBatBuoc.ResumeLayout(false);
            gbBatBuoc.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableHocBa;
        private TabPage tabPage3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button button2;
        private TextBox txt10_Van;
        private TextBox txt12_Toan;
        private TextBox txt11_Toan;
        private TextBox txt10_Toan;
        private TextBox txt12_Van;
        private TextBox txt11_Van;
        private TextBox txt12_Tin;
        private TextBox txt11_Tin;
        private TextBox txt10_Tin;
        private TextBox txt12_Dia;
        private TextBox txt11_Dia;
        private TextBox txt10_Dia;
        private TextBox txt12_Su;
        private TextBox txt11_Su;
        private TextBox txt10_Su;
        private TextBox txt12_Sinh;
        private TextBox txt11_Sinh;
        private TextBox txt10_Sinh;
        private TextBox txt12_Hoa;
        private TextBox txt11_Hoa;
        private TextBox txt10_Hoa;
        private TextBox txt12_Ly;
        private TextBox txt11_Ly;
        private TextBox txt10_Ly;
        private TextBox txt12_GDKTPL;
        private TextBox txt11_GDKTPL;
        private TextBox txt10_GDKTPL;
        private TextBox txt12_Anh;
        private TextBox txt11_Anh;
        private TextBox txt10_Anh;
        private GroupBox gbBatBuoc;
        private TextBox txtTHPT_Van;
        private TextBox txtTHPT_Toan;
        private Label label17;
        private Label label16;
        private GroupBox gbTuChon2;
        private GroupBox gbTuChon1;
        private TextBox txtTHPT_Mon1;
        private Label label19;
        private Label label18;
        private ComboBox cbTHPT_Mon1;
        private ComboBox cbTHPT_Mon2;
        private Label label20;
        private Label label22;
        private TextBox txtTHPT_Mon2;
        private Label label21;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label26;
        private TabPage tabPage4;
        private Panel panel2;
        private TextBox txtDiemCong;
        private Label label29;
        private Label label28;
        private ComboBox cbDoiTuong;
        private Label label27;
        private ComboBox cbKhuVuc;
    }
}