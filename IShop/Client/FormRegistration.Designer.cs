﻿namespace IShop.Client
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
            label1.Location = new System.Drawing.Point(386, 108);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Создайте аккаунт";
            // 
            // RegistryLoginField
            // 
            RegistryLoginField.Location = new System.Drawing.Point(337, 153);
            RegistryLoginField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RegistryLoginField.Name = "RegistryLoginField";
            RegistryLoginField.Size = new System.Drawing.Size(225, 27);
            RegistryLoginField.TabIndex = 1;
            // 
            // RegistryPassField
            // 
            RegistryPassField.Location = new System.Drawing.Point(337, 209);
            RegistryPassField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RegistryPassField.Name = "RegistryPassField";
            RegistryPassField.Size = new System.Drawing.Size(225, 27);
            RegistryPassField.TabIndex = 2;
            // 
            // BtnCreateAccaount
            // 
            BtnCreateAccaount.Location = new System.Drawing.Point(406, 304);
            BtnCreateAccaount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnCreateAccaount.Name = "BtnCreateAccaount";
            BtnCreateAccaount.Size = new System.Drawing.Size(86, 31);
            BtnCreateAccaount.TabIndex = 3;
            BtnCreateAccaount.Text = "Создать аккаунт";
            BtnCreateAccaount.UseVisualStyleBackColor = true;
            BtnCreateAccaount.Click += BtnCreateAccaount_Click;
            // 
            // RegistryNumberField
            // 
            RegistryNumberField.Location = new System.Drawing.Point(337, 265);
            RegistryNumberField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RegistryNumberField.Name = "RegistryNumberField";
            RegistryNumberField.Size = new System.Drawing.Size(225, 27);
            RegistryNumberField.TabIndex = 4;
            // 
            // BtnCloseFormRegistration
            // 
            BtnCloseFormRegistration.Location = new System.Drawing.Point(815, 16);
            BtnCloseFormRegistration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnCloseFormRegistration.Name = "BtnCloseFormRegistration";
            BtnCloseFormRegistration.Size = new System.Drawing.Size(86, 31);
            BtnCloseFormRegistration.TabIndex = 5;
            BtnCloseFormRegistration.Text = "Закрыть";
            BtnCloseFormRegistration.UseVisualStyleBackColor = true;
            BtnCloseFormRegistration.Click += BtnCloseFormRegistration_Click;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(BtnCloseFormRegistration);
            Controls.Add(RegistryNumberField);
            Controls.Add(BtnCreateAccaount);
            Controls.Add(RegistryPassField);
            Controls.Add(RegistryLoginField);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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