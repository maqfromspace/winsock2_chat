namespace MyClient
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.sendButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.chatLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.sendBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.setupLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.SystemColors.Control;
            this.sendButton.Location = new System.Drawing.Point(333, 328);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(76, 59);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.Control;
            this.enterButton.Location = new System.Drawing.Point(134, 41);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 42);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Вход";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.Control;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Введите ник";
            // 
            // chatLabel
            // 
            this.chatLabel.AutoSize = true;
            this.chatLabel.BackColor = System.Drawing.SystemColors.Control;
            this.chatLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatLabel.Location = new System.Drawing.Point(21, 116);
            this.chatLabel.Name = "chatLabel";
            this.chatLabel.Size = new System.Drawing.Size(36, 17);
            this.chatLabel.TabIndex = 3;
            this.chatLabel.Text = "Чат";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.messageLabel.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(20, 306);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(102, 19);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "Ваше сообщение";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nameBox.Location = new System.Drawing.Point(12, 63);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(116, 20);
            this.nameBox.TabIndex = 5;
            // 
            // ChatBox
            // 
            this.ChatBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChatBox.Location = new System.Drawing.Point(12, 136);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.ReadOnly = true;
            this.ChatBox.Size = new System.Drawing.Size(315, 139);
            this.ChatBox.TabIndex = 6;
            this.ChatBox.Text = "";
            this.ChatBox.TextChanged += new System.EventHandler(this.ChatBox_TextChanged);
            // 
            // sendBox
            // 
            this.sendBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sendBox.Location = new System.Drawing.Point(12, 328);
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(315, 59);
            this.sendBox.TabIndex = 7;
            this.sendBox.Text = "";
            this.sendBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sendBox_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuSetup,
            this.ToolStripMenuExit});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ToolStripMenuItem.Text = "Меню";
            // 
            // ToolStripMenuSetup
            // 
            this.ToolStripMenuSetup.Name = "ToolStripMenuSetup";
            this.ToolStripMenuSetup.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuSetup.Text = "Настройки";
            this.ToolStripMenuSetup.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // ToolStripMenuExit
            // 
            this.ToolStripMenuExit.Name = "ToolStripMenuExit";
            this.ToolStripMenuExit.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuExit.Text = "Выход";
            this.ToolStripMenuExit.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // setupLabel
            // 
            this.setupLabel.AutoSize = true;
            this.setupLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.setupLabel.Location = new System.Drawing.Point(377, 45);
            this.setupLabel.Name = "setupLabel";
            this.setupLabel.Size = new System.Drawing.Size(0, 13);
            this.setupLabel.TabIndex = 9;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(510, 425);
            this.Controls.Add(this.setupLabel);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.chatLabel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "MaxChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label chatLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RichTextBox ChatBox;
        private System.Windows.Forms.RichTextBox sendBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuSetup;
        private System.Windows.Forms.Label setupLabel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuExit;
    }
}

