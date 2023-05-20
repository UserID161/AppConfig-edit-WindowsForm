namespace AppConfig
{
    partial class EditAppConfig
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
            this.labelServer = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(23, 20);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(50, 16);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(23, 54);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(34, 16);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port:";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(23, 88);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(55, 16);
            this.labelUserID.TabIndex = 2;
            this.labelUserID.Text = "User ID:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(23, 120);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(23, 155);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(70, 16);
            this.labelDatabase.TabIndex = 4;
            this.labelDatabase.Text = "Database:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 188);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(203, 16);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Информационное сообщение:";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(101, 14);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(357, 22);
            this.textBoxServer.TabIndex = 6;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(101, 48);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(357, 22);
            this.textBoxPort.TabIndex = 7;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(101, 82);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(357, 22);
            this.textBoxUserID.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(101, 114);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(357, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(101, 149);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(357, 22);
            this.textBoxDatabase.TabIndex = 10;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(357, 228);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(126, 23);
            this.buttonTest.TabIndex = 11;
            this.buttonTest.Text = "Тестирование";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(191, 228);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(15, 228);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(126, 23);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // EditAppConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 273);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelServer);
            this.Name = "EditAppConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование App.Config";
            this.Load += new System.EventHandler(this.EditAppConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
    }
}

