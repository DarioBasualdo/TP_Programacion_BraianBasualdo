namespace FrondEnd
{
    partial class riverFundacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.btinformacionf = new System.Windows.Forms.Button();
            this.txtmostrarf = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btinformacionf
            // 
            this.btinformacionf.Location = new System.Drawing.Point(713, 379);
            this.btinformacionf.Name = "btinformacionf";
            this.btinformacionf.Size = new System.Drawing.Size(75, 23);
            this.btinformacionf.TabIndex = 6;
            this.btinformacionf.Text = "Informacion";
            this.btinformacionf.UseVisualStyleBackColor = true;
            this.btinformacionf.Click += new System.EventHandler(this.btinformacionf_Click);
            // 
            // txtmostrarf
            // 
            this.txtmostrarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmostrarf.Location = new System.Drawing.Point(0, 221);
            this.txtmostrarf.Multiline = true;
            this.txtmostrarf.Name = "txtmostrarf";
            this.txtmostrarf.ReadOnly = true;
            this.txtmostrarf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtmostrarf.Size = new System.Drawing.Size(797, 152);
            this.txtmostrarf.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrondEnd.Properties.Resources.fundacion_de_river;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 28);
            this.label1.MaximumSize = new System.Drawing.Size(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 150);
            this.label1.TabIndex = 8;
            this.label1.Text = "El puerto de Buenos Aires en el año 1900,\r\nBario la Boca ,el nombre fue sacado de" +
    " unos cajones que se encontraban en ese lugar";
            // 
            // riverFundacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btinformacionf);
            this.Controls.Add(this.txtmostrarf);
            this.Controls.Add(this.button1);
            this.Name = "riverFundacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "riverFundacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btinformacionf;
        private System.Windows.Forms.TextBox txtmostrarf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}