namespace DestinyCompanion
{
    partial class DeleteChar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteChar));
            this.CharSlotLabel1 = new System.Windows.Forms.Label();
            this.CharSlotLabel2 = new System.Windows.Forms.Label();
            this.CharSlotLabel3 = new System.Windows.Forms.Label();
            this.CharLabel1 = new System.Windows.Forms.Label();
            this.CharLabel2 = new System.Windows.Forms.Label();
            this.CharLabel3 = new System.Windows.Forms.Label();
            this.DeleteSlot1 = new System.Windows.Forms.Button();
            this.DeleteSlot2 = new System.Windows.Forms.Button();
            this.DeleteSlot3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CharSlotLabel1
            // 
            this.CharSlotLabel1.AutoSize = true;
            this.CharSlotLabel1.Location = new System.Drawing.Point(12, 59);
            this.CharSlotLabel1.Name = "CharSlotLabel1";
            this.CharSlotLabel1.Size = new System.Drawing.Size(86, 13);
            this.CharSlotLabel1.TabIndex = 0;
            this.CharSlotLabel1.Text = "Character Slot 1:";
            // 
            // CharSlotLabel2
            // 
            this.CharSlotLabel2.AutoSize = true;
            this.CharSlotLabel2.Location = new System.Drawing.Point(12, 124);
            this.CharSlotLabel2.Name = "CharSlotLabel2";
            this.CharSlotLabel2.Size = new System.Drawing.Size(86, 13);
            this.CharSlotLabel2.TabIndex = 1;
            this.CharSlotLabel2.Text = "Character Slot 2:";
            // 
            // CharSlotLabel3
            // 
            this.CharSlotLabel3.AutoSize = true;
            this.CharSlotLabel3.Location = new System.Drawing.Point(12, 195);
            this.CharSlotLabel3.Name = "CharSlotLabel3";
            this.CharSlotLabel3.Size = new System.Drawing.Size(86, 13);
            this.CharSlotLabel3.TabIndex = 2;
            this.CharSlotLabel3.Text = "Character Slot 3:";
            // 
            // CharLabel1
            // 
            this.CharLabel1.AutoSize = true;
            this.CharLabel1.Location = new System.Drawing.Point(144, 59);
            this.CharLabel1.Name = "CharLabel1";
            this.CharLabel1.Size = new System.Drawing.Size(36, 13);
            this.CharLabel1.TabIndex = 3;
            this.CharLabel1.Text = "Empty";
            this.CharLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CharLabel2
            // 
            this.CharLabel2.AutoSize = true;
            this.CharLabel2.Location = new System.Drawing.Point(144, 124);
            this.CharLabel2.Name = "CharLabel2";
            this.CharLabel2.Size = new System.Drawing.Size(36, 13);
            this.CharLabel2.TabIndex = 4;
            this.CharLabel2.Text = "Empty";
            this.CharLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CharLabel3
            // 
            this.CharLabel3.AutoSize = true;
            this.CharLabel3.Location = new System.Drawing.Point(144, 190);
            this.CharLabel3.Name = "CharLabel3";
            this.CharLabel3.Size = new System.Drawing.Size(36, 13);
            this.CharLabel3.TabIndex = 5;
            this.CharLabel3.Text = "Empty";
            this.CharLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeleteSlot1
            // 
            this.DeleteSlot1.Location = new System.Drawing.Point(237, 59);
            this.DeleteSlot1.Name = "DeleteSlot1";
            this.DeleteSlot1.Size = new System.Drawing.Size(75, 23);
            this.DeleteSlot1.TabIndex = 6;
            this.DeleteSlot1.Text = "Delete";
            this.DeleteSlot1.UseVisualStyleBackColor = true;
            this.DeleteSlot1.Click += new System.EventHandler(this.DeleteSlot1_Click);
            // 
            // DeleteSlot2
            // 
            this.DeleteSlot2.Location = new System.Drawing.Point(237, 119);
            this.DeleteSlot2.Name = "DeleteSlot2";
            this.DeleteSlot2.Size = new System.Drawing.Size(75, 23);
            this.DeleteSlot2.TabIndex = 7;
            this.DeleteSlot2.Text = "Delete";
            this.DeleteSlot2.UseVisualStyleBackColor = true;
            this.DeleteSlot2.Click += new System.EventHandler(this.DeleteSlot2_Click);
            // 
            // DeleteSlot3
            // 
            this.DeleteSlot3.Location = new System.Drawing.Point(237, 185);
            this.DeleteSlot3.Name = "DeleteSlot3";
            this.DeleteSlot3.Size = new System.Drawing.Size(75, 23);
            this.DeleteSlot3.TabIndex = 8;
            this.DeleteSlot3.Text = "Delete";
            this.DeleteSlot3.UseVisualStyleBackColor = true;
            this.DeleteSlot3.Click += new System.EventHandler(this.DeleteSlot3_Click);
            // 
            // DeleteChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.DeleteSlot3);
            this.Controls.Add(this.DeleteSlot2);
            this.Controls.Add(this.DeleteSlot1);
            this.Controls.Add(this.CharLabel3);
            this.Controls.Add(this.CharLabel2);
            this.Controls.Add(this.CharLabel1);
            this.Controls.Add(this.CharSlotLabel3);
            this.Controls.Add(this.CharSlotLabel2);
            this.Controls.Add(this.CharSlotLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteChar";
            this.Text = "Delete Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CharSlotLabel1;
        private System.Windows.Forms.Label CharSlotLabel2;
        private System.Windows.Forms.Label CharSlotLabel3;
        private System.Windows.Forms.Label CharLabel1;
        private System.Windows.Forms.Label CharLabel2;
        private System.Windows.Forms.Label CharLabel3;
        private System.Windows.Forms.Button DeleteSlot1;
        private System.Windows.Forms.Button DeleteSlot2;
        private System.Windows.Forms.Button DeleteSlot3;
    }
}