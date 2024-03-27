
namespace IShop.Client
{
    partial class FormLogin
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
            LoginField = new System.Windows.Forms.TextBox();
            PassField = new System.Windows.Forms.TextBox();
            BtnEnter = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            BtnRegistration = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(351, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Вход";
            // 
            // LoginField
            // 
            LoginField.Location = new System.Drawing.Point(298, 110);
            LoginField.Name = "LoginField";
            LoginField.Size = new System.Drawing.Size(156, 23);
            LoginField.TabIndex = 1; 
            // 
            // PassField
            // 
            PassField.Location = new System.Drawing.Point(298, 149);
            PassField.Name = "PassField";
            PassField.Size = new System.Drawing.Size(156, 23);
            PassField.TabIndex = 2;
            // 
            // BtnEnter
            // 
            BtnEnter.Location = new System.Drawing.Point(298, 178);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new System.Drawing.Size(156, 32);
            BtnEnter.TabIndex = 4;
            BtnEnter.Text = "Войти";
            BtnEnter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(243, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(243, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Пароль";
            // 
            // BtnRegistration
            // 
            BtnRegistration.Location = new System.Drawing.Point(298, 216);
            BtnRegistration.Name = "BtnRegistration";
            BtnRegistration.Size = new System.Drawing.Size(156, 33);
            BtnRegistration.TabIndex = 7;
            BtnRegistration.Text = "Создать аккаунт";
            BtnRegistration.UseVisualStyleBackColor = true;
            BtnRegistration.Click += BtnRegistration_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(BtnRegistration);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnEnter);
            Controls.Add(PassField);
            Controls.Add(LoginField);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegistration;
    }
}