namespace CopySelectionAppWasas
{
    partial class Form2
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
            this.browse_btn = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.copy_all_btn = new System.Windows.Forms.Button();
            this.file_list = new System.Windows.Forms.ListBox();
            this.copy_selected_btn = new System.Windows.Forms.Button();
            this.copy_non_selected_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browse_btn
            // 
            this.browse_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browse_btn.Location = new System.Drawing.Point(540, 127);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(273, 71);
            this.browse_btn.TabIndex = 0;
            this.browse_btn.Text = "Browse Folder";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(72, 81);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(141, 20);
            this.path.TabIndex = 1;
            this.path.Text = "//seçilen dosya yolu";
            // 
            // copy_all_btn
            // 
            this.copy_all_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copy_all_btn.Location = new System.Drawing.Point(541, 357);
            this.copy_all_btn.Name = "copy_all_btn";
            this.copy_all_btn.Size = new System.Drawing.Size(273, 74);
            this.copy_all_btn.TabIndex = 4;
            this.copy_all_btn.Text = "Hepsini Kopyalama Ekranı";
            this.copy_all_btn.UseVisualStyleBackColor = true;
            this.copy_all_btn.Click += new System.EventHandler(this.copy_all_btn_Click);
            // 
            // file_list
            // 
            this.file_list.FormattingEnabled = true;
            this.file_list.ItemHeight = 20;
            this.file_list.Location = new System.Drawing.Point(72, 127);
            this.file_list.Name = "file_list";
            this.file_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.file_list.Size = new System.Drawing.Size(451, 304);
            this.file_list.TabIndex = 5;
            // 
            // copy_selected_btn
            // 
            this.copy_selected_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copy_selected_btn.Location = new System.Drawing.Point(540, 204);
            this.copy_selected_btn.Name = "copy_selected_btn";
            this.copy_selected_btn.Size = new System.Drawing.Size(273, 67);
            this.copy_selected_btn.TabIndex = 6;
            this.copy_selected_btn.Text = "Copy Selected";
            this.copy_selected_btn.UseVisualStyleBackColor = true;
            this.copy_selected_btn.Click += new System.EventHandler(this.copy_selected_btn_Click);
            // 
            // copy_non_selected_btn
            // 
            this.copy_non_selected_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copy_non_selected_btn.Location = new System.Drawing.Point(541, 277);
            this.copy_non_selected_btn.Name = "copy_non_selected_btn";
            this.copy_non_selected_btn.Size = new System.Drawing.Size(272, 74);
            this.copy_non_selected_btn.TabIndex = 7;
            this.copy_non_selected_btn.Text = "Copy Non Selected";
            this.copy_non_selected_btn.UseVisualStyleBackColor = true;
            this.copy_non_selected_btn.Click += new System.EventHandler(this.copy_non_selected_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 482);
            this.Controls.Add(this.copy_non_selected_btn);
            this.Controls.Add(this.copy_selected_btn);
            this.Controls.Add(this.file_list);
            this.Controls.Add(this.copy_all_btn);
            this.Controls.Add(this.path);
            this.Controls.Add(this.browse_btn);
            this.Name = "Form2";
            this.Text = "Copy Selection App Wasas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button browse_btn;
        private Label path;
        private Button copy_all_btn;
        private ListBox file_list;
        private Button copy_selected_btn;
        private Button copy_non_selected_btn;
    }
}