namespace Catalog
{
    partial class Manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual));
            this.AuthorGroup = new System.Windows.Forms.GroupBox();
            this.ManualGroup = new System.Windows.Forms.GroupBox();
            this.AuthorPic = new System.Windows.Forms.PictureBox();
            this.AuthorText = new System.Windows.Forms.Label();
            this.ManualText = new System.Windows.Forms.Label();
            this.AuthorGroup.SuspendLayout();
            this.ManualGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorPic)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorGroup
            // 
            this.AuthorGroup.Controls.Add(this.AuthorText);
            this.AuthorGroup.Controls.Add(this.AuthorPic);
            this.AuthorGroup.Location = new System.Drawing.Point(13, 13);
            this.AuthorGroup.Name = "AuthorGroup";
            this.AuthorGroup.Size = new System.Drawing.Size(437, 232);
            this.AuthorGroup.TabIndex = 0;
            this.AuthorGroup.TabStop = false;
            this.AuthorGroup.Text = "Об авторе";
            // 
            // ManualGroup
            // 
            this.ManualGroup.Controls.Add(this.ManualText);
            this.ManualGroup.Location = new System.Drawing.Point(13, 251);
            this.ManualGroup.Name = "ManualGroup";
            this.ManualGroup.Size = new System.Drawing.Size(431, 171);
            this.ManualGroup.TabIndex = 1;
            this.ManualGroup.TabStop = false;
            this.ManualGroup.Text = "Инструкция";
            // 
            // AuthorPic
            // 
            this.AuthorPic.Image = global::Catalog.Properties.Resources.User;
            this.AuthorPic.Location = new System.Drawing.Point(6, 21);
            this.AuthorPic.Name = "AuthorPic";
            this.AuthorPic.Size = new System.Drawing.Size(191, 188);
            this.AuthorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AuthorPic.TabIndex = 0;
            this.AuthorPic.TabStop = false;
            // 
            // AuthorText
            // 
            this.AuthorText.AutoSize = true;
            this.AuthorText.Location = new System.Drawing.Point(203, 21);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(228, 102);
            this.AuthorText.TabIndex = 1;
            this.AuthorText.Text = "Держин Кирилл Викторович \r\nСтудент Национального \r\nАерокосмического Университета\r" +
    "\nим. М.Е Жуковского \"ХАИ\"\r\n\r\nk.derzhin@student.csn.khai.edu";
            // 
            // ManualText
            // 
            this.ManualText.AutoSize = true;
            this.ManualText.Location = new System.Drawing.Point(7, 22);
            this.ManualText.Name = "ManualText";
            this.ManualText.Size = new System.Drawing.Size(402, 136);
            this.ManualText.TabIndex = 0;
            this.ManualText.Text = resources.GetString("ManualText.Text");
            this.ManualText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 435);
            this.Controls.Add(this.ManualGroup);
            this.Controls.Add(this.AuthorGroup);
            this.Name = "Manual";
            this.Text = "Инструкция";
            this.AuthorGroup.ResumeLayout(false);
            this.AuthorGroup.PerformLayout();
            this.ManualGroup.ResumeLayout(false);
            this.ManualGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AuthorGroup;
        private System.Windows.Forms.PictureBox AuthorPic;
        private System.Windows.Forms.GroupBox ManualGroup;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.Label ManualText;
    }
}