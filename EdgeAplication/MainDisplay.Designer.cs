namespace EdgeAplication
{
    partial class MainPanel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadImgButton = new System.Windows.Forms.Button();
            this.applyEdgeButton = new System.Windows.Forms.Button();
            this.saveImgButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.msgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadImgButton
            // 
            this.loadImgButton.Location = new System.Drawing.Point(12, 546);
            this.loadImgButton.Name = "loadImgButton";
            this.loadImgButton.Size = new System.Drawing.Size(106, 33);
            this.loadImgButton.TabIndex = 0;
            this.loadImgButton.Text = "Load img";
            this.loadImgButton.UseVisualStyleBackColor = true;
            this.loadImgButton.Click += new System.EventHandler(this.loadImgButton_Click);
            // 
            // applyEdgeButton
            // 
            this.applyEdgeButton.Location = new System.Drawing.Point(199, 546);
            this.applyEdgeButton.Name = "applyEdgeButton";
            this.applyEdgeButton.Size = new System.Drawing.Size(106, 33);
            this.applyEdgeButton.TabIndex = 1;
            this.applyEdgeButton.Text = "Apply Edge";
            this.applyEdgeButton.UseVisualStyleBackColor = true;
            this.applyEdgeButton.Click += new System.EventHandler(this.applyEdgeButton_Click);
            // 
            // saveImgButton
            // 
            this.saveImgButton.Location = new System.Drawing.Point(384, 546);
            this.saveImgButton.Name = "saveImgButton";
            this.saveImgButton.Size = new System.Drawing.Size(106, 33);
            this.saveImgButton.TabIndex = 2;
            this.saveImgButton.Text = "Save modified img";
            this.saveImgButton.UseVisualStyleBackColor = true;
            this.saveImgButton.Click += new System.EventHandler(this.saveImgButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(478, 512);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.msgLabel.Location = new System.Drawing.Point(253, 527);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(7, 13);
            this.msgLabel.TabIndex = 4;
            this.msgLabel.Text = "\r\n";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 600);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.saveImgButton);
            this.Controls.Add(this.applyEdgeButton);
            this.Controls.Add(this.loadImgButton);
            this.Name = "MainPanel";
            this.Text = "Edge Applier";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadImgButton;
        private System.Windows.Forms.Button applyEdgeButton;
        private System.Windows.Forms.Button saveImgButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label msgLabel;
    }
}

