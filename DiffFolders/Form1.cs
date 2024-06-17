using System.Diagnostics;
using static System.Windows.Forms.ListViewItem;

namespace DiffFolders
{
    public partial class Form1 : Form
    {
        public List<string> folders = new List<string>();
        public Form1()
        {
            InitializeComponent();
            lvlDiffFolders.Items.Clear();
            lvlDiffFolders2.Items.Clear();
        }

        private void btFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            DialogResult result = openFolderDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                var folder = openFolderDialog.SelectedPath;

                if(folders.Count <= 2)
                {
                    folders.Add(folder);

                    UpdateLabels();

                    if(folders.Count >= 2)
                    {
                        btFolders.Enabled = false;
                    }
                }
            }
        }

        private void UpdateLabels()
        {
            if(folders.Count == 1)
            {
                lblfolder1.Text += "Pasta 1: " + folders[0];
            }
            if (folders.Count == 2)
            {
                lblfolder2.Text += "Pasta 2: " + folders[1];
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            folders.Clear();
            lvlDiffFolders.Items.Clear();
            lvlDiffFolders2.Items.Clear();
            lblfolder1.Text = String.Empty;
            lblfolder2.Text = String.Empty;
            btFolders.Enabled = true;
            lvlDiffFolders.Columns[0].Text = "Arquivos e pastas diff pasta 1";
            lvlDiffFolders2.Columns[0].Text = "Arquivos e pastas diff pasta 2";
        }

        private void btVerifyFolders_Click(object sender, EventArgs e)
        {
           

            if (folders.Count == 2)
            {
                MakeTextColum(lvlDiffFolders, 0);
                MakeTextColum(lvlDiffFolders2, 1);

                var dirsFolder1 = GetOnlyTheFileOrDirectoryName(Directory.GetDirectories(folders[0]));
                var filesFolder1 = GetOnlyTheFileOrDirectoryName(Directory.GetFiles(folders[0]));

                var dirsFolder2 = GetOnlyTheFileOrDirectoryName(Directory.GetDirectories(folders[1]));
                var filesFolder2 = GetOnlyTheFileOrDirectoryName(Directory.GetFiles(folders[1]));

                var dirsFolder1NotFolder2 = dirsFolder1.Except(dirsFolder2).ToArray();
                var filesFolder1NotFolder2 = filesFolder1.Except(filesFolder2).ToArray();

                var dirsFolder2NotFolder1 = dirsFolder2.Except(dirsFolder1).ToArray();
                var filesFolder2NotFolder1 = filesFolder2.Except(filesFolder1).ToArray();

                AddItems(lvlDiffFolders, dirsFolder1NotFolder2, filesFolder1NotFolder2);

                AddItems(lvlDiffFolders2, dirsFolder2NotFolder1, filesFolder2NotFolder1);
            }
            else
            {
                MessageBox.Show("Necessário selecionar 2 pastas.");
            }
        }

        private void MakeTextColum(ListView lvlDiffFolders, int index)
        {
            lvlDiffFolders.Columns[0].Text = "Arquivos e pastas diff no caminho: " + folders[index];
            lvlDiffFolders.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
             
        }

        private void AddItems(ListView listView, string[] dirs, string[] files)
        {
            if (dirs.Length == 0 && files.Length == 0)
                listView.Items.Add("Nenhum item diferente encontrado");

            foreach (string dir in dirs)
            {
                //var subItem = new ListViewSubItem(listItem1, dir);
                listView.Items.Add(dir);
            }

            foreach (string file in files)
            {
                //var subItem = new ListViewSubItem(listItem1, dir);
                listView.Items.Add(file);
            }

            
        }

        private IEnumerable<string> GetOnlyTheFileOrDirectoryName(string[] values)
        {
            return values.Select(x => x.Split("\\").Last());
        }

        private void lvlDiffFolders2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(e.IsSelected)
             Process.Start("explorer.exe", "/select, " + Path.Combine(folders[1], e.Item.Text));
        }
    }
}