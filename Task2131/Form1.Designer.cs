
namespace Task2131
{
    partial class Form1
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
            this.editlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.acclabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ovalPictureBox1 = new Task2131.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // editlbl
            // 
            this.editlbl.AutoSize = true;
            this.editlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editlbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.editlbl.Location = new System.Drawing.Point(125, 28);
            this.editlbl.Name = "editlbl";
            this.editlbl.Size = new System.Drawing.Size(177, 20);
            this.editlbl.TabIndex = 1;
            this.editlbl.Text = "EDIT INFORMATION";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(305, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // acclabel
            // 
            this.acclabel.AutoSize = true;
            this.acclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acclabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.acclabel.Location = new System.Drawing.Point(93, 267);
            this.acclabel.Name = "acclabel";
            this.acclabel.Size = new System.Drawing.Size(172, 20);
            this.acclabel.TabIndex = 3;
            this.acclabel.Text = "Account Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(93, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(235, 348);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(261, 35);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OpenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenBtn.Location = new System.Drawing.Point(602, 309);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(103, 40);
            this.OpenBtn.TabIndex = 6;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = false;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(602, 377);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(103, 40);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Image = global::Task2131.Properties.Resources.default_profile_pic;
            this.ovalPictureBox1.Location = new System.Drawing.Point(146, 89);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(119, 115);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 8;
            this.ovalPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ovalPictureBox1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acclabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label editlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label acclabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button SaveBtn;
        private OvalPictureBox ovalPictureBox1;
    }
}

