namespace Lab15
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.FadList = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbUpload = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbNewDir = new System.Windows.Forms.TextBox();
            this.btnCreateDir = new System.Windows.Forms.Button();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbRetrieve = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.tbFileModificationTime = new System.Windows.Forms.TextBox();
            this.btnModificationTime = new System.Windows.Forms.Button();
            this.tbFileSize = new System.Windows.Forms.TextBox();
            this.btnSize = new System.Windows.Forms.Button();
            this.tbNameList = new System.Windows.Forms.TextBox();
            this.btnNameList = new System.Windows.Forms.Button();
            this.tbList = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.tbRemoveDir = new System.Windows.Forms.TextBox();
            this.btnRemoveDir = new System.Windows.Forms.Button();
            this.tbOldName = new System.Windows.Forms.TextBox();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnStoreUnique = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(12, 12);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(200, 20);
            this.tbHost.TabIndex = 0;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(12, 38);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(200, 20);
            this.tbUser.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(12, 64);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(200, 20);
            this.tbPass.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(218, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // FadList
            // 
            this.FadList.FormattingEnabled = true;
            this.FadList.Location = new System.Drawing.Point(426, 272);
            this.FadList.Name = "FadList";
            this.FadList.Size = new System.Drawing.Size(362, 225);
            this.FadList.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbUpload
            // 
            this.tbUpload.Location = new System.Drawing.Point(12, 321);
            this.tbUpload.Name = "tbUpload";
            this.tbUpload.Size = new System.Drawing.Size(200, 20);
            this.tbUpload.TabIndex = 5;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(218, 319);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbNewDir
            // 
            this.tbNewDir.Location = new System.Drawing.Point(12, 347);
            this.tbNewDir.Name = "tbNewDir";
            this.tbNewDir.Size = new System.Drawing.Size(200, 20);
            this.tbNewDir.TabIndex = 7;
            // 
            // btnCreateDir
            // 
            this.btnCreateDir.Location = new System.Drawing.Point(218, 345);
            this.btnCreateDir.Name = "btnCreateDir";
            this.btnCreateDir.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDir.TabIndex = 8;
            this.btnCreateDir.Text = "Create Dir";
            this.btnCreateDir.UseVisualStyleBackColor = true;
            this.btnCreateDir.Click += new System.EventHandler(this.btnCreateDir_Click);
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(12, 373);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(200, 20);
            this.tbDelete.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbRetrieve
            // 
            this.tbRetrieve.Location = new System.Drawing.Point(12, 399);
            this.tbRetrieve.Name = "tbRetrieve";
            this.tbRetrieve.Size = new System.Drawing.Size(200, 20);
            this.tbRetrieve.TabIndex = 11;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(218, 397);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 12;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // tbFileModificationTime
            // 
            this.tbFileModificationTime.Location = new System.Drawing.Point(12, 425);
            this.tbFileModificationTime.Name = "tbFileModificationTime";
            this.tbFileModificationTime.Size = new System.Drawing.Size(200, 20);
            this.tbFileModificationTime.TabIndex = 13;
            // 
            // btnModificationTime
            // 
            this.btnModificationTime.Location = new System.Drawing.Point(218, 423);
            this.btnModificationTime.Name = "btnModificationTime";
            this.btnModificationTime.Size = new System.Drawing.Size(120, 23);
            this.btnModificationTime.TabIndex = 14;
            this.btnModificationTime.Text = "Modification Time";
            this.btnModificationTime.UseVisualStyleBackColor = true;
            this.btnModificationTime.Click += new System.EventHandler(this.btnModificationTime_Click);
            // 
            // tbFileSize
            // 
            this.tbFileSize.Location = new System.Drawing.Point(12, 451);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.Size = new System.Drawing.Size(200, 20);
            this.tbFileSize.TabIndex = 15;
            // 
            // btnSize
            // 
            this.btnSize.Location = new System.Drawing.Point(218, 449);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(75, 23);
            this.btnSize.TabIndex = 16;
            this.btnSize.Text = "Size";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // tbNameList
            // 
            this.tbNameList.Location = new System.Drawing.Point(313, 12);
            this.tbNameList.Name = "tbNameList";
            this.tbNameList.Size = new System.Drawing.Size(200, 20);
            this.tbNameList.TabIndex = 17;
            // 
            // btnNameList
            // 
            this.btnNameList.Location = new System.Drawing.Point(519, 10);
            this.btnNameList.Name = "btnNameList";
            this.btnNameList.Size = new System.Drawing.Size(75, 23);
            this.btnNameList.TabIndex = 18;
            this.btnNameList.Text = "Name List";
            this.btnNameList.UseVisualStyleBackColor = true;
            this.btnNameList.Click += new System.EventHandler(this.btnNameList_Click);
            // 
            // tbList
            // 
            this.tbList.Location = new System.Drawing.Point(313, 38);
            this.tbList.Name = "tbList";
            this.tbList.Size = new System.Drawing.Size(200, 20);
            this.tbList.TabIndex = 19;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(519, 36);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 20;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // tbRemoveDir
            // 
            this.tbRemoveDir.Location = new System.Drawing.Point(313, 64);
            this.tbRemoveDir.Name = "tbRemoveDir";
            this.tbRemoveDir.Size = new System.Drawing.Size(200, 20);
            this.tbRemoveDir.TabIndex = 21;
            // 
            // btnRemoveDir
            // 
            this.btnRemoveDir.Location = new System.Drawing.Point(519, 62);
            this.btnRemoveDir.Name = "btnRemoveDir";
            this.btnRemoveDir.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveDir.TabIndex = 22;
            this.btnRemoveDir.Text = "Remove Dir";
            this.btnRemoveDir.UseVisualStyleBackColor = true;
            this.btnRemoveDir.Click += new System.EventHandler(this.btnRemoveDir_Click);
            // 
            // tbOldName
            // 
            this.tbOldName.Location = new System.Drawing.Point(313, 90);
            this.tbOldName.Name = "tbOldName";
            this.tbOldName.Size = new System.Drawing.Size(200, 20);
            this.tbOldName.TabIndex = 23;
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(313, 116);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(200, 20);
            this.tbNewName.TabIndex = 24;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(519, 114);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 25;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnStoreUnique
            // 
            this.btnStoreUnique.Location = new System.Drawing.Point(313, 142);
            this.btnStoreUnique.Name = "btnStoreUnique";
            this.btnStoreUnique.Size = new System.Drawing.Size(120, 23);
            this.btnStoreUnique.TabIndex = 26;
            this.btnStoreUnique.Text = "Store Unique";
            this.btnStoreUnique.UseVisualStyleBackColor = true;
            this.btnStoreUnique.Click += new System.EventHandler(this.btnStoreUnique_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(313, 171);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 27;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 477);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(200, 20);
            this.textBox10.TabIndex = 28;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnStoreUnique);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.tbOldName);
            this.Controls.Add(this.btnRemoveDir);
            this.Controls.Add(this.tbRemoveDir);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.tbList);
            this.Controls.Add(this.btnNameList);
            this.Controls.Add(this.tbNameList);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.tbFileSize);
            this.Controls.Add(this.btnModificationTime);
            this.Controls.Add(this.tbFileModificationTime);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.tbRetrieve);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbDelete);
            this.Controls.Add(this.btnCreateDir);
            this.Controls.Add(this.tbNewDir);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tbUpload);
            this.Controls.Add(this.FadList);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbHost);
            this.Name = "Form1";
            this.Text = "FTP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox FadList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbUpload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbNewDir;
        private System.Windows.Forms.Button btnCreateDir;
        private System.Windows.Forms.TextBox tbDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbRetrieve;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.TextBox tbFileModificationTime;
        private System.Windows.Forms.Button btnModificationTime;
        private System.Windows.Forms.TextBox tbFileSize;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.TextBox tbNameList;
        private System.Windows.Forms.Button btnNameList;
        private System.Windows.Forms.TextBox tbList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox tbRemoveDir;
        private System.Windows.Forms.Button btnRemoveDir;
        private System.Windows.Forms.TextBox tbOldName;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnStoreUnique;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.TextBox textBox10; // Добавление textBox10
    }
}
