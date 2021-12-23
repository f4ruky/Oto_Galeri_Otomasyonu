
namespace FinalProject
{
    partial class AdminGirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGirisPaneli));
            this.btnAracKirala = new System.Windows.Forms.Button();
            this.btnAracSat = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAracKirala
            // 
            this.btnAracKirala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAracKirala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAracKirala.ForeColor = System.Drawing.Color.Green;
            this.btnAracKirala.Location = new System.Drawing.Point(0, 131);
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(260, 75);
            this.btnAracKirala.TabIndex = 2;
            this.btnAracKirala.Text = "Araç Kiralama";
            this.btnAracKirala.UseVisualStyleBackColor = true;
            this.btnAracKirala.Click += new System.EventHandler(this.btnAracKirala_Click);
            // 
            // btnAracSat
            // 
            this.btnAracSat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAracSat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAracSat.ForeColor = System.Drawing.Color.Green;
            this.btnAracSat.Location = new System.Drawing.Point(376, 131);
            this.btnAracSat.Name = "btnAracSat";
            this.btnAracSat.Size = new System.Drawing.Size(260, 75);
            this.btnAracSat.TabIndex = 3;
            this.btnAracSat.Text = "Araç Satış";
            this.btnAracSat.UseVisualStyleBackColor = true;
            this.btnAracSat.Click += new System.EventHandler(this.btnAracSat_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.ForeColor = System.Drawing.Color.Green;
            this.btnCikis.Location = new System.Drawing.Point(0, 236);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(636, 82);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(116, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Real Rent A Car";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(589, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 50);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AdminGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(637, 682);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAracSat);
            this.Controls.Add(this.btnAracKirala);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminGirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGirisPaneli";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAracKirala;
        private System.Windows.Forms.Button btnAracSat;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}