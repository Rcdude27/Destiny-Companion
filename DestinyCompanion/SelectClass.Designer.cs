namespace DestinyCompanion
{
    partial class SelectClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectClass));
            this.TitanRadio = new System.Windows.Forms.RadioButton();
            this.WarlockRadio = new System.Windows.Forms.RadioButton();
            this.HunterRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Okbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitanRadio
            // 
            this.TitanRadio.AutoCheck = false;
            this.TitanRadio.AutoSize = true;
            this.TitanRadio.Location = new System.Drawing.Point(103, 47);
            this.TitanRadio.Name = "TitanRadio";
            this.TitanRadio.Size = new System.Drawing.Size(49, 17);
            this.TitanRadio.TabIndex = 0;
            this.TitanRadio.TabStop = true;
            this.TitanRadio.Text = "Titan";
            this.TitanRadio.UseVisualStyleBackColor = true;
            this.TitanRadio.Click += new System.EventHandler(this.TitanRadio_Click);
            // 
            // WarlockRadio
            // 
            this.WarlockRadio.AutoCheck = false;
            this.WarlockRadio.AutoSize = true;
            this.WarlockRadio.Location = new System.Drawing.Point(103, 70);
            this.WarlockRadio.Name = "WarlockRadio";
            this.WarlockRadio.Size = new System.Drawing.Size(65, 17);
            this.WarlockRadio.TabIndex = 1;
            this.WarlockRadio.TabStop = true;
            this.WarlockRadio.Text = "Warlock";
            this.WarlockRadio.UseVisualStyleBackColor = true;
            this.WarlockRadio.Click += new System.EventHandler(this.WarlockRadio_Click);
            // 
            // HunterRadio
            // 
            this.HunterRadio.AutoCheck = false;
            this.HunterRadio.AutoSize = true;
            this.HunterRadio.Location = new System.Drawing.Point(103, 93);
            this.HunterRadio.Name = "HunterRadio";
            this.HunterRadio.Size = new System.Drawing.Size(57, 17);
            this.HunterRadio.TabIndex = 2;
            this.HunterRadio.TabStop = true;
            this.HunterRadio.Text = "Hunter";
            this.HunterRadio.UseVisualStyleBackColor = true;
            this.HunterRadio.Click += new System.EventHandler(this.HunterRadio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a Class";
            // 
            // Okbtn
            // 
            this.Okbtn.Location = new System.Drawing.Point(103, 116);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(75, 23);
            this.Okbtn.TabIndex = 4;
            this.Okbtn.Text = "Ok";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // SelectClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 145);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HunterRadio);
            this.Controls.Add(this.WarlockRadio);
            this.Controls.Add(this.TitanRadio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectClass";
            this.Text = "Class Selection";
            this.Load += new System.EventHandler(this.SelectClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton TitanRadio;
        private System.Windows.Forms.RadioButton WarlockRadio;
        private System.Windows.Forms.RadioButton HunterRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Okbtn;
    }
}