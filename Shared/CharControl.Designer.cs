namespace CharacterManager.Shared
{
    partial class CharControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Stats = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healt = new System.Windows.Forms.ProgressBar();
            this.xp = new System.Windows.Forms.ProgressBar();
            this.healtlabel = new System.Windows.Forms.Label();
            this.xplabel = new System.Windows.Forms.Label();
            this.charToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(3, 262);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 25);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(114, 262);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 25);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(117, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Stats
            // 
            this.Stats.AutoSize = true;
            this.Stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Stats.Location = new System.Drawing.Point(3, 28);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(42, 18);
            this.Stats.TabIndex = 3;
            this.Stats.Text = "Stats:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.charToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(215, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // healt
            // 
            this.healt.Location = new System.Drawing.Point(3, 220);
            this.healt.Name = "healt";
            this.healt.Size = new System.Drawing.Size(209, 36);
            this.healt.TabIndex = 5;
            // 
            // xp
            // 
            this.xp.Location = new System.Drawing.Point(3, 188);
            this.xp.Name = "xp";
            this.xp.Size = new System.Drawing.Size(209, 26);
            this.xp.TabIndex = 6;
            // 
            // healtlabel
            // 
            this.healtlabel.AutoSize = true;
            this.healtlabel.Location = new System.Drawing.Point(3, 240);
            this.healtlabel.Name = "healtlabel";
            this.healtlabel.Size = new System.Drawing.Size(44, 16);
            this.healtlabel.TabIndex = 7;
            this.healtlabel.Text = "label1";
            // 
            // xplabel
            // 
            this.xplabel.AutoSize = true;
            this.xplabel.Location = new System.Drawing.Point(3, 198);
            this.xplabel.Name = "xplabel";
            this.xplabel.Size = new System.Drawing.Size(44, 16);
            this.xplabel.TabIndex = 8;
            this.xplabel.Text = "label2";
            // 
            // charToolStripMenuItem
            // 
            this.charToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.charToolStripMenuItem.Name = "charToolStripMenuItem";
            this.charToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.charToolStripMenuItem.Text = "Char";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // CharControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.xplabel);
            this.Controls.Add(this.healtlabel);
            this.Controls.Add(this.xp);
            this.Controls.Add(this.healt);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CharControl";
            this.Size = new System.Drawing.Size(215, 288);
            this.Load += new System.EventHandler(this.CharControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Stats;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ProgressBar healt;
        private System.Windows.Forms.ProgressBar xp;
        private System.Windows.Forms.Label healtlabel;
        private System.Windows.Forms.Label xplabel;
        private System.Windows.Forms.ToolStripMenuItem charToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}
