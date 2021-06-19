
namespace PPAI_Grupo14
{
    partial class RegistrarReservaVisitasGuiadas
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
            this.cmb_escuela = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_sede = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegir una escuela";
            // 
            // cmb_escuela
            // 
            this.cmb_escuela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_escuela.FormattingEnabled = true;
            this.cmb_escuela.Items.AddRange(new object[] {
            "Escuela 1",
            "Escuela 2",
            "Escuela 3"});
            this.cmb_escuela.Location = new System.Drawing.Point(15, 25);
            this.cmb_escuela.Name = "cmb_escuela";
            this.cmb_escuela.Size = new System.Drawing.Size(121, 21);
            this.cmb_escuela.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar la cantidad de visitantes";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(15, 65);
            this.txt_cantidad.Mask = "99999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 4;
            this.txt_cantidad.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elegir una sede";
            // 
            // cmb_sede
            // 
            this.cmb_sede.FormattingEnabled = true;
            this.cmb_sede.Items.AddRange(new object[] {
            "Sede 1",
            "Sede 2",
            "Sede 3"});
            this.cmb_sede.Location = new System.Drawing.Point(15, 104);
            this.cmb_sede.Name = "cmb_sede";
            this.cmb_sede.Size = new System.Drawing.Size(121, 21);
            this.cmb_sede.TabIndex = 6;
            // 
            // RegistrarReservaVisitasGuiadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_sede);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_escuela);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarReservaVisitasGuiadas";
            this.Text = "Registrar Visita";
            this.Load += new System.EventHandler(this.RegistrarVisita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_escuela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_sede;
    }
}