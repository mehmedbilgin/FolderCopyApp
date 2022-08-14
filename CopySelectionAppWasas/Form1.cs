using System.IO;
//Fatih Mehmed Bilgin
//12/8/2022

namespace CopySelectionAppWasas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)//listing files to list view
        {
            string yol = f_path.Text;// take the source url
            file_list.Items.Clear();
            var files = new DirectoryInfo(yol);// get files from source
            DirectoryInfo[] files2 = files.GetDirectories();
            foreach(DirectoryInfo file in files2)
            {   
                file_list.Items.Add(file.Name);//show in list view
            }
        }

        private void copy_all_btn_Click(object sender, EventArgs e)
        {
            string src = f_path.Text; // source url
            string dst = dest_path.Text; // destination url
            try
            {
                var files = new DirectoryInfo(src).GetFiles("*.*"); // take folders
                foreach (FileInfo file in files)
                {
                    string destination = dst + "\\" + file.Name;//create a destination url with file name
                    file.CopyTo(destination);//copy
                }
                MessageBox.Show("Tüm dosyalar kopyalandý.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Hata");
            }
        
        }
        
        private void copy_selected_btn_Click(object sender, EventArgs e) 
        {
            // just testing can we take the selected files..
            string yol = f_path.Text;
            string dst = dest_path.Text;
            string[] selected = new string[file_list.SelectedItems.Count];
            int i = 0;
            foreach (string str in file_list.SelectedItems)
            {
                MessageBox.Show(str);
            }
        }

        private void button2_Click(object sender, EventArgs e)// button for changing page
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }
    }
}