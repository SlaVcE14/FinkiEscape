namespace FinkiEscapa
{
    partial class MainMenuScene
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
            this.playBtn = new System.Windows.Forms.Button();
            this.howToPlayBtn = new System.Windows.Forms.Button();
            this.creditsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playBtn.Location = new System.Drawing.Point(68, 188);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(276, 59);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "ИГРАЈ";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // howToPlayBtn
            // 
            this.howToPlayBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.howToPlayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.howToPlayBtn.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.howToPlayBtn.Location = new System.Drawing.Point(68, 301);
            this.howToPlayBtn.Name = "howToPlayBtn";
            this.howToPlayBtn.Size = new System.Drawing.Size(277, 64);
            this.howToPlayBtn.TabIndex = 1;
            this.howToPlayBtn.Text = "КАКО СЕ ИГРА?";
            this.howToPlayBtn.UseVisualStyleBackColor = false;
            this.howToPlayBtn.Click += new System.EventHandler(this.howToPlayBtn_Click);
            // 
            // creditsBtn
            // 
            this.creditsBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.creditsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditsBtn.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.creditsBtn.Location = new System.Drawing.Point(68, 422);
            this.creditsBtn.Name = "creditsBtn";
            this.creditsBtn.Size = new System.Drawing.Size(277, 64);
            this.creditsBtn.TabIndex = 2;
            this.creditsBtn.Text = "КРЕДИТИ";
            this.creditsBtn.UseVisualStyleBackColor = false;
            this.creditsBtn.Click += new System.EventHandler(this.creditsBtn_Click);
            // 
            // MainMenuScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::FinkiEscapa.Properties.Resources.mainMenuBg;
            this.Controls.Add(this.creditsBtn);
            this.Controls.Add(this.howToPlayBtn);
            this.Controls.Add(this.playBtn);
            this.Name = "MainMenuScene";
            this.Size = new System.Drawing.Size(1150, 660);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button howToPlayBtn;
        private System.Windows.Forms.Button creditsBtn;
    }
}
