namespace CopySelectionAppWasas
{
    partial class Form3
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
            this.selected_path = new System.Windows.Forms.Label();
            this.files_selector = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cpy_all_btn = new System.Windows.Forms.Button();
            this.browse_dest_addr_btn = new System.Windows.Forms.Button();
            this.dest_addr_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selected_path
            // 
            this.selected_path.AutoSize = true;
            this.selected_path.Location = new System.Drawing.Point(71, 57);
            this.selected_path.Name = "selected_path";
            this.selected_path.Size = new System.Drawing.Size(39, 20);
            this.selected_path.TabIndex = 0;
            this.selected_path.Text = "path";
            // 
            // files_selector
            // 
            this.files_selector.FormattingEnabled = true;
            this.files_selector.ItemHeight = 20;
            this.files_selector.Location = new System.Drawing.Point(71, 96);
            this.files_selector.Name = "files_selector";
            this.files_selector.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.files_selector.Size = new System.Drawing.Size(425, 264);
            this.files_selector.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(70, 392);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(426, 29);
            this.progressBar1.TabIndex = 2;
            // 
            // cpy_all_btn
            // 
            this.cpy_all_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpy_all_btn.Location = new System.Drawing.Point(586, 187);
            this.cpy_all_btn.Name = "cpy_all_btn";
            this.cpy_all_btn.Size = new System.Drawing.Size(164, 61);
            this.cpy_all_btn.TabIndex = 3;
            this.cpy_all_btn.Text = "Tümünü Kopyala";
            this.cpy_all_btn.UseVisualStyleBackColor = true;
            this.cpy_all_btn.Click += new System.EventHandler(this.cpy_all_btn_Click);
            // 
            // browse_dest_addr_btn
            // 
            this.browse_dest_addr_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browse_dest_addr_btn.Location = new System.Drawing.Point(586, 96);
            this.browse_dest_addr_btn.Name = "browse_dest_addr_btn";
            this.browse_dest_addr_btn.Size = new System.Drawing.Size(164, 62);
            this.browse_dest_addr_btn.TabIndex = 4;
            this.browse_dest_addr_btn.Text = "Hedef Seç";
            this.browse_dest_addr_btn.UseVisualStyleBackColor = true;
            this.browse_dest_addr_btn.Click += new System.EventHandler(this.browse_dest_addr_btn_Click);
            // 
            // dest_addr_label
            // 
            this.dest_addr_label.AutoSize = true;
            this.dest_addr_label.Location = new System.Drawing.Point(475, 61);
            this.dest_addr_label.Name = "dest_addr_label";
            this.dest_addr_label.Size = new System.Drawing.Size(0, 20);
            this.dest_addr_label.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 463);
            this.Controls.Add(this.dest_addr_label);
            this.Controls.Add(this.browse_dest_addr_btn);
            this.Controls.Add(this.cpy_all_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.files_selector);
            this.Controls.Add(this.selected_path);
            this.Name = "Form3";
            this.Text = "Tümünü Kopyala";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label selected_path;
        private ListBox files_selector;
        private ProgressBar progressBar1;
        private Button cpy_all_btn;
        private Button browse_dest_addr_btn;
        private Label dest_addr_label;
    }
}