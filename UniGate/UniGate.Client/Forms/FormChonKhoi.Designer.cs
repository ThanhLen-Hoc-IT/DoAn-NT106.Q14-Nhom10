namespace UniGate.Client
{
    partial class FormChonKhoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChonKhoi));
            clbToHop = new CheckedListBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // clbToHop
            // 
            clbToHop.FormattingEnabled = true;
            clbToHop.Location = new Point(155, 112);
            clbToHop.Name = "clbToHop";
            clbToHop.Size = new Size(719, 364);
            clbToHop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(325, 39);
            label1.Name = "label1";
            label1.Size = new Size(450, 52);
            label1.TabIndex = 1;
            label1.Text = "Chọn Tổ Hợp Xét Tuyển";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(406, 497);
            button1.Name = "button1";
            button1.Size = new Size(230, 54);
            button1.TabIndex = 2;
            button1.Text = "Gợi Ý Ngành";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormChonKhoi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1020, 576);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(clbToHop);
            Name = "FormChonKhoi";
            Text = "FormChonKhoi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clbToHop;
        private Label label1;
        private Button button1;
    }
}