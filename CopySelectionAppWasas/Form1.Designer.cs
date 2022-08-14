namespace CopySelectionAppWasas
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baslik1 = new System.Windows.Forms.Label();
            this.f_path = new System.Windows.Forms.TextBox();
            this.btn_listele = new System.Windows.Forms.Button();
            this.file_list = new System.Windows.Forms.ListBox();
            this.dest_path = new System.Windows.Forms.TextBox();
            this.dest = new System.Windows.Forms.Label();
            this.copy_all_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baslik1
            // 
            this.baslik1.AutoSize = true;
            this.baslik1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.baslik1.Location = new System.Drawing.Point(82, 43);
            this.baslik1.Name = "baslik1";
            this.baslik1.Size = new System.Drawing.Size(387, 28);
            this.baslik1.TabIndex = 0;
            this.baslik1.Text = "KOPYALANACAK DOSYA YOLUNU GİRİN";
            // 
            // f_path
            // 
            this.f_path.Location = new System.Drawing.Point(82, 102);
            this.f_path.Name = "f_path";
            this.f_path.Size = new System.Drawing.Size(383, 27);
            this.f_path.TabIndex = 1;
            // 
            // btn_listele
            // 
            this.btn_listele.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listele.Location = new System.Drawing.Point(603, 102);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(94, 29);
            this.btn_listele.TabIndex = 2;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // file_list
            // 
            this.file_list.FormattingEnabled = true;
            this.file_list.ItemHeight = 20;
            this.file_list.Location = new System.Drawing.Point(82, 161);
            this.file_list.Name = "file_list";
            this.file_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.file_list.Size = new System.Drawing.Size(456, 304);
            this.file_list.TabIndex = 3;
            // 
            // dest_path
            // 
            this.dest_path.Location = new System.Drawing.Point(603, 207);
            this.dest_path.Name = "dest_path";
            this.dest_path.Size = new System.Drawing.Size(252, 27);
            this.dest_path.TabIndex = 4;
            // 
            // dest
            // 
            this.dest.AutoSize = true;
            this.dest.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dest.Location = new System.Drawing.Point(603, 161);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(225, 23);
            this.dest.TabIndex = 5;
            this.dest.Text = "HEDEF DOSYA YOLU GİRİN";
            // 
            // copy_all_btn
            // 
            this.copy_all_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copy_all_btn.Location = new System.Drawing.Point(603, 280);
            this.copy_all_btn.Name = "copy_all_btn";
            this.copy_all_btn.Size = new System.Drawing.Size(250, 41);
            this.copy_all_btn.TabIndex = 6;
            this.copy_all_btn.Text = "Hepsini Kopyala";
            this.copy_all_btn.UseVisualStyleBackColor = true;
            this.copy_all_btn.Click += new System.EventHandler(this.copy_all_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(603, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Detailed Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 525);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.copy_all_btn);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.dest_path);
            this.Controls.Add(this.file_list);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.f_path);
            this.Controls.Add(this.baslik1);
            this.Name = "Main";
            this.Text = "Copy Selection App Wasas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label baslik1;
        private TextBox f_path;
        private Button btn_listele;
        private ListBox file_list;
        private TextBox dest_path;
        private Label dest;
        private Button copy_all_btn;
        private Button button2;
    }
}