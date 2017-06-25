namespace MyClient
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveSetupButton = new System.Windows.Forms.Button();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите IP сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите порт сервера";
            // 
            // saveSetupButton
            // 
            this.saveSetupButton.Location = new System.Drawing.Point(64, 148);
            this.saveSetupButton.Name = "saveSetupButton";
            this.saveSetupButton.Size = new System.Drawing.Size(142, 23);
            this.saveSetupButton.TabIndex = 2;
            this.saveSetupButton.Text = "Сохранить настройки";
            this.saveSetupButton.UseVisualStyleBackColor = true;
            this.saveSetupButton.Click += new System.EventHandler(this.saveSetupButton_Click);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(64, 32);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(142, 20);
            this.ipBox.TabIndex = 3;
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(64, 91);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(142, 20);
            this.portBox.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 202);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.saveSetupButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveSetupButton;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox portBox;
    }
}