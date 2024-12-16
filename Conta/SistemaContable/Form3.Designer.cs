namespace Conta_Tool
{
    partial class Form3
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
            this.tbox_plan_cuentas = new System.Windows.Forms.TextBox();
            this.btn_cargar_plan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_plan_cuentas
            // 
            this.tbox_plan_cuentas.Location = new System.Drawing.Point(384, 12);
            this.tbox_plan_cuentas.Multiline = true;
            this.tbox_plan_cuentas.Name = "tbox_plan_cuentas";
            this.tbox_plan_cuentas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox_plan_cuentas.Size = new System.Drawing.Size(441, 355);
            this.tbox_plan_cuentas.TabIndex = 0;
            this.tbox_plan_cuentas.Text = "<No se cargó ningún plan de cuentas>";
            this.tbox_plan_cuentas.TextChanged += new System.EventHandler(this.tbox_plan_cuentas_TextChanged);
            // 
            // btn_cargar_plan
            // 
            this.btn_cargar_plan.Location = new System.Drawing.Point(205, 344);
            this.btn_cargar_plan.Name = "btn_cargar_plan";
            this.btn_cargar_plan.Size = new System.Drawing.Size(173, 23);
            this.btn_cargar_plan.TabIndex = 1;
            this.btn_cargar_plan.Text = "Cargar otro plan de cuentas";
            this.btn_cargar_plan.UseVisualStyleBackColor = true;
            this.btn_cargar_plan.Click += new System.EventHandler(this.btn_cargar_plan_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 379);
            this.Controls.Add(this.btn_cargar_plan);
            this.Controls.Add(this.tbox_plan_cuentas);
            this.Name = "Form3";
            this.Text = "Plan de cuentas";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_plan_cuentas;
        private System.Windows.Forms.Button btn_cargar_plan;
    }
}