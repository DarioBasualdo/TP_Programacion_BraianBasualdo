namespace FrondEnd
{
    partial class riverColores
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
            this.txcolores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rojoyblanco = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 38);
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
            this.btinformacionf.TabIndex = 6;
            this.btinformacionf.Text = "Informacion";
            this.btinformacionf.UseVisualStyleBackColor = true;
            this.btinformacionf.Click += new System.EventHandler(this.btinformacionf_Click);
            // 
            // txtmostrarc
            // 
            this.txtmostrarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmostrarc.Location = new System.Drawing.Point(12, 246);
            this.txtmostrarc.Multiline = true;
            this.txtmostrarc.Name = "txtmostrarc";
            this.txtmostrarc.ReadOnly = true;
            this.txtmostrarc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtmostrarc.Size = new System.Drawing.Size(776, 113);
            this.txtmostrarc.TabIndex = 5;
            // 
            // txcolores
            // 
            this.txcolores.BackColor = System.Drawing.Color.White;
            this.txcolores.Location = new System.Drawing.Point(220, 393);
            this.txcolores.Multiline = true;
            this.txcolores.Name = "txcolores";
            this.txcolores.ReadOnly = true;
            this.txcolores.Size = new System.Drawing.Size(364, 45);
            this.txcolores.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 65);
            this.label1.MaximumSize = new System.Drawing.Size(350, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 62);
            this.label1.TabIndex = 9;
            this.label1.Text = "Camiseta de 1961 utilizada por Ermindo Onega.";
            // 
            // rojoyblanco
            // 
            this.rojoyblanco.Enabled = true;
            this.rojoyblanco.Interval = 700;
            this.rojoyblanco.Tick += new System.EventHandler(this.rojoyblanco_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrondEnd.Properties.Resources.colores_de_river;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // riverColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txcolores);
            this.Controls.Add(this.btinformacionf);
            this.Controls.Add(this.txtmostrarc);
            this.Controls.Add(this.button1);
            this.Name = "riverColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "riverColores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btinformacionf;
        private System.Windows.Forms.TextBox txtmostrarc;
        private System.Windows.Forms.TextBox txcolores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer rojoyblanco;
    }
}