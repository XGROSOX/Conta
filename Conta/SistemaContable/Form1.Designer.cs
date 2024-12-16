namespace Conta_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_emp = new System.Windows.Forms.Label();
            this.tbox_user = new System.Windows.Forms.TextBox();
            this.tbox_pwd = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_pwd = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_emp
            // 
            this.lb_emp.AutoSize = true;
            this.lb_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_emp.Location = new System.Drawing.Point(12, 19);
            this.lb_emp.Name = "lb_emp";
            this.lb_emp.Size = new System.Drawing.Size(209, 37);
            this.lb_emp.TabIndex = 0;
            this.lb_emp.Text = "<EMPRESA>";
            // 
            // tbox_user
            // 
            this.tbox_user.Location = new System.Drawing.Point(19, 76);
            this.tbox_user.Name = "tbox_user";
            this.tbox_user.Size = new System.Drawing.Size(202, 20);
            this.tbox_user.TabIndex = 1;
            this.tbox_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbox_pwd
            // 
            this.tbox_pwd.Location = new System.Drawing.Point(19, 123);
            this.tbox_pwd.Name = "tbox_pwd";
            this.tbox_pwd.Size = new System.Drawing.Size(202, 20);
            this.tbox_pwd.TabIndex = 2;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(16, 56);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(46, 13);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "Usuario:";
            // 
            // lb_pwd
            // 
            this.lb_pwd.AutoSize = true;
            this.lb_pwd.Location = new System.Drawing.Point(16, 107);
            this.lb_pwd.Name = "lb_pwd";
            this.lb_pwd.Size = new System.Drawing.Size(64, 13);
            this.lb_pwd.TabIndex = 4;
            this.lb_pwd.Text = "Contraseña:";
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(146, 162);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 42);
            this.btn_enter.TabIndex = 5;
            this.btn_enter.Text = "Ingresar";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(19, 162);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 42);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 216);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.lb_pwd);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.tbox_pwd);
            this.Controls.Add(this.tbox_user);
            this.Controls.Add(this.lb_emp);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_emp;
        private System.Windows.Forms.TextBox tbox_user;
        private System.Windows.Forms.TextBox tbox_pwd;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_pwd;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_exit;
    }
}

