namespace FinkiEscapa
{
    partial class Classroom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classroom));
            this.dialogText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcBtn = new System.Windows.Forms.PictureBox();
            this.dialogPanel = new System.Windows.Forms.Panel();
            this.soaceImg = new System.Windows.Forms.PictureBox();
            this.breakerBoxBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcBtn)).BeginInit();
            this.dialogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soaceImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogText
            // 
            this.dialogText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dialogText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dialogText.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogText.ForeColor = System.Drawing.SystemColors.Info;
            this.dialogText.Location = new System.Drawing.Point(0, 552);
            this.dialogText.Margin = new System.Windows.Forms.Padding(20);
            this.dialogText.Name = "dialogText";
            this.dialogText.Padding = new System.Windows.Forms.Padding(20);
            this.dialogText.Size = new System.Drawing.Size(1150, 108);
            this.dialogText.TabIndex = 0;
            this.dialogText.Text = "Dialog text";
            this.dialogText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dialogText.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcBtn
            // 
            this.pcBtn.BackColor = System.Drawing.Color.Transparent;
            this.pcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBtn.Location = new System.Drawing.Point(255, 240);
            this.pcBtn.Name = "pcBtn";
            this.pcBtn.Size = new System.Drawing.Size(142, 142);
            this.pcBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBtn.TabIndex = 4;
            this.pcBtn.TabStop = false;
            this.pcBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // dialogPanel
            // 
            this.dialogPanel.BackColor = System.Drawing.Color.Transparent;
            this.dialogPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dialogPanel.Controls.Add(this.soaceImg);
            this.dialogPanel.Controls.Add(this.dialogText);
            this.dialogPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dialogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogPanel.Location = new System.Drawing.Point(0, 0);
            this.dialogPanel.Name = "dialogPanel";
            this.dialogPanel.Size = new System.Drawing.Size(1150, 660);
            this.dialogPanel.TabIndex = 6;
            this.dialogPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick_1);
            // 
            // soaceImg
            // 
            this.soaceImg.BackColor = System.Drawing.Color.Transparent;
            this.soaceImg.Image = ((System.Drawing.Image)(resources.GetObject("soaceImg.Image")));
            this.soaceImg.Location = new System.Drawing.Point(960, 493);
            this.soaceImg.Name = "soaceImg";
            this.soaceImg.Size = new System.Drawing.Size(165, 49);
            this.soaceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.soaceImg.TabIndex = 2;
            this.soaceImg.TabStop = false;
            // 
            // breakerBoxBtn
            // 
            this.breakerBoxBtn.BackColor = System.Drawing.Color.Transparent;
            this.breakerBoxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.breakerBoxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.breakerBoxBtn.Location = new System.Drawing.Point(1064, 120);
            this.breakerBoxBtn.Name = "breakerBoxBtn";
            this.breakerBoxBtn.Size = new System.Drawing.Size(86, 230);
            this.breakerBoxBtn.TabIndex = 3;
            this.breakerBoxBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // Classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinkiEscapa.Properties.Resources.classroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dialogPanel);
            this.Controls.Add(this.breakerBoxBtn);
            this.Controls.Add(this.pcBtn);
            this.DoubleBuffered = true;
            this.Name = "Classroom";
            this.Size = new System.Drawing.Size(1150, 660);
            ((System.ComponentModel.ISupportInitialize)(this.pcBtn)).EndInit();
            this.dialogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soaceImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label dialogText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcBtn;
        private System.Windows.Forms.Panel dialogPanel;
        private System.Windows.Forms.PictureBox soaceImg;
        private System.Windows.Forms.Label breakerBoxBtn;
    }
}
