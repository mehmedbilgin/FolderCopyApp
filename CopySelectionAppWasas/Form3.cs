using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Fatih Mehmed Bilgin
// 12/08/2022

namespace CopySelectionAppWasas
{
    public partial class Form3 : Form
    {
        string kaynak;
        
        public Form3(string kaynak)// we take source path as parameter
        {
            InitializeComponent();
            this.kaynak = kaynak;
            
        }

        private void Form3_Load(object sender, EventArgs e)// actions when form loading
        {
            selected_path.Text = kaynak;
            files_selector.Items.Clear();
            foreach(string file in Directory.EnumerateFiles(kaynak, "*", SearchOption.AllDirectories))
            {// we  filling  the list box with filenames
                files_selector.Items.Add(file);
            }
            
        }
        public static void DeepCopy(DirectoryInfo dir , string dest_adr)// this function takes all directories and all files and copy them to the destination.
        {
            foreach (string dr in Directory.GetDirectories(dir.FullName, "*", SearchOption.AllDirectories))
            {// takes all the directories and create in destiantion 
                string dir_to_create = dr.Replace(  dir.FullName, dest_adr );
                Directory.CreateDirectory(dir_to_create);
            }
            foreach(string new_path in Directory.GetFiles(dir.FullName, "*.*", SearchOption.AllDirectories))
            {// takes all files in source dierctories and copy to new destination
                File.Copy(  new_path, new_path.Replace(dir.FullName,dest_adr),true);
            }
        }

        private void cpy_all_btn_Click(object sender, EventArgs e)// this button copies all files from source to destination 
        {
            DirectoryInfo dir = new DirectoryInfo(kaynak);
            string dest = dest_addr_label.Text;
            while (true)
            {// this loop enforces destination selection 
                if(dest_addr_label.Text != String.Empty)
                {
                    break;
                }
                else
                {
                    MessageBox.Show("Hedef dosya girmediniz, lütfen hedef dosya seçin");
                    BrowseFolder();// folder selection function
                    dest = dest_addr_label.Text;
                }
            }
            
            try
            {
                DeepCopy(dir, dest);// copy all function
                MessageBox.Show("Tüm dosyalar, kopyalandı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.Message);
            }

        }

        private void browse_dest_addr_btn_Click(object sender, EventArgs e)
        {
            BrowseFolder();  
        }
        public void BrowseFolder()
        {// this function open a browser dialog and  selects folder
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            string dest_str = folderBrowserDialog.SelectedPath;
            dest_addr_label.Text = dest_str;
        }
    }
}
