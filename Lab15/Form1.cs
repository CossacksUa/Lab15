using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            FadList.Items.Clear();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            while (!reader.EndOfStream)
            {
                FadList.Items.Add(reader.ReadLine());
            }
            MessageBox.Show(response.WelcomeMessage);
            reader.Close();
            response.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox10.Text = openFileDialog1.FileName;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbUpload.Text + openFileDialog1.SafeFileName);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                byte[] file = File.ReadAllBytes(textBox10.Text);
                Stream strz = request.GetRequestStream();
                strz.Write(file, 0, file.Length);
                strz.Close();
                strz.Dispose();

                MessageBox.Show(openFileDialog1.SafeFileName + " uploaded");
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }

        private void btnCreateDir_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbNewDir.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Directory " + tbNewDir.Text + " created");
            response.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbDelete.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.DeleteFile;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("File " + tbDelete.Text + " deleted");
            response.Close();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbRetrieve.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string fileContent = reader.ReadToEnd();
            MessageBox.Show(fileContent);
            reader.Close();
            response.Close();
        }

        private void btnModificationTime_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbFileModificationTime.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.GetDateTimestamp;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Modification time: " + response.LastModified);
            response.Close();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbFileSize.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.GetFileSize;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Size: " + response.ContentLength);
            response.Close();
        }

        private void btnNameList_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbNameList.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string names = reader.ReadToEnd();
            MessageBox.Show(names);
            reader.Close();
            response.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbList.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string details = reader.ReadToEnd();
            MessageBox.Show(details);
            reader.Close();
            response.Close();
        }

        private void btnRemoveDir_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbRemoveDir.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.RemoveDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Directory " + tbRemoveDir.Text + " removed");
            response.Close();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbOldName.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.Rename;
            request.RenameTo = tbNewName.Text;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Renamed to " + tbNewName.Text);
            response.Close();
        }

        private void btnStoreUnique_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.UploadFileWithUniqueName;
                byte[] file = File.ReadAllBytes(openFileDialog1.FileName);
                Stream strz = request.GetRequestStream();
                strz.Write(file, 0, file.Length);
                strz.Close();
                strz.Dispose();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("Uploaded with unique name: " + response.ResponseUri);
                response.Close();
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox10.Text = openFileDialog1.FileName;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbUpload.Text + openFileDialog1.SafeFileName);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.AppendFile;
                byte[] file = File.ReadAllBytes(textBox10.Text);
                Stream strz = request.GetRequestStream();
                strz.Write(file, 0, file.Length);
                strz.Close();
                strz.Dispose();

                MessageBox.Show(openFileDialog1.SafeFileName + " appended");
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }
    }
}
