namespace Conta_Tool
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
            this.lb_emp = new System.Windows.Forms.Label();
            this.btn_apertura = new System.Windows.Forms.Button();
            this.btn_plan_cuentas = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_B_General = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_emp
            // 
            this.lb_emp.AutoSize = true;
            this.lb_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_emp.Location = new System.Drawing.Point(22, 25);
            this.lb_emp.Name = "lb_emp";
            this.lb_emp.Size = new System.Drawing.Size(284, 51);
            this.lb_emp.TabIndex = 1;
            this.lb_emp.Text = "<EMPRESA>";
            // 
            // btn_apertura
            // 
            this.btn_apertura.Location = new System.Drawing.Point(63, 100);
            this.btn_apertura.Name = "btn_apertura";
            this.btn_apertura.Size = new System.Drawing.Size(199, 37);
            this.btn_apertura.TabIndex = 2;
            this.btn_apertura.Text = "Iniciar balance de apertura";
            this.btn_apertura.UseVisualStyleBackColor = true;
            // 
            // btn_plan_cuentas
            // 
            this.btn_plan_cuentas.Location = new System.Drawing.Point(63, 154);
            this.btn_plan_cuentas.Name = "btn_plan_cuentas";
            this.btn_plan_cuentas.Size = new System.Drawing.Size(199, 37);
            this.btn_plan_cuentas.TabIndex = 3;
            this.btn_plan_cuentas.Text = "Plan de cuentas";
            this.btn_plan_cuentas.UseVisualStyleBackColor = true;
            this.btn_plan_cuentas.Click += new System.EventHandler(this.btn_plan_cuentas_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(63, 210);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(199, 37);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Cerrar";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_B_General
            // 
            this.btn_B_General.Location = new System.Drawing.Point(63, 253);
            this.btn_B_General.Name = "btn_B_General";
            this.btn_B_General.Size = new System.Drawing.Size(199, 37);
            this.btn_B_General.TabIndex = 5;
            this.btn_B_General.Text = "Balance general ";
            this.btn_B_General.UseVisualStyleBackColor = true;
            this.btn_B_General.Click += new System.EventHandler(this.btn_B_General_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 295);
            this.Controls.Add(this.btn_B_General);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_plan_cuentas);
            this.Controls.Add(this.btn_apertura);
            this.Controls.Add(this.lb_emp);
            this.Name = "Form2";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_emp;
        private System.Windows.Forms.Button btn_apertura;
        private System.Windows.Forms.Button btn_plan_cuentas;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_B_General;
    }
}