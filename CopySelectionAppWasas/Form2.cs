using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Fatih Mehmed Bilgin
//12/8/2022

namespace CopySelectionAppWasas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            // for browsing the folder which is we want to list all files in there
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();//create folder browser dialog
            folderBrowserDialog.ShowDialog();//show it 
            string str = folderBrowserDialog.SelectedPath;// take the source path
            path.Text = str;
            foreach(string file in Directory.EnumerateFiles(str, "*", SearchOption.AllDirectories))//take all the files in selected folder
            {
                file_list.Items.Add(file);// list them in list view
                
            }
        }


        private void copy_all_btn_Click(object sender, EventArgs e)// button for go to copy all page
        {
            Form3 form = new Form3(path.Text);
            form.Show();
        }

        private void copy_selected_btn_Click(object sender, EventArgs e)
        {
            string dest = null;
            MessageBox.Show("Hedef yolu seçin");
            while (dest == null)// checking is dest folder path selected..
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowDialog();
                dest = folderBrowserDialog.SelectedPath;
            }
            string[] selected = getSelectedItems();// take the selected items
            int j = 0;
            string src = path.Text;// take the source
            DirectoryInfo dir = new DirectoryInfo(src);
            DeepCopy(dir, dest, selected);// deep copy; ı will explain this in function
            deleteEmptyDirectory(dest);// delete empty director; ı will explain this in function

            MessageBox.Show("Dosyalarınzı kopyalandı.");
        }

        
        public string[] getSelectedItems()
        {
            // the function takes the selected items in list view 
            // and puts them in array.
            string[] selected = new string[file_list.SelectedItems.Count];
            int i = 0;
            foreach (string str in file_list.SelectedItems)// take selected items 
            {
                selected[i] = str;// put them in array.
                i++;
            }
            return selected;
        }
        public string[] getNonSelectedItems()
        {
            // the function takes the not selected items in list view 
            // and puts them in array.
            string[] selected = new string[file_list.SelectedItems.Count];
            int i = 0;
            foreach (string str in file_list.SelectedItems)// taking selected items
            {
                selected[i] = str;
                i++;
            }
            // create a new array for not selected items..
            int non_s_count = ((file_list.Items.Count) - (file_list.SelectedItems.Count));
            string[] non_selected = new string[non_s_count];
            int h = 0;// variable for check the item is selected or not
            int k = 0;// variable for access all indices in not selected array.
            foreach(string item in file_list.Items)// take all the files in list view
            {
                h = 0;
                for(i = 0; i < selected.Length; i++)
                {
                    if(selected[i] == item)// decomposition not selected items with variable control
                    {
                        h++;
                    }
                }
                if(h == 0)// if item pass the control we put them in not selected array
                {

                    non_selected[k] = item;
                    k++;
                }
            }
            
            
            return non_selected;// returns not selected items.
        }

        private void copy_non_selected_btn_Click(object sender, EventArgs e)
        {
            string dest = null;
            MessageBox.Show("Hedef yolu seçin");
            while (dest == null)// checking is dest folder path selected..
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowDialog();
                dest = folderBrowserDialog.SelectedPath;
            }
            string[] selected = getNonSelectedItems();// take the not selected items
            int j = 0;
            string src = path.Text;// take the source path
            DirectoryInfo dir = new DirectoryInfo(src);
            DeepCopy(dir, dest, selected);// deep copy; ı will explain this in function
            deleteEmptyDirectory(dest);// delete empty director; ı will explain this in function

            MessageBox.Show("Dosyalarınzı kopyalandı.");
        }

        
        public static void DeepCopy(DirectoryInfo dir, string dest_adr, string[] selected)
        {
            // copy all the files in one directory, with subdirectories and subfiles
            int i = 0;
            foreach (string dr in Directory.GetDirectories(dir.FullName, "*", SearchOption.AllDirectories))
            {
                // take the all directories in source and create them in destination
                string dir_to_create = dr.Replace(dir.FullName, dest_adr);
                Directory.CreateDirectory(dir_to_create);
            }
            foreach (string new_path in Directory.GetFiles(dir.FullName, "*.*", SearchOption.AllDirectories))
            { // in this case we use the search option - all directories , that makes the search deeper.
                for(i = 0; i < selected.Length;i++)
                {
                    if(selected[i] == new_path)
                    {
                        // if the selected items equals with files in source 
                        // we copy them to destination
                        File.Copy(new_path, new_path.Replace(dir.FullName, dest_adr), true);
                    }
                }
                
            }
        }
        public void deleteEmptyDirectory(string dest)// this function checks and fixes the copying empty folders problem
        {
            string check = "";// variable for checking
            foreach (string file in Directory.GetDirectories(dest, "*", SearchOption.AllDirectories))
            {// take all directories in destination 
                check = "";
                foreach (string file2 in Directory.EnumerateFiles(file, "*", SearchOption.AllDirectories))
                {//take the files if exist in under directory
                    check = check + file2;
                }
                if (check.Length == 0)
                {// if directory is empty we delete the directory
                    Directory.Delete(file, true);
                }
            }
        }
    }
}
