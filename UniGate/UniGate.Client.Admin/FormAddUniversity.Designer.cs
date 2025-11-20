namespace UniGate.Client.Admin
{
    partial class FormAddUniversity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUniversity));
            lblKhoiDaChon = new Label();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtCode = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblKhoiDaChon
            // 
            lblKhoiDaChon.AutoSize = true;
            lblKhoiDaChon.BackColor = Color.Transparent;
            lblKhoiDaChon.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKhoiDaChon.Location = new Point(197, 88);
            lblKhoiDaChon.Name = "lblKhoiDaChon";
            lblKhoiDaChon.Size = new Size(205, 45);
            lblKhoiDaChon.TabIndex = 5;
            lblKhoiDaChon.Text = "Tên trường:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 283);
            label1.Name = "label1";
            label1.Size = new Size(123, 45);
            label1.TabIndex = 6;
            label1.Text = "Mô tả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 150);
            label2.Name = "label2";
            label2.Size = new Size(201, 45);
            label2.TabIndex = 7;
            label2.Text = "Mã trường:";
            // 
            // txtName
            // 
            txtName.Location = new Point(408, 88);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(418, 45);
            txtName.TabIndex = 8;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(408, 150);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(418, 45);
            txtCode.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(408, 211);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(418, 40);
            comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(298, 211);
            label3.Name = "label3";
            label3.Size = new Size(100, 45);
            label3.TabIndex = 11;
            label3.Text = "Tỉnh:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(404, 290);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(588, 196);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 537);
            label4.Name = "label4";
            label4.Size = new Size(105, 45);
            label4.TabIndex = 13;
            label4.Text = "Logo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 537);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(518, 45);
            textBox1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(404, 588);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 243);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(954, 533);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 16;
            button1.Text = "Chọn";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(613, 19);
            label5.Name = "label5";
            label5.Size = new Size(271, 52);
            label5.TabIndex = 17;
            label5.Text = "Thêm Trường";
            // 
            // FormAddUniversity
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1346, 856);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(txtCode);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblKhoiDaChon);
            Name = "FormAddUniversity";
            Text = "FormAddUniversity";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKhoiDaChon;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtCode;
        private ComboBox comboBox1;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label4;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label5;
    }
}