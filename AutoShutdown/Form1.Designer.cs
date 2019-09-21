namespace Teste1
{
    partial class AutoShutdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoShutdown));
            this.edtTxt_horas = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.Label();
            this.edtTxt_minutos = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.Label();
            this.edtTxt_segundos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.chkBox_dark = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // edtTxt_horas
            // 
            this.edtTxt_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTxt_horas.Location = new System.Drawing.Point(345, 215);
            this.edtTxt_horas.Name = "edtTxt_horas";
            this.edtTxt_horas.Size = new System.Drawing.Size(100, 30);
            this.edtTxt_horas.TabIndex = 2;
            this.edtTxt_horas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtTxt_horas_KeyPress);
            // 
            // txtHora
            // 
            this.txtHora.AutoSize = true;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(360, 187);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(64, 25);
            this.txtHora.TabIndex = 3;
            this.txtHora.Text = "Horas";
            // 
            // txtMinutos
            // 
            this.txtMinutos.AutoSize = true;
            this.txtMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos.Location = new System.Drawing.Point(354, 260);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(81, 25);
            this.txtMinutos.TabIndex = 5;
            this.txtMinutos.Text = "Minutos";
            // 
            // edtTxt_minutos
            // 
            this.edtTxt_minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTxt_minutos.Location = new System.Drawing.Point(345, 288);
            this.edtTxt_minutos.Name = "edtTxt_minutos";
            this.edtTxt_minutos.Size = new System.Drawing.Size(100, 30);
            this.edtTxt_minutos.TabIndex = 4;
            this.edtTxt_minutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtTxt_minutos_KeyPress);
            // 
            // txtSegundos
            // 
            this.txtSegundos.AutoSize = true;
            this.txtSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundos.Location = new System.Drawing.Point(343, 338);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(102, 25);
            this.txtSegundos.TabIndex = 7;
            this.txtSegundos.Text = "Segundos";
            // 
            // edtTxt_segundos
            // 
            this.edtTxt_segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTxt_segundos.Location = new System.Drawing.Point(345, 366);
            this.edtTxt_segundos.Name = "edtTxt_segundos";
            this.edtTxt_segundos.Size = new System.Drawing.Size(100, 30);
            this.edtTxt_segundos.TabIndex = 6;
            this.edtTxt_segundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtTxt_segundos_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AutoShutdown.Properties.Resources.icone;
            this.pictureBox1.Location = new System.Drawing.Point(338, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(258, 151);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(291, 26);
            this.titulo.TabIndex = 10;
            this.titulo.Text = "Defina o tempo para desligar";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(332, 415);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(128, 43);
            this.btn_ok.TabIndex = 11;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click_1);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(291, 467);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(211, 44);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancelar Auto Desligamento";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(631, 497);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(135, 44);
            this.btn_sair.TabIndex = 14;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // chkBox_dark
            // 
            this.chkBox_dark.AutoSize = true;
            this.chkBox_dark.Location = new System.Drawing.Point(13, 520);
            this.chkBox_dark.Name = "chkBox_dark";
            this.chkBox_dark.Size = new System.Drawing.Size(153, 21);
            this.chkBox_dark.TabIndex = 15;
            this.chkBox_dark.Text = "Tema Escuro (WIP)";
            this.chkBox_dark.UseVisualStyleBackColor = true;
            this.chkBox_dark.Click += new System.EventHandler(this.chkBox_dark_Click);
            // 
            // AutoShutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(778, 553);
            this.Controls.Add(this.chkBox_dark);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.edtTxt_segundos);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.edtTxt_minutos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.edtTxt_horas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoShutdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoShutdown";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox edtTxt_horas;
        private System.Windows.Forms.Label txtHora;
        private System.Windows.Forms.Label txtMinutos;
        private System.Windows.Forms.TextBox edtTxt_minutos;
        private System.Windows.Forms.Label txtSegundos;
        private System.Windows.Forms.TextBox edtTxt_segundos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.CheckBox chkBox_dark;
    }
}

