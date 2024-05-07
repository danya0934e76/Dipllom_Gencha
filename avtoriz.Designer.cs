namespace Dipllom_Gencha
{
    partial class avtoriz
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
            this.showPass = new System.Windows.Forms.CheckBox();
            this.vxod1 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.loginPolz = new System.Windows.Forms.Label();
            this.passpolz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(397, 218);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(117, 17);
            this.showPass.TabIndex = 0;
            this.showPass.Text = "Показать пароль ";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // vxod1
            // 
            this.vxod1.Location = new System.Drawing.Point(245, 241);
            this.vxod1.Name = "vxod1";
            this.vxod1.Size = new System.Drawing.Size(269, 40);
            this.vxod1.TabIndex = 1;
            this.vxod1.Text = "Войти";
            this.vxod1.UseVisualStyleBackColor = true;
            this.vxod1.Click += new System.EventHandler(this.vxod1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(245, 134);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(263, 20);
            this.login.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(245, 192);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(263, 20);
            this.pass.TabIndex = 3;
            // 
            // loginPolz
            // 
            this.loginPolz.AutoSize = true;
            this.loginPolz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPolz.Location = new System.Drawing.Point(240, 91);
            this.loginPolz.Name = "loginPolz";
            this.loginPolz.Size = new System.Drawing.Size(71, 25);
            this.loginPolz.TabIndex = 4;
            this.loginPolz.Text = "Логин";
            // 
            // passpolz
            // 
            this.passpolz.AutoSize = true;
            this.passpolz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passpolz.Location = new System.Drawing.Point(240, 157);
            this.passpolz.Name = "passpolz";
            this.passpolz.Size = new System.Drawing.Size(86, 25);
            this.passpolz.TabIndex = 5;
            this.passpolz.Text = "Пароль";
            // 
            // avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passpolz);
            this.Controls.Add(this.loginPolz);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.vxod1);
            this.Controls.Add(this.showPass);
            this.Name = "avtoriz";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.avtoriz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Button vxod1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label loginPolz;
        private System.Windows.Forms.Label passpolz;
    }
}

