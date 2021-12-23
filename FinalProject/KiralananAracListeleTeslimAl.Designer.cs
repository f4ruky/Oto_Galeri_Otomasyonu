
namespace FinalProject
{
    partial class KiralananAracListeleTeslimAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralananAracListeleTeslimAl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 467);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.Image")));
            this.btnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListele.Location = new System.Drawing.Point(354, 481);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(158, 102);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimAl.Image = ((System.Drawing.Image)(resources.GetObject("btnTeslimAl.Image")));
            this.btnTeslimAl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeslimAl.Location = new System.Drawing.Point(518, 481);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(154, 48);
            this.btnTeslimAl.TabIndex = 2;
            this.btnTeslimAl.Text = "Teslim Al";
            this.btnTeslimAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.Image")));
            this.btnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnasayfa.Location = new System.Drawing.Point(518, 535);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(154, 48);
            this.btnAnasayfa.TabIndex = 3;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Durum:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(106, 484);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(193, 36);
            this.txtid.TabIndex = 6;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(115, 535);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(193, 36);
            this.txtDurum.TabIndex = 7;
            // 
            // KiralananAracListeleTeslimAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(684, 595);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KiralananAracListeleTeslimAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiralananAracListeleTeslimAl";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtDurum;
    }
}