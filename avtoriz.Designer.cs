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
            this.name = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.logr = new System.Windows.Forms.TextBox();
            this.passr = new System.Windows.Forms.TextBox();
            this.registr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passrch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(247, 175);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(117, 17);
            this.showPass.TabIndex = 0;
            this.showPass.Text = "Показать пароль ";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // vxod1
            // 
            this.vxod1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.vxod1.Location = new System.Drawing.Point(95, 198);
            this.vxod1.Name = "vxod1";
            this.vxod1.Size = new System.Drawing.Size(269, 40);
            this.vxod1.TabIndex = 1;
            this.vxod1.Text = "Войти";
            this.vxod1.UseVisualStyleBackColor = false;
            this.vxod1.Click += new System.EventHandler(this.vxod1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(95, 91);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(263, 20);
            this.login.TabIndex = 2;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(95, 149);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(263, 20);
            this.pass.TabIndex = 3;
            // 
            // loginPolz
            // 
            this.loginPolz.AutoSize = true;
            this.loginPolz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPolz.Location = new System.Drawing.Point(90, 48);
            this.loginPolz.Name = "loginPolz";
            this.loginPolz.Size = new System.Drawing.Size(71, 25);
            this.loginPolz.TabIndex = 4;
            this.loginPolz.Text = "Логин";
            // 
            // passpolz
            // 
            this.passpolz.AutoSize = true;
            this.passpolz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passpolz.Location = new System.Drawing.Point(90, 114);
            this.passpolz.Name = "passpolz";
            this.passpolz.Size = new System.Drawing.Size(86, 25);
            this.passpolz.TabIndex = 5;
            this.passpolz.Text = "Пароль";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(95, 342);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(263, 20);
            this.name.TabIndex = 6;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(95, 368);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(263, 20);
            this.second.TabIndex = 7;
            this.second.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // logr
            // 
            this.logr.Location = new System.Drawing.Point(95, 394);
            this.logr.Name = "logr";
            this.logr.Size = new System.Drawing.Size(263, 20);
            this.logr.TabIndex = 8;
            // 
            // passr
            // 
            this.passr.Location = new System.Drawing.Point(95, 420);
            this.passr.Name = "passr";
            this.passr.Size = new System.Drawing.Size(263, 20);
            this.passr.TabIndex = 9;
            // 
            // registr
            // 
            this.registr.BackColor = System.Drawing.Color.MediumAquamarine;
            this.registr.Location = new System.Drawing.Point(95, 490);
            this.registr.Name = "registr";
            this.registr.Size = new System.Drawing.Size(269, 40);
            this.registr.TabIndex = 10;
            this.registr.Text = "Регистрация";
            this.registr.UseVisualStyleBackColor = false;
            this.registr.Click += new System.EventHandler(this.registr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Фамилия:";
            // 
            // roles
            // 
            this.roles.FormattingEnabled = true;
            this.roles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.roles.Location = new System.Drawing.Point(94, 458);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(44, 21);
            this.roles.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Роль:";
            // 
            // passrch
            // 
            this.passrch.AutoSize = true;
            this.passrch.Location = new System.Drawing.Point(241, 446);
            this.passrch.Name = "passrch";
            this.passrch.Size = new System.Drawing.Size(117, 17);
            this.passrch.TabIndex = 18;
            this.passrch.Text = "Показать пароль ";
            this.passrch.UseVisualStyleBackColor = true;
            this.passrch.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 586);
            this.Controls.Add(this.passrch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registr);
            this.Controls.Add(this.passr);
            this.Controls.Add(this.logr);
            this.Controls.Add(this.second);
            this.Controls.Add(this.name);
            this.Controls.Add(this.passpolz);
            this.Controls.Add(this.loginPolz);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.vxod1);
            this.Controls.Add(this.showPass);
            this.Name = "avtoriz";
            this.Text = "Авторизация";
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
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox logr;
        private System.Windows.Forms.TextBox passr;
        private System.Windows.Forms.Button registr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox passrch;
    }
}

