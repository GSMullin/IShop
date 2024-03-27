namespace IShop.Client
{
    partial class FormRegistration
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
            label1 = new System.Windows.Forms.Label();
            RegistryLoginField = new System.Windows.Forms.TextBox();
            RegistryPassField = new System.Windows.Forms.TextBox();
            BtnCreateAccaount = new System.Windows.Forms.Button();
            RegistryNumberField = new System.Windows.Forms.TextBox();
            BtnCloseFormRegistration = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(338, 81);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Создайте аккаунт";
            // 
            // RegistryLoginField
            // 
            RegistryLoginField.Location = new System.Drawing.Point(295, 115);
            RegistryLoginField.Name = "RegistryLoginField";
            RegistryLoginField.Size = new System.Drawing.Size(197, 23);
            RegistryLoginField.TabIndex = 1;
            // 
            // RegistryPassField
            // 
            RegistryPassField.Location = new System.Drawing.Point(295, 157);
            RegistryPassField.Name = "RegistryPassField";
            RegistryPassField.Size = new System.Drawing.Size(197, 23);
            RegistryPassField.TabIndex = 2;
            // 
            // BtnCreateAccaount
            // 
            BtnCreateAccaount.Location = new System.Drawing.Point(355, 228);
            BtnCreateAccaount.Name = "BtnCreateAccaount";
            BtnCreateAccaount.Size = new System.Drawing.Size(75, 23);
            BtnCreateAccaount.TabIndex = 3;
            BtnCreateAccaount.Text = "Создать аккаунт";
            BtnCreateAccaount.UseVisualStyleBackColor = true;
            // 
            // RegistryNumberField
            // 
            RegistryNumberField.Location = new System.Drawing.Point(295, 199);
            RegistryNumberField.Name = "RegistryNumberField";
            RegistryNumberField.Size = new System.Drawing.Size(197, 23);
            RegistryNumberField.TabIndex = 4;
            // 
            // BtnCloseFormRegistration
            // 
            BtnCloseFormRegistration.Location = new System.Drawing.Point(713, 12);
            BtnCloseFormRegistration.Name = "BtnCloseFormRegistration";
            BtnCloseFormRegistration.Size = new System.Drawing.Size(75, 23);
            BtnCloseFormRegistration.TabIndex = 5;
            BtnCloseFormRegistration.Text = "Закрыть";
            BtnCloseFormRegistration.UseVisualStyleBackColor = true;
            BtnCloseFormRegistration.Click += BtnCloseFormRegistration_Click;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(BtnCloseFormRegistration);
            Controls.Add(RegistryNumberField);
            Controls.Add(BtnCreateAccaount);
            Controls.Add(RegistryPassField);
            Controls.Add(RegistryLoginField);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FormRegistration";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegistryLoginField;
        private System.Windows.Forms.TextBox RegistryPassField;
        private System.Windows.Forms.Button BtnCreateAccaount;
        private System.Windows.Forms.TextBox RegistryNumberField;
        private System.Windows.Forms.Button BtnCloseFormRegistration;
    }
}