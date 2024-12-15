using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace DirectoryCompressor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            lstDirectories.AllowDrop = true;
        }

        private void BtnSelectDirectories_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione o diretório que deseja comprimir";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    lstDirectories.Items.Add(folderDialog.SelectedPath);
                }
            }
        }

        private void BtnCompress_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                toolStripStatusLabel1.Text = string.Empty;

                object[] folders = new object[lstDirectories.Items.Count];

                lstDirectories.Items.CopyTo(folders, 0);
                
                foreach (object directory in folders)
                {
                    string zipFileName = Path.Combine(Path.GetDirectoryName((string)directory), Path.GetFileName((string)directory) + ".zip");

                    if (File.Exists(zipFileName))
                    {
                        File.Delete(zipFileName);
                    }

                    toolStripStatusLabel1.Text = $"Comprimindo o diretorio {directory}.";

                    statusStrip1.Invalidate();
                    statusStrip1.Refresh();

                    ZipFile.CreateFromDirectory((string)directory, zipFileName);

                    lstDirectories.Items.Remove(directory);

                    lstDirectories.Invalidate();
                    lstDirectories.Refresh();

                    if (removeFolderChkBox.Checked)
                    {
                        Directory.Delete((string)directory, true);
                    }                   
                }

                toolStripStatusLabel1.Text = $"Compressão foi finalizada.";

                statusStrip1.Invalidate();
                statusStrip1.Refresh();

                MessageBox.Show("Diretórios comprimidos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema durante a compressão dos diretorios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor.Current = Cursors.Default;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LstDirectories_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void LstDirectories_DragDrop(object sender, DragEventArgs e)
        {
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string folder in folders)
            {
                if (Directory.Exists(folder) && !lstDirectories.Items.Contains(folder))
                {
                    lstDirectories.Items.Add(folder);
                }
            }
        }
    }
}
