namespace DestinyCompanion
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Char1 = new System.Windows.Forms.Button();
            this.Char2 = new System.Windows.Forms.Button();
            this.Char3 = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CharName = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.LightLevelLabel = new System.Windows.Forms.Label();
            this.CharClass = new System.Windows.Forms.Label();
            this.CharLevel = new System.Windows.Forms.Label();
            this.CharLightLevel = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(515, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.characterToolStripMenuItem.Text = "Character";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Char1
            // 
            this.Char1.Location = new System.Drawing.Point(27, 51);
            this.Char1.Name = "Char1";
            this.Char1.Size = new System.Drawing.Size(75, 23);
            this.Char1.TabIndex = 2;
            this.Char1.Text = "Empty";
            this.Char1.UseVisualStyleBackColor = true;
            // 
            // Char2
            // 
            this.Char2.Location = new System.Drawing.Point(215, 51);
            this.Char2.Name = "Char2";
            this.Char2.Size = new System.Drawing.Size(75, 23);
            this.Char2.TabIndex = 3;
            this.Char2.Text = "Empty";
            this.Char2.UseVisualStyleBackColor = true;
            // 
            // Char3
            // 
            this.Char3.Location = new System.Drawing.Point(403, 51);
            this.Char3.Name = "Char3";
            this.Char3.Size = new System.Drawing.Size(75, 23);
            this.Char3.TabIndex = 4;
            this.Char3.Text = "Empty";
            this.Char3.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(23, 103);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 20);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name:";
            // 
            // CharName
            // 
            this.CharName.AutoSize = true;
            this.CharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharName.Location = new System.Drawing.Point(84, 103);
            this.CharName.Name = "CharName";
            this.CharName.Size = new System.Drawing.Size(54, 20);
            this.CharName.TabIndex = 6;
            this.CharName.Text = "Empty";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.Location = new System.Drawing.Point(23, 137);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(52, 20);
            this.ClassLabel.TabIndex = 7;
            this.ClassLabel.Text = "Class:";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(23, 172);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(50, 20);
            this.LevelLabel.TabIndex = 8;
            this.LevelLabel.Text = "Level:";
            // 
            // LightLevelLabel
            // 
            this.LightLevelLabel.AutoSize = true;
            this.LightLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightLevelLabel.Location = new System.Drawing.Point(23, 210);
            this.LightLevelLabel.Name = "LightLevelLabel";
            this.LightLevelLabel.Size = new System.Drawing.Size(89, 20);
            this.LightLevelLabel.TabIndex = 9;
            this.LightLevelLabel.Text = "Light Level:";
            // 
            // CharClass
            // 
            this.CharClass.AutoSize = true;
            this.CharClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharClass.Location = new System.Drawing.Point(84, 137);
            this.CharClass.Name = "CharClass";
            this.CharClass.Size = new System.Drawing.Size(54, 20);
            this.CharClass.TabIndex = 10;
            this.CharClass.Text = "Empty";
            // 
            // CharLevel
            // 
            this.CharLevel.AutoSize = true;
            this.CharLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharLevel.Location = new System.Drawing.Point(84, 172);
            this.CharLevel.Name = "CharLevel";
            this.CharLevel.Size = new System.Drawing.Size(54, 20);
            this.CharLevel.TabIndex = 11;
            this.CharLevel.Text = "Empty";
            // 
            // CharLightLevel
            // 
            this.CharLightLevel.AutoSize = true;
            this.CharLightLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharLightLevel.Location = new System.Drawing.Point(128, 210);
            this.CharLightLevel.Name = "CharLightLevel";
            this.CharLightLevel.Size = new System.Drawing.Size(54, 20);
            this.CharLightLevel.TabIndex = 12;
            this.CharLightLevel.Text = "Empty";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 440);
            this.Controls.Add(this.CharLightLevel);
            this.Controls.Add(this.CharLevel);
            this.Controls.Add(this.CharClass);
            this.Controls.Add(this.LightLevelLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.CharName);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Char3);
            this.Controls.Add(this.Char2);
            this.Controls.Add(this.Char1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Destiny Companion V1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button Char1;
        private System.Windows.Forms.Button Char2;
        private System.Windows.Forms.Button Char3;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CharName;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label LightLevelLabel;
        private System.Windows.Forms.Label CharClass;
        private System.Windows.Forms.Label CharLevel;
        private System.Windows.Forms.Label CharLightLevel;
    }
}

