namespace FinkiEscapa
{
    partial class Exit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backBtn = new System.Windows.Forms.Button();
            this.keypadBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.keypadBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backBtn.Location = new System.Drawing.Point(24, 588);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(144, 57);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // keypadBtn
            // 
            this.keypadBtn.BackColor = System.Drawing.Color.Transparent;
            this.keypadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keypadBtn.Location = new System.Drawing.Point(263, 249);
            this.keypadBtn.Name = "keypadBtn";
            this.keypadBtn.Size = new System.Drawing.Size(134, 191);
            this.keypadBtn.TabIndex = 4;
            this.keypadBtn.TabStop = false;
            this.keypadBtn.Click += new System.EventHandler(this.keypadBtn_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinkiEscapa.Properties.Resources.ExitDoor;
            this.Controls.Add(this.keypadBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "Exit";
            this.Size = new System.Drawing.Size(1150, 660);
            ((System.ComponentModel.ISupportInitialize)(this.keypadBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox keypadBtn;
    }
}
