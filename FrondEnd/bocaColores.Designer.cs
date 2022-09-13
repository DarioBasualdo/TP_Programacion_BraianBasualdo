namespace FrondEnd
{
    partial class bocaColores
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btinformacionf = new System.Windows.Forms.Button();
            this.txtmostrarc = new System.Windows.Forms.TextBox();
            this.azulyamarillo = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txcolor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btinformacionf
            // 
            this.btinformacionf.Location = new System.Drawing.Point(713, 365);
            this.btinformacionf.Name = "btinformacionf";
            this.btinformacionf.Size = new System.Drawing.Size(75, 23);
            this.btinformacionf.TabIndex = 4;
            this.btinformacionf.Text = "Informacion";
            this.btinformacionf.UseVisualStyleBackColor = true;
            this.btinformacionf.Click += new System.EventHandler(this.btinformacionf_Click);
            // 
            // txtmostrarc
            // 
            this.txtmostrarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmostrarc.Location = new System.Drawing.Point(11, 257);
            this.txtmostrarc.Multiline = true;
            this.txtmostrarc.Name = "txtmostrarc";
            this.txtmostrarc.ReadOnly = true;
            this.txtmostrarc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtmostrarc.Size = new System.Drawing.Size(785, 102);
            this.txtmostrarc.TabIndex = 3;
            // 
            // azulyamarillo
            // 
            this.azulyamarillo.Enabled = true;
            this.azulyamarillo.Interval = 700;
            this.azulyamarillo.Tick += new System.EventHandler(this.azulyamarillo_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrondEnd.Properties.Resources.bandera_actual_de_suecia_1024x640;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txcolor
            // 
            this.txcolor.BackColor = System.Drawing.Color.MediumBlue;
            this.txcolor.Location = new System.Drawing.Point(210, 384);
            this.txcolor.Multiline = true;
            this.txcolor.Name = "txcolor";
            this.txcolor.ReadOnly = true;
            this.txcolor.Size = new System.Drawing.Size(370, 48);
            this.txcolor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 57);
            this.label1.MaximumSize = new System.Drawing.Size(350, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 124);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bandera de Suecia, de la cual se tomaron los colores\r\npara el uniforme titular de" +
    "l club.";
            // 
            // bocaColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(809, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txcolor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btinformacionf);
            this.Controls.Add(this.txtmostrarc);
            this.Controls.Add(this.button1);
            this.Name = "bocaColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bocaColores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btinformacionf;
        private System.Windows.Forms.TextBox txtmostrarc;
        private System.Windows.Forms.Timer azulyamarillo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txcolor;
        private System.Windows.Forms.Label label1;
    }
}